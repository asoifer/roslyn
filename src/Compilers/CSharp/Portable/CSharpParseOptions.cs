// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public sealed class CSharpParseOptions : ParseOptions, IEquatable<CSharpParseOptions>
    {
        public static CSharpParseOptions Default { get; }

        private ImmutableDictionary<string, string> _features;

        public LanguageVersion LanguageVersion { get; private set; }

        public LanguageVersion SpecifiedLanguageVersion { get; private set; }

        internal ImmutableArray<string> PreprocessorSymbols { get; private set; }

        public override IEnumerable<string> PreprocessorSymbolNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 1807, 1842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 1813, 1840);

                    return f_10024_1820_1839();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 1807, 1842);

                    System.Collections.Immutable.ImmutableArray<string>
                    f_10024_1820_1839()
                    {
                        var return_v = PreprocessorSymbols;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 1820, 1839);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 1723, 1853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 1723, 1853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CSharpParseOptions(
                    LanguageVersion languageVersion = LanguageVersion.Default,
                    DocumentationMode documentationMode = DocumentationMode.Parse,
                    SourceCodeKind kind = SourceCodeKind.Regular,
                    IEnumerable<string>? preprocessorSymbols = null)
        : this(f_10024_2181_2196_C(languageVersion), documentationMode, kind, f_10024_2280_2325(preprocessorSymbols), ImmutableDictionary<string, string>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10024, 1865, 2410);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10024, 1865, 2410);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 1865, 2410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 1865, 2410);
            }
        }

        internal CSharpParseOptions(
                    LanguageVersion languageVersion,
                    DocumentationMode documentationMode,
                    SourceCodeKind kind,
                    ImmutableArray<string> preprocessorSymbols,
                    IReadOnlyDictionary<string, string>? features)
        : base(f_10024_2718_2722_C(kind), documentationMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10024, 2422, 3104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 877, 886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 1087, 1147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 1449, 1518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 2767, 2815);

                this.SpecifiedLanguageVersion = languageVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 2829, 2901);

                this.LanguageVersion = f_10024_2852_2900(languageVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 2915, 2988);

                this.PreprocessorSymbols = preprocessorSymbols.ToImmutableArrayOrEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 3002, 3093);

                _features = f_10024_3023_3047(_features) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<string, string>?>(10024, 3014, 3092) ?? ImmutableDictionary<string, string>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10024, 2422, 3104);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 2422, 3104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 2422, 3104);
            }
        }

        private CSharpParseOptions(CSharpParseOptions other) : this(
         f_10024_3190_3237_C(f_10024_3207_3237(other)), documentationMode: f_10024_3271_3294(other), kind: f_10024_3315_3325(other), preprocessorSymbols: f_10024_3361_3386(other), features: f_10024_3411_3425(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10024, 3116, 3448);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10024, 3116, 3448);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 3116, 3448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 3116, 3448);
            }
        }

        public override string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 3492, 3515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 3495, 3515);
                    return LanguageNames.CSharp; DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 3492, 3515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 3492, 3515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 3492, 3515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new CSharpParseOptions WithKind(SourceCodeKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 3528, 3882);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 3612, 3703) || true) && (kind == f_10024_3624_3642(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 3612, 3703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 3676, 3688);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 3612, 3703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 3719, 3774);

                var
                effectiveKind = f_10024_3739_3773(kind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 3788, 3871);

                return new CSharpParseOptions(this) { SpecifiedKind = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => kind, 10024, 3795, 3870), Kind = effectiveKind };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 3528, 3882);

                Microsoft.CodeAnalysis.SourceCodeKind
                f_10024_3624_3642(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 3624, 3642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10024_3739_3773(Microsoft.CodeAnalysis.SourceCodeKind
                kind)
                {
                    var return_v = kind.MapSpecifiedToEffectiveKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 3739, 3773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 3528, 3882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 3528, 3882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpParseOptions WithLanguageVersion(LanguageVersion version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 3894, 4326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 3989, 4094) || true) && (version == f_10024_4004_4033(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 3989, 4094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4067, 4079);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 3989, 4094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4110, 4182);

                var
                effectiveLanguageVersion = f_10024_4141_4181(version)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4196, 4315);

                return new CSharpParseOptions(this) { SpecifiedLanguageVersion = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => version, 10024, 4203, 4314), LanguageVersion = effectiveLanguageVersion };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 3894, 4326);

                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_4004_4033(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedLanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 4004, 4033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_4141_4181(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.MapSpecifiedToEffectiveVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 4141, 4181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 3894, 4326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 3894, 4326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpParseOptions WithPreprocessorSymbols(IEnumerable<string>? preprocessorSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 4338, 4537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4454, 4526);

                return f_10024_4461_4525(this, f_10024_4485_4524(preprocessorSymbols));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 4338, 4537);

                System.Collections.Immutable.ImmutableArray<string>
                f_10024_4485_4524(System.Collections.Generic.IEnumerable<string>?
                items)
                {
                    var return_v = items.AsImmutableOrNull<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 4485, 4524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10024_4461_4525(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, System.Collections.Immutable.ImmutableArray<string>
                symbols)
                {
                    var return_v = this_param.WithPreprocessorSymbols(symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 4461, 4525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 4338, 4537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 4338, 4537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpParseOptions WithPreprocessorSymbols(params string[]? preprocessorSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 4549, 4744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4661, 4733);

                return f_10024_4668_4732(this, f_10024_4692_4731(preprocessorSymbols));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 4549, 4744);

                System.Collections.Immutable.ImmutableArray<string>
                f_10024_4692_4731(string[]?
                items)
                {
                    var return_v = items.AsImmutableOrNull<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 4692, 4731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10024_4668_4732(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, System.Collections.Immutable.ImmutableArray<string>
                symbols)
                {
                    var return_v = this_param.WithPreprocessorSymbols(symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 4668, 4732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 4549, 4744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 4549, 4744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpParseOptions WithPreprocessorSymbols(ImmutableArray<string> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 4756, 5189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4862, 4971) || true) && (symbols.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 4862, 4971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4917, 4956);

                    symbols = ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 4862, 4971);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 4987, 5092) || true) && (symbols.Equals(f_10024_5006_5030(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 4987, 5092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5065, 5077);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 4987, 5092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5108, 5178);

                return new CSharpParseOptions(this) { PreprocessorSymbols = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => symbols, 10024, 5115, 5177) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 4756, 5189);

                System.Collections.Immutable.ImmutableArray<string>
                f_10024_5006_5030(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.PreprocessorSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 5006, 5030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 4756, 5189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 4756, 5189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpParseOptions WithDocumentationMode(DocumentationMode documentationMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 5201, 5527);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5314, 5422) || true) && (documentationMode == f_10024_5339_5361(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 5314, 5422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5395, 5407);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 5314, 5422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5438, 5516);

                return new CSharpParseOptions(this) { DocumentationMode = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => documentationMode, 10024, 5445, 5515) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 5201, 5527);

                Microsoft.CodeAnalysis.DocumentationMode
                f_10024_5339_5361(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 5339, 5361);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 5201, 5527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 5201, 5527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ParseOptions CommonWithKind(SourceCodeKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 5539, 5661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5628, 5650);

                return f_10024_5635_5649(this, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 5539, 5661);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10024_5635_5649(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.SourceCodeKind
                kind)
                {
                    var return_v = this_param.WithKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 5635, 5649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 5539, 5661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 5539, 5661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ParseOptions CommonWithDocumentationMode(DocumentationMode documentationMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 5673, 5853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5794, 5842);

                return f_10024_5801_5841(this, documentationMode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 5673, 5853);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10024_5801_5841(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.DocumentationMode
                documentationMode)
                {
                    var return_v = this_param.WithDocumentationMode(documentationMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 5801, 5841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 5673, 5853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 5673, 5853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ParseOptions CommonWithFeatures(IEnumerable<KeyValuePair<string, string>>? features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 5865, 6034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 5993, 6023);

                return f_10024_6000_6022(this, features);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 5865, 6034);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10024_6000_6022(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>?
                features)
                {
                    var return_v = this_param.WithFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 6000, 6022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 5865, 6034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 5865, 6034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpParseOptions WithFeatures(IEnumerable<KeyValuePair<string, string>>? features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 6162, 6566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 6282, 6476);

                ImmutableDictionary<string, string>
                dictionary =
                f_10024_6357_6413(_features, f_10024_6380_6412()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<string, string>?>(10024, 6348, 6475) ?? ImmutableDictionary<string, string>.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 6492, 6555);

                return new CSharpParseOptions(this) { _features = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => dictionary, 10024, 6499, 6554) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 6162, 6566);

                System.StringComparer
                f_10024_6380_6412()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 6380, 6412);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>
                f_10024_6357_6413(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                source, System.StringComparer
                keyComparer)
                {
                    var return_v = source?.ToImmutableDictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)keyComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 6357, 6413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 6162, 6566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 6162, 6566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IReadOnlyDictionary<string, string> Features
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 6663, 6731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 6699, 6716);

                    return _features;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 6663, 6731);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 6578, 6742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 6578, 6742);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void ValidateOptions(ArrayBuilder<Diagnostic> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 6754, 7910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 6851, 6902);

                f_10024_6851_6901(this, builder, MessageProvider.Instance);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7030, 7233) || true) && (!f_10024_7035_7060(f_10024_7035_7050()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 7030, 7233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7094, 7218);

                    f_10024_7094_7217(builder, f_10024_7106_7216(MessageProvider.Instance, ErrorCode.ERR_BadLanguageVersion, f_10024_7189_7215(f_10024_7189_7204())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 7030, 7233);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7249, 7899) || true) && (f_10024_7253_7290_M(!f_10024_7254_7273().IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 7249, 7899);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7324, 7884);
                        foreach (var symbol in f_10024_7347_7366_I(f_10024_7347_7366()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 7324, 7884);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7408, 7865) || true) && (symbol == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 7408, 7865);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7476, 7588);

                                f_10024_7476_7587(builder, f_10024_7488_7586(MessageProvider.Instance, ErrorCode.ERR_InvalidPreprocessingSymbol, "null"));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 7408, 7865);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 7408, 7865);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7638, 7865) || true) && (!f_10024_7643_7680(symbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 7638, 7865);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7730, 7842);

                                    f_10024_7730_7841(builder, f_10024_7742_7840(MessageProvider.Instance, ErrorCode.ERR_InvalidPreprocessingSymbol, symbol));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 7638, 7865);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 7408, 7865);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 7324, 7884);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10024, 1, 561);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10024, 1, 561);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 7249, 7899);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 6754, 7910);

                int
                f_10024_6851_6901(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                builder, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    this_param.ValidateOptions(builder, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 6851, 6901);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_7035_7050()
                {
                    var return_v = LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 7035, 7050);
                    return return_v;
                }


                bool
                f_10024_7035_7060(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7035, 7060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_7189_7204()
                {
                    var return_v = LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 7189, 7204);
                    return return_v;
                }


                string
                f_10024_7189_7215(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7189, 7215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10024_7106_7216(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7106, 7216);
                    return return_v;
                }


                int
                f_10024_7094_7217(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7094, 7217);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10024_7254_7273()
                {
                    var return_v = PreprocessorSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 7254, 7273);
                    return return_v;
                }


                bool
                f_10024_7253_7290_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 7253, 7290);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10024_7347_7366()
                {
                    var return_v = PreprocessorSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 7347, 7366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10024_7488_7586(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7488, 7586);
                    return return_v;
                }


                int
                f_10024_7476_7587(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7476, 7587);
                    return 0;
                }


                bool
                f_10024_7643_7680(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7643, 7680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10024_7742_7840(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7742, 7840);
                    return return_v;
                }


                int
                f_10024_7730_7841(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7730, 7841);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10024_7347_7366_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 7347, 7366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 6754, 7910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 6754, 7910);
            }
        }

        internal bool IsFeatureEnabled(MessageID feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 7922, 8378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 7996, 8044);

                string?
                featureFlag = f_10024_8018_8043(feature)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8058, 8171) || true) && (featureFlag != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 8058, 8171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8115, 8156);

                    return f_10024_8122_8155(f_10024_8122_8130(), featureFlag);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 8058, 8171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8185, 8236);

                LanguageVersion
                availableVersion = f_10024_8220_8235()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8250, 8310);

                LanguageVersion
                requiredVersion = f_10024_8284_8309(feature)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8324, 8367);

                return availableVersion >= requiredVersion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 7922, 8378);

                string?
                f_10024_8018_8043(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredFeature();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 8018, 8043);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_10024_8122_8130()
                {
                    var return_v = Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 8122, 8130);
                    return return_v;
                }


                bool
                f_10024_8122_8155(System.Collections.Generic.IReadOnlyDictionary<string, string>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 8122, 8155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_8220_8235()
                {
                    var return_v = LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 8220, 8235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_8284_8309(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 8284, 8309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 7922, 8378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 7922, 8378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 8390, 8512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8455, 8501);

                return f_10024_8462_8500(this, obj as CSharpParseOptions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 8390, 8512);

                bool
                f_10024_8462_8500(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 8462, 8500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 8390, 8512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 8390, 8512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(CSharpParseOptions? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 8524, 8899);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8594, 8694) || true) && (f_10024_8598_8633(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 8594, 8694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8667, 8679);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 8594, 8694);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8710, 8801) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EqualsHelper(other), 10024, 8715, 8739))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10024, 8710, 8801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8773, 8786);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10024, 8710, 8801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8817, 8888);

                return f_10024_8824_8853(this) == f_10024_8857_8887(other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 8524, 8899);

                bool
                f_10024_8598_8633(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                objA, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 8598, 8633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_8824_8853(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedLanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 8824, 8853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_8857_8887(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedLanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 8857, 8887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 8524, 8899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 8524, 8899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10024, 8911, 9113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 8969, 9102);

                return
                f_10024_8993_9101(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCodeHelper(), 10024, 9006, 9030), f_10024_9049_9100(f_10024_9067_9096(this), 0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10024, 8911, 9113);

                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10024_9067_9096(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedLanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 9067, 9096);
                    return return_v;
                }


                int
                f_10024_9049_9100(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 9049, 9100);
                    return return_v;
                }


                int
                f_10024_8993_9101(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 8993, 9101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10024, 8911, 9113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 8911, 9113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpParseOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10024, 555, 9120);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10024, 744, 821);
            Default = f_10024_796_820(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10024, 555, 9120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10024, 555, 9120);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10024, 555, 9120);

        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_10024_796_820()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpParseOptions();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 796, 820);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_10024_2280_2325(System.Collections.Generic.IEnumerable<string>?
        items)
        {
            var return_v = items.ToImmutableArrayOrEmpty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 2280, 2325);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LanguageVersion
        f_10024_2181_2196_C(Microsoft.CodeAnalysis.CSharp.LanguageVersion
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10024, 1865, 2410);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.LanguageVersion
        f_10024_2852_2900(Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = version.MapSpecifiedToEffectiveVersion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 2852, 2900);
            return return_v;
        }


        System.Collections.Immutable.ImmutableDictionary<string, string>
        f_10024_3023_3047(System.Collections.Generic.IReadOnlyDictionary<string, string>
        source)
        {
            var return_v = source?.ToImmutableDictionary<string, string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10024, 3023, 3047);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SourceCodeKind
        f_10024_2718_2722_C(Microsoft.CodeAnalysis.SourceCodeKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10024, 2422, 3104);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LanguageVersion
        f_10024_3207_3237(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param)
        {
            var return_v = this_param.SpecifiedLanguageVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 3207, 3237);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DocumentationMode
        f_10024_3271_3294(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param)
        {
            var return_v = this_param.DocumentationMode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 3271, 3294);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SourceCodeKind
        f_10024_3315_3325(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 3315, 3325);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_10024_3361_3386(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param)
        {
            var return_v = this_param.PreprocessorSymbols;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 3361, 3386);
            return return_v;
        }


        static System.Collections.Generic.IReadOnlyDictionary<string, string>
        f_10024_3411_3425(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param)
        {
            var return_v = this_param.Features;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10024, 3411, 3425);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LanguageVersion
        f_10024_3190_3237_C(Microsoft.CodeAnalysis.CSharp.LanguageVersion
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10024, 3116, 3448);
            return return_v;
        }

    }
}
