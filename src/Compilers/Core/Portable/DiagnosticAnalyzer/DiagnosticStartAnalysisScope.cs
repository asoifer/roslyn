// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class AnalyzerAnalysisContext : AnalysisContext
    {
        private readonly DiagnosticAnalyzer _analyzer;

        private readonly HostSessionStartAnalysisScope _scope;

        public AnalyzerAnalysisContext(DiagnosticAnalyzer analyzer, HostSessionStartAnalysisScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 901, 1083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 815, 824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 882, 888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1022, 1043);

                _analyzer = analyzer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1057, 1072);

                _scope = scope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 901, 1083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 901, 1083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 901, 1083);
            }
        }

        public override void RegisterCompilationStartAction(Action<CompilationStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 1095, 1358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1219, 1276);

                f_263_1219_1275(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1290, 1347);

                f_263_1290_1346(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 1095, 1358);

                int
                f_263_1219_1275(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 1219, 1275);
                    return 0;
                }


                int
                f_263_1290_1346(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationStartAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 1290, 1346);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 1095, 1358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 1095, 1358);
            }
        }

        public override void RegisterCompilationAction(Action<CompilationAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 1370, 1618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1484, 1541);

                f_263_1484_1540(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1555, 1607);

                f_263_1555_1606(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 1370, 1618);

                int
                f_263_1484_1540(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 1484, 1540);
                    return 0;
                }


                int
                f_263_1555_1606(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 1555, 1606);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 1370, 1618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 1370, 1618);
            }
        }

        public override void RegisterSyntaxTreeAction(Action<SyntaxTreeAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 1630, 1875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1742, 1799);

                f_263_1742_1798(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 1813, 1864);

                f_263_1813_1863(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 1630, 1875);

                int
                f_263_1742_1798(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 1742, 1798);
                    return 0;
                }


                int
                f_263_1813_1863(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                action)
                {
                    this_param.RegisterSyntaxTreeAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 1813, 1863);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 1630, 1875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 1630, 1875);
            }
        }

        public override void RegisterAdditionalFileAction(Action<AdditionalFileAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 1887, 2144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2007, 2064);

                f_263_2007_2063(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2078, 2133);

                f_263_2078_2132(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 1887, 2144);

                int
                f_263_2007_2063(System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2007, 2063);
                    return 0;
                }


                int
                f_263_2078_2132(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext>
                action)
                {
                    this_param.RegisterAdditionalFileAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2078, 2132);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 1887, 2144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 1887, 2144);
            }
        }

        public override void RegisterSemanticModelAction(Action<SemanticModelAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 2156, 2410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2274, 2331);

                f_263_2274_2330(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2345, 2399);

                f_263_2345_2398(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 2156, 2410);

                int
                f_263_2274_2330(System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2274, 2330);
                    return 0;
                }


                int
                f_263_2345_2398(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext>
                action)
                {
                    this_param.RegisterSemanticModelAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2345, 2398);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 2156, 2410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 2156, 2410);
            }
        }

        public override void RegisterSymbolAction(Action<SymbolAnalysisContext> action, ImmutableArray<SymbolKind> symbolKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 2422, 2721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2566, 2636);

                f_263_2566_2635(action, symbolKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2650, 2710);

                f_263_2650_2709(_scope, _analyzer, action, symbolKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 2422, 2721);

                int
                f_263_2566_2635(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2566, 2635);
                    return 0;
                }


                int
                f_263_2650_2709(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    this_param.RegisterSymbolAction(analyzer, action, symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2650, 2709);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 2422, 2721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 2422, 2721);
            }
        }

        public override void RegisterSymbolStartAction(Action<SymbolStartAnalysisContext> action, SymbolKind symbolKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 2733, 3016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2870, 2927);

                f_263_2870_2926(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 2941, 3005);

                f_263_2941_3004(_scope, _analyzer, action, symbolKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 2733, 3016);

                int
                f_263_2870_2926(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2870, 2926);
                    return 0;
                }


                int
                f_263_2941_3004(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                action, Microsoft.CodeAnalysis.SymbolKind
                symbolKind)
                {
                    this_param.RegisterSymbolStartAction(analyzer, action, symbolKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 2941, 3004);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 2733, 3016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 2733, 3016);
            }
        }

        public override void RegisterCodeBlockStartAction<TLanguageKindEnum>(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 3028, 3342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 3186, 3243);

                f_263_3186_3242(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 3257, 3331);

                f_263_3257_3330(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 3028, 3342);

                int
                f_263_3186_3242(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 3186, 3242);
                    return 0;
                }


                int
                f_263_3257_3330(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                action)
                {
                    this_param.RegisterCodeBlockStartAction<TLanguageKindEnum>(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 3257, 3330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 3028, 3342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 3028, 3342);
            }
        }

        public override void RegisterCodeBlockAction(Action<CodeBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 3354, 3596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 3464, 3521);

                f_263_3464_3520(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 3535, 3585);

                f_263_3535_3584(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 3354, 3596);

                int
                f_263_3464_3520(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 3464, 3520);
                    return 0;
                }


                int
                f_263_3535_3584(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action)
                {
                    this_param.RegisterCodeBlockAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 3535, 3584);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 3354, 3596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 3354, 3596);
            }
        }

        public override void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 3608, 3945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 3786, 3856);

                f_263_3786_3855(action, syntaxKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 3870, 3934);

                f_263_3870_3933(_scope, _analyzer, action, syntaxKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 3608, 3945);

                int
                f_263_3786_3855(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 3786, 3855);
                    return 0;
                }


                int
                f_263_3870_3933(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<TLanguageKindEnum>(analyzer, action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 3870, 3933);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 3608, 3945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 3608, 3945);
            }
        }

        public override void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 3957, 4277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 4113, 4186);

                f_263_4113_4185(action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 4200, 4266);

                f_263_4200_4265(_scope, _analyzer, action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 3957, 4277);

                int
                f_263_4113_4185(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 4113, 4185);
                    return 0;
                }


                int
                f_263_4200_4265(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(analyzer, action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 4200, 4265);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 3957, 4277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 3957, 4277);
            }
        }

        public override void RegisterOperationBlockStartAction(Action<OperationBlockStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 4289, 4561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 4419, 4476);

                f_263_4419_4475(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 4490, 4550);

                f_263_4490_4549(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 4289, 4561);

                int
                f_263_4419_4475(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 4419, 4475);
                    return 0;
                }


                int
                f_263_4490_4549(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockStartAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 4490, 4549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 4289, 4561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 4289, 4561);
            }
        }

        public override void RegisterOperationBlockAction(Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 4573, 4830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 4693, 4750);

                f_263_4693_4749(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 4764, 4819);

                f_263_4764_4818(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 4573, 4830);

                int
                f_263_4693_4749(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 4693, 4749);
                    return 0;
                }


                int
                f_263_4764_4818(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 4764, 4818);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 4573, 4830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 4573, 4830);
            }
        }

        public override void EnableConcurrentExecution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 4842, 4970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 4915, 4959);

                f_263_4915_4958(_scope, _analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 4842, 4970);

                int
                f_263_4915_4958(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    this_param.EnableConcurrentExecution(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 4915, 4958);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 4842, 4970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 4842, 4970);
            }
        }

        public override void ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 4982, 5157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 5091, 5146);

                f_263_5091_5145(_scope, _analyzer, mode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 4982, 5157);

                int
                f_263_5091_5145(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                mode)
                {
                    this_param.ConfigureGeneratedCodeAnalysis(analyzer, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 5091, 5145);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 4982, 5157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 4982, 5157);
            }
        }

        static AnalyzerAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 699, 5164);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 699, 5164);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 699, 5164);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 699, 5164);
    }
    internal sealed class AnalyzerCompilationStartAnalysisContext : CompilationStartAnalysisContext
    {
        private readonly DiagnosticAnalyzer _analyzer;

        private readonly HostCompilationStartAnalysisScope _scope;

        private readonly CompilationAnalysisValueProviderFactory _compilationAnalysisValueProviderFactory;

        public AnalyzerCompilationStartAnalysisContext(
                    DiagnosticAnalyzer analyzer,
                    HostCompilationStartAnalysisScope scope,
                    Compilation compilation,
                    AnalyzerOptions options,
                    CompilationAnalysisValueProviderFactory compilationAnalysisValueProviderFactory,
                    CancellationToken cancellationToken)
        : base(f_263_6050_6061_C(compilation), options, cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 5666, 6273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 5468, 5477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 5539, 5545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 5613, 5653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6115, 6136);

                _analyzer = analyzer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6150, 6165);

                _scope = scope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6179, 6262);

                _compilationAnalysisValueProviderFactory = compilationAnalysisValueProviderFactory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 5666, 6273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 5666, 6273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 5666, 6273);
            }
        }

        public override void RegisterCompilationEndAction(Action<CompilationAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 6285, 6539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6402, 6459);

                f_263_6402_6458(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6473, 6528);

                f_263_6473_6527(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 6285, 6539);

                int
                f_263_6402_6458(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 6402, 6458);
                    return 0;
                }


                int
                f_263_6473_6527(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationEndAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 6473, 6527);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 6285, 6539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 6285, 6539);
            }
        }

        public override void RegisterSyntaxTreeAction(Action<SyntaxTreeAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 6551, 6796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6663, 6720);

                f_263_6663_6719(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6734, 6785);

                f_263_6734_6784(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 6551, 6796);

                int
                f_263_6663_6719(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 6663, 6719);
                    return 0;
                }


                int
                f_263_6734_6784(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                action)
                {
                    this_param.RegisterSyntaxTreeAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 6734, 6784);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 6551, 6796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 6551, 6796);
            }
        }

        public override void RegisterAdditionalFileAction(Action<AdditionalFileAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 6808, 7065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6928, 6985);

                f_263_6928_6984(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 6999, 7054);

                f_263_6999_7053(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 6808, 7065);

                int
                f_263_6928_6984(System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 6928, 6984);
                    return 0;
                }


                int
                f_263_6999_7053(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext>
                action)
                {
                    this_param.RegisterAdditionalFileAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 6999, 7053);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 6808, 7065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 6808, 7065);
            }
        }

        public override void RegisterSemanticModelAction(Action<SemanticModelAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 7077, 7331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 7195, 7252);

                f_263_7195_7251(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 7266, 7320);

                f_263_7266_7319(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 7077, 7331);

                int
                f_263_7195_7251(System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 7195, 7251);
                    return 0;
                }


                int
                f_263_7266_7319(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext>
                action)
                {
                    this_param.RegisterSemanticModelAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 7266, 7319);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 7077, 7331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 7077, 7331);
            }
        }

        public override void RegisterSymbolAction(Action<SymbolAnalysisContext> action, ImmutableArray<SymbolKind> symbolKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 7343, 7642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 7487, 7557);

                f_263_7487_7556(action, symbolKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 7571, 7631);

                f_263_7571_7630(_scope, _analyzer, action, symbolKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 7343, 7642);

                int
                f_263_7487_7556(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 7487, 7556);
                    return 0;
                }


                int
                f_263_7571_7630(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    this_param.RegisterSymbolAction(analyzer, action, symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 7571, 7630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 7343, 7642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 7343, 7642);
            }
        }

        public override void RegisterSymbolStartAction(Action<SymbolStartAnalysisContext> action, SymbolKind symbolKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 7654, 7937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 7791, 7848);

                f_263_7791_7847(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 7862, 7926);

                f_263_7862_7925(_scope, _analyzer, action, symbolKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 7654, 7937);

                int
                f_263_7791_7847(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 7791, 7847);
                    return 0;
                }


                int
                f_263_7862_7925(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                action, Microsoft.CodeAnalysis.SymbolKind
                symbolKind)
                {
                    this_param.RegisterSymbolStartAction(analyzer, action, symbolKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 7862, 7925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 7654, 7937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 7654, 7937);
            }
        }

        public override void RegisterCodeBlockStartAction<TLanguageKindEnum>(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 7949, 8263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 8107, 8164);

                f_263_8107_8163(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 8178, 8252);

                f_263_8178_8251(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 7949, 8263);

                int
                f_263_8107_8163(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 8107, 8163);
                    return 0;
                }


                int
                f_263_8178_8251(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                action)
                {
                    this_param.RegisterCodeBlockStartAction<TLanguageKindEnum>(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 8178, 8251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 7949, 8263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 7949, 8263);
            }
        }

        public override void RegisterCodeBlockAction(Action<CodeBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 8275, 8517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 8385, 8442);

                f_263_8385_8441(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 8456, 8506);

                f_263_8456_8505(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 8275, 8517);

                int
                f_263_8385_8441(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 8385, 8441);
                    return 0;
                }


                int
                f_263_8456_8505(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action)
                {
                    this_param.RegisterCodeBlockAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 8456, 8505);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 8275, 8517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 8275, 8517);
            }
        }

        public override void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 8529, 8866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 8707, 8777);

                f_263_8707_8776(action, syntaxKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 8791, 8855);

                f_263_8791_8854(_scope, _analyzer, action, syntaxKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 8529, 8866);

                int
                f_263_8707_8776(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 8707, 8776);
                    return 0;
                }


                int
                f_263_8791_8854(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<TLanguageKindEnum>(analyzer, action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 8791, 8854);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 8529, 8866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 8529, 8866);
            }
        }

        public override void RegisterOperationBlockStartAction(Action<OperationBlockStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 8878, 9150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 9008, 9065);

                f_263_9008_9064(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 9079, 9139);

                f_263_9079_9138(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 8878, 9150);

                int
                f_263_9008_9064(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 9008, 9064);
                    return 0;
                }


                int
                f_263_9079_9138(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockStartAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 9079, 9138);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 8878, 9150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 8878, 9150);
            }
        }

        public override void RegisterOperationBlockAction(Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 9162, 9419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 9282, 9339);

                f_263_9282_9338(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 9353, 9408);

                f_263_9353_9407(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 9162, 9419);

                int
                f_263_9282_9338(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 9282, 9338);
                    return 0;
                }


                int
                f_263_9353_9407(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 9353, 9407);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 9162, 9419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 9162, 9419);
            }
        }

        public override void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 9431, 9751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 9587, 9660);

                f_263_9587_9659(action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 9674, 9740);

                f_263_9674_9739(_scope, _analyzer, action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 9431, 9751);

                int
                f_263_9587_9659(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 9587, 9659);
                    return 0;
                }


                int
                f_263_9674_9739(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(analyzer, action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 9674, 9739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 9431, 9751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 9431, 9751);
            }
        }

        internal override bool TryGetValueCore<TKey, TValue>(TKey key, AnalysisValueProvider<TKey, TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 9763, 10147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 9942, 10054);

                var
                compilationAnalysisValueProvider = f_263_9981_10053(_compilationAnalysisValueProviderFactory, valueProvider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 10068, 10136);

                return f_263_10075_10135(compilationAnalysisValueProvider, key, out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 9763, 10147);

                Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProvider<TKey, TValue>
                f_263_9981_10053(Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProviderFactory
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                analysisSharedStateProvider)
                {
                    var return_v = this_param.GetValueProvider<TKey, TValue>(analysisSharedStateProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 9981, 10053);
                    return return_v;
                }


                bool
                f_263_10075_10135(Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProvider<TKey, TValue>
                this_param, TKey
                key, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 10075, 10135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 9763, 10147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 9763, 10147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalyzerCompilationStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 5320, 10154);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 5320, 10154);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 5320, 10154);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 5320, 10154);

        static Microsoft.CodeAnalysis.Compilation
        f_263_6050_6061_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(263, 5666, 6273);
            return return_v;
        }

    }
    internal sealed class AnalyzerSymbolStartAnalysisContext : SymbolStartAnalysisContext
    {
        private readonly DiagnosticAnalyzer _analyzer;

        private readonly HostSymbolStartAnalysisScope _scope;

        internal AnalyzerSymbolStartAnalysisContext(DiagnosticAnalyzer analyzer,
                                                               HostSymbolStartAnalysisScope scope,
                                                               ISymbol owningSymbol,
                                                               Compilation compilation,
                                                               AnalyzerOptions options,
                                                               CancellationToken cancellationToken)
        : base(f_263_11024_11036_C(owningSymbol), compilation, options, cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 10506, 11164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 10421, 10430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 10487, 10493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11103, 11124);

                _analyzer = analyzer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11138, 11153);

                _scope = scope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 10506, 11164);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 10506, 11164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 10506, 11164);
            }
        }

        public override void RegisterSymbolEndAction(Action<SymbolAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 11176, 11415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11283, 11340);

                f_263_11283_11339(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11354, 11404);

                f_263_11354_11403(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 11176, 11415);

                int
                f_263_11283_11339(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 11283, 11339);
                    return 0;
                }


                int
                f_263_11354_11403(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action)
                {
                    this_param.RegisterSymbolEndAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 11354, 11403);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 11176, 11415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 11176, 11415);
            }
        }

        public override void RegisterCodeBlockStartAction<TLanguageKindEnum>(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 11427, 11741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11585, 11642);

                f_263_11585_11641(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11656, 11730);

                f_263_11656_11729(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 11427, 11741);

                int
                f_263_11585_11641(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 11585, 11641);
                    return 0;
                }


                int
                f_263_11656_11729(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                action)
                {
                    this_param.RegisterCodeBlockStartAction<TLanguageKindEnum>(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 11656, 11729);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 11427, 11741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 11427, 11741);
            }
        }

        public override void RegisterCodeBlockAction(Action<CodeBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 11753, 11995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11863, 11920);

                f_263_11863_11919(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 11934, 11984);

                f_263_11934_11983(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 11753, 11995);

                int
                f_263_11863_11919(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 11863, 11919);
                    return 0;
                }


                int
                f_263_11934_11983(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action)
                {
                    this_param.RegisterCodeBlockAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 11934, 11983);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 11753, 11995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 11753, 11995);
            }
        }

        public override void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 12007, 12344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 12185, 12255);

                f_263_12185_12254(action, syntaxKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 12269, 12333);

                f_263_12269_12332(_scope, _analyzer, action, syntaxKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 12007, 12344);

                int
                f_263_12185_12254(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 12185, 12254);
                    return 0;
                }


                int
                f_263_12269_12332(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<TLanguageKindEnum>(analyzer, action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 12269, 12332);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 12007, 12344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 12007, 12344);
            }
        }

        public override void RegisterOperationBlockStartAction(Action<OperationBlockStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 12356, 12628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 12486, 12543);

                f_263_12486_12542(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 12557, 12617);

                f_263_12557_12616(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 12356, 12628);

                int
                f_263_12486_12542(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 12486, 12542);
                    return 0;
                }


                int
                f_263_12557_12616(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockStartAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 12557, 12616);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 12356, 12628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 12356, 12628);
            }
        }

        public override void RegisterOperationBlockAction(Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 12640, 12897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 12760, 12817);

                f_263_12760_12816(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 12831, 12886);

                f_263_12831_12885(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 12640, 12897);

                int
                f_263_12760_12816(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 12760, 12816);
                    return 0;
                }


                int
                f_263_12831_12885(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 12831, 12885);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 12640, 12897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 12640, 12897);
            }
        }

        public override void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 12909, 13229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 13065, 13138);

                f_263_13065_13137(action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 13152, 13218);

                f_263_13152_13217(_scope, _analyzer, action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 12909, 13229);

                int
                f_263_13065_13137(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 13065, 13137);
                    return 0;
                }


                int
                f_263_13152_13217(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(analyzer, action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 13152, 13217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 12909, 13229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 12909, 13229);
            }
        }

        static AnalyzerSymbolStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 10283, 13236);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 10283, 13236);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 10283, 13236);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 10283, 13236);

        static Microsoft.CodeAnalysis.ISymbol
        f_263_11024_11036_C(Microsoft.CodeAnalysis.ISymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(263, 10506, 11164);
            return return_v;
        }

    }
    internal sealed class AnalyzerCodeBlockStartAnalysisContext<TLanguageKindEnum> : CodeBlockStartAnalysisContext<TLanguageKindEnum> where TLanguageKindEnum : struct
    {
        private readonly DiagnosticAnalyzer _analyzer;

        private readonly HostCodeBlockStartAnalysisScope<TLanguageKindEnum> _scope;

        internal AnalyzerCodeBlockStartAnalysisContext(DiagnosticAnalyzer analyzer,
                                                               HostCodeBlockStartAnalysisScope<TLanguageKindEnum> scope,
                                                               SyntaxNode codeBlock,
                                                               ISymbol owningSymbol,
                                                               SemanticModel semanticModel,
                                                               AnalyzerOptions options,
                                                               CancellationToken cancellationToken)
        : base(f_263_14338_14347_C(codeBlock), owningSymbol, semanticModel, options, cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 13713, 14491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 13606, 13615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 13694, 13700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 14430, 14451);

                _analyzer = analyzer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 14465, 14480);

                _scope = scope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 13713, 14491);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 13713, 14491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 13713, 14491);
            }
        }

        public override void RegisterCodeBlockEndAction(Action<CodeBlockAnalysisContext> action)
        {
            DiagnosticAnalysisContextHelpers.VerifyArguments(action);
            _scope.RegisterCodeBlockEndAction(_analyzer, action);
        }

        public override void RegisterSyntaxNodeAction(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds)
        {
            DiagnosticAnalysisContextHelpers.VerifyArguments(action, syntaxKinds);
            _scope.RegisterSyntaxNodeAction(_analyzer, action, syntaxKinds);
        }

        static AnalyzerCodeBlockStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 13391, 15088);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 13391, 15088);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 13391, 15088);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 13391, 15088);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_263_14338_14347_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(263, 13713, 14491);
            return return_v;
        }

    }
    internal sealed class AnalyzerOperationBlockStartAnalysisContext : OperationBlockStartAnalysisContext
    {
        private readonly DiagnosticAnalyzer _analyzer;

        private readonly HostOperationBlockStartAnalysisScope _scope;

        internal AnalyzerOperationBlockStartAnalysisContext(DiagnosticAnalyzer analyzer,
                                                                    HostOperationBlockStartAnalysisScope scope,
                                                                    ImmutableArray<IOperation> operationBlocks,
                                                                    ISymbol owningSymbol,
                                                                    Compilation compilation,
                                                                    AnalyzerOptions options,
                                                                    Func<IOperation, ControlFlowGraph> getControlFlowGraph,
                                                                    CancellationToken cancellationToken)
        : base(f_263_16277_16292_C(operationBlocks), owningSymbol, compilation, options, getControlFlowGraph, cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 15496, 16455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 15403, 15412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 15477, 15483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 16394, 16415);

                _analyzer = analyzer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 16429, 16444);

                _scope = scope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 15496, 16455);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 15496, 16455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 15496, 16455);
            }
        }

        public override void RegisterOperationBlockEndAction(Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 16467, 16730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 16590, 16647);

                f_263_16590_16646(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 16661, 16719);

                f_263_16661_16718(_scope, _analyzer, action);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 16467, 16730);

                int
                f_263_16590_16646(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 16590, 16646);
                    return 0;
                }


                int
                f_263_16661_16718(Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action)
                {
                    this_param.RegisterOperationBlockEndAction(analyzer, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 16661, 16718);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 16467, 16730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 16467, 16730);
            }
        }

        public override void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 16742, 17062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 16898, 16971);

                f_263_16898_16970(action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 16985, 17051);

                f_263_16985_17050(_scope, _analyzer, action, operationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 16742, 17062);

                int
                f_263_16898_16970(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 16898, 16970);
                    return 0;
                }


                int
                f_263_16985_17050(Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(analyzer, action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 16985, 17050);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 16742, 17062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 16742, 17062);
            }
        }

        static AnalyzerOperationBlockStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 15249, 17069);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 15249, 17069);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 15249, 17069);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 15249, 17069);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        f_263_16277_16292_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(263, 15496, 16455);
            return return_v;
        }

    }
    internal sealed class HostSessionStartAnalysisScope : HostAnalysisScope
    {
        private ImmutableHashSet<DiagnosticAnalyzer> _concurrentAnalyzers;

        private readonly ConcurrentDictionary<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags> _generatedCodeConfigurationMap;

        public bool IsConcurrentAnalyzer(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 17629, 17773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 17715, 17762);

                return f_263_17722_17761(_concurrentAnalyzers, analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 17629, 17773);

                bool
                f_263_17722_17761(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 17722, 17761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 17629, 17773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 17629, 17773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GeneratedCodeAnalysisFlags GetGeneratedCodeAnalysisFlags(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 17785, 18087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 17902, 17934);

                GeneratedCodeAnalysisFlags
                mode
                = default(GeneratedCodeAnalysisFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 17948, 18076);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(263, 17955, 18017) || ((f_263_17955_18017(_generatedCodeConfigurationMap, analyzer, out mode) && DynAbs.Tracing.TraceSender.Conditional_F2(263, 18020, 18024)) || DynAbs.Tracing.TraceSender.Conditional_F3(263, 18027, 18075))) ? mode : AnalyzerDriver.DefaultGeneratedCodeAnalysisFlags;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 17785, 18087);

                bool
                f_263_17955_18017(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, out Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 17955, 18017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 17785, 18087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 17785, 18087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void RegisterCompilationStartAction(DiagnosticAnalyzer analyzer, Action<CompilationStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 18099, 18459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 18243, 18344);

                CompilationStartAnalyzerAction
                analyzerAction = f_263_18291_18343(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 18358, 18448);

                f_263_18358_18399(this, analyzer).Value.AddCompilationStartAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 18099, 18459);

                Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalyzerAction
                f_263_18291_18343(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 18291, 18343);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_18358_18399(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 18358, 18399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 18099, 18459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 18099, 18459);
            }
        }

        public void EnableConcurrentExecution(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 18471, 18716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 18562, 18620);

                _concurrentAnalyzers = f_263_18585_18619(_concurrentAnalyzers, analyzer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 18634, 18705);

                f_263_18634_18670(this, analyzer).Value.EnableConcurrentExecution();
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 18471, 18716);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_263_18585_18619(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 18585, 18619);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_18634_18670(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 18634, 18670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 18471, 18716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 18471, 18716);
            }
        }

        public void ConfigureGeneratedCodeAnalysis(DiagnosticAnalyzer analyzer, GeneratedCodeAnalysisFlags mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 18728, 18973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 18857, 18962);

                f_263_18857_18961(_generatedCodeConfigurationMap, analyzer, addValue: mode, updateValueFactory: (a, c) => mode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 18728, 18973);

                Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                f_263_18857_18961(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                addValue, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                updateValueFactory)
                {
                    var return_v = this_param.AddOrUpdate(key, addValue: addValue, updateValueFactory: updateValueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 18857, 18961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 18728, 18973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 18728, 18973);
            }
        }

        public HostSessionStartAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 17214, 18980);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 17347, 17412);
            this._concurrentAnalyzers = ImmutableHashSet<DiagnosticAnalyzer>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 17509, 17616);
            this._generatedCodeConfigurationMap = f_263_17542_17616(); DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 17214, 18980);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 17214, 18980);
        }


        static HostSessionStartAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 17214, 18980);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 17214, 18980);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 17214, 18980);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 17214, 18980);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
        f_263_17542_17616()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 17542, 17616);
            return return_v;
        }

    }
    internal sealed class HostCompilationStartAnalysisScope : HostAnalysisScope
    {
        private readonly HostSessionStartAnalysisScope _sessionScope;

        public HostCompilationStartAnalysisScope(HostSessionStartAnalysisScope sessionScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 19286, 19435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19260, 19273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19395, 19424);

                _sessionScope = sessionScope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 19286, 19435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 19286, 19435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 19286, 19435);
            }
        }

        public override AnalyzerActions GetAnalyzerActions(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 19447, 20025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19551, 19622);

                AnalyzerActions
                compilationActions = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAnalyzerActions(analyzer), 263, 19588, 19621)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19636, 19712);

                AnalyzerActions
                sessionActions = f_263_19669_19711(_sessionScope, analyzer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19728, 19829) || true) && (sessionActions.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(263, 19728, 19829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19788, 19814);

                    return compilationActions;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(263, 19728, 19829);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19845, 19946) || true) && (compilationActions.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(263, 19845, 19946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19909, 19931);

                    return sessionActions;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(263, 19845, 19946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 19962, 20014);

                return compilationActions.Append(in sessionActions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 19447, 20025);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_263_19669_19711(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 19669, 19711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 19447, 20025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 19447, 20025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static HostCompilationStartAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 19121, 20032);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 19121, 20032);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 19121, 20032);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 19121, 20032);
    }
    internal sealed class HostSymbolStartAnalysisScope : HostAnalysisScope
    {
        public HostSymbolStartAnalysisScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 20246, 20305);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 20246, 20305);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 20246, 20305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 20246, 20305);
            }
        }

        static HostSymbolStartAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 20159, 20312);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 20159, 20312);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 20159, 20312);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 20159, 20312);
    }
    internal sealed class HostCodeBlockStartAnalysisScope<TLanguageKindEnum> where TLanguageKindEnum : struct
    {
        private ImmutableArray<CodeBlockAnalyzerAction> _codeBlockEndActions;

        private ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>> _syntaxNodeActions;

        public ImmutableArray<CodeBlockAnalyzerAction> CodeBlockEndActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 20959, 20995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 20965, 20993);

                    return _codeBlockEndActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 20959, 20995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 20868, 21006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 20868, 21006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>> SyntaxNodeActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 21127, 21161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 21133, 21159);

                    return _syntaxNodeActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 21127, 21161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 21018, 21172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 21018, 21172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal HostCodeBlockStartAnalysisScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 21184, 21248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 20622, 20690);
                this._codeBlockEndActions = ImmutableArray<CodeBlockAnalyzerAction>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 20769, 20855);
                this._syntaxNodeActions = ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>.Empty; DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 21184, 21248);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 21184, 21248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 21184, 21248);
            }
        }

        public void RegisterCodeBlockEndAction(DiagnosticAnalyzer analyzer, Action<CodeBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 21260, 21499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 21393, 21488);

                _codeBlockEndActions = _codeBlockEndActions.Add(f_263_21441_21486(action, analyzer));
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 21260, 21499);

                Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction
                f_263_21441_21486(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 21441, 21486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 21260, 21499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 21260, 21499);
            }
        }

        public void RegisterSyntaxNodeAction(DiagnosticAnalyzer analyzer, Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds)
        {
            _syntaxNodeActions = _syntaxNodeActions.Add(new SyntaxNodeAnalyzerAction<TLanguageKindEnum>(action, syntaxKinds, analyzer));
        }

        static HostCodeBlockStartAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 20452, 21832);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 20452, 21832);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 20452, 21832);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 20452, 21832);
    }
    internal sealed class HostOperationBlockStartAnalysisScope
    {
        private ImmutableArray<OperationBlockAnalyzerAction> _operationBlockEndActions;

        private ImmutableArray<OperationAnalyzerAction> _operationActions;

        public ImmutableArray<OperationBlockAnalyzerAction> OperationBlockEndActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 22260, 22288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 22263, 22288);
                    return _operationBlockEndActions; DynAbs.Tracing.TraceSender.TraceExitMethod(263, 22260, 22288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 22260, 22288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 22260, 22288);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<OperationAnalyzerAction> OperationActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 22365, 22385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 22368, 22385);
                    return _operationActions; DynAbs.Tracing.TraceSender.TraceExitMethod(263, 22365, 22385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 22365, 22385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 22365, 22385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal HostOperationBlockStartAnalysisScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 22398, 22467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 21968, 22046);
                this._operationBlockEndActions = ImmutableArray<OperationBlockAnalyzerAction>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 22105, 22170);
                this._operationActions = ImmutableArray<OperationAnalyzerAction>.Empty; DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 22398, 22467);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 22398, 22467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 22398, 22467);
            }
        }

        public void RegisterOperationBlockEndAction(DiagnosticAnalyzer analyzer, Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 22479, 22743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 22622, 22732);

                _operationBlockEndActions = _operationBlockEndActions.Add(f_263_22680_22730(action, analyzer));
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 22479, 22743);

                Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction
                f_263_22680_22730(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 22680, 22730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 22479, 22743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 22479, 22743);
            }
        }

        public void RegisterOperationAction(DiagnosticAnalyzer analyzer, Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 22755, 23047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 22931, 23036);

                _operationActions = _operationActions.Add(f_263_22973_23034(action, operationKinds, analyzer));
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 22755, 23047);

                Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                f_263_22973_23034(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                kinds, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction(action, kinds, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 22973, 23034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 22755, 23047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 22755, 23047);
            }
        }

        static HostOperationBlockStartAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 21840, 23054);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 21840, 23054);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 21840, 23054);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 21840, 23054);
    }
    internal abstract class HostAnalysisScope
    {
        private readonly ConcurrentDictionary<DiagnosticAnalyzer, StrongBox<AnalyzerActions>> _analyzerActions;

        public virtual AnalyzerActions GetAnalyzerActions(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 23312, 23481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 23415, 23470);

                return f_263_23422_23463(this, analyzer).Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 23312, 23481);

                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_23422_23463(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 23422, 23463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 23312, 23481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 23312, 23481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void RegisterCompilationAction(DiagnosticAnalyzer analyzer, Action<CompilationAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 23493, 23828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 23627, 23718);

                CompilationAnalyzerAction
                analyzerAction = f_263_23670_23717(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 23732, 23817);

                f_263_23732_23773(this, analyzer).Value.AddCompilationAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 23493, 23828);

                Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction
                f_263_23670_23717(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 23670, 23717);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_23732_23773(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 23732, 23773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 23493, 23828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 23493, 23828);
            }
        }

        public void RegisterCompilationEndAction(DiagnosticAnalyzer analyzer, Action<CompilationAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 23840, 24181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 23977, 24068);

                CompilationAnalyzerAction
                analyzerAction = f_263_24020_24067(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 24082, 24170);

                f_263_24082_24123(this, analyzer).Value.AddCompilationEndAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 23840, 24181);

                Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction
                f_263_24020_24067(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 24020, 24067);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_24082_24123(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 24082, 24123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 23840, 24181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 23840, 24181);
            }
        }

        public void RegisterSemanticModelAction(DiagnosticAnalyzer analyzer, Action<SemanticModelAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 24193, 24538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 24331, 24426);

                SemanticModelAnalyzerAction
                analyzerAction = f_263_24376_24425(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 24440, 24527);

                f_263_24440_24481(this, analyzer).Value.AddSemanticModelAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 24193, 24538);

                Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction
                f_263_24376_24425(System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 24376, 24425);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_24440_24481(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 24440, 24481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 24193, 24538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 24193, 24538);
            }
        }

        public void RegisterSyntaxTreeAction(DiagnosticAnalyzer analyzer, Action<SyntaxTreeAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 24550, 24880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 24682, 24771);

                SyntaxTreeAnalyzerAction
                analyzerAction = f_263_24724_24770(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 24785, 24869);

                f_263_24785_24826(this, analyzer).Value.AddSyntaxTreeAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 24550, 24880);

                Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction
                f_263_24724_24770(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 24724, 24770);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_24785_24826(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 24785, 24826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 24550, 24880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 24550, 24880);
            }
        }

        public void RegisterAdditionalFileAction(DiagnosticAnalyzer analyzer, Action<AdditionalFileAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 24892, 25217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 25032, 25104);

                var
                analyzerAction = f_263_25053_25103(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 25118, 25206);

                f_263_25118_25159(this, analyzer).Value.AddAdditionalFileAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 24892, 25217);

                Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction
                f_263_25053_25103(System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 25053, 25103);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_25118_25159(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 25118, 25159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 24892, 25217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 24892, 25217);
            }
        }

        public void RegisterSymbolAction(DiagnosticAnalyzer analyzer, Action<SymbolAnalysisContext> action, ImmutableArray<SymbolKind> symbolKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 25229, 28075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 25393, 25487);

                SymbolAnalyzerAction
                analyzerAction = f_263_25431_25486(action, symbolKinds, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 25501, 25581);

                f_263_25501_25542(this, analyzer).Value.AddSymbolAction(analyzerAction);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 25953, 28064) || true) && (symbolKinds.Contains(SymbolKind.Parameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(263, 25953, 28064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 26033, 28049);

                    f_263_26033_28048(this, analyzer, context =>
                                        {
                                            ImmutableArray<IParameterSymbol> parameters;

                                            switch (context.Symbol.Kind)
                                            {
                                                case SymbolKind.Method:
                                                    parameters = ((IMethodSymbol)context.Symbol).Parameters;
                                                    break;
                                                case SymbolKind.Property:
                                                    parameters = ((IPropertySymbol)context.Symbol).Parameters;
                                                    break;
                                                case SymbolKind.NamedType:
                                                    var namedType = (INamedTypeSymbol)context.Symbol;
                                                    var delegateInvokeMethod = namedType.DelegateInvokeMethod;
                                                    parameters = delegateInvokeMethod?.Parameters ?? ImmutableArray.Create<IParameterSymbol>();
                                                    break;
                                                default:
                                                    throw new ArgumentException($"{context.Symbol.Kind} is not supported.", nameof(context));
                                            }

                                            foreach (var parameter in parameters)
                                            {
                                                if (!parameter.IsImplicitlyDeclared)
                                                {
                                                    action(new SymbolAnalysisContext(
                                                        parameter,
                                                        context.Compilation,
                                                        context.Options,
                                                        context.ReportDiagnostic,
                                                        context.IsSupportedDiagnostic,
                                                        context.CancellationToken));
                                                }
                                            }
                                        }, f_263_27964_28047(SymbolKind.Method, SymbolKind.Property, SymbolKind.NamedType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(263, 25953, 28064);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 25229, 28075);

                Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                f_263_25431_25486(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                kinds, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction(action, kinds, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 25431, 25486);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_25501_25542(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 25501, 25542);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                f_263_27964_28047(Microsoft.CodeAnalysis.SymbolKind
                item1, Microsoft.CodeAnalysis.SymbolKind
                item2, Microsoft.CodeAnalysis.SymbolKind
                item3)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 27964, 28047);
                    return return_v;
                }


                int
                f_263_26033_28048(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    this_param.RegisterSymbolAction(analyzer, action, symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 26033, 28048);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 25229, 28075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 25229, 28075);
            }
        }

        public void RegisterSymbolStartAction(DiagnosticAnalyzer analyzer, Action<SymbolStartAnalysisContext> action, SymbolKind symbolKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 28087, 28435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 28244, 28325);

                var
                analyzerAction = f_263_28265_28324(action, symbolKind, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 28339, 28424);

                f_263_28339_28380(this, analyzer).Value.AddSymbolStartAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 28087, 28435);

                Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                f_263_28265_28324(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                action, Microsoft.CodeAnalysis.SymbolKind
                kind, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction(action, kind, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 28265, 28324);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_28339_28380(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 28339, 28380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 28087, 28435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 28087, 28435);
            }
        }

        public void RegisterSymbolEndAction(DiagnosticAnalyzer analyzer, Action<SymbolAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 28447, 28749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 28574, 28641);

                var
                analyzerAction = f_263_28595_28640(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 28655, 28738);

                f_263_28655_28696(this, analyzer).Value.AddSymbolEndAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 28447, 28749);

                Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction
                f_263_28595_28640(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 28595, 28640);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_28655_28696(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 28655, 28696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 28447, 28749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 28447, 28749);
            }
        }

        public void RegisterCodeBlockStartAction<TLanguageKindEnum>(DiagnosticAnalyzer analyzer, Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 28761, 29220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 28972, 29107);

                CodeBlockStartAnalyzerAction<TLanguageKindEnum>
                analyzerAction = f_263_29037_29106(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 29121, 29209);

                f_263_29121_29162(this, analyzer).Value.AddCodeBlockStartAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 28761, 29220);

                Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>
                f_263_29037_29106(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 29037, 29106);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_29121_29162(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 29121, 29162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 28761, 29220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 28761, 29220);
            }
        }

        public void RegisterCodeBlockEndAction(DiagnosticAnalyzer analyzer, Action<CodeBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 29232, 29563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 29365, 29452);

                CodeBlockAnalyzerAction
                analyzerAction = f_263_29406_29451(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 29466, 29552);

                f_263_29466_29507(this, analyzer).Value.AddCodeBlockEndAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 29232, 29563);

                Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction
                f_263_29406_29451(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 29406, 29451);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_29466_29507(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 29466, 29507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 29232, 29563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 29232, 29563);
            }
        }

        public void RegisterCodeBlockAction(DiagnosticAnalyzer analyzer, Action<CodeBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 29575, 29900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 29705, 29792);

                CodeBlockAnalyzerAction
                analyzerAction = f_263_29746_29791(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 29806, 29889);

                f_263_29806_29847(this, analyzer).Value.AddCodeBlockAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 29575, 29900);

                Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction
                f_263_29746_29791(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 29746, 29791);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_29806_29847(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 29806, 29847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 29575, 29900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 29575, 29900);
            }
        }

        public void RegisterSyntaxNodeAction<TLanguageKindEnum>(DiagnosticAnalyzer analyzer, Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 29912, 30392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 30143, 30283);

                SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                analyzerAction = f_263_30204_30282(action, syntaxKinds, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 30297, 30381);

                f_263_30297_30338(this, analyzer).Value.AddSyntaxNodeAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 29912, 30392);

                Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                f_263_30204_30282(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                kinds, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>(action, kinds, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 30204, 30282);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_30297_30338(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 30297, 30338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 29912, 30392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 29912, 30392);
            }
        }

        public void RegisterOperationBlockStartAction(DiagnosticAnalyzer analyzer, Action<OperationBlockStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 30404, 30779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 30554, 30661);

                OperationBlockStartAnalyzerAction
                analyzerAction = f_263_30605_30660(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 30675, 30768);

                f_263_30675_30716(this, analyzer).Value.AddOperationBlockStartAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 30404, 30779);

                Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction
                f_263_30605_30660(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 30605, 30660);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_30675_30716(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 30675, 30716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 30404, 30779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 30404, 30779);
            }
        }

        public void RegisterOperationBlockEndAction(DiagnosticAnalyzer analyzer, Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 30791, 31147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 30934, 31031);

                OperationBlockAnalyzerAction
                analyzerAction = f_263_30980_31030(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 31045, 31136);

                f_263_31045_31086(this, analyzer).Value.AddOperationBlockEndAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 30791, 31147);

                Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction
                f_263_30980_31030(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 30980, 31030);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_31045_31086(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 31045, 31086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 30791, 31147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 30791, 31147);
            }
        }

        public void RegisterOperationBlockAction(DiagnosticAnalyzer analyzer, Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 31159, 31509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 31299, 31396);

                OperationBlockAnalyzerAction
                analyzerAction = f_263_31345_31395(action, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 31410, 31498);

                f_263_31410_31451(this, analyzer).Value.AddOperationBlockAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 31159, 31509);

                Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction
                f_263_31345_31395(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                action, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction(action, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 31345, 31395);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_31410_31451(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 31410, 31451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 31159, 31509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 31159, 31509);
            }
        }

        public void RegisterOperationAction(DiagnosticAnalyzer analyzer, Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 31521, 31908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 31697, 31800);

                OperationAnalyzerAction
                analyzerAction = f_263_31738_31799(action, operationKinds, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 31814, 31897);

                f_263_31814_31855(this, analyzer).Value.AddOperationAction(analyzerAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 31521, 31908);

                Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                f_263_31738_31799(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                kinds, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction(action, kinds, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 31738, 31799);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_31814_31855(Microsoft.CodeAnalysis.Diagnostics.HostAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetOrCreateAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 31814, 31855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 31521, 31908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 31521, 31908);
            }
        }

        protected StrongBox<AnalyzerActions> GetOrCreateAnalyzerActions(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 31920, 32151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 32037, 32140);

                return f_263_32044_32139(_analyzerActions, analyzer, _ => new StrongBox<AnalyzerActions>(AnalyzerActions.Empty));
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 31920, 32151);

                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_263_32044_32139(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 32044, 32139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 31920, 32151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 31920, 32151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public HostAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 23062, 32158);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 23206, 23299);
            this._analyzerActions = f_263_23225_23299(); DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 23062, 32158);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 23062, 32158);
        }


        static HostAnalysisScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 23062, 32158);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 23062, 32158);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 23062, 32158);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(263, 23062, 32158);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>>
        f_263_23225_23299()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 23225, 23299);
            return return_v;
        }

    }

    internal struct AnalyzerActions
    {

        public static readonly AnalyzerActions Empty;

        private ImmutableArray<CompilationStartAnalyzerAction> _compilationStartActions;

        private ImmutableArray<CompilationAnalyzerAction> _compilationEndActions;

        private ImmutableArray<CompilationAnalyzerAction> _compilationActions;

        private ImmutableArray<SyntaxTreeAnalyzerAction> _syntaxTreeActions;

        private ImmutableArray<AdditionalFileAnalyzerAction> _additionalFileActions;

        private ImmutableArray<SemanticModelAnalyzerAction> _semanticModelActions;

        private ImmutableArray<SymbolAnalyzerAction> _symbolActions;

        private ImmutableArray<SymbolStartAnalyzerAction> _symbolStartActions;

        private ImmutableArray<SymbolEndAnalyzerAction> _symbolEndActions;

        private ImmutableArray<AnalyzerAction> _codeBlockStartActions;

        private ImmutableArray<CodeBlockAnalyzerAction> _codeBlockEndActions;

        private ImmutableArray<CodeBlockAnalyzerAction> _codeBlockActions;

        private ImmutableArray<OperationBlockStartAnalyzerAction> _operationBlockStartActions;

        private ImmutableArray<OperationBlockAnalyzerAction> _operationBlockEndActions;

        private ImmutableArray<OperationBlockAnalyzerAction> _operationBlockActions;

        private ImmutableArray<AnalyzerAction> _syntaxNodeActions;

        private ImmutableArray<OperationAnalyzerAction> _operationActions;

        private bool _concurrent;

        internal AnalyzerActions(bool concurrent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 34291, 35861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34357, 34437);

                _compilationStartActions = ImmutableArray<CompilationStartAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34451, 34524);

                _compilationEndActions = ImmutableArray<CompilationAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34538, 34608);

                _compilationActions = ImmutableArray<CompilationAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34622, 34690);

                _syntaxTreeActions = ImmutableArray<SyntaxTreeAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34704, 34780);

                _additionalFileActions = ImmutableArray<AdditionalFileAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34794, 34868);

                _semanticModelActions = ImmutableArray<SemanticModelAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34882, 34942);

                _symbolActions = ImmutableArray<SymbolAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 34956, 35026);

                _symbolStartActions = ImmutableArray<SymbolStartAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35040, 35106);

                _symbolEndActions = ImmutableArray<SymbolEndAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35120, 35182);

                _codeBlockStartActions = ImmutableArray<AnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35196, 35265);

                _codeBlockEndActions = ImmutableArray<CodeBlockAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35279, 35345);

                _codeBlockActions = ImmutableArray<CodeBlockAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35359, 35445);

                _operationBlockStartActions = ImmutableArray<OperationBlockStartAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35459, 35538);

                _operationBlockEndActions = ImmutableArray<OperationBlockAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35552, 35628);

                _operationBlockActions = ImmutableArray<OperationBlockAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35642, 35700);

                _syntaxNodeActions = ImmutableArray<AnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35714, 35780);

                _operationActions = ImmutableArray<OperationAnalyzerAction>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35794, 35819);

                _concurrent = concurrent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 35835, 35850);

                IsEmpty = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 34291, 35861);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 34291, 35861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 34291, 35861);
            }
        }

        public AnalyzerActions(
                    ImmutableArray<CompilationStartAnalyzerAction> compilationStartActions,
                    ImmutableArray<CompilationAnalyzerAction> compilationEndActions,
                    ImmutableArray<CompilationAnalyzerAction> compilationActions,
                    ImmutableArray<SyntaxTreeAnalyzerAction> syntaxTreeActions,
                    ImmutableArray<AdditionalFileAnalyzerAction> additionalFileActions,
                    ImmutableArray<SemanticModelAnalyzerAction> semanticModelActions,
                    ImmutableArray<SymbolAnalyzerAction> symbolActions,
                    ImmutableArray<SymbolStartAnalyzerAction> symbolStartActions,
                    ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions,
                    ImmutableArray<AnalyzerAction> codeBlockStartActions,
                    ImmutableArray<CodeBlockAnalyzerAction> codeBlockEndActions,
                    ImmutableArray<CodeBlockAnalyzerAction> codeBlockActions,
                    ImmutableArray<OperationBlockStartAnalyzerAction> operationBlockStartActions,
                    ImmutableArray<OperationBlockAnalyzerAction> operationBlockEndActions,
                    ImmutableArray<OperationBlockAnalyzerAction> operationBlockActions,
                    ImmutableArray<AnalyzerAction> syntaxNodeActions,
                    ImmutableArray<OperationAnalyzerAction> operationActions,
                    bool concurrent,
                    bool isEmpty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(263, 35873, 38307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37262, 37313);

                _compilationStartActions = compilationStartActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37327, 37374);

                _compilationEndActions = compilationEndActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37388, 37429);

                _compilationActions = compilationActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37443, 37482);

                _syntaxTreeActions = syntaxTreeActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37496, 37543);

                _additionalFileActions = additionalFileActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37557, 37602);

                _semanticModelActions = semanticModelActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37616, 37647);

                _symbolActions = symbolActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37661, 37702);

                _symbolStartActions = symbolStartActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37716, 37753);

                _symbolEndActions = symbolEndActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37767, 37814);

                _codeBlockStartActions = codeBlockStartActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37828, 37871);

                _codeBlockEndActions = codeBlockEndActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37885, 37922);

                _codeBlockActions = codeBlockActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 37936, 37993);

                _operationBlockStartActions = operationBlockStartActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38007, 38060);

                _operationBlockEndActions = operationBlockEndActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38074, 38121);

                _operationBlockActions = operationBlockActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38135, 38174);

                _syntaxNodeActions = syntaxNodeActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38188, 38225);

                _operationActions = operationActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38239, 38264);

                _concurrent = concurrent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38278, 38296);

                IsEmpty = isEmpty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(263, 35873, 38307);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 35873, 38307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 35873, 38307);
            }
        }

        public readonly int CompilationStartActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 38370, 38417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38376, 38415);

                    return _compilationStartActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 38370, 38417);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 38319, 38419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 38319, 38419);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int CompilationEndActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 38478, 38523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38484, 38521);

                    return _compilationEndActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 38478, 38523);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 38429, 38525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 38429, 38525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int CompilationActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 38581, 38623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38587, 38621);

                    return _compilationActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 38581, 38623);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 38535, 38625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 38535, 38625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int SyntaxTreeActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 38680, 38721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38686, 38719);

                    return _syntaxTreeActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 38680, 38721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 38635, 38723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 38635, 38723);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int AdditionalFileActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 38782, 38827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38788, 38825);

                    return _additionalFileActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 38782, 38827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 38733, 38829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 38733, 38829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int SemanticModelActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 38887, 38931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38893, 38929);

                    return _semanticModelActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 38887, 38931);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 38839, 38933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 38839, 38933);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int SymbolActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 38984, 39021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 38990, 39019);

                    return _symbolActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 38984, 39021);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 38943, 39023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 38943, 39023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int SymbolStartActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39079, 39121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39085, 39119);

                    return _symbolStartActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39079, 39121);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39033, 39123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39033, 39123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int SymbolEndActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39177, 39217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39183, 39215);

                    return _symbolEndActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39177, 39217);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39133, 39219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39133, 39219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int SyntaxNodeActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39274, 39315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39280, 39313);

                    return _syntaxNodeActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39274, 39315);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39229, 39317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39229, 39317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int OperationActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39371, 39411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39377, 39409);

                    return _operationActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39371, 39411);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39327, 39413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39327, 39413);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int OperationBlockStartActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39477, 39527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39483, 39525);

                    return _operationBlockStartActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39477, 39527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39423, 39529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39423, 39529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int OperationBlockEndActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39591, 39639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39597, 39637);

                    return _operationBlockEndActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39591, 39639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39539, 39641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39539, 39641);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int OperationBlockActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39700, 39745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39706, 39743);

                    return _operationBlockActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39700, 39745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39651, 39747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39651, 39747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int CodeBlockStartActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39806, 39851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39812, 39849);

                    return _codeBlockStartActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39806, 39851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39757, 39853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39757, 39853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int CodeBlockEndActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 39910, 39953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 39916, 39951);

                    return _codeBlockEndActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 39910, 39953);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39863, 39955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39863, 39955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int CodeBlockActionsCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 40009, 40049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 40015, 40047);

                    return _codeBlockActions.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 40009, 40049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 39965, 40051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 39965, 40051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly bool Concurrent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 40093, 40107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 40096, 40107);
                    return _concurrent; DynAbs.Tracing.TraceSender.TraceExitMethod(263, 40093, 40107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 40093, 40107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 40093, 40107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsEmpty { readonly get; private set; }

        public readonly bool IsDefault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 40209, 40246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 40212, 40246);
                    return _compilationStartActions.IsDefault; DynAbs.Tracing.TraceSender.TraceExitMethod(263, 40209, 40246);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 40209, 40246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 40209, 40246);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<CompilationStartAnalyzerAction> CompilationStartActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 40372, 40412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 40378, 40410);

                    return _compilationStartActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 40372, 40412);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 40259, 40423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 40259, 40423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<CompilationAnalyzerAction> CompilationEndActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 40541, 40579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 40547, 40577);

                    return _compilationEndActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 40541, 40579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 40435, 40590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 40435, 40590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<CompilationAnalyzerAction> CompilationActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 40705, 40740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 40711, 40738);

                    return _compilationActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 40705, 40740);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 40602, 40751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 40602, 40751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<SyntaxTreeAnalyzerAction> SyntaxTreeActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 40864, 40898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 40870, 40896);

                    return _syntaxTreeActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 40864, 40898);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 40763, 40909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 40763, 40909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<AdditionalFileAnalyzerAction> AdditionalFileActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 41030, 41068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 41036, 41066);

                    return _additionalFileActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 41030, 41068);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 40921, 41079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 40921, 41079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<SemanticModelAnalyzerAction> SemanticModelActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 41198, 41235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 41204, 41233);

                    return _semanticModelActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 41198, 41235);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 41091, 41246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 41091, 41246);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<SymbolAnalyzerAction> SymbolActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 41351, 41381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 41357, 41379);

                    return _symbolActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 41351, 41381);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 41258, 41392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 41258, 41392);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<SymbolStartAnalyzerAction> SymbolStartActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 41507, 41542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 41513, 41540);

                    return _symbolStartActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 41507, 41542);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 41404, 41553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 41404, 41553);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<SymbolEndAnalyzerAction> SymbolEndActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 41664, 41697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 41670, 41695);

                    return _symbolEndActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 41664, 41697);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 41565, 41708);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 41565, 41708);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<CodeBlockAnalyzerAction> CodeBlockEndActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 41822, 41858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 41828, 41856);

                    return _codeBlockEndActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 41822, 41858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 41720, 41869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 41720, 41869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<CodeBlockAnalyzerAction> CodeBlockActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 41980, 42013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 41986, 42011);

                    return _codeBlockActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 41980, 42013);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 41881, 42024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 41881, 42024);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<CodeBlockStartAnalyzerAction<TLanguageKindEnum>> GetCodeBlockStartActions<TLanguageKindEnum>() where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 42036, 42339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 42221, 42328);

                return f_263_42228_42327(_codeBlockStartActions.OfType<CodeBlockStartAnalyzerAction<TLanguageKindEnum>>());
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 42036, 42339);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                f_263_42228_42327(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 42228, 42327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 42036, 42339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 42036, 42339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal readonly ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>> GetSyntaxNodeActions<TLanguageKindEnum>() where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 42351, 42638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 42528, 42627);

                return f_263_42535_42626(_syntaxNodeActions.OfType<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>());
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 42351, 42638);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                f_263_42535_42626(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 42535, 42626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 42351, 42638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 42351, 42638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal readonly ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>> GetSyntaxNodeActions<TLanguageKindEnum>(DiagnosticAnalyzer analyzer) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 42650, 43324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 42854, 42940);

                var
                builder = f_263_42868_42939()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 42954, 43261);
                    foreach (var action in f_263_42977_42995_I(_syntaxNodeActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(263, 42954, 43261);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 43029, 43246) || true) && (f_263_43033_43048(action) == analyzer && (DynAbs.Tracing.TraceSender.Expression_True(263, 43033, 43155) && action is SyntaxNodeAnalyzerAction<TLanguageKindEnum> syntaxNodeAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(263, 43029, 43246);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 43197, 43227);

                            f_263_43197_43226(builder, syntaxNodeAction);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(263, 43029, 43246);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(263, 42954, 43261);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(263, 1, 308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(263, 1, 308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 43277, 43313);

                return f_263_43284_43312(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 42650, 43324);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                f_263_42868_42939()
                {
                    var return_v = ArrayBuilder<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 42868, 42939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_263_43033_43048(Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(263, 43033, 43048);
                    return return_v;
                }


                int
                f_263_43197_43226(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 43197, 43226);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_263_42977_42995_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 42977, 42995);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                f_263_43284_43312(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 43284, 43312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 42650, 43324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 42650, 43324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal readonly ImmutableArray<OperationBlockAnalyzerAction> OperationBlockActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 43445, 43483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 43451, 43481);

                    return _operationBlockActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 43445, 43483);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 43336, 43494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 43336, 43494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<OperationBlockAnalyzerAction> OperationBlockEndActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 43618, 43659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 43624, 43657);

                    return _operationBlockEndActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 43618, 43659);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 43506, 43670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 43506, 43670);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<OperationBlockStartAnalyzerAction> OperationBlockStartActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 43801, 43844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 43807, 43842);

                    return _operationBlockStartActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 43801, 43844);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 43682, 43855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 43682, 43855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly ImmutableArray<OperationAnalyzerAction> OperationActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 43966, 43999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 43972, 43997);

                    return _operationActions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(263, 43966, 43999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 43867, 44010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 43867, 44010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AddCompilationStartAction(CompilationStartAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 44022, 44230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44125, 44189);

                _compilationStartActions = _compilationStartActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44203, 44219);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 44022, 44230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 44022, 44230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 44022, 44230);
            }
        }

        internal void AddCompilationEndAction(CompilationAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 44242, 44439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44338, 44398);

                _compilationEndActions = _compilationEndActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44412, 44428);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 44242, 44439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 44242, 44439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 44242, 44439);
            }
        }

        internal void AddCompilationAction(CompilationAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 44451, 44639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44544, 44598);

                _compilationActions = _compilationActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44612, 44628);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 44451, 44639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 44451, 44639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 44451, 44639);
            }
        }

        internal void AddSyntaxTreeAction(SyntaxTreeAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 44651, 44835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44742, 44794);

                _syntaxTreeActions = _syntaxTreeActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44808, 44824);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 44651, 44835);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 44651, 44835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 44651, 44835);
            }
        }

        internal void AddAdditionalFileAction(AdditionalFileAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 44847, 45047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 44946, 45006);

                _additionalFileActions = _additionalFileActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45020, 45036);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 44847, 45047);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 44847, 45047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 44847, 45047);
            }
        }

        internal void AddSemanticModelAction(SemanticModelAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 45059, 45255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45156, 45214);

                _semanticModelActions = _semanticModelActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45228, 45244);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 45059, 45255);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 45059, 45255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 45059, 45255);
            }
        }

        internal void AddSymbolAction(SymbolAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 45267, 45435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45350, 45394);

                _symbolActions = _symbolActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45408, 45424);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 45267, 45435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 45267, 45435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 45267, 45435);
            }
        }

        internal void AddSymbolStartAction(SymbolStartAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 45447, 45635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45540, 45594);

                _symbolStartActions = _symbolStartActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45608, 45624);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 45447, 45635);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 45447, 45635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 45447, 45635);
            }
        }

        internal void AddSymbolEndAction(SymbolEndAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 45647, 45827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45736, 45786);

                _symbolEndActions = _symbolEndActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 45800, 45816);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 45647, 45827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 45647, 45827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 45647, 45827);
            }
        }

        internal void AddCodeBlockStartAction<TLanguageKindEnum>(CodeBlockStartAnalyzerAction<TLanguageKindEnum> action) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 45839, 46110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46009, 46069);

                _codeBlockStartActions = _codeBlockStartActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46083, 46099);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 45839, 46110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 45839, 46110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 45839, 46110);
            }
        }

        internal void AddCodeBlockEndAction(CodeBlockAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 46122, 46311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46214, 46270);

                _codeBlockEndActions = _codeBlockEndActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46284, 46300);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 46122, 46311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 46122, 46311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 46122, 46311);
            }
        }

        internal void AddCodeBlockAction(CodeBlockAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 46323, 46503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46412, 46462);

                _codeBlockActions = _codeBlockActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46476, 46492);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 46323, 46503);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 46323, 46503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 46323, 46503);
            }
        }

        internal void AddSyntaxNodeAction<TLanguageKindEnum>(SyntaxNodeAnalyzerAction<TLanguageKindEnum> action) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 46515, 46770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46677, 46729);

                _syntaxNodeActions = _syntaxNodeActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46743, 46759);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 46515, 46770);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 46515, 46770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 46515, 46770);
            }
        }

        internal void AddOperationBlockStartAction(OperationBlockStartAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 46782, 47002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46891, 46961);

                _operationBlockStartActions = _operationBlockStartActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 46975, 46991);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 46782, 47002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 46782, 47002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 46782, 47002);
            }
        }

        internal void AddOperationBlockAction(OperationBlockAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 47014, 47214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 47113, 47173);

                _operationBlockActions = _operationBlockActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 47187, 47203);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 47014, 47214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 47014, 47214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 47014, 47214);
            }
        }

        internal void AddOperationBlockEndAction(OperationBlockAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 47226, 47435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 47328, 47394);

                _operationBlockEndActions = _operationBlockEndActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 47408, 47424);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 47226, 47435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 47226, 47435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 47226, 47435);
            }
        }

        internal void AddOperationAction(OperationAnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 47447, 47627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 47536, 47586);

                _operationActions = _operationActions.Add(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 47600, 47616);

                IsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 47447, 47627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 47447, 47627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 47447, 47627);
            }
        }

        internal void EnableConcurrentExecution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 47639, 47735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 47705, 47724);

                _concurrent = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 47639, 47735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 47639, 47735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 47639, 47735);
            }
        }

        public readonly AnalyzerActions Append(in AnalyzerActions otherActions, bool appendSymbolStartAndSymbolEndActions = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(263, 47975, 50472);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48121, 48250) || true) && (otherActions.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(263, 48121, 48250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48181, 48235);

                    throw f_263_48187_48234(nameof(otherActions));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(263, 48121, 48250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48266, 48364);

                AnalyzerActions
                actions = f_263_48292_48363(concurrent: _concurrent || (DynAbs.Tracing.TraceSender.Expression_False(263, 48324, 48362) || otherActions.Concurrent))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48378, 48486);

                actions._compilationStartActions = _compilationStartActions.AddRange(otherActions._compilationStartActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48500, 48602);

                actions._compilationEndActions = _compilationEndActions.AddRange(otherActions._compilationEndActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48616, 48709);

                actions._compilationActions = _compilationActions.AddRange(otherActions._compilationActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48723, 48813);

                actions._syntaxTreeActions = _syntaxTreeActions.AddRange(otherActions._syntaxTreeActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48827, 48929);

                actions._additionalFileActions = _additionalFileActions.AddRange(otherActions._additionalFileActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 48943, 49042);

                actions._semanticModelActions = _semanticModelActions.AddRange(otherActions._semanticModelActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49056, 49134);

                actions._symbolActions = _symbolActions.AddRange(otherActions._symbolActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49148, 49302);

                actions._symbolStartActions = (DynAbs.Tracing.TraceSender.Conditional_F1(263, 49178, 49214) || ((appendSymbolStartAndSymbolEndActions && DynAbs.Tracing.TraceSender.Conditional_F2(263, 49217, 49279)) || DynAbs.Tracing.TraceSender.Conditional_F3(263, 49282, 49301))) ? _symbolStartActions.AddRange(otherActions._symbolStartActions) : _symbolStartActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49316, 49462);

                actions._symbolEndActions = (DynAbs.Tracing.TraceSender.Conditional_F1(263, 49344, 49380) || ((appendSymbolStartAndSymbolEndActions && DynAbs.Tracing.TraceSender.Conditional_F2(263, 49383, 49441)) || DynAbs.Tracing.TraceSender.Conditional_F3(263, 49444, 49461))) ? _symbolEndActions.AddRange(otherActions._symbolEndActions) : _symbolEndActions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49476, 49578);

                actions._codeBlockStartActions = _codeBlockStartActions.AddRange(otherActions._codeBlockStartActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49592, 49688);

                actions._codeBlockEndActions = _codeBlockEndActions.AddRange(otherActions._codeBlockEndActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49702, 49789);

                actions._codeBlockActions = _codeBlockActions.AddRange(otherActions._codeBlockActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49803, 49893);

                actions._syntaxNodeActions = _syntaxNodeActions.AddRange(otherActions._syntaxNodeActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 49907, 49994);

                actions._operationActions = _operationActions.AddRange(otherActions._operationActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 50008, 50125);

                actions._operationBlockStartActions = _operationBlockStartActions.AddRange(otherActions._operationBlockStartActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 50139, 50250);

                actions._operationBlockEndActions = _operationBlockEndActions.AddRange(otherActions._operationBlockEndActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 50264, 50366);

                actions._operationBlockActions = _operationBlockActions.AddRange(otherActions._operationBlockActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 50380, 50430);

                actions.IsEmpty = IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(263, 50398, 50429) && otherActions.IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 50446, 50461);

                return actions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(263, 47975, 50472);

                System.ArgumentNullException
                f_263_48187_48234(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 48187, 48234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_263_48292_48363(bool
                concurrent)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions(concurrent: concurrent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 48292, 48363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(263, 47975, 50472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 47975, 50472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AnalyzerActions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(263, 32739, 50479);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(263, 32826, 32872);
            Empty = f_263_32834_32872(concurrent: false); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(263, 32739, 50479);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(263, 32739, 50479);
        }

        static Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
        f_263_32834_32872(bool
        concurrent)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions(concurrent: concurrent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(263, 32834, 32872);
            return return_v;
        }

    }
}
