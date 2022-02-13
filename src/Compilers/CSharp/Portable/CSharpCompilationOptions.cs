// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public sealed class CSharpCompilationOptions : CompilationOptions, IEquatable<CSharpCompilationOptions>
    {
        public bool AllowUnsafe { get; private set; }

        public ImmutableArray<string> Usings { get; private set; }

        internal BinderFlags TopLevelBinderFlags { get; private set; }

        public override NullableContextOptions NullableContextOptions { get; protected set; }

        public CSharpCompilationOptions(
                    OutputKind outputKind,
                    bool reportSuppressedDiagnostics = false,
                    string? moduleName = null,
                    string? mainTypeName = null,
                    string? scriptClassName = null,
                    IEnumerable<string>? usings = null,
                    OptimizationLevel optimizationLevel = OptimizationLevel.Debug,
                    bool checkOverflow = false,
                    bool allowUnsafe = false,
                    string? cryptoKeyContainer = null,
                    string? cryptoKeyFile = null,
                    ImmutableArray<byte> cryptoPublicKey = default,
                    bool? delaySign = null,
                    Platform platform = Platform.AnyCpu,
                    ReportDiagnostic generalDiagnosticOption = ReportDiagnostic.Default,
                    int warningLevel = Diagnostic.DefaultWarningLevel,
                    IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions = null,
                    bool concurrentBuild = true,
                    bool deterministic = false,
                    XmlReferenceResolver? xmlReferenceResolver = null,
                    SourceReferenceResolver? sourceReferenceResolver = null,
                    MetadataReferenceResolver? metadataReferenceResolver = null,
                    AssemblyIdentityComparer? assemblyIdentityComparer = null,
                    StrongNameProvider? strongNameProvider = null,
                    bool publicSign = false,
                    MetadataImportOptions metadataImportOptions = MetadataImportOptions.Public,
                    NullableContextOptions nullableContextOptions = NullableContextOptions.Disable)
        : this(f_10037_3501_3511_C(outputKind), reportSuppressedDiagnostics, moduleName, mainTypeName, scriptClassName, usings, optimizationLevel, checkOverflow, allowUnsafe, cryptoKeyContainer, cryptoKeyFile, cryptoPublicKey, delaySign, platform, generalDiagnosticOption, warningLevel, specificDiagnosticOptions, concurrentBuild, deterministic, currentLocalTime: default, debugPlusMode: false, xmlReferenceResolver: xmlReferenceResolver, sourceReferenceResolver: sourceReferenceResolver, syntaxTreeOptionsProvider: null, metadataReferenceResolver: metadataReferenceResolver, assemblyIdentityComparer: assemblyIdentityComparer, strongNameProvider: strongNameProvider, metadataImportOptions: metadataImportOptions, referencesSupersedeLowerVersions: false, publicSign: publicSign, topLevelBinderFlags: BinderFlags.None, nullableContextOptions: nullableContextOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 1897, 4692);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 1897, 4692);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 1897, 4692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 1897, 4692);
            }
        }

        public CSharpCompilationOptions(
                    OutputKind outputKind,
                    bool reportSuppressedDiagnostics,
                    string? moduleName,
                    string? mainTypeName,
                    string? scriptClassName,
                    IEnumerable<string>? usings,
                    OptimizationLevel optimizationLevel,
                    bool checkOverflow,
                    bool allowUnsafe,
                    string? cryptoKeyContainer,
                    string? cryptoKeyFile,
                    ImmutableArray<byte> cryptoPublicKey,
                    bool? delaySign,
                    Platform platform,
                    ReportDiagnostic generalDiagnosticOption,
                    int warningLevel,
                    IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions,
                    bool concurrentBuild,
                    bool deterministic,
                    XmlReferenceResolver? xmlReferenceResolver,
                    SourceReferenceResolver? sourceReferenceResolver,
                    MetadataReferenceResolver? metadataReferenceResolver,
                    AssemblyIdentityComparer? assemblyIdentityComparer,
                    StrongNameProvider? strongNameProvider,
                    bool publicSign,
                    MetadataImportOptions metadataImportOptions)
        : this(f_10037_5985_5995_C(outputKind), reportSuppressedDiagnostics, moduleName, mainTypeName, scriptClassName, usings, optimizationLevel, checkOverflow, allowUnsafe, cryptoKeyContainer, cryptoKeyFile, cryptoPublicKey, delaySign, platform, generalDiagnosticOption, warningLevel, specificDiagnosticOptions, concurrentBuild, deterministic, xmlReferenceResolver, sourceReferenceResolver, metadataReferenceResolver, assemblyIdentityComparer, strongNameProvider, publicSign, metadataImportOptions, nullableContextOptions: NullableContextOptions.Disable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 4757, 6767);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 4757, 6767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 4757, 6767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 4757, 6767);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CSharpCompilationOptions(
                    OutputKind outputKind,
                    bool reportSuppressedDiagnostics,
                    string? moduleName,
                    string? mainTypeName,
                    string? scriptClassName,
                    IEnumerable<string>? usings,
                    OptimizationLevel optimizationLevel,
                    bool checkOverflow,
                    bool allowUnsafe,
                    string? cryptoKeyContainer,
                    string? cryptoKeyFile,
                    ImmutableArray<byte> cryptoPublicKey,
                    bool? delaySign,
                    Platform platform,
                    ReportDiagnostic generalDiagnosticOption,
                    int warningLevel,
                    IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions,
                    bool concurrentBuild,
                    bool deterministic,
                    XmlReferenceResolver? xmlReferenceResolver,
                    SourceReferenceResolver? sourceReferenceResolver,
                    MetadataReferenceResolver? metadataReferenceResolver,
                    AssemblyIdentityComparer? assemblyIdentityComparer,
                    StrongNameProvider? strongNameProvider,
                    bool publicSign)
        : this(f_10037_8057_8067_C(outputKind), reportSuppressedDiagnostics, moduleName, mainTypeName, scriptClassName, usings, optimizationLevel, checkOverflow, allowUnsafe, cryptoKeyContainer, cryptoKeyFile, cryptoPublicKey, delaySign, platform, generalDiagnosticOption, warningLevel, specificDiagnosticOptions, concurrentBuild, deterministic, xmlReferenceResolver, sourceReferenceResolver, metadataReferenceResolver, assemblyIdentityComparer, strongNameProvider, publicSign, MetadataImportOptions.Public)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 6832, 8770);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 6832, 8770);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 6832, 8770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 6832, 8770);
            }
        }

        internal CSharpCompilationOptions(
                    OutputKind outputKind,
                    bool reportSuppressedDiagnostics,
                    string? moduleName,
                    string? mainTypeName,
                    string? scriptClassName,
                    IEnumerable<string>? usings,
                    OptimizationLevel optimizationLevel,
                    bool checkOverflow,
                    bool allowUnsafe,
                    string? cryptoKeyContainer,
                    string? cryptoKeyFile,
                    ImmutableArray<byte> cryptoPublicKey,
                    bool? delaySign,
                    Platform platform,
                    ReportDiagnostic generalDiagnosticOption,
                    int warningLevel,
                    IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions,
                    bool concurrentBuild,
                    bool deterministic,
                    DateTime currentLocalTime,
                    bool debugPlusMode,
                    XmlReferenceResolver? xmlReferenceResolver,
                    SourceReferenceResolver? sourceReferenceResolver,
                    SyntaxTreeOptionsProvider? syntaxTreeOptionsProvider,
                    MetadataReferenceResolver? metadataReferenceResolver,
                    AssemblyIdentityComparer? assemblyIdentityComparer,
                    StrongNameProvider? strongNameProvider,
                    MetadataImportOptions metadataImportOptions,
                    bool referencesSupersedeLowerVersions,
                    bool publicSign,
                    BinderFlags topLevelBinderFlags,
                    NullableContextOptions nullableContextOptions)
        : base(f_10037_10349_10359_C(outputKind), reportSuppressedDiagnostics, moduleName, mainTypeName, scriptClassName, cryptoKeyContainer, cryptoKeyFile, cryptoPublicKey, delaySign, publicSign, optimizationLevel, checkOverflow, platform, generalDiagnosticOption, warningLevel, f_10037_10631_10687(specificDiagnosticOptions), concurrentBuild, deterministic, currentLocalTime, debugPlusMode, xmlReferenceResolver, sourceReferenceResolver, syntaxTreeOptionsProvider, metadataReferenceResolver, assemblyIdentityComparer, strongNameProvider, metadataImportOptions, referencesSupersedeLowerVersions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 8821, 11268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 963, 1008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 1380, 1442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 1547, 1632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 11042, 11084);

                this.Usings = f_10037_11056_11083(usings);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 11098, 11129);

                this.AllowUnsafe = allowUnsafe;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 11143, 11190);

                this.TopLevelBinderFlags = topLevelBinderFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 11204, 11257);

                this.NullableContextOptions = nullableContextOptions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 8821, 11268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 8821, 11268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 8821, 11268);
            }
        }

        private CSharpCompilationOptions(CSharpCompilationOptions other) : this(
         f_10037_11366_11394_C(outputKind: f_10037_11378_11394(other)), moduleName: f_10037_11421_11437(other), mainTypeName: f_10037_11466_11484(other), scriptClassName: f_10037_11516_11537(other), usings: f_10037_11560_11572(other), optimizationLevel: f_10037_11606_11629(other), checkOverflow: f_10037_11659_11678(other), allowUnsafe: f_10037_11706_11723(other), cryptoKeyContainer: f_10037_11758_11782(other), cryptoKeyFile: f_10037_11812_11831(other), cryptoPublicKey: f_10037_11863_11884(other), delaySign: f_10037_11910_11925(other), platform: f_10037_11950_11964(other), generalDiagnosticOption: f_10037_12004_12033(other), warningLevel: f_10037_12062_12080(other), specificDiagnosticOptions: f_10037_12122_12153(other), concurrentBuild: f_10037_12185_12206(other), deterministic: f_10037_12236_12255(other), currentLocalTime: f_10037_12288_12310(other), debugPlusMode: f_10037_12340_12359(other), xmlReferenceResolver: f_10037_12396_12422(other), sourceReferenceResolver: f_10037_12462_12491(other), syntaxTreeOptionsProvider: f_10037_12533_12564(other), metadataReferenceResolver: f_10037_12606_12637(other), assemblyIdentityComparer: f_10037_12678_12708(other), strongNameProvider: f_10037_12743_12767(other), metadataImportOptions: f_10037_12805_12832(other), referencesSupersedeLowerVersions: f_10037_12881_12919(other), reportSuppressedDiagnostics: f_10037_12963_12996(other), publicSign: f_10037_13023_13039(other), topLevelBinderFlags: f_10037_13075_13100(other), nullableContextOptions: f_10037_13139_13167(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 11280, 13190);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 11280, 13190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 11280, 13190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 11280, 13190);
            }
        }

        public override string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 13234, 13257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 13237, 13257);
                    return LanguageNames.CSharp; DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 13234, 13257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 13234, 13257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 13234, 13257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CSharpCompilationOptions WithTopLevelBinderFlags(BinderFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 13270, 13496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 13371, 13485);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10037, 13378, 13408) || (((flags == f_10037_13388_13407()) && DynAbs.Tracing.TraceSender.Conditional_F2(10037, 13411, 13415)) || DynAbs.Tracing.TraceSender.Conditional_F3(10037, 13418, 13484))) ? this : new CSharpCompilationOptions(this) { TopLevelBinderFlags = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => flags, 10037, 13418, 13484) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 13270, 13496);

                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10037_13388_13407()
                {
                    var return_v = TopLevelBinderFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 13388, 13407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 13270, 13496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 13270, 13496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetImports()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 13562, 13571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 13565, 13571);
                return f_10037_13565_13571(); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 13562, 13571);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 13562, 13571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 13562, 13571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithOutputKind(OutputKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 13584, 13855);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 13676, 13764) || true) && (kind == f_10037_13688_13703(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 13676, 13764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 13737, 13749);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 13676, 13764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 13780, 13844);

                return new CSharpCompilationOptions(this) { OutputKind = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => kind, 10037, 13787, 13843) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 13584, 13855);

                Microsoft.CodeAnalysis.OutputKind
                f_10037_13688_13703(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 13688, 13703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 13584, 13855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 13584, 13855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithModuleName(string? moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 13867, 14153);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 13962, 14056) || true) && (moduleName == f_10037_13980_13995(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 13962, 14056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14029, 14041);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 13962, 14056);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14072, 14142);

                return new CSharpCompilationOptions(this) { ModuleName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => moduleName, 10037, 14079, 14141) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 13867, 14153);

                string?
                f_10037_13980_13995(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 13980, 13995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 13867, 14153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 13867, 14153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithScriptClassName(string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 14165, 14448);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14259, 14352) || true) && (name == f_10037_14271_14291(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 14259, 14352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14325, 14337);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 14259, 14352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14368, 14437);

                return new CSharpCompilationOptions(this) { ScriptClassName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => name, 10037, 14375, 14436) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 14165, 14448);

                string?
                f_10037_14271_14291(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 14271, 14291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 14165, 14448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 14165, 14448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithMainTypeName(string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 14460, 14734);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14551, 14641) || true) && (name == f_10037_14563_14580(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 14551, 14641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14614, 14626);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 14551, 14641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14657, 14723);

                return new CSharpCompilationOptions(this) { MainTypeName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => name, 10037, 14664, 14722) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 14460, 14734);

                string?
                f_10037_14563_14580(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 14563, 14580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 14460, 14734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 14460, 14734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithCryptoKeyContainer(string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 14746, 15038);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14843, 14939) || true) && (name == f_10037_14855_14878(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 14843, 14939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14912, 14924);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 14843, 14939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 14955, 15027);

                return new CSharpCompilationOptions(this) { CryptoKeyContainer = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => name, 10037, 14962, 15026) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 14746, 15038);

                string?
                f_10037_14855_14878(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 14855, 14878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 14746, 15038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 14746, 15038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithCryptoKeyFile(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 15050, 15434);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15142, 15233) || true) && (f_10037_15146_15172(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 15142, 15233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15206, 15218);

                    path = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 15142, 15233);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15249, 15340) || true) && (path == f_10037_15261_15279(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 15249, 15340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15313, 15325);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 15249, 15340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15356, 15423);

                return new CSharpCompilationOptions(this) { CryptoKeyFile = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => path, 10037, 15363, 15422) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 15050, 15434);

                bool
                f_10037_15146_15172(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 15146, 15172);
                    return return_v;
                }


                string?
                f_10037_15261_15279(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 15261, 15279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 15050, 15434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 15050, 15434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithCryptoPublicKey(ImmutableArray<byte> value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 15446, 15864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15554, 15657) || true) && (value.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 15554, 15657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15607, 15642);

                    value = ImmutableArray<byte>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 15554, 15657);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15673, 15767) || true) && (value == f_10037_15686_15706(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 15673, 15767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15740, 15752);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 15673, 15767);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15783, 15853);

                return new CSharpCompilationOptions(this) { CryptoPublicKey = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 10037, 15790, 15852) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 15446, 15864);

                System.Collections.Immutable.ImmutableArray<byte>
                f_10037_15686_15706(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 15686, 15706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 15446, 15864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 15446, 15864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithDelaySign(bool? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 15876, 16142);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 15963, 16051) || true) && (value == f_10037_15976_15990(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 15963, 16051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16024, 16036);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 15963, 16051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16067, 16131);

                return new CSharpCompilationOptions(this) { DelaySign = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 10037, 16074, 16130) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 15876, 16142);

                bool?
                f_10037_15976_15990(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 15976, 15990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 15876, 16142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 15876, 16142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpCompilationOptions WithUsings(ImmutableArray<string> usings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 16154, 16427);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16252, 16338) || true) && (f_10037_16256_16267(this) == usings)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 16252, 16338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16311, 16323);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 16252, 16338);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16354, 16416);

                return new CSharpCompilationOptions(this) { Usings = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => usings, 10037, 16361, 16415) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 16154, 16427);

                System.Collections.Immutable.ImmutableArray<string>
                f_10037_16256_16267(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 16256, 16267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 16154, 16427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 16154, 16427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpCompilationOptions WithUsings(IEnumerable<string>? usings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 16511, 16602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16527, 16602);
                return new CSharpCompilationOptions(this) { Usings = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10037_16573_16600(usings), 10037, 16527, 16602) }; DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 16511, 16602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 16511, 16602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 16511, 16602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpCompilationOptions WithUsings(params string[]? usings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 16683, 16726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16686, 16726);
                return f_10037_16686_16726(this, usings); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 16683, 16726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 16683, 16726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 16683, 16726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithOptimizationLevel(OptimizationLevel value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 16739, 17041);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16846, 16942) || true) && (value == f_10037_16859_16881(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 16846, 16942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16915, 16927);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 16846, 16942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 16958, 17030);

                return new CSharpCompilationOptions(this) { OptimizationLevel = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 10037, 16965, 17029) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 16739, 17041);

                Microsoft.CodeAnalysis.OptimizationLevel
                f_10037_16859_16881(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 16859, 16881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 16739, 17041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 16739, 17041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithOverflowChecks(bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 17053, 17337);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17146, 17240) || true) && (enabled == f_10037_17161_17179(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 17146, 17240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17213, 17225);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 17146, 17240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17256, 17326);

                return new CSharpCompilationOptions(this) { CheckOverflow = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => enabled, 10037, 17263, 17325) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 17053, 17337);

                bool
                f_10037_17161_17179(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CheckOverflow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 17161, 17179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 17053, 17337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 17053, 17337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpCompilationOptions WithNullableContextOptions(NullableContextOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 17349, 17673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17464, 17567) || true) && (options == f_10037_17479_17506(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 17464, 17567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17540, 17552);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 17464, 17567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17583, 17662);

                return new CSharpCompilationOptions(this) { NullableContextOptions = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => options, 10037, 17590, 17661) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 17349, 17673);

                Microsoft.CodeAnalysis.NullableContextOptions
                f_10037_17479_17506(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 17479, 17506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 17349, 17673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 17349, 17673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpCompilationOptions WithAllowUnsafe(bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 17685, 17958);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17771, 17863) || true) && (enabled == f_10037_17786_17802(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 17771, 17863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17836, 17848);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 17771, 17863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 17879, 17947);

                return new CSharpCompilationOptions(this) { AllowUnsafe = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => enabled, 10037, 17886, 17946) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 17685, 17958);

                bool
                f_10037_17786_17802(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 17786, 17802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 17685, 17958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 17685, 17958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithPlatform(Platform platform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 17970, 18245);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18062, 18152) || true) && (f_10037_18066_18079(this) == platform)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 18062, 18152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18125, 18137);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 18062, 18152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18168, 18234);

                return new CSharpCompilationOptions(this) { Platform = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => platform, 10037, 18175, 18233) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 17970, 18245);

                Microsoft.CodeAnalysis.Platform
                f_10037_18066_18079(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 18066, 18079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 17970, 18245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 17970, 18245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithPublicSign(bool publicSign)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 18257, 18540);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18349, 18443) || true) && (f_10037_18353_18368(this) == publicSign)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 18349, 18443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18416, 18428);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 18349, 18443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18459, 18529);

                return new CSharpCompilationOptions(this) { PublicSign = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => publicSign, 10037, 18466, 18528) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 18257, 18540);

                bool
                f_10037_18353_18368(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 18353, 18368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 18257, 18540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 18257, 18540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithGeneralDiagnosticOption(ReportDiagnostic value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 18648, 18685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18651, 18685);
                return f_10037_18651_18685(this, value); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 18648, 18685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 18648, 18685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 18648, 18685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithSpecificDiagnosticOptions(ImmutableDictionary<string, ReportDiagnostic>? specificDiagnosticOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 18846, 18918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 18862, 18918);
                return f_10037_18862_18918(this, specificDiagnosticOptions); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 18846, 18918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 18846, 18918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 18846, 18918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithSpecificDiagnosticOptions(IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 19085, 19157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19101, 19157);
                return f_10037_19101_19157(this, specificDiagnosticOptions); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 19085, 19157);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 19085, 19157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 19085, 19157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithReportSuppressedDiagnostics(bool reportSuppressedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 19280, 19356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19296, 19356);
                return f_10037_19296_19356(this, reportSuppressedDiagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 19280, 19356);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 19280, 19356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 19280, 19356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithGeneralDiagnosticOption(ReportDiagnostic value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 19369, 19688);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19481, 19583) || true) && (f_10037_19485_19513(this) == value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 19481, 19583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19556, 19568);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 19481, 19583);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19599, 19677);

                return new CSharpCompilationOptions(this) { GeneralDiagnosticOption = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 10037, 19606, 19676) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 19369, 19688);

                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10037_19485_19513(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 19485, 19513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 19369, 19688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 19369, 19688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithSpecificDiagnosticOptions(ImmutableDictionary<string, ReportDiagnostic>? values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 19700, 20202);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19845, 19973) || true) && (values == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 19845, 19973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19897, 19958);

                    values = ImmutableDictionary<string, ReportDiagnostic>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 19845, 19973);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 19989, 20094) || true) && (f_10037_19993_20023(this) == values)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 19989, 20094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 20067, 20079);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 19989, 20094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 20110, 20191);

                return new CSharpCompilationOptions(this) { SpecificDiagnosticOptions = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => values, 10037, 20117, 20190) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 19700, 20202);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10037_19993_20023(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 19993, 20023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 19700, 20202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 19700, 20202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithSpecificDiagnosticOptions(IEnumerable<KeyValuePair<string, ReportDiagnostic>>? values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 20341, 20461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 20357, 20461);
                return new CSharpCompilationOptions(this) { SpecificDiagnosticOptions = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10037_20422_20459(values), 10037, 20357, 20461) }; DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 20341, 20461);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 20341, 20461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 20341, 20461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithReportSuppressedDiagnostics(bool reportSuppressedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 20474, 20859);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 20600, 20728) || true) && (reportSuppressedDiagnostics == f_10037_20635_20667(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 20600, 20728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 20701, 20713);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 20600, 20728);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 20744, 20848);

                return new CSharpCompilationOptions(this) { ReportSuppressedDiagnostics = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => reportSuppressedDiagnostics, 10037, 20751, 20847) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 20474, 20859);

                bool
                f_10037_20635_20667(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 20635, 20667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 20474, 20859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 20474, 20859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpCompilationOptions WithWarningLevel(int warningLevel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 20871, 21161);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 20962, 21060) || true) && (warningLevel == f_10037_20982_20999(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 20962, 21060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21033, 21045);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 20962, 21060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21076, 21150);

                return new CSharpCompilationOptions(this) { WarningLevel = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => warningLevel, 10037, 21083, 21149) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 20871, 21161);

                int
                f_10037_20982_20999(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 20982, 20999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 20871, 21161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 20871, 21161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithConcurrentBuild(bool concurrentBuild)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 21173, 21486);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21275, 21379) || true) && (concurrentBuild == f_10037_21298_21318(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 21275, 21379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21352, 21364);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 21275, 21379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21395, 21475);

                return new CSharpCompilationOptions(this) { ConcurrentBuild = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => concurrentBuild, 10037, 21402, 21474) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 21173, 21486);

                bool
                f_10037_21298_21318(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 21298, 21318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 21173, 21486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 21173, 21486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithDeterministic(bool deterministic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 21498, 21799);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21596, 21696) || true) && (deterministic == f_10037_21617_21635(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 21596, 21696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21669, 21681);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 21596, 21696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21712, 21788);

                return new CSharpCompilationOptions(this) { Deterministic = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => deterministic, 10037, 21719, 21787) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 21498, 21799);

                bool
                f_10037_21617_21635(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Deterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 21617, 21635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 21498, 21799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 21498, 21799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CSharpCompilationOptions WithCurrentLocalTime(DateTime value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 21811, 22099);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21906, 22001) || true) && (value == f_10037_21919_21940(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 21906, 22001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 21974, 21986);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 21906, 22001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22017, 22088);

                return new CSharpCompilationOptions(this) { CurrentLocalTime = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 10037, 22024, 22087) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 21811, 22099);

                System.DateTime
                f_10037_21919_21940(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.CurrentLocalTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 21919, 21940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 21811, 22099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 21811, 22099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CSharpCompilationOptions WithDebugPlusMode(bool debugPlusMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 22111, 22410);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22207, 22307) || true) && (debugPlusMode == f_10037_22228_22246(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 22207, 22307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22280, 22292);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 22207, 22307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22323, 22399);

                return new CSharpCompilationOptions(this) { DebugPlusMode = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => debugPlusMode, 10037, 22330, 22398) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 22111, 22410);

                bool
                f_10037_22228_22246(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.DebugPlusMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 22228, 22246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 22111, 22410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 22111, 22410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithMetadataImportOptions(MetadataImportOptions value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 22422, 22740);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22537, 22637) || true) && (value == f_10037_22550_22576(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 22537, 22637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22610, 22622);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 22537, 22637);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22653, 22729);

                return new CSharpCompilationOptions(this) { MetadataImportOptions = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 10037, 22660, 22728) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 22422, 22740);

                Microsoft.CodeAnalysis.MetadataImportOptions
                f_10037_22550_22576(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 22550, 22576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 22422, 22740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 22422, 22740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CSharpCompilationOptions WithReferencesSupersedeLowerVersions(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 22752, 23084);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22859, 22970) || true) && (value == f_10037_22872_22909(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 22859, 22970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22943, 22955);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 22859, 22970);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 22986, 23073);

                return new CSharpCompilationOptions(this) { ReferencesSupersedeLowerVersions = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 10037, 22993, 23072) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 22752, 23084);

                bool
                f_10037_22872_22909(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ReferencesSupersedeLowerVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 22872, 22909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 22752, 23084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 22752, 23084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithXmlReferenceResolver(XmlReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 23096, 23435);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 23213, 23330) || true) && (f_10037_23217_23269(resolver, f_10037_23243_23268(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 23213, 23330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 23303, 23315);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 23213, 23330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 23346, 23424);

                return new CSharpCompilationOptions(this) { XmlReferenceResolver = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => resolver, 10037, 23353, 23423) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 23096, 23435);

                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_10037_23243_23268(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 23243, 23268);
                    return return_v;
                }


                bool
                f_10037_23217_23269(Microsoft.CodeAnalysis.XmlReferenceResolver?
                objA, Microsoft.CodeAnalysis.XmlReferenceResolver?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 23217, 23269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 23096, 23435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 23096, 23435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithSourceReferenceResolver(SourceReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 23447, 23798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 23570, 23690) || true) && (f_10037_23574_23629(resolver, f_10037_23600_23628(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 23570, 23690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 23663, 23675);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 23570, 23690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 23706, 23787);

                return new CSharpCompilationOptions(this) { SourceReferenceResolver = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => resolver, 10037, 23713, 23786) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 23447, 23798);

                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_10037_23600_23628(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 23600, 23628);
                    return return_v;
                }


                bool
                f_10037_23574_23629(Microsoft.CodeAnalysis.SourceReferenceResolver?
                objA, Microsoft.CodeAnalysis.SourceReferenceResolver?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 23574, 23629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 23447, 23798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 23447, 23798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithSyntaxTreeOptionsProvider(SyntaxTreeOptionsProvider? provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 23810, 24169);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 23937, 24059) || true) && (f_10037_23941_23998(provider, f_10037_23967_23997(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 23937, 24059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24032, 24044);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 23937, 24059);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24075, 24158);

                return new CSharpCompilationOptions(this) { SyntaxTreeOptionsProvider = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => provider, 10037, 24082, 24157) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 23810, 24169);

                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_10037_23967_23997(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 23967, 23997);
                    return return_v;
                }


                bool
                f_10037_23941_23998(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                objA, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 23941, 23998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 23810, 24169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 23810, 24169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithMetadataReferenceResolver(MetadataReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 24181, 24540);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24308, 24430) || true) && (f_10037_24312_24369(resolver, f_10037_24338_24368(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 24308, 24430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24403, 24415);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 24308, 24430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24446, 24529);

                return new CSharpCompilationOptions(this) { MetadataReferenceResolver = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => resolver, 10037, 24453, 24528) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 24181, 24540);

                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_10037_24338_24368(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 24338, 24368);
                    return return_v;
                }


                bool
                f_10037_24312_24369(Microsoft.CodeAnalysis.MetadataReferenceResolver?
                objA, Microsoft.CodeAnalysis.MetadataReferenceResolver?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 24312, 24369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 24181, 24540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 24181, 24540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithAssemblyIdentityComparer(AssemblyIdentityComparer? comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 24552, 24979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24677, 24733);

                comparer = comparer ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.AssemblyIdentityComparer?>(10037, 24688, 24732) ?? f_10037_24700_24732());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24749, 24870) || true) && (f_10037_24753_24809(comparer, f_10037_24779_24808(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 24749, 24870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24843, 24855);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 24749, 24870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 24886, 24968);

                return new CSharpCompilationOptions(this) { AssemblyIdentityComparer = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => comparer, 10037, 24893, 24967) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 24552, 24979);

                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_10037_24700_24732()
                {
                    var return_v = AssemblyIdentityComparer.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 24700, 24732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_10037_24779_24808(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 24779, 24808);
                    return return_v;
                }


                bool
                f_10037_24753_24809(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                objA, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 24753, 24809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 24552, 24979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 24552, 24979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCompilationOptions WithStrongNameProvider(StrongNameProvider? provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 24991, 25322);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25104, 25219) || true) && (f_10037_25108_25158(provider, f_10037_25134_25157(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 25104, 25219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25192, 25204);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 25104, 25219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25235, 25311);

                return new CSharpCompilationOptions(this) { StrongNameProvider = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => provider, 10037, 25242, 25310) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 24991, 25322);

                Microsoft.CodeAnalysis.StrongNameProvider?
                f_10037_25134_25157(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 25134, 25157);
                    return return_v;
                }


                bool
                f_10037_25108_25158(Microsoft.CodeAnalysis.StrongNameProvider?
                objA, Microsoft.CodeAnalysis.StrongNameProvider?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 25108, 25158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 24991, 25322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 24991, 25322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithConcurrentBuild(bool concurrent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 25415, 25449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25418, 25449);
                return f_10037_25418_25449(this, concurrent); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 25415, 25449);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 25415, 25449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 25415, 25449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithDeterministic(bool deterministic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 25542, 25577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25545, 25577);
                return f_10037_25545_25577(this, deterministic); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 25542, 25577);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 25542, 25577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 25542, 25577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithOutputKind(OutputKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 25666, 25689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25669, 25689);
                return f_10037_25669_25689(this, kind); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 25666, 25689);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 25666, 25689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 25666, 25689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithPlatform(Platform platform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 25778, 25803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25781, 25803);
                return f_10037_25781_25803(this, platform); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 25778, 25803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 25778, 25803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 25778, 25803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithPublicSign(bool publicSign)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 25892, 25921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 25895, 25921);
                return f_10037_25895_25921(this, publicSign); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 25892, 25921);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 25892, 25921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 25892, 25921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithOptimizationLevel(OptimizationLevel value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 26025, 26056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 26028, 26056);
                return f_10037_26028_26056(this, value); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 26025, 26056);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 26025, 26056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 26025, 26056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithAssemblyIdentityComparer(AssemblyIdentityComparer? comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 26178, 26232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 26194, 26232);
                return f_10037_26194_26232(this, comparer); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 26178, 26232);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 26178, 26232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 26178, 26232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithXmlReferenceResolver(XmlReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 26346, 26396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 26362, 26396);
                return f_10037_26362_26396(this, resolver); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 26346, 26396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 26346, 26396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 26346, 26396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithSourceReferenceResolver(SourceReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 26516, 26569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 26532, 26569);
                return f_10037_26532_26569(this, resolver); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 26516, 26569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 26516, 26569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 26516, 26569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithSyntaxTreeOptionsProvider(SyntaxTreeOptionsProvider? provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 26706, 26748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 26709, 26748);
                return f_10037_26709_26748(this, provider); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 26706, 26748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 26706, 26748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 26706, 26748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithMetadataReferenceResolver(MetadataReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 26872, 26927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 26888, 26927);
                return f_10037_26888_26927(this, resolver); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 26872, 26927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 26872, 26927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 26872, 26927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithStrongNameProvider(StrongNameProvider? provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 27037, 27085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27053, 27085);
                return f_10037_27053_27085(this, provider); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 27037, 27085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 27037, 27085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 27037, 27085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithMetadataImportOptions(MetadataImportOptions value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 27197, 27245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27213, 27245);
                return f_10037_27213_27245(this, value); DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 27197, 27245);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 27197, 27245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 27197, 27245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete]
        protected override CompilationOptions CommonWithFeatures(ImmutableArray<string> features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 27258, 27439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27392, 27428);

                throw f_10037_27398_27427();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 27258, 27439);

                System.NotImplementedException
                f_10037_27398_27427()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27398, 27427);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 27258, 27439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 27258, 27439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ValidateOptions(ArrayBuilder<Diagnostic> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 27451, 30797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27548, 27599);

                f_10037_27548_27598(this, builder, MessageProvider.Instance);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27677, 28228) || true) && (f_10037_27681_27698(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 27677, 28228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27740, 27955) || true) && (f_10037_27744_27769(f_10037_27744_27759(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10037, 27744, 27805) && !f_10037_27774_27805(f_10037_27774_27789(this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 27740, 27955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27847, 27936);

                        f_10037_27847_27935(builder, f_10037_27859_27934(MessageProvider.Instance, ErrorCode.ERR_NoMainOnDLL));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 27740, 27955);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 27975, 28213) || true) && (!f_10037_27980_28013(f_10037_27980_27992()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 27975, 28213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28055, 28194);

                        f_10037_28055_28193(builder, f_10037_28067_28192(MessageProvider.Instance, ErrorCode.ERR_BadCompilationOptionValue, nameof(MainTypeName), f_10037_28179_28191()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 27975, 28213);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 27677, 28228);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28244, 28430) || true) && (!f_10037_28249_28267(f_10037_28249_28257()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 28244, 28430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28301, 28415);

                    f_10037_28301_28414(builder, f_10037_28313_28413(MessageProvider.Instance, ErrorCode.ERR_BadPlatformType, f_10037_28393_28412(f_10037_28393_28401())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 28244, 28430);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28446, 28640) || true) && (f_10037_28450_28460() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 28446, 28640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28502, 28625);

                    f_10037_28502_28624(f_10037_28544_28554(), MessageProvider.Instance, ErrorCode.ERR_BadModuleName, builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 28446, 28640);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28656, 28876) || true) && (!f_10037_28661_28681(f_10037_28661_28671()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 28656, 28876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28715, 28861);

                    f_10037_28715_28860(builder, f_10037_28727_28859(MessageProvider.Instance, ErrorCode.ERR_BadCompilationOptionValue, nameof(OutputKind), f_10037_28837_28858(f_10037_28837_28847())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 28656, 28876);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28892, 29133) || true) && (!f_10037_28897_28924(f_10037_28897_28914()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 28892, 29133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 28958, 29118);

                    f_10037_28958_29117(builder, f_10037_28970_29116(MessageProvider.Instance, ErrorCode.ERR_BadCompilationOptionValue, nameof(OptimizationLevel), f_10037_29087_29115(f_10037_29087_29104())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 28892, 29133);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 29149, 29421) || true) && (f_10037_29153_29168() == null || (DynAbs.Tracing.TraceSender.Expression_False(10037, 29153, 29217) || !f_10037_29181_29217(f_10037_29181_29196())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 29149, 29421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 29251, 29406);

                    f_10037_29251_29405(builder, f_10037_29263_29404(MessageProvider.Instance, ErrorCode.ERR_BadCompilationOptionValue, nameof(ScriptClassName), f_10037_29378_29393() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10037, 29378, 29403) ?? "null")));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 29149, 29421);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 29437, 29645) || true) && (f_10037_29441_29453() < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 29437, 29645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 29491, 29630);

                    f_10037_29491_29629(builder, f_10037_29503_29628(MessageProvider.Instance, ErrorCode.ERR_BadCompilationOptionValue, nameof(WarningLevel), f_10037_29615_29627()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 29437, 29645);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 29661, 29963) || true) && (f_10037_29665_29671() != null && (DynAbs.Tracing.TraceSender.Expression_True(10037, 29665, 29728) && f_10037_29683_29689().Any(u => !u.IsValidClrNamespaceName())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 29661, 29963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 29762, 29948);

                    f_10037_29762_29947(builder, f_10037_29774_29946(MessageProvider.Instance, ErrorCode.ERR_BadCompilationOptionValue, nameof(Usings), f_10037_29880_29935(f_10037_29880_29886().Where(u => !u.IsValidClrNamespaceName())) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10037, 29880, 29945) ?? "null")));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 29661, 29963);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 29979, 30342) || true) && (f_10037_29983_29991() == Platform.AnyCpu32BitPreferred && (DynAbs.Tracing.TraceSender.Expression_True(10037, 29983, 30048) && f_10037_30028_30048(f_10037_30028_30038())) && (DynAbs.Tracing.TraceSender.Expression_True(10037, 29983, 30199) && !(f_10037_30054_30064() == OutputKind.ConsoleApplication || (DynAbs.Tracing.TraceSender.Expression_False(10037, 30054, 30144) || f_10037_30101_30111() == OutputKind.WindowsApplication) || (DynAbs.Tracing.TraceSender.Expression_False(10037, 30054, 30198) || f_10037_30148_30158() == OutputKind.WindowsRuntimeApplication))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 29979, 30342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 30233, 30327);

                    f_10037_30233_30326(builder, f_10037_30245_30325(MessageProvider.Instance, ErrorCode.ERR_BadPrefer32OnLib));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 29979, 30342);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 30358, 30611) || true) && (!f_10037_30363_30394(f_10037_30363_30384()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 30358, 30611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 30428, 30596);

                    f_10037_30428_30595(builder, f_10037_30440_30594(MessageProvider.Instance, ErrorCode.ERR_BadCompilationOptionValue, nameof(MetadataImportOptions), f_10037_30561_30593(f_10037_30561_30582())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 30358, 30611);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 27451, 30797);

                int
                f_10037_27548_27598(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                builder, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    this_param.ValidateOptions(builder, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27548, 27598);
                    return 0;
                }


                string?
                f_10037_27681_27698(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 27681, 27698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_27744_27759(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 27744, 27759);
                    return return_v;
                }


                bool
                f_10037_27744_27769(Microsoft.CodeAnalysis.OutputKind
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27744, 27769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_27774_27789(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 27774, 27789);
                    return return_v;
                }


                bool
                f_10037_27774_27805(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27774, 27805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_27859_27934(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27859, 27934);
                    return return_v;
                }


                int
                f_10037_27847_27935(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27847, 27935);
                    return 0;
                }


                string
                f_10037_27980_27992()
                {
                    var return_v = MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 27980, 27992);
                    return return_v;
                }


                bool
                f_10037_27980_28013(string
                name)
                {
                    var return_v = name.IsValidClrTypeName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27980, 28013);
                    return return_v;
                }


                string
                f_10037_28179_28191()
                {
                    var return_v = MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28179, 28191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_28067_28192(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28067, 28192);
                    return return_v;
                }


                int
                f_10037_28055_28193(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28055, 28193);
                    return 0;
                }


                Microsoft.CodeAnalysis.Platform
                f_10037_28249_28257()
                {
                    var return_v = Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28249, 28257);
                    return return_v;
                }


                bool
                f_10037_28249_28267(Microsoft.CodeAnalysis.Platform
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28249, 28267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Platform
                f_10037_28393_28401()
                {
                    var return_v = Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28393, 28401);
                    return return_v;
                }


                string
                f_10037_28393_28412(Microsoft.CodeAnalysis.Platform
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28393, 28412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_28313_28413(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28313, 28413);
                    return return_v;
                }


                int
                f_10037_28301_28414(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28301, 28414);
                    return 0;
                }


                string?
                f_10037_28450_28460()
                {
                    var return_v = ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28450, 28460);
                    return return_v;
                }


                string
                f_10037_28544_28554()
                {
                    var return_v = ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28544, 28554);
                    return return_v;
                }


                int
                f_10037_28502_28624(string
                name, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                builder)
                {
                    MetadataHelpers.CheckAssemblyOrModuleName(name, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)code, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28502, 28624);
                    return 0;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_28661_28671()
                {
                    var return_v = OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28661, 28671);
                    return return_v;
                }


                bool
                f_10037_28661_28681(Microsoft.CodeAnalysis.OutputKind
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28661, 28681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_28837_28847()
                {
                    var return_v = OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28837, 28847);
                    return return_v;
                }


                string
                f_10037_28837_28858(Microsoft.CodeAnalysis.OutputKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28837, 28858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_28727_28859(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28727, 28859);
                    return return_v;
                }


                int
                f_10037_28715_28860(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28715, 28860);
                    return 0;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10037_28897_28914()
                {
                    var return_v = OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 28897, 28914);
                    return return_v;
                }


                bool
                f_10037_28897_28924(Microsoft.CodeAnalysis.OptimizationLevel
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28897, 28924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10037_29087_29104()
                {
                    var return_v = OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29087, 29104);
                    return return_v;
                }


                string
                f_10037_29087_29115(Microsoft.CodeAnalysis.OptimizationLevel
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29087, 29115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_28970_29116(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28970, 29116);
                    return return_v;
                }


                int
                f_10037_28958_29117(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 28958, 29117);
                    return 0;
                }


                string?
                f_10037_29153_29168()
                {
                    var return_v = ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29153, 29168);
                    return return_v;
                }


                string
                f_10037_29181_29196()
                {
                    var return_v = ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29181, 29196);
                    return return_v;
                }


                bool
                f_10037_29181_29217(string
                name)
                {
                    var return_v = name.IsValidClrTypeName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29181, 29217);
                    return return_v;
                }


                string?
                f_10037_29378_29393()
                {
                    var return_v = ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29378, 29393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_29263_29404(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29263, 29404);
                    return return_v;
                }


                int
                f_10037_29251_29405(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29251, 29405);
                    return 0;
                }


                int
                f_10037_29441_29453()
                {
                    var return_v = WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29441, 29453);
                    return return_v;
                }


                int
                f_10037_29615_29627()
                {
                    var return_v = WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29615, 29627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_29503_29628(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29503, 29628);
                    return return_v;
                }


                int
                f_10037_29491_29629(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29491, 29629);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10037_29665_29671()
                {
                    var return_v = Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29665, 29671);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10037_29683_29689()
                {
                    var return_v = Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29683, 29689);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10037_29880_29886()
                {
                    var return_v = Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29880, 29886);
                    return return_v;
                }


                string
                f_10037_29880_29935(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.First<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29880, 29935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_29774_29946(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29774, 29946);
                    return return_v;
                }


                int
                f_10037_29762_29947(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 29762, 29947);
                    return 0;
                }


                Microsoft.CodeAnalysis.Platform
                f_10037_29983_29991()
                {
                    var return_v = Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 29983, 29991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_30028_30038()
                {
                    var return_v = OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 30028, 30038);
                    return return_v;
                }


                bool
                f_10037_30028_30048(Microsoft.CodeAnalysis.OutputKind
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30028, 30048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_30054_30064()
                {
                    var return_v = OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 30054, 30064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_30101_30111()
                {
                    var return_v = OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 30101, 30111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10037_30148_30158()
                {
                    var return_v = OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 30148, 30158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_30245_30325(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30245, 30325);
                    return return_v;
                }


                int
                f_10037_30233_30326(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30233, 30326);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_10037_30363_30384()
                {
                    var return_v = MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 30363, 30384);
                    return return_v;
                }


                bool
                f_10037_30363_30394(Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30363, 30394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_10037_30561_30582()
                {
                    var return_v = MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 30561, 30582);
                    return return_v;
                }


                string
                f_10037_30561_30593(Microsoft.CodeAnalysis.MetadataImportOptions
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30561, 30593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10037_30440_30594(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30440, 30594);
                    return return_v;
                }


                int
                f_10037_30428_30595(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30428, 30595);
                    return 0;
                }


                // TODO: add check for 
                //          (kind == 'arm' || kind == 'appcontainer' || kind == 'winmdobj') &&
                //          (version >= "6.2")
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 27451, 30797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 27451, 30797);
            }
        }

        public bool Equals(CSharpCompilationOptions? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 30809, 31458);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 30885, 30985) || true) && (f_10037_30889_30924(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 30885, 30985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 30958, 30970);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 30885, 30985);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 31001, 31092) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EqualsHelper(other), 10037, 31006, 31030))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10037, 31001, 31092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 31064, 31077);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10037, 31001, 31092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 31108, 31447);

                return f_10037_31115_31131(this) == f_10037_31135_31152(other) && (DynAbs.Tracing.TraceSender.Expression_True(10037, 31115, 31229) && f_10037_31176_31200(this) == f_10037_31204_31229(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10037, 31115, 31446) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10037, 31254, 31273) || ((f_10037_31254_31265(this) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10037, 31276, 31296)) || DynAbs.Tracing.TraceSender.Conditional_F3(10037, 31299, 31445))) ? f_10037_31276_31288(other) == null : this.Usings.SequenceEqual(f_10037_31325_31337(other), f_10037_31339_31361()) && (DynAbs.Tracing.TraceSender.Expression_True(10037, 31299, 31445) && f_10037_31386_31413(this) == f_10037_31417_31445(other))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 30809, 31458);

                bool
                f_10037_30889_30924(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                objA, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 30889, 30924);
                    return return_v;
                }


                bool
                f_10037_31115_31131(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31115, 31131);
                    return return_v;
                }


                bool
                f_10037_31135_31152(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31135, 31152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10037_31176_31200(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.TopLevelBinderFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31176, 31200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10037_31204_31229(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.TopLevelBinderFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31204, 31229);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10037_31254_31265(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31254, 31265);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10037_31276_31288(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31276, 31288);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10037_31325_31337(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31325, 31337);
                    return return_v;
                }


                System.StringComparer
                f_10037_31339_31361()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31339, 31361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10037_31386_31413(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31386, 31413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10037_31417_31445(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31417, 31445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 30809, 31458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 30809, 31458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 31470, 31598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 31535, 31587);

                return f_10037_31542_31586(this, obj as CSharpCompilationOptions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 31470, 31598);

                bool
                f_10037_31542_31586(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31542, 31586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 31470, 31598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 31470, 31598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 31610, 31980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 31668, 31969);

                return f_10037_31675_31968(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCodeHelper(), 10037, 31688, 31712), f_10037_31734_31967(f_10037_31747_31763(this), f_10037_31785_31966(f_10037_31798_31853(f_10037_31817_31828(this), f_10037_31830_31852()), f_10037_31875_31965(f_10037_31888_31921(f_10037_31888_31907()), f_10037_31923_31964(f_10037_31923_31950(this))))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 31610, 31980);

                bool
                f_10037_31747_31763(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31747, 31763);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10037_31817_31828(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31817, 31828);
                    return return_v;
                }


                System.StringComparer
                f_10037_31830_31852()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31830, 31852);
                    return return_v;
                }


                int
                f_10037_31798_31853(System.Collections.Immutable.ImmutableArray<string>
                values, System.StringComparer
                stringComparer)
                {
                    var return_v = Hash.CombineValues((System.Collections.Generic.IEnumerable<string?>)values, stringComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31798, 31853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10037_31888_31907()
                {
                    var return_v = TopLevelBinderFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31888, 31907);
                    return return_v;
                }


                int
                f_10037_31888_31921(Microsoft.CodeAnalysis.CSharp.BinderFlags
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31888, 31921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10037_31923_31950(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 31923, 31950);
                    return return_v;
                }


                int
                f_10037_31923_31964(Microsoft.CodeAnalysis.NullableContextOptions
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31923, 31964);
                    return return_v;
                }


                int
                f_10037_31875_31965(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31875, 31965);
                    return return_v;
                }


                int
                f_10037_31785_31966(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31785, 31966);
                    return return_v;
                }


                int
                f_10037_31734_31967(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31734, 31967);
                    return return_v;
                }


                int
                f_10037_31675_31968(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 31675, 31968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 31610, 31980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 31610, 31980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Diagnostic? FilterDiagnostic(Diagnostic diagnostic, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 31992, 32439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 32123, 32428);

                return f_10037_32130_32427(diagnostic, f_10037_32207_32219(), f_10037_32238_32260(), f_10037_32279_32302(), f_10037_32321_32346(), f_10037_32365_32390(), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 31992, 32439);

                int
                f_10037_32207_32219()
                {
                    var return_v = WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 32207, 32219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10037_32238_32260()
                {
                    var return_v = NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 32238, 32260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10037_32279_32302()
                {
                    var return_v = GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 32279, 32302);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10037_32321_32346()
                {
                    var return_v = SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 32321, 32346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_10037_32365_32390()
                {
                    var return_v = SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 32365, 32390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic?
                f_10037_32130_32427(Microsoft.CodeAnalysis.Diagnostic
                d, int
                warningLevelOption, Microsoft.CodeAnalysis.NullableContextOptions
                nullableOption, Microsoft.CodeAnalysis.ReportDiagnostic
                generalDiagnosticOption, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificDiagnosticOptions, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                syntaxTreeOptions, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CSharpDiagnosticFilter.Filter(d, warningLevelOption, nullableOption, generalDiagnosticOption, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>)specificDiagnosticOptions, syntaxTreeOptions, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 32130, 32427);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 31992, 32439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 31992, 32439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithModuleName(string? moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 32451, 32599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 32554, 32588);

                return f_10037_32561_32587(this, moduleName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 32451, 32599);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_32561_32587(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, string?
                moduleName)
                {
                    var return_v = this_param.WithModuleName(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 32561, 32587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 32451, 32599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 32451, 32599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithMainTypeName(string? mainTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 32611, 32767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 32718, 32756);

                return f_10037_32725_32755(this, mainTypeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 32611, 32767);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_32725_32755(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, string?
                name)
                {
                    var return_v = this_param.WithMainTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 32725, 32755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 32611, 32767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 32611, 32767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithScriptClassName(string? scriptClassName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 32779, 32947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 32892, 32936);

                return f_10037_32899_32935(this, scriptClassName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 32779, 32947);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_32899_32935(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, string?
                name)
                {
                    var return_v = this_param.WithScriptClassName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 32899, 32935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 32779, 32947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 32779, 32947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithCryptoKeyContainer(string? cryptoKeyContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 32959, 33139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 33078, 33128);

                return f_10037_33085_33127(this, cryptoKeyContainer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 32959, 33139);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_33085_33127(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, string?
                name)
                {
                    var return_v = this_param.WithCryptoKeyContainer(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 33085, 33127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 32959, 33139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 32959, 33139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithCryptoKeyFile(string? cryptoKeyFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 33151, 33311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 33260, 33300);

                return f_10037_33267_33299(this, cryptoKeyFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 33151, 33311);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_33267_33299(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, string?
                path)
                {
                    var return_v = this_param.WithCryptoKeyFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 33267, 33299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 33151, 33311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 33151, 33311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithCryptoPublicKey(ImmutableArray<byte> cryptoPublicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 33323, 33504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 33449, 33493);

                return f_10037_33456_33492(this, cryptoPublicKey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 33323, 33504);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_33456_33492(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = this_param.WithCryptoPublicKey(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 33456, 33492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 33323, 33504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 33323, 33504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithDelaySign(bool? delaySign)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 33516, 33658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 33615, 33647);

                return f_10037_33622_33646(this, delaySign);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 33516, 33658);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_33622_33646(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool?
                value)
                {
                    var return_v = this_param.WithDelaySign(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 33622, 33646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 33516, 33658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 33516, 33658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CompilationOptions CommonWithCheckOverflow(bool checkOverflow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10037, 33670, 33828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10037, 33776, 33817);

                return f_10037_33783_33816(this, checkOverflow);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10037, 33670, 33828);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10037_33783_33816(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                enabled)
                {
                    var return_v = this_param.WithOverflowChecks(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 33783, 33816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 33670, 33828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 33670, 33828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CSharpCompilationOptions(
                    OutputKind outputKind,
                    string? moduleName,
                    string? mainTypeName,
                    string? scriptClassName,
                    IEnumerable<string>? usings,
                    OptimizationLevel optimizationLevel,
                    bool checkOverflow,
                    bool allowUnsafe,
                    string? cryptoKeyContainer,
                    string? cryptoKeyFile,
                    ImmutableArray<byte> cryptoPublicKey,
                    bool? delaySign,
                    Platform platform,
                    ReportDiagnostic generalDiagnosticOption,
                    int warningLevel,
                    IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions,
                    bool concurrentBuild,
                    bool deterministic,
                    XmlReferenceResolver? xmlReferenceResolver,
                    SourceReferenceResolver? sourceReferenceResolver,
                    MetadataReferenceResolver? metadataReferenceResolver,
                    AssemblyIdentityComparer? assemblyIdentityComparer,
                    StrongNameProvider? strongNameProvider)
        : this(f_10037_35040_35050_C(outputKind), false, moduleName, mainTypeName, scriptClassName, usings, optimizationLevel, checkOverflow, allowUnsafe, cryptoKeyContainer, cryptoKeyFile, cryptoPublicKey, delaySign, platform, generalDiagnosticOption, warningLevel, specificDiagnosticOptions, concurrentBuild, deterministic, xmlReferenceResolver: xmlReferenceResolver, sourceReferenceResolver: sourceReferenceResolver, metadataReferenceResolver: metadataReferenceResolver, assemblyIdentityComparer: assemblyIdentityComparer, strongNameProvider: strongNameProvider, publicSign: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 33892, 35788);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 33892, 35788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 33892, 35788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 33892, 35788);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CSharpCompilationOptions(
                    OutputKind outputKind,
                    string? moduleName,
                    string? mainTypeName,
                    string? scriptClassName,
                    IEnumerable<string>? usings,
                    OptimizationLevel optimizationLevel,
                    bool checkOverflow,
                    bool allowUnsafe,
                    string? cryptoKeyContainer,
                    string? cryptoKeyFile,
                    ImmutableArray<byte> cryptoPublicKey,
                    bool? delaySign,
                    Platform platform,
                    ReportDiagnostic generalDiagnosticOption,
                    int warningLevel,
                    IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions,
                    bool concurrentBuild,
                    XmlReferenceResolver? xmlReferenceResolver,
                    SourceReferenceResolver? sourceReferenceResolver,
                    MetadataReferenceResolver? metadataReferenceResolver,
                    AssemblyIdentityComparer? assemblyIdentityComparer,
                    StrongNameProvider? strongNameProvider)
        : this(f_10037_36969_36979_C(outputKind), moduleName, mainTypeName, scriptClassName, usings, optimizationLevel, checkOverflow, allowUnsafe, cryptoKeyContainer, cryptoKeyFile, cryptoPublicKey, delaySign, platform, generalDiagnosticOption, warningLevel, specificDiagnosticOptions, concurrentBuild, deterministic: false, xmlReferenceResolver: xmlReferenceResolver, sourceReferenceResolver: sourceReferenceResolver, metadataReferenceResolver: metadataReferenceResolver, assemblyIdentityComparer: assemblyIdentityComparer, strongNameProvider: strongNameProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 35854, 37718);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 35854, 37718);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 35854, 37718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 35854, 37718);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CSharpCompilationOptions(
                    OutputKind outputKind,
                    bool reportSuppressedDiagnostics,
                    string? moduleName,
                    string? mainTypeName,
                    string? scriptClassName,
                    IEnumerable<string>? usings,
                    OptimizationLevel optimizationLevel,
                    bool checkOverflow,
                    bool allowUnsafe,
                    string? cryptoKeyContainer,
                    string? cryptoKeyFile,
                    ImmutableArray<byte> cryptoPublicKey,
                    bool? delaySign,
                    Platform platform,
                    ReportDiagnostic generalDiagnosticOption,
                    int warningLevel,
                    IEnumerable<KeyValuePair<string, ReportDiagnostic>>? specificDiagnosticOptions,
                    bool concurrentBuild,
                    bool deterministic,
                    XmlReferenceResolver? xmlReferenceResolver,
                    SourceReferenceResolver? sourceReferenceResolver,
                    MetadataReferenceResolver? metadataReferenceResolver,
                    AssemblyIdentityComparer? assemblyIdentityComparer,
                    StrongNameProvider? strongNameProvider)
        : this(f_10037_39193_39203_C(outputKind), false, moduleName, mainTypeName, scriptClassName, usings, optimizationLevel, checkOverflow, allowUnsafe, cryptoKeyContainer, cryptoKeyFile, cryptoPublicKey, delaySign, platform, generalDiagnosticOption, warningLevel, specificDiagnosticOptions, concurrentBuild, deterministic: deterministic, currentLocalTime: default, debugPlusMode: false, xmlReferenceResolver: xmlReferenceResolver, sourceReferenceResolver: sourceReferenceResolver, syntaxTreeOptionsProvider: null, metadataReferenceResolver: metadataReferenceResolver, assemblyIdentityComparer: assemblyIdentityComparer, strongNameProvider: strongNameProvider, metadataImportOptions: MetadataImportOptions.Public, referencesSupersedeLowerVersions: false, publicSign: false, topLevelBinderFlags: BinderFlags.None, nullableContextOptions: NullableContextOptions.Disable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10037, 37998, 40387);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10037, 37998, 40387);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10037, 37998, 40387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 37998, 40387);
            }
        }

        static CSharpCompilationOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10037, 708, 40394);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10037, 708, 40394);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10037, 708, 40394);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10037, 708, 40394);

        static Microsoft.CodeAnalysis.OutputKind
        f_10037_3501_3511_C(Microsoft.CodeAnalysis.OutputKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 1897, 4692);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_5985_5995_C(Microsoft.CodeAnalysis.OutputKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 4757, 6767);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_8057_8067_C(Microsoft.CodeAnalysis.OutputKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 6832, 8770);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
        f_10037_10631_10687(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>?
        items)
        {
            var return_v = items.ToImmutableDictionaryOrEmpty<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 10631, 10687);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_10037_11056_11083(System.Collections.Generic.IEnumerable<string>?
        items)
        {
            var return_v = items.AsImmutableOrEmpty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 11056, 11083);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_10349_10359_C(Microsoft.CodeAnalysis.OutputKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 8821, 11268);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_11378_11394(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.OutputKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11378, 11394);
            return return_v;
        }


        static string?
        f_10037_11421_11437(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.ModuleName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11421, 11437);
            return return_v;
        }


        static string?
        f_10037_11466_11484(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.MainTypeName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11466, 11484);
            return return_v;
        }


        static string?
        f_10037_11516_11537(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.ScriptClassName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11516, 11537);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_10037_11560_11572(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.Usings;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11560, 11572);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OptimizationLevel
        f_10037_11606_11629(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.OptimizationLevel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11606, 11629);
            return return_v;
        }


        static bool
        f_10037_11659_11678(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.CheckOverflow;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11659, 11678);
            return return_v;
        }


        static bool
        f_10037_11706_11723(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.AllowUnsafe;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11706, 11723);
            return return_v;
        }


        static string?
        f_10037_11758_11782(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.CryptoKeyContainer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11758, 11782);
            return return_v;
        }


        static string?
        f_10037_11812_11831(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.CryptoKeyFile;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11812, 11831);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<byte>
        f_10037_11863_11884(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.CryptoPublicKey;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11863, 11884);
            return return_v;
        }


        static bool?
        f_10037_11910_11925(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.DelaySign;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11910, 11925);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Platform
        f_10037_11950_11964(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.Platform;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 11950, 11964);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ReportDiagnostic
        f_10037_12004_12033(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.GeneralDiagnosticOption;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12004, 12033);
            return return_v;
        }


        static int
        f_10037_12062_12080(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.WarningLevel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12062, 12080);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
        f_10037_12122_12153(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.SpecificDiagnosticOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12122, 12153);
            return return_v;
        }


        static bool
        f_10037_12185_12206(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.ConcurrentBuild;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12185, 12206);
            return return_v;
        }


        static bool
        f_10037_12236_12255(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.Deterministic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12236, 12255);
            return return_v;
        }


        static System.DateTime
        f_10037_12288_12310(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.CurrentLocalTime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12288, 12310);
            return return_v;
        }


        static bool
        f_10037_12340_12359(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.DebugPlusMode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12340, 12359);
            return return_v;
        }


        static Microsoft.CodeAnalysis.XmlReferenceResolver?
        f_10037_12396_12422(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.XmlReferenceResolver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12396, 12422);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SourceReferenceResolver?
        f_10037_12462_12491(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.SourceReferenceResolver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12462, 12491);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
        f_10037_12533_12564(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.SyntaxTreeOptionsProvider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12533, 12564);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReferenceResolver?
        f_10037_12606_12637(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.MetadataReferenceResolver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12606, 12637);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AssemblyIdentityComparer
        f_10037_12678_12708(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.AssemblyIdentityComparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12678, 12708);
            return return_v;
        }


        static Microsoft.CodeAnalysis.StrongNameProvider?
        f_10037_12743_12767(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.StrongNameProvider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12743, 12767);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataImportOptions
        f_10037_12805_12832(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.MetadataImportOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12805, 12832);
            return return_v;
        }


        static bool
        f_10037_12881_12919(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.ReferencesSupersedeLowerVersions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12881, 12919);
            return return_v;
        }


        static bool
        f_10037_12963_12996(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.ReportSuppressedDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 12963, 12996);
            return return_v;
        }


        static bool
        f_10037_13023_13039(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.PublicSign;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 13023, 13039);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.BinderFlags
        f_10037_13075_13100(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.TopLevelBinderFlags;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 13075, 13100);
            return return_v;
        }


        static Microsoft.CodeAnalysis.NullableContextOptions
        f_10037_13139_13167(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.NullableContextOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 13139, 13167);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_11366_11394_C(Microsoft.CodeAnalysis.OutputKind
        outputKind)
        {
            var return_v = outputKind;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 11280, 13190);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>
        f_10037_13565_13571()
        {
            var return_v = Usings;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10037, 13565, 13571);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>
        f_10037_16573_16600(System.Collections.Generic.IEnumerable<string>?
        items)
        {
            var return_v = items.AsImmutableOrEmpty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 16573, 16600);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_16686_16726(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, string[]?
        usings)
        {
            var return_v = this_param.WithUsings((System.Collections.Generic.IEnumerable<string>?)usings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 16686, 16726);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_18651_18685(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.ReportDiagnostic
        value)
        {
            var return_v = this_param.WithGeneralDiagnosticOption(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 18651, 18685);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_18862_18918(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
        values)
        {
            var return_v = this_param.WithSpecificDiagnosticOptions(values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 18862, 18918);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_19101_19157(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>?
        values)
        {
            var return_v = this_param.WithSpecificDiagnosticOptions(values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 19101, 19157);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_19296_19356(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        reportSuppressedDiagnostics)
        {
            var return_v = this_param.WithReportSuppressedDiagnostics(reportSuppressedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 19296, 19356);
            return return_v;
        }


        System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
        f_10037_20422_20459(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>?
        items)
        {
            var return_v = items.ToImmutableDictionaryOrEmpty<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 20422, 20459);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_25418_25449(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        concurrentBuild)
        {
            var return_v = this_param.WithConcurrentBuild(concurrentBuild);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 25418, 25449);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_25545_25577(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        deterministic)
        {
            var return_v = this_param.WithDeterministic(deterministic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 25545, 25577);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_25669_25689(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.OutputKind
        kind)
        {
            var return_v = this_param.WithOutputKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 25669, 25689);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_25781_25803(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.Platform
        platform)
        {
            var return_v = this_param.WithPlatform(platform);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 25781, 25803);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_25895_25921(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        publicSign)
        {
            var return_v = this_param.WithPublicSign(publicSign);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 25895, 25921);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_26028_26056(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.OptimizationLevel
        value)
        {
            var return_v = this_param.WithOptimizationLevel(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 26028, 26056);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_26194_26232(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.AssemblyIdentityComparer?
        comparer)
        {
            var return_v = this_param.WithAssemblyIdentityComparer(comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 26194, 26232);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_26362_26396(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.XmlReferenceResolver?
        resolver)
        {
            var return_v = this_param.WithXmlReferenceResolver(resolver);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 26362, 26396);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_26532_26569(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.SourceReferenceResolver?
        resolver)
        {
            var return_v = this_param.WithSourceReferenceResolver(resolver);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 26532, 26569);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_26709_26748(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
        provider)
        {
            var return_v = this_param.WithSyntaxTreeOptionsProvider(provider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 26709, 26748);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_26888_26927(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver?
        resolver)
        {
            var return_v = this_param.WithMetadataReferenceResolver(resolver);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 26888, 26927);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_27053_27085(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.StrongNameProvider?
        provider)
        {
            var return_v = this_param.WithStrongNameProvider(provider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27053, 27085);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10037_27213_27245(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.MetadataImportOptions
        value)
        {
            var return_v = this_param.WithMetadataImportOptions(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10037, 27213, 27245);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_35040_35050_C(Microsoft.CodeAnalysis.OutputKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 33892, 35788);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_36969_36979_C(Microsoft.CodeAnalysis.OutputKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 35854, 37718);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OutputKind
        f_10037_39193_39203_C(Microsoft.CodeAnalysis.OutputKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10037, 37998, 40387);
            return return_v;
        }

    }
}
