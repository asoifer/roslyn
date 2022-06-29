// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.Serialization;

namespace Microsoft.CodeAnalysis.Diagnostics.Telemetry
{
    [DataContract]
    public sealed class AnalyzerTelemetryInfo
    {
        [DataMember(Order = 0)]
        public int CompilationStartActionsCount { get; set; }

        [DataMember(Order = 1)]
        public int CompilationEndActionsCount { get; set; }

        [DataMember(Order = 2)]
        public int CompilationActionsCount { get; set; }

        [DataMember(Order = 3)]
        public int SyntaxTreeActionsCount { get; set; }

        [DataMember(Order = 4)]
        public int AdditionalFileActionsCount { get; set; }

        [DataMember(Order = 5)]
        public int SemanticModelActionsCount { get; set; }

        [DataMember(Order = 6)]
        public int SymbolActionsCount { get; set; }

        [DataMember(Order = 7)]
        public int SymbolStartActionsCount { get; set; }

        [DataMember(Order = 8)]
        public int SymbolEndActionsCount { get; set; }

        [DataMember(Order = 9)]
        public int SyntaxNodeActionsCount { get; set; }

        [DataMember(Order = 10)]
        public int CodeBlockStartActionsCount { get; set; }

        [DataMember(Order = 11)]
        public int CodeBlockEndActionsCount { get; set; }

        [DataMember(Order = 12)]
        public int CodeBlockActionsCount { get; set; }

        [DataMember(Order = 13)]
        public int OperationActionsCount { get; set; }

        [DataMember(Order = 14)]
        public int OperationBlockStartActionsCount { get; set; }

        [DataMember(Order = 15)]
        public int OperationBlockEndActionsCount { get; set; }

        [DataMember(Order = 16)]
        public int OperationBlockActionsCount { get; set; }

        [DataMember(Order = 17)]
        public int SuppressionActionsCount { get; set; }

        [DataMember(Order = 18)]
        public TimeSpan ExecutionTime { get; set; }

        [DataMember(Order = 19)]
        public bool Concurrent { get; set; }

        internal AnalyzerTelemetryInfo(AnalyzerActionCounts actionCounts, int suppressionActionCounts, TimeSpan executionTime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(240, 4765, 6425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 675, 761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 878, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1075, 1156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1269, 1349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1466, 1550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1666, 1749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1857, 1933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2047, 2128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2240, 2319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2432, 2512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2630, 2715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2831, 2914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3026, 3106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3217, 3297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3420, 3510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3631, 3719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3836, 3921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4265, 4347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4441, 4535);
                this.ExecutionTime = TimeSpan.Zero; DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4683, 4753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4908, 4981);

                CompilationStartActionsCount = f_240_4939_4980(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4995, 5064);

                CompilationEndActionsCount = f_240_5024_5063(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5078, 5141);

                CompilationActionsCount = f_240_5104_5140(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5157, 5218);

                SyntaxTreeActionsCount = f_240_5182_5217(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5232, 5301);

                AdditionalFileActionsCount = f_240_5261_5300(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5315, 5382);

                SemanticModelActionsCount = f_240_5343_5381(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5396, 5449);

                SymbolActionsCount = f_240_5417_5448(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5463, 5526);

                SymbolStartActionsCount = f_240_5489_5525(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5540, 5599);

                SymbolEndActionsCount = f_240_5564_5598(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5613, 5674);

                SyntaxNodeActionsCount = f_240_5638_5673(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5690, 5759);

                CodeBlockStartActionsCount = f_240_5719_5758(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5773, 5838);

                CodeBlockEndActionsCount = f_240_5800_5837(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5852, 5911);

                CodeBlockActionsCount = f_240_5876_5910(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 5927, 5986);

                OperationActionsCount = f_240_5951_5985(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 6000, 6079);

                OperationBlockStartActionsCount = f_240_6034_6078(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 6093, 6168);

                OperationBlockEndActionsCount = f_240_6125_6167(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 6182, 6251);

                OperationBlockActionsCount = f_240_6211_6250(actionCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 6267, 6317);

                SuppressionActionsCount = suppressionActionCounts;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 6333, 6363);

                ExecutionTime = executionTime;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 6377, 6414);

                Concurrent = f_240_6390_6413(actionCounts);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(240, 4765, 6425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(240, 4765, 6425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(240, 4765, 6425);
            }
        }

        public AnalyzerTelemetryInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(240, 6612, 6664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 675, 761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 878, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1075, 1156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1269, 1349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1466, 1550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1666, 1749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 1857, 1933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2047, 2128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2240, 2319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2432, 2512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2630, 2715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 2831, 2914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3026, 3106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3217, 3297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3420, 3510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3631, 3719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 3836, 3921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4265, 4347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4441, 4535);
                this.ExecutionTime = TimeSpan.Zero; DynAbs.Tracing.TraceSender.TraceSimpleStatement(240, 4683, 4753);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(240, 6612, 6664);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(240, 6612, 6664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(240, 6612, 6664);
            }
        }

        static AnalyzerTelemetryInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(240, 490, 6671);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(240, 490, 6671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(240, 490, 6671);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(240, 490, 6671);

        static int
        f_240_4939_4980(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.CompilationStartActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 4939, 4980);
            return return_v;
        }


        static int
        f_240_5024_5063(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.CompilationEndActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5024, 5063);
            return return_v;
        }


        static int
        f_240_5104_5140(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.CompilationActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5104, 5140);
            return return_v;
        }


        static int
        f_240_5182_5217(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.SyntaxTreeActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5182, 5217);
            return return_v;
        }


        static int
        f_240_5261_5300(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.AdditionalFileActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5261, 5300);
            return return_v;
        }


        static int
        f_240_5343_5381(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.SemanticModelActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5343, 5381);
            return return_v;
        }


        static int
        f_240_5417_5448(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.SymbolActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5417, 5448);
            return return_v;
        }


        static int
        f_240_5489_5525(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.SymbolStartActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5489, 5525);
            return return_v;
        }


        static int
        f_240_5564_5598(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.SymbolEndActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5564, 5598);
            return return_v;
        }


        static int
        f_240_5638_5673(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.SyntaxNodeActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5638, 5673);
            return return_v;
        }


        static int
        f_240_5719_5758(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.CodeBlockStartActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5719, 5758);
            return return_v;
        }


        static int
        f_240_5800_5837(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.CodeBlockEndActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5800, 5837);
            return return_v;
        }


        static int
        f_240_5876_5910(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.CodeBlockActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5876, 5910);
            return return_v;
        }


        static int
        f_240_5951_5985(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.OperationActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 5951, 5985);
            return return_v;
        }


        static int
        f_240_6034_6078(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.OperationBlockStartActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 6034, 6078);
            return return_v;
        }


        static int
        f_240_6125_6167(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.OperationBlockEndActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 6125, 6167);
            return return_v;
        }


        static int
        f_240_6211_6250(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.OperationBlockActionsCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 6211, 6250);
            return return_v;
        }


        static bool
        f_240_6390_6413(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
        this_param)
        {
            var return_v = this_param.Concurrent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(240, 6390, 6413);
            return return_v;
        }

    }
}
