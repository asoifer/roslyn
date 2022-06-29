// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract class AnalyzerAction
    {
        internal DiagnosticAnalyzer Analyzer { get; }

        internal AnalyzerAction(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 469, 577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 412, 457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 546, 566);

                Analyzer = analyzer;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 469, 577);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 469, 577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 469, 577);
            }
        }

        static AnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 357, 584);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 357, 584);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 357, 584);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 357, 584);
    }
    internal sealed class SymbolAnalyzerAction : AnalyzerAction
    {
        public Action<SymbolAnalysisContext> Action { get; }

        public ImmutableArray<SymbolKind> Kinds { get; }

        public SymbolAnalyzerAction(Action<SymbolAnalysisContext> action, ImmutableArray<SymbolKind> kinds, DiagnosticAnalyzer analyzer)
        : base(f_259_939_947_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 790, 1028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 668, 720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 973, 989);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1003, 1017);

                Kinds = kinds;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 790, 1028);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 790, 1028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 790, 1028);
            }
        }

        static SymbolAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 592, 1035);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 592, 1035);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 592, 1035);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 592, 1035);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_939_947_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 790, 1028);
            return return_v;
        }

    }
    internal sealed class SymbolStartAnalyzerAction : AnalyzerAction
    {
        public Action<SymbolStartAnalysisContext> Action { get; }

        public SymbolKind Kind { get; }

        public SymbolStartAnalyzerAction(Action<SymbolStartAnalysisContext> action, SymbolKind kind, DiagnosticAnalyzer analyzer)
        : base(f_259_1376_1384_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 1234, 1463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1124, 1181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1191, 1222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1410, 1426);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1440, 1452);

                Kind = kind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 1234, 1463);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 1234, 1463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 1234, 1463);
            }
        }

        static SymbolStartAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 1043, 1470);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 1043, 1470);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 1043, 1470);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 1043, 1470);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_1376_1384_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 1234, 1463);
            return return_v;
        }

    }
    internal sealed class SymbolEndAnalyzerAction : AnalyzerAction
    {
        public Action<SymbolAnalysisContext> Action { get; }

        public SymbolEndAnalyzerAction(Action<SymbolAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_1739_1747_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 1621, 1800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1557, 1609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1773, 1789);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 1621, 1800);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 1621, 1800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 1621, 1800);
            }
        }

        static SymbolEndAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 1478, 1807);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 1478, 1807);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 1478, 1807);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 1478, 1807);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_1739_1747_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 1621, 1800);
            return return_v;
        }

    }
    internal sealed class SyntaxNodeAnalyzerAction<TLanguageKindEnum> : AnalyzerAction where TLanguageKindEnum : struct
    {
        public Action<SyntaxNodeAnalysisContext> Action { get; }

        public ImmutableArray<TLanguageKindEnum> Kinds { get; }

        public SyntaxNodeAnalyzerAction(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> kinds, DiagnosticAnalyzer analyzer)
        : base(f_259_2244_2252_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 2080, 2333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 1947, 2003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 2278, 2294);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 2308, 2322);

                Kinds = kinds;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 2080, 2333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 2080, 2333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 2080, 2333);
            }
        }

        static SyntaxNodeAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 1815, 2340);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 1815, 2340);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 1815, 2340);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 1815, 2340);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_2244_2252_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 2080, 2333);
            return return_v;
        }

    }
    internal sealed class OperationBlockStartAnalyzerAction : AnalyzerAction
    {
        public Action<OperationBlockStartAnalysisContext> Action { get; }

        public OperationBlockStartAnalyzerAction(Action<OperationBlockStartAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_2655_2663_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 2514, 2716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 2437, 2502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 2689, 2705);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 2514, 2716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 2514, 2716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 2514, 2716);
            }
        }

        static OperationBlockStartAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 2348, 2723);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 2348, 2723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 2348, 2723);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 2348, 2723);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_2655_2663_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 2514, 2716);
            return return_v;
        }

    }
    internal sealed class OperationBlockAnalyzerAction : AnalyzerAction
    {
        public Action<OperationBlockAnalysisContext> Action { get; }

        public OperationBlockAnalyzerAction(Action<OperationBlockAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_3018_3026_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 2887, 3079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 2815, 2875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 3052, 3068);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 2887, 3079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 2887, 3079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 2887, 3079);
            }
        }

        static OperationBlockAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 2731, 3086);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 2731, 3086);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 2731, 3086);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 2731, 3086);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_3018_3026_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 2887, 3079);
            return return_v;
        }

    }
    internal sealed class OperationAnalyzerAction : AnalyzerAction
    {
        public Action<OperationAnalysisContext> Action { get; }

        public ImmutableArray<OperationKind> Kinds { get; }

        public OperationAnalyzerAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> kinds, DiagnosticAnalyzer analyzer)
        : base(f_259_3459_3467_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 3301, 3548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 3173, 3228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 3493, 3509);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 3523, 3537);

                Kinds = kinds;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 3301, 3548);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 3301, 3548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 3301, 3548);
            }
        }

        static OperationAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 3094, 3555);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 3094, 3555);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 3094, 3555);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 3094, 3555);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_3459_3467_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 3301, 3548);
            return return_v;
        }

    }
    internal sealed class CompilationStartAnalyzerAction : AnalyzerAction
    {
        public Action<CompilationStartAnalysisContext> Action { get; }

        public CompilationStartAnalyzerAction(Action<CompilationStartAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_3858_3866_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 3723, 3919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 3649, 3711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 3892, 3908);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 3723, 3919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 3723, 3919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 3723, 3919);
            }
        }

        static CompilationStartAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 3563, 3926);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 3563, 3926);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 3563, 3926);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 3563, 3926);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_3858_3866_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 3723, 3919);
            return return_v;
        }

    }
    internal sealed class CompilationAnalyzerAction : AnalyzerAction
    {
        public Action<CompilationAnalysisContext> Action { get; }

        public CompilationAnalyzerAction(Action<CompilationAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_4209_4217_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 4084, 4270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 4015, 4072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 4243, 4259);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 4084, 4270);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 4084, 4270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 4084, 4270);
            }
        }

        static CompilationAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 3934, 4277);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 3934, 4277);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 3934, 4277);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 3934, 4277);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_4209_4217_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 4084, 4270);
            return return_v;
        }

    }
    internal sealed class SemanticModelAnalyzerAction : AnalyzerAction
    {
        public Action<SemanticModelAnalysisContext> Action { get; }

        public SemanticModelAnalyzerAction(Action<SemanticModelAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_4568_4576_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 4439, 4629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 4368, 4427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 4602, 4618);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 4439, 4629);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 4439, 4629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 4439, 4629);
            }
        }

        static SemanticModelAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 4285, 4636);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 4285, 4636);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 4285, 4636);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 4285, 4636);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_4568_4576_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 4439, 4629);
            return return_v;
        }

    }
    internal sealed class SyntaxTreeAnalyzerAction : AnalyzerAction
    {
        public Action<SyntaxTreeAnalysisContext> Action { get; }

        public SyntaxTreeAnalyzerAction(Action<SyntaxTreeAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_4915_4923_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 4792, 4976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 4724, 4780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 4949, 4965);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 4792, 4976);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 4792, 4976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 4792, 4976);
            }
        }

        static SyntaxTreeAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 4644, 4983);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 4644, 4983);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 4644, 4983);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 4644, 4983);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_4915_4923_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 4792, 4976);
            return return_v;
        }

    }
    internal sealed class AdditionalFileAnalyzerAction : AnalyzerAction
    {
        public Action<AdditionalFileAnalysisContext> Action { get; }

        public AdditionalFileAnalyzerAction(Action<AdditionalFileAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_5278_5286_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 5147, 5339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 5075, 5135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 5312, 5328);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 5147, 5339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 5147, 5339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 5147, 5339);
            }
        }

        static AdditionalFileAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 4991, 5346);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 4991, 5346);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 4991, 5346);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 4991, 5346);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_5278_5286_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 5147, 5339);
            return return_v;
        }

    }
    internal sealed class CodeBlockStartAnalyzerAction<TLanguageKindEnum> : AnalyzerAction where TLanguageKindEnum : struct
    {
        public Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> Action { get; }

        public CodeBlockStartAnalyzerAction(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action, DiagnosticAnalyzer analyzer)
        : base(f_259_5731_5739_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 5581, 5792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 5490, 5569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 5765, 5781);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 5581, 5792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 5581, 5792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 5581, 5792);
            }
        }

        static CodeBlockStartAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 5354, 5799);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 5354, 5799);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 5354, 5799);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 5354, 5799);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_5731_5739_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 5581, 5792);
            return return_v;
        }

    }
    internal sealed class CodeBlockAnalyzerAction : AnalyzerAction
    {
        public Action<CodeBlockAnalysisContext> Action { get; }

        public CodeBlockAnalyzerAction(Action<CodeBlockAnalysisContext> action, DiagnosticAnalyzer analyzer)
        : base(f_259_6074_6082_C(analyzer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(259, 5953, 6135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 5886, 5941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(259, 6108, 6124);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(259, 5953, 6135);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(259, 5953, 6135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 5953, 6135);
            }
        }

        static CodeBlockAnalyzerAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(259, 5807, 6142);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(259, 5807, 6142);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(259, 5807, 6142);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(259, 5807, 6142);

        static Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        f_259_6074_6082_C(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(259, 5953, 6135);
            return return_v;
        }

    }
}
