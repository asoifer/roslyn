// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.AnalyzerConfig;

namespace Roslyn.Utilities
{
    public sealed class TestSyntaxTreeOptionsProvider : SyntaxTreeOptionsProvider
    {
        private readonly Dictionary<SyntaxTree, Dictionary<string, ReportDiagnostic>>? _options;

        private readonly Dictionary<SyntaxTree, GeneratedKind>? _isGenerated;

        private readonly Dictionary<string, ReportDiagnostic>? _globalOptions;

        public TestSyntaxTreeOptionsProvider(
                    IEqualityComparer<string> comparer,
                    (string? key, ReportDiagnostic diagnostic) globalOption,
                    params (SyntaxTree, (string, ReportDiagnostic)[])[] options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25065, 760, 1516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 582, 590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 657, 669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 735, 749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 1015, 1239);

                _options = f_25065_1026_1238(options, x => x.Item1, x => x.Item2.ToDictionary(
                                    x => x.Item1,
                                    x => x.Item2,
                                    comparer));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 1253, 1471) || true) && (globalOption.key is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25065, 1253, 1471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 1317, 1456);

                    _globalOptions = new Dictionary<string, ReportDiagnostic>(f_25065_1375_1404()) { { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => globalOption.key, 25065, 1334, 1455), globalOption.diagnostic } };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25065, 1253, 1471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 1485, 1505);

                _isGenerated = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25065, 760, 1516);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 760, 1516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 760, 1516);
            }
        }

        public TestSyntaxTreeOptionsProvider(
                    params (SyntaxTree, (string, ReportDiagnostic)[])[] options)
        : this(f_25065_1660_1694_C(f_25065_1660_1694()), globalOption: default, options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25065, 1528, 1740);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25065, 1528, 1740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 1528, 1740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 1528, 1740);
            }
        }

        public TestSyntaxTreeOptionsProvider(
                    (string, ReportDiagnostic) globalOption,
                    params (SyntaxTree, (string, ReportDiagnostic)[])[] options)
        : this(f_25065_1938_1972_C(f_25065_1938_1972()), globalOption: globalOption, options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25065, 1752, 2023);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25065, 1752, 2023);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 1752, 2023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 1752, 2023);
            }
        }

        public TestSyntaxTreeOptionsProvider(
                    SyntaxTree tree, params (string, ReportDiagnostic)[] options)
        : this(globalOption: f_25065_2168_2189_C(default), new[] { (tree, options) })
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25065, 2035, 2230);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25065, 2035, 2230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 2035, 2230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 2035, 2230);
            }
        }

        public TestSyntaxTreeOptionsProvider(
                    params (SyntaxTree, GeneratedKind isGenerated)[] isGenerated
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25065, 2242, 2553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 582, 590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 657, 669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 735, 749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 2389, 2405);

                _options = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 2419, 2542);

                _isGenerated = f_25065_2434_2541(isGenerated, x => x.Item1, x => x.isGenerated);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25065, 2242, 2553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 2242, 2553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 2242, 2553);
            }
        }

        public override GeneratedKind IsGenerated(SyntaxTree tree, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25065, 2674, 2776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 2677, 2776);
                DynAbs.Tracing.TraceSender.Conditional_F1(25065, 2677, 2745);

                // LAFHIS
                //return ((_isGenerated != null && (DynAbs.Tracing.TraceSender.Expression_True(25065, 2677, 2745) 
                //    && f_25065_2701_2745(_isGenerated, tree, out var kind)) 
                //    && DynAbs.Tracing.TraceSender.Conditional_F2(25065, 2748, 2752)) || 
                //    DynAbs.Tracing.TraceSender.Conditional_F3(25065, 2755, 2776)) ? kind : 
                //    GeneratedKind.Unknown; 

                var temp = _isGenerated != null;
                if (temp)
                { 
                    DynAbs.Tracing.TraceSender.Expression_True(25065, 2677, 2745);
                    var temp2 = f_25065_2701_2745(_isGenerated, tree, out var kind);
                    if (temp2)
                    {
                        DynAbs.Tracing.TraceSender.Conditional_F2(25065, 2748, 2752);
                        return kind;
                    }
                }

                DynAbs.Tracing.TraceSender.Conditional_F3(25065, 2755, 2776);
                return GeneratedKind.Unknown;

                DynAbs.Tracing.TraceSender.TraceExitMethod(25065, 2674, 2776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 2674, 2776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 2674, 2776);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_25065_2701_2745(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.GeneratedKind>
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            key, out Microsoft.CodeAnalysis.GeneratedKind
            value)
            {
                var return_v = this_param.TryGetValue(key, out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25065, 2701, 2745);
                return return_v;
            }

        }

        public override bool TryGetDiagnosticValue(
                    SyntaxTree tree,
                    string diagnosticId,
                    CancellationToken cancellationToken,
                    out ReportDiagnostic severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25065, 2789, 3312);
                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic> diags = default(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3015, 3224) || true) && (_options != null && (DynAbs.Tracing.TraceSender.Expression_True(25065, 3019, 3097) && f_25065_3056_3097(_options, tree, out diags)) && (DynAbs.Tracing.TraceSender.Expression_True(25065, 3019, 3163) && f_25065_3118_3163(diags, diagnosticId, out severity)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25065, 3015, 3224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3197, 3209);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25065, 3015, 3224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3238, 3274);

                severity = ReportDiagnostic.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3288, 3301);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25065, 2789, 3312);

                bool
                f_25065_3056_3097(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25065, 3056, 3097);
                    return return_v;
                }


                bool
                f_25065_3118_3163(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25065, 3118, 3163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 2789, 3312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 2789, 3312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TryGetGlobalDiagnosticValue(string diagnosticId, CancellationToken cancellationToken, out ReportDiagnostic severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25065, 3324, 3738);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3486, 3650) || true) && (_globalOptions is object && (DynAbs.Tracing.TraceSender.Expression_True(25065, 3490, 3589) && f_25065_3535_3589(_globalOptions, diagnosticId, out severity)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25065, 3486, 3650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3623, 3635);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25065, 3486, 3650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3664, 3700);

                severity = ReportDiagnostic.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25065, 3714, 3727);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25065, 3324, 3738);

                bool
                f_25065_3535_3589(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25065, 3535, 3589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25065, 3324, 3738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 3324, 3738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TestSyntaxTreeOptionsProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25065, 409, 3745);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25065, 409, 3745);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25065, 409, 3745);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25065, 409, 3745);

        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
        f_25065_1026_1238((Microsoft.CodeAnalysis.SyntaxTree, (string, Microsoft.CodeAnalysis.ReportDiagnostic)[])[]
        source, System.Func<(Microsoft.CodeAnalysis.SyntaxTree, (string, Microsoft.CodeAnalysis.ReportDiagnostic)[]), Microsoft.CodeAnalysis.SyntaxTree>
        keySelector, System.Func<(Microsoft.CodeAnalysis.SyntaxTree, (string, Microsoft.CodeAnalysis.ReportDiagnostic)[]), System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>>
        elementSelector)
        {
            var return_v = source.ToDictionary<(Microsoft.CodeAnalysis.SyntaxTree, (string, Microsoft.CodeAnalysis.ReportDiagnostic)[]), Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>>(keySelector, elementSelector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25065, 1026, 1238);
            return return_v;
        }


        static System.StringComparer
        f_25065_1375_1404()
        {
            var return_v = Section.PropertiesKeyComparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25065, 1375, 1404);
            return return_v;
        }


        static System.StringComparer
        f_25065_1660_1694()
        {
            var return_v = CaseInsensitiveComparison.Comparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25065, 1660, 1694);
            return return_v;
        }


        static System.Collections.Generic.IEqualityComparer<string>
        f_25065_1660_1694_C(System.Collections.Generic.IEqualityComparer<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25065, 1528, 1740);
            return return_v;
        }


        static System.StringComparer
        f_25065_1938_1972()
        {
            var return_v = CaseInsensitiveComparison.Comparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25065, 1938, 1972);
            return return_v;
        }


        static System.Collections.Generic.IEqualityComparer<string>
        f_25065_1938_1972_C(System.Collections.Generic.IEqualityComparer<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25065, 1752, 2023);
            return return_v;
        }


        static (string, Microsoft.CodeAnalysis.ReportDiagnostic)
        f_25065_2168_2189_C((string, Microsoft.CodeAnalysis.ReportDiagnostic)
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25065, 2035, 2230);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.GeneratedKind>
        f_25065_2434_2541((Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.GeneratedKind isGenerated)[]
        source, System.Func<(Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.GeneratedKind isGenerated), Microsoft.CodeAnalysis.SyntaxTree>
        keySelector, System.Func<(Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.GeneratedKind isGenerated), Microsoft.CodeAnalysis.GeneratedKind>
        elementSelector)
        {
            var return_v = source.ToDictionary<(Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.GeneratedKind isGenerated), Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.GeneratedKind>(keySelector, elementSelector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25065, 2434, 2541);
            return return_v;
        }

    }
}
