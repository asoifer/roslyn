// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract class SyntaxTreeOptionsProvider
    {
        public abstract GeneratedKind IsGenerated(SyntaxTree tree, CancellationToken cancellationToken);

        public abstract bool TryGetDiagnosticValue(SyntaxTree tree, string diagnosticId, CancellationToken cancellationToken, out ReportDiagnostic severity);

        public abstract bool TryGetGlobalDiagnosticValue(string diagnosticId, CancellationToken cancellationToken, out ReportDiagnostic severity);

        public SyntaxTreeOptionsProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(169, 338, 1191);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(169, 338, 1191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 338, 1191);
        }


        static SyntaxTreeOptionsProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(169, 338, 1191);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(169, 338, 1191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 338, 1191);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(169, 338, 1191);
    }
    internal sealed class CompilerSyntaxTreeOptionsProvider : SyntaxTreeOptionsProvider
    {
        private readonly struct Options
        {

            public readonly GeneratedKind IsGenerated;

            public readonly ImmutableDictionary<string, ReportDiagnostic> DiagnosticOptions;

            public Options(AnalyzerConfigOptionsResult? result)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(169, 1507, 2046);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 1591, 2031) || true) && (result is AnalyzerConfigOptionsResult r)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(169, 1591, 2031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 1676, 1710);

                        DiagnosticOptions = r.TreeOptions;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 1732, 1818);

                        IsGenerated = f_169_1746_1817(r.AnalyzerOptions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(169, 1591, 2031);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(169, 1591, 2031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 1900, 1954);

                        DiagnosticOptions = SyntaxTree.EmptyDiagnosticOptions;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 1976, 2012);

                        IsGenerated = GeneratedKind.Unknown;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(169, 1591, 2031);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(169, 1507, 2046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(169, 1507, 2046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 1507, 2046);
                }
            }
            static Options()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(169, 1299, 2057);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(169, 1299, 2057);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 1299, 2057);
            }

            static Microsoft.CodeAnalysis.GeneratedKind
            f_169_1746_1817(System.Collections.Immutable.ImmutableDictionary<string, string>
            options)
            {
                var return_v = GeneratedCodeUtilities.GetIsGeneratedCodeFromOptions(options);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 1746, 1817);
                return return_v;
            }

        }

        private readonly ImmutableDictionary<SyntaxTree, Options> _options;

        private readonly AnalyzerConfigOptionsResult _globalOptions;

        public CompilerSyntaxTreeOptionsProvider(
                    SyntaxTree?[] trees,
                    ImmutableArray<AnalyzerConfigOptionsResult> results,
                    AnalyzerConfigOptionsResult globalResults)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(169, 2220, 2963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2127, 2135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2442, 2513);

                var
                builder = f_169_2456_2512()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2536, 2541);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2527, 2850) || true) && (i < f_169_2547_2559(trees))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2561, 2564)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(169, 2527, 2850))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(169, 2527, 2850);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2598, 2835) || true) && (trees[i] != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(169, 2598, 2835);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2660, 2816);

                            f_169_2660_2815(builder, trees[i]!, f_169_2734_2814((DynAbs.Tracing.TraceSender.Conditional_F1(169, 2746, 2763) || ((results.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(169, 2766, 2770)) || DynAbs.Tracing.TraceSender.Conditional_F3(169, 2773, 2813))) ? null : (AnalyzerConfigOptionsResult?)results[i]));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(169, 2598, 2835);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(169, 1, 324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(169, 1, 324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2864, 2907);

                _options = f_169_2875_2906(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 2921, 2952);

                _globalOptions = globalResults;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(169, 2220, 2963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(169, 2220, 2963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 2220, 2963);
            }
        }

        public override GeneratedKind IsGenerated(SyntaxTree tree, CancellationToken _)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(169, 3068, 3156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3071, 3156);
                
                // LAFHIS
                DynAbs.Tracing.TraceSender.Conditional_F1(169, 3071, 3112);
                return (f_169_3071_3112(_options, tree, out var value) &&
                    DynAbs.Tracing.TraceSender.Conditional_F2(169, 3115, 3132)) ||
                    DynAbs.Tracing.TraceSender.Conditional_F3(169, 3135, 3156) ?
                    value.IsGenerated : GeneratedKind.Unknown; 
                
                DynAbs.Tracing.TraceSender.TraceExitMethod(169, 3068, 3156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(169, 3068, 3156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 3068, 3156);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_169_3071_3112(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options>
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            key, out Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options
            value)
            {
                var return_v = this_param.TryGetValue(key, out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 3071, 3112);
                return return_v;
            }

        }

        public override bool TryGetDiagnosticValue(SyntaxTree tree, string diagnosticId, CancellationToken _, out ReportDiagnostic severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(169, 3169, 3579);
                Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options value = default(Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3326, 3491) || true) && (f_169_3330_3371(_options, tree, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(169, 3326, 3491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3405, 3476);

                    return f_169_3412_3475(value.DiagnosticOptions, diagnosticId, out severity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(169, 3326, 3491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3505, 3541);

                severity = ReportDiagnostic.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3555, 3568);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(169, 3169, 3579);

                bool
                f_169_3330_3371(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 3330, 3371);
                    return return_v;
                }


                bool
                f_169_3412_3475(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 3412, 3475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(169, 3169, 3579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 3169, 3579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TryGetGlobalDiagnosticValue(string diagnosticId, CancellationToken _, out ReportDiagnostic severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(169, 3591, 3988);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3737, 3900) || true) && (_globalOptions.TreeOptions is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(169, 3737, 3900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3811, 3885);

                    return f_169_3818_3884(_globalOptions.TreeOptions, diagnosticId, out severity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(169, 3737, 3900);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3914, 3950);

                severity = ReportDiagnostic.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(169, 3964, 3977);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(169, 3591, 3988);

                bool
                f_169_3818_3884(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 3818, 3884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(169, 3591, 3988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 3591, 3988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilerSyntaxTreeOptionsProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(169, 1199, 3995);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(169, 1199, 3995);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(169, 1199, 3995);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(169, 1199, 3995);

        static System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options>.Builder
        f_169_2456_2512()
        {
            var return_v = ImmutableDictionary.CreateBuilder<SyntaxTree, Options>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 2456, 2512);
            return return_v;
        }


        static int
        f_169_2547_2559(Microsoft.CodeAnalysis.SyntaxTree?[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(169, 2547, 2559);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options
        f_169_2734_2814(Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult?
        result)
        {
            var return_v = new Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options(result);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 2734, 2814);
            return return_v;
        }


        static int
        f_169_2660_2815(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options>.Builder
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        key, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 2660, 2815);
            return 0;
        }


        static System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options>
        f_169_2875_2906(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options>.Builder
        builder)
        {
            var return_v = builder.ToImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider.Options>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(169, 2875, 2906);
            return return_v;
        }

    }
}
