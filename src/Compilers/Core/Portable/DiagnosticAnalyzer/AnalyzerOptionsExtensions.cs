// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal static class AnalyzerOptionsExtensions
    {
        private const string
        DotnetAnalyzerDiagnosticPrefix = "dotnet_analyzer_diagnostic"
        ;

        private const string
        CategoryPrefix = "category"
        ;

        private const string
        SeveritySuffix = "severity"
        ;

        private const string
        DotnetAnalyzerDiagnosticSeverityKey = DotnetAnalyzerDiagnosticPrefix + "." + SeveritySuffix
        ;

        private static string GetCategoryBasedDotnetAnalyzerDiagnosticSeverityKey(string category)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(238, 886, 969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 889, 969);
                return $"{DotnetAnalyzerDiagnosticPrefix}.{CategoryPrefix}-{category}.{SeveritySuffix}"; DynAbs.Tracing.TraceSender.TraceExitMethod(238, 886, 969);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(238, 886, 969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(238, 886, 969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSeverityFromBulkConfiguration(
                    this AnalyzerOptions? analyzerOptions,
                    SyntaxTree tree,
                    Compilation compilation,
                    DiagnosticDescriptor descriptor,
                    CancellationToken cancellationToken,
                    out ReportDiagnostic severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(238, 1408, 4032);
                string? value = default(string?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 1953, 2279) || true) && (analyzerOptions == null || (DynAbs.Tracing.TraceSender.Expression_False(238, 1957, 2031) || f_238_2001_2031_M(!descriptor.IsEnabledByDefault)) || (DynAbs.Tracing.TraceSender.Expression_False(238, 1957, 2180) || f_238_2052_2180(f_238_2052_2073(descriptor), tag => tag == WellKnownDiagnosticTags.Compiler || tag == WellKnownDiagnosticTags.NotConfigurable)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(238, 1953, 2279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 2214, 2233);

                    severity = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 2251, 2264);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(238, 1953, 2279);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 2538, 2857) || true) && (f_238_2542_2614(f_238_2542_2587(f_238_2542_2561(compilation)), f_238_2600_2613(descriptor)) || (DynAbs.Tracing.TraceSender.Expression_False(238, 2542, 2758) || f_238_2635_2750_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_238_2635_2680(f_238_2635_2654(compilation)), 238, 2635, 2750).TryGetDiagnosticValue(tree, f_238_2710_2723(descriptor), cancellationToken, out _)) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(238, 2538, 2857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 2792, 2811);

                    severity = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 2829, 2842);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(238, 2538, 2857);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 2873, 2964);

                var
                analyzerConfigOptions = f_238_2901_2963(f_238_2901_2946(analyzerOptions), tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 3195, 3291);

                var
                categoryBasedKey = f_238_3218_3290(f_238_3270_3289(descriptor))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 3305, 3512) || true) && (f_238_3309_3375(analyzerConfigOptions, categoryBasedKey, out value) && (DynAbs.Tracing.TraceSender.Expression_True(238, 3309, 3451) && f_238_3396_3451(value, out severity)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(238, 3305, 3512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 3485, 3497);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(238, 3305, 3512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 3737, 3959) || true) && (f_238_3741_3822(analyzerConfigOptions, DotnetAnalyzerDiagnosticSeverityKey, out value) && (DynAbs.Tracing.TraceSender.Expression_True(238, 3741, 3898) && f_238_3843_3898(value, out severity)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(238, 3737, 3959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 3932, 3944);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(238, 3737, 3959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 3975, 3994);

                severity = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 4008, 4021);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(238, 1408, 4032);

                bool
                f_238_2001_2031_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2001, 2031);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_238_2052_2073(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2052, 2073);
                    return return_v;
                }


                bool
                f_238_2052_2180(System.Collections.Generic.IEnumerable<string>
                sequence, System.Func<string, bool>
                predicate)
                {
                    var return_v = sequence.Contains<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 2052, 2180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_238_2542_2561(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2542, 2561);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_238_2542_2587(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2542, 2587);
                    return return_v;
                }


                string
                f_238_2600_2613(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2600, 2613);
                    return return_v;
                }


                bool
                f_238_2542_2614(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 2542, 2614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_238_2635_2654(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2635, 2654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_238_2635_2680(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2635, 2680);
                    return return_v;
                }


                string
                f_238_2710_2723(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2710, 2723);
                    return return_v;
                }


                bool?
                f_238_2635_2750_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 2635, 2750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
                f_238_2901_2946(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                this_param)
                {
                    var return_v = this_param.AnalyzerConfigOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 2901, 2946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                f_238_2901_2963(Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.GetOptions(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 2901, 2963);
                    return return_v;
                }


                string
                f_238_3270_3289(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(238, 3270, 3289);
                    return return_v;
                }


                string
                f_238_3218_3290(string
                category)
                {
                    var return_v = GetCategoryBasedDotnetAnalyzerDiagnosticSeverityKey(category);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 3218, 3290);
                    return return_v;
                }


                bool
                f_238_3309_3375(Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                this_param, string
                key, out string?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 3309, 3375);
                    return return_v;
                }


                bool
                f_238_3396_3451(string
                value, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = AnalyzerConfigSet.TryParseSeverity(value, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 3396, 3451);
                    return return_v;
                }


                bool
                f_238_3741_3822(Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                this_param, string
                key, out string?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 3741, 3822);
                    return return_v;
                }


                bool
                f_238_3843_3898(string
                value, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = AnalyzerConfigSet.TryParseSeverity(value, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(238, 3843, 3898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(238, 1408, 4032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(238, 1408, 4032);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalyzerOptionsExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(238, 380, 4039);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 465, 526);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 558, 585);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 617, 644);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(238, 678, 769);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(238, 380, 4039);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(238, 380, 4039);
        }

    }
}
