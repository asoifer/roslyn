// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Operations;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    public sealed partial class ControlFlowGraph
    {
        private readonly ControlFlowGraphBuilder.CaptureIdDispenser _captureIdDispenser;

        private readonly ImmutableDictionary<IMethodSymbol, (ControlFlowRegion region, ILocalFunctionOperation operation, int ordinal)> _localFunctionsMap;

        private ControlFlowGraph?[]? _lazyLocalFunctionsGraphs;

        private readonly ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)> _anonymousFunctionsMap;

        private ControlFlowGraph?[]? _lazyAnonymousFunctionsGraphs;

        internal ControlFlowGraph(IOperation originalOperation,
                                          ControlFlowGraph? parent,
                                          ControlFlowGraphBuilder.CaptureIdDispenser captureIdDispenser,
                                          ImmutableArray<BasicBlock> blocks, ControlFlowRegion root,
                                          ImmutableArray<IMethodSymbol> localFunctions,
                                          ImmutableDictionary<IMethodSymbol, (ControlFlowRegion region, ILocalFunctionOperation operation, int ordinal)> localFunctionsMap,
                                          ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)> anonymousFunctionsMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(451, 1551, 3865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 1084, 1103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 1242, 1260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 1300, 1325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 1447, 1469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 1509, 1538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 10916, 10960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 11203, 11243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 11547, 11585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2282, 2431);

                f_451_2282_2430(parent != null == (f_451_2314_2336(originalOperation) == OperationKind.LocalFunction || (DynAbs.Tracing.TraceSender.Expression_False(451, 2314, 2428) || f_451_2371_2393(originalOperation) == OperationKind.AnonymousFunction)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2445, 2486);

                f_451_2445_2485(captureIdDispenser != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2500, 2532);

                f_451_2500_2531(f_451_2513_2530_M(!blocks.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2546, 2604);

                f_451_2546_2603(f_451_2559_2578(blocks.First()) == BasicBlockKind.Entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2618, 2674);

                f_451_2618_2673(f_451_2631_2649(blocks.Last()) == BasicBlockKind.Exit);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2688, 2715);

                f_451_2688_2714(root != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2729, 2783);

                f_451_2729_2782(f_451_2742_2751(root) == ControlFlowRegionKind.Root);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2797, 2839);

                f_451_2797_2838(f_451_2810_2832(root) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2853, 2910);

                f_451_2853_2909(f_451_2866_2887(root) == blocks.Length - 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2924, 2964);

                f_451_2924_2963(f_451_2937_2962_M(!localFunctions.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 2978, 3018);

                f_451_2978_3017(localFunctionsMap != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3032, 3095);

                f_451_3032_3094(f_451_3045_3068(localFunctionsMap) == localFunctions.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3109, 3181);

                f_451_3109_3180(localFunctions.Distinct().Length == localFunctions.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3195, 3239);

                f_451_3195_3238(anonymousFunctionsMap != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3264, 3490);
                    foreach (IMethodSymbol method in f_451_3297_3311_I(localFunctions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 3264, 3490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3345, 3405);

                        f_451_3345_3404(f_451_3358_3375(method) == MethodKind.LocalFunction);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3423, 3475);

                        f_451_3423_3474(f_451_3436_3473(localFunctionsMap, method));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(451, 3264, 3490);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(451, 1, 227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(451, 1, 227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3515, 3553);

                OriginalOperation = originalOperation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3567, 3583);

                Parent = parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3597, 3613);

                Blocks = blocks;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3627, 3639);

                Root = root;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3653, 3685);

                LocalFunctions = localFunctions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3699, 3738);

                _localFunctionsMap = localFunctionsMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3752, 3799);

                _anonymousFunctionsMap = anonymousFunctionsMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 3813, 3854);

                _captureIdDispenser = captureIdDispenser;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(451, 1551, 3865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 1551, 3865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 1551, 3865);
            }
        }

        public static ControlFlowGraph? Create(SyntaxNode node, SemanticModel semanticModel, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 4767, 5453);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 4923, 5034) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 4923, 5034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 4973, 5019);

                    throw f_451_4979_5018(nameof(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 4923, 5034);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 5050, 5179) || true) && (semanticModel == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 5050, 5179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 5109, 5164);

                    throw f_451_5115_5163(nameof(semanticModel));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 5050, 5179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 5195, 5271);

                IOperation?
                operation = f_451_5219_5270(semanticModel, node, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 5285, 5334);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 5348, 5442);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(451, 5355, 5372) || ((operation == null && DynAbs.Tracing.TraceSender.Conditional_F2(451, 5375, 5379)) || DynAbs.Tracing.TraceSender.Conditional_F3(451, 5382, 5441))) ? null : f_451_5382_5441(operation, nameof(operation), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 4767, 5453);

                System.ArgumentNullException
                f_451_4979_5018(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 4979, 5018);
                    return return_v;
                }


                System.ArgumentNullException
                f_451_5115_5163(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 5115, 5163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_451_5219_5270(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetOperation(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 5219, 5270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_5382_5441(Microsoft.CodeAnalysis.IOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateCore(operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 5382, 5441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 4767, 5453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 4767, 5453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowGraph Create(Operations.IBlockOperation body, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 5802, 6012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 5944, 6001);

                return f_451_5951_6000(body, nameof(body), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 5802, 6012);

                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_5951_6000(Microsoft.CodeAnalysis.Operations.IBlockOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateCore((Microsoft.CodeAnalysis.IOperation)operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 5951, 6000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 5802, 6012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 5802, 6012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowGraph Create(Operations.IFieldInitializerOperation initializer, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 6387, 6629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 6547, 6618);

                return f_451_6554_6617(initializer, nameof(initializer), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 6387, 6629);

                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_6554_6617(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateCore((Microsoft.CodeAnalysis.IOperation)operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 6554, 6617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 6387, 6629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 6387, 6629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowGraph Create(Operations.IPropertyInitializerOperation initializer, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 7007, 7252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 7170, 7241);

                return f_451_7177_7240(initializer, nameof(initializer), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 7007, 7252);

                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_7177_7240(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateCore((Microsoft.CodeAnalysis.IOperation)operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 7177, 7240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 7007, 7252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 7007, 7252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowGraph Create(Operations.IParameterInitializerOperation initializer, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 7631, 7877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 7795, 7866);

                return f_451_7802_7865(initializer, nameof(initializer), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 7631, 7877);

                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_7802_7865(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateCore((Microsoft.CodeAnalysis.IOperation)operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 7802, 7865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 7631, 7877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 7631, 7877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowGraph Create(Operations.IConstructorBodyOperation constructorBody, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 8261, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 8424, 8503);

                return f_451_8431_8502(constructorBody, nameof(constructorBody), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 8261, 8514);

                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_8431_8502(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateCore((Microsoft.CodeAnalysis.IOperation)operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 8431, 8502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 8261, 8514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 8261, 8514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowGraph Create(Operations.IMethodBodyOperation methodBody, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 8881, 9114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9034, 9103);

                return f_451_9041_9102(methodBody, nameof(methodBody), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 8881, 9114);

                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_9041_9102(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateCore((Microsoft.CodeAnalysis.IOperation)operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 9041, 9102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 8881, 9114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 8881, 9114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ControlFlowGraph CreateCore(IOperation operation, string argumentNameForException, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(451, 9223, 10575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9383, 9432);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9448, 9576) || true) && (operation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 9448, 9576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9503, 9561);

                    throw f_451_9509_9560(argumentNameForException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 9448, 9576);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9592, 9764) || true) && (f_451_9596_9612(operation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 9592, 9764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9654, 9749);

                    throw f_451_9660_9748(f_451_9682_9721(), argumentNameForException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 9592, 9764);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9780, 9990) || true) && (f_451_9784_9826(((Operation)operation)) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 9780, 9990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 9868, 9975);

                    throw f_451_9874_9974(f_451_9896_9947(), argumentNameForException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 9780, 9990);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 10042, 10120);

                    ControlFlowGraph
                    controlFlowGraph = f_451_10078_10119(operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 10138, 10200);

                    f_451_10138_10199(f_451_10151_10185(controlFlowGraph) == operation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 10218, 10242);

                    return controlFlowGraph;
                }
                catch (Exception e) when (f_451_10297_10339(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(451, 10271, 10536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 10480, 10521);

                    f_451_10480_10520(false, "\n" + f_451_10507_10519(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(451, 10271, 10536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 10552, 10564);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(451, 9223, 10575);

                System.ArgumentNullException
                f_451_9509_9560(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 9509, 9560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_451_9596_9612(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 9596, 9612);
                    return return_v;
                }


                string
                f_451_9682_9721()
                {
                    var return_v = CodeAnalysisResources.NotARootOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 9682, 9721);
                    return return_v;
                }


                System.ArgumentException
                f_451_9660_9748(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 9660, 9748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_451_9784_9826(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 9784, 9826);
                    return return_v;
                }


                string
                f_451_9896_9947()
                {
                    var return_v = CodeAnalysisResources.OperationHasNullSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 9896, 9947);
                    return return_v;
                }


                System.ArgumentException
                f_451_9874_9974(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 9874, 9974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_10078_10119(Microsoft.CodeAnalysis.IOperation
                body)
                {
                    var return_v = ControlFlowGraphBuilder.Create(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 10078, 10119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_451_10151_10185(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.OriginalOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 10151, 10185);
                    return return_v;
                }


                int
                f_451_10138_10199(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 10138, 10199);
                    return 0;
                }


                bool
                f_451_10297_10339(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndCatchUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 10297, 10339);
                    return return_v;
                }


                string
                f_451_10507_10519(System.Exception
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 10507, 10519);
                    return return_v;
                }


                int
                f_451_10480_10520(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 10480, 10520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 9223, 10575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 9223, 10575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IOperation OriginalOperation { get; }

        public ControlFlowGraph? Parent { get; }

        public ImmutableArray<BasicBlock> Blocks { get; }

        public ControlFlowRegion Root { get; }

        public ImmutableArray<IMethodSymbol> LocalFunctions { get; }

        public ControlFlowGraph GetLocalFunctionControlFlowGraph(IMethodSymbol localFunction, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(451, 11931, 12559);
                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph? controlFlowGraph = default(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12088, 12137);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12153, 12282) || true) && (localFunction is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 12153, 12282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12212, 12267);

                    throw f_451_12218_12266(nameof(localFunction));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 12153, 12282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12298, 12508) || true) && (!f_451_12303_12398(this, localFunction, cancellationToken, out controlFlowGraph))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 12298, 12508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12432, 12493);

                    throw f_451_12438_12492(nameof(localFunction));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 12298, 12508);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12524, 12548);

                return controlFlowGraph;
                DynAbs.Tracing.TraceSender.TraceExitMethod(451, 11931, 12559);

                System.ArgumentNullException
                f_451_12218_12266(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 12218, 12266);
                    return return_v;
                }


                bool
                f_451_12303_12398(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                localFunction, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                controlFlowGraph)
                {
                    var return_v = this_param.TryGetLocalFunctionControlFlowGraph(localFunction, cancellationToken, out controlFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 12303, 12398);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_451_12438_12492(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 12438, 12492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 11931, 12559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 11931, 12559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetLocalFunctionControlFlowGraph(IMethodSymbol localFunction, CancellationToken cancellationToken, [NotNullWhen(true)] out ControlFlowGraph? controlFlowGraph)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(451, 12571, 13991);
                (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion enclosing, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal) info = default((Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion enclosing, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12771, 13013) || true) && (!f_451_12776_12909(_localFunctionsMap, localFunction, out info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 12771, 13013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12943, 12967);

                    controlFlowGraph = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 12985, 12998);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 12771, 13013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13029, 13089);

                f_451_13029_13088(localFunction == f_451_13059_13073()[info.ordinal]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13105, 13301) || true) && (_lazyLocalFunctionsGraphs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 13105, 13301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13176, 13286);

                    f_451_13176_13285(ref _lazyLocalFunctionsGraphs, new ControlFlowGraph[f_451_13256_13270().Length], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 13105, 13301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13317, 13404);

                ref ControlFlowGraph?
                localFunctionGraph = ref _lazyLocalFunctionsGraphs[info.ordinal]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13418, 13840) || true) && (localFunctionGraph == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 13418, 13840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13482, 13535);

                    f_451_13482_13534(localFunction == f_451_13512_13533(info.operation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13553, 13668);

                    ControlFlowGraph
                    graph = f_451_13578_13667(info.operation, this, info.enclosing, _captureIdDispenser)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13686, 13742);

                    f_451_13686_13741(f_451_13699_13722(graph) == info.operation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13760, 13825);

                    f_451_13760_13824(ref localFunctionGraph, graph, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 13418, 13840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13856, 13894);

                controlFlowGraph = localFunctionGraph;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13908, 13954);

                f_451_13908_13953(f_451_13921_13944(controlFlowGraph) == this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 13968, 13980);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(451, 12571, 13991);

                bool
                f_451_12776_12909(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.IMethodSymbol, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal)>
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                key, out (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion enclosing, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 12776, 12909);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                f_451_13059_13073()
                {
                    var return_v = LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 13059, 13073);
                    return return_v;
                }


                int
                f_451_13029_13088(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 13029, 13088);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                f_451_13256_13270()
                {
                    var return_v = LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 13256, 13270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?[]?
                f_451_13176_13285(ref Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?[]?
                location1, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph[]
                value, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 13176, 13285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_451_13512_13533(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 13512, 13533);
                    return return_v;
                }


                int
                f_451_13482_13534(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 13482, 13534);
                    return 0;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_13578_13667(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
                body, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                parent, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                enclosing, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.CaptureIdDispenser
                captureIdDispenser)
                {
                    var return_v = ControlFlowGraphBuilder.Create((Microsoft.CodeAnalysis.IOperation)body, parent, enclosing, captureIdDispenser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 13578, 13667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_451_13699_13722(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.OriginalOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 13699, 13722);
                    return return_v;
                }


                int
                f_451_13686_13741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 13686, 13741);
                    return 0;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_451_13760_13824(ref Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                location1, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                value, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 13760, 13824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_451_13921_13944(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 13921, 13944);
                    return return_v;
                }


                int
                f_451_13908_13953(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 13908, 13953);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 12571, 13991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 12571, 13991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ControlFlowGraph GetAnonymousFunctionControlFlowGraph(IFlowAnonymousFunctionOperation anonymousFunction, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(451, 14144, 14832);
                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph? controlFlowGraph = default(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 14327, 14376);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 14392, 14529) || true) && (anonymousFunction is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 14392, 14529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 14455, 14514);

                    throw f_451_14461_14513(nameof(anonymousFunction));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 14392, 14529);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 14545, 14781) || true) && (!f_451_14550_14667(this, anonymousFunction, cancellationToken, out controlFlowGraph))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 14545, 14781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 14701, 14766);

                    throw f_451_14707_14765(nameof(anonymousFunction));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 14545, 14781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 14797, 14821);

                return controlFlowGraph;
                DynAbs.Tracing.TraceSender.TraceExitMethod(451, 14144, 14832);

                System.ArgumentNullException
                f_451_14461_14513(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 14461, 14513);
                    return return_v;
                }


                bool
                f_451_14550_14667(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                anonymousFunction, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                controlFlowGraph)
                {
                    var return_v = this_param.TryGetAnonymousFunctionControlFlowGraph(anonymousFunction, cancellationToken, out controlFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 14550, 14667);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_451_14707_14765(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 14707, 14765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 14144, 14832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 14144, 14832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetAnonymousFunctionControlFlowGraph(IFlowAnonymousFunctionOperation anonymousFunction, CancellationToken cancellationToken, [NotNullWhen(true)] out ControlFlowGraph? controlFlowGraph)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(451, 14844, 16250);
                (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion enclosing, int ordinal) info = default((Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion enclosing, int ordinal));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15070, 15285) || true) && (!f_451_15075_15181(_anonymousFunctionsMap, anonymousFunction, out info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 15070, 15285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15215, 15239);

                    controlFlowGraph = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15257, 15270);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 15070, 15285);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15301, 15512) || true) && (_lazyAnonymousFunctionsGraphs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 15301, 15512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15376, 15497);

                    f_451_15376_15496(ref _lazyAnonymousFunctionsGraphs, new ControlFlowGraph[f_451_15460_15488(_anonymousFunctionsMap)], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 15301, 15512);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15528, 15619);

                ref ControlFlowGraph?
                anonymousFlowGraph = ref _lazyAnonymousFunctionsGraphs[info.ordinal]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15633, 16098) || true) && (anonymousFlowGraph == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(451, 15633, 16098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15697, 15763);

                    var
                    anonymous = (FlowAnonymousFunctionOperation)anonymousFunction
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15781, 15922);

                    ControlFlowGraph
                    graph = f_451_15806_15921(anonymous.Original, this, info.enclosing, _captureIdDispenser, anonymous.Context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 15940, 16000);

                    f_451_15940_15999(f_451_15953_15976(graph) == anonymous.Original);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 16018, 16083);

                    f_451_16018_16082(ref anonymousFlowGraph, graph, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(451, 15633, 16098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 16114, 16152);

                controlFlowGraph = anonymousFlowGraph;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 16166, 16213);

                f_451_16166_16212(f_451_16179_16203(controlFlowGraph!) == this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(451, 16227, 16239);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(451, 14844, 16250);

                bool
                f_451_15075_15181(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>
                this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                key, out (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion enclosing, int ordinal)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 15075, 15181);
                    return return_v;
                }


                int
                f_451_15460_15488(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 15460, 15488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?[]?
                f_451_15376_15496(ref Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?[]?
                location1, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph[]
                value, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 15376, 15496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_451_15806_15921(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
                body, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                parent, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                enclosing, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.CaptureIdDispenser
                captureIdDispenser, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.Context
                context)
                {
                    var return_v = ControlFlowGraphBuilder.Create((Microsoft.CodeAnalysis.IOperation)body, parent, enclosing, captureIdDispenser, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 15806, 15921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_451_15953_15976(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.OriginalOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 15953, 15976);
                    return return_v;
                }


                int
                f_451_15940_15999(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 15940, 15999);
                    return 0;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_451_16018_16082(ref Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                location1, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                value, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 16018, 16082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_451_16179_16203(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 16179, 16203);
                    return return_v;
                }


                int
                f_451_16166_16212(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 16166, 16212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(451, 14844, 16250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 14844, 16250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ControlFlowGraph()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(451, 963, 16257);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(451, 963, 16257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(451, 963, 16257);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(451, 963, 16257);

        static Microsoft.CodeAnalysis.OperationKind
        f_451_2314_2336(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2314, 2336);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OperationKind
        f_451_2371_2393(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2371, 2393);
            return return_v;
        }


        static int
        f_451_2282_2430(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2282, 2430);
            return 0;
        }


        static int
        f_451_2445_2485(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2445, 2485);
            return 0;
        }


        bool
        f_451_2513_2530_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2513, 2530);
            return return_v;
        }


        static int
        f_451_2500_2531(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2500, 2531);
            return 0;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
        f_451_2559_2578(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2559, 2578);
            return return_v;
        }


        static int
        f_451_2546_2603(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2546, 2603);
            return 0;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
        f_451_2631_2649(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2631, 2649);
            return return_v;
        }


        static int
        f_451_2618_2673(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2618, 2673);
            return 0;
        }


        static int
        f_451_2688_2714(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2688, 2714);
            return 0;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        f_451_2742_2751(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2742, 2751);
            return return_v;
        }


        static int
        f_451_2729_2782(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2729, 2782);
            return 0;
        }


        static int
        f_451_2810_2832(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.FirstBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2810, 2832);
            return return_v;
        }


        static int
        f_451_2797_2838(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2797, 2838);
            return 0;
        }


        static int
        f_451_2866_2887(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.LastBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2866, 2887);
            return return_v;
        }


        static int
        f_451_2853_2909(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2853, 2909);
            return 0;
        }


        bool
        f_451_2937_2962_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 2937, 2962);
            return return_v;
        }


        static int
        f_451_2924_2963(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2924, 2963);
            return 0;
        }


        static int
        f_451_2978_3017(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 2978, 3017);
            return 0;
        }


        static int
        f_451_3045_3068(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.IMethodSymbol, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal)>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 3045, 3068);
            return return_v;
        }


        static int
        f_451_3032_3094(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 3032, 3094);
            return 0;
        }


        static int
        f_451_3109_3180(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 3109, 3180);
            return 0;
        }


        static int
        f_451_3195_3238(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 3195, 3238);
            return 0;
        }


        static Microsoft.CodeAnalysis.MethodKind
        f_451_3358_3375(Microsoft.CodeAnalysis.IMethodSymbol
        this_param)
        {
            var return_v = this_param.MethodKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(451, 3358, 3375);
            return return_v;
        }


        static int
        f_451_3345_3404(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 3345, 3404);
            return 0;
        }


        static bool
        f_451_3436_3473(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.IMethodSymbol, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal)>
        this_param, Microsoft.CodeAnalysis.IMethodSymbol
        key)
        {
            var return_v = this_param.ContainsKey(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 3436, 3473);
            return return_v;
        }


        static int
        f_451_3423_3474(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 3423, 3474);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
        f_451_3297_3311_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(451, 3297, 3311);
            return return_v;
        }

    }
}
