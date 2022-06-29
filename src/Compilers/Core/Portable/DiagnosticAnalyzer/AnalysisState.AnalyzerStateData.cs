// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalysisState
    {
        internal class AnalyzerStateData
        {
            public StateKind StateKind { get; private set; }

            public HashSet<AnalyzerAction> ProcessedActions { get; }

            public static readonly AnalyzerStateData FullyProcessedInstance;

            public AnalyzerStateData()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(211, 1027, 1200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 680, 728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 842, 898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 1086, 1118);

                    StateKind = StateKind.InProcess;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 1136, 1185);

                    ProcessedActions = f_211_1155_1184();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(211, 1027, 1200);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(211, 1027, 1200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(211, 1027, 1200);
                }
            }

            private static AnalyzerStateData CreateFullyProcessedInstance()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(211, 1216, 1466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 1312, 1351);

                    var
                    instance = f_211_1327_1350()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 1369, 1417);

                    f_211_1369_1416(instance, StateKind.FullyProcessed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 1435, 1451);

                    return instance;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(211, 1216, 1466);

                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    f_211_1327_1350()
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(211, 1327, 1350);
                        return return_v;
                    }


                    int
                    f_211_1369_1416(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(211, 1369, 1416);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(211, 1216, 1466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(211, 1216, 1466);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public virtual void SetStateKind(StateKind stateKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(211, 1482, 1605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 1568, 1590);

                    StateKind = stateKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(211, 1482, 1605);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(211, 1482, 1605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(211, 1482, 1605);
                }
            }

            public void ResetToReadyState()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(211, 1922, 2040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 1986, 2025);

                    f_211_1986_2024(this, StateKind.ReadyToProcess);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(211, 1922, 2040);

                    int
                    f_211_1986_2024(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(211, 1986, 2024);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(211, 1922, 2040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(211, 1922, 2040);
                }
            }

            public virtual void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(211, 2056, 2220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 2115, 2157);

                    this.StateKind = StateKind.ReadyToProcess;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 2175, 2205);

                    f_211_2175_2204(f_211_2175_2196(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(211, 2056, 2220);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                    f_211_2175_2196(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.ProcessedActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(211, 2175, 2196);
                        return return_v;
                    }


                    int
                    f_211_2175_2204(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(211, 2175, 2204);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(211, 2056, 2220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(211, 2056, 2220);
                }
            }

            static AnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(211, 524, 2231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(211, 955, 1010);
                FullyProcessedInstance = f_211_980_1010(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(211, 524, 2231);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(211, 524, 2231);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(211, 524, 2231);

            static Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
            f_211_980_1010()
            {
                var return_v = CreateFullyProcessedInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(211, 980, 1010);
                return return_v;
            }


            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
            f_211_1155_1184()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(211, 1155, 1184);
                return return_v;
            }

        }

        static AnalysisState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(211, 319, 2238);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(211, 319, 2238);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(211, 319, 2238);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(211, 319, 2238);
    }
}
