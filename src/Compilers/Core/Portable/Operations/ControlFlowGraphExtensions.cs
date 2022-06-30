// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    public static partial class ControlFlowGraphExtensions
    {
        public static ControlFlowGraph GetLocalFunctionControlFlowGraphInScope(this ControlFlowGraph controlFlowGraph, IMethodSymbol localFunction, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(458, 632, 1645);
                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph? localFunctionControlFlowGraph = default(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 843, 978) || true) && (controlFlowGraph == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 843, 978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 905, 963);

                    throw f_458_911_962(nameof(controlFlowGraph));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(458, 843, 978);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 994, 1123) || true) && (localFunction == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 994, 1123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 1053, 1108);

                    throw f_458_1059_1107(nameof(localFunction));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(458, 994, 1123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 1139, 1189);

                ControlFlowGraph?
                currentGraph = controlFlowGraph
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 1203, 1557);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 1238, 1475) || true) && (f_458_1242_1377(currentGraph, localFunction, cancellationToken, out localFunctionControlFlowGraph))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 1238, 1475);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 1419, 1456);

                                return localFunctionControlFlowGraph;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(458, 1238, 1475);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(458, 1203, 1557);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 1203, 1557) || true) && ((currentGraph = f_458_1527_1546(currentGraph)) != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(458, 1203, 1557);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(458, 1203, 1557);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 1573, 1634);

                throw f_458_1579_1633(nameof(localFunction));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(458, 632, 1645);

                System.ArgumentNullException
                f_458_911_962(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 911, 962);
                    return return_v;
                }


                System.ArgumentNullException
                f_458_1059_1107(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 1059, 1107);
                    return return_v;
                }


                bool
                f_458_1242_1377(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                localFunction, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                controlFlowGraph)
                {
                    var return_v = this_param.TryGetLocalFunctionControlFlowGraph(localFunction, cancellationToken, out controlFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 1242, 1377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_458_1527_1546(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(458, 1527, 1546);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_458_1579_1633(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 1579, 1633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(458, 632, 1645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(458, 632, 1645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowGraph GetAnonymousFunctionControlFlowGraphInScope(this ControlFlowGraph controlFlowGraph, IFlowAnonymousFunctionOperation anonymousFunction, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(458, 1918, 2977);
                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph? localFunctionControlFlowGraph = default(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2155, 2290) || true) && (controlFlowGraph == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 2155, 2290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2217, 2275);

                    throw f_458_2223_2274(nameof(controlFlowGraph));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(458, 2155, 2290);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2306, 2443) || true) && (anonymousFunction == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 2306, 2443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2369, 2428);

                    throw f_458_2375_2427(nameof(anonymousFunction));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(458, 2306, 2443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2459, 2509);

                ControlFlowGraph?
                currentGraph = controlFlowGraph
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 2523, 2885);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2558, 2803) || true) && (f_458_2562_2705(currentGraph, anonymousFunction, cancellationToken, out localFunctionControlFlowGraph))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(458, 2558, 2803);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2747, 2784);

                                return localFunctionControlFlowGraph;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(458, 2558, 2803);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(458, 2523, 2885);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2523, 2885) || true) && ((currentGraph = f_458_2855_2874(currentGraph)) != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(458, 2523, 2885);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(458, 2523, 2885);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(458, 2901, 2966);

                throw f_458_2907_2965(nameof(anonymousFunction));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(458, 1918, 2977);

                System.ArgumentNullException
                f_458_2223_2274(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 2223, 2274);
                    return return_v;
                }


                System.ArgumentNullException
                f_458_2375_2427(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 2375, 2427);
                    return return_v;
                }


                bool
                f_458_2562_2705(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                anonymousFunction, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                controlFlowGraph)
                {
                    var return_v = this_param.TryGetAnonymousFunctionControlFlowGraph(anonymousFunction, cancellationToken, out controlFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 2562, 2705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_458_2855_2874(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(458, 2855, 2874);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_458_2907_2965(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(458, 2907, 2965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(458, 1918, 2977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(458, 1918, 2977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ControlFlowGraphExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(458, 304, 2984);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(458, 304, 2984);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(458, 304, 2984);
        }

    }
}
