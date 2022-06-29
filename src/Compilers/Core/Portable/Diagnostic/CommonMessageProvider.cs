// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Globalization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract class CommonMessageProvider
    {
        private static readonly ConcurrentDictionary<(string prefix, int code), string> s_errorIdCache;

        public abstract DiagnosticSeverity GetSeverity(int code);

        public abstract string LoadMessage(int code, CultureInfo? language);

        public abstract LocalizableString GetTitle(int code);

        public abstract LocalizableString GetDescription(int code);

        public abstract LocalizableString GetMessageFormat(int code);

        public abstract string GetHelpLink(int code);

        public abstract string GetCategory(int code);

        public abstract string CodePrefix { get; }

        public abstract int GetWarningLevel(int code);

        public abstract Type ErrorCodeType { get; }

        public Diagnostic CreateDiagnostic(int code, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(178, 3227, 3389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 3315, 3378);

                return f_178_3322_3377(this, code, location, f_178_3355_3376());
                DynAbs.Tracing.TraceSender.TraceExitMethod(178, 3227, 3389);

                object[]
                f_178_3355_3376()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 3355, 3376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_178_3322_3377(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 3322, 3377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(178, 3227, 3389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(178, 3227, 3389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract Diagnostic CreateDiagnostic(DiagnosticInfo info);

        public abstract Diagnostic CreateDiagnostic(int code, Location location, params object[] args);

        public abstract string GetMessagePrefix(string id, DiagnosticSeverity severity, bool isWarningAsError, CultureInfo? culture);

        public abstract string GetErrorDisplayString(ISymbol symbol);

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/31964",
                    AllowCaptures = false,
                    Constraint = "Frequently called by error list filtering; avoid allocations")]
        public string GetIdForErrorCode(int errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(178, 4582, 4988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 4874, 4977);

                return f_178_4881_4976(s_errorIdCache, (f_178_4906_4916(), errorCode), key => key.prefix + key.code.ToString("0000"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(178, 4582, 4988);

                string
                f_178_4906_4916()
                {
                    var return_v = CodePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(178, 4906, 4916);
                    return return_v;
                }


                string
                f_178_4881_4976(System.Collections.Concurrent.ConcurrentDictionary<(string prefix, int code), string>
                this_param, (string CodePrefix, int errorCode)
                key, System.Func<(string prefix, int code), string>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(((string prefix, int code))key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 4881, 4976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(178, 4582, 4988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(178, 4582, 4988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ReportDiagnostic GetDiagnosticReport(DiagnosticInfo diagnosticInfo, CompilationOptions options);

        public DiagnosticInfo? FilterDiagnosticInfo(DiagnosticInfo diagnosticInfo, CompilationOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(178, 5784, 6758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 5911, 5974);

                var
                report = f_178_5924_5973(this, diagnosticInfo, options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 5988, 6747);

                switch (report)
                {

                    case ReportDiagnostic.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(178, 5988, 6747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 6086, 6158);

                        return f_178_6093_6157(diagnosticInfo, DiagnosticSeverity.Error);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(178, 5988, 6747);

                    case ReportDiagnostic.Warn:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(178, 5988, 6747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 6225, 6299);

                        return f_178_6232_6298(diagnosticInfo, DiagnosticSeverity.Warning);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(178, 5988, 6747);

                    case ReportDiagnostic.Info:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(178, 5988, 6747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 6366, 6437);

                        return f_178_6373_6436(diagnosticInfo, DiagnosticSeverity.Info);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(178, 5988, 6747);

                    case ReportDiagnostic.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(178, 5988, 6747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 6506, 6579);

                        return f_178_6513_6578(diagnosticInfo, DiagnosticSeverity.Hidden);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(178, 5988, 6747);

                    case ReportDiagnostic.Suppress:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(178, 5988, 6747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 6650, 6662);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(178, 5988, 6747);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(178, 5988, 6747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 6710, 6732);

                        return diagnosticInfo;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(178, 5988, 6747);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(178, 5784, 6758);

                Microsoft.CodeAnalysis.ReportDiagnostic
                f_178_5924_5973(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo, Microsoft.CodeAnalysis.CompilationOptions
                options)
                {
                    var return_v = this_param.GetDiagnosticReport(diagnosticInfo, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 5924, 5973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_178_6093_6157(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.GetInstanceWithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 6093, 6157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_178_6232_6298(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.GetInstanceWithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 6232, 6298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_178_6373_6436(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.GetInstanceWithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 6373, 6436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_178_6513_6578(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.GetInstanceWithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 6513, 6578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(178, 5784, 6758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(178, 5784, 6758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract int ERR_FailedToCreateTempFile { get; }

        public abstract int ERR_MultipleAnalyzerConfigsInSameDir { get; }

        public abstract int ERR_ExpectedSingleScript { get; }

        public abstract int ERR_OpenResponseFile { get; }

        public abstract int ERR_InvalidPathMap { get; }

        public abstract int FTL_InvalidInputFileName { get; }

        public abstract int ERR_FileNotFound { get; }

        public abstract int ERR_NoSourceFile { get; }

        public abstract int ERR_CantOpenFileWrite { get; }

        public abstract int ERR_OutputWriteFailed { get; }

        public abstract int WRN_NoConfigNotOnCommandLine { get; }

        public abstract int ERR_BinaryFile { get; }

        public abstract int WRN_UnableToLoadAnalyzer { get; }

        public abstract int INF_UnableToLoadSomeTypesInAnalyzer { get; }

        public abstract int WRN_AnalyzerCannotBeCreated { get; }

        public abstract int WRN_NoAnalyzerInAssembly { get; }

        public abstract int WRN_AnalyzerReferencesFramework { get; }

        public abstract int ERR_CantReadRulesetFile { get; }

        public abstract int ERR_CompileCancelled { get; }

        public abstract int ERR_BadSourceCodeKind { get; }

        public abstract int ERR_BadDocumentationMode { get; }

        public abstract int ERR_BadCompilationOptionValue { get; }

        public abstract int ERR_MutuallyExclusiveOptions { get; }

        public abstract int ERR_InvalidDebugInformationFormat { get; }

        public abstract int ERR_InvalidFileAlignment { get; }

        public abstract int ERR_InvalidSubsystemVersion { get; }

        public abstract int ERR_InvalidOutputName { get; }

        public abstract int ERR_InvalidInstrumentationKind { get; }

        public abstract int ERR_InvalidHashAlgorithmName { get; }

        public abstract int ERR_MetadataFileNotAssembly { get; }

        public abstract int ERR_MetadataFileNotModule { get; }

        public abstract int ERR_InvalidAssemblyMetadata { get; }

        public abstract int ERR_InvalidModuleMetadata { get; }

        public abstract int ERR_ErrorOpeningAssemblyFile { get; }

        public abstract int ERR_ErrorOpeningModuleFile { get; }

        public abstract int ERR_MetadataFileNotFound { get; }

        public abstract int ERR_MetadataReferencesNotSupported { get; }

        public abstract int ERR_LinkedNetmoduleMetadataMustProvideFullPEImage { get; }

        public abstract void ReportDuplicateMetadataReferenceStrong(DiagnosticBag diagnostics, Location location, MetadataReference reference, AssemblyIdentity identity, MetadataReference equivalentReference, AssemblyIdentity equivalentIdentity);

        public abstract void ReportDuplicateMetadataReferenceWeak(DiagnosticBag diagnostics, Location location, MetadataReference reference, AssemblyIdentity identity, MetadataReference equivalentReference, AssemblyIdentity equivalentIdentity);

        public abstract int ERR_PublicKeyFileFailure { get; }

        public abstract int ERR_PublicKeyContainerFailure { get; }

        public abstract int ERR_OptionMustBeAbsolutePath { get; }

        public abstract int ERR_CantReadResource { get; }

        public abstract int ERR_CantOpenWin32Resource { get; }

        public abstract int ERR_CantOpenWin32Manifest { get; }

        public abstract int ERR_CantOpenWin32Icon { get; }

        public abstract int ERR_BadWin32Resource { get; }

        public abstract int ERR_ErrorBuildingWin32Resource { get; }

        public abstract int ERR_ResourceNotUnique { get; }

        public abstract int ERR_ResourceFileNameNotUnique { get; }

        public abstract int ERR_ResourceInModule { get; }

        public abstract int ERR_PermissionSetAttributeFileReadError { get; }

        public abstract int ERR_EncodinglessSyntaxTree { get; }

        public abstract int WRN_PdbUsingNameTooLong { get; }

        public abstract int WRN_PdbLocalNameTooLong { get; }

        public abstract int ERR_PdbWritingFailed { get; }

        public abstract int ERR_MetadataNameTooLong { get; }

        public abstract int ERR_EncReferenceToAddedMember { get; }

        public abstract int ERR_TooManyUserStrings { get; }

        public abstract int ERR_PeWritingFailure { get; }

        public abstract int ERR_ModuleEmitFailure { get; }

        public abstract int ERR_EncUpdateFailedMissingAttribute { get; }

        public abstract int ERR_InvalidDebugInfo { get; }

        public abstract int WRN_GeneratorFailedDuringInitialization { get; }

        public abstract int WRN_GeneratorFailedDuringGeneration { get; }

        public void ReportStreamWriteException(Exception e, string filePath, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(178, 11912, 12136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 12032, 12125);

                f_178_12032_12124(diagnostics, f_178_12048_12123(this, f_178_12065_12086(), f_178_12088_12101(), filePath, f_178_12113_12122(e)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(178, 11912, 12136);

                int
                f_178_12065_12086()
                {
                    var return_v = ERR_OutputWriteFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(178, 12065, 12086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_178_12088_12101()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(178, 12088, 12101);
                    return return_v;
                }


                string
                f_178_12113_12122(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(178, 12113, 12122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_178_12048_12123(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 12048, 12123);
                    return return_v;
                }


                int
                f_178_12032_12124(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 12032, 12124);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(178, 11912, 12136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(178, 11912, 12136);
            }
        }

        public abstract void ReportInvalidAttributeArgument(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int parameterIndex, AttributeData attribute);

        public abstract void ReportInvalidNamedArgument(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int namedArgumentIndex, ITypeSymbol attributeClass, string parameterName);

        public abstract void ReportParameterNotValidForType(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int namedArgumentIndex);

        public abstract void ReportMarshalUnmanagedTypeNotValidForFields(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int parameterIndex, string unmanagedTypeName, AttributeData attribute);

        public abstract void ReportMarshalUnmanagedTypeOnlyValidForFields(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int parameterIndex, string unmanagedTypeName, AttributeData attribute);

        public abstract void ReportAttributeParameterRequired(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, string parameterName);

        public abstract void ReportAttributeParameterRequired(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, string parameterName1, string parameterName2);

        public abstract int ERR_BadAssemblyName { get; }

        public CommonMessageProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(178, 548, 13408);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(178, 548, 13408);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(178, 548, 13408);
        }


        static CommonMessageProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(178, 548, 13408);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(178, 817, 895);
            s_errorIdCache = f_178_834_895(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(178, 548, 13408);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(178, 548, 13408);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(178, 548, 13408);

        static System.Collections.Concurrent.ConcurrentDictionary<(string prefix, int code), string>
        f_178_834_895()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<(string prefix, int code), string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(178, 834, 895);
            return return_v;
        }

    }
}
