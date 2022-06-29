// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract class CommandLineArguments
    {
        internal bool IsScriptRunner { get; set; }

        public bool InteractiveMode { get; internal set; }

        public string? BaseDirectory { get; internal set; }

        public ImmutableArray<KeyValuePair<string, string>> PathMap { get; internal set; }

        public ImmutableArray<string> ReferencePaths { get; internal set; }

        public ImmutableArray<string> SourcePaths { get; internal set; }

        public ImmutableArray<string> KeyFileSearchPaths { get; internal set; }

        public bool Utf8Output { get; internal set; }

        public string? CompilationName { get; internal set; }

        public EmitOptions EmitOptions { get; internal set; }

        public string? OutputFileName { get; internal set; }

        public string? OutputRefFilePath { get; internal set; }

        public string? PdbPath { get; internal set; }

        public string? SourceLink { get; internal set; }

        public string? RuleSetPath { get; internal set; }

        public bool EmitPdb { get; internal set; }

        public string OutputDirectory { get; internal set; }

        public string? DocumentationPath { get; internal set; }

        public string? GeneratedFilesOutputDirectory { get; internal set; }

        public ErrorLogOptions? ErrorLogOptions { get; internal set; }

        public string? ErrorLogPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 5860, 5884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 5863, 5884);
                    return f_122_5863_5884_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_122_5863_5878(), 122, 5863, 5884)?.Path); DynAbs.Tracing.TraceSender.TraceExitMethod(122, 5860, 5884);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 5860, 5884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 5860, 5884);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string? AppConfigPath { get; internal set; }

        public ImmutableArray<Diagnostic> Errors { get; internal set; }

        public ImmutableArray<CommandLineReference> MetadataReferences { get; internal set; }

        public ImmutableArray<CommandLineAnalyzerReference> AnalyzerReferences { get; internal set; }

        public ImmutableArray<string> AnalyzerConfigPaths { get; internal set; }

        public ImmutableArray<CommandLineSourceFile> AdditionalFiles { get; internal set; }

        public ImmutableArray<CommandLineSourceFile> EmbeddedFiles { get; internal set; }

        public bool ReportAnalyzer { get; internal set; }

        public bool SkipAnalyzers { get; internal set; }

        public bool DisplayLogo { get; internal set; }

        public bool DisplayHelp { get; internal set; }

        public bool DisplayVersion { get; internal set; }

        public bool DisplayLangVersions { get; internal set; }

        public string? Win32ResourceFile { get; internal set; }

        public string? Win32Icon { get; internal set; }

        public string? Win32Manifest { get; internal set; }

        public bool NoWin32Manifest { get; internal set; }

        public ImmutableArray<ResourceDescription> ManifestResources { get; internal set; }

        public Encoding? Encoding { get; internal set; }

        public SourceHashAlgorithm ChecksumAlgorithm { get; internal set; }

        public ImmutableArray<string> ScriptArguments { get; internal set; }

        public ImmutableArray<CommandLineSourceFile> SourceFiles { get; internal set; }

        public string? TouchedFilesPath { get; internal set; }

        public bool PrintFullPaths { get; internal set; }

        public ParseOptions ParseOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 11715, 11747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 11721, 11745);

                    return f_122_11728_11744();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(122, 11715, 11747);

                    Microsoft.CodeAnalysis.ParseOptions
                    f_122_11728_11744()
                    {
                        var return_v = ParseOptionsCore;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 11728, 11744);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 11658, 11758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 11658, 11758);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CompilationOptions CompilationOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 11941, 11979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 11947, 11977);

                    return f_122_11954_11976();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(122, 11941, 11979);

                    Microsoft.CodeAnalysis.CompilationOptions
                    f_122_11954_11976()
                    {
                        var return_v = CompilationOptionsCore;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 11954, 11976);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 11872, 11990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 11872, 11990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract ParseOptions ParseOptionsCore { get; }

        protected abstract CompilationOptions CompilationOptionsCore { get; }

        public CultureInfo? PreferredUILang { get; internal set; }

        internal StrongNameProvider GetStrongNameProvider(StrongNameFileSystem fileSystem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 12420, 12484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 12423, 12484);
                return f_122_12423_12484(f_122_12453_12471(), fileSystem); DynAbs.Tracing.TraceSender.TraceExitMethod(122, 12420, 12484);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 12420, 12484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 12420, 12484);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<string>
            f_122_12453_12471()
            {
                var return_v = KeyFileSearchPaths;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 12453, 12471);
                return return_v;
            }


            Microsoft.CodeAnalysis.DesktopStrongNameProvider
            f_122_12423_12484(System.Collections.Immutable.ImmutableArray<string>
            keyFileSearchPaths, Microsoft.CodeAnalysis.StrongNameFileSystem
            strongNameFileSystem)
            {
                var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider(keyFileSearchPaths, strongNameFileSystem);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 12423, 12484);
                return return_v;
            }

        }

        internal CommandLineArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(122, 12497, 12550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 823, 865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 1047, 1097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 1562, 1613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 3007, 3052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 3167, 3220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 3315, 3377);
                this.EmitOptions = null!; DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 3523, 3575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 3705, 3760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 3912, 3957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 4195, 4243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 4376, 4425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 4583, 4625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 4787, 4848);
                this.OutputDirectory = null!; DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 5022, 5077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 5257, 5324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 5547, 5609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 6023, 6074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 7556, 7605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 7726, 7774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 7947, 7993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 8156, 8202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 8364, 8413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 8596, 8650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 8752, 8807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 8909, 8956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 9131, 9182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 9402, 9452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 9803, 9851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 10004, 10071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 11229, 11283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 11456, 11505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 12254, 12312);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(122, 12497, 12550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 12497, 12550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 12497, 12550);
            }
        }

        public string GetOutputFilePath(string outputFileName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 13176, 13466);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 13255, 13386) || true) && (outputFileName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 13255, 13386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 13315, 13371);

                    throw f_122_13321_13370(nameof(outputFileName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(122, 13255, 13386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 13402, 13455);

                return f_122_13409_13454(f_122_13422_13437(), outputFileName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 13176, 13466);

                System.ArgumentNullException
                f_122_13321_13370(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 13321, 13370);
                    return return_v;
                }


                string
                f_122_13422_13437()
                {
                    var return_v = OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 13422, 13437);
                    return return_v;
                }


                string
                f_122_13409_13454(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 13409, 13454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 13176, 13466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 13176, 13466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetPdbFilePath(string outputFileName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 14157, 14485);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 14233, 14364) || true) && (outputFileName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 14233, 14364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 14293, 14349);

                    throw f_122_14299_14348(nameof(outputFileName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(122, 14233, 14364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 14380, 14474);

                return f_122_14387_14394() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(122, 14387, 14473) ?? f_122_14398_14473(f_122_14411_14426(), f_122_14428_14472(outputFileName, ".pdb")));
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 14157, 14485);

                System.ArgumentNullException
                f_122_14299_14348(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 14299, 14348);
                    return return_v;
                }


                string?
                f_122_14387_14394()
                {
                    var return_v = PdbPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 14387, 14394);
                    return return_v;
                }


                string
                f_122_14411_14426()
                {
                    var return_v = OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 14411, 14426);
                    return return_v;
                }


                string?
                f_122_14428_14472(string
                path, string
                extension)
                {
                    var return_v = Path.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 14428, 14472);
                    return return_v;
                }


                string
                f_122_14398_14473(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 14398, 14473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 14157, 14485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 14157, 14485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool EmitPdbFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 14716, 14799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 14719, 14799);
                    return f_122_14719_14726() && (DynAbs.Tracing.TraceSender.Expression_True(122, 14719, 14799) && f_122_14730_14764(f_122_14730_14741()) != DebugInformationFormat.Embedded); DynAbs.Tracing.TraceSender.TraceExitMethod(122, 14716, 14799);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 14716, 14799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 14716, 14799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<MetadataReference> ResolveMetadataReferences(MetadataReferenceResolver metadataResolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 15403, 15796);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 15535, 15670) || true) && (metadataResolver == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 15535, 15670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 15597, 15655);

                    throw f_122_15603_15654(nameof(metadataResolver));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(122, 15535, 15670);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 15686, 15785);

                return f_122_15693_15784(this, metadataResolver, diagnosticsOpt: null, messageProviderOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 15403, 15796);

                System.ArgumentNullException
                f_122_15603_15654(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 15603, 15654);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_122_15693_15784(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver
                metadataResolver, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>?
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider?
                messageProviderOpt)
                {
                    var return_v = this_param.ResolveMetadataReferences(metadataResolver, diagnosticsOpt: diagnosticsOpt, messageProviderOpt: messageProviderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 15693, 15784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 15403, 15796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 15403, 15796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<MetadataReference> ResolveMetadataReferences(MetadataReferenceResolver metadataResolver, List<DiagnosticInfo>? diagnosticsOpt, CommonMessageProvider? messageProviderOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 16427, 16900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 16642, 16687);

                f_122_16642_16686(metadataResolver != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 16703, 16748);

                var
                resolved = f_122_16718_16747()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 16762, 16857);

                f_122_16762_16856(this, metadataResolver, diagnosticsOpt, messageProviderOpt, resolved);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 16873, 16889);

                return resolved;
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 16427, 16900);

                int
                f_122_16642_16686(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 16642, 16686);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                f_122_16718_16747()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 16718, 16747);
                    return return_v;
                }


                bool
                f_122_16762_16856(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver
                metadataResolver, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>?
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider?
                messageProviderOpt, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                resolved)
                {
                    var return_v = this_param.ResolveMetadataReferences(metadataResolver, diagnosticsOpt, messageProviderOpt, resolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 16762, 16856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 16427, 16900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 16427, 16900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool ResolveMetadataReferences(MetadataReferenceResolver metadataResolver, List<DiagnosticInfo>? diagnosticsOpt, CommonMessageProvider? messageProviderOpt, List<MetadataReference> resolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 16912, 17978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17143, 17162);

                bool
                result = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17178, 17937);
                    foreach (CommandLineReference cmdReference in f_122_17224_17242_I(f_122_17224_17242()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 17178, 17937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17276, 17386);

                        var
                        references = f_122_17293_17385(cmdReference, metadataResolver, diagnosticsOpt, messageProviderOpt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17404, 17922) || true) && (f_122_17408_17436_M(!references.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 17404, 17922);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17478, 17508);

                            f_122_17478_17507(resolved, references);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(122, 17404, 17922);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 17404, 17922);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17590, 17605);

                            result = false;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17627, 17903) || true) && (diagnosticsOpt == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 17627, 17903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17785, 17880);

                                f_122_17785_17879(                        // no diagnostic, so leaved unresolved reference in list
                                                        resolved, f_122_17798_17878(cmdReference.Reference, cmdReference.Properties));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(122, 17627, 17903);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(122, 17404, 17922);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(122, 17178, 17937);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(122, 1, 760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(122, 1, 760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 17953, 17967);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 16912, 17978);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineReference>
                f_122_17224_17242()
                {
                    var return_v = MetadataReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 17224, 17242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PortableExecutableReference>
                f_122_17293_17385(Microsoft.CodeAnalysis.CommandLineReference
                cmdReference, Microsoft.CodeAnalysis.MetadataReferenceResolver
                metadataResolver, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>?
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider?
                messageProviderOpt)
                {
                    var return_v = ResolveMetadataReference(cmdReference, metadataResolver, diagnosticsOpt, messageProviderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 17293, 17385);
                    return return_v;
                }


                bool
                f_122_17408_17436_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 17408, 17436);
                    return return_v;
                }


                int
                f_122_17478_17507(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PortableExecutableReference>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 17478, 17507);
                    return 0;
                }


                Microsoft.CodeAnalysis.UnresolvedMetadataReference
                f_122_17798_17878(string
                reference, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.UnresolvedMetadataReference(reference, properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 17798, 17878);
                    return return_v;
                }


                int
                f_122_17785_17879(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.UnresolvedMetadataReference
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.MetadataReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 17785, 17879);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineReference>
                f_122_17224_17242_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 17224, 17242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 16912, 17978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 16912, 17978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<PortableExecutableReference> ResolveMetadataReference(CommandLineReference cmdReference, MetadataReferenceResolver metadataResolver, List<DiagnosticInfo>? diagnosticsOpt, CommonMessageProvider? messageProviderOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(122, 17990, 19563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 18259, 18304);

                f_122_18259_18303(metadataResolver != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 18318, 18389);

                f_122_18318_18388((diagnosticsOpt == null) == (messageProviderOpt == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 18405, 18460);

                ImmutableArray<PortableExecutableReference>
                references
                = default(ImmutableArray<PortableExecutableReference>);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 18510, 18638);

                    references = f_122_18523_18637(metadataResolver, cmdReference.Reference, baseFilePath: null, properties: cmdReference.Properties);
                }
                catch (Exception e) when (diagnosticsOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(122, 18693, 18769) && (e is BadImageFormatException || (DynAbs.Tracing.TraceSender.Expression_False(122, 18720, 18768) || e is IOException))))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(122, 18667, 19129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 18803, 18963);

                    var
                    diagnostic = f_122_18820_18962(e, messageProviderOpt!, f_122_18894_18907(), cmdReference.Reference, cmdReference.Properties.Kind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 18981, 19039);

                    f_122_18981_19038(diagnosticsOpt, f_122_19000_19037(((DiagnosticWithInfo)diagnostic)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 19057, 19114);

                    return ImmutableArray<PortableExecutableReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(122, 18667, 19129);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 19145, 19518) || true) && (references.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(122, 19149, 19202) && diagnosticsOpt != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 19145, 19518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 19236, 19282);

                    f_122_19236_19281(messageProviderOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 19300, 19428);

                    f_122_19300_19427(diagnosticsOpt, f_122_19319_19426(messageProviderOpt, f_122_19358_19401(messageProviderOpt), cmdReference.Reference));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 19446, 19503);

                    return ImmutableArray<PortableExecutableReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(122, 19145, 19518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 19534, 19552);

                return references;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(122, 17990, 19563);

                int
                f_122_18259_18303(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 18259, 18303);
                    return 0;
                }


                int
                f_122_18318_18388(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 18318, 18388);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PortableExecutableReference>
                f_122_18523_18637(Microsoft.CodeAnalysis.MetadataReferenceResolver
                this_param, string
                reference, string?
                baseFilePath, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.ResolveReference(reference, baseFilePath: baseFilePath, properties: properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 18523, 18637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_122_18894_18907()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 18894, 18907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_122_18820_18962(System.Exception
                e, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.Location
                location, string
                display, Microsoft.CodeAnalysis.MetadataImageKind
                kind)
                {
                    var return_v = PortableExecutableReference.ExceptionToDiagnostic(e, messageProvider, location, display, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 18820, 18962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_122_19000_19037(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 19000, 19037);
                    return return_v;
                }


                int
                f_122_18981_19038(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 18981, 19038);
                    return 0;
                }


                int
                f_122_19236_19281(Microsoft.CodeAnalysis.CommonMessageProvider?
                value)
                {
                    RoslynDebug.AssertNotNull(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 19236, 19281);
                    return 0;
                }


                int
                f_122_19358_19401(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataFileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 19358, 19401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_122_19319_19426(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 19319, 19426);
                    return return_v;
                }


                int
                f_122_19300_19427(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 19300, 19427);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 17990, 19563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 17990, 19563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<AnalyzerReference> ResolveAnalyzerReferences(IAnalyzerAssemblyLoader analyzerLoader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 20009, 20447);

                var listYield = new List<AnalyzerReference>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 20137, 20436);
                    foreach (CommandLineAnalyzerReference cmdLineReference in f_122_20195_20213_I(f_122_20195_20213()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 20137, 20436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 20247, 20421);

                        listYield.Add(f_122_20260_20318(this, cmdLineReference, analyzerLoader) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference?>(122, 20260, 20420) ?? (AnalyzerReference)f_122_20362_20420(cmdLineReference.FilePath)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(122, 20137, 20436);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(122, 1, 300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(122, 1, 300);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 20009, 20447);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                f_122_20195_20213()
                {
                    var return_v = AnalyzerReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 20195, 20213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference?
                f_122_20260_20318(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, Microsoft.CodeAnalysis.CommandLineAnalyzerReference
                reference, Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                analyzerLoader)
                {
                    var return_v = this_param.ResolveAnalyzerReference(reference, analyzerLoader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 20260, 20318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.UnresolvedAnalyzerReference
                f_122_20362_20420(string
                unresolvedPath)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.UnresolvedAnalyzerReference(unresolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 20362, 20420);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                f_122_20195_20213_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 20195, 20213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 20009, 20447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 20009, 20447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ResolveAnalyzersFromArguments(
                    string language,
                    List<DiagnosticInfo> diagnostics,
                    CommonMessageProvider messageProvider,
                    IAnalyzerAssemblyLoader analyzerLoader,
                    bool skipAnalyzers,
                    out ImmutableArray<DiagnosticAnalyzer> analyzers,
                    out ImmutableArray<ISourceGenerator> generators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 20459, 24515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 20868, 20941);

                var
                analyzerBuilder = f_122_20890_20940()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 20955, 21027);

                var
                generatorBuilder = f_122_20978_21026()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 21043, 23042);

                EventHandler<AnalyzerLoadFailureEventArgs>
                errorHandler = (o, e) =>
                            {
                                var analyzerReference = o as AnalyzerFileReference;
                                RoslynDebug.Assert(analyzerReference is object);
                                DiagnosticInfo? diagnostic;
                                switch (e.ErrorCode)
                                {
                                    case AnalyzerLoadFailureEventArgs.FailureErrorCode.UnableToLoadAnalyzer:
                                        diagnostic = new DiagnosticInfo(messageProvider, messageProvider.WRN_UnableToLoadAnalyzer, analyzerReference.FullPath, e.Message);
                                        break;
                                    case AnalyzerLoadFailureEventArgs.FailureErrorCode.UnableToCreateAnalyzer:
                                        diagnostic = new DiagnosticInfo(messageProvider, messageProvider.WRN_AnalyzerCannotBeCreated, e.TypeName ?? "", analyzerReference.FullPath, e.Message);
                                        break;
                                    case AnalyzerLoadFailureEventArgs.FailureErrorCode.NoAnalyzers:
                                        diagnostic = new DiagnosticInfo(messageProvider, messageProvider.WRN_NoAnalyzerInAssembly, analyzerReference.FullPath);
                                        break;
                                    case AnalyzerLoadFailureEventArgs.FailureErrorCode.ReferencesFramework:
                                        diagnostic = new DiagnosticInfo(messageProvider, messageProvider.WRN_AnalyzerReferencesFramework, analyzerReference.FullPath, e.TypeName!);
                                        break;
                                    case AnalyzerLoadFailureEventArgs.FailureErrorCode.None:
                                    default:
                                        return;
                                }

                // Filter this diagnostic based on the compilation options so that /nowarn and /warnaserror etc. take effect.
                diagnostic = messageProvider.FilterDiagnosticInfo(diagnostic, this.CompilationOptions);

                                if (diagnostic != null)
                                {
                                    diagnostics.Add(diagnostic);
                                }
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23058, 23133);

                var
                resolvedReferences = f_122_23083_23132()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23147, 23823);
                    foreach (var reference in f_122_23173_23191_I(f_122_23173_23191()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 23147, 23823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23225, 23301);

                        var
                        resolvedReference = f_122_23249_23300(this, reference, analyzerLoader)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23319, 23808) || true) && (resolvedReference != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 23319, 23808);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23390, 23432);

                            f_122_23390_23431(resolvedReferences, resolvedReference);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23527, 23592);

                            f_122_23527_23591(
                                                // register the reference to the analyzer loader:
                                                analyzerLoader, f_122_23564_23590(resolvedReference));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(122, 23319, 23808);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 23319, 23808);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23674, 23789);

                            f_122_23674_23788(diagnostics, f_122_23690_23787(messageProvider, f_122_23726_23766(messageProvider), reference.FilePath));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(122, 23319, 23808);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(122, 23147, 23823);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(122, 1, 677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(122, 1, 677);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 23926, 24346);
                    foreach (var resolvedReference in f_122_23960_23978_I(resolvedReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 23926, 24346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24012, 24065);

                        resolvedReference.AnalyzerLoadFailed += errorHandler;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24083, 24182) || true) && (!skipAnalyzers)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 24083, 24182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24124, 24182);

                            f_122_24124_24181(resolvedReference, analyzerBuilder, language);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(122, 24083, 24182);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24200, 24260);

                        f_122_24200_24259(resolvedReference, generatorBuilder, language);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24278, 24331);

                        resolvedReference.AnalyzerLoadFailed -= errorHandler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(122, 23926, 24346);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(122, 1, 421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(122, 1, 421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24362, 24388);

                f_122_24362_24387(
                            resolvedReferences);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24404, 24448);

                generators = f_122_24417_24447(generatorBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24462, 24504);

                analyzers = f_122_24474_24503(analyzerBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 20459, 24515);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                f_122_20890_20940()
                {
                    var return_v = ImmutableArray.CreateBuilder<DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 20890, 20940);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>.Builder
                f_122_20978_21026()
                {
                    var return_v = ImmutableArray.CreateBuilder<ISourceGenerator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 20978, 21026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference>
                f_122_23083_23132()
                {
                    var return_v = ArrayBuilder<AnalyzerFileReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23083, 23132);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                f_122_23173_23191()
                {
                    var return_v = AnalyzerReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 23173, 23191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference?
                f_122_23249_23300(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, Microsoft.CodeAnalysis.CommandLineAnalyzerReference
                reference, Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                analyzerLoader)
                {
                    var return_v = this_param.ResolveAnalyzerReference(reference, analyzerLoader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23249, 23300);
                    return return_v;
                }


                int
                f_122_23390_23431(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23390, 23431);
                    return 0;
                }


                string
                f_122_23564_23590(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 23564, 23590);
                    return return_v;
                }


                int
                f_122_23527_23591(Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    this_param.AddDependencyLocation(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23527, 23591);
                    return 0;
                }


                int
                f_122_23726_23766(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataFileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 23726, 23766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_122_23690_23787(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23690, 23787);
                    return return_v;
                }


                int
                f_122_23674_23788(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23674, 23788);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                f_122_23173_23191_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23173, 23191);
                    return return_v;
                }


                int
                f_122_24124_24181(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                builder, string
                language)
                {
                    this_param.AddAnalyzers(builder, language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 24124, 24181);
                    return 0;
                }


                int
                f_122_24200_24259(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>.Builder
                builder, string
                language)
                {
                    this_param.AddGenerators(builder, language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 24200, 24259);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference>
                f_122_23960_23978_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 23960, 23978);
                    return return_v;
                }


                int
                f_122_24362_24387(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 24362, 24387);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                f_122_24417_24447(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 24417, 24447);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_122_24474_24503(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 24474, 24503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 20459, 24515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 20459, 24515);
            }
        }

        private AnalyzerFileReference? ResolveAnalyzerReference(CommandLineAnalyzerReference reference, IAnalyzerAssemblyLoader analyzerLoader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(122, 24527, 25210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24687, 24864);

                string?
                resolvedPath = f_122_24710_24863(reference.FilePath, basePath: null, baseDirectory: f_122_24795_24808(), searchPaths: f_122_24823_24837(), fileExists: File.Exists)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24878, 25019) || true) && (resolvedPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 24878, 25019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 24936, 25004);

                    resolvedPath = f_122_24951_25003(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(122, 24878, 25019);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 25035, 25171) || true) && (resolvedPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(122, 25035, 25171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 25093, 25156);

                    return f_122_25100_25155(resolvedPath, analyzerLoader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(122, 25035, 25171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(122, 25187, 25199);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(122, 24527, 25210);

                string?
                f_122_24795_24808()
                {
                    var return_v = BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 24795, 24808);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_122_24823_24837()
                {
                    var return_v = ReferencePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 24823, 24837);
                    return return_v;
                }


                string?
                f_122_24710_24863(string
                path, string?
                basePath, string?
                baseDirectory, System.Collections.Immutable.ImmutableArray<string>
                searchPaths, System.Func<string, bool>
                fileExists)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, basePath: basePath, baseDirectory: baseDirectory, searchPaths: (System.Collections.Generic.IEnumerable<string>)searchPaths, fileExists: fileExists);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 24710, 24863);
                    return return_v;
                }


                string?
                f_122_24951_25003(string
                path)
                {
                    var return_v = FileUtilities.TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 24951, 25003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                f_122_25100_25155(string
                fullPath, Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                assemblyLoader)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference(fullPath, assemblyLoader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 25100, 25155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122, 24527, 25210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 24527, 25210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandLineArguments()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(122, 764, 25237);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(122, 764, 25237);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122, 764, 25237);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(122, 764, 25237);

        Microsoft.CodeAnalysis.ErrorLogOptions?
        f_122_5863_5878()
        {
            var return_v = ErrorLogOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 5863, 5878);
            return return_v;
        }


        string?
        f_122_5863_5884_M(string?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 5863, 5884);
            return return_v;
        }


        bool
        f_122_14719_14726()
        {
            var return_v = EmitPdb;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 14719, 14726);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.EmitOptions
        f_122_14730_14741()
        {
            var return_v = EmitOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 14730, 14741);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.DebugInformationFormat
        f_122_14730_14764(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.DebugInformationFormat;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 14730, 14764);
            return return_v;
        }

    }
}
