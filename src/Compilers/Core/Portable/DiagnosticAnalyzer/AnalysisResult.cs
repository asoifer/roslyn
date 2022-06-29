// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.Diagnostics.Telemetry;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public class AnalysisResult
    {
        internal AnalysisResult(
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> localSyntaxDiagnostics,
                    ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> localSemanticDiagnostics,
                    ImmutableDictionary<AdditionalText, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> localAdditionalFileDiagnostics,
                    ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>> nonLocalDiagnostics,
                    ImmutableDictionary<DiagnosticAnalyzer, AnalyzerTelemetryInfo> analyzerTelemetryInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(208, 693, 1773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 2086, 2220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 2354, 2490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 2635, 2781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 2918, 3024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 3166, 3266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 1430, 1452);

                Analyzers = analyzers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 1466, 1509);

                SyntaxDiagnostics = localSyntaxDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 1523, 1570);

                SemanticDiagnostics = localSemanticDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 1584, 1643);

                AdditionalFileDiagnostics = localAdditionalFileDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 1657, 1702);

                CompilationDiagnostics = nonLocalDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 1716, 1762);

                AnalyzerTelemetryInfo = analyzerTelemetryInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(208, 693, 1773);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(208, 693, 1773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 693, 1773);
            }
        }

        public ImmutableArray<DiagnosticAnalyzer> Analyzers { get; }

        public ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> SyntaxDiagnostics { get; }

        public ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> SemanticDiagnostics { get; }

        public ImmutableDictionary<AdditionalText, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> AdditionalFileDiagnostics { get; }

        public ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>> CompilationDiagnostics { get; }

        public ImmutableDictionary<DiagnosticAnalyzer, AnalyzerTelemetryInfo> AnalyzerTelemetryInfo { get; }

        public ImmutableArray<Diagnostic> GetAllDiagnostics(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(208, 3414, 3801);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 3519, 3698) || true) && (!f_208_3524_3533().Contains(analyzer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(208, 3519, 3698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 3586, 3683);

                    throw f_208_3592_3682(f_208_3614_3663(), nameof(analyzer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(208, 3519, 3698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 3714, 3790);

                return f_208_3721_3789(this, f_208_3736_3788(analyzer));
                DynAbs.Tracing.TraceSender.TraceExitMethod(208, 3414, 3801);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_208_3524_3533()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 3524, 3533);
                    return return_v;
                }


                string
                f_208_3614_3663()
                {
                    var return_v = CodeAnalysisResources.UnsupportedAnalyzerInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 3614, 3663);
                    return return_v;
                }


                System.ArgumentException
                f_208_3592_3682(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 3592, 3682);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_208_3736_3788(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 3736, 3788);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_208_3721_3789(Microsoft.CodeAnalysis.Diagnostics.AnalysisResult
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetDiagnostics(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 3721, 3789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(208, 3414, 3801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 3414, 3801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Diagnostic> GetAllDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(208, 3943, 4065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4021, 4054);

                return f_208_4028_4053(this, f_208_4043_4052());
                DynAbs.Tracing.TraceSender.TraceExitMethod(208, 3943, 4065);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_208_4043_4052()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4043, 4052);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_208_4028_4053(Microsoft.CodeAnalysis.Diagnostics.AnalysisResult
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>)analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4028, 4053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(208, 3943, 4065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 3943, 4065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Diagnostic> GetDiagnostics(IEnumerable<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(208, 4077, 4466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4194, 4246);

                // LAFHIS
                var temp = f_208_4218_4227();
                var excludedAnalyzers = f_208_4218_4245(ref temp, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4260, 4397);

                var
                excludedAnalyzersSet = (DynAbs.Tracing.TraceSender.Conditional_F1(208, 4287, 4310) || ((f_208_4287_4310(excludedAnalyzers) && DynAbs.Tracing.TraceSender.Conditional_F2(208, 4313, 4351)) || DynAbs.Tracing.TraceSender.Conditional_F3(208, 4354, 4396))) ? f_208_4313_4351(excludedAnalyzers) : ImmutableHashSet<DiagnosticAnalyzer>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4411, 4455);

                return f_208_4418_4454(this, excludedAnalyzersSet);
                DynAbs.Tracing.TraceSender.TraceExitMethod(208, 4077, 4466);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_208_4218_4227()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4218, 4227);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_208_4218_4245(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                second)
                {
                    var return_v = first.Except<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4218, 4245);
                    return return_v;
                }


                bool
                f_208_4287_4310(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4287, 4310);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_208_4313_4351(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4313, 4351);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_208_4418_4454(Microsoft.CodeAnalysis.Diagnostics.AnalysisResult
                this_param, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                excludedAnalyzers)
                {
                    var return_v = this_param.GetDiagnostics(excludedAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4418, 4454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(208, 4077, 4466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 4077, 4466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Diagnostic> GetDiagnostics(ImmutableHashSet<DiagnosticAnalyzer> excludedAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(208, 4478, 5327);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4608, 5260) || true) && (f_208_4612_4635(f_208_4612_4629()) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(208, 4612, 4672) || f_208_4643_4668(f_208_4643_4662()) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(208, 4612, 4711) || f_208_4676_4707(f_208_4676_4701()) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(208, 4612, 4747) || f_208_4715_4743(f_208_4715_4737()) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(208, 4608, 5260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4781, 4838);

                    var
                    builder = f_208_4795_4837()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4856, 4923);

                    f_208_4856_4922(f_208_4876_4893(), excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 4941, 5010);

                    f_208_4941_5009(f_208_4961_4980(), excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5028, 5103);

                    f_208_5028_5102(f_208_5048_5073(), excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5121, 5196);

                    f_208_5121_5195(f_208_5144_5166(), excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5216, 5245);

                    return f_208_5223_5244(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(208, 4608, 5260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5276, 5316);

                return ImmutableArray<Diagnostic>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(208, 4478, 5327);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_208_4612_4629()
                {
                    var return_v = SyntaxDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4612, 4629);
                    return return_v;
                }


                int
                f_208_4612_4635(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4612, 4635);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_208_4643_4662()
                {
                    var return_v = SemanticDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4643, 4662);
                    return return_v;
                }


                int
                f_208_4643_4668(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4643, 4668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_208_4676_4701()
                {
                    var return_v = AdditionalFileDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4676, 4701);
                    return return_v;
                }


                int
                f_208_4676_4707(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4676, 4707);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_208_4715_4737()
                {
                    var return_v = CompilationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4715, 4737);
                    return return_v;
                }


                int
                f_208_4715_4743(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4715, 4743);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                f_208_4795_4837()
                {
                    var return_v = ImmutableArray.CreateBuilder<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4795, 4837);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_208_4876_4893()
                {
                    var return_v = SyntaxDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4876, 4893);
                    return return_v;
                }


                int
                f_208_4856_4922(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                localDiagnostics, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                excludedAnalyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddLocalDiagnostics(localDiagnostics, excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4856, 4922);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_208_4961_4980()
                {
                    var return_v = SemanticDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 4961, 4980);
                    return return_v;
                }


                int
                f_208_4941_5009(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                localDiagnostics, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                excludedAnalyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddLocalDiagnostics(localDiagnostics, excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 4941, 5009);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_208_5048_5073()
                {
                    var return_v = AdditionalFileDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 5048, 5073);
                    return return_v;
                }


                int
                f_208_5028_5102(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                localDiagnostics, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                excludedAnalyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddLocalDiagnostics(localDiagnostics, excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 5028, 5102);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_208_5144_5166()
                {
                    var return_v = CompilationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(208, 5144, 5166);
                    return return_v;
                }


                int
                f_208_5121_5195(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                nonLocalDiagnostics, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                excludedAnalyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddNonLocalDiagnostics(nonLocalDiagnostics, excludedAnalyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 5121, 5195);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_208_5223_5244(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 5223, 5244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(208, 4478, 5327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 4478, 5327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddLocalDiagnostics<T>(
                    ImmutableDictionary<T, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> localDiagnostics,
                    ImmutableHashSet<DiagnosticAnalyzer> excludedAnalyzers,
                    ImmutableArray<Diagnostic>.Builder builder)
                    where T : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(208, 5339, 6128);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5687, 6117);
                    foreach (var diagnosticsByTree in f_208_5721_5737_I(localDiagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(208, 5687, 6117);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5771, 6102);
                            foreach (var diagnosticsByAnalyzer in f_208_5809_5832_I(diagnosticsByTree.Value))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(208, 5771, 6102);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5874, 6013) || true) && (f_208_5878_5931(excludedAnalyzers, diagnosticsByAnalyzer.Key))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(208, 5874, 6013);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 5981, 5990);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(208, 5874, 6013);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 6037, 6083);

                                f_208_6037_6082(
                                                    builder, diagnosticsByAnalyzer.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(208, 5771, 6102);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(208, 1, 332);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(208, 1, 332);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(208, 5687, 6117);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(208, 1, 431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(208, 1, 431);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(208, 5339, 6128);

                bool
                f_208_5878_5931(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 5878, 5931);
                    return return_v;
                }


                int
                f_208_6037_6082(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 6037, 6082);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_208_5809_5832_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 5809, 5832);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<T, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_208_5721_5737_I(System.Collections.Immutable.ImmutableDictionary<T, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 5721, 5737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(208, 5339, 6128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 5339, 6128);
            }
        }

        private static void AddNonLocalDiagnostics(
                    ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>> nonLocalDiagnostics,
                    ImmutableHashSet<DiagnosticAnalyzer> excludedAnalyzers,
                    ImmutableArray<Diagnostic>.Builder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(208, 6140, 6746);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 6436, 6735);
                    foreach (var diagnosticsByAnalyzer in f_208_6474_6493_I(nonLocalDiagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(208, 6436, 6735);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 6527, 6654) || true) && (f_208_6531_6584(excludedAnalyzers, diagnosticsByAnalyzer.Key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(208, 6527, 6654);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 6626, 6635);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(208, 6527, 6654);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(208, 6674, 6720);

                        f_208_6674_6719(
                                        builder, diagnosticsByAnalyzer.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(208, 6436, 6735);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(208, 1, 300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(208, 1, 300);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(208, 6140, 6746);

                bool
                f_208_6531_6584(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 6531, 6584);
                    return return_v;
                }


                int
                f_208_6674_6719(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 6674, 6719);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_208_6474_6493_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(208, 6474, 6493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(208, 6140, 6746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 6140, 6746);
            }
        }

        static AnalysisResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(208, 649, 6753);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(208, 649, 6753);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(208, 649, 6753);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(208, 649, 6753);
    }
}
