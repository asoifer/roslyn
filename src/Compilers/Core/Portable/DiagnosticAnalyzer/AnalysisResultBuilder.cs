// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Diagnostics.Telemetry;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class AnalysisResultBuilder
    {
        private static readonly ImmutableDictionary<string, OneOrMany<AdditionalText>> s_emptyPathToAdditionalTextMap;

        private readonly object _gate;

        private readonly Dictionary<DiagnosticAnalyzer, TimeSpan>? _analyzerExecutionTimeOpt;

        private readonly HashSet<DiagnosticAnalyzer> _completedAnalyzers;

        private readonly Dictionary<DiagnosticAnalyzer, AnalyzerActionCounts> _analyzerActionCounts;

        private readonly ImmutableDictionary<string, OneOrMany<AdditionalText>> _pathToAdditionalTextMap;

        private Dictionary<SyntaxTree, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? _localSemanticDiagnosticsOpt;

        private Dictionary<SyntaxTree, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? _localSyntaxDiagnosticsOpt;

        private Dictionary<AdditionalText, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? _localAdditionalFileDiagnosticsOpt;

        private Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>? _nonLocalDiagnosticsOpt;

        internal AnalysisResultBuilder(bool logAnalyzerExecutionTime, ImmutableArray<DiagnosticAnalyzer> analyzers, ImmutableArray<AdditionalText> additionalFiles)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(209, 2043, 2609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1066, 1086);
                this._gate = f_209_1074_1086(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1156, 1181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1237, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1337, 1358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1441, 1465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1578, 1613);
                this._localSemanticDiagnosticsOpt = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1724, 1757);
                this._localSyntaxDiagnosticsOpt = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 1872, 1913);
                this._localAdditionalFileDiagnosticsOpt = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2000, 2030);
                this._nonLocalDiagnosticsOpt = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2223, 2327);

                _analyzerExecutionTimeOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(209, 2251, 2275) || ((logAnalyzerExecutionTime && DynAbs.Tracing.TraceSender.Conditional_F2(209, 2278, 2319)) || DynAbs.Tracing.TraceSender.Conditional_F3(209, 2322, 2326))) ? f_209_2278_2319(analyzers) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2341, 2397);

                _completedAnalyzers = f_209_2363_2396();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2411, 2510);

                _analyzerActionCounts = f_209_2435_2509(analyzers.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2524, 2598);

                _pathToAdditionalTextMap = f_209_2551_2597(additionalFiles);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(209, 2043, 2609);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 2043, 2609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 2043, 2609);
            }
        }

        private static Dictionary<DiagnosticAnalyzer, TimeSpan> CreateAnalyzerExecutionTimeMap(ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(209, 2621, 3010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2778, 2851);

                var
                map = f_209_2788_2850(analyzers.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2865, 2972);
                    foreach (var analyzer in f_209_2890_2899_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 2865, 2972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2933, 2957);

                        map[analyzer] = default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 2865, 2972);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 2988, 2999);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(209, 2621, 3010);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_209_2788_2850(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 2788, 2850);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_2890_2899_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 2890, 2899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 2621, 3010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 2621, 3010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableDictionary<string, OneOrMany<AdditionalText>> CreatePathToAdditionalTextMap(ImmutableArray<AdditionalText> additionalFiles)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(209, 3022, 4256);
                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText> value = default(Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 3194, 3308) || true) && (additionalFiles.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 3194, 3308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 3255, 3293);

                    return s_emptyPathToAdditionalTextMap;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 3194, 3308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 3324, 3431);

                var
                builder = f_209_3338_3430(PathUtilities.Comparer)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 3445, 4200);
                    foreach (var file in f_209_3466_3481_I(additionalFiles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 3445, 4200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 3762, 3799);

                        var
                        path = f_209_3773_3782(file) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(209, 3773, 3798) ?? string.Empty)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 3888, 4143) || true) && (f_209_3892_3932(builder, path, out value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 3888, 4143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 3974, 3998);

                            value = value.Add(file);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 3888, 4143);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 3888, 4143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4080, 4124);

                            value = f_209_4088_4123(file);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 3888, 4143);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4163, 4185);

                        builder[path] = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 3445, 4200);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4216, 4245);

                return f_209_4223_4244(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(209, 3022, 4256);

                System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>.Builder
                f_209_3338_3430(System.Collections.Generic.IEqualityComparer<string>
                keyComparer)
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, OneOrMany<AdditionalText>>(keyComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 3338, 3430);
                    return return_v;
                }


                string?
                f_209_3773_3782(Microsoft.CodeAnalysis.AdditionalText
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 3773, 3782);
                    return return_v;
                }


                bool
                f_209_3892_3932(System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>.Builder
                this_param, string
                key, out Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 3892, 3932);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>
                f_209_4088_4123(Microsoft.CodeAnalysis.AdditionalText
                one)
                {
                    var return_v = new Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 4088, 4123);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                f_209_3466_3481_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 3466, 3481);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>
                f_209_4223_4244(System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 4223, 4244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 3022, 4256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 3022, 4256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TimeSpan GetAnalyzerExecutionTime(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 4268, 4540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4362, 4410);

                f_209_4362_4409(_analyzerExecutionTimeOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4432, 4437);

                lock (_gate)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4471, 4514);

                    return f_209_4478_4513(_analyzerExecutionTimeOpt, analyzer);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 4268, 4540);

                int
                f_209_4362_4409(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 4362, 4409);
                    return 0;
                }


                System.TimeSpan
                f_209_4478_4513(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 4478, 4513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 4268, 4540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 4268, 4540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<DiagnosticAnalyzer> GetPendingAnalyzers(ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 4552, 5268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4692, 4697);
                lock (_gate)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4731, 4780);

                    ArrayBuilder<DiagnosticAnalyzer>?
                    builder = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4798, 5125);
                        foreach (var analyzer in f_209_4823_4832_I(analyzers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 4798, 5125);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4874, 5106) || true) && (!f_209_4879_4917(_completedAnalyzers, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 4874, 5106);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 4967, 5035);

                                builder = builder ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?>(209, 4977, 5034) ?? f_209_4988_5034());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 5061, 5083);

                                f_209_5061_5082(builder, analyzer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 4874, 5106);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 4798, 5125);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 328);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 328);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 5145, 5242);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(209, 5152, 5167) || ((builder != null && DynAbs.Tracing.TraceSender.Conditional_F2(209, 5170, 5198)) || DynAbs.Tracing.TraceSender.Conditional_F3(209, 5201, 5241))) ? f_209_5170_5198(builder) : ImmutableArray<DiagnosticAnalyzer>.Empty;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 4552, 5268);

                bool
                f_209_4879_4917(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 4879, 4917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_4988_5034()
                {
                    var return_v = ArrayBuilder<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 4988, 5034);
                    return return_v;
                }


                int
                f_209_5061_5082(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 5061, 5082);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_4823_4832_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 4823, 4832);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_5170_5198(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 5170, 5198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 4552, 5268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 4552, 5268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ApplySuppressionsAndStoreAnalysisResult(AnalysisScope analysisScope, AnalyzerDriver driver, Compilation compilation, Func<DiagnosticAnalyzer, AnalyzerActionCounts> getAnalyzerActionCounts, bool fullAnalysisResultForAnalyzersInScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 5280, 9279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 5551, 5709);

                f_209_5551_5708(!fullAnalysisResultForAnalyzersInScope || (DynAbs.Tracing.TraceSender.Expression_False(209, 5564, 5641) || f_209_5606_5633(analysisScope) == null), "Full analysis result cannot come from partial (tree) analysis.");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 5725, 8298);
                    foreach (var analyzer in f_209_5750_5773_I(f_209_5750_5773(analysisScope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 5725, 8298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 5909, 6034);

                        var
                        syntaxDiagnostics = f_209_5933_6033(driver, analyzer, syntax: true, compilation: compilation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6052, 6180);

                        var
                        semanticDiagnostics = f_209_6078_6179(driver, analyzer, syntax: false, compilation: compilation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6198, 6304);

                        var
                        compilationDiagnostics = f_209_6227_6303(driver, analyzer, compilation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6330, 6335);

                        lock (_gate)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6377, 6584) || true) && (f_209_6381_6419(_completedAnalyzers, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 6377, 6584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6552, 6561);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 6377, 6584);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6608, 7463) || true) && (syntaxDiagnostics.Length > 0 || (DynAbs.Tracing.TraceSender.Expression_False(209, 6612, 6674) || semanticDiagnostics.Length > 0) || (DynAbs.Tracing.TraceSender.Expression_False(209, 6612, 6711) || compilationDiagnostics.Length > 0) || (DynAbs.Tracing.TraceSender.Expression_False(209, 6612, 6752) || fullAnalysisResultForAnalyzersInScope))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 6608, 7463);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6802, 6947);

                                f_209_6802_6946(this, analyzer, syntaxDiagnostics, fullAnalysisResultForAnalyzersInScope, getSourceTree, ref _localSyntaxDiagnosticsOpt);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 6973, 7133);

                                f_209_6973_7132(this, analyzer, syntaxDiagnostics, fullAnalysisResultForAnalyzersInScope, getAdditionalTextKey, ref _localAdditionalFileDiagnosticsOpt);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 7159, 7308);

                                f_209_7159_7307(this, analyzer, semanticDiagnostics, fullAnalysisResultForAnalyzersInScope, getSourceTree, ref _localSemanticDiagnosticsOpt);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 7334, 7440);

                                f_209_7334_7439(this, analyzer, compilationDiagnostics, fullAnalysisResultForAnalyzersInScope);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 6608, 7463);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 7487, 7876) || true) && (_analyzerExecutionTimeOpt != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 7487, 7876);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 7574, 7633);

                                var
                                timeSpan = f_209_7589_7632(driver, analyzer)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 7659, 7853);

                                _analyzerExecutionTimeOpt[analyzer] = (DynAbs.Tracing.TraceSender.Conditional_F1(209, 7697, 7734) || ((fullAnalysisResultForAnalyzersInScope && DynAbs.Tracing.TraceSender.Conditional_F2(209, 7766, 7774)) || DynAbs.Tracing.TraceSender.Conditional_F3(209, 7806, 7852))) ? timeSpan : f_209_7806_7841(_analyzerExecutionTimeOpt, analyzer) + timeSpan;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 7487, 7876);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 7900, 8092) || true) && (!f_209_7905_7948(_analyzerActionCounts, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 7900, 8092);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 7998, 8069);

                                f_209_7998_8068(_analyzerActionCounts, analyzer, f_209_8034_8067(getAnalyzerActionCounts, analyzer));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 7900, 8092);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 8116, 8264) || true) && (fullAnalysisResultForAnalyzersInScope)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 8116, 8264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 8207, 8241);

                                f_209_8207_8240(_completedAnalyzers, analyzer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 8116, 8264);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 5725, 8298);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 2574);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 2574);
                }
                static SyntaxTree? getSourceTree(Diagnostic diagnostic)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 8387, 8420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 8390, 8420);
                        return f_209_8390_8420(f_209_8390_8409(diagnostic)); DynAbs.Tracing.TraceSender.TraceExitMethod(209, 8387, 8420);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 8387, 8420);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 8387, 8420);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                AdditionalText? getAdditionalTextKey(Diagnostic diagnostic)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 8437, 9268);
                        Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText> additionalTexts = default(Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 8615, 9221) || true) && (f_209_8619_8638(diagnostic) is ExternalFileLocation externalFileLocation)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 8615, 9221);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 8725, 9202) || true) && (f_209_8729_8821(_pathToAdditionalTextMap, f_209_8766_8795(externalFileLocation), out additionalTexts))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 8725, 9202);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 8871, 9179);
                                    foreach (var additionalText in f_209_8902_8917_I(additionalTexts))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 8871, 9179);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 8975, 9152) || true) && (f_209_8979_9033(f_209_8979_9008(analysisScope), additionalText))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 8975, 9152);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 9099, 9121);

                                            return additionalText;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 8975, 9152);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 8871, 9179);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 309);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 309);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 8725, 9202);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 8615, 9221);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 9241, 9253);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(209, 8437, 9268);

                        Microsoft.CodeAnalysis.Location
                        f_209_8619_8638(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 8619, 8638);
                            return return_v;
                        }


                        string
                        f_209_8766_8795(Microsoft.CodeAnalysis.ExternalFileLocation
                        this_param)
                        {
                            var return_v = this_param.FilePath;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 8766, 8795);
                            return return_v;
                        }


                        bool
                        f_209_8729_8821(System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>
                        this_param, string
                        key, out Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 8729, 8821);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
                        f_209_8979_9008(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                        this_param)
                        {
                            var return_v = this_param.AdditionalFiles;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 8979, 9008);
                            return return_v;
                        }


                        bool
                        f_209_8979_9033(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
                        source, Microsoft.CodeAnalysis.AdditionalText
                        value)
                        {
                            var return_v = source.Contains<Microsoft.CodeAnalysis.AdditionalText>(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 8979, 9033);
                            return return_v;
                        }


                        Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>
                        f_209_8902_8917_I(Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 8902, 8917);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 8437, 9268);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 8437, 9268);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 5280, 9279);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_209_5606_5633(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 5606, 5633);
                    return return_v;
                }


                int
                f_209_5551_5708(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 5551, 5708);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_5750_5773(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 5750, 5773);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_209_5933_6033(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, bool
                syntax, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.DequeueLocalDiagnosticsAndApplySuppressions(analyzer, syntax: syntax, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 5933, 6033);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_209_6078_6179(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, bool
                syntax, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.DequeueLocalDiagnosticsAndApplySuppressions(analyzer, syntax: syntax, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 6078, 6179);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_209_6227_6303(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.DequeueNonLocalDiagnosticsAndApplySuppressions(analyzer, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 6227, 6303);
                    return return_v;
                }


                bool
                f_209_6381_6419(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 6381, 6419);
                    return return_v;
                }


                int
                f_209_6802_6946(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                overwrite, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.SyntaxTree?>
                getKeyFunc, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                lazyLocalDiagnostics)
                {
                    this_param.UpdateLocalDiagnostics_NoLock<Microsoft.CodeAnalysis.SyntaxTree>(analyzer, diagnostics, overwrite, getKeyFunc, ref lazyLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 6802, 6946);
                    return 0;
                }


                int
                f_209_6973_7132(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                overwrite, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.AdditionalText?>
                getKeyFunc, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                lazyLocalDiagnostics)
                {
                    this_param.UpdateLocalDiagnostics_NoLock<Microsoft.CodeAnalysis.AdditionalText>(analyzer, diagnostics, overwrite, getKeyFunc, ref lazyLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 6973, 7132);
                    return 0;
                }


                int
                f_209_7159_7307(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                overwrite, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.SyntaxTree?>
                getKeyFunc, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                lazyLocalDiagnostics)
                {
                    this_param.UpdateLocalDiagnostics_NoLock<Microsoft.CodeAnalysis.SyntaxTree>(analyzer, diagnostics, overwrite, getKeyFunc, ref lazyLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 7159, 7307);
                    return 0;
                }


                int
                f_209_7334_7439(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                overwrite)
                {
                    this_param.UpdateNonLocalDiagnostics_NoLock(analyzer, diagnostics, overwrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 7334, 7439);
                    return 0;
                }


                System.TimeSpan
                f_209_7589_7632(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.ResetAnalyzerExecutionTime(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 7589, 7632);
                    return return_v;
                }


                System.TimeSpan
                f_209_7806_7841(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 7806, 7841);
                    return return_v;
                }


                bool
                f_209_7905_7948(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 7905, 7948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                f_209_8034_8067(System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 8034, 8067);
                    return return_v;
                }


                int
                f_209_7998_8068(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 7998, 8068);
                    return 0;
                }


                bool
                f_209_8207_8240(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 8207, 8240);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_5750_5773_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 5750, 5773);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.Location
                f_209_8390_8409(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 8390, 8409);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SyntaxTree?
                f_209_8390_8420(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 8390, 8420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 5280, 9279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 5280, 9279);
            }
        }

        private void UpdateLocalDiagnostics_NoLock<TKey>(
                    DiagnosticAnalyzer analyzer,
                    ImmutableArray<Diagnostic> diagnostics,
                    bool overwrite,
                    Func<Diagnostic, TKey?> getKeyFunc,
                    ref Dictionary<TKey, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? lazyLocalDiagnostics)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 9291, 11127);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 9695, 9774) || true) && (diagnostics.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 9695, 9774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 9752, 9759);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 9695, 9774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 9790, 9928);

                lazyLocalDiagnostics = lazyLocalDiagnostics ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?>(209, 9813, 9927) ?? f_209_9837_9927());
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 9944, 11116);
                    foreach (var diagsByKey in f_209_9971_10002_I(f_209_9971_10002(ref diagnostics, getKeyFunc)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 9944, 11116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10036, 10061);

                        var
                        key = f_209_10046_10060<TKey?>(diagsByKey)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10079, 10164) || true) && (key is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 10079, 10164);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10136, 10145);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 10079, 10164);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10184, 10267);

                        Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>?
                        allDiagnostics
                        = default(Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10285, 10563) || true) && (!f_209_10290_10347(lazyLocalDiagnostics, key, out allDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 10285, 10563);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10389, 10479);

                            allDiagnostics = f_209_10406_10478();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10501, 10544);

                            lazyLocalDiagnostics[key] = allDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 10285, 10563);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10583, 10639);

                        ImmutableArray<Diagnostic>.Builder?
                        analyzerDiagnostics
                        = default(ImmutableArray<Diagnostic>.Builder?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10657, 10918) || true) && (!f_209_10662_10723(allDiagnostics, analyzer, out analyzerDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 10657, 10918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10765, 10830);

                            analyzerDiagnostics = f_209_10787_10829();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10852, 10899);

                            allDiagnostics[analyzer] = analyzerDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 10657, 10918);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10938, 11040) || true) && (overwrite)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 10938, 11040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 10993, 11021);

                            f_209_10993_11020(analyzerDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 10938, 11040);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11060, 11101);

                        f_209_11060_11100(
                                        analyzerDiagnostics, diagsByKey);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 9944, 11116);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 1173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 1173);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 9291, 11127);

                System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>
                f_209_9837_9927()
                {
                    var return_v = new System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 9837, 9927);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, Microsoft.CodeAnalysis.Diagnostic>>
                f_209_9971_10002<TKey>(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostic, TKey>
                keySelector)
                {
                    var return_v = source.GroupBy<Microsoft.CodeAnalysis.Diagnostic, TKey>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 9971, 10002);
                    return return_v;
                }


                TKey?
                f_209_10046_10060<TKey>(System.Linq.IGrouping<TKey?, Microsoft.CodeAnalysis.Diagnostic>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 10046, 10060);
                    return return_v;
                }


                bool
                f_209_10290_10347(System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>
                this_param, TKey
                key, out System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 10290, 10347);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                f_209_10406_10478()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 10406, 10478);
                    return return_v;
                }


                bool
                f_209_10662_10723(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 10662, 10723);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                f_209_10787_10829()
                {
                    var return_v = ImmutableArray.CreateBuilder<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 10787, 10829);
                    return return_v;
                }


                int
                f_209_10993_11020(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 10993, 11020);
                    return 0;
                }


                int
                f_209_11060_11100<TKey>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param, System.Linq.IGrouping<TKey?, Microsoft.CodeAnalysis.Diagnostic>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 11060, 11100);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey?, Microsoft.CodeAnalysis.Diagnostic>>
                f_209_9971_10002_I(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey?, Microsoft.CodeAnalysis.Diagnostic>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 9971, 10002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 9291, 11127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 9291, 11127);
            }
        }

        private void UpdateNonLocalDiagnostics_NoLock(DiagnosticAnalyzer analyzer, ImmutableArray<Diagnostic> diagnostics, bool overwrite)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 11139, 12033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11294, 11373) || true) && (diagnostics.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 11294, 11373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11351, 11358);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 11294, 11373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11389, 11515);

                _nonLocalDiagnosticsOpt = _nonLocalDiagnosticsOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>?>(209, 11415, 11514) ?? f_209_11442_11514());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11531, 11586);

                ImmutableArray<Diagnostic>.Builder?
                currentDiagnostics
                = default(ImmutableArray<Diagnostic>.Builder?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11600, 11860) || true) && (!f_209_11605_11674(_nonLocalDiagnosticsOpt, analyzer, out currentDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 11600, 11860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11708, 11772);

                    currentDiagnostics = f_209_11729_11771();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11790, 11845);

                    _nonLocalDiagnosticsOpt[analyzer] = currentDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 11600, 11860);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11876, 11965) || true) && (overwrite)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 11876, 11965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11923, 11950);

                    f_209_11923_11949(currentDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 11876, 11965);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 11981, 12022);

                f_209_11981_12021(
                            currentDiagnostics, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 11139, 12033);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                f_209_11442_11514()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 11442, 11514);
                    return return_v;
                }


                bool
                f_209_11605_11674(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 11605, 11674);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                f_209_11729_11771()
                {
                    var return_v = ImmutableArray.CreateBuilder<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 11729, 11771);
                    return return_v;
                }


                int
                f_209_11923_11949(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 11923, 11949);
                    return 0;
                }


                int
                f_209_11981_12021(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 11981, 12021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 11139, 12033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 11139, 12033);
            }
        }

        internal ImmutableArray<Diagnostic> GetDiagnostics(AnalysisScope analysisScope, bool getLocalDiagnostics, bool getNonLocalDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 12045, 12364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12210, 12215);
                lock (_gate)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12249, 12338);

                    return f_209_12256_12337(this, analysisScope, getLocalDiagnostics, getNonLocalDiagnostics);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 12045, 12364);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_209_12256_12337(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, bool
                getLocalDiagnostics, bool
                getNonLocalDiagnostics)
                {
                    var return_v = this_param.GetDiagnostics_NoLock(analysisScope, getLocalDiagnostics, getNonLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 12256, 12337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 12045, 12364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 12045, 12364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Diagnostic> GetDiagnostics_NoLock(AnalysisScope analysisScope, bool getLocalDiagnostics, bool getNonLocalDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 12376, 13964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12541, 12601);

                f_209_12541_12600(getLocalDiagnostics || (DynAbs.Tracing.TraceSender.Expression_False(209, 12554, 12599) || getNonLocalDiagnostics));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12617, 12674);

                var
                builder = f_209_12631_12673()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12688, 13696) || true) && (getLocalDiagnostics)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 12688, 13696);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12745, 13681) || true) && (f_209_12749_12784_M(!analysisScope.IsSingleFileAnalysis))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 12745, 13681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12826, 12908);

                        f_209_12826_12907(_localSyntaxDiagnosticsOpt, analysisScope, builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 12930, 13014);

                        f_209_12930_13013(_localSemanticDiagnosticsOpt, analysisScope, builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13036, 13126);

                        f_209_13036_13125(_localAdditionalFileDiagnosticsOpt, analysisScope, builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 12745, 13681);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 12745, 13681);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13168, 13681) || true) && (f_209_13172_13215(analysisScope))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 13168, 13681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13257, 13354);

                            f_209_13257_13353(_localSyntaxDiagnosticsOpt, analysisScope, builder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13376, 13481);

                            f_209_13376_13480(_localAdditionalFileDiagnosticsOpt, analysisScope, builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 13168, 13681);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 13168, 13681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13563, 13662);

                            f_209_13563_13661(_localSemanticDiagnosticsOpt, analysisScope, builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 13168, 13681);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 12745, 13681);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 12688, 13696);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13712, 13903) || true) && (getNonLocalDiagnostics && (DynAbs.Tracing.TraceSender.Expression_True(209, 13716, 13773) && _nonLocalDiagnosticsOpt != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 13712, 13903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13807, 13888);

                    f_209_13807_13887(_nonLocalDiagnosticsOpt, f_209_13854_13877(analysisScope), builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 13712, 13903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 13919, 13953);

                return f_209_13926_13952(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 12376, 13964);

                int
                f_209_12541_12600(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 12541, 12600);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                f_209_12631_12673()
                {
                    var return_v = ImmutableArray.CreateBuilder<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 12631, 12673);
                    return return_v;
                }


                bool
                f_209_12749_12784_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 12749, 12784);
                    return return_v;
                }


                int
                f_209_12826_12907(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                lazyLocalDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddAllLocalDiagnostics_NoLock(lazyLocalDiagnostics, analysisScope, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 12826, 12907);
                    return 0;
                }


                int
                f_209_12930_13013(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                lazyLocalDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddAllLocalDiagnostics_NoLock(lazyLocalDiagnostics, analysisScope, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 12930, 13013);
                    return 0;
                }


                int
                f_209_13036_13125(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                lazyLocalDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddAllLocalDiagnostics_NoLock(lazyLocalDiagnostics, analysisScope, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 13036, 13125);
                    return 0;
                }


                bool
                f_209_13172_13215(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.IsSyntacticSingleFileAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 13172, 13215);
                    return return_v;
                }


                int
                f_209_13257_13353(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                localDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddLocalDiagnosticsForPartialAnalysis_NoLock(localDiagnostics, analysisScope, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 13257, 13353);
                    return 0;
                }


                int
                f_209_13376_13480(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                localDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddLocalDiagnosticsForPartialAnalysis_NoLock(localDiagnostics, analysisScope, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 13376, 13480);
                    return 0;
                }


                int
                f_209_13563_13661(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                localDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddLocalDiagnosticsForPartialAnalysis_NoLock(localDiagnostics, analysisScope, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 13563, 13661);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_13854_13877(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 13854, 13877);
                    return return_v;
                }


                int
                f_209_13807_13887(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddDiagnostics_NoLock(diagnostics, analyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 13807, 13887);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_209_13926_13952(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 13926, 13952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 12376, 13964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 12376, 13964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddAllLocalDiagnostics_NoLock<TKey>(
                    Dictionary<TKey, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? lazyLocalDiagnostics,
                    AnalysisScope analysisScope,
                    ImmutableArray<Diagnostic>.Builder builder)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(209, 13976, 14596);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 14309, 14585) || true) && (lazyLocalDiagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 14309, 14585);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 14375, 14570);
                        foreach (var localDiagsByTree in f_209_14408_14435_I(f_209_14408_14435(lazyLocalDiagnostics)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 14375, 14570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 14477, 14551);

                            f_209_14477_14550(localDiagsByTree, f_209_14517_14540(analysisScope), builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 14375, 14570);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 196);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 196);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 14309, 14585);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(209, 13976, 14596);

                System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>.ValueCollection
                f_209_14408_14435(System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 14408, 14435);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_14517_14540(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 14517, 14540);
                    return return_v;
                }


                int
                f_209_14477_14550(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddDiagnostics_NoLock(diagnostics, analyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 14477, 14550);
                    return 0;
                }


                System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>.ValueCollection
                f_209_14408_14435_I(System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 14408, 14435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 13976, 14596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 13976, 14596);
            }
        }

        private static void AddLocalDiagnosticsForPartialAnalysis_NoLock(
                    Dictionary<SyntaxTree, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? localDiagnostics,
                    AnalysisScope analysisScope,
                    ImmutableArray<Diagnostic>.Builder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 14909, 15055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 14912, 15055);
                f_209_14912_15055(localDiagnostics, analysisScope.FilterFileOpt!.Value.SourceTree, f_209_15022_15045(analysisScope), builder); DynAbs.Tracing.TraceSender.TraceExitMethod(209, 14909, 15055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 14909, 15055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 14909, 15055);
            }

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            f_209_15022_15045(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
            this_param)
            {
                var return_v = this_param.Analyzers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 15022, 15045);
                return return_v;
            }


            int
            f_209_14912_15055(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
            localDiagnostics, Microsoft.CodeAnalysis.SyntaxTree?
            key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            analyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
            builder)
            {
                AddLocalDiagnosticsForPartialAnalysis_NoLock(localDiagnostics, key, analyzers, builder);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 14912, 15055);
                return 0;
            }

        }

        private static void AddLocalDiagnosticsForPartialAnalysis_NoLock(
                    Dictionary<AdditionalText, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? localDiagnostics,
                    AnalysisScope analysisScope,
                    ImmutableArray<Diagnostic>.Builder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 15373, 15523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 15376, 15523);
                f_209_15376_15523(localDiagnostics, analysisScope.FilterFileOpt!.Value.AdditionalFile, f_209_15490_15513(analysisScope), builder); DynAbs.Tracing.TraceSender.TraceExitMethod(209, 15373, 15523);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 15373, 15523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 15373, 15523);
            }

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            f_209_15490_15513(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
            this_param)
            {
                var return_v = this_param.Analyzers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 15490, 15513);
                return return_v;
            }


            int
            f_209_15376_15523(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
            localDiagnostics, Microsoft.CodeAnalysis.AdditionalText?
            key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            analyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
            builder)
            {
                AddLocalDiagnosticsForPartialAnalysis_NoLock(localDiagnostics, key, analyzers, builder);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 15376, 15523);
                return 0;
            }

        }

        private static void AddLocalDiagnosticsForPartialAnalysis_NoLock<TKey>(
                    Dictionary<TKey, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? localDiagnostics,
                    TKey? key,
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    ImmutableArray<Diagnostic>.Builder builder)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(209, 15536, 16248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 15921, 16008);

                Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>?
                diagnosticsForTree
                = default(Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 16022, 16237) || true) && (key != null && (DynAbs.Tracing.TraceSender.Expression_True(209, 16026, 16065) && localDiagnostics != null) && (DynAbs.Tracing.TraceSender.Expression_True(209, 16026, 16126) && f_209_16069_16126(localDiagnostics, key, out diagnosticsForTree)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 16022, 16237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 16160, 16222);

                    f_209_16160_16221(diagnosticsForTree, analyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 16022, 16237);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(209, 15536, 16248);

                bool
                f_209_16069_16126(System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>
                this_param, TKey
                key, out System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 16069, 16126);
                    return return_v;
                }


                int
                f_209_16160_16221(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                builder)
                {
                    AddDiagnostics_NoLock(diagnostics, analyzers, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 16160, 16221);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 15536, 16248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 15536, 16248);
            }
        }

        private static void AddDiagnostics_NoLock(
                    Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder> diagnostics,
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    ImmutableArray<Diagnostic>.Builder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(209, 16260, 16921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 16536, 16570);

                f_209_16536_16569(diagnostics != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 16586, 16910);
                    foreach (var analyzer in f_209_16611_16620_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 16586, 16910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 16654, 16712);

                        ImmutableArray<Diagnostic>.Builder?
                        diagnosticsByAnalyzer
                        = default(ImmutableArray<Diagnostic>.Builder?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 16730, 16895) || true) && (f_209_16734_16794(diagnostics, analyzer, out diagnosticsByAnalyzer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 16730, 16895);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 16836, 16876);

                            f_209_16836_16875(builder, diagnosticsByAnalyzer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 16730, 16895);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 16586, 16910);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 325);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(209, 16260, 16921);

                int
                f_209_16536_16569(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 16536, 16569);
                    return 0;
                }


                bool
                f_209_16734_16794(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 16734, 16794);
                    return return_v;
                }


                int
                f_209_16836_16875(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 16836, 16875);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_16611_16620_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 16611, 16620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 16260, 16921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 16260, 16921);
            }
        }

        internal AnalysisResult ToAnalysisResult(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 16933, 18513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17081, 17130);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17146, 17270);

                ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>
                localSyntaxDiagnostics
                = default(ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17284, 17410);

                ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>
                localSemanticDiagnostics
                = default(ImmutableDictionary<SyntaxTree, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17424, 17560);

                ImmutableDictionary<AdditionalText, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>
                localAdditionalFileDiagnostics
                = default(ImmutableDictionary<AdditionalText, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17574, 17662);

                ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>
                nonLocalDiagnostics
                = default(ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17678, 17728);

                var
                analyzersSet = f_209_17697_17727(ref analyzers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17748, 17753);
                lock (_gate)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17787, 17867);

                    localSyntaxDiagnostics = f_209_17812_17866(analyzersSet, _localSyntaxDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17885, 17969);

                    localSemanticDiagnostics = f_209_17912_17968(analyzersSet, _localSemanticDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 17987, 18083);

                    localAdditionalFileDiagnostics = f_209_18020_18082(analyzersSet, _localAdditionalFileDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 18101, 18175);

                    nonLocalDiagnostics = f_209_18123_18174(analyzersSet, _nonLocalDiagnosticsOpt);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 18206, 18255);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 18269, 18325);

                var
                analyzerTelemetryInfo = f_209_18297_18324(this, analyzers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 18339, 18502);

                return f_209_18346_18501(analyzers, localSyntaxDiagnostics, localSemanticDiagnostics, localAdditionalFileDiagnostics, nonLocalDiagnostics, analyzerTelemetryInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 16933, 18513);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_17697_17727(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 17697, 17727);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_209_17812_17866(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                localDiagnosticsOpt)
                {
                    var return_v = GetImmutable(analyzers, localDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 17812, 17866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_209_17912_17968(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                localDiagnosticsOpt)
                {
                    var return_v = GetImmutable(analyzers, localDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 17912, 17968);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_209_18020_18082(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>?
                localDiagnosticsOpt)
                {
                    var return_v = GetImmutable(analyzers, localDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 18020, 18082);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_209_18123_18174(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>?
                nonLocalDiagnosticsOpt)
                {
                    var return_v = GetImmutable(analyzers, nonLocalDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 18123, 18174);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo>
                f_209_18297_18324(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetTelemetryInfo(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 18297, 18324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisResult
                f_209_18346_18501(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                localSyntaxDiagnostics, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                localSemanticDiagnostics, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AdditionalText, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                localAdditionalFileDiagnostics, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                nonLocalDiagnostics, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo>
                analyzerTelemetryInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisResult(analyzers, localSyntaxDiagnostics, localSemanticDiagnostics, localAdditionalFileDiagnostics, nonLocalDiagnostics, analyzerTelemetryInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 18346, 18501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 16933, 18513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 16933, 18513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableDictionary<TKey, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>> GetImmutable<TKey>(
                    ImmutableHashSet<DiagnosticAnalyzer> analyzers,
                    Dictionary<TKey, Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>>? localDiagnosticsOpt)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(209, 18525, 20005);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 18892, 19080) || true) && (localDiagnosticsOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 18892, 19080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 18957, 19065);

                    return ImmutableDictionary<TKey, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 18892, 19080);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19096, 19221);

                var
                builder = f_209_19110_19220()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19235, 19340);

                var
                perTreeBuilder = f_209_19256_19339()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19356, 19949);
                    foreach (var diagnosticsByTree in f_209_19390_19409_I(localDiagnosticsOpt))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 19356, 19949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19443, 19475);

                        var
                        key = diagnosticsByTree.Key
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19493, 19826);
                            foreach (var diagnosticsByAnalyzer in f_209_19531_19554_I(diagnosticsByTree.Value))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 19493, 19826);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19596, 19807) || true) && (f_209_19600_19645(analyzers, diagnosticsByAnalyzer.Key))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 19596, 19807);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19695, 19784);

                                    f_209_19695_19783(perTreeBuilder, diagnosticsByAnalyzer.Key, f_209_19741_19782(diagnosticsByAnalyzer.Value));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 19596, 19807);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 19493, 19826);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 334);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 334);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19846, 19893);

                        f_209_19846_19892(
                                        builder, key, f_209_19863_19891(perTreeBuilder));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19911, 19934);

                        f_209_19911_19933(perTreeBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 19356, 19949);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 19965, 19994);

                return f_209_19972_19993(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(209, 18525, 20005);

                System.Collections.Immutable.ImmutableDictionary<TKey, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>.Builder
                f_209_19110_19220()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<TKey, ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19110, 19220);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>.Builder
                f_209_19256_19339()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19256, 19339);
                    return return_v;
                }


                bool
                f_209_19600_19645(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19600, 19645);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_209_19741_19782(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19741, 19782);
                    return return_v;
                }


                int
                f_209_19695_19783(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19695, 19783);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                f_209_19531_19554_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19531, 19554);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_209_19863_19891(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19863, 19891);
                    return return_v;
                }


                int
                f_209_19846_19892(System.Collections.Immutable.ImmutableDictionary<TKey, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>.Builder
                this_param, TKey
                key, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19846, 19892);
                    return 0;
                }


                int
                f_209_19911_19933(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19911, 19933);
                    return 0;
                }


                System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>
                f_209_19390_19409_I(System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19390, 19409);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<TKey, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>
                f_209_19972_19993(System.Collections.Immutable.ImmutableDictionary<TKey, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 19972, 19993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 18525, 20005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 18525, 20005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>> GetImmutable(
                    ImmutableHashSet<DiagnosticAnalyzer> analyzers,
                    Dictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>.Builder>? nonLocalDiagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(209, 20017, 20953);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 20304, 20468) || true) && (nonLocalDiagnosticsOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 20304, 20468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 20372, 20453);

                    return ImmutableDictionary<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(209, 20304, 20468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 20484, 20582);

                var
                builder = f_209_20498_20581()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 20596, 20897);
                    foreach (var diagnosticsByAnalyzer in f_209_20634_20656_I(nonLocalDiagnosticsOpt))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 20596, 20897);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 20690, 20882) || true) && (f_209_20694_20739(analyzers, diagnosticsByAnalyzer.Key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 20690, 20882);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 20781, 20863);

                            f_209_20781_20862(builder, diagnosticsByAnalyzer.Key, f_209_20820_20861(diagnosticsByAnalyzer.Value));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 20690, 20882);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(209, 20596, 20897);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 20913, 20942);

                return f_209_20920_20941(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(209, 20017, 20953);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>.Builder
                f_209_20498_20581()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, ImmutableArray<Diagnostic>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 20498, 20581);
                    return return_v;
                }


                bool
                f_209_20694_20739(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 20694, 20739);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_209_20820_20861(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 20820, 20861);
                    return return_v;
                }


                int
                f_209_20781_20862(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 20781, 20862);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                f_209_20634_20656_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 20634, 20656);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_209_20920_20941(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 20920, 20941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 20017, 20953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 20017, 20953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableDictionary<DiagnosticAnalyzer, AnalyzerTelemetryInfo> GetTelemetryInfo(
                    ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(209, 20965, 22042);
                Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts actionCounts = default(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21137, 21230);

                var
                builder = f_209_21151_21229()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21252, 21257);

                lock (_gate)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21291, 21971);
                        foreach (var analyzer in f_209_21316_21325_I(analyzers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 21291, 21971);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21367, 21552) || true) && (!f_209_21372_21437(_analyzerActionCounts, analyzer, out actionCounts))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(209, 21367, 21552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21487, 21529);

                                actionCounts = AnalyzerActionCounts.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(209, 21367, 21552);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21576, 21647);

                            var
                            suppressionActionCounts = (DynAbs.Tracing.TraceSender.Conditional_F1(209, 21606, 21638) || ((analyzer is DiagnosticSuppressor && DynAbs.Tracing.TraceSender.Conditional_F2(209, 21641, 21642)) || DynAbs.Tracing.TraceSender.Conditional_F3(209, 21645, 21646))) ? 1 : 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21669, 21771);

                            var
                            executionTime = (DynAbs.Tracing.TraceSender.Conditional_F1(209, 21689, 21722) || ((_analyzerExecutionTimeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(209, 21725, 21760)) || DynAbs.Tracing.TraceSender.Conditional_F3(209, 21763, 21770))) ? f_209_21725_21760(_analyzerExecutionTimeOpt, analyzer) : default
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21793, 21893);

                            var
                            telemetryInfo = f_209_21813_21892(actionCounts, suppressionActionCounts, executionTime)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 21915, 21952);

                            f_209_21915_21951(builder, analyzer, telemetryInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(209, 21291, 21971);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(209, 1, 681);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(209, 1, 681);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 22002, 22031);

                return f_209_22009_22030(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(209, 20965, 22042);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo>.Builder
                f_209_21151_21229()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, AnalyzerTelemetryInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 21151, 21229);
                    return return_v;
                }


                bool
                f_209_21372_21437(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, out Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 21372, 21437);
                    return return_v;
                }


                System.TimeSpan
                f_209_21725_21760(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(209, 21725, 21760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo
                f_209_21813_21892(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                actionCounts, int
                suppressionActionCounts, System.TimeSpan
                executionTime)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo(actionCounts, suppressionActionCounts, executionTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 21813, 21892);
                    return return_v;
                }


                int
                f_209_21915_21951(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 21915, 21951);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_209_21316_21325_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 21316, 21325);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo>
                f_209_22009_22030(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 22009, 22030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(209, 20965, 22042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 20965, 22042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalysisResultBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(209, 746, 22049);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(209, 885, 1029);
            s_emptyPathToAdditionalTextMap = f_209_931_1029(ImmutableDictionary<string, OneOrMany<AdditionalText>>.Empty, PathUtilities.Comparer); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(209, 746, 22049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(209, 746, 22049);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(209, 746, 22049);

        static System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>
        f_209_931_1029(System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>
        this_param, System.Collections.Generic.IEqualityComparer<string>
        keyComparer)
        {
            var return_v = this_param.WithComparers(keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 931, 1029);
            return return_v;
        }


        object
        f_209_1074_1086()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 1074, 1086);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
        f_209_2278_2319(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers)
        {
            var return_v = CreateAnalyzerExecutionTimeMap(analyzers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 2278, 2319);
            return return_v;
        }


        static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        f_209_2363_2396()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 2363, 2396);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
        f_209_2435_2509(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 2435, 2509);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.AdditionalText>>
        f_209_2551_2597(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
        additionalFiles)
        {
            var return_v = CreatePathToAdditionalTextMap(additionalFiles);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(209, 2551, 2597);
            return return_v;
        }

    }
}
