// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Diagnostics.Telemetry
{
    internal class AnalyzerActionCounts
    {
        internal static readonly AnalyzerActionCounts Empty;

        internal AnalyzerActionCounts(in AnalyzerActions analyzerActions) : this(
        f_217_672_716_C(analyzerActions.CompilationStartActionsCount), analyzerActions.CompilationEndActionsCount, analyzerActions.CompilationActionsCount, analyzerActions.SyntaxTreeActionsCount, analyzerActions.AdditionalFileActionsCount, analyzerActions.SemanticModelActionsCount, analyzerActions.SymbolActionsCount, analyzerActions.SymbolStartActionsCount, analyzerActions.SymbolEndActionsCount, analyzerActions.SyntaxNodeActionsCount, analyzerActions.CodeBlockStartActionsCount, analyzerActions.CodeBlockEndActionsCount, analyzerActions.CodeBlockActionsCount, analyzerActions.OperationActionsCount, analyzerActions.OperationBlockStartActionsCount, analyzerActions.OperationBlockEndActionsCount, analyzerActions.OperationBlockActionsCount, analyzerActions.Concurrent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(217, 568, 1728);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(217, 568, 1728);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(217, 568, 1728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(217, 568, 1728);
            }
        }

        internal AnalyzerActionCounts(
                    int compilationStartActionsCount,
                    int compilationEndActionsCount,
                    int compilationActionsCount,
                    int syntaxTreeActionsCount,
                    int additionalFileActionsCount,
                    int semanticModelActionsCount,
                    int symbolActionsCount,
                    int symbolStartActionsCount,
                    int symbolEndActionsCount,
                    int syntaxNodeActionsCount,
                    int codeBlockStartActionsCount,
                    int codeBlockEndActionsCount,
                    int codeBlockActionsCount,
                    int operationActionsCount,
                    int operationBlockStartActionsCount,
                    int operationBlockEndActionsCount,
                    int operationBlockActionsCount,
                    bool concurrent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(217, 1740, 4096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 4215, 4263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 4380, 4426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 4539, 4582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 4695, 4737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 4854, 4900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 5016, 5061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 5169, 5207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 5321, 5364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 5476, 5517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 5630, 5672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 5779, 5825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 5930, 5974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 6075, 6116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 6216, 6257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 6369, 6420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 6530, 6579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 6685, 6731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 6878, 6926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 7074, 7105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 2560, 2620);

                CompilationStartActionsCount = compilationStartActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 2634, 2690);

                CompilationEndActionsCount = compilationEndActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 2704, 2754);

                CompilationActionsCount = compilationActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 2768, 2816);

                SyntaxTreeActionsCount = syntaxTreeActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 2830, 2886);

                AdditionalFileActionsCount = additionalFileActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 2900, 2954);

                SemanticModelActionsCount = semanticModelActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 2968, 3008);

                SymbolActionsCount = symbolActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3022, 3072);

                SymbolStartActionsCount = symbolStartActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3086, 3132);

                SymbolEndActionsCount = symbolEndActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3146, 3194);

                SyntaxNodeActionsCount = syntaxNodeActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3208, 3264);

                CodeBlockStartActionsCount = codeBlockStartActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3278, 3330);

                CodeBlockEndActionsCount = codeBlockEndActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3344, 3390);

                CodeBlockActionsCount = codeBlockActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3404, 3450);

                OperationActionsCount = operationActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3464, 3530);

                OperationBlockStartActionsCount = operationBlockStartActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3544, 3606);

                OperationBlockEndActionsCount = operationBlockEndActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3620, 3676);

                OperationBlockActionsCount = operationBlockActionsCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3690, 3714);

                Concurrent = concurrent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 3730, 4085);

                HasAnyExecutableCodeActions = f_217_3760_3781() > 0 || (DynAbs.Tracing.TraceSender.Expression_False(217, 3760, 3836) || f_217_3806_3832() > 0) || (DynAbs.Tracing.TraceSender.Expression_False(217, 3760, 3883) || f_217_3857_3879() > 0) || (DynAbs.Tracing.TraceSender.Expression_False(217, 3760, 3929) || f_217_3904_3925() > 0) || (DynAbs.Tracing.TraceSender.Expression_False(217, 3760, 3980) || f_217_3950_3976() > 0) || (DynAbs.Tracing.TraceSender.Expression_False(217, 3760, 4036) || f_217_4001_4032() > 0) || (DynAbs.Tracing.TraceSender.Expression_False(217, 3760, 4084) || f_217_4057_4080() > 0);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(217, 1740, 4096);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(217, 1740, 4096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(217, 1740, 4096);
            }
        }

        public int CompilationStartActionsCount { get; }

        public int CompilationEndActionsCount { get; }

        public int CompilationActionsCount { get; }

        public int SyntaxTreeActionsCount { get; }

        public int AdditionalFileActionsCount { get; }

        public int SemanticModelActionsCount { get; }

        public int SymbolActionsCount { get; }

        public int SymbolStartActionsCount { get; }

        public int SymbolEndActionsCount { get; }

        public int SyntaxNodeActionsCount { get; }

        public int CodeBlockStartActionsCount { get; }

        public int CodeBlockEndActionsCount { get; }

        public int CodeBlockActionsCount { get; }

        public int OperationActionsCount { get; }

        public int OperationBlockStartActionsCount { get; }

        public int OperationBlockEndActionsCount { get; }

        public int OperationBlockActionsCount { get; }

        public bool HasAnyExecutableCodeActions { get; }

        public bool Concurrent { get; }

        static AnalyzerActionCounts()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(217, 399, 7112);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(217, 497, 555);
            Empty = f_217_505_555(AnalyzerActions.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(217, 399, 7112);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(217, 399, 7112);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(217, 399, 7112);

        static Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        f_217_505_555(Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
        analyzerActions)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts(analyzerActions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(217, 505, 555);
            return return_v;
        }


        static int
        f_217_672_716_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(217, 568, 1728);
            return return_v;
        }


        int
        f_217_3760_3781()
        {
            var return_v = CodeBlockActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(217, 3760, 3781);
            return return_v;
        }


        int
        f_217_3806_3832()
        {
            var return_v = CodeBlockStartActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(217, 3806, 3832);
            return return_v;
        }


        int
        f_217_3857_3879()
        {
            var return_v = SyntaxNodeActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(217, 3857, 3879);
            return return_v;
        }


        int
        f_217_3904_3925()
        {
            var return_v = OperationActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(217, 3904, 3925);
            return return_v;
        }


        int
        f_217_3950_3976()
        {
            var return_v = OperationBlockActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(217, 3950, 3976);
            return return_v;
        }


        int
        f_217_4001_4032()
        {
            var return_v = OperationBlockStartActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(217, 4001, 4032);
            return return_v;
        }


        int
        f_217_4057_4080()
        {
            var return_v = SymbolStartActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(217, 4057, 4080);
            return return_v;
        }

    }
}
