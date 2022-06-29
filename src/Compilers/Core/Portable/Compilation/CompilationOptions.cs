// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract class CompilationOptions
    {
        public OutputKind OutputKind { get; protected set; }

        public string? ModuleName { get; protected set; }

        public string? ScriptClassName { get; protected set; }

        public string? MainTypeName { get; protected set; }

        public ImmutableArray<byte> CryptoPublicKey { get; protected set; }

        public string? CryptoKeyFile { get; protected set; }

        public string? CryptoKeyContainer { get; protected set; }

        public bool? DelaySign { get; protected set; }

        public bool PublicSign { get; protected set; }

        public bool CheckOverflow { get; protected set; }

        public Platform Platform { get; protected set; }

        public OptimizationLevel OptimizationLevel { get; protected set; }

        public ReportDiagnostic GeneralDiagnosticOption { get; protected set; }

        public int WarningLevel { get; protected set; }

        public bool ConcurrentBuild { get; protected set; }

        public bool Deterministic { get; protected set; }

        internal DateTime CurrentLocalTime { get; private protected set; }

        internal bool DebugPlusMode { get; private protected set; }

        public MetadataImportOptions MetadataImportOptions { get; protected set; }

        internal bool ReferencesSupersedeLowerVersions { get; private protected set; }

        internal abstract Diagnostic? FilterDiagnostic(Diagnostic diagnostic, CancellationToken cancellationToken);

        public ImmutableDictionary<string, ReportDiagnostic> SpecificDiagnosticOptions { get; protected set; }

        public SyntaxTreeOptionsProvider? SyntaxTreeOptionsProvider { get; protected set; }

        public bool ReportSuppressedDiagnostics { get; protected set; }

        public MetadataReferenceResolver? MetadataReferenceResolver { get; protected set; }

        public XmlReferenceResolver? XmlReferenceResolver { get; protected set; }

        public SourceReferenceResolver? SourceReferenceResolver { get; protected set; }

        public StrongNameProvider? StrongNameProvider { get; protected set; }

        public AssemblyIdentityComparer AssemblyIdentityComparer { get; protected set; }

        public abstract NullableContextOptions NullableContextOptions { get; protected set; }

        [Obsolete]
        protected internal ImmutableArray<string> Features
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 12202, 12289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 12238, 12274);

                    throw f_146_12244_12273();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(146, 12202, 12289);

                    System.NotImplementedException
                    f_146_12244_12273()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 12244, 12273);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 12107, 12411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 12107, 12411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 12303, 12400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 12349, 12385);

                    throw f_146_12355_12384();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(146, 12303, 12400);

                    System.NotImplementedException
                    f_146_12355_12384()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 12355, 12384);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 12107, 12411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 12107, 12411);
                }
            }
        }

        private readonly Lazy<ImmutableArray<Diagnostic>> _lazyErrors;

        internal CompilationOptions(
                    OutputKind outputKind,
                    bool reportSuppressedDiagnostics,
                    string? moduleName,
                    string? mainTypeName,
                    string? scriptClassName,
                    string? cryptoKeyContainer,
                    string? cryptoKeyFile,
                    ImmutableArray<byte> cryptoPublicKey,
                    bool? delaySign,
                    bool publicSign,
                    OptimizationLevel optimizationLevel,
                    bool checkOverflow,
                    Platform platform,
                    ReportDiagnostic generalDiagnosticOption,
                    int warningLevel,
                    ImmutableDictionary<string, ReportDiagnostic> specificDiagnosticOptions,
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
                    bool referencesSupersedeLowerVersions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(146, 12536, 15895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 755, 807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 1367, 1416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 1697, 1751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 2014, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 3503, 3555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 4328, 4385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 5287, 5333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 5874, 5920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 6069, 6118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 6273, 6321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 6551, 6617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 6718, 6789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 6908, 6955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 7092, 7143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 7274, 7323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 7794, 7853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 8389, 8463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 8617, 8695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 9237, 9339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 9469, 9552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 9738, 9801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 10111, 10194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 10507, 10580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 10863, 10942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 11126, 11195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 11466, 11546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 12473, 12484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 13876, 13905);

                this.OutputKind = outputKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 13919, 13948);

                this.ModuleName = moduleName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 13962, 13995);

                this.MainTypeName = mainTypeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14009, 14095);

                this.ScriptClassName = scriptClassName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(146, 14032, 14094) ?? WellKnownMemberNames.DefaultScriptClassName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14109, 14154);

                this.CryptoKeyContainer = cryptoKeyContainer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14168, 14248);

                this.CryptoKeyFile = (DynAbs.Tracing.TraceSender.Conditional_F1(146, 14189, 14224) || ((f_146_14189_14224(cryptoKeyFile) && DynAbs.Tracing.TraceSender.Conditional_F2(146, 14227, 14231)) || DynAbs.Tracing.TraceSender.Conditional_F3(146, 14234, 14247))) ? null : cryptoKeyFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14262, 14315);

                this.CryptoPublicKey = cryptoPublicKey.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14329, 14356);

                this.DelaySign = delaySign;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14370, 14405);

                this.CheckOverflow = checkOverflow;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14419, 14444);

                this.Platform = platform;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14458, 14513);

                this.GeneralDiagnosticOption = generalDiagnosticOption;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14527, 14560);

                this.WarningLevel = warningLevel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14574, 14633);

                this.SpecificDiagnosticOptions = specificDiagnosticOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14647, 14710);

                this.ReportSuppressedDiagnostics = reportSuppressedDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14724, 14767);

                this.OptimizationLevel = optimizationLevel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14781, 14820);

                this.ConcurrentBuild = concurrentBuild;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14834, 14869);

                this.Deterministic = deterministic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14883, 14924);

                this.CurrentLocalTime = currentLocalTime;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14938, 14973);

                this.DebugPlusMode = debugPlusMode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 14987, 15036);

                this.XmlReferenceResolver = xmlReferenceResolver;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15050, 15105);

                this.SourceReferenceResolver = sourceReferenceResolver;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15119, 15178);

                this.SyntaxTreeOptionsProvider = syntaxTreeOptionsProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15192, 15251);

                this.MetadataReferenceResolver = metadataReferenceResolver;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15265, 15310);

                this.StrongNameProvider = strongNameProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15324, 15417);

                this.AssemblyIdentityComparer = assemblyIdentityComparer ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.AssemblyIdentityComparer?>(146, 15356, 15416) ?? f_146_15384_15416());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15431, 15482);

                this.MetadataImportOptions = metadataImportOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15496, 15569);

                this.ReferencesSupersedeLowerVersions = referencesSupersedeLowerVersions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15583, 15612);

                this.PublicSign = publicSign;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 15628, 15884);

                _lazyErrors = f_146_15642_15883(() =>
                            {
                                var builder = ArrayBuilder<Diagnostic>.GetInstance();
                                ValidateOptions(builder);
                                return builder.ToImmutableAndFree();
                            });
                DynAbs.Tracing.TraceSender.TraceExitConstructor(146, 12536, 15895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 12536, 15895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 12536, 15895);
            }
        }

        internal bool CanReuseCompilationReferenceManager(CompilationOptions other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 15907, 17012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 16467, 17001);

                return f_146_16474_16500(this) == f_146_16504_16531(other) && (DynAbs.Tracing.TraceSender.Expression_True(146, 16474, 16631) && f_146_16552_16589(this) == f_146_16593_16631(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 16474, 16715) && f_146_16652_16681(f_146_16652_16667(this)) == f_146_16685_16715(f_146_16685_16701(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 16474, 16804) && f_146_16736_16804(f_146_16750_16775(this), f_146_16777_16803(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 16474, 16903) && f_146_16825_16903(f_146_16839_16869(this), f_146_16871_16902(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 16474, 17000) && f_146_16924_17000(f_146_16938_16967(this), f_146_16969_16999(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 15907, 17012);

                Microsoft.CodeAnalysis.MetadataImportOptions
                f_146_16474_16500(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16474, 16500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_146_16504_16531(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16504, 16531);
                    return return_v;
                }


                bool
                f_146_16552_16589(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReferencesSupersedeLowerVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16552, 16589);
                    return return_v;
                }


                bool
                f_146_16593_16631(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReferencesSupersedeLowerVersions
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16593, 16631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_146_16652_16667(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16652, 16667);
                    return return_v;
                }


                bool
                f_146_16652_16681(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 16652, 16681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_146_16685_16701(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16685, 16701);
                    return return_v;
                }


                bool
                f_146_16685_16715(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 16685, 16715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_146_16750_16775(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16750, 16775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_146_16777_16803(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16777, 16803);
                    return return_v;
                }


                bool
                f_146_16736_16804(Microsoft.CodeAnalysis.XmlReferenceResolver?
                objA, Microsoft.CodeAnalysis.XmlReferenceResolver?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 16736, 16804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_146_16839_16869(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16839, 16869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_146_16871_16902(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16871, 16902);
                    return return_v;
                }


                bool
                f_146_16825_16903(Microsoft.CodeAnalysis.MetadataReferenceResolver?
                objA, Microsoft.CodeAnalysis.MetadataReferenceResolver?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 16825, 16903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_146_16938_16967(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16938, 16967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_146_16969_16999(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 16969, 16999);
                    return return_v;
                }


                bool
                f_146_16924_17000(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                objA, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 16924, 17000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 15907, 17012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 15907, 17012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract string Language { get; }

        internal bool EnableEditAndContinue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 17247, 17350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 17283, 17335);

                    return f_146_17290_17307() == OptimizationLevel.Debug;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(146, 17247, 17350);

                    Microsoft.CodeAnalysis.OptimizationLevel
                    f_146_17290_17307()
                    {
                        var return_v = OptimizationLevel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 17290, 17307);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 17187, 17361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 17187, 17361);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsValidFileAlignment(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(146, 17373, 17741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 17450, 17730);

                switch (value)
                {

                    case 512:
                    case 1024:
                    case 2048:
                    case 4096:
                    case 8192:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 17450, 17730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 17640, 17652);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(146, 17450, 17730);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 17450, 17730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 17702, 17715);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(146, 17450, 17730);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(146, 17373, 17741);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 17373, 17741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 17373, 17741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract ImmutableArray<string> GetImports();

        public CompilationOptions WithGeneralDiagnosticOption(ReportDiagnostic value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 17956, 18117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 18058, 18106);

                return f_146_18065_18105(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 17956, 18117);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_18065_18105(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.ReportDiagnostic
                generalDiagnosticOption)
                {
                    var return_v = this_param.CommonWithGeneralDiagnosticOption(generalDiagnosticOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 18065, 18105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 17956, 18117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 17956, 18117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithSpecificDiagnosticOptions(ImmutableDictionary<string, ReportDiagnostic>? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 18268, 18463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 18402, 18452);

                return f_146_18409_18451(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 18268, 18463);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_18409_18451(Microsoft.CodeAnalysis.CompilationOptions
                this_param, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                specificDiagnosticOptions)
                {
                    var return_v = this_param.CommonWithSpecificDiagnosticOptions(specificDiagnosticOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 18409, 18451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 18268, 18463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 18268, 18463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithSpecificDiagnosticOptions(IEnumerable<KeyValuePair<string, ReportDiagnostic>> value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 18614, 18814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 18753, 18803);

                return f_146_18760_18802(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 18614, 18814);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_18760_18802(Microsoft.CodeAnalysis.CompilationOptions
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
                specificDiagnosticOptions)
                {
                    var return_v = this_param.CommonWithSpecificDiagnosticOptions(specificDiagnosticOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 18760, 18802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 18614, 18814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 18614, 18814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithReportSuppressedDiagnostics(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 18977, 19134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 19071, 19123);

                return f_146_19078_19122(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 18977, 19134);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_19078_19122(Microsoft.CodeAnalysis.CompilationOptions
                this_param, bool
                reportSuppressedDiagnostics)
                {
                    var return_v = this_param.CommonWithReportSuppressedDiagnostics(reportSuppressedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 19078, 19122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 18977, 19134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 18977, 19134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithConcurrentBuild(bool concurrent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 19289, 19432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 19376, 19421);

                return f_146_19383_19420(this, concurrent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 19289, 19432);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_19383_19420(Microsoft.CodeAnalysis.CompilationOptions
                this_param, bool
                concurrent)
                {
                    var return_v = this_param.CommonWithConcurrentBuild(concurrent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 19383, 19420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 19289, 19432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 19289, 19432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithDeterministic(bool deterministic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 19584, 19729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 19672, 19718);

                return f_146_19679_19717(this, deterministic);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 19584, 19729);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_19679_19717(Microsoft.CodeAnalysis.CompilationOptions
                this_param, bool
                deterministic)
                {
                    var return_v = this_param.CommonWithDeterministic(deterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 19679, 19717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 19584, 19729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 19584, 19729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithOutputKind(OutputKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 19864, 19991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 19946, 19980);

                return f_146_19953_19979(this, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 19864, 19991);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_19953_19979(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = this_param.CommonWithOutputKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 19953, 19979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 19864, 19991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 19864, 19991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithPlatform(Platform platform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 20123, 20252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 20205, 20241);

                return f_146_20212_20240(this, platform);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 20123, 20252);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_20212_20240(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    var return_v = this_param.CommonWithPlatform(platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 20212, 20240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 20123, 20252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 20123, 20252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithPublicSign(bool publicSign)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 20453, 20488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 20456, 20488);
                return f_146_20456_20488(this, publicSign); DynAbs.Tracing.TraceSender.TraceExitMethod(146, 20453, 20488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 20453, 20488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 20453, 20488);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CompilationOptions
            f_146_20456_20488(Microsoft.CodeAnalysis.CompilationOptions
            this_param, bool
            publicSign)
            {
                var return_v = this_param.CommonWithPublicSign(publicSign);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 20456, 20488);
                return return_v;
            }

        }

        public CompilationOptions WithOptimizationLevel(OptimizationLevel value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 20632, 20782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 20729, 20771);

                return f_146_20736_20770(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 20632, 20782);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_20736_20770(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.OptimizationLevel
                value)
                {
                    var return_v = this_param.CommonWithOptimizationLevel(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 20736, 20770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 20632, 20782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 20632, 20782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithXmlReferenceResolver(XmlReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 20794, 20960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 20901, 20949);

                return f_146_20908_20948(this, resolver);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 20794, 20960);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_20908_20948(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.XmlReferenceResolver?
                resolver)
                {
                    var return_v = this_param.CommonWithXmlReferenceResolver(resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 20908, 20948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 20794, 20960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 20794, 20960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithSourceReferenceResolver(SourceReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 20972, 21147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 21085, 21136);

                return f_146_21092_21135(this, resolver);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 20972, 21147);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_21092_21135(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.SourceReferenceResolver?
                resolver)
                {
                    var return_v = this_param.CommonWithSourceReferenceResolver(resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 21092, 21135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 20972, 21147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 20972, 21147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithSyntaxTreeOptionsProvider(SyntaxTreeOptionsProvider? provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 21159, 21340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 21276, 21329);

                return f_146_21283_21328(this, provider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 21159, 21340);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_21283_21328(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                resolver)
                {
                    var return_v = this_param.CommonWithSyntaxTreeOptionsProvider(resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 21283, 21328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 21159, 21340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 21159, 21340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithMetadataReferenceResolver(MetadataReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 21352, 21533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 21469, 21522);

                return f_146_21476_21521(this, resolver);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 21352, 21533);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_21476_21521(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver?
                resolver)
                {
                    var return_v = this_param.CommonWithMetadataReferenceResolver(resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 21476, 21521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 21352, 21533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 21352, 21533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithAssemblyIdentityComparer(AssemblyIdentityComparer comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 21545, 21722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 21659, 21711);

                return f_146_21666_21710(this, comparer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 21545, 21722);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_21666_21710(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                comparer)
                {
                    var return_v = this_param.CommonWithAssemblyIdentityComparer(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 21666, 21710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 21545, 21722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 21545, 21722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithStrongNameProvider(StrongNameProvider? provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 21734, 21894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 21837, 21883);

                return f_146_21844_21882(this, provider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 21734, 21894);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_21844_21882(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.StrongNameProvider?
                provider)
                {
                    var return_v = this_param.CommonWithStrongNameProvider(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 21844, 21882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 21734, 21894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 21734, 21894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithModuleName(string? moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 21906, 22042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 21991, 22031);

                return f_146_21998_22030(this, moduleName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 21906, 22042);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_21998_22030(Microsoft.CodeAnalysis.CompilationOptions
                this_param, string?
                moduleName)
                {
                    var return_v = this_param.CommonWithModuleName(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 21998, 22030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 21906, 22042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 21906, 22042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithMainTypeName(string? mainTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 22054, 22198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 22143, 22187);

                return f_146_22150_22186(this, mainTypeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 22054, 22198);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_22150_22186(Microsoft.CodeAnalysis.CompilationOptions
                this_param, string?
                mainTypeName)
                {
                    var return_v = this_param.CommonWithMainTypeName(mainTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 22150, 22186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 22054, 22198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 22054, 22198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithScriptClassName(string scriptClassName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 22210, 22365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 22304, 22354);

                return f_146_22311_22353(this, scriptClassName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 22210, 22365);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_22311_22353(Microsoft.CodeAnalysis.CompilationOptions
                this_param, string
                scriptClassName)
                {
                    var return_v = this_param.CommonWithScriptClassName(scriptClassName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 22311, 22353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 22210, 22365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 22210, 22365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithCryptoKeyContainer(string? cryptoKeyContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 22377, 22545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 22478, 22534);

                return f_146_22485_22533(this, cryptoKeyContainer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 22377, 22545);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_22485_22533(Microsoft.CodeAnalysis.CompilationOptions
                this_param, string?
                cryptoKeyContainer)
                {
                    var return_v = this_param.CommonWithCryptoKeyContainer(cryptoKeyContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 22485, 22533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 22377, 22545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 22377, 22545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithCryptoKeyFile(string? cryptoKeyFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 22557, 22705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 22648, 22694);

                return f_146_22655_22693(this, cryptoKeyFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 22557, 22705);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_22655_22693(Microsoft.CodeAnalysis.CompilationOptions
                this_param, string?
                cryptoKeyFile)
                {
                    var return_v = this_param.CommonWithCryptoKeyFile(cryptoKeyFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 22655, 22693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 22557, 22705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 22557, 22705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithCryptoPublicKey(ImmutableArray<byte> cryptoPublicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 22717, 22886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 22825, 22875);

                return f_146_22832_22874(this, cryptoPublicKey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 22717, 22886);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_22832_22874(Microsoft.CodeAnalysis.CompilationOptions
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                cryptoPublicKey)
                {
                    var return_v = this_param.CommonWithCryptoPublicKey(cryptoPublicKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 22832, 22874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 22717, 22886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 22717, 22886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithDelaySign(bool? delaySign)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 22898, 23028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 22979, 23017);

                return f_146_22986_23016(this, delaySign);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 22898, 23028);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_22986_23016(Microsoft.CodeAnalysis.CompilationOptions
                this_param, bool?
                delaySign)
                {
                    var return_v = this_param.CommonWithDelaySign(delaySign);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 22986, 23016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 22898, 23028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 22898, 23028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithOverflowChecks(bool checkOverflow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 23040, 23186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 23129, 23175);

                return f_146_23136_23174(this, checkOverflow);
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 23040, 23186);

                Microsoft.CodeAnalysis.CompilationOptions
                f_146_23136_23174(Microsoft.CodeAnalysis.CompilationOptions
                this_param, bool
                checkOverflow)
                {
                    var return_v = this_param.CommonWithCheckOverflow(checkOverflow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 23136, 23174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 23040, 23186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 23040, 23186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationOptions WithMetadataImportOptions(MetadataImportOptions value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 23279, 23320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 23282, 23320);
                return f_146_23282_23320(this, value); DynAbs.Tracing.TraceSender.TraceExitMethod(146, 23279, 23320);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 23279, 23320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 23279, 23320);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CompilationOptions
            f_146_23282_23320(Microsoft.CodeAnalysis.CompilationOptions
            this_param, Microsoft.CodeAnalysis.MetadataImportOptions
            value)
            {
                var return_v = this_param.CommonWithMetadataImportOptions(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 23282, 23320);
                return return_v;
            }

        }

        protected abstract CompilationOptions CommonWithConcurrentBuild(bool concurrent);

        protected abstract CompilationOptions CommonWithDeterministic(bool deterministic);

        protected abstract CompilationOptions CommonWithOutputKind(OutputKind kind);

        protected abstract CompilationOptions CommonWithPlatform(Platform platform);

        protected abstract CompilationOptions CommonWithPublicSign(bool publicSign);

        protected abstract CompilationOptions CommonWithOptimizationLevel(OptimizationLevel value);

        protected abstract CompilationOptions CommonWithXmlReferenceResolver(XmlReferenceResolver? resolver);

        protected abstract CompilationOptions CommonWithSourceReferenceResolver(SourceReferenceResolver? resolver);

        protected abstract CompilationOptions CommonWithSyntaxTreeOptionsProvider(SyntaxTreeOptionsProvider? resolver);

        protected abstract CompilationOptions CommonWithMetadataReferenceResolver(MetadataReferenceResolver? resolver);

        protected abstract CompilationOptions CommonWithAssemblyIdentityComparer(AssemblyIdentityComparer? comparer);

        protected abstract CompilationOptions CommonWithStrongNameProvider(StrongNameProvider? provider);

        protected abstract CompilationOptions CommonWithGeneralDiagnosticOption(ReportDiagnostic generalDiagnosticOption);

        protected abstract CompilationOptions CommonWithSpecificDiagnosticOptions(ImmutableDictionary<string, ReportDiagnostic>? specificDiagnosticOptions);

        protected abstract CompilationOptions CommonWithSpecificDiagnosticOptions(IEnumerable<KeyValuePair<string, ReportDiagnostic>> specificDiagnosticOptions);

        protected abstract CompilationOptions CommonWithReportSuppressedDiagnostics(bool reportSuppressedDiagnostics);

        protected abstract CompilationOptions CommonWithModuleName(string? moduleName);

        protected abstract CompilationOptions CommonWithMainTypeName(string? mainTypeName);

        protected abstract CompilationOptions CommonWithScriptClassName(string scriptClassName);

        protected abstract CompilationOptions CommonWithCryptoKeyContainer(string? cryptoKeyContainer);

        protected abstract CompilationOptions CommonWithCryptoKeyFile(string? cryptoKeyFile);

        protected abstract CompilationOptions CommonWithCryptoPublicKey(ImmutableArray<byte> cryptoPublicKey);

        protected abstract CompilationOptions CommonWithDelaySign(bool? delaySign);

        protected abstract CompilationOptions CommonWithCheckOverflow(bool checkOverflow);

        protected abstract CompilationOptions CommonWithMetadataImportOptions(MetadataImportOptions value);

        [Obsolete]
        protected abstract CompilationOptions CommonWithFeatures(ImmutableArray<string> features);

        internal abstract void ValidateOptions(ArrayBuilder<Diagnostic> builder);

        internal void ValidateOptions(ArrayBuilder<Diagnostic> builder, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 26366, 28071);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 26493, 27132) || true) && (f_146_26497_26521_M(!f_146_26498_26513().IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 26493, 27132);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 26555, 26821) || true) && (f_146_26559_26572() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 26555, 26821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 26622, 26802);

                        f_146_26622_26801(builder, f_146_26634_26800(messageProvider, f_146_26667_26711(messageProvider), f_146_26738_26751(), nameof(CryptoPublicKey), nameof(CryptoKeyFile)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(146, 26555, 26821);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 26841, 27117) || true) && (f_146_26845_26863() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 26841, 27117);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 26913, 27098);

                        f_146_26913_27097(builder, f_146_26925_27096(messageProvider, f_146_26958_27002(messageProvider), f_146_27029_27042(), nameof(CryptoPublicKey), nameof(CryptoKeyContainer)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(146, 26841, 27117);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(146, 26493, 27132);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 27148, 28060) || true) && (f_146_27152_27162())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 27148, 28060);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 27196, 27481) || true) && (f_146_27200_27213() != null && (DynAbs.Tracing.TraceSender.Expression_True(146, 27200, 27265) && !f_146_27226_27265(f_146_27251_27264())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 27196, 27481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 27307, 27462);

                        f_146_27307_27461(builder, f_146_27319_27460(messageProvider, f_146_27352_27396(messageProvider), f_146_27423_27436(), nameof(CryptoKeyFile)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(146, 27196, 27481);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 27501, 27772) || true) && (f_146_27505_27523() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 27501, 27772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 27573, 27753);

                        f_146_27573_27752(builder, f_146_27585_27751(messageProvider, f_146_27618_27662(messageProvider), f_146_27689_27702(), nameof(PublicSign), nameof(CryptoKeyContainer)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(146, 27501, 27772);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 27792, 28045) || true) && (f_146_27796_27805() == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 27792, 28045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 27855, 28026);

                        f_146_27855_28025(builder, f_146_27867_28024(messageProvider, f_146_27900_27944(messageProvider), f_146_27971_27984(), nameof(PublicSign), nameof(DelaySign)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(146, 27792, 28045);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(146, 27148, 28060);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 26366, 28071);

                System.Collections.Immutable.ImmutableArray<byte>
                f_146_26498_26513()
                {
                    var return_v = CryptoPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 26498, 26513);
                    return return_v;
                }


                bool
                f_146_26497_26521_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 26497, 26521);
                    return return_v;
                }


                string?
                f_146_26559_26572()
                {
                    var return_v = CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 26559, 26572);
                    return return_v;
                }


                int
                f_146_26667_26711(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MutuallyExclusiveOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 26667, 26711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_146_26738_26751()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 26738, 26751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_146_26634_26800(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 26634, 26800);
                    return return_v;
                }


                int
                f_146_26622_26801(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 26622, 26801);
                    return 0;
                }


                string?
                f_146_26845_26863()
                {
                    var return_v = CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 26845, 26863);
                    return return_v;
                }


                int
                f_146_26958_27002(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MutuallyExclusiveOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 26958, 27002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_146_27029_27042()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27029, 27042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_146_26925_27096(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 26925, 27096);
                    return return_v;
                }


                int
                f_146_26913_27097(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 26913, 27097);
                    return 0;
                }


                bool
                f_146_27152_27162()
                {
                    var return_v = PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27152, 27162);
                    return return_v;
                }


                string?
                f_146_27200_27213()
                {
                    var return_v = CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27200, 27213);
                    return return_v;
                }


                string
                f_146_27251_27264()
                {
                    var return_v = CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27251, 27264);
                    return return_v;
                }


                bool
                f_146_27226_27265(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 27226, 27265);
                    return return_v;
                }


                int
                f_146_27352_27396(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_OptionMustBeAbsolutePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27352, 27396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_146_27423_27436()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27423, 27436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_146_27319_27460(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 27319, 27460);
                    return return_v;
                }


                int
                f_146_27307_27461(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 27307, 27461);
                    return 0;
                }


                string?
                f_146_27505_27523()
                {
                    var return_v = CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27505, 27523);
                    return return_v;
                }


                int
                f_146_27618_27662(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MutuallyExclusiveOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27618, 27662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_146_27689_27702()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27689, 27702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_146_27585_27751(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 27585, 27751);
                    return return_v;
                }


                int
                f_146_27573_27752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 27573, 27752);
                    return 0;
                }


                bool?
                f_146_27796_27805()
                {
                    var return_v = DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27796, 27805);
                    return return_v;
                }


                int
                f_146_27900_27944(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MutuallyExclusiveOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27900, 27944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_146_27971_27984()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 27971, 27984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_146_27867_28024(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 27867, 28024);
                    return return_v;
                }


                int
                f_146_27855_28025(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 27855, 28025);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 26366, 28071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 26366, 28071);
            }
        }

        public ImmutableArray<Diagnostic> Errors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 28280, 28313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 28286, 28311);

                    return f_146_28293_28310(_lazyErrors);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(146, 28280, 28313);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_146_28293_28310(System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 28293, 28310);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 28215, 28324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 28215, 28324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override bool Equals(object? obj);

        protected bool EqualsHelper([NotNullWhen(true)] CompilationOptions? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 28398, 31363);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 28497, 28598) || true) && (f_146_28501_28536(other, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(146, 28497, 28598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 28570, 28583);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(146, 28497, 28598);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 28804, 31323);

                bool
                equal =
                f_146_28837_28855(this) == f_146_28859_28878(other) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 28947) && f_146_28902_28922(this) == f_146_28926_28947(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29012) && f_146_28971_28989(this) == f_146_28993_29012(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29083) && f_146_29036_29057(this) == f_146_29061_29083(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29148) && f_146_29107_29125(this) == f_146_29129_29148(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29262) && f_146_29172_29262(f_146_29186_29209(this), f_146_29211_29235(other), StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29366) && f_146_29286_29366(f_146_29300_29318(this), f_146_29320_29339(other), StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29447) && this.CryptoPublicKey.SequenceEqual(f_146_29425_29446(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29504) && f_146_29471_29485(this) == f_146_29489_29504(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29589) && f_146_29528_29556(this) == f_146_29560_29589(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29691) && f_146_29613_29691(f_146_29627_29644(this), f_146_29646_29664(other), StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29772) && f_146_29715_29741(this) == f_146_29745_29772(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29875) && f_146_29796_29833(this) == f_146_29837_29875(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 29973) && f_146_29899_29973(f_146_29913_29928(this), f_146_29930_29946(other), StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30046) && f_146_29997_30019(this) == f_146_30023_30046(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30105) && f_146_30070_30085(this) == f_146_30089_30105(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30160) && f_146_30129_30142(this) == f_146_30146_30160(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30253) && f_146_30184_30216(this) == f_146_30220_30253(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30361) && f_146_30277_30361(f_146_30291_30311(this), f_146_30313_30334(other), StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30535) && f_146_30385_30535(f_146_30385_30415(this), f_146_30430_30461(other), (left, right) => (left.Key == right.Key) && (left.Value == right.Value))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30598) && f_146_30559_30576(this) == f_146_30580_30598(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30700) && f_146_30622_30700(f_146_30636_30666(this), f_146_30668_30699(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30792) && f_146_30724_30792(f_146_30738_30763(this), f_146_30765_30791(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30890) && f_146_30816_30890(f_146_30830_30858(this), f_146_30860_30889(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 30992) && f_146_30914_30992(f_146_30928_30958(this), f_146_30960_30991(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 31080) && f_146_31016_31080(f_146_31030_31053(this), f_146_31055_31079(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 31180) && f_146_31104_31180(f_146_31118_31147(this), f_146_31149_31179(other))) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 31239) && f_146_31204_31219(this) == f_146_31223_31239(other)) && (DynAbs.Tracing.TraceSender.Expression_True(146, 28837, 31322) && f_146_31263_31290(this) == f_146_31294_31322(other))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 31339, 31352);

                return equal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 28398, 31363);

                bool
                f_146_28501_28536(Microsoft.CodeAnalysis.CompilationOptions?
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 28501, 28536);
                    return return_v;
                }


                bool
                f_146_28837_28855(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CheckOverflow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 28837, 28855);
                    return return_v;
                }


                bool
                f_146_28859_28878(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CheckOverflow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 28859, 28878);
                    return return_v;
                }


                bool
                f_146_28902_28922(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 28902, 28922);
                    return return_v;
                }


                bool
                f_146_28926_28947(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 28926, 28947);
                    return return_v;
                }


                bool
                f_146_28971_28989(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Deterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 28971, 28989);
                    return return_v;
                }


                bool
                f_146_28993_29012(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Deterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 28993, 29012);
                    return return_v;
                }


                System.DateTime
                f_146_29036_29057(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CurrentLocalTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29036, 29057);
                    return return_v;
                }


                System.DateTime
                f_146_29061_29083(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CurrentLocalTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29061, 29083);
                    return return_v;
                }


                bool
                f_146_29107_29125(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DebugPlusMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29107, 29125);
                    return return_v;
                }


                bool
                f_146_29129_29148(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DebugPlusMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29129, 29148);
                    return return_v;
                }


                string?
                f_146_29186_29209(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29186, 29209);
                    return return_v;
                }


                string?
                f_146_29211_29235(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29211, 29235);
                    return return_v;
                }


                bool
                f_146_29172_29262(string?
                a, string?
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 29172, 29262);
                    return return_v;
                }


                string?
                f_146_29300_29318(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29300, 29318);
                    return return_v;
                }


                string?
                f_146_29320_29339(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29320, 29339);
                    return return_v;
                }


                bool
                f_146_29286_29366(string?
                a, string?
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 29286, 29366);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_146_29425_29446(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29425, 29446);
                    return return_v;
                }


                bool?
                f_146_29471_29485(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29471, 29485);
                    return return_v;
                }


                bool?
                f_146_29489_29504(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29489, 29504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_146_29528_29556(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29528, 29556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_146_29560_29589(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29560, 29589);
                    return return_v;
                }


                string?
                f_146_29627_29644(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29627, 29644);
                    return return_v;
                }


                string?
                f_146_29646_29664(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29646, 29664);
                    return return_v;
                }


                bool
                f_146_29613_29691(string?
                a, string?
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 29613, 29691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_146_29715_29741(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29715, 29741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_146_29745_29772(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29745, 29772);
                    return return_v;
                }


                bool
                f_146_29796_29833(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReferencesSupersedeLowerVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29796, 29833);
                    return return_v;
                }


                bool
                f_146_29837_29875(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReferencesSupersedeLowerVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29837, 29875);
                    return return_v;
                }


                string?
                f_146_29913_29928(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29913, 29928);
                    return return_v;
                }


                string?
                f_146_29930_29946(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29930, 29946);
                    return return_v;
                }


                bool
                f_146_29899_29973(string?
                a, string?
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 29899, 29973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_146_29997_30019(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 29997, 30019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_146_30023_30046(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30023, 30046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_146_30070_30085(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30070, 30085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_146_30089_30105(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30089, 30105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Platform
                f_146_30129_30142(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30129, 30142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Platform
                f_146_30146_30160(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30146, 30160);
                    return return_v;
                }


                bool
                f_146_30184_30216(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30184, 30216);
                    return return_v;
                }


                bool
                f_146_30220_30253(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30220, 30253);
                    return return_v;
                }


                string?
                f_146_30291_30311(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30291, 30311);
                    return return_v;
                }


                string?
                f_146_30313_30334(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30313, 30334);
                    return return_v;
                }


                bool
                f_146_30277_30361(string?
                a, string?
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 30277, 30361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_146_30385_30415(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30385, 30415);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_146_30430_30461(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30430, 30461);
                    return return_v;
                }


                bool
                f_146_30385_30535(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                first, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                second, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>, bool>
                comparer)
                {
                    var return_v = first.SequenceEqual<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>)second, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 30385, 30535);
                    return return_v;
                }


                int
                f_146_30559_30576(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30559, 30576);
                    return return_v;
                }


                int
                f_146_30580_30598(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30580, 30598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_146_30636_30666(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30636, 30666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_146_30668_30699(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30668, 30699);
                    return return_v;
                }


                bool
                f_146_30622_30700(Microsoft.CodeAnalysis.MetadataReferenceResolver?
                objA, Microsoft.CodeAnalysis.MetadataReferenceResolver?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 30622, 30700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_146_30738_30763(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30738, 30763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_146_30765_30791(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30765, 30791);
                    return return_v;
                }


                bool
                f_146_30724_30792(Microsoft.CodeAnalysis.XmlReferenceResolver?
                objA, Microsoft.CodeAnalysis.XmlReferenceResolver?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 30724, 30792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_146_30830_30858(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30830, 30858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_146_30860_30889(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30860, 30889);
                    return return_v;
                }


                bool
                f_146_30816_30890(Microsoft.CodeAnalysis.SourceReferenceResolver?
                objA, Microsoft.CodeAnalysis.SourceReferenceResolver?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 30816, 30890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_146_30928_30958(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30928, 30958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_146_30960_30991(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 30960, 30991);
                    return return_v;
                }


                bool
                f_146_30914_30992(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                objA, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 30914, 30992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_146_31030_31053(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31030, 31053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_146_31055_31079(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31055, 31079);
                    return return_v;
                }


                bool
                f_146_31016_31080(Microsoft.CodeAnalysis.StrongNameProvider?
                objA, Microsoft.CodeAnalysis.StrongNameProvider?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31016, 31080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_146_31118_31147(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31118, 31147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_146_31149_31179(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31149, 31179);
                    return return_v;
                }


                bool
                f_146_31104_31180(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                objA, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31104, 31180);
                    return return_v;
                }


                bool
                f_146_31204_31219(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31204, 31219);
                    return return_v;
                }


                bool
                f_146_31223_31239(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31223, 31239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_146_31263_31290(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31263, 31290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_146_31294_31322(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31294, 31322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 28398, 31363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 28398, 31363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract override int GetHashCode();

        protected int GetHashCodeHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(146, 31430, 33567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 31488, 33556);

                return f_146_31495_33555(f_146_31508_31526(this), f_146_31548_33554(f_146_31561_31581(this), f_146_31603_33553(f_146_31616_31634(this), f_146_31656_33552(this.CurrentLocalTime.GetHashCode(), f_146_31726_33551(f_146_31739_31757(this), f_146_31779_33550((DynAbs.Tracing.TraceSender.Conditional_F1(146, 31792, 31823) || ((f_146_31792_31815(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(146, 31826, 31885)) || DynAbs.Tracing.TraceSender.Conditional_F3(146, 31888, 31889))) ? f_146_31826_31885(f_146_31826_31848(), f_146_31861_31884(this)) : 0, f_146_31911_33549((DynAbs.Tracing.TraceSender.Conditional_F1(146, 31924, 31950) || ((f_146_31924_31942(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(146, 31953, 32007)) || DynAbs.Tracing.TraceSender.Conditional_F3(146, 32010, 32011))) ? f_146_31953_32007(f_146_31953_31975(), f_146_31988_32006(this)) : 0, f_146_32033_33548(f_146_32046_32090(f_146_32065_32085(this), 16), f_146_32112_33547(f_146_32130_32158(this), f_146_32180_33546((DynAbs.Tracing.TraceSender.Conditional_F1(146, 32193, 32218) || ((f_146_32193_32210(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(146, 32221, 32274)) || DynAbs.Tracing.TraceSender.Conditional_F3(146, 32277, 32278))) ? f_146_32221_32274(f_146_32221_32243(), f_146_32256_32273(this)) : 0, f_146_32300_33545(f_146_32318_32344(this), f_146_32366_33544(f_146_32379_32416(this), f_146_32438_33543((DynAbs.Tracing.TraceSender.Conditional_F1(146, 32451, 32474) || ((f_146_32451_32466(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(146, 32477, 32528)) || DynAbs.Tracing.TraceSender.Conditional_F3(146, 32531, 32532))) ? f_146_32477_32528(f_146_32477_32499(), f_146_32512_32527(this)) : 0, f_146_32554_33542(f_146_32572_32594(this), f_146_32616_33541(f_146_32634_32649(this), f_146_32671_33540(f_146_32689_32702(this), f_146_32724_33539(f_146_32737_32769(this), f_146_32791_33538((DynAbs.Tracing.TraceSender.Conditional_F1(146, 32804, 32832) || ((f_146_32804_32824(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(146, 32835, 32891)) || DynAbs.Tracing.TraceSender.Conditional_F3(146, 32894, 32895))) ? f_146_32835_32891(f_146_32835_32857(), f_146_32870_32890(this)) : 0, f_146_32917_33537(f_146_32930_32980(f_146_32949_32979(this)), f_146_33002_33536(f_146_33015_33032(this), f_146_33054_33535(f_146_33067_33097(this), f_146_33119_33534(f_146_33132_33157(this), f_146_33179_33533(f_146_33192_33220(this), f_146_33242_33532(f_146_33255_33285(this), f_146_33307_33531(f_146_33320_33343(this), f_146_33365_33530(f_146_33378_33407(this), f_146_33429_33529(f_146_33442_33457(this), f_146_33479_33528(f_146_33497_33524(this), 0))))))))))))))))))))))))))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(146, 31430, 33567);

                bool
                f_146_31508_31526(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CheckOverflow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31508, 31526);
                    return return_v;
                }


                bool
                f_146_31561_31581(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31561, 31581);
                    return return_v;
                }


                bool
                f_146_31616_31634(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Deterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31616, 31634);
                    return return_v;
                }


                bool
                f_146_31739_31757(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DebugPlusMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31739, 31757);
                    return return_v;
                }


                string?
                f_146_31792_31815(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31792, 31815);
                    return return_v;
                }


                System.StringComparer
                f_146_31826_31848()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31826, 31848);
                    return return_v;
                }


                string
                f_146_31861_31884(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31861, 31884);
                    return return_v;
                }


                int
                f_146_31826_31885(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31826, 31885);
                    return return_v;
                }


                string?
                f_146_31924_31942(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31924, 31942);
                    return return_v;
                }


                System.StringComparer
                f_146_31953_31975()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31953, 31975);
                    return return_v;
                }


                string
                f_146_31988_32006(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 31988, 32006);
                    return return_v;
                }


                int
                f_146_31953_32007(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31953, 32007);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_146_32065_32085(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32065, 32085);
                    return return_v;
                }


                int
                f_146_32046_32090(System.Collections.Immutable.ImmutableArray<byte>
                values, int
                maxItemsToHash)
                {
                    var return_v = Hash.CombineValues(values, maxItemsToHash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32046, 32090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_146_32130_32158(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32130, 32158);
                    return return_v;
                }


                string?
                f_146_32193_32210(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32193, 32210);
                    return return_v;
                }


                System.StringComparer
                f_146_32221_32243()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32221, 32243);
                    return return_v;
                }


                string
                f_146_32256_32273(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MainTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32256, 32273);
                    return return_v;
                }


                int
                f_146_32221_32274(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32221, 32274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_146_32318_32344(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32318, 32344);
                    return return_v;
                }


                bool
                f_146_32379_32416(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReferencesSupersedeLowerVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32379, 32416);
                    return return_v;
                }


                string?
                f_146_32451_32466(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32451, 32466);
                    return return_v;
                }


                System.StringComparer
                f_146_32477_32499()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32477, 32499);
                    return return_v;
                }


                string
                f_146_32512_32527(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32512, 32527);
                    return return_v;
                }


                int
                f_146_32477_32528(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32477, 32528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_146_32572_32594(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32572, 32594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_146_32634_32649(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32634, 32649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Platform
                f_146_32689_32702(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32689, 32702);
                    return return_v;
                }


                bool
                f_146_32737_32769(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32737, 32769);
                    return return_v;
                }


                string?
                f_146_32804_32824(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32804, 32824);
                    return return_v;
                }


                System.StringComparer
                f_146_32835_32857()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32835, 32857);
                    return return_v;
                }


                string
                f_146_32870_32890(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32870, 32890);
                    return return_v;
                }


                int
                f_146_32835_32891(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32835, 32891);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_146_32949_32979(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 32949, 32979);
                    return return_v;
                }


                int
                f_146_32930_32980(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                values)
                {
                    var return_v = Hash.CombineValues((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32930, 32980);
                    return return_v;
                }


                int
                f_146_33015_33032(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33015, 33032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_146_33067_33097(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33067, 33097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_146_33132_33157(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33132, 33157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_146_33192_33220(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33192, 33220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_146_33255_33285(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33255, 33285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_146_33320_33343(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33320, 33343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_146_33378_33407(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33378, 33407);
                    return return_v;
                }


                bool
                f_146_33442_33457(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33442, 33457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_146_33497_33524(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 33497, 33524);
                    return return_v;
                }


                int
                f_146_33479_33528(Microsoft.CodeAnalysis.NullableContextOptions
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33479, 33528);
                    return return_v;
                }


                int
                f_146_33429_33529(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33429, 33529);
                    return return_v;
                }


                int
                f_146_33365_33530(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33365, 33530);
                    return return_v;
                }


                int
                f_146_33307_33531(Microsoft.CodeAnalysis.StrongNameProvider?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33307, 33531);
                    return return_v;
                }


                int
                f_146_33242_33532(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33242, 33532);
                    return return_v;
                }


                int
                f_146_33179_33533(Microsoft.CodeAnalysis.SourceReferenceResolver?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33179, 33533);
                    return return_v;
                }


                int
                f_146_33119_33534(Microsoft.CodeAnalysis.XmlReferenceResolver?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33119, 33534);
                    return return_v;
                }


                int
                f_146_33054_33535(Microsoft.CodeAnalysis.MetadataReferenceResolver?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33054, 33535);
                    return return_v;
                }


                int
                f_146_33002_33536(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33002, 33536);
                    return return_v;
                }


                int
                f_146_32917_33537(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32917, 33537);
                    return return_v;
                }


                int
                f_146_32791_33538(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32791, 33538);
                    return return_v;
                }


                int
                f_146_32724_33539(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32724, 33539);
                    return return_v;
                }


                int
                f_146_32671_33540(Microsoft.CodeAnalysis.Platform
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32671, 33540);
                    return return_v;
                }


                int
                f_146_32616_33541(Microsoft.CodeAnalysis.OutputKind
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32616, 33541);
                    return return_v;
                }


                int
                f_146_32554_33542(Microsoft.CodeAnalysis.OptimizationLevel
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32554, 33542);
                    return return_v;
                }


                int
                f_146_32438_33543(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32438, 33543);
                    return return_v;
                }


                int
                f_146_32366_33544(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32366, 33544);
                    return return_v;
                }


                int
                f_146_32300_33545(Microsoft.CodeAnalysis.MetadataImportOptions
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32300, 33545);
                    return return_v;
                }


                int
                f_146_32180_33546(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32180, 33546);
                    return return_v;
                }


                int
                f_146_32112_33547(Microsoft.CodeAnalysis.ReportDiagnostic
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32112, 33547);
                    return return_v;
                }


                int
                f_146_32033_33548(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 32033, 33548);
                    return return_v;
                }


                int
                f_146_31911_33549(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31911, 33549);
                    return return_v;
                }


                int
                f_146_31779_33550(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31779, 33550);
                    return return_v;
                }


                int
                f_146_31726_33551(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31726, 33551);
                    return return_v;
                }


                int
                f_146_31656_33552(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31656, 33552);
                    return return_v;
                }


                int
                f_146_31603_33553(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31603, 33553);
                    return return_v;
                }


                int
                f_146_31548_33554(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31548, 33554);
                    return return_v;
                }


                int
                f_146_31495_33555(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 31495, 33555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 31430, 33567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 31430, 33567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(CompilationOptions? left, CompilationOptions? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(146, 33579, 33732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 33687, 33721);

                return f_146_33694_33720(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(146, 33579, 33732);

                bool
                f_146_33694_33720(Microsoft.CodeAnalysis.CompilationOptions?
                objA, Microsoft.CodeAnalysis.CompilationOptions?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33694, 33720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 33579, 33732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 33579, 33732);
            }
        }

        public static bool operator !=(CompilationOptions? left, CompilationOptions? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(146, 33744, 33898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(146, 33852, 33887);

                return !f_146_33860_33886(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(146, 33744, 33898);

                bool
                f_146_33860_33886(Microsoft.CodeAnalysis.CompilationOptions?
                objA, Microsoft.CodeAnalysis.CompilationOptions?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 33860, 33886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(146, 33744, 33898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 33744, 33898);
            }
        }

        static CompilationOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(146, 593, 33905);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(146, 593, 33905);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(146, 593, 33905);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(146, 593, 33905);

        static bool
        f_146_14189_14224(string?
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 14189, 14224);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AssemblyIdentityComparer
        f_146_15384_15416()
        {
            var return_v = AssemblyIdentityComparer.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(146, 15384, 15416);
            return return_v;
        }


        static System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
        f_146_15642_15883(System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(146, 15642, 15883);
            return return_v;
        }

    }
}
