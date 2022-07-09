// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Operations;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalysisState
    {
        internal sealed class DeclarationAnalyzerStateData : SyntaxNodeAnalyzerStateData
        {
            public CodeBlockAnalyzerStateData CodeBlockAnalysisState { get; }

            public OperationBlockAnalyzerStateData OperationBlockAnalysisState { get; }

            public static new readonly DeclarationAnalyzerStateData FullyProcessedInstance;

            public DeclarationAnalyzerStateData()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(215, 1360, 1589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 908, 973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1141, 1216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1430, 1488);

                    CodeBlockAnalysisState = f_215_1455_1487();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1506, 1574);

                    OperationBlockAnalysisState = f_215_1536_1573();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(215, 1360, 1589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 1360, 1589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 1360, 1589);
                }
            }

            private static DeclarationAnalyzerStateData CreateFullyProcessedInstance()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(215, 1605, 1877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1712, 1762);

                    var
                    instance = f_215_1727_1761()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1780, 1828);

                    f_215_1780_1827(instance, StateKind.FullyProcessed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1846, 1862);

                    return instance;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(215, 1605, 1877);

                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    f_215_1727_1761()
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 1727, 1761);
                        return return_v;
                    }


                    int
                    f_215_1780_1827(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 1780, 1827);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 1605, 1877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 1605, 1877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void SetStateKind(StateKind stateKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 1893, 2159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1980, 2027);

                    f_215_1980_2026(f_215_1980_2002(), stateKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2045, 2097);

                    f_215_2045_2096(f_215_2045_2072(), stateKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2115, 2144);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetStateKind(stateKind), 215, 2115, 2143);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 1893, 2159);

                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData
                    f_215_1980_2002()
                    {
                        var return_v = CodeBlockAnalysisState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 1980, 2002);
                        return return_v;
                    }


                    int
                    f_215_1980_2026(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 1980, 2026);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData
                    f_215_2045_2072()
                    {
                        var return_v = OperationBlockAnalysisState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 2045, 2072);
                        return return_v;
                    }


                    int
                    f_215_2045_2096(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 2045, 2096);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 1893, 2159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 1893, 2159);
                }
            }

            public override void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 2175, 2363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2235, 2247);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 215, 2235, 2246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2265, 2295);

                    f_215_2265_2294(f_215_2265_2287());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2313, 2348);

                    f_215_2313_2347(f_215_2313_2340());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 2175, 2363);

                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData
                    f_215_2265_2287()
                    {
                        var return_v = CodeBlockAnalysisState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 2265, 2287);
                        return return_v;
                    }


                    int
                    f_215_2265_2294(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 2265, 2294);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData
                    f_215_2313_2340()
                    {
                        var return_v = OperationBlockAnalysisState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 2313, 2340);
                        return return_v;
                    }


                    int
                    f_215_2313_2347(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 2313, 2347);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 2175, 2363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 2175, 2363);
                }
            }

            static DeclarationAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(215, 656, 2374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 1288, 1343);
                FullyProcessedInstance = f_215_1313_1343(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(215, 656, 2374);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 656, 2374);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(215, 656, 2374);

            static Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
            f_215_1313_1343()
            {
                var return_v = CreateFullyProcessedInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 1313, 1343);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData
            f_215_1455_1487()
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 1455, 1487);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData
            f_215_1536_1573()
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 1536, 1573);
                return return_v;
            }

        }
        internal class SyntaxNodeAnalyzerStateData : AnalyzerStateData
        {
            public HashSet<SyntaxNode> ProcessedNodes { get; }

            public SyntaxNode CurrentNode { get; set; }

            public SyntaxNodeAnalyzerStateData()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(215, 2743, 2907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2620, 2670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2684, 2727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2812, 2831);

                    CurrentNode = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2849, 2892);

                    ProcessedNodes = f_215_2866_2891();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(215, 2743, 2907);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 2743, 2907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 2743, 2907);
                }
            }

            public void ClearNodeAnalysisState()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 2923, 3069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 2992, 3011);

                    CurrentNode = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3029, 3054);

                    f_215_3029_3053(f_215_3029_3045());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 2923, 3069);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                    f_215_3029_3045()
                    {
                        var return_v = ProcessedActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 3029, 3045);
                        return return_v;
                    }


                    int
                    f_215_3029_3053(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 3029, 3053);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 2923, 3069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 2923, 3069);
                }
            }

            public override void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 3085, 3250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3145, 3157);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 215, 3145, 3156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3175, 3194);

                    CurrentNode = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3212, 3235);

                    f_215_3212_3234(f_215_3212_3226());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 3085, 3250);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    f_215_3212_3226()
                    {
                        var return_v = ProcessedNodes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 3212, 3226);
                        return return_v;
                    }


                    int
                    f_215_3212_3234(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 3212, 3234);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 3085, 3250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 3085, 3250);
                }
            }

            static SyntaxNodeAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(215, 2533, 3261);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(215, 2533, 3261);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 2533, 3261);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(215, 2533, 3261);

            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
            f_215_2866_2891()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 2866, 2891);
                return return_v;
            }

        }
        internal class OperationAnalyzerStateData : AnalyzerStateData
        {
            public HashSet<IOperation> ProcessedOperations { get; }

            public IOperation CurrentOperation { get; set; }

            public OperationAnalyzerStateData()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(215, 3637, 3810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3504, 3559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3573, 3621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3705, 3729);

                    CurrentOperation = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3747, 3795);

                    ProcessedOperations = f_215_3769_3794();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(215, 3637, 3810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 3637, 3810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 3637, 3810);
                }
            }

            public void ClearNodeAnalysisState()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 3826, 3977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3895, 3919);

                    CurrentOperation = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 3937, 3962);

                    f_215_3937_3961(f_215_3937_3953());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 3826, 3977);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                    f_215_3937_3953()
                    {
                        var return_v = ProcessedActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 3937, 3953);
                        return return_v;
                    }


                    int
                    f_215_3937_3961(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 3937, 3961);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 3826, 3977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 3826, 3977);
                }
            }

            public override void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 3993, 4168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4053, 4065);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 215, 4053, 4064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4083, 4107);

                    CurrentOperation = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4125, 4153);

                    f_215_4125_4152(f_215_4125_4144());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 3993, 4168);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                    f_215_4125_4144()
                    {
                        var return_v = ProcessedOperations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 4125, 4144);
                        return return_v;
                    }


                    int
                    f_215_4125_4152(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 4125, 4152);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 3993, 4168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 3993, 4168);
                }
            }

            static OperationAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(215, 3418, 4179);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(215, 3418, 4179);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 3418, 4179);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(215, 3418, 4179);

            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
            f_215_3769_3794()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 3769, 3794);
                return return_v;
            }

        }
        internal abstract class BlockAnalyzerStateData<TBlockAction, TNodeStateData> : AnalyzerStateData
                    where TBlockAction : AnalyzerAction
                    where TNodeStateData : AnalyzerStateData, new()
        {
            public TNodeStateData ExecutableNodesAnalysisState { get; }

            public ImmutableHashSet<TBlockAction> CurrentBlockEndActions { get; set; }

            public ImmutableHashSet<AnalyzerAction> CurrentBlockNodeActions { get; set; }

            public BlockAnalyzerStateData()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(215, 4851, 5079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4595, 4654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4670, 4744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4758, 4835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4915, 4967);

                    ExecutableNodesAnalysisState = f_215_4946_4966<TNodeStateData>();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 4985, 5015);

                    CurrentBlockEndActions = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 5033, 5064);

                    CurrentBlockNodeActions = null;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(215, 4851, 5079);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 4851, 5079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 4851, 5079);
                }
            }

            public override void SetStateKind(StateKind stateKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 5095, 5297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 5182, 5235);

                    f_215_5182_5234(f_215_5182_5210(), stateKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 5253, 5282);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetStateKind(stateKind), 215, 5253, 5281);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 5095, 5297);

                    TNodeStateData
                    f_215_5182_5210()
                    {
                        var return_v = ExecutableNodesAnalysisState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 5182, 5210);
                        return return_v;
                    }


                    int
                    f_215_5182_5234(TNodeStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 5182, 5234);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 5095, 5297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 5095, 5297);
                }
            }

            public override void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(215, 5313, 5551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 5373, 5385);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 215, 5373, 5384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 5403, 5439);

                    f_215_5403_5438(f_215_5403_5431());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 5457, 5487);

                    CurrentBlockEndActions = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(215, 5505, 5536);

                    CurrentBlockNodeActions = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(215, 5313, 5551);

                    TNodeStateData
                    f_215_5403_5431()
                    {
                        var return_v = ExecutableNodesAnalysisState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(215, 5403, 5431);
                        return return_v;
                    }


                    int
                    f_215_5403_5438(TNodeStateData
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 5403, 5438);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(215, 5313, 5551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 5313, 5551);
                }
            }

            static BlockAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(215, 4364, 5562);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(215, 4364, 5562);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 4364, 5562);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(215, 4364, 5562);

            static TNodeStateData
            f_215_4946_4966<TNodeStateData>() where TNodeStateData : AnalyzerStateData, new()

            {
                var return_v = new TNodeStateData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(215, 4946, 4966);
                return return_v;
            }

        }
        internal sealed class CodeBlockAnalyzerStateData : BlockAnalyzerStateData<CodeBlockAnalyzerAction, SyntaxNodeAnalyzerStateData>
        {
            public CodeBlockAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(215, 5720, 5869);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(215, 5720, 5869);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 5720, 5869);
            }


            static CodeBlockAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(215, 5720, 5869);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(215, 5720, 5869);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 5720, 5869);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(215, 5720, 5869);
        }
        internal sealed class OperationBlockAnalyzerStateData : BlockAnalyzerStateData<OperationBlockAnalyzerAction, OperationAnalyzerStateData>
        {
            public OperationBlockAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(215, 6032, 6190);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(215, 6032, 6190);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 6032, 6190);
            }


            static OperationBlockAnalyzerStateData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(215, 6032, 6190);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(215, 6032, 6190);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(215, 6032, 6190);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(215, 6032, 6190);
        }
    }
}
