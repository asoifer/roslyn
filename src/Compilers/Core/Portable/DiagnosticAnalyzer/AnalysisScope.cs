// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal class AnalysisScope
    {
        private readonly Lazy<ImmutableHashSet<DiagnosticAnalyzer>> _lazyAnalyzersSet;

        public SourceOrAdditionalFile? FilterFileOpt { get; }

        public TextSpan? FilterSpanOpt { get; }

        public ImmutableArray<DiagnosticAnalyzer> Analyzers { get; }

        public IEnumerable<SyntaxTree> SyntaxTrees { get; }

        public IEnumerable<AdditionalText> AdditionalFiles { get; }

        public bool ConcurrentAnalysis { get; }

        public bool CategorizeDiagnostics { get; }

        public bool IsSyntacticSingleFileAnalysis { get; }

        public bool IsSingleFileAnalysis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 2104, 2128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 2107, 2128);
                    return f_210_2107_2120() != null; DynAbs.Tracing.TraceSender.TraceExitMethod(210, 2104, 2128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 2104, 2128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 2104, 2128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPartialAnalysis { get; }

        public AnalysisScope(Compilation compilation, AnalyzerOptions? analyzerOptions, ImmutableArray<DiagnosticAnalyzer> analyzers, bool hasAllAnalyzers, bool concurrentAnalysis, bool categorizeDiagnostics)
        : this(f_210_2737_2760_C(f_210_2737_2760(compilation)), f_210_2762_2794_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerOptions, 210, 2762, 2794)?.AdditionalFiles) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?>(210, 2762, 2834) ?? ImmutableArray<AdditionalText>.Empty), analyzers, isPartialAnalysis: !hasAllAnalyzers, filterFile: null, filterSpanOpt: null, isSyntacticSingleFileAnalysis: false, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(210, 2516, 3088);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(210, 2516, 3088);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 2516, 3088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 2516, 3088);
            }
        }

        public AnalysisScope(ImmutableArray<DiagnosticAnalyzer> analyzers, SourceOrAdditionalFile filterFile, TextSpan? filterSpan, bool isSyntacticSingleFileAnalysis, bool concurrentAnalysis, bool categorizeDiagnostics)
        : this(f_210_3333_3485_C((DynAbs.Tracing.TraceSender.Conditional_F1(210, 3333, 3362) || ((filterFile.SourceTree != null && DynAbs.Tracing.TraceSender.Conditional_F2(210, 3365, 3430)) || DynAbs.Tracing.TraceSender.Conditional_F3(210, 3433, 3485))) ? f_210_3365_3430(filterFile.SourceTree) : f_210_3433_3485()), (DynAbs.Tracing.TraceSender.Conditional_F1(210, 3507, 3540) || ((filterFile.AdditionalFile != null && DynAbs.Tracing.TraceSender.Conditional_F2(210, 3543, 3612)) || DynAbs.Tracing.TraceSender.Conditional_F3(210, 3615, 3671))) ? f_210_3543_3612(filterFile.AdditionalFile) : f_210_3615_3671(), analyzers, isPartialAnalysis: true, filterFile, filterSpan, isSyntacticSingleFileAnalysis, concurrentAnalysis, categorizeDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(210, 3100, 3848);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(210, 3100, 3848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 3100, 3848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 3100, 3848);
            }
        }

        private AnalysisScope(IEnumerable<SyntaxTree> trees, IEnumerable<AdditionalText> additionalFiles, ImmutableArray<DiagnosticAnalyzer> analyzers, bool isPartialAnalysis, SourceOrAdditionalFile? filterFile, TextSpan? filterSpanOpt, bool isSyntacticSingleFileAnalysis, bool concurrentAnalysis, bool categorizeDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(210, 3860, 4971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 848, 865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 878, 931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 941, 980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 1182, 1233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 1360, 1419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 1431, 1470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 1671, 1713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 1873, 1923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 2466, 2504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4202, 4259);

                f_210_4202_4258(isPartialAnalysis || (DynAbs.Tracing.TraceSender.Expression_False(210, 4215, 4257) || f_210_4236_4249() == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4273, 4330);

                f_210_4273_4329(isPartialAnalysis || (DynAbs.Tracing.TraceSender.Expression_False(210, 4286, 4328) || f_210_4307_4320() == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4344, 4410);

                f_210_4344_4409(isPartialAnalysis || (DynAbs.Tracing.TraceSender.Expression_False(210, 4357, 4408) || !isSyntacticSingleFileAnalysis));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4426, 4446);

                SyntaxTrees = trees;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4460, 4494);

                AdditionalFiles = additionalFiles;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4508, 4530);

                Analyzers = analyzers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4544, 4582);

                IsPartialAnalysis = isPartialAnalysis;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4596, 4623);

                FilterFileOpt = filterFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4637, 4667);

                FilterSpanOpt = filterSpanOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4681, 4743);

                IsSyntacticSingleFileAnalysis = isSyntacticSingleFileAnalysis;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4757, 4797);

                ConcurrentAnalysis = concurrentAnalysis;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4811, 4857);

                CategorizeDiagnostics = categorizeDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 4873, 4960);

                _lazyAnalyzersSet = f_210_4893_4959(CreateAnalyzersSet);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(210, 3860, 4971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 3860, 4971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 3860, 4971);
            }
        }

        private ImmutableHashSet<DiagnosticAnalyzer> CreateAnalyzersSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 5049, 5082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 5052, 5082);
                // LAFHIS
                var temp = f_210_5052_5061();
                return f_210_5052_5082(ref temp); DynAbs.Tracing.TraceSender.TraceExitMethod(210, 5049, 5082);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 5049, 5082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 5049, 5082);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            f_210_5052_5061()
            {
                var return_v = Analyzers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5052, 5061);
                return return_v;
            }


            System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            f_210_5052_5082(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            source)
            {
                var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 5052, 5082);
                return return_v;
            }

        }

        public bool Contains(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 5095, 5404);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 5169, 5327) || true) && (f_210_5173_5191_M(!IsPartialAnalysis))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 5169, 5327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 5225, 5282);

                    f_210_5225_5281(f_210_5238_5280(f_210_5238_5261(_lazyAnalyzersSet), analyzer));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 5300, 5312);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 5169, 5327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 5343, 5393);

                return f_210_5350_5392(f_210_5350_5373(_lazyAnalyzersSet), analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 5095, 5404);

                bool
                f_210_5173_5191_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5173, 5191);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_210_5238_5261(System.Lazy<System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5238, 5261);
                    return return_v;
                }


                bool
                f_210_5238_5280(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 5238, 5280);
                    return return_v;
                }


                int
                f_210_5225_5281(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 5225, 5281);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_210_5350_5373(System.Lazy<System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5350, 5373);
                    return return_v;
                }


                bool
                f_210_5350_5392(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 5350, 5392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 5095, 5404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 5095, 5404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AnalysisScope WithAnalyzers(ImmutableArray<DiagnosticAnalyzer> analyzers, bool hasAllAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 5416, 5822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 5543, 5608);

                var
                isPartialAnalysis = f_210_5567_5587() || (DynAbs.Tracing.TraceSender.Expression_False(210, 5567, 5607) || !hasAllAnalyzers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 5622, 5811);

                return f_210_5629_5810(f_210_5647_5658(), f_210_5660_5675(), analyzers, isPartialAnalysis, f_210_5707_5720(), f_210_5722_5735(), f_210_5737_5766(), f_210_5768_5786(), f_210_5788_5809());
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 5416, 5822);

                bool
                f_210_5567_5587()
                {
                    var return_v = IsSingleFileAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5567, 5587);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_210_5647_5658()
                {
                    var return_v = SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5647, 5658);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
                f_210_5660_5675()
                {
                    var return_v = AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5660, 5675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_5707_5720()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5707, 5720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan?
                f_210_5722_5735()
                {
                    var return_v = FilterSpanOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5722, 5735);
                    return return_v;
                }


                bool
                f_210_5737_5766()
                {
                    var return_v = IsSyntacticSingleFileAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5737, 5766);
                    return return_v;
                }


                bool
                f_210_5768_5786()
                {
                    var return_v = ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5768, 5786);
                    return return_v;
                }


                bool
                f_210_5788_5809()
                {
                    var return_v = CategorizeDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 5788, 5809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_210_5629_5810(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                trees, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
                additionalFiles, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                isPartialAnalysis, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                filterFile, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanOpt, bool
                isSyntacticSingleFileAnalysis, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(trees, additionalFiles, analyzers, isPartialAnalysis, filterFile, filterSpanOpt, isSyntacticSingleFileAnalysis, concurrentAnalysis, categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 5629, 5810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 5416, 5822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 5416, 5822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ShouldSkipSymbolAnalysis(SymbolDeclaredCompilationEvent symbolEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(210, 5834, 6168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 6038, 6157);

                return f_210_6045_6084(f_210_6045_6063(symbolEvent)) || (DynAbs.Tracing.TraceSender.Expression_False(210, 6045, 6156) || symbolEvent.DeclaringSyntaxReferences.All(s => s.SyntaxTree == null));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(210, 5834, 6168);

                Microsoft.CodeAnalysis.ISymbol
                f_210_6045_6063(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6045, 6063);
                    return return_v;
                }


                bool
                f_210_6045_6084(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6045, 6084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 5834, 6168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 5834, 6168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ShouldSkipDeclarationAnalysis(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(210, 6180, 6550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 6395, 6539);

                return f_210_6402_6429(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(210, 6402, 6538) && !((f_210_6453_6464(symbol) == SymbolKind.Namespace && (DynAbs.Tracing.TraceSender.Expression_True(210, 6453, 6536) && f_210_6492_6536(((INamespaceSymbol)symbol))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(210, 6180, 6550);

                bool
                f_210_6402_6429(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6402, 6429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_210_6453_6464(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6453, 6464);
                    return return_v;
                }


                bool
                f_210_6492_6536(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6492, 6536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 6180, 6550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 6180, 6550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldAnalyze(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 6562, 6713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 6629, 6702);

                return f_210_6636_6659_M(!f_210_6637_6650().HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(210, 6636, 6701) || f_210_6663_6676().Value.SourceTree == tree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 6562, 6713);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_6637_6650()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6637, 6650);
                    return return_v;
                }


                bool
                f_210_6636_6659_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6636, 6659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_6663_6676()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6663, 6676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 6562, 6713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 6562, 6713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldAnalyze(AdditionalText file)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 6725, 6884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 6796, 6873);

                return f_210_6803_6826_M(!f_210_6804_6817().HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(210, 6803, 6872) || f_210_6830_6843().Value.AdditionalFile == file);
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 6725, 6884);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_6804_6817()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6804, 6817);
                    return return_v;
                }


                bool
                f_210_6803_6826_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6803, 6826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_6830_6843()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6830, 6843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 6725, 6884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 6725, 6884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldAnalyze(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 6896, 7484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 6962, 7050) || true) && (f_210_6966_6989_M(!f_210_6967_6980().HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 6962, 7050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7023, 7035);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 6962, 7050);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7066, 7170) || true) && (f_210_7070_7083().Value.SourceTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 7066, 7170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7142, 7155);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 7066, 7170);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7186, 7444);
                    foreach (var location in f_210_7211_7227_I(f_210_7211_7227(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 7186, 7444);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7261, 7429) || true) && (f_210_7265_7278().Value.SourceTree == f_210_7299_7318(location) && (DynAbs.Tracing.TraceSender.Expression_True(210, 7265, 7356) && f_210_7322_7356(this, f_210_7336_7355(location))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 7261, 7429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7398, 7410);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(210, 7261, 7429);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(210, 7186, 7444);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(210, 1, 259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(210, 1, 259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7460, 7473);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 6896, 7484);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_6967_6980()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6967, 6980);
                    return return_v;
                }


                bool
                f_210_6966_6989_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 6966, 6989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_7070_7083()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7070, 7083);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_210_7211_7227(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7211, 7227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_7265_7278()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7265, 7278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_210_7299_7318(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7299, 7318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_210_7336_7355(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7336, 7355);
                    return return_v;
                }


                bool
                f_210_7322_7356(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                filterSpan)
                {
                    var return_v = this_param.ShouldInclude(filterSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 7322, 7356);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_210_7211_7227_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 7211, 7227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 6896, 7484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 6896, 7484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldAnalyze(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 7496, 7834);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7563, 7651) || true) && (f_210_7567_7590_M(!f_210_7568_7581().HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 7563, 7651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7624, 7636);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 7563, 7651);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7667, 7771) || true) && (f_210_7671_7684().Value.SourceTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 7667, 7771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7743, 7756);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 7667, 7771);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7787, 7823);

                return f_210_7794_7822(this, f_210_7808_7821(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 7496, 7834);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_7568_7581()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7568, 7581);
                    return return_v;
                }


                bool
                f_210_7567_7590_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7567, 7590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_7671_7684()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7671, 7684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_210_7808_7821(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7808, 7821);
                    return return_v;
                }


                bool
                f_210_7794_7822(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                filterSpan)
                {
                    var return_v = this_param.ShouldInclude(filterSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 7794, 7822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 7496, 7834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 7496, 7834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldInclude(TextSpan filterSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 7846, 8010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 7918, 7999);

                return f_210_7925_7948_M(!f_210_7926_7939().HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(210, 7925, 7998) || f_210_7952_7965().Value.IntersectsWith(filterSpan));
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 7846, 8010);

                Microsoft.CodeAnalysis.Text.TextSpan?
                f_210_7926_7939()
                {
                    var return_v = FilterSpanOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7926, 7939);
                    return return_v;
                }


                bool
                f_210_7925_7948_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7925, 7948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan?
                f_210_7952_7965()
                {
                    var return_v = FilterSpanOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 7952, 7965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 7846, 8010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 7846, 8010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ContainsSpan(TextSpan filterSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 8022, 8178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8092, 8167);

                return f_210_8099_8122_M(!f_210_8100_8113().HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(210, 8099, 8166) || f_210_8126_8139().Value.Contains(filterSpan));
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 8022, 8178);

                Microsoft.CodeAnalysis.Text.TextSpan?
                f_210_8100_8113()
                {
                    var return_v = FilterSpanOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8100, 8113);
                    return return_v;
                }


                bool
                f_210_8099_8122_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8099, 8122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan?
                f_210_8126_8139()
                {
                    var return_v = FilterSpanOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8126, 8139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 8022, 8178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 8022, 8178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldInclude(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(210, 8190, 9055);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8263, 8351) || true) && (f_210_8267_8290_M(!f_210_8268_8281().HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 8263, 8351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8324, 8336);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 8263, 8351);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8367, 8975) || true) && (f_210_8371_8401(f_210_8371_8390(diagnostic)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 8367, 8975);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8435, 8577) || true) && (f_210_8439_8469(f_210_8439_8458(diagnostic)) != f_210_8473_8486().Value.SourceTree)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 8435, 8577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8545, 8558);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(210, 8435, 8577);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 8367, 8975);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 8367, 8975);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8611, 8975) || true) && (f_210_8615_8634(diagnostic) is ExternalFileLocation externalFileLocation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 8611, 8975);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8713, 8960) || true) && (f_210_8717_8730().Value.AdditionalFile == null || (DynAbs.Tracing.TraceSender.Expression_False(210, 8717, 8886) || !f_210_8785_8886(PathUtilities.Comparer, f_210_8815_8844(externalFileLocation), f_210_8846_8885(f_210_8846_8859().Value.AdditionalFile))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(210, 8713, 8960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8928, 8941);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(210, 8713, 8960);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(210, 8611, 8975);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(210, 8367, 8975);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(210, 8991, 9044);

                return f_210_8998_9043(this, f_210_9012_9042(f_210_9012_9031(diagnostic)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(210, 8190, 9055);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_8268_8281()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8268, 8281);
                    return return_v;
                }


                bool
                f_210_8267_8290_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8267, 8290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_210_8371_8390(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8371, 8390);
                    return return_v;
                }


                bool
                f_210_8371_8401(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8371, 8401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_210_8439_8458(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8439, 8458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_210_8439_8469(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8439, 8469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_8473_8486()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8473, 8486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_210_8615_8634(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8615, 8634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_8717_8730()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8717, 8730);
                    return return_v;
                }


                string
                f_210_8815_8844(Microsoft.CodeAnalysis.ExternalFileLocation
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8815, 8844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_210_8846_8859()
                {
                    var return_v = FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8846, 8859);
                    return return_v;
                }


                string
                f_210_8846_8885(Microsoft.CodeAnalysis.AdditionalText
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 8846, 8885);
                    return return_v;
                }


                bool
                f_210_8785_8886(System.Collections.Generic.IEqualityComparer<string>
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 8785, 8886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_210_9012_9031(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 9012, 9031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_210_9012_9042(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 9012, 9042);
                    return return_v;
                }


                bool
                f_210_8998_9043(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                filterSpan)
                {
                    var return_v = this_param.ShouldInclude(filterSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 8998, 9043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(210, 8190, 9055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 8190, 9055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(210, 743, 9062);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(210, 743, 9062);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(210, 743, 9062);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(210, 743, 9062);

        Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
        f_210_2107_2120()
        {
            var return_v = FilterFileOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 2107, 2120);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        f_210_2737_2760(Microsoft.CodeAnalysis.Compilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 2737, 2760);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?
        f_210_2762_2794_M(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 2762, 2794);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        f_210_2737_2760_C(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(210, 2516, 3088);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        f_210_3365_3430(Microsoft.CodeAnalysis.SyntaxTree
        value)
        {
            var return_v = SpecializedCollections.SingletonEnumerable(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 3365, 3430);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        f_210_3433_3485()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<SyntaxTree>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 3433, 3485);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
        f_210_3543_3612(Microsoft.CodeAnalysis.AdditionalText
        value)
        {
            var return_v = SpecializedCollections.SingletonEnumerable(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 3543, 3612);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
        f_210_3615_3671()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<AdditionalText>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 3615, 3671);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        f_210_3333_3485_C(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(210, 3100, 3848);
            return return_v;
        }


        Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
        f_210_4236_4249()
        {
            var return_v = FilterFileOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 4236, 4249);
            return return_v;
        }


        static int
        f_210_4202_4258(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 4202, 4258);
            return 0;
        }


        Microsoft.CodeAnalysis.Text.TextSpan?
        f_210_4307_4320()
        {
            var return_v = FilterSpanOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(210, 4307, 4320);
            return return_v;
        }


        static int
        f_210_4273_4329(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 4273, 4329);
            return 0;
        }


        static int
        f_210_4344_4409(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 4344, 4409);
            return 0;
        }


        static System.Lazy<System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
        f_210_4893_4959(System.Func<System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(210, 4893, 4959);
            return return_v;
        }

    }
}
