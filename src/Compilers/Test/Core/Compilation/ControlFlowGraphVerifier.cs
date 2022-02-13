// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static class ControlFlowGraphVerifier
    {
        public static (ControlFlowGraph graph, ISymbol associatedSymbol) GetControlFlowGraph(SyntaxNode syntaxNode, SemanticModel model)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25011, 898, 3133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 1051, 1109);

                IOperation
                operationRoot = f_25011_1078_1108(model, syntaxNode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 1261, 1557);

                operationRoot = (DynAbs.Tracing.TraceSender.Conditional_F1(25011, 1277, 1475) || ((f_25011_1277_1295(operationRoot) == OperationKind.Block && (DynAbs.Tracing.TraceSender.Expression_True(25011, 1277, 1475) && (f_25011_1340_1366_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25011_1340_1360(operationRoot), 25011, 1340, 1366)?.Kind) == OperationKind.ConstructorBody || (DynAbs.Tracing.TraceSender.Expression_False(25011, 1340, 1474) || f_25011_1420_1446_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25011_1420_1440(operationRoot), 25011, 1420, 1446)?.Kind) == OperationKind.MethodBody))) && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 1499, 1519)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 1543, 1556))) ? f_25011_1499_1519(operationRoot) : operationRoot;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 1573, 1623);

                f_25011_1573_1622(operationRoot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 1639, 1662);

                ControlFlowGraph
                graph
                = default(ControlFlowGraph);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 1676, 2880);

                switch (operationRoot)
                {

                    case IBlockOperation blockOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 1676, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 1789, 1837);

                        graph = f_25011_1797_1836(blockOperation);
                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 1859, 1865);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 1676, 2880);

                    case IMethodBodyOperation methodBodyOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 1676, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 1953, 2006);

                        graph = f_25011_1961_2005(methodBodyOperation);
                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 2028, 2034);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 1676, 2880);

                    case IConstructorBodyOperation constructorBodyOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 1676, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 2132, 2190);

                        graph = f_25011_2140_2189(constructorBodyOperation);
                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 2212, 2218);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 1676, 2880);

                    case IFieldInitializerOperation fieldInitializerOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 1676, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 2318, 2377);

                        graph = f_25011_2326_2376(fieldInitializerOperation);
                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 2399, 2405);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 1676, 2880);

                    case IPropertyInitializerOperation propertyInitializerOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 1676, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 2511, 2573);

                        graph = f_25011_2519_2572(propertyInitializerOperation);
                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 2595, 2601);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 1676, 2880);

                    case IParameterInitializerOperation parameterInitializerOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 1676, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 2709, 2772);

                        graph = f_25011_2717_2771(parameterInitializerOperation);
                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 2794, 2800);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 1676, 2880);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 1676, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 2850, 2865);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 1676, 2880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 2896, 2924);

                f_25011_2896_2923(graph);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 2938, 2996);

                f_25011_2938_2995(operationRoot, f_25011_2971_2994(graph));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3010, 3077);

                var
                declaredSymbol = f_25011_3031_3076(model, f_25011_3055_3075(operationRoot))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3091, 3122);

                return (graph, declaredSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25011, 898, 3133);

                Microsoft.CodeAnalysis.IOperation?
                f_25011_1078_1108(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetOperation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 1078, 1108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25011_1277_1295(Microsoft.CodeAnalysis.IOperation?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 1277, 1295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_1340_1360(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 1340, 1360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind?
                f_25011_1340_1366_M(Microsoft.CodeAnalysis.OperationKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 1340, 1366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_1420_1440(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 1420, 1440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind?
                f_25011_1420_1446_M(Microsoft.CodeAnalysis.OperationKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 1420, 1446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25011_1499_1519(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 1499, 1519);
                    return return_v;
                }


                int
                f_25011_1573_1622(Microsoft.CodeAnalysis.IOperation
                root)
                {
                    TestOperationVisitor.VerifySubTree(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 1573, 1622);
                    return 0;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_1797_1836(Microsoft.CodeAnalysis.Operations.IBlockOperation
                body)
                {
                    var return_v = ControlFlowGraph.Create(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 1797, 1836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_1961_2005(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
                methodBody)
                {
                    var return_v = ControlFlowGraph.Create(methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 1961, 2005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_2140_2189(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                constructorBody)
                {
                    var return_v = ControlFlowGraph.Create(constructorBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 2140, 2189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_2326_2376(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
                initializer)
                {
                    var return_v = ControlFlowGraph.Create(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 2326, 2376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_2519_2572(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
                initializer)
                {
                    var return_v = ControlFlowGraph.Create(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 2519, 2572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_2717_2771(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
                initializer)
                {
                    var return_v = ControlFlowGraph.Create(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 2717, 2771);
                    return return_v;
                }


                bool
                f_25011_2896_2923(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 2896, 2923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25011_2971_2994(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.OriginalOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 2971, 2994);
                    return return_v;
                }


                bool
                f_25011_2938_2995(Microsoft.CodeAnalysis.IOperation
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 2938, 2995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25011_3055_3075(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 3055, 3075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25011_3031_3076(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                declaration)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 3031, 3076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 898, 3133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 898, 3133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void VerifyGraph(Compilation compilation, string expectedFlowGraph, ControlFlowGraph graph, ISymbol associatedSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25011, 3145, 4106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3301, 3374);

                var
                actualFlowGraph = f_25011_3323_3373(compilation, graph, associatedSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3388, 3453);

                f_25011_3388_3452(expectedFlowGraph, actualFlowGraph);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3842, 3917);

                var
                reachabilityVector = f_25011_3867_3916(graph)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3940, 3945);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3931, 4095) || true) && (i < graph.Blocks.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 3972, 3975)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 3931, 4095))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 3931, 4095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4009, 4080);

                        f_25011_4009_4079(f_25011_4028_4055(f_25011_4028_4040(graph)[i]), reachabilityVector[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25011, 3145, 4106);

                string
                f_25011_3323_3373(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                graph, Microsoft.CodeAnalysis.ISymbol
                associatedSymbol)
                {
                    var return_v = GetFlowGraph(compilation, graph, associatedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 3323, 3373);
                    return return_v;
                }


                bool
                f_25011_3388_3452(string
                expectedOperationTree, string
                actualOperationTree)
                {
                    var return_v = OperationTreeVerifier.Verify(expectedOperationTree, actualOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 3388, 3452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_25011_3867_3916(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                controlFlowGraph)
                {
                    var return_v = BasicBlockReachabilityDataFlowAnalyzer.Run(controlFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 3867, 3916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
                f_25011_4028_4040(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Blocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 4028, 4040);
                    return return_v;
                }


                bool
                f_25011_4028_4055(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.IsReachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 4028, 4055);
                    return return_v;
                }


                bool
                f_25011_4009_4079(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 4009, 4079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 3145, 4106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 3145, 4106);
            }
        }

        public static string GetFlowGraph(Compilation compilation, ControlFlowGraph graph, ISymbol associatedSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25011, 4118, 4573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4251, 4319);

                var
                pooledBuilder = f_25011_4271_4318()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4333, 4375);

                var
                stringBuilder = pooledBuilder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4391, 4507);

                f_25011_4391_4506(pooledBuilder.Builder, compilation, graph, enclosing: null, idSuffix: "", indent: 0, associatedSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4523, 4562);

                return f_25011_4530_4561(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25011, 4118, 4573);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_25011_4271_4318()
                {
                    var return_v = PooledObjects.PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 4271, 4318);
                    return return_v;
                }


                int
                f_25011_4391_4506(System.Text.StringBuilder
                stringBuilder, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                graph, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                enclosing, string
                idSuffix, int
                indent, Microsoft.CodeAnalysis.ISymbol
                associatedSymbol)
                {
                    GetFlowGraph(stringBuilder, compilation, graph, enclosing: enclosing, idSuffix: idSuffix, indent: indent, associatedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 4391, 4506);
                    return 0;
                }


                string
                f_25011_4530_4561(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 4530, 4561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 4118, 4573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 4118, 4573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetFlowGraph(System.Text.StringBuilder stringBuilder, Compilation compilation, ControlFlowGraph graph,
                                                 ControlFlowRegion enclosing, string idSuffix, int indent, ISymbol associatedSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25011, 4585, 84403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4858, 4907);

                ImmutableArray<BasicBlock>
                blocks = f_25011_4894_4906(graph)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4923, 4968);

                var
                visitor = TestOperationVisitor.Singleton
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 4982, 5027);

                ControlFlowRegion
                currentRegion = f_25011_5016_5026(graph)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5041, 5087);

                bool
                lastPrintedBlockIsInCurrentRegion = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5101, 5171);

                PooledDictionary<ControlFlowRegion, int>
                regionMap = f_25011_5154_5170()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5185, 5273);

                var
                localFunctionsMap = f_25011_5209_5272()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5287, 5397);

                var
                anonymousFunctionsMap = f_25011_5315_5396()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5411, 5481);

                var
                referencedLocalsAndMethods = f_25011_5444_5480()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5495, 5561);

                var
                referencedCaptureIds = f_25011_5522_5560()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5586, 5591);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5577, 16020) || true) && (i < blocks.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5612, 5615)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 5577, 16020))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 5577, 16020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5649, 5671);

                        var
                        block = blocks[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5691, 5728);

                        f_25011_5691_5727(i, f_25011_5713_5726(block));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5748, 8134);

                        switch (f_25011_5756_5766(block))
                        {

                            case BasicBlockKind.Block:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 5748, 8134);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5860, 5888);

                                f_25011_5860_5887(0, i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 5914, 5958);

                                f_25011_5914_5957(blocks.Length - 1, i);
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 5984, 5990);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 5748, 8134);

                            case BasicBlockKind.Entry:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 5748, 8134);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6066, 6091);

                                f_25011_6066_6090(0, i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6117, 6154);

                                f_25011_6117_6153(f_25011_6136_6152(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6180, 6219);

                                f_25011_6180_6218(f_25011_6199_6217(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6245, 6282);

                                f_25011_6245_6281(f_25011_6263_6280(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6308, 6357);

                                f_25011_6308_6356(f_25011_6329_6355(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6383, 6444);

                                f_25011_6383_6443(f_25011_6404_6442(f_25011_6404_6430(block)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6470, 6516);

                                f_25011_6470_6515(f_25011_6488_6514(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6542, 6587);

                                f_25011_6542_6586(f_25011_6560_6570(graph), currentRegion);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6613, 6669);

                                f_25011_6613_6668(currentRegion, f_25011_6646_6667(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6695, 6750);

                                f_25011_6695_6749(0, f_25011_6717_6748(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6776, 6836);

                                f_25011_6776_6835(enclosing, f_25011_6805_6834(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6862, 6909);

                                f_25011_6862_6908(f_25011_6880_6907(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 6935, 6976);

                                f_25011_6935_6975(f_25011_6954_6974(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7002, 7051);

                                f_25011_7002_7050(f_25011_7021_7049(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7077, 7122);

                                f_25011_7077_7121(f_25011_7096_7120(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7148, 7215);

                                f_25011_7148_7214(ControlFlowRegionKind.Root, f_25011_7195_7213(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7241, 7278);

                                f_25011_7241_7277(f_25011_7259_7276(block));
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 7304, 7310);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 5748, 8134);

                            case BasicBlockKind.Exit:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 5748, 8134);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7385, 7426);

                                f_25011_7385_7425(blocks.Length - 1, i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7452, 7489);

                                f_25011_7452_7488(f_25011_7471_7487(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7515, 7561);

                                f_25011_7515_7560(f_25011_7533_7559(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7587, 7633);

                                f_25011_7587_7632(f_25011_7605_7631(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7659, 7696);

                                f_25011_7659_7695(f_25011_7677_7694(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7722, 7767);

                                f_25011_7722_7766(f_25011_7740_7750(graph), currentRegion);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7793, 7849);

                                f_25011_7793_7848(currentRegion, f_25011_7826_7847(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 7875, 7929);

                                f_25011_7875_7928(i, f_25011_7897_7927(currentRegion));
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 7955, 7961);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 5748, 8134);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 5748, 8134);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8019, 8083);

                                f_25011_8019_8082(true, $"Unexpected block kind {f_25011_8069_8079(block)}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 8109, 8115);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 5748, 8134);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8154, 8308) || true) && (f_25011_8158_8179(block) != currentRegion)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 8154, 8308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8238, 8289);

                            f_25011_8238_8288(f_25011_8251_8272(block), f_25011_8274_8287(block));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 8154, 8308);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8328, 8454) || true) && (!lastPrintedBlockIsInCurrentRegion)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 8328, 8454);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8408, 8435);

                            f_25011_8408_8434(stringBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 8328, 8454);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8474, 8576);

                        f_25011_8474_8575($"Block[{f_25011_8494_8511(block)}] - {f_25011_8517_8527(block)}{((DynAbs.Tracing.TraceSender.Conditional_F1(25011, 8530, 8547) || ((f_25011_8530_8547(block) && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 8550, 8552)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 8555, 8571))) ? "" : " [UnReachable]")}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8596, 8634);

                        var
                        predecessors = f_25011_8615_8633(block)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8654, 11170) || true) && (f_25011_8658_8679_M(!predecessors.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 8654, 11170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8721, 8736);

                            f_25011_8721_8735();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8758, 8800);

                            f_25011_8758_8799(stringBuilder, "    Predecessors:");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8822, 8858);

                            int
                            previousPredecessorOrdinal = -1
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8889, 8909);
                                for (var
            predecessorIndex = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8880, 10943) || true) && (predecessorIndex < predecessors.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 8951, 8969)
            , predecessorIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 8880, 10943))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 8880, 10943);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9019, 9074);

                                    var
                                    predecessorBranch = predecessors[predecessorIndex]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9100, 9156);

                                    f_25011_9100_9155(block, f_25011_9125_9154(predecessorBranch));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9182, 9225);

                                    var
                                    predecessor = f_25011_9200_9224(predecessorBranch)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9251, 9319);

                                    f_25011_9251_9318(previousPredecessorOrdinal < f_25011_9298_9317(predecessor));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9345, 9394);

                                    previousPredecessorOrdinal = f_25011_9374_9393(predecessor);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9420, 9480);

                                    f_25011_9420_9479(blocks[f_25011_9445_9464(predecessor)], predecessor);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9508, 10003) || true) && (f_25011_9512_9552(predecessorBranch))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 9508, 10003);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9610, 9681);

                                        f_25011_9610_9680(f_25011_9628_9660(predecessor), predecessorBranch);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9711, 9791);

                                        f_25011_9711_9790(ControlFlowConditionKind.None, f_25011_9764_9789(predecessor));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 9508, 10003);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 9508, 10003);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 9905, 9976);

                                        f_25011_9905_9975(f_25011_9923_9955(predecessor), predecessorBranch);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 9508, 10003);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10031, 10084);

                                    f_25011_10031_10083(
                                                            stringBuilder, $" [{f_25011_10057_10080(predecessor)}");

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10112, 10866) || true) && (predecessorIndex < predecessors.Length - 1 && (DynAbs.Tracing.TraceSender.Expression_True(25011, 10116, 10218) && f_25011_10162_10203(predecessors[predecessorIndex + 1]) == predecessor))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 10112, 10866);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10398, 10458);

                                        f_25011_10398_10457(f_25011_10416_10456(predecessorBranch));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10488, 10507);

                                        predecessorIndex++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10537, 10588);

                                        predecessorBranch = predecessors[predecessorIndex];
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10618, 10689);

                                        f_25011_10618_10688(f_25011_10636_10668(predecessor), predecessorBranch);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10719, 10780);

                                        f_25011_10719_10779(f_25011_10738_10778(predecessorBranch));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10812, 10839);

                                        f_25011_10812_10838(
                                                                    stringBuilder, "*2");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 10112, 10866);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10894, 10920);

                                    f_25011_10894_10919(
                                                            stringBuilder, "]");
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 2064);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 2064);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 10967, 10994);

                            f_25011_10967_10993(
                                                stringBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 8654, 11170);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 8654, 11170);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11036, 11170) || true) && (f_25011_11040_11050(block) != BasicBlockKind.Entry)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 11036, 11170);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11116, 11151);

                                f_25011_11116_11150("    Predecessors (0)");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 11036, 11170);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 8654, 11170);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11190, 11224);

                        var
                        statements = f_25011_11207_11223(block)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11242, 11294);

                        f_25011_11242_11293($"    Statements ({statements.Length})");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11312, 11509);
                            foreach (var statement in f_25011_11338_11348_I(statements))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 11312, 11509);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11390, 11414);

                                f_25011_11390_11413(statement);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11436, 11490);

                                f_25011_11436_11489(stringBuilder, f_25011_11461_11488(statement));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 11312, 11509);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 198);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 198);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11529, 11594);

                        ControlFlowBranch
                        conditionalBranch = f_25011_11567_11593(block)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11614, 13480) || true) && (f_25011_11618_11637(block) != ControlFlowConditionKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 11614, 13480);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11712, 11752);

                            f_25011_11712_11751(conditionalBranch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11774, 11834);

                            f_25011_11774_11833(f_25011_11792_11832(conditionalBranch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11858, 11909);

                            f_25011_11858_11908(block, f_25011_11883_11907(conditionalBranch));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 11931, 12141) || true) && (f_25011_11935_11964(conditionalBranch) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 11931, 12141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12022, 12118);

                                f_25011_12022_12117(blocks[f_25011_12047_12084(f_25011_12047_12076(conditionalBranch))], f_25011_12087_12116(conditionalBranch));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 11931, 12141);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12165, 12251);

                            f_25011_12165_12250(ControlFlowBranchSemantics.Return, f_25011_12222_12249(conditionalBranch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12273, 12358);

                            f_25011_12273_12357(ControlFlowBranchSemantics.Throw, f_25011_12329_12356(conditionalBranch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12380, 12487);

                            f_25011_12380_12486(ControlFlowBranchSemantics.StructuredExceptionHandling, f_25011_12458_12485(conditionalBranch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12511, 12648);

                            f_25011_12511_12647(f_25011_12529_12548(block) == ControlFlowConditionKind.WhenTrue || (DynAbs.Tracing.TraceSender.Expression_False(25011, 12529, 12646) || f_25011_12589_12608(block) == ControlFlowConditionKind.WhenFalse));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12670, 12766);

                            string
                            jumpIfTrue = (DynAbs.Tracing.TraceSender.Conditional_F1(25011, 12690, 12746) || ((f_25011_12690_12709(block) == ControlFlowConditionKind.WhenTrue && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 12749, 12755)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 12758, 12765))) ? "True" : "False"
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12788, 12916);

                            f_25011_12788_12915($"    Jump if {jumpIfTrue} ({f_25011_12828_12855(conditionalBranch)}) to Block[{f_25011_12868_12911(ref conditionalBranch)}]");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12940, 12977);

                            IOperation
                            value = f_25011_12959_12976(block)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 12999, 13027);

                            f_25011_12999_13026(value);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13049, 13069);

                            f_25011_13049_13068(value);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13091, 13137);

                            f_25011_13091_13136(stringBuilder, f_25011_13112_13135(value));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13159, 13200);

                            f_25011_13159_13199(block, conditionalBranch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13222, 13249);

                            f_25011_13222_13248(stringBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 11614, 13480);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 11614, 13480);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13331, 13368);

                            f_25011_13331_13367(conditionalBranch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13390, 13461);

                            f_25011_13390_13460(ControlFlowConditionKind.None, f_25011_13440_13459(block));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 11614, 13480);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13500, 13558);

                        ControlFlowBranch
                        nextBranch = f_25011_13531_13557(block)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13578, 15671) || true) && (f_25011_13582_13592(block) == BasicBlockKind.Exit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 13578, 15671);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13657, 13687);

                            f_25011_13657_13686(nextBranch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13709, 13746);

                            f_25011_13709_13745(f_25011_13727_13744(block));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 13578, 15671);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 13578, 15671);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13828, 13861);

                            f_25011_13828_13860(nextBranch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13883, 13937);

                            f_25011_13883_13936(f_25011_13902_13935(nextBranch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 13961, 14005);

                            f_25011_13961_14004(block, f_25011_13986_14003(nextBranch));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14027, 14216) || true) && (f_25011_14031_14053(nextBranch) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 14027, 14216);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14111, 14193);

                                f_25011_14111_14192(blocks[f_25011_14136_14166(f_25011_14136_14158(nextBranch))], f_25011_14169_14191(nextBranch));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 14027, 14216);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14240, 14704) || true) && (f_25011_14244_14264(nextBranch) == ControlFlowBranchSemantics.StructuredExceptionHandling)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 14240, 14704);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14372, 14414);

                                f_25011_14372_14413(f_25011_14390_14412(nextBranch));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14440, 14514);

                                f_25011_14440_14513(f_25011_14459_14497(f_25011_14459_14480(block)), f_25011_14499_14512(block));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14540, 14681);

                                f_25011_14540_14680(f_25011_14558_14584(f_25011_14558_14579(block)) == ControlFlowRegionKind.Filter || (DynAbs.Tracing.TraceSender.Expression_False(25011, 14558, 14679) || f_25011_14620_14646(f_25011_14620_14641(block)) == ControlFlowRegionKind.Finally));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 14240, 14704);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14728, 14823);

                            f_25011_14728_14822($"    Next ({f_25011_14752_14772(nextBranch)}) Block[{f_25011_14782_14818(ref nextBranch)}]");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14845, 14944);

                            IOperation
                            value = (DynAbs.Tracing.TraceSender.Conditional_F1(25011, 14864, 14916) || ((f_25011_14864_14883(block) == ControlFlowConditionKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 14919, 14936)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 14939, 14943))) ? f_25011_14919_14936(block) : null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 14968, 15594) || true) && (value != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 14968, 15594);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15035, 15172);

                                f_25011_15035_15171(ControlFlowBranchSemantics.Return == f_25011_15090_15110(nextBranch) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 15053, 15170) || ControlFlowBranchSemantics.Throw == f_25011_15150_15170(nextBranch)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15198, 15218);

                                f_25011_15198_15217(value);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15244, 15290);

                                f_25011_15244_15289(stringBuilder, f_25011_15265_15288(value));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 14968, 15594);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 14968, 15594);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15388, 15467);

                                f_25011_15388_15466(ControlFlowBranchSemantics.Return, f_25011_15445_15465(nextBranch));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15493, 15571);

                                f_25011_15493_15570(ControlFlowBranchSemantics.Throw, f_25011_15549_15569(nextBranch));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 14968, 15594);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15618, 15652);

                            f_25011_15618_15651(block, nextBranch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 13578, 15671);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15693, 16005) || true) && (f_25011_15697_15727(currentRegion) == f_25011_15731_15744(block) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 15697, 15770) && i != blocks.Length - 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 15693, 16005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15812, 15863);

                            f_25011_15812_15862(f_25011_15825_15846(block), f_25011_15848_15861(block));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 15693, 16005);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 15693, 16005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 15945, 15986);

                            lastPrintedBlockIsInCurrentRegion = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 15693, 16005);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 10444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 10444);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16036, 16399);
                    foreach (IMethodSymbol m in f_25011_16064_16084_I(f_25011_16064_16084(graph)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 16036, 16399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16118, 16160);

                        ControlFlowGraph
                        g = f_25011_16139_16159(localFunctionsMap, m)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16178, 16242);

                        f_25011_16178_16241(g, f_25011_16199_16240(graph, m));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16260, 16331);

                        f_25011_16260_16330(g, f_25011_16281_16329(graph, m));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16349, 16384);

                        f_25011_16349_16383(graph, f_25011_16374_16382(g));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 16036, 16399);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16415, 16488);

                f_25011_16415_16487(graph.LocalFunctions.Length, f_25011_16463_16486(localFunctionsMap));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16504, 16910);
                    foreach (KeyValuePair<IFlowAnonymousFunctionOperation, ControlFlowGraph> pair in f_25011_16585_16606_I(anonymousFunctionsMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 16504, 16910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16640, 16724);

                        f_25011_16640_16723(pair.Value, f_25011_16670_16722(graph, pair.Key));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16742, 16833);

                        f_25011_16742_16832(pair.Value, f_25011_16772_16831(graph, pair.Key));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16851, 16895);

                        f_25011_16851_16894(graph, f_25011_16876_16893(pair.Value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 16504, 16910);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16926, 16960);

                bool
                doCaptureVerification = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 16976, 17846) || true) && (f_25011_16980_17012(f_25011_16980_17003(graph)) == LanguageNames.VisualBasic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 16976, 17846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 17075, 17159);

                    var
                    model = f_25011_17087_17158(compilation, f_25011_17116_17157(f_25011_17116_17146(f_25011_17116_17139(graph))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 17177, 17831) || true) && (f_25011_17181_17238(model, f_25011_17202_17237(f_25011_17202_17232(f_25011_17202_17225(graph)))).
                                            Any(d => d.Code == (int)VisualBasic.ERRID.ERR_GotoIntoWith ||
                                                     d.Code == (int)VisualBasic.ERRID.ERR_GotoIntoFor ||
                                                     d.Code == (int)VisualBasic.ERRID.ERR_GotoIntoSyncLock ||
                                                     d.Code == (int)VisualBasic.ERRID.ERR_GotoIntoUsing))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 17177, 17831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 17782, 17812);

                        doCaptureVerification = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 17177, 17831);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 16976, 17846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 17862, 17919);

                Func<string>
                finalGraph = () => stringBuilder.ToString()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 17933, 18034) || true) && (doCaptureVerification)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 17933, 18034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 17992, 18019);

                    f_25011_17992_18018(finalGraph);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 17933, 18034);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18050, 18175);
                    foreach (var block in f_25011_18072_18078_I(blocks))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 18050, 18175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18112, 18160);

                        f_25011_18112_18159(block, finalGraph);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 18050, 18175);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18191, 18208);

                f_25011_18191_18207(
                            regionMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18222, 18247);

                f_25011_18222_18246(localFunctionsMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18261, 18290);

                f_25011_18261_18289(anonymousFunctionsMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18304, 18338);

                f_25011_18304_18337(referencedLocalsAndMethods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18352, 18380);

                f_25011_18352_18379(referencedCaptureIds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18394, 18401);

                return;

                void verifyCaptures(Func<string> finalGraph)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 18417, 22184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18494, 18552);

                        var
                        longLivedIds = f_25011_18513_18551()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18570, 18629);

                        var
                        referencedIds = f_25011_18590_18628()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18647, 18752);

                        var
                        entryStates = f_25011_18665_18751(blocks.Length, fillWithValue: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18770, 18830);

                        var
                        regions = f_25011_18784_18829()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18859, 18864);

                            for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18850, 21871) || true) && (i < blocks.Length - 1)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18889, 18892)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 18850, 21871))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 18850, 21871);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18934, 18963);

                                BasicBlock
                                block = blocks[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 18985, 19082);

                                PooledHashSet<CaptureId>
                                currentState = f_25011_19025_19039(entryStates, i) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>(25011, 19025, 19081) ?? f_25011_19043_19081())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 19104, 19126);

                                entryStates[i] = null;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 19150, 20069);
                                    foreach (ControlFlowBranch predecessor in f_25011_19192_19210_I(f_25011_19192_19210(block)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 19150, 20069);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 19260, 20046) || true) && (f_25011_19264_19290(f_25011_19264_19282(predecessor)) >= i)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 19260, 20046);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 19353, 20019);
                                                foreach (ControlFlowRegion region in f_25011_19390_19417_I(f_25011_19390_19417(predecessor)))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 19353, 20019);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 19483, 19988) || true) && (f_25011_19487_19511(region) != f_25011_19515_19528(block))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 19483, 19988);
                                                        try
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 19602, 19953);
                                                            foreach (CaptureId id in f_25011_19627_19644_I(f_25011_19627_19644(region)))
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 19602, 19953);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 19726, 19914);

                                                                f_25011_19726_19913(f_25011_19746_19771(currentState, id), $"Backward branch from [{f_25011_19798_19828(f_25011_19809_19827(predecessor))}] to [{f_25011_19836_19853(block)}] before capture [{id.Value}] is initialized.", finalGraph);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 19602, 19953);
                                                            }
                                                        }
                                                        catch (System.Exception)
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 352);
                                                            throw;
                                                        }
                                                        finally
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 352);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 19483, 19988);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 19353, 20019);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 667);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 667);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 19260, 20046);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 19150, 20069);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 920);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 920);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20102, 20107);

                                    for (var
                j = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20093, 20906) || true) && (j < block.Operations.Length)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20138, 20141)
                , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 20093, 20906))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 20093, 20906);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20191, 20227);

                                        var
                                        operation = f_25011_20207_20223(block)[j]
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20253, 20883) || true) && (operation is IFlowCaptureOperation capture)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 20253, 20883);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20357, 20461);

                                            f_25011_20357_20460(currentState, f_25011_20395_20408(capture), block, j, longLivedIds, referencedIds, finalGraph);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20491, 20642);

                                            f_25011_20491_20641(f_25011_20511_20539(currentState, f_25011_20528_20538(capture)), $"Operation [{j}] in [{f_25011_20564_20581(block)}] re-initialized capture [{capture.Id.Value}]", finalGraph);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 20253, 20883);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 20253, 20883);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20756, 20856);

                                            f_25011_20756_20855(currentState, operation, block, j, longLivedIds, referencedIds, finalGraph);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 20253, 20883);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 814);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 814);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 20930, 21399) || true) && (f_25011_20934_20951(block) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 20930, 21399);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21009, 21139);

                                    f_25011_21009_21138(currentState, f_25011_21047_21064(block), block, block.Operations.Length, longLivedIds, referencedIds, finalGraph);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21167, 21376) || true) && (f_25011_21171_21197(block) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 21167, 21376);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21263, 21349);

                                        f_25011_21263_21348(entryStates, f_25011_21307_21333(block), currentState);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 21167, 21376);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 20930, 21399);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21423, 21509);

                                f_25011_21423_21508(entryStates, f_25011_21467_21493(block), currentState);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21533, 21709) || true) && (blocks[i + 1].Predecessors.IsEmpty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 21533, 21709);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21621, 21686);

                                    f_25011_21621_21685(entryStates, blocks[i + 1], currentState);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 21533, 21709);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21733, 21808);

                                f_25011_21733_21807(block, longLivedIds, referencedIds, regions, finalGraph);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21832, 21852);

                                f_25011_21832_21851(
                                                    currentState);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 3022);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 3022);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21891, 22020);
                            foreach (PooledHashSet<CaptureId> state in f_25011_21934_21945_I(entryStates))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 21891, 22020);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 21987, 22001);

                                f_25011_21993_22000(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(state, 25011, 21987, 22000));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 21891, 22020);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 130);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 130);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22040, 22059);

                        f_25011_22040_22058(
                                        entryStates);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22077, 22097);

                        f_25011_22077_22096(longLivedIds);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22115, 22136);

                        f_25011_22115_22135(referencedIds);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22154, 22169);

                        f_25011_22154_22168(regions);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 18417, 22184);

                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_18513_18551()
                        {
                            var return_v = PooledHashSet<CaptureId>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18513, 18551);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_18590_18628()
                        {
                            var return_v = PooledHashSet<CaptureId>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18590, 18628);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        f_25011_18665_18751(int
                        capacity, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        fillWithValue)
                        {
                            var return_v = ArrayBuilder<PooledHashSet<CaptureId>>.GetInstance(capacity, fillWithValue: fillWithValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18665, 18751);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_18784_18829()
                        {
                            var return_v = ArrayBuilder<ControlFlowRegion>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18784, 18829);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_19025_19039(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19025, 19039);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_19043_19081()
                        {
                            var return_v = PooledHashSet<CaptureId>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19043, 19081);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                        f_25011_19192_19210(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Predecessors;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19192, 19210);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_19264_19282(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19264, 19282);
                            return return_v;
                        }


                        int
                        f_25011_19264_19290(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19264, 19290);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_19390_19417(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.EnteringRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19390, 19417);
                            return return_v;
                        }


                        int
                        f_25011_19487_19511(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19487, 19511);
                            return return_v;
                        }


                        int
                        f_25011_19515_19528(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19515, 19528);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_19627_19644(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.CaptureIds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19627, 19644);
                            return return_v;
                        }


                        bool
                        f_25011_19746_19771(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19746, 19771);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_19809_19827(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 19809, 19827);
                            return return_v;
                        }


                        string
                        f_25011_19798_19828(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19798, 19828);
                            return return_v;
                        }


                        string
                        f_25011_19836_19853(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19836, 19853);
                            return return_v;
                        }


                        int
                        f_25011_19726_19913(bool
                        value, string
                        message, System.Func<string>
                        finalGraph)
                        {
                            AssertTrueWithGraph(value, message, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19726, 19913);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_19627_19644_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19627, 19644);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_19390_19417_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19390, 19417);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                        f_25011_19192_19210_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 19192, 19210);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        f_25011_20207_20223(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Operations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 20207, 20223);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_20395_20408(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 20395, 20408);
                            return return_v;
                        }


                        int
                        f_25011_20357_20460(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state, Microsoft.CodeAnalysis.IOperation
                        operation, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, int
                        operationIndex, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        longLivedIds, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        referencedIds, System.Func<string>
                        finalGraph)
                        {
                            assertCaptureReferences(state, operation, block, operationIndex, longLivedIds, referencedIds, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 20357, 20460);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        f_25011_20528_20538(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 20528, 20538);
                            return return_v;
                        }


                        bool
                        f_25011_20511_20539(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 20511, 20539);
                            return return_v;
                        }


                        string
                        f_25011_20564_20581(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 20564, 20581);
                            return return_v;
                        }


                        int
                        f_25011_20491_20641(bool
                        value, string
                        message, System.Func<string>
                        finalGraph)
                        {
                            AssertTrueWithGraph(value, message, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 20491, 20641);
                            return 0;
                        }


                        int
                        f_25011_20756_20855(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state, Microsoft.CodeAnalysis.IOperation
                        operation, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, int
                        operationIndex, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        longLivedIds, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        referencedIds, System.Func<string>
                        finalGraph)
                        {
                            assertCaptureReferences(state, operation, block, operationIndex, longLivedIds, referencedIds, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 20756, 20855);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_20934_20951(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 20934, 20951);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_21047_21064(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 21047, 21064);
                            return return_v;
                        }


                        int
                        f_25011_21009_21138(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state, Microsoft.CodeAnalysis.IOperation
                        operation, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, int
                        operationIndex, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        longLivedIds, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        referencedIds, System.Func<string>
                        finalGraph)
                        {
                            assertCaptureReferences(state, operation, block, operationIndex, longLivedIds, referencedIds, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21009, 21138);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                        f_25011_21171_21197(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.ConditionalSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 21171, 21197);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        f_25011_21307_21333(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.ConditionalSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 21307, 21333);
                            return return_v;
                        }


                        int
                        f_25011_21263_21348(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        entryStates, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        branch, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state)
                        {
                            adjustEntryStateForDestination(entryStates, branch, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21263, 21348);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                        f_25011_21467_21493(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.FallThroughSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 21467, 21493);
                            return return_v;
                        }


                        int
                        f_25011_21423_21508(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        entryStates, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                        branch, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state)
                        {
                            adjustEntryStateForDestination(entryStates, branch, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21423, 21508);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_21621_21685(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        entryStates, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state)
                        {
                            var return_v = adjustAndGetEntryState(entryStates, block, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21621, 21685);
                            return return_v;
                        }


                        int
                        f_25011_21733_21807(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        longLivedIds, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        referencedIds, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        regions, System.Func<string>
                        finalGraph)
                        {
                            verifyLeftRegions(block, longLivedIds, referencedIds, regions, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21733, 21807);
                            return 0;
                        }


                        int
                        f_25011_21832_21851(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21832, 21851);
                            return 0;
                        }


                        int
                        f_25011_21993_22000(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            this_param?.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21993, 22000);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        f_25011_21934_21945_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 21934, 21945);
                            return return_v;
                        }


                        int
                        f_25011_22040_22058(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22040, 22058);
                            return 0;
                        }


                        int
                        f_25011_22077_22096(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22077, 22096);
                            return 0;
                        }


                        int
                        f_25011_22115_22135(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22115, 22135);
                            return 0;
                        }


                        int
                        f_25011_22154_22168(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22154, 22168);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 18417, 22184);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 18417, 22184);
                    }
                }

                void verifyLeftRegions(BasicBlock block, PooledHashSet<CaptureId> longLivedIds, PooledHashSet<CaptureId> referencedIds, ArrayBuilder<ControlFlowRegion> regions, Func<string> finalGraph)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 22200, 26127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22418, 22434);

                        f_25011_22418_22433(regions);

                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22477, 22526);

                            ControlFlowRegion
                            region = f_25011_22504_22525(block)
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22550, 22748) || true) && (f_25011_22557_22580(region) == f_25011_22584_22597(block))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 22550, 22748);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22647, 22667);

                                    f_25011_22647_22666(regions, region);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22693, 22725);

                                    region = f_25011_22702_22724(region);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 22550, 22748);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 22550, 22748);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 22550, 22748);
                            }
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22787, 23052) || true) && (f_25011_22791_22817(block) != null && (DynAbs.Tracing.TraceSender.Expression_True(25011, 22791, 22893) && f_25011_22829_22855(block).LeavingRegions.Length > f_25011_22880_22893(regions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 22787, 23052);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22935, 22951);

                            f_25011_22935_22950(regions);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 22973, 23033);

                            f_25011_22973_23032(regions, f_25011_22990_23031(f_25011_22990_23016(block)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 22787, 23052);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23072, 23299) || true) && (f_25011_23076_23102(block).LeavingRegions.Length > f_25011_23127_23140(regions))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 23072, 23299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23182, 23198);

                            f_25011_23182_23197(regions);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23220, 23280);

                            f_25011_23220_23279(regions, f_25011_23237_23278(f_25011_23237_23263(block)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 23072, 23299);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23319, 26112) || true) && (f_25011_23323_23336(regions) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 23319, 26112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23382, 23414);

                            IOperation
                            lastOperation = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23445, 23462);
                                for (int
            i = f_25011_23449_23462(block)
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23436, 23650) || true) && (i > 0 && (DynAbs.Tracing.TraceSender.Expression_True(25011, 23464, 23494) && lastOperation == null))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23496, 23499)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 23436, 23650))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 23436, 23650);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23549, 23627);

                                    lastOperation = f_25011_23565_23586(blocks[i]) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.IOperation?>(25011, 23565, 23626) ?? blocks[i].Operations.LastOrDefault());
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 215);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 215);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23674, 23745);

                            var
                            referencedInLastOperation = f_25011_23706_23744()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23769, 24124) || true) && (lastOperation != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 23769, 24124);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 23844, 24101);
                                    foreach (IFlowCaptureReferenceOperation reference in f_25011_23897_23972_I(f_25011_23897_23972(f_25011_23897_23931(lastOperation))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 23844, 24101);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 24030, 24074);

                                        f_25011_24030_24073(referencedInLastOperation, f_25011_24060_24072(reference));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 23844, 24101);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 258);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 258);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 23769, 24124);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 24148, 26036);
                                foreach (ControlFlowRegion region in f_25011_24185_24192_I(regions))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 24148, 26036);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 24242, 26013);
                                        foreach (CaptureId id in f_25011_24267_24284_I(f_25011_24267_24284(region)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 24242, 26013);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 24342, 25222) || true) && (f_25011_24346_24384(referencedInLastOperation, id) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 24446) || f_25011_24421_24446(longLivedIds, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 24539) || f_25011_24483_24539(region, block, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 24623) || f_25011_24576_24623(region, block, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 24700) || f_25011_24660_24700(region, block, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 24782) || f_25011_24737_24782(region, block, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 24875) || f_25011_24819_24875(region, block, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 24990) || f_25011_24912_24990(lastOperation, region, block, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 24346, 25116) || (f_25011_25028_25054(referencedIds, id) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 25028, 25115) && f_25011_25058_25115(lastOperation, region, block, id)))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 24342, 25222);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 25182, 25191);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 24342, 25222);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 25254, 25434) || true) && (f_25011_25258_25281(region) != f_25011_25285_25298(block) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 25258, 25328) && f_25011_25302_25328(referencedIds, id)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 25254, 25434);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 25394, 25403);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 25254, 25434);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 25466, 25624);

                                            IFlowCaptureReferenceOperation[]
                                            referencesAfter = f_25011_25517_25623(f_25011_25517_25613(f_25011_25517_25585(region, f_25011_25567_25580(block) + 1), r => r.Id.Equals(id)))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 25656, 25986);

                                            f_25011_25656_25985(f_25011_25676_25698(referencesAfter) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(25011, 25676, 25816) && f_25011_25747_25816(referencesAfter, r => isLongLivedCaptureReferenceSyntax(r.Syntax))), $"Capture [{id.Value}] is not used in region [{f_25011_25898_25917(region)}] before leaving it after block [{f_25011_25952_25969(block)}]", finalGraph);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 24242, 26013);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1772);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1772);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 24148, 26036);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1889);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1889);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26060, 26093);

                            f_25011_26060_26092(
                                                referencedInLastOperation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 23319, 26112);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 22200, 26127);

                        int
                        f_25011_22418_22433(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param)
                        {
                            this_param.Clear();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22418, 22433);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_22504_22525(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22504, 22525);
                            return return_v;
                        }


                        int
                        f_25011_22557_22580(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.LastBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22557, 22580);
                            return return_v;
                        }


                        int
                        f_25011_22584_22597(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22584, 22597);
                            return return_v;
                        }


                        int
                        f_25011_22647_22666(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22647, 22666);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_22702_22724(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22702, 22724);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                        f_25011_22791_22817(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.ConditionalSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22791, 22817);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        f_25011_22829_22855(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.ConditionalSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22829, 22855);
                            return return_v;
                        }


                        int
                        f_25011_22880_22893(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22880, 22893);
                            return return_v;
                        }


                        int
                        f_25011_22935_22950(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param)
                        {
                            this_param.Clear();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22935, 22950);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        f_25011_22990_23016(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.ConditionalSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22990, 23016);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_22990_23031(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.LeavingRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 22990, 23031);
                            return return_v;
                        }


                        int
                        f_25011_22973_23032(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        items)
                        {
                            this_param.AddRange(items);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 22973, 23032);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                        f_25011_23076_23102(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.FallThroughSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 23076, 23102);
                            return return_v;
                        }


                        int
                        f_25011_23127_23140(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 23127, 23140);
                            return return_v;
                        }


                        int
                        f_25011_23182_23197(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param)
                        {
                            this_param.Clear();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 23182, 23197);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        f_25011_23237_23263(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.FallThroughSuccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 23237, 23263);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_23237_23278(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.LeavingRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 23237, 23278);
                            return return_v;
                        }


                        int
                        f_25011_23220_23279(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        items)
                        {
                            this_param.AddRange(items);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 23220, 23279);
                            return 0;
                        }


                        int
                        f_25011_23323_23336(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 23323, 23336);
                            return return_v;
                        }


                        int
                        f_25011_23449_23462(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 23449, 23462);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_23565_23586(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 23565, 23586);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_23706_23744()
                        {
                            var return_v = PooledHashSet<CaptureId>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 23706, 23744);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_23897_23931(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            var return_v = operation.DescendantsAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 23897, 23931);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_23897_23972(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        source)
                        {
                            var return_v = source.OfType<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 23897, 23972);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        f_25011_24060_24072(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 24060, 24072);
                            return return_v;
                        }


                        bool
                        f_25011_24030_24073(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24030, 24073);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_23897_23972_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 23897, 23972);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_24267_24284(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.CaptureIds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 24267, 24284);
                            return return_v;
                        }


                        bool
                        f_25011_24346_24384(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24346, 24384);
                            return return_v;
                        }


                        bool
                        f_25011_24421_24446(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24421, 24446);
                            return return_v;
                        }


                        bool
                        f_25011_24483_24539(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isCSharpEmptyObjectInitializerCapture(region, block, id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24483, 24539);
                            return return_v;
                        }


                        bool
                        f_25011_24576_24623(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isWithStatementTargetCapture(region, block, id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24576, 24623);
                            return return_v;
                        }


                        bool
                        f_25011_24660_24700(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isSwitchTargetCapture(region, block, id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24660, 24700);
                            return return_v;
                        }


                        bool
                        f_25011_24737_24782(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isForEachEnumeratorCapture(region, block, id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24737, 24782);
                            return return_v;
                        }


                        bool
                        f_25011_24819_24875(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isConditionalXMLAccessReceiverCapture(region, block, id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24819, 24875);
                            return return_v;
                        }


                        bool
                        f_25011_24912_24990(Microsoft.CodeAnalysis.IOperation?
                        operation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isConditionalAccessCaptureUsedAfterNullCheck(operation, region, block, id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24912, 24990);
                            return return_v;
                        }


                        bool
                        f_25011_25028_25054(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25028, 25054);
                            return return_v;
                        }


                        bool
                        f_25011_25058_25115(Microsoft.CodeAnalysis.IOperation?
                        operation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isAggregateGroupCapture(operation, region, block, id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25058, 25115);
                            return return_v;
                        }


                        int
                        f_25011_25258_25281(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LastBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 25258, 25281);
                            return return_v;
                        }


                        int
                        f_25011_25285_25298(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 25285, 25298);
                            return return_v;
                        }


                        bool
                        f_25011_25302_25328(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25302, 25328);
                            return return_v;
                        }


                        int
                        f_25011_25567_25580(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 25567, 25580);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_25517_25585(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        firstBlockOrdinal)
                        {
                            var return_v = getFlowCaptureReferenceOperationsInRegion(region, firstBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25517, 25585);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_25517_25613(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        source, System.Func<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation, bool>
                        predicate)
                        {
                            var return_v = source.Where<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>(predicate);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25517, 25613);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation[]
                        f_25011_25517_25623(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        source)
                        {
                            var return_v = source.ToArray<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25517, 25623);
                            return return_v;
                        }


                        int
                        f_25011_25676_25698(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 25676, 25698);
                            return return_v;
                        }


                        bool
                        f_25011_25747_25816(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation[]
                        source, System.Func<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation, bool>
                        predicate)
                        {
                            var return_v = source.All<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>(predicate);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25747, 25816);
                            return return_v;
                        }


                        string
                        f_25011_25898_25917(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25898, 25917);
                            return return_v;
                        }


                        string
                        f_25011_25952_25969(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25952, 25969);
                            return return_v;
                        }


                        int
                        f_25011_25656_25985(bool
                        value, string
                        message, System.Func<string>
                        finalGraph)
                        {
                            AssertTrueWithGraph(value, message, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 25656, 25985);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_24267_24284_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24267, 24284);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_24185_24192_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 24185, 24192);
                            return return_v;
                        }


                        int
                        f_25011_26060_26092(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 26060, 26092);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 22200, 26127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 22200, 26127);
                    }
                }

                bool isCSharpEmptyObjectInitializerCapture(ControlFlowRegion region, BasicBlock block, CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 26143, 27825);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26276, 26410) || true) && (f_25011_26280_26312(f_25011_26280_26303(graph)) != LanguageNames.CSharp)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 26276, 26410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26378, 26391);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 26276, 26410);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26430, 27777);
                            foreach (IFlowCaptureOperation candidate in f_25011_26474_26539_I(f_25011_26474_26539(region, f_25011_26525_26538(block))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 26430, 27777);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26581, 27758) || true) && (candidate.Id.Equals(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 26581, 27758);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26658, 26763);

                                    CSharpSyntaxNode
                                    syntax = f_25011_26684_26762(f_25011_26745_26761(candidate))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26789, 26822);

                                    CSharpSyntaxNode
                                    parent = syntax
                                    ;
                                    {
                                        try
                                        {
                                            do

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 26850, 27073);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26909, 26932);

                                                parent = f_25011_26918_26931(parent);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 26850, 27073);
                                            }
                                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 26850, 27073) || true) && (parent != null && (DynAbs.Tracing.TraceSender.Expression_True(25011, 26992, 27071) && f_25011_27010_27023(parent) != CSharp.SyntaxKind.SimpleAssignmentExpression))
                                            );
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 26850, 27073);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 26850, 27073);
                                        }
                                    }
                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 27101, 27701) || true) && (parent is AssignmentExpressionSyntax assignment && (DynAbs.Tracing.TraceSender.Expression_True(25011, 27105, 27259) && f_25011_27203_27210(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25011_27185_27202(assignment), 25011, 27185, 27210)) == CSharp.SyntaxKind.ObjectInitializerExpression) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 27105, 27349) && f_25011_27292_27349(f_25011_27292_27332(f_25011_27292_27307(assignment)), syntax)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 27105, 27441) && f_25011_27382_27398(assignment) is InitializerExpressionSyntax initializer) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 27105, 27541) && f_25011_27474_27492(initializer) == CSharp.SyntaxKind.ObjectInitializerExpression) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 27105, 27604) && !initializer.Expressions.Any()))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 27101, 27701);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 27662, 27674);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 27101, 27701);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 27729, 27735);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 26581, 27758);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 26430, 27777);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1348);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1348);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 27797, 27810);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 26143, 27825);

                        Microsoft.CodeAnalysis.IOperation
                        f_25011_26280_26303(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param)
                        {
                            var return_v = this_param.OriginalOperation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 26280, 26303);
                            return return_v;
                        }


                        string
                        f_25011_26280_26312(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 26280, 26312);
                            return return_v;
                        }


                        int
                        f_25011_26525_26538(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 26525, 26538);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_26474_26539(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        lastBlockOrdinal)
                        {
                            var return_v = getFlowCaptureOperationsFromBlocksInRegion(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 26474, 26539);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_26745_26761(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 26745, 26761);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_26684_26762(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 26684, 26762);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_26918_26931(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 26918, 26931);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_27010_27023(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 27010, 27023);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_27185_27202(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 27185, 27202);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                        f_25011_27203_27210(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param?.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 27203, 27210);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_27292_27307(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 27292, 27307);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                        f_25011_27292_27332(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.DescendantNodesAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 27292, 27332);
                            return return_v;
                        }


                        bool
                        f_25011_27292_27349(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                        source, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        value)
                        {
                            var return_v = source.Contains<Microsoft.CodeAnalysis.SyntaxNode>((Microsoft.CodeAnalysis.SyntaxNode)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 27292, 27349);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_27382_27398(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Right;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 27382, 27398);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_27474_27492(Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 27474, 27492);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_26474_26539_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 26474, 26539);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 26143, 27825);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 26143, 27825);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isWithStatementTargetCapture(ControlFlowRegion region, BasicBlock block, CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 27841, 28866);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 27965, 28104) || true) && (f_25011_27969_28001(f_25011_27969_27992(graph)) != LanguageNames.VisualBasic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 27965, 28104);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28072, 28085);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 27965, 28104);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28124, 28818);
                            foreach (IFlowCaptureOperation candidate in f_25011_28168_28233_I(f_25011_28168_28233(region, f_25011_28219_28232(block))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 28124, 28818);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28275, 28799) || true) && (candidate.Id.Equals(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 28275, 28799);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28352, 28450);

                                    VisualBasicSyntaxNode
                                    syntax = f_25011_28383_28449(f_25011_28432_28448(candidate))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28476, 28521);

                                    VisualBasicSyntaxNode
                                    parent = f_25011_28507_28520(syntax)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28549, 28742) || true) && (parent is WithStatementSyntax with && (DynAbs.Tracing.TraceSender.Expression_True(25011, 28553, 28645) && f_25011_28620_28635(with) == syntax))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 28549, 28742);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28703, 28715);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 28549, 28742);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 28770, 28776);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 28275, 28799);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 28124, 28818);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 695);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 695);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 28838, 28851);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 27841, 28866);

                        Microsoft.CodeAnalysis.IOperation
                        f_25011_27969_27992(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param)
                        {
                            var return_v = this_param.OriginalOperation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 27969, 27992);
                            return return_v;
                        }


                        string
                        f_25011_27969_28001(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 27969, 28001);
                            return return_v;
                        }


                        int
                        f_25011_28219_28232(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 28219, 28232);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_28168_28233(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        lastBlockOrdinal)
                        {
                            var return_v = getFlowCaptureOperationsFromBlocksInRegion(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 28168, 28233);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_28432_28448(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 28432, 28448);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_28383_28449(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 28383, 28449);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_28507_28520(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 28507, 28520);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_28620_28635(Microsoft.CodeAnalysis.VisualBasic.Syntax.WithStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 28620, 28635);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_28168_28233_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 28168, 28233);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 27841, 28866);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 27841, 28866);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isConditionalXMLAccessReceiverCapture(ControlFlowRegion region, BasicBlock block, CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 28882, 30662);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 29015, 29154) || true) && (f_25011_29019_29051(f_25011_29019_29042(graph)) != LanguageNames.VisualBasic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 29015, 29154);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 29122, 29135);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 29015, 29154);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 29174, 30614);
                            foreach (IFlowCaptureOperation candidate in f_25011_29218_29283_I(f_25011_29218_29283(region, f_25011_29269_29282(block))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 29174, 30614);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 29325, 30595) || true) && (candidate.Id.Equals(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 29325, 30595);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 29402, 29500);

                                    VisualBasicSyntaxNode
                                    syntax = f_25011_29433_29499(f_25011_29482_29498(candidate))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 29526, 29571);

                                    VisualBasicSyntaxNode
                                    parent = f_25011_29557_29570(syntax)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 29599, 30538) || true) && (parent is VisualBasic.Syntax.ConditionalAccessExpressionSyntax conditional && (DynAbs.Tracing.TraceSender.Expression_True(25011, 29603, 29742) && f_25011_29710_29732(conditional) == syntax) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 29603, 30184) && f_25011_29775_30184(f_25011_29775_29823(f_25011_29775_29798(conditional)), n =>
                                                                                      n.IsKind(VisualBasic.SyntaxKind.XmlElementAccessExpression) ||
                                                                                      n.IsKind(VisualBasic.SyntaxKind.XmlDescendantAccessExpression) ||
                                                                                      n.IsKind(VisualBasic.SyntaxKind.XmlAttributeAccessExpression))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 29599, 30538);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 30499, 30511);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 29599, 30538);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 30566, 30572);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 29325, 30595);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 29174, 30614);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1441);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1441);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 30634, 30647);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 28882, 30662);

                        Microsoft.CodeAnalysis.IOperation
                        f_25011_29019_29042(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param)
                        {
                            var return_v = this_param.OriginalOperation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 29019, 29042);
                            return return_v;
                        }


                        string
                        f_25011_29019_29051(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 29019, 29051);
                            return return_v;
                        }


                        int
                        f_25011_29269_29282(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 29269, 29282);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_29218_29283(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        lastBlockOrdinal)
                        {
                            var return_v = getFlowCaptureOperationsFromBlocksInRegion(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 29218, 29283);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_29482_29498(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 29482, 29498);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_29433_29499(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 29433, 29499);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_29557_29570(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 29557, 29570);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_29710_29732(Microsoft.CodeAnalysis.VisualBasic.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 29710, 29732);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_29775_29798(Microsoft.CodeAnalysis.VisualBasic.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.WhenNotNull;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 29775, 29798);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                        f_25011_29775_29823(Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.DescendantNodesAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 29775, 29823);
                            return return_v;
                        }


                        bool
                        f_25011_29775_30184(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                        source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                        predicate)
                        {
                            var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 29775, 30184);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_29218_29283_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 29218, 29283);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 28882, 30662);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 28882, 30662);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isEmptySwitchExpressionResult(IFlowCaptureReferenceOperation reference)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 30678, 30907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 30787, 30892);

                        return f_25011_30794_30810(reference) is CSharp.Syntax.SwitchExpressionSyntax switchExpr && (DynAbs.Tracing.TraceSender.Expression_True(25011, 30794, 30891) && switchExpr.Arms.Count == 0);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 30678, 30907);

                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_30794_30810(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 30794, 30810);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 30678, 30907);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 30678, 30907);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isSwitchTargetCapture(ControlFlowRegion region, BasicBlock block, CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 30923, 32931);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 31040, 32883);
                            foreach (IFlowCaptureOperation candidate in f_25011_31084_31149_I(f_25011_31084_31149(region, f_25011_31135_31148(block))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 31040, 32883);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 31191, 32864) || true) && (candidate.Id.Equals(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 31191, 32864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 31268, 32807);

                                    switch (f_25011_31276_31294(candidate))
                                    {

                                        case LanguageNames.CSharp:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 31268, 32807);
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 31451, 31556);

                                                CSharpSyntaxNode
                                                syntax = f_25011_31477_31555(f_25011_31538_31554(candidate))
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 31594, 31829) || true) && (f_25011_31598_31611(syntax) is CSharp.Syntax.SwitchStatementSyntax switchStmt && (DynAbs.Tracing.TraceSender.Expression_True(25011, 31598, 31696) && f_25011_31665_31686(switchStmt) == syntax))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 31594, 31829);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 31778, 31790);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 31594, 31829);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 31869, 32114) || true) && (f_25011_31873_31886(syntax) is CSharp.Syntax.SwitchExpressionSyntax switchExpr && (DynAbs.Tracing.TraceSender.Expression_True(25011, 31873, 31981) && f_25011_31941_31971(switchExpr) == syntax))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 31869, 32114);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 32063, 32075);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 31869, 32114);
                                                }
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 32185, 32191);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 31268, 32807);

                                        case LanguageNames.VisualBasic:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 31268, 32807);
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 32327, 32425);

                                                VisualBasicSyntaxNode
                                                syntax = f_25011_32358_32424(f_25011_32407_32423(candidate))
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 32463, 32703) || true) && (f_25011_32467_32480(syntax) is VisualBasic.Syntax.SelectStatementSyntax switchStmt && (DynAbs.Tracing.TraceSender.Expression_True(25011, 32467, 32570) && f_25011_32539_32560(switchStmt) == syntax))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 32463, 32703);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 32652, 32664);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 32463, 32703);
                                                }
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 32774, 32780);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 31268, 32807);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 32835, 32841);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 31191, 32864);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 31040, 32883);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1844);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1844);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 32903, 32916);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 30923, 32931);

                        int
                        f_25011_31135_31148(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 31135, 31148);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_31084_31149(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        lastBlockOrdinal)
                        {
                            var return_v = getFlowCaptureOperationsFromBlocksInRegion(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 31084, 31149);
                            return return_v;
                        }


                        string
                        f_25011_31276_31294(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 31276, 31294);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_31538_31554(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 31538, 31554);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_31477_31555(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 31477, 31555);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_31598_31611(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 31598, 31611);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_31665_31686(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 31665, 31686);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_31873_31886(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 31873, 31886);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_31941_31971(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.GoverningExpression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 31941, 31971);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_32407_32423(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 32407, 32423);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_32358_32424(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 32358, 32424);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_32467_32480(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 32467, 32480);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_32539_32560(Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 32539, 32560);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_31084_31149_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 31084, 31149);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 30923, 32931);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 30923, 32931);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isForEachEnumeratorCapture(ControlFlowRegion region, BasicBlock block, CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 32947, 34671);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 33069, 34623);
                            foreach (IFlowCaptureOperation candidate in f_25011_33113_33178_I(f_25011_33113_33178(region, f_25011_33164_33177(block))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 33069, 34623);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 33220, 34604) || true) && (candidate.Id.Equals(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 33220, 34604);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 33297, 34547);

                                    switch (f_25011_33305_33323(candidate))
                                    {

                                        case LanguageNames.CSharp:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 33297, 34547);
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 33480, 33585);

                                                CSharpSyntaxNode
                                                syntax = f_25011_33506_33584(f_25011_33567_33583(candidate))
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 33623, 33859) || true) && (f_25011_33627_33640(syntax) is CSharp.Syntax.CommonForEachStatementSyntax forEach && (DynAbs.Tracing.TraceSender.Expression_True(25011, 33627, 33726) && f_25011_33698_33716(forEach) == syntax))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 33623, 33859);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 33808, 33820);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 33623, 33859);
                                                }
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 33930, 33936);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 33297, 34547);

                                        case LanguageNames.VisualBasic:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 33297, 34547);
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 34072, 34170);

                                                VisualBasicSyntaxNode
                                                syntax = f_25011_34103_34169(f_25011_34152_34168(candidate))
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 34208, 34443) || true) && (f_25011_34212_34225(syntax) is VisualBasic.Syntax.ForEachStatementSyntax forEach && (DynAbs.Tracing.TraceSender.Expression_True(25011, 34212, 34310) && f_25011_34282_34300(forEach) == syntax))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 34208, 34443);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 34392, 34404);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 34208, 34443);
                                                }
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 34514, 34520);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 33297, 34547);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 34575, 34581);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 33220, 34604);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 33069, 34623);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1555);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1555);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 34643, 34656);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 32947, 34671);

                        int
                        f_25011_33164_33177(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 33164, 33177);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_33113_33178(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        lastBlockOrdinal)
                        {
                            var return_v = getFlowCaptureOperationsFromBlocksInRegion(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 33113, 33178);
                            return return_v;
                        }


                        string
                        f_25011_33305_33323(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 33305, 33323);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_33567_33583(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 33567, 33583);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_33506_33584(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 33506, 33584);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_33627_33640(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 33627, 33640);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_33698_33716(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 33698, 33716);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_34152_34168(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 34152, 34168);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_34103_34169(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 34103, 34169);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_34212_34225(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 34212, 34225);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_34282_34300(Microsoft.CodeAnalysis.VisualBasic.Syntax.ForEachStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 34282, 34300);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_33113_33178_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 33113, 33178);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 32947, 34671);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 32947, 34671);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isAggregateGroupCapture(IOperation operation, ControlFlowRegion region, BasicBlock block, CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 34687, 36262);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 34828, 34967) || true) && (f_25011_34832_34864(f_25011_34832_34855(graph)) != LanguageNames.VisualBasic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 34828, 34967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 34935, 34948);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 34828, 34967);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 34987, 36214);
                            foreach (IFlowCaptureOperation candidate in f_25011_35031_35096_I(f_25011_35031_35096(region, f_25011_35082_35095(block))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 34987, 36214);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 35138, 36195) || true) && (candidate.Id.Equals(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 35138, 36195);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 35215, 35313);

                                    VisualBasicSyntaxNode
                                    syntax = f_25011_35246_35312(f_25011_35295_35311(candidate))
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 35341, 36138);
                                        foreach (ITranslatedQueryOperation query in f_25011_35385_35451_I(f_25011_35385_35451(f_25011_35385_35415(operation))))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 35341, 36138);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 35509, 36111) || true) && (f_25011_35513_35525(query) is VisualBasic.Syntax.QueryExpressionSyntax querySyntax && (DynAbs.Tracing.TraceSender.Expression_True(25011, 35513, 35705) && f_25011_35618_35651(querySyntax.Clauses) is VisualBasic.Syntax.AggregateClauseSyntax aggregate) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 35513, 35807) && aggregate.AggregateKeyword.SpanStart < f_25011_35781_35807(f_25011_35781_35797(candidate))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 35513, 35904) && aggregate.IntoKeyword.SpanStart > f_25011_35878_35904(f_25011_35878_35894(candidate))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 35513, 36002) && f_25011_35941_35961(f_25011_35941_35956(query)) == OperationKind.AnonymousObjectCreation))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 35509, 36111);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 36068, 36080);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 35509, 36111);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 35341, 36138);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 798);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 798);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 36166, 36172);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 35138, 36195);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 34987, 36214);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1228);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1228);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 36234, 36247);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 34687, 36262);

                        Microsoft.CodeAnalysis.IOperation
                        f_25011_34832_34855(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param)
                        {
                            var return_v = this_param.OriginalOperation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 34832, 34855);
                            return return_v;
                        }


                        string
                        f_25011_34832_34864(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 34832, 34864);
                            return return_v;
                        }


                        int
                        f_25011_35082_35095(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35082, 35095);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_35031_35096(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        lastBlockOrdinal)
                        {
                            var return_v = getFlowCaptureOperationsFromBlocksInRegion(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 35031, 35096);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_35295_35311(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35295, 35311);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_35246_35312(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 35246, 35312);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_35385_35415(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            var return_v = operation.DescendantsAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 35385, 35415);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation>
                        f_25011_35385_35451(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        source)
                        {
                            var return_v = source.OfType<Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 35385, 35451);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_35513_35525(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35513, 35525);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.QueryClauseSyntax?
                        f_25011_35618_35651(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.VisualBasic.Syntax.QueryClauseSyntax>
                        source)
                        {
                            var return_v = source.AsSingleton<Microsoft.CodeAnalysis.VisualBasic.Syntax.QueryClauseSyntax>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 35618, 35651);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_35781_35797(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35781, 35797);
                            return return_v;
                        }


                        int
                        f_25011_35781_35807(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.SpanStart;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35781, 35807);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_35878_35894(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35878, 35894);
                            return return_v;
                        }


                        int
                        f_25011_35878_35904(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.SpanStart;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35878, 35904);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_35941_35956(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation
                        this_param)
                        {
                            var return_v = this_param.Operation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35941, 35956);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.OperationKind
                        f_25011_35941_35961(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 35941, 35961);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation>
                        f_25011_35385_35451_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 35385, 35451);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_35031_35096_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 35031, 35096);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 34687, 36262);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 34687, 36262);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                void adjustEntryStateForDestination(ArrayBuilder<PooledHashSet<CaptureId>> entryStates, ControlFlowBranch branch, PooledHashSet<CaptureId> state)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 36278, 38324);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 36456, 38089) || true) && (f_25011_36460_36478(branch) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 36456, 38089);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 36528, 36967) || true) && (f_25011_36532_36558(f_25011_36532_36550(branch)) > f_25011_36561_36582(f_25011_36561_36574(branch)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 36528, 36967);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 36632, 36733);

                                PooledHashSet<CaptureId>
                                entryState = f_25011_36670_36732(entryStates, f_25011_36706_36724(branch), state)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 36761, 36944);
                                    foreach (ControlFlowRegion region in f_25011_36798_36819_I(f_25011_36798_36819(branch)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 36761, 36944);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 36877, 36917);

                                        entryState.RemoveAll(f_25011_36898_36915(region));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 36761, 36944);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 184);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 184);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 36528, 36967);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 36456, 38089);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 36456, 38089);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 37009, 38089) || true) && (f_25011_37013_37029(branch) == ControlFlowBranchSemantics.Throw || (DynAbs.Tracing.TraceSender.Expression_False(25011, 37013, 37149) || f_25011_37095_37111(branch) == ControlFlowBranchSemantics.Rethrow) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 37013, 37231) || f_25011_37179_37195(branch) == ControlFlowBranchSemantics.Error) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 37013, 37335) || f_25011_37261_37277(branch) == ControlFlowBranchSemantics.StructuredExceptionHandling))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 37009, 38089);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 37377, 37434);

                                ControlFlowRegion
                                region = f_25011_37404_37433(f_25011_37404_37417(branch))
                                ;
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 37458, 38070) || true) && (f_25011_37465_37476(region) != ControlFlowRegionKind.Root)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 37458, 38070);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 37556, 37987) || true) && (f_25011_37560_37571(region) == ControlFlowRegionKind.Try && (DynAbs.Tracing.TraceSender.Expression_True(25011, 37560, 37670) && f_25011_37604_37631(f_25011_37604_37626(region)) == ControlFlowRegionKind.TryAndFinally))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 37556, 37987);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 37728, 37820);

                                            f_25011_37728_37819(f_25011_37741_37785(f_25011_37741_37777(f_25011_37741_37763(region))[1]) == ControlFlowRegionKind.Finally);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 37850, 37960);

                                            f_25011_37850_37959(entryStates, blocks[f_25011_37893_37950(f_25011_37893_37929(f_25011_37893_37915(region))[1])], state);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 37556, 37987);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38015, 38047);

                                        region = f_25011_38024_38046(region);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 37458, 38070);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 37458, 38070);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 37458, 38070);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 37009, 38089);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 36456, 38089);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38109, 38309);
                            foreach (ControlFlowRegion @finally in f_25011_38148_38169_I(f_25011_38148_38169(branch)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 38109, 38309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38211, 38290);

                                f_25011_38211_38289(entryStates, blocks[f_25011_38254_38280(@finally)], state);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 38109, 38309);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 201);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 201);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 36278, 38324);

                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                        f_25011_36460_36478(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36460, 36478);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_36532_36550(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36532, 36550);
                            return return_v;
                        }


                        int
                        f_25011_36532_36558(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36532, 36558);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_36561_36574(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36561, 36574);
                            return return_v;
                        }


                        int
                        f_25011_36561_36582(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36561, 36582);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_36706_36724(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36706, 36724);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_36670_36732(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        entryStates, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state)
                        {
                            var return_v = adjustAndGetEntryState(entryStates, block, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 36670, 36732);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_36798_36819(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.LeavingRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36798, 36819);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_36898_36915(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.CaptureIds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 36898, 36915);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_36798_36819_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 36798, 36819);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_37013_37029(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37013, 37029);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_37095_37111(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37095, 37111);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_37179_37195(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37179, 37195);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_37261_37277(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37261, 37277);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_37404_37417(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37404, 37417);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_37404_37433(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37404, 37433);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_37465_37476(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37465, 37476);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_37560_37571(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37560, 37571);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_37604_37626(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37604, 37626);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_37604_37631(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37604, 37631);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_37741_37763(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37741, 37763);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_37741_37777(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.NestedRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37741, 37777);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_37741_37785(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37741, 37785);
                            return return_v;
                        }


                        int
                        f_25011_37728_37819(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 37728, 37819);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_37893_37915(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37893, 37915);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_37893_37929(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.NestedRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37893, 37929);
                            return return_v;
                        }


                        int
                        f_25011_37893_37950(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 37893, 37950);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_37850_37959(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        entryStates, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state)
                        {
                            var return_v = adjustAndGetEntryState(entryStates, block, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 37850, 37959);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_38024_38046(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 38024, 38046);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_38148_38169(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.FinallyRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 38148, 38169);
                            return return_v;
                        }


                        int
                        f_25011_38254_38280(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 38254, 38280);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_38211_38289(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        entryStates, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        state)
                        {
                            var return_v = adjustAndGetEntryState(entryStates, block, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 38211, 38289);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_38148_38169_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 38148, 38169);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 36278, 38324);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 36278, 38324);
                    }
                }

                PooledHashSet<CaptureId> adjustAndGetEntryState(ArrayBuilder<PooledHashSet<CaptureId>> entryStates, BasicBlock block, PooledHashSet<CaptureId> state)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 38340, 39034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38522, 38587);

                        PooledHashSet<CaptureId>
                        entryState = f_25011_38560_38586(entryStates, f_25011_38572_38585(block))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38605, 38981) || true) && (entryState == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 38605, 38981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38669, 38721);

                            entryState = f_25011_38682_38720();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38743, 38768);

                            f_25011_38743_38767(entryState, state);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38790, 38830);

                            entryStates[f_25011_38802_38815(block)] = entryState;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 38605, 38981);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 38605, 38981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 38912, 38962);

                            f_25011_38912_38961(entryState, id => !state.Contains(id));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 38605, 38981);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 39001, 39019);

                        return entryState;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 38340, 39034);

                        int
                        f_25011_38572_38585(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 38572, 38585);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_38560_38586(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 38560, 38586);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_38682_38720()
                        {
                            var return_v = PooledHashSet<CaptureId>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 38682, 38720);
                            return return_v;
                        }


                        bool
                        f_25011_38743_38767(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        set, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        values)
                        {
                            var return_v = set.AddAll<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>)values);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 38743, 38767);
                            return return_v;
                        }


                        int
                        f_25011_38802_38815(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 38802, 38815);
                            return return_v;
                        }


                        int
                        f_25011_38912_38961(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, System.Predicate<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        match)
                        {
                            var return_v = this_param.RemoveWhere(match);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 38912, 38961);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 38340, 39034);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 38340, 39034);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                void assertCaptureReferences(
                                PooledHashSet<CaptureId> state, IOperation operation, BasicBlock block, int operationIndex,
                                PooledHashSet<CaptureId> longLivedIds, PooledHashSet<CaptureId> referencedIds, Func<string> finalGraph)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 39050, 41036);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 39342, 41021);
                            foreach (IFlowCaptureReferenceOperation reference in f_25011_39395_39466_I(f_25011_39395_39466(f_25011_39395_39425(operation))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 39342, 41021);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 39508, 39536);

                                CaptureId
                                id = f_25011_39523_39535(reference)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 39558, 39580);

                                f_25011_39558_39579(referencedIds, id);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 39604, 39763) || true) && (f_25011_39608_39669(reference, f_25011_39647_39668(block)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 39604, 39763);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 39719, 39740);

                                    f_25011_39719_39739(longLivedIds, id);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 39604, 39763);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 39787, 40044);

                                f_25011_39787_40043(f_25011_39807_39825(state, id) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 39807, 39860) || f_25011_39829_39860(id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 39807, 39904) || f_25011_39864_39904(reference)), $"Operation [{operationIndex}] in [{f_25011_39967_39984(block)}] uses not initialized capture [{id.Value}].", finalGraph);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 40275, 41002);

                                f_25011_40275_41001(f_25011_40295_40316(block).CaptureIds.Contains(id) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 40295, 40369) || f_25011_40344_40369(longLivedIds, id)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 40295, 40828) || ((f_25011_40408_40470(reference) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 40408, 40568) || f_25011_40512_40568(reference)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 40408, 40648) || f_25011_40610_40648(reference)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 40408, 40727) || f_25011_40690_40727(reference))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 40407, 40827) && f_25011_40766_40803(f_25011_40766_40787(block)).CaptureIds.Contains(id)))), $"Operation [{operationIndex}] in [{f_25011_40891_40908(block)}] uses capture [{id.Value}] from another region. Should the regions be merged?", finalGraph);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 39342, 41021);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 1680);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 1680);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 39050, 41036);

                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_39395_39425(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            var return_v = operation.DescendantsAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39395, 39425);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_39395_39466(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        source)
                        {
                            var return_v = source.OfType<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39395, 39466);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        f_25011_39523_39535(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 39523, 39535);
                            return return_v;
                        }


                        bool
                        f_25011_39558_39579(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39558, 39579);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_39647_39668(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 39647, 39668);
                            return return_v;
                        }


                        bool
                        f_25011_39608_39669(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        reference, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = isLongLivedCaptureReference(reference, region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39608, 39669);
                            return return_v;
                        }


                        bool
                        f_25011_39719_39739(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39719, 39739);
                            return return_v;
                        }


                        bool
                        f_25011_39807_39825(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39807, 39825);
                            return return_v;
                        }


                        bool
                        f_25011_39829_39860(Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isCaptureFromEnclosingGraph(id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39829, 39860);
                            return return_v;
                        }


                        bool
                        f_25011_39864_39904(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        reference)
                        {
                            var return_v = isEmptySwitchExpressionResult(reference);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39864, 39904);
                            return return_v;
                        }


                        string
                        f_25011_39967_39984(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39967, 39984);
                            return return_v;
                        }


                        int
                        f_25011_39787_40043(bool
                        value, string
                        message, System.Func<string>
                        finalGraph)
                        {
                            AssertTrueWithGraph(value, message, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39787, 40043);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_40295_40316(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 40295, 40316);
                            return return_v;
                        }


                        bool
                        f_25011_40344_40369(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 40344, 40369);
                            return return_v;
                        }


                        bool
                        f_25011_40408_40470(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        reference)
                        {
                            var return_v = isFirstOperandOfDynamicOrUserDefinedLogicalOperator(reference);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 40408, 40470);
                            return return_v;
                        }


                        bool
                        f_25011_40512_40568(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        reference)
                        {
                            var return_v = isIncrementedNullableForToLoopControlVariable(reference);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 40512, 40568);
                            return return_v;
                        }


                        bool
                        f_25011_40610_40648(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        reference)
                        {
                            var return_v = isConditionalAccessReceiver(reference);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 40610, 40648);
                            return return_v;
                        }


                        bool
                        f_25011_40690_40727(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        reference)
                        {
                            var return_v = isCoalesceAssignmentTarget(reference);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 40690, 40727);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_40766_40787(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 40766, 40787);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_40766_40803(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 40766, 40803);
                            return return_v;
                        }


                        string
                        f_25011_40891_40908(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 40891, 40908);
                            return return_v;
                        }


                        int
                        f_25011_40275_41001(bool
                        value, string
                        message, System.Func<string>
                        finalGraph)
                        {
                            AssertTrueWithGraph(value, message, finalGraph);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 40275, 41001);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_39395_39466_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 39395, 39466);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 39050, 41036);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 39050, 41036);
                    }
                }

                bool isConditionalAccessReceiver(IFlowCaptureReferenceOperation reference)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 41052, 42471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 41159, 41212);

                        SyntaxNode
                        captureReferenceSyntax = f_25011_41195_41211(reference)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 41232, 42423);

                        switch (f_25011_41240_41271(captureReferenceSyntax))
                        {

                            case LanguageNames.CSharp:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 41232, 42423);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 41396, 41507);

                                    CSharpSyntaxNode
                                    syntax = f_25011_41422_41506(captureReferenceSyntax)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 41537, 41785) || true) && (f_25011_41541_41554(syntax) is CSharp.Syntax.ConditionalAccessExpressionSyntax access && (DynAbs.Tracing.TraceSender.Expression_True(25011, 41541, 41676) && f_25011_41649_41666(access) == syntax))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 41537, 41785);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 41742, 41754);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 41537, 41785);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 41838, 41844);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 41232, 42423);

                            case LanguageNames.VisualBasic:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 41232, 42423);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 41956, 42060);

                                    VisualBasicSyntaxNode
                                    syntax = f_25011_41987_42059(captureReferenceSyntax)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 42090, 42343) || true) && (f_25011_42094_42107(syntax) is VisualBasic.Syntax.ConditionalAccessExpressionSyntax access && (DynAbs.Tracing.TraceSender.Expression_True(25011, 42094, 42234) && f_25011_42207_42224(access) == syntax))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 42090, 42343);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 42300, 42312);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 42090, 42343);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 42398, 42404);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 41232, 42423);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 42443, 42456);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 41052, 42471);

                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_41195_41211(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 41195, 41211);
                            return return_v;
                        }


                        string
                        f_25011_41240_41271(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 41240, 41271);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_41422_41506(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 41422, 41506);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_41541_41554(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 41541, 41554);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_41649_41666(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 41649, 41666);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_41987_42059(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 41987, 42059);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_42094_42107(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 42094, 42107);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_42207_42224(Microsoft.CodeAnalysis.VisualBasic.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 42207, 42224);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 41052, 42471);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 41052, 42471);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isCoalesceAssignmentTarget(IFlowCaptureReferenceOperation reference)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 42487, 43127);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 42593, 42713) || true) && (f_25011_42597_42615(reference) != LanguageNames.CSharp)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 42593, 42713);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 42681, 42694);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 42593, 42713);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 42733, 42847);

                        CSharpSyntaxNode
                        referenceSyntax = f_25011_42768_42846(f_25011_42829_42845(reference))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 42865, 43112);

                        return f_25011_42872_42894(referenceSyntax) is AssignmentExpressionSyntax conditionalAccess && (DynAbs.Tracing.TraceSender.Expression_True(25011, 42872, 43042) && f_25011_42970_43042(conditionalAccess, CSharp.SyntaxKind.CoalesceAssignmentExpression)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 42872, 43111) && f_25011_43070_43092(conditionalAccess) == referenceSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 42487, 43127);

                        string
                        f_25011_42597_42615(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 42597, 42615);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_42829_42845(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 42829, 42845);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_42768_42846(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 42768, 42846);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_42872_42894(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 42872, 42894);
                            return return_v;
                        }


                        bool
                        f_25011_42970_43042(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        kind)
                        {
                            var return_v = node.IsKind(kind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 42970, 43042);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_43070_43092(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43070, 43092);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 42487, 43127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 42487, 43127);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isFirstOperandOfDynamicOrUserDefinedLogicalOperator(IFlowCaptureReferenceOperation reference)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 43143, 46710);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 43274, 46662) || true) && (f_25011_43278_43294(reference) is IBinaryOperation binOp)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 43274, 46662);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 43362, 46643) || true) && (f_25011_43366_43383(binOp) == reference && (DynAbs.Tracing.TraceSender.Expression_True(25011, 43366, 43540) && (f_25011_43426_43444(binOp) == Operations.BinaryOperatorKind.And || (DynAbs.Tracing.TraceSender.Expression_False(25011, 43426, 43539) || f_25011_43485_43503(binOp) == Operations.BinaryOperatorKind.Or))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 43366, 43825) && (f_25011_43570_43590(binOp) != null || (DynAbs.Tracing.TraceSender.Expression_False(25011, 43570, 43824) || (f_25011_43629_43673(f_25011_43662_43672(binOp)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 43629, 43823) && (f_25011_43705_43761(f_25011_43738_43760(f_25011_43738_43755(binOp))) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 43705, 43822) || f_25011_43765_43822(f_25011_43798_43821(f_25011_43798_43816(binOp)))))))))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 43362, 46643);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 43875, 46620) || true) && (f_25011_43879_43897(reference) == LanguageNames.CSharp)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 43875, 46620);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 43979, 44598) || true) && (f_25011_43983_43995(binOp) is CSharp.Syntax.BinaryExpressionSyntax binOpSyntax && (DynAbs.Tracing.TraceSender.Expression_True(25011, 43983, 44209) && (f_25011_44085_44103(binOpSyntax) == CSharp.SyntaxKind.LogicalAndExpression || (DynAbs.Tracing.TraceSender.Expression_False(25011, 44085, 44208) || f_25011_44149_44167(binOpSyntax) == CSharp.SyntaxKind.LogicalOrExpression))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 43983, 44344) && f_25011_44246_44262(binOpSyntax) == f_25011_44266_44344(f_25011_44327_44343(reference))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 43983, 44489) && f_25011_44381_44398(binOpSyntax) == f_25011_44402_44489(f_25011_44463_44488(f_25011_44463_44481(binOp)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 43979, 44598);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 44555, 44567);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 43979, 44598);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 43875, 46620);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 43875, 46620);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 44656, 46620) || true) && (f_25011_44660_44678(reference) == LanguageNames.VisualBasic)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 44656, 46620);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 44765, 44854);

                                        var
                                        referenceSyntax = f_25011_44787_44853(f_25011_44836_44852(reference))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 44884, 46593) || true) && (f_25011_44888_44900(binOp) is VisualBasic.Syntax.BinaryExpressionSyntax binOpSyntax && (DynAbs.Tracing.TraceSender.Expression_True(25011, 44888, 45123) && (f_25011_44995_45013(binOpSyntax) == VisualBasic.SyntaxKind.AndAlsoExpression || (DynAbs.Tracing.TraceSender.Expression_False(25011, 44995, 45122) || f_25011_45061_45079(binOpSyntax) == VisualBasic.SyntaxKind.OrElseExpression))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 44888, 45195) && f_25011_45160_45176(binOpSyntax) == referenceSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 44888, 45328) && f_25011_45232_45249(binOpSyntax) == f_25011_45253_45328(f_25011_45302_45327(f_25011_45302_45320(binOp)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 44884, 46593);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 45394, 45406);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 44884, 46593);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 44884, 46593);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 45472, 46593) || true) && (f_25011_45476_45488(binOp) is VisualBasic.Syntax.RangeCaseClauseSyntax range && (DynAbs.Tracing.TraceSender.Expression_True(25011, 45476, 45630) && f_25011_45575_45593(binOp) == Operations.BinaryOperatorKind.And) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 45476, 45702) && f_25011_45667_45683(range) == referenceSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 45476, 45834) && f_25011_45739_45755(range) == f_25011_45759_45834(f_25011_45808_45833(f_25011_45808_45826(binOp)))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 45472, 46593);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 45900, 45912);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 45472, 46593);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 45472, 46593);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 45978, 46593) || true) && (f_25011_45982_45994(binOp) is VisualBasic.Syntax.CaseStatementSyntax caseStmt && (DynAbs.Tracing.TraceSender.Expression_True(25011, 45982, 46136) && f_25011_46082_46100(binOp) == Operations.BinaryOperatorKind.Or) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 45982, 46197) && caseStmt.Cases.Count > 1) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 45982, 46327) && (caseStmt == referenceSyntax || (DynAbs.Tracing.TraceSender.Expression_False(25011, 46235, 46326) || caseStmt.Cases.Contains(referenceSyntax as CaseClauseSyntax)))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 45982, 46484) && caseStmt.Cases.Contains(f_25011_46388_46463(f_25011_46437_46462(f_25011_46437_46455(binOp))) as CaseClauseSyntax)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 45978, 46593);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 46550, 46562);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 45978, 46593);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 45472, 46593);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 44884, 46593);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 44656, 46620);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 43875, 46620);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 43362, 46643);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 43274, 46662);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 46682, 46695);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 43143, 46710);

                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_43278_43294(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43278, 43294);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_43366_43383(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.LeftOperand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43366, 43383);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                        f_25011_43426_43444(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.OperatorKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43426, 43444);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                        f_25011_43485_43503(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.OperatorKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43485, 43503);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IMethodSymbol?
                        f_25011_43570_43590(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.OperatorMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43570, 43590);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_43662_43672(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43662, 43672);
                            return return_v;
                        }


                        bool
                        f_25011_43629_43673(Microsoft.CodeAnalysis.ITypeSymbol?
                        type)
                        {
                            var return_v = ITypeSymbolHelpers.IsDynamicType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 43629, 43673);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_43738_43755(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.LeftOperand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43738, 43755);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_43738_43760(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43738, 43760);
                            return return_v;
                        }


                        bool
                        f_25011_43705_43761(Microsoft.CodeAnalysis.ITypeSymbol?
                        type)
                        {
                            var return_v = ITypeSymbolHelpers.IsDynamicType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 43705, 43761);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_43798_43816(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.RightOperand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43798, 43816);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_43798_43821(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43798, 43821);
                            return return_v;
                        }


                        bool
                        f_25011_43765_43822(Microsoft.CodeAnalysis.ITypeSymbol?
                        type)
                        {
                            var return_v = ITypeSymbolHelpers.IsDynamicType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 43765, 43822);
                            return return_v;
                        }


                        string
                        f_25011_43879_43897(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43879, 43897);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_43983_43995(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 43983, 43995);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_44085_44103(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 44085, 44103);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_44149_44167(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 44149, 44167);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_44246_44262(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44246, 44262);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_44327_44343(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44327, 44343);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_44266_44344(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 44266, 44344);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_44381_44398(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Right;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44381, 44398);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_44463_44481(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.RightOperand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44463, 44481);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_44463_44488(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44463, 44488);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_44402_44489(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 44402, 44489);
                            return return_v;
                        }


                        string
                        f_25011_44660_44678(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44660, 44678);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_44836_44852(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44836, 44852);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_44787_44853(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 44787, 44853);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_44888_44900(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 44888, 44900);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.SyntaxKind
                        f_25011_44995_45013(Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 44995, 45013);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.SyntaxKind
                        f_25011_45061_45079(Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 45061, 45079);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_45160_45176(Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45160, 45176);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_45232_45249(Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Right;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45232, 45249);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_45302_45320(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.RightOperand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45302, 45320);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_45302_45327(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45302, 45327);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_45253_45328(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 45253, 45328);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_45476_45488(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45476, 45488);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                        f_25011_45575_45593(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.OperatorKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45575, 45593);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_45667_45683(Microsoft.CodeAnalysis.VisualBasic.Syntax.RangeCaseClauseSyntax
                        this_param)
                        {
                            var return_v = this_param.LowerBound;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45667, 45683);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_45739_45755(Microsoft.CodeAnalysis.VisualBasic.Syntax.RangeCaseClauseSyntax
                        this_param)
                        {
                            var return_v = this_param.UpperBound;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45739, 45755);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_45808_45826(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.RightOperand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45808, 45826);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_45808_45833(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45808, 45833);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_45759_45834(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 45759, 45834);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_45982_45994(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 45982, 45994);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                        f_25011_46082_46100(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.OperatorKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 46082, 46100);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_46437_46455(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                        this_param)
                        {
                            var return_v = this_param.RightOperand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 46437, 46455);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_46437_46462(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 46437, 46462);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_46388_46463(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 46388, 46463);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 43143, 46710);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 43143, 46710);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isIncrementedNullableForToLoopControlVariable(IFlowCaptureReferenceOperation reference)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 46726, 47517);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 46851, 47469) || true) && (f_25011_46855_46871(reference) is ISimpleAssignmentOperation assignment && (DynAbs.Tracing.TraceSender.Expression_True(25011, 46855, 46958) && f_25011_46937_46958(assignment)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 46855, 47013) && f_25011_46983_47000(assignment) == reference) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 46855, 47087) && f_25011_47038_47087(f_25011_47072_47086(reference))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 46855, 47185) && f_25011_47112_47136(f_25011_47112_47129(assignment)) is VisualBasic.Syntax.ForStatementSyntax forStmt) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 46855, 47254) && f_25011_47210_47227(assignment) == f_25011_47231_47254(forStmt)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 46855, 47316) && f_25011_47279_47295(reference) == f_25011_47299_47316(assignment)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 46855, 47396) && f_25011_47341_47364(f_25011_47341_47357(assignment)) == f_25011_47368_47396(f_25011_47368_47386(forStmt))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 46851, 47469);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 47438, 47450);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 46851, 47469);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 47489, 47502);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 46726, 47517);

                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_46855_46871(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 46855, 46871);
                            return return_v;
                        }


                        bool
                        f_25011_46937_46958(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                        this_param)
                        {
                            var return_v = this_param.IsImplicit;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 46937, 46958);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_46983_47000(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                        this_param)
                        {
                            var return_v = this_param.Target;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 46983, 47000);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_47072_47086(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47072, 47086);
                            return return_v;
                        }


                        bool
                        f_25011_47038_47087(Microsoft.CodeAnalysis.ITypeSymbol?
                        typeOpt)
                        {
                            var return_v = ITypeSymbolHelpers.IsNullableType(typeOpt);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 47038, 47087);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_47112_47129(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47112, 47129);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode?
                        f_25011_47112_47136(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47112, 47136);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_47210_47227(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47210, 47227);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_47231_47254(Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.ControlVariable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47231, 47254);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_47279_47295(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47279, 47295);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_47299_47316(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47299, 47316);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_47341_47357(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47341, 47357);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_47341_47364(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47341, 47364);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStepClauseSyntax
                        f_25011_47368_47386(Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.StepClause;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47368, 47386);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_47368_47396(Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStepClauseSyntax
                        this_param)
                        {
                            var return_v = this_param.StepValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47368, 47396);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 46726, 47517);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 46726, 47517);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isLongLivedCaptureReference(IFlowCaptureReferenceOperation reference, ControlFlowRegion region)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 47533, 47878);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 47666, 47794) || true) && (f_25011_47670_47721(f_25011_47704_47720(reference)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 47666, 47794);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 47763, 47775);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 47666, 47794);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 47814, 47863);

                        return f_25011_47821_47862(f_25011_47849_47861(reference));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 47533, 47878);

                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_47704_47720(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47704, 47720);
                            return return_v;
                        }


                        bool
                        f_25011_47670_47721(Microsoft.CodeAnalysis.SyntaxNode
                        captureReferenceSyntax)
                        {
                            var return_v = isLongLivedCaptureReferenceSyntax(captureReferenceSyntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 47670, 47721);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        f_25011_47849_47861(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 47849, 47861);
                            return return_v;
                        }


                        bool
                        f_25011_47821_47862(Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        id)
                        {
                            var return_v = isCaptureFromEnclosingGraph(id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 47821, 47862);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 47533, 47878);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 47533, 47878);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isCaptureFromEnclosingGraph(CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 47894, 48352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 47973, 48027);

                        ControlFlowRegion
                        region = f_25011_48000_48026(f_25011_48000_48010(graph))
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48047, 48304) || true) && (region != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 48047, 48304);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48110, 48229) || true) && (region.CaptureIds.Contains(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 48110, 48229);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48194, 48206);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 48110, 48229);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48253, 48285);

                                region = f_25011_48262_48284(region);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 48047, 48304);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 48047, 48304);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 48047, 48304);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48324, 48337);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 47894, 48352);

                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_48000_48010(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param)
                        {
                            var return_v = this_param.Root;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48000, 48010);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_48000_48026(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48000, 48026);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_48262_48284(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48262, 48284);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 47894, 48352);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 47894, 48352);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isConditionalAccessCaptureUsedAfterNullCheck(IOperation operation, ControlFlowRegion region, BasicBlock block, CaptureId id)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 48368, 50718);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48530, 48560);

                        SyntaxNode
                        whenNotNull = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48580, 50080) || true) && (f_25011_48584_48600(operation) == null && (DynAbs.Tracing.TraceSender.Expression_True(25011, 48584, 48647) && operation is IsNullOperation isNull) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 48584, 48708) && f_25011_48651_48670(f_25011_48651_48665(isNull)) == OperationKind.FlowCaptureReference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 48580, 50080);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48750, 50061);

                            switch (f_25011_48758_48781(f_25011_48758_48772(isNull)))
                            {

                                case LanguageNames.CSharp:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 48750, 50061);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 48922, 49032);

                                        CSharpSyntaxNode
                                        syntax = f_25011_48948_49031(f_25011_49009_49030(f_25011_49009_49023(isNull)))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 49066, 49351) || true) && (f_25011_49070_49083(syntax) is CSharp.Syntax.ConditionalAccessExpressionSyntax access && (DynAbs.Tracing.TraceSender.Expression_True(25011, 49070, 49209) && f_25011_49182_49199(access) == syntax))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 49066, 49351);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 49283, 49316);

                                            whenNotNull = f_25011_49297_49315(access);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 49066, 49351);
                                        }
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 49412, 49418);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 48750, 50061);

                                case LanguageNames.VisualBasic:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 48750, 50061);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 49542, 49645);

                                        VisualBasicSyntaxNode
                                        syntax = f_25011_49573_49644(f_25011_49622_49643(f_25011_49622_49636(isNull)))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 49679, 49969) || true) && (f_25011_49683_49696(syntax) is VisualBasic.Syntax.ConditionalAccessExpressionSyntax access && (DynAbs.Tracing.TraceSender.Expression_True(25011, 49683, 49827) && f_25011_49800_49817(access) == syntax))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 49679, 49969);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 49901, 49934);

                                            whenNotNull = f_25011_49915_49933(access);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 49679, 49969);
                                        }
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 50032, 50038);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 48750, 50061);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 48580, 50080);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50100, 50197) || true) && (whenNotNull == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 50100, 50197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50165, 50178);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 50100, 50197);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50217, 50670);
                            foreach (IFlowCaptureOperation candidate in f_25011_50261_50336_I(f_25011_50261_50336(region, f_25011_50312_50335(region))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 50217, 50670);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50378, 50651) || true) && (candidate.Id.Equals(id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 50378, 50651);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50455, 50594) || true) && (f_25011_50459_50497(whenNotNull, f_25011_50480_50496(candidate)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 50455, 50594);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50555, 50567);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 50455, 50594);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(25011, 50622, 50628);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 50378, 50651);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 50217, 50670);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 454);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 454);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50690, 50703);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 48368, 50718);

                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_48584_48600(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48584, 48600);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_48651_48665(Microsoft.CodeAnalysis.Operations.IsNullOperation
                        this_param)
                        {
                            var return_v = this_param.Operand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48651, 48665);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.OperationKind
                        f_25011_48651_48670(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48651, 48670);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_48758_48772(Microsoft.CodeAnalysis.Operations.IsNullOperation
                        this_param)
                        {
                            var return_v = this_param.Operand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48758, 48772);
                            return return_v;
                        }


                        string
                        f_25011_48758_48781(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 48758, 48781);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_49009_49023(Microsoft.CodeAnalysis.Operations.IsNullOperation
                        this_param)
                        {
                            var return_v = this_param.Operand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49009, 49023);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_49009_49030(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49009, 49030);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_48948_49031(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 48948, 49031);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_49070_49083(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49070, 49083);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_49182_49199(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49182, 49199);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_49297_49315(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.WhenNotNull;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49297, 49315);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_49622_49636(Microsoft.CodeAnalysis.Operations.IsNullOperation
                        this_param)
                        {
                            var return_v = this_param.Operand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49622, 49636);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_49622_49643(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49622, 49643);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_49573_49644(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 49573, 49644);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_49683_49696(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49683, 49696);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_49800_49817(Microsoft.CodeAnalysis.VisualBasic.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49800, 49817);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_49915_49933(Microsoft.CodeAnalysis.VisualBasic.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.WhenNotNull;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 49915, 49933);
                            return return_v;
                        }


                        int
                        f_25011_50312_50335(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LastBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 50312, 50335);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_50261_50336(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, int
                        lastBlockOrdinal)
                        {
                            var return_v = getFlowCaptureOperationsFromBlocksInRegion(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 50261, 50336);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_25011_50480_50496(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Syntax;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 50480, 50496);
                            return return_v;
                        }


                        bool
                        f_25011_50459_50497(Microsoft.CodeAnalysis.SyntaxNode
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        node)
                        {
                            var return_v = this_param.Contains(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 50459, 50497);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        f_25011_50261_50336_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 50261, 50336);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 48368, 50718);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 48368, 50718);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isLongLivedCaptureReferenceSyntax(SyntaxNode captureReferenceSyntax)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 50734, 60838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 50840, 60790);

                        switch (f_25011_50848_50879(captureReferenceSyntax))
                        {

                            case LanguageNames.CSharp:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 50840, 60790);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 51004, 51058);

                                    var
                                    syntax = (CSharpSyntaxNode)captureReferenceSyntax
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 51088, 51804);

                                    switch (f_25011_51096_51109(syntax))
                                    {

                                        case CSharp.SyntaxKind.ObjectCreationExpression:
                                        case CSharp.SyntaxKind.ImplicitObjectCreationExpression:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 51088, 51804);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 51398, 51487);

                                            var
                                            initializer = f_25011_51416_51486(((CSharp.Syntax.BaseObjectCreationExpressionSyntax)syntax))
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 51525, 51729) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(25011, 51529, 51548) || ((initializer != null && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 51551, 51588)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 51591, 51596))) ? initializer.Expressions.Any() == true : false)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 51525, 51729);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 51678, 51690);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 51525, 51729);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 51767, 51773);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 51088, 51804);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 51836, 51896);

                                    syntax = f_25011_51845_51895(syntax);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 51928, 52185) || true) && (f_25011_51932_51953_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25011_51932_51945(syntax), 25011, 51932, 51953)?.Parent) is CSharp.Syntax.UsingStatementSyntax usingStmt && (DynAbs.Tracing.TraceSender.Expression_True(25011, 51932, 52076) && f_25011_52038_52059(usingStmt) == f_25011_52063_52076(syntax)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 51928, 52185);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 52142, 52154);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 51928, 52185);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 52217, 52257);

                                    CSharpSyntaxNode
                                    parent = f_25011_52243_52256(syntax)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 52289, 56641);

                                    switch (f_25011_52304_52311(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 25011, 52297, 52311)))
                                    {

                                        case CSharp.SyntaxKind.ForEachStatement:
                                        case CSharp.SyntaxKind.ForEachVariableStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52289, 56641);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 52537, 52733) || true) && (f_25011_52541_52590(((CommonForEachStatementSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52537, 52733);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 52682, 52694);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52537, 52733);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 52771, 52777);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52289, 56641);

                                        case CSharp.SyntaxKind.Argument:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52289, 56641);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 53779, 54742) || true) && ((parent = f_25011_53793_53806(parent)) != null && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 53875) && f_25011_53819_53832(parent) == CSharp.SyntaxKind.BracketedArgumentList) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 53952) && (parent = f_25011_53930_53943(parent)) != null) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 54012) && f_25011_53956_53969(parent) == CSharp.SyntaxKind.ImplicitElementAccess) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 54111) && f_25011_54057_54070(parent) is AssignmentExpressionSyntax assignment) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 54180) && f_25011_54115_54132(assignment) == CSharp.SyntaxKind.SimpleAssignmentExpression) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 54250) && f_25011_54225_54240(assignment) == parent) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 54369) && f_25011_54313_54320(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25011_54295_54312(assignment), 25011, 54295, 54320)) == CSharp.SyntaxKind.ObjectInitializerExpression) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 53783, 54609) && (f_25011_54415_54438(f_25011_54415_54431(assignment)) == CSharp.SyntaxKind.CollectionInitializerExpression || (DynAbs.Tracing.TraceSender.Expression_False(25011, 54415, 54608) || f_25011_54536_54559(f_25011_54536_54552(assignment)) == CSharp.SyntaxKind.ObjectInitializerExpression))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 53779, 54742);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 54691, 54703);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 53779, 54742);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 54780, 54786);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52289, 56641);

                                        case CSharp.SyntaxKind.LockStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52289, 56641);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 54897, 55091) || true) && (f_25011_54901_54948(((LockStatementSyntax)f_25011_54923_54936(syntax))) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 54897, 55091);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 55040, 55052);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 54897, 55091);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 55129, 55135);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52289, 56641);

                                        case CSharp.SyntaxKind.UsingStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52289, 56641);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 55247, 55456) || true) && (f_25011_55251_55313(((CSharp.Syntax.UsingStatementSyntax)f_25011_55288_55301(syntax))) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 55247, 55456);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 55405, 55417);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 55247, 55456);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 55494, 55500);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52289, 56641);

                                        case CSharp.SyntaxKind.SwitchStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52289, 56641);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 55613, 55823) || true) && (f_25011_55617_55680(((CSharp.Syntax.SwitchStatementSyntax)f_25011_55655_55668(syntax))) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 55613, 55823);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 55772, 55784);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 55613, 55823);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 55861, 55867);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52289, 56641);

                                        case CSharp.SyntaxKind.SwitchExpression:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52289, 56641);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 55981, 56201) || true) && (f_25011_55985_56058(((CSharp.Syntax.SwitchExpressionSyntax)f_25011_56024_56037(syntax))) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 55981, 56201);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 56150, 56162);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 55981, 56201);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 56239, 56245);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52289, 56641);

                                        case CSharp.SyntaxKind.CoalesceAssignmentExpression:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 52289, 56641);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 56371, 56566) || true) && (f_25011_56375_56423(((AssignmentExpressionSyntax)f_25011_56404_56417(syntax))) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 56371, 56566);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 56515, 56527);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 56371, 56566);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 56604, 56610);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 52289, 56641);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 56696, 56702);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 50840, 60790);

                            case LanguageNames.VisualBasic:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 50840, 60790);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 56814, 56918);

                                    VisualBasicSyntaxNode
                                    syntax = f_25011_56845_56917(captureReferenceSyntax)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 56950, 57963);

                                    switch (f_25011_56958_56971(syntax))
                                    {

                                        case VisualBasic.SyntaxKind.ForStatement:
                                        case VisualBasic.SyntaxKind.ForBlock:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 56950, 57963);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 57187, 57199);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 56950, 57963);

                                        case VisualBasic.SyntaxKind.ObjectCreationExpression:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 56950, 57963);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 57326, 57402);

                                            var
                                            objCreation = (VisualBasic.Syntax.ObjectCreationExpressionSyntax)syntax
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 57440, 57888) || true) && ((f_25011_57445_57468(objCreation) is VisualBasic.Syntax.ObjectMemberInitializerSyntax memberInit && (DynAbs.Tracing.TraceSender.Expression_True(25011, 57445, 57564) && memberInit.Initializers.Any())) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 57444, 57755) || (f_25011_57611_57634(objCreation) is VisualBasic.Syntax.ObjectCollectionInitializerSyntax collectionInit && (DynAbs.Tracing.TraceSender.Expression_True(25011, 57611, 57754) && f_25011_57709_57735(collectionInit).Initializers.Any()))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 57440, 57888);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 57837, 57849);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 57440, 57888);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 57926, 57932);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 56950, 57963);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 57995, 58040);

                                    VisualBasicSyntaxNode
                                    parent = f_25011_58026_58039(syntax)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 58070, 60710);

                                    switch (f_25011_58085_58092(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 25011, 58078, 58092)))
                                    {

                                        case VisualBasic.SyntaxKind.ForEachStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58070, 60710);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 58241, 58450) || true) && (f_25011_58245_58307(((VisualBasic.Syntax.ForEachStatementSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58241, 58450);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 58399, 58411);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58241, 58450);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 58488, 58494);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58070, 60710);

                                        case VisualBasic.SyntaxKind.ForStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58070, 60710);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 58609, 58811) || true) && (f_25011_58613_58668(((VisualBasic.Syntax.ForStatementSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58609, 58811);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 58760, 58772);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58609, 58811);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 58849, 58855);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58070, 60710);

                                        case VisualBasic.SyntaxKind.ForStepClause:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58070, 60710);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 58971, 59157) || true) && (f_25011_58975_59014(((ForStepClauseSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58971, 59157);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 59106, 59118);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58971, 59157);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 59195, 59201);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58070, 60710);

                                        case VisualBasic.SyntaxKind.SyncLockStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58070, 60710);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 59321, 59531) || true) && (f_25011_59325_59388(((VisualBasic.Syntax.SyncLockStatementSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 59321, 59531);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 59480, 59492);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 59321, 59531);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 59569, 59575);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58070, 60710);

                                        case VisualBasic.SyntaxKind.UsingStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58070, 60710);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 59692, 59899) || true) && (f_25011_59696_59756(((VisualBasic.Syntax.UsingStatementSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 59692, 59899);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 59848, 59860);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 59692, 59899);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 59937, 59943);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58070, 60710);

                                        case VisualBasic.SyntaxKind.WithStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58070, 60710);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 60059, 60265) || true) && (f_25011_60063_60122(((VisualBasic.Syntax.WithStatementSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 60059, 60265);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 60214, 60226);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 60059, 60265);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 60303, 60309);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58070, 60710);

                                        case VisualBasic.SyntaxKind.SelectStatement:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 58070, 60710);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 60427, 60635) || true) && (f_25011_60431_60492(((VisualBasic.Syntax.SelectStatementSyntax)parent)) == syntax)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 60427, 60635);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 60584, 60596);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 60427, 60635);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 60673, 60679);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 58070, 60710);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 60765, 60771);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 50840, 60790);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 60810, 60823);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 50734, 60838);

                        string
                        f_25011_50848_50879(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Language;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 50848, 50879);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_51096_51109(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 51096, 51109);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax?
                        f_25011_51416_51486(Microsoft.CodeAnalysis.CSharp.Syntax.BaseObjectCreationExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Initializer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 51416, 51486);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_51845_51895(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedOrNullSuppressionIfAnyCS(syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 51845, 51895);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_51932_51945(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 51932, 51945);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_51932_51953_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 51932, 51953);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                        f_25011_52038_52059(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Declaration;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 52038, 52059);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_52063_52076(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 52063, 52076);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_52243_52256(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 52243, 52256);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                        f_25011_52304_52311(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param?.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 52304, 52311);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_52541_52590(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 52541, 52590);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_53793_53806(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 53793, 53806);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_53819_53832(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 53819, 53832);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_53930_53943(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 53930, 53943);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_53956_53969(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 53956, 53969);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_54057_54070(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 54057, 54070);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_54115_54132(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 54115, 54132);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_54225_54240(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 54225, 54240);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_54295_54312(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 54295, 54312);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                        f_25011_54313_54320(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param?.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 54313, 54320);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_54415_54431(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Right;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 54415, 54431);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_54415_54438(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 54415, 54438);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_54536_54552(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Right;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 54536, 54552);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_25011_54536_54559(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 54536, 54559);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_54923_54936(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 54923, 54936);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_54901_54948(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax?
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 54901, 54948);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_55288_55301(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 55288, 55301);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                        f_25011_55251_55313(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax?
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 55251, 55313);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_55655_55668(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 55655, 55668);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_55617_55680(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax?
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 55617, 55680);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_56024_56037(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 56024, 56037);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_55985_56058(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax?
                        this_param)
                        {
                            var return_v = this_param.GoverningExpression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 55985, 56058);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_56404_56417(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 56404, 56417);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_25011_56375_56423(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax?
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 56375, 56423);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_56845_56917(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = applyParenthesizedIfAnyVB((Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 56845, 56917);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.SyntaxKind
                        f_25011_56958_56971(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 56958, 56971);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCreationInitializerSyntax
                        f_25011_57445_57468(Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCreationExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Initializer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 57445, 57468);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCreationInitializerSyntax
                        f_25011_57611_57634(Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCreationExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Initializer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 57611, 57634);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.CollectionInitializerSyntax
                        f_25011_57709_57735(Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCollectionInitializerSyntax
                        this_param)
                        {
                            var return_v = this_param.Initializer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 57709, 57735);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_58026_58039(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 58026, 58039);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.SyntaxKind?
                        f_25011_58085_58092(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param?.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 58085, 58092);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_58245_58307(Microsoft.CodeAnalysis.VisualBasic.Syntax.ForEachStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 58245, 58307);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_58613_58668(Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.ToValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 58613, 58668);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_58975_59014(Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStepClauseSyntax
                        this_param)
                        {
                            var return_v = this_param.StepValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 58975, 59014);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_59325_59388(Microsoft.CodeAnalysis.VisualBasic.Syntax.SyncLockStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 59325, 59388);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_59696_59756(Microsoft.CodeAnalysis.VisualBasic.Syntax.UsingStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 59696, 59756);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_60063_60122(Microsoft.CodeAnalysis.VisualBasic.Syntax.WithStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 60063, 60122);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax
                        f_25011_60431_60492(Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectStatementSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 60431, 60492);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 50734, 60838);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 50734, 60838);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                CSharpSyntaxNode applyParenthesizedOrNullSuppressionIfAnyCS(CSharpSyntaxNode syntax)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 60854, 61316);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 60971, 61267) || true) && (f_25011_60978_60991(syntax) is CSharp.Syntax.ParenthesizedExpressionSyntax or
                                                                    PostfixUnaryExpressionSyntax { OperatorToken: { RawKind: (int)CSharp.SyntaxKind.ExclamationToken } })
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 60971, 61267);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61225, 61248);

                                syntax = f_25011_61234_61247(syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 60971, 61267);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 60971, 61267);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 60971, 61267);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61287, 61301);

                        return syntax;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 60854, 61316);

                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_25011_60978_60991(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 60978, 60991);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        f_25011_61234_61247(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 61234, 61247);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 60854, 61316);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 60854, 61316);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                VisualBasicSyntaxNode applyParenthesizedIfAnyVB(VisualBasicSyntaxNode syntax)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 61332, 61653);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61442, 61604) || true) && (f_25011_61463_61470(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25011_61449_61462(syntax), 25011, 61449, 61470)) == VisualBasic.SyntaxKind.ParenthesizedExpression)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 61442, 61604);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61562, 61585);

                                syntax = f_25011_61571_61584(syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 61442, 61604);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 61442, 61604);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 61442, 61604);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61624, 61638);

                        return syntax;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 61332, 61653);

                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_61449_61462(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 61449, 61462);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.SyntaxKind?
                        f_25011_61463_61470(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param?.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 61463, 61470);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        f_25011_61571_61584(Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 61571, 61584);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 61332, 61653);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 61332, 61653);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                IEnumerable<IFlowCaptureOperation> getFlowCaptureOperationsFromBlocksInRegion(ControlFlowRegion region, int lastBlockOrdinal)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 61669, 62340);

                        var listYield = new List<IFlowCaptureOperation>();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61827, 61885);

                        f_25011_61827_61884(lastBlockOrdinal <= f_25011_61860_61883(region));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61912, 61932);
                            for (int
            i = lastBlockOrdinal
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61903, 62325) || true) && (i >= f_25011_61939_61963(region))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 61965, 61968)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 61903, 62325))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 61903, 62325);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62019, 62054);
                                    for (var
                j = blocks[i].Operations.Length - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62010, 62306) || true) && (j >= 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62064, 62067)
                , j--, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 62010, 62306))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 62010, 62306);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62117, 62283) || true) && (f_25011_62121_62141(blocks[i])[j] is IFlowCaptureOperation capture)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 62117, 62283);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62235, 62256);

                                            listYield.Add(capture);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 62117, 62283);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 297);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 297);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 423);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 423);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 61669, 62340);

                        return listYield;

                        int
                        f_25011_61860_61883(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LastBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 61860, 61883);
                            return return_v;
                        }


                        int
                        f_25011_61827_61884(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 61827, 61884);
                            return 0;
                        }


                        int
                        f_25011_61939_61963(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 61939, 61963);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        f_25011_62121_62141(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Operations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 62121, 62141);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 61669, 62340);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 61669, 62340);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                IEnumerable<IFlowCaptureReferenceOperation> getFlowCaptureReferenceOperationsInRegion(ControlFlowRegion region, int firstBlockOrdinal)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 62356, 63513);

                        var listYield = new List<IFlowCaptureReferenceOperation>();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62523, 62583);

                        f_25011_62523_62582(firstBlockOrdinal >= f_25011_62557_62581(region));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62610, 62631);
                            for (int
            i = firstBlockOrdinal
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62601, 63498) || true) && (i <= f_25011_62638_62661(region))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62663, 62666)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 62601, 63498))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 62601, 63498);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62708, 62737);

                                BasicBlock
                                block = blocks[i]
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62759, 63113);
                                    foreach (IOperation operation in f_25011_62792_62808_I(f_25011_62792_62808(block)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 62759, 63113);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 62858, 63090);
                                            foreach (IFlowCaptureReferenceOperation reference in f_25011_62911_62982_I(f_25011_62911_62982(f_25011_62911_62941(operation))))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 62858, 63090);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63040, 63063);

                                                listYield.Add(reference);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 62858, 63090);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 233);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 233);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 62759, 63113);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 355);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 355);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63137, 63479) || true) && (f_25011_63141_63158(block) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 63137, 63479);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63216, 63456);
                                        foreach (IFlowCaptureReferenceOperation reference in f_25011_63269_63348_I(f_25011_63269_63348(f_25011_63269_63307(f_25011_63269_63286(block)))))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 63216, 63456);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63406, 63429);

                                            listYield.Add(reference);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 63216, 63456);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 241);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 241);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 63137, 63479);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 898);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 898);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 62356, 63513);

                        return listYield;

                        int
                        f_25011_62557_62581(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 62557, 62581);
                            return return_v;
                        }


                        int
                        f_25011_62523_62582(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 62523, 62582);
                            return 0;
                        }


                        int
                        f_25011_62638_62661(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LastBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 62638, 62661);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        f_25011_62792_62808(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Operations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 62792, 62808);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_62911_62941(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            var return_v = operation.DescendantsAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 62911, 62941);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_62911_62982(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        source)
                        {
                            var return_v = source.OfType<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 62911, 62982);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_62911_62982_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 62911, 62982);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        f_25011_62792_62808_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 62792, 62808);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_63141_63158(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 63141, 63158);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_63269_63286(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 63269, 63286);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_63269_63307(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            var return_v = operation.DescendantsAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 63269, 63307);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_63269_63348(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        source)
                        {
                            var return_v = source.OfType<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 63269, 63348);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        f_25011_63269_63348_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 63269, 63348);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 62356, 63513);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 62356, 63513);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string getDestinationString(ref ControlFlowBranch branch)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 63529, 63710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63619, 63695);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(25011, 63626, 63652) || ((f_25011_63626_63644(branch) != null && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 63655, 63685)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 63688, 63694))) ? f_25011_63655_63685(f_25011_63666_63684(branch)) : "null";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 63529, 63710);

                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                        f_25011_63626_63644(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 63626, 63644);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_63666_63684(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 63666, 63684);
                            return return_v;
                        }


                        string
                        f_25011_63655_63685(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 63655, 63685);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 63529, 63710);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 63529, 63710);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                PooledObjects.PooledDictionary<ControlFlowRegion, int> buildRegionMap()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 63726, 64335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63830, 63912);

                        var
                        result = f_25011_63843_63911()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63930, 63946);

                        int
                        ordinal = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 63964, 63982);

                        f_25011_63964_63981(f_25011_63970_63980(graph));

                        void visit(ControlFlowRegion region)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 64002, 64286);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64079, 64109);

                                f_25011_64079_64108(result, region, ordinal++);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64133, 64267);
                                    foreach (ControlFlowRegion r in f_25011_64165_64185_I(f_25011_64165_64185(region)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 64133, 64267);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64235, 64244);

                                        f_25011_64235_64243(r);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 64133, 64267);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 135);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 135);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 64002, 64286);

                                int
                                f_25011_64079_64108(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion, int>
                                this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                                key, int
                                value)
                                {
                                    this_param.Add(key, value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64079, 64108);
                                    return 0;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                                f_25011_64165_64185(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                                this_param)
                                {
                                    var return_v = this_param.NestedRegions;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 64165, 64185);
                                    return return_v;
                                }


                                int
                                f_25011_64235_64243(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                                region)
                                {
                                    visit(region);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64235, 64243);
                                    return 0;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                                f_25011_64165_64185_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64165, 64185);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 64002, 64286);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 64002, 64286);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64306, 64320);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 63726, 64335);

                        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion, int>
                        f_25011_63843_63911()
                        {
                            var return_v = PooledObjects.PooledDictionary<ControlFlowRegion, int>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 63843, 63911);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_63970_63980(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param)
                        {
                            var return_v = this_param.Root;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 63970, 63980);
                            return return_v;
                        }


                        int
                        f_25011_63964_63981(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            visit(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 63964, 63981);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 63726, 64335);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 63726, 64335);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                void appendLine(string line)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 64351, 64491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64412, 64427);

                        f_25011_64412_64426();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64445, 64476);

                        f_25011_64445_64475(stringBuilder, line);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 64351, 64491);

                        int
                        f_25011_64412_64426()
                        {
                            appendIndent();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64412, 64426);
                            return 0;
                        }


                        System.Text.StringBuilder
                        f_25011_64445_64475(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.AppendLine(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64445, 64475);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 64351, 64491);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 64351, 64491);
                    }
                }

                void appendIndent()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 64507, 64608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64559, 64593);

                        f_25011_64559_64592(stringBuilder, ' ', indent);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 64507, 64608);

                        System.Text.StringBuilder
                        f_25011_64559_64592(System.Text.StringBuilder
                        this_param, char
                        value, int
                        repeatCount)
                        {
                            var return_v = this_param.Append(value, repeatCount);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64559, 64592);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 64507, 64608);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 64507, 64608);
                    }
                }

                void printLocals(ControlFlowRegion region)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 64624, 65967);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64699, 65101) || true) && (f_25011_64703_64725_M(!region.Locals.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 64699, 65101);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64767, 64782);

                            f_25011_64767_64781();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64804, 64836);

                            f_25011_64804_64835(stringBuilder, "Locals:");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64858, 65033);
                                foreach (ILocalSymbol local in f_25011_64889_64902_I(f_25011_64889_64902(region)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 64858, 65033);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 64952, 65010);

                                    f_25011_64952_65009(stringBuilder, $" [{f_25011_64978_65005(local)}]");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 64858, 65033);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 176);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 176);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65055, 65082);

                            f_25011_65055_65081(stringBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 64699, 65101);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65121, 65543) || true) && (f_25011_65125_65155_M(!region.LocalFunctions.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 65121, 65543);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65197, 65212);

                            f_25011_65197_65211();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65234, 65267);

                            f_25011_65234_65266(stringBuilder, "Methods:");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65289, 65475);
                                foreach (IMethodSymbol method in f_25011_65322_65343_I(f_25011_65322_65343(region)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 65289, 65475);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65393, 65452);

                                    f_25011_65393_65451(stringBuilder, $" [{f_25011_65419_65447(method)}]");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 65289, 65475);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 187);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 187);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65497, 65524);

                            f_25011_65497_65523(stringBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 65121, 65543);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65563, 65952) || true) && (f_25011_65567_65593_M(!region.CaptureIds.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 65563, 65952);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65635, 65650);

                            f_25011_65635_65649();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65672, 65708);

                            f_25011_65672_65707(stringBuilder, "CaptureIds:");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65730, 65884);
                                foreach (CaptureId id in f_25011_65755_65772_I(f_25011_65755_65772(region)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 65730, 65884);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65822, 65861);

                                    f_25011_65822_65860(stringBuilder, $" [{id.Value}]");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 65730, 65884);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 155);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 155);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 65906, 65933);

                            f_25011_65906_65932(stringBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 65563, 65952);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 64624, 65967);

                        bool
                        f_25011_64703_64725_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 64703, 64725);
                            return return_v;
                        }


                        int
                        f_25011_64767_64781()
                        {
                            appendIndent();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64767, 64781);
                            return 0;
                        }


                        System.Text.StringBuilder
                        f_25011_64804_64835(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64804, 64835);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        f_25011_64889_64902(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 64889, 64902);
                            return return_v;
                        }


                        string
                        f_25011_64978_65005(Microsoft.CodeAnalysis.ILocalSymbol
                        symbol)
                        {
                            var return_v = symbol.ToTestDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64978, 65005);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_25011_64952_65009(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64952, 65009);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        f_25011_64889_64902_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 64889, 64902);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_25011_65055_65081(System.Text.StringBuilder
                        this_param)
                        {
                            var return_v = this_param.AppendLine();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65055, 65081);
                            return return_v;
                        }


                        bool
                        f_25011_65125_65155_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 65125, 65155);
                            return return_v;
                        }


                        int
                        f_25011_65197_65211()
                        {
                            appendIndent();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65197, 65211);
                            return 0;
                        }


                        System.Text.StringBuilder
                        f_25011_65234_65266(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65234, 65266);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        f_25011_65322_65343(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LocalFunctions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 65322, 65343);
                            return return_v;
                        }


                        string
                        f_25011_65419_65447(Microsoft.CodeAnalysis.IMethodSymbol
                        symbol)
                        {
                            var return_v = symbol.ToTestDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65419, 65447);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_25011_65393_65451(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65393, 65451);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        f_25011_65322_65343_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65322, 65343);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_25011_65497_65523(System.Text.StringBuilder
                        this_param)
                        {
                            var return_v = this_param.AppendLine();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65497, 65523);
                            return return_v;
                        }


                        bool
                        f_25011_65567_65593_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 65567, 65593);
                            return return_v;
                        }


                        int
                        f_25011_65635_65649()
                        {
                            appendIndent();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65635, 65649);
                            return 0;
                        }


                        System.Text.StringBuilder
                        f_25011_65672_65707(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65672, 65707);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_65755_65772(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.CaptureIds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 65755, 65772);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_25011_65822_65860(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65822, 65860);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_65755_65772_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65755, 65772);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_25011_65906_65932(System.Text.StringBuilder
                        this_param)
                        {
                            var return_v = this_param.AppendLine();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 65906, 65932);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 64624, 65967);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 64624, 65967);
                    }
                }

                void enterRegions(ControlFlowRegion region, int firstBlockOrdinal)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 65983, 70987);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66082, 66425) || true) && (f_25011_66086_66110(region) != firstBlockOrdinal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66082, 66425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66173, 66214);

                            f_25011_66173_66213(currentRegion, region);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66238, 66375) || true) && (lastPrintedBlockIsInCurrentRegion)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66238, 66375);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66325, 66352);

                                f_25011_66325_66351(stringBuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66238, 66375);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66399, 66406);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66082, 66425);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66445, 66501);

                        f_25011_66445_66500(f_25011_66458_66480(region), firstBlockOrdinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66519, 66542);

                        currentRegion = region;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66560, 66601);

                        lastPrintedBlockIsInCurrentRegion = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66621, 70728);

                        switch (f_25011_66629_66640(region))
                        {

                            case ControlFlowRegionKind.Filter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66742, 66776);

                                f_25011_66742_66775(f_25011_66761_66774(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66802, 66844);

                                f_25011_66802_66843(f_25011_66821_66842(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66870, 66950);

                                f_25011_66870_66949(firstBlockOrdinal, f_25011_66908_66948(f_25011_66908_66930(region)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 66976, 67054);

                                f_25011_66976_67053(f_25011_66994_67014(region), f_25011_67016_67052(f_25011_67016_67038(region)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 67080, 67130);

                                f_25011_67080_67129($".filter {{{f_25011_67105_67124(region)}}}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 67156, 67162);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.Try:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 67241, 67281);

                                f_25011_67241_67280(f_25011_67259_67279(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 67307, 67387);

                                f_25011_67307_67386(firstBlockOrdinal, f_25011_67345_67385(f_25011_67345_67367(region)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 67413, 67499);

                                f_25011_67413_67498($".try {{{f_25011_67435_67470(f_25011_67447_67469(region))}, {f_25011_67474_67493(region)}}}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 67525, 67531);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.FilterAndHandler:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 67658, 67765);

                                var
                                exceptionTypeText = (DynAbs.Tracing.TraceSender.Conditional_F1(25011, 67682, 67710) || ((f_25011_67682_67702(region) != null && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 67713, 67755)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 67758, 67764))) ? f_25011_67713_67755(f_25011_67713_67733(region)) : "null"
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 67791, 67862);

                                f_25011_67791_67861($".catch {{{f_25011_67815_67834(region)}}} ({exceptionTypeText})");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 67888, 67894);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.Finally:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 67977, 68017);

                                f_25011_67977_68016(f_25011_67995_68015(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 68043, 68094);

                                f_25011_68043_68093($".finally {{{f_25011_68069_68088(region)}}}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 68120, 68126);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.Catch:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 68207, 69171);

                                switch (f_25011_68215_68242(f_25011_68215_68237(region)))
                                {

                                    case ControlFlowRegionKind.FilterAndHandler:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 68207, 69171);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 68378, 68456);

                                        f_25011_68378_68455(f_25011_68396_68416(region), f_25011_68418_68454(f_25011_68418_68440(region)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 68490, 68541);

                                        f_25011_68490_68540($".handler {{{f_25011_68516_68535(region)}}}");
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 68575, 68581);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 68207, 69171);

                                    case ControlFlowRegionKind.TryAndCatch:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 68207, 69171);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 68684, 68798);

                                        var
                                        anotherExceptionTypeText = (DynAbs.Tracing.TraceSender.Conditional_F1(25011, 68715, 68743) || ((f_25011_68715_68735(region) != null && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 68746, 68788)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 68791, 68797))) ? f_25011_68746_68788(f_25011_68746_68766(region)) : "null"
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 68832, 68910);

                                        f_25011_68832_68909($".catch {{{f_25011_68856_68875(region)}}} ({anotherExceptionTypeText})");
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 68944, 68950);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 68207, 69171);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 68207, 69171);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69022, 69104);

                                        f_25011_69022_69103(true, $"Unexpected region kind {f_25011_69073_69100(f_25011_69073_69095(region))}");
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 69138, 69144);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 68207, 69171);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 69197, 69203);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.LocalLifetime:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69292, 69332);

                                f_25011_69292_69331(f_25011_69310_69330(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69358, 69462);

                                f_25011_69358_69461(region.Locals.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(25011, 69377, 69431) && region.LocalFunctions.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 69377, 69460) && region.CaptureIds.IsEmpty));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69488, 69538);

                                f_25011_69488_69537($".locals {{{f_25011_69513_69532(region)}}}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 69564, 69570);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.TryAndCatch:
                            case ControlFlowRegionKind.TryAndFinally:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69722, 69756);

                                f_25011_69722_69755(f_25011_69741_69754(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69782, 69824);

                                f_25011_69782_69823(f_25011_69801_69822(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69850, 69888);

                                f_25011_69850_69887(f_25011_69869_69886(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 69914, 69954);

                                f_25011_69914_69953(f_25011_69932_69952(region));
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 69980, 69986);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.StaticLocalInitializer:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70086, 70126);

                                f_25011_70086_70125(f_25011_70104_70124(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70152, 70186);

                                f_25011_70152_70185(f_25011_70171_70184(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70212, 70274);

                                f_25011_70212_70273($".static initializer {{{f_25011_70249_70268(region)}}}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 70300, 70306);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            case ControlFlowRegionKind.ErroneousBody:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70397, 70437);

                                f_25011_70397_70436(f_25011_70415_70435(region));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70463, 70521);

                                f_25011_70463_70520($".erroneous body {{{f_25011_70496_70515(region)}}}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 70547, 70553);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 66621, 70728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70611, 70677);

                                f_25011_70611_70676(true, $"Unexpected region kind {f_25011_70662_70673(region)}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 70703, 70709);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 66621, 70728);
                        }

                        void enterRegion(string header)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 70748, 70972);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70820, 70839);

                                f_25011_70820_70838(header);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70861, 70877);

                                f_25011_70861_70876("{");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70899, 70911);

                                indent += 4;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 70933, 70953);

                                f_25011_70933_70952(region);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 70748, 70972);

                                int
                                f_25011_70820_70838(string
                                line)
                                {
                                    appendLine(line);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70820, 70838);
                                    return 0;
                                }


                                int
                                f_25011_70861_70876(string
                                line)
                                {
                                    appendLine(line);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70861, 70876);
                                    return 0;
                                }


                                int
                                f_25011_70933_70952(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                                region)
                                {
                                    printLocals(region);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70933, 70952);
                                    return 0;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 70748, 70972);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 70748, 70972);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 65983, 70987);

                        int
                        f_25011_66086_66110(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66086, 66110);
                            return return_v;
                        }


                        bool
                        f_25011_66173_66213(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        actual)
                        {
                            var return_v = CustomAssert.Same((object)expected, (object)actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 66173, 66213);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_25011_66325_66351(System.Text.StringBuilder
                        this_param)
                        {
                            var return_v = this_param.AppendLine();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 66325, 66351);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_66458_66480(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66458, 66480);
                            return return_v;
                        }


                        int
                        f_25011_66445_66500(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        region, int
                        firstBlockOrdinal)
                        {
                            enterRegions(region, firstBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 66445, 66500);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_66629_66640(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66629, 66640);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        f_25011_66761_66774(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66761, 66774);
                            return return_v;
                        }


                        bool
                        f_25011_66742_66775(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 66742, 66775);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        f_25011_66821_66842(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LocalFunctions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66821, 66842);
                            return return_v;
                        }


                        bool
                        f_25011_66802_66843(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 66802, 66843);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_66908_66930(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66908, 66930);
                            return return_v;
                        }


                        int
                        f_25011_66908_66948(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66908, 66948);
                            return return_v;
                        }


                        bool
                        f_25011_66870_66949(int
                        expected, int
                        actual)
                        {
                            var return_v = CustomAssert.Equal(expected, actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 66870, 66949);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_66994_67014(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 66994, 67014);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_67016_67038(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67016, 67038);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_67016_67052(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67016, 67052);
                            return return_v;
                        }


                        bool
                        f_25011_66976_67053(Microsoft.CodeAnalysis.ITypeSymbol?
                        expected, Microsoft.CodeAnalysis.ITypeSymbol?
                        actual)
                        {
                            var return_v = CustomAssert.Same((object?)expected, (object?)actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 66976, 67053);
                            return return_v;
                        }


                        string
                        f_25011_67105_67124(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67105, 67124);
                            return return_v;
                        }


                        int
                        f_25011_67080_67129(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67080, 67129);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_67259_67279(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67259, 67279);
                            return return_v;
                        }


                        bool
                        f_25011_67241_67280(Microsoft.CodeAnalysis.ITypeSymbol?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67241, 67280);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_67345_67367(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67345, 67367);
                            return return_v;
                        }


                        int
                        f_25011_67345_67385(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.FirstBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67345, 67385);
                            return return_v;
                        }


                        bool
                        f_25011_67307_67386(int
                        expected, int
                        actual)
                        {
                            var return_v = CustomAssert.Equal(expected, actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67307, 67386);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_67447_67469(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67447, 67469);
                            return return_v;
                        }


                        string
                        f_25011_67435_67470(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67435, 67470);
                            return return_v;
                        }


                        string
                        f_25011_67474_67493(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67474, 67493);
                            return return_v;
                        }


                        int
                        f_25011_67413_67498(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67413, 67498);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_67682_67702(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67682, 67702);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_25011_67713_67733(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67713, 67733);
                            return return_v;
                        }


                        string
                        f_25011_67713_67755(Microsoft.CodeAnalysis.ITypeSymbol
                        symbol)
                        {
                            var return_v = symbol.ToTestDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67713, 67755);
                            return return_v;
                        }


                        string
                        f_25011_67815_67834(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67815, 67834);
                            return return_v;
                        }


                        int
                        f_25011_67791_67861(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67791, 67861);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_67995_68015(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 67995, 68015);
                            return return_v;
                        }


                        bool
                        f_25011_67977_68016(Microsoft.CodeAnalysis.ITypeSymbol?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 67977, 68016);
                            return return_v;
                        }


                        string
                        f_25011_68069_68088(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68069, 68088);
                            return return_v;
                        }


                        int
                        f_25011_68043_68093(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68043, 68093);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_68215_68237(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 68215, 68237);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_68215_68242(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 68215, 68242);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_68396_68416(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 68396, 68416);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_68418_68440(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 68418, 68440);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_68418_68454(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 68418, 68454);
                            return return_v;
                        }


                        bool
                        f_25011_68378_68455(Microsoft.CodeAnalysis.ITypeSymbol?
                        expected, Microsoft.CodeAnalysis.ITypeSymbol?
                        actual)
                        {
                            var return_v = CustomAssert.Same((object?)expected, (object?)actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68378, 68455);
                            return return_v;
                        }


                        string
                        f_25011_68516_68535(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68516, 68535);
                            return return_v;
                        }


                        int
                        f_25011_68490_68540(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68490, 68540);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_68715_68735(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 68715, 68735);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_25011_68746_68766(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 68746, 68766);
                            return return_v;
                        }


                        string
                        f_25011_68746_68788(Microsoft.CodeAnalysis.ITypeSymbol
                        symbol)
                        {
                            var return_v = symbol.ToTestDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68746, 68788);
                            return return_v;
                        }


                        string
                        f_25011_68856_68875(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68856, 68875);
                            return return_v;
                        }


                        int
                        f_25011_68832_68909(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 68832, 68909);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_69073_69095(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 69073, 69095);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_69073_69100(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 69073, 69100);
                            return return_v;
                        }


                        bool
                        f_25011_69022_69103(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.False(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69022, 69103);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_69310_69330(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 69310, 69330);
                            return return_v;
                        }


                        bool
                        f_25011_69292_69331(Microsoft.CodeAnalysis.ITypeSymbol?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69292, 69331);
                            return return_v;
                        }


                        bool
                        f_25011_69358_69461(bool
                        condition)
                        {
                            var return_v = CustomAssert.False(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69358, 69461);
                            return return_v;
                        }


                        string
                        f_25011_69513_69532(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69513, 69532);
                            return return_v;
                        }


                        int
                        f_25011_69488_69537(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69488, 69537);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        f_25011_69741_69754(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 69741, 69754);
                            return return_v;
                        }


                        bool
                        f_25011_69722_69755(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69722, 69755);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        f_25011_69801_69822(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LocalFunctions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 69801, 69822);
                            return return_v;
                        }


                        bool
                        f_25011_69782_69823(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69782, 69823);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_69869_69886(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.CaptureIds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 69869, 69886);
                            return return_v;
                        }


                        bool
                        f_25011_69850_69887(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69850, 69887);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_69932_69952(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 69932, 69952);
                            return return_v;
                        }


                        bool
                        f_25011_69914_69953(Microsoft.CodeAnalysis.ITypeSymbol?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 69914, 69953);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_70104_70124(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 70104, 70124);
                            return return_v;
                        }


                        bool
                        f_25011_70086_70125(Microsoft.CodeAnalysis.ITypeSymbol?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70086, 70125);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        f_25011_70171_70184(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 70171, 70184);
                            return return_v;
                        }


                        bool
                        f_25011_70152_70185(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70152, 70185);
                            return return_v;
                        }


                        string
                        f_25011_70249_70268(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70249, 70268);
                            return return_v;
                        }


                        int
                        f_25011_70212_70273(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70212, 70273);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_25011_70415_70435(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.ExceptionType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 70415, 70435);
                            return return_v;
                        }


                        bool
                        f_25011_70397_70436(Microsoft.CodeAnalysis.ITypeSymbol?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70397, 70436);
                            return return_v;
                        }


                        string
                        f_25011_70496_70515(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70496, 70515);
                            return return_v;
                        }


                        int
                        f_25011_70463_70520(string
                        header)
                        {
                            enterRegion(header);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70463, 70520);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_70662_70673(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 70662, 70673);
                            return return_v;
                        }


                        bool
                        f_25011_70611_70676(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.False(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 70611, 70676);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 65983, 70987);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 65983, 70987);
                    }
                }

                void leaveRegions(ControlFlowRegion region, int lastBlockOrdinal)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 71003, 73782);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71101, 71325) || true) && (f_25011_71105_71128(region) != lastBlockOrdinal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 71101, 71325);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71190, 71213);

                            currentRegion = region;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71235, 71277);

                            lastPrintedBlockIsInCurrentRegion = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71299, 71306);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 71101, 71325);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71345, 71383);

                        string
                        regionId = f_25011_71363_71382(region)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71410, 71415);
                            for (var
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71401, 72088) || true) && (i < region.LocalFunctions.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71451, 71454)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 71401, 72088))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 71401, 72088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71496, 71534);

                                var
                                method = f_25011_71509_71530(region)[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71556, 71571);

                                f_25011_71556_71570("");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71593, 71643);

                                f_25011_71593_71642("{   " + f_25011_71613_71641(method));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71665, 71680);

                                f_25011_71665_71679("");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71702, 71757);

                                var
                                g = f_25011_71710_71756(graph, method)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71779, 71812);

                                f_25011_71779_71811(localFunctionsMap, method, g);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71834, 71908);

                                f_25011_71834_71907(OperationKind.LocalFunction, f_25011_71882_71906(f_25011_71882_71901(g)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 71930, 72031);

                                f_25011_71930_72030(stringBuilder, compilation, g, region, $"#{i}{regionId}", indent + 4, associatedSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 72053, 72069);

                                f_25011_72053_72068("}");
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 688);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 688);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 72108, 73692);

                        switch (f_25011_72116_72127(region))
                        {

                            case ControlFlowRegionKind.LocalLifetime:
                            case ControlFlowRegionKind.Filter:
                            case ControlFlowRegionKind.Try:
                            case ControlFlowRegionKind.Finally:
                            case ControlFlowRegionKind.FilterAndHandler:
                            case ControlFlowRegionKind.StaticLocalInitializer:
                            case ControlFlowRegionKind.ErroneousBody:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 72108, 73692);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 72603, 72615);

                                indent -= 4;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 72641, 72657);

                                f_25011_72641_72656("}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 72683, 72689);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 72108, 73692);

                            case ControlFlowRegionKind.Catch:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 72108, 73692);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 72770, 73248);

                                switch (f_25011_72778_72805(f_25011_72778_72800(region)))
                                {

                                    case ControlFlowRegionKind.FilterAndHandler:
                                    case ControlFlowRegionKind.TryAndCatch:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 72770, 73248);

                                        goto endRegion;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 72770, 73248);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 72770, 73248);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 73099, 73181);

                                        f_25011_73099_73180(true, $"Unexpected region kind {f_25011_73150_73177(f_25011_73150_73172(region))}");
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 73215, 73221);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 72770, 73248);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 73276, 73282);

                                break;

endRegion:

                                goto case ControlFlowRegionKind.Filter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 72108, 73692);

                            case ControlFlowRegionKind.TryAndCatch:
                            case ControlFlowRegionKind.TryAndFinally:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 72108, 73692);
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 73513, 73519);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 72108, 73692);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 72108, 73692);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 73575, 73641);

                                f_25011_73575_73640(true, $"Unexpected region kind {f_25011_73626_73637(region)}");
                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 73667, 73673);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 72108, 73692);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 73712, 73767);

                        f_25011_73712_73766(f_25011_73725_73747(region), lastBlockOrdinal);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 71003, 73782);

                        int
                        f_25011_71105_71128(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LastBlockOrdinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 71105, 71128);
                            return return_v;
                        }


                        string
                        f_25011_71363_71382(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region)
                        {
                            var return_v = getRegionId(region);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71363, 71382);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        f_25011_71509_71530(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LocalFunctions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 71509, 71530);
                            return return_v;
                        }


                        int
                        f_25011_71556_71570(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71556, 71570);
                            return 0;
                        }


                        string
                        f_25011_71613_71641(Microsoft.CodeAnalysis.IMethodSymbol
                        symbol)
                        {
                            var return_v = symbol.ToTestDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71613, 71641);
                            return return_v;
                        }


                        int
                        f_25011_71593_71642(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71593, 71642);
                            return 0;
                        }


                        int
                        f_25011_71665_71679(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71665, 71679);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        f_25011_71710_71756(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param, Microsoft.CodeAnalysis.IMethodSymbol
                        localFunction)
                        {
                            var return_v = this_param.GetLocalFunctionControlFlowGraph(localFunction);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71710, 71756);
                            return return_v;
                        }


                        int
                        f_25011_71779_71811(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                        this_param, Microsoft.CodeAnalysis.IMethodSymbol
                        key, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71779, 71811);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_71882_71901(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        this_param)
                        {
                            var return_v = this_param.OriginalOperation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 71882, 71901);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.OperationKind
                        f_25011_71882_71906(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 71882, 71906);
                            return return_v;
                        }


                        bool
                        f_25011_71834_71907(Microsoft.CodeAnalysis.OperationKind
                        expected, Microsoft.CodeAnalysis.OperationKind
                        actual)
                        {
                            var return_v = CustomAssert.Equal(expected, actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71834, 71907);
                            return return_v;
                        }


                        int
                        f_25011_71930_72030(System.Text.StringBuilder
                        stringBuilder, Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        graph, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        enclosing, string
                        idSuffix, int
                        indent, Microsoft.CodeAnalysis.ISymbol
                        associatedSymbol)
                        {
                            GetFlowGraph(stringBuilder, compilation, graph, enclosing, idSuffix, indent, associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 71930, 72030);
                            return 0;
                        }


                        int
                        f_25011_72053_72068(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 72053, 72068);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_72116_72127(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 72116, 72127);
                            return return_v;
                        }


                        int
                        f_25011_72641_72656(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 72641, 72656);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_72778_72800(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 72778, 72800);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_72778_72805(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 72778, 72805);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_73150_73172(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 73150, 73172);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_73150_73177(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 73150, 73177);
                            return return_v;
                        }


                        bool
                        f_25011_73099_73180(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.False(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 73099, 73180);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                        f_25011_73626_73637(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 73626, 73637);
                            return return_v;
                        }


                        bool
                        f_25011_73575_73640(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.False(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 73575, 73640);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_73725_73747(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 73725, 73747);
                            return return_v;
                        }


                        int
                        f_25011_73712_73766(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        region, int
                        lastBlockOrdinal)
                        {
                            leaveRegions(region, lastBlockOrdinal);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 73712, 73766);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 71003, 73782);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 71003, 73782);
                    }
                }

                void validateBranch(BasicBlock fromBlock, ControlFlowBranch branch)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 73798, 76743);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 73898, 74665) || true) && (f_25011_73902_73920(branch) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 73898, 74665);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 73970, 74012);

                            f_25011_73970_74011(f_25011_73989_74010(branch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 74034, 74076);

                            f_25011_74034_74075(f_25011_74053_74074(branch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 74098, 74141);

                            f_25011_74098_74140(f_25011_74117_74139(branch));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 74163, 74617);

                            f_25011_74163_74616(ControlFlowBranchSemantics.None == f_25011_74216_74232(branch) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 74181, 74288) || ControlFlowBranchSemantics.Throw == f_25011_74272_74288(branch)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 74181, 74379) || ControlFlowBranchSemantics.Rethrow == f_25011_74363_74379(branch)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 74181, 74457) || ControlFlowBranchSemantics.StructuredExceptionHandling == f_25011_74441_74457(branch)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 74181, 74559) || ControlFlowBranchSemantics.ProgramTermination == f_25011_74543_74559(branch)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 74181, 74615) || ControlFlowBranchSemantics.Error == f_25011_74599_74615(branch)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 74639, 74646);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 73898, 74665);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 74685, 74816);

                        f_25011_74685_74815(ControlFlowBranchSemantics.Regular == f_25011_74741_74757(branch) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 74703, 74814) || ControlFlowBranchSemantics.Return == f_25011_74798_74814(branch)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 74834, 74922);

                        var temp = f_25011_74852_74870(branch).Predecessors;
                        f_25011_74834_74921(f_25011_74852_74920(ref temp, p => p.Source == fromBlock));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 74942, 75107) || true) && (f_25011_74946_74976_M(!branch.FinallyRegions.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 74942, 75107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75018, 75088);

                            f_25011_75018_75087($"        Finalizing:" + f_25011_75054_75086(f_25011_75064_75085(branch)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 74942, 75107);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75127, 75185);

                        ControlFlowRegion
                        remainedIn1 = f_25011_75159_75184(fromBlock)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75203, 75605) || true) && (f_25011_75207_75237_M(!branch.LeavingRegions.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 75203, 75605);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75279, 75346);

                            f_25011_75279_75345($"        Leaving:" + f_25011_75312_75344(f_25011_75322_75343(branch)));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75368, 75586);
                                foreach (ControlFlowRegion r in f_25011_75400_75421_I(f_25011_75400_75421(branch)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 75368, 75586);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75471, 75505);

                                    f_25011_75471_75504(remainedIn1, r);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75531, 75563);

                                    remainedIn1 = f_25011_75545_75562(r);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 75368, 75586);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 219);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 219);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 75203, 75605);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75625, 75692);

                        ControlFlowRegion
                        remainedIn2 = f_25011_75657_75691(f_25011_75657_75675(branch))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75710, 76195) || true) && (f_25011_75714_75745_M(!branch.EnteringRegions.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 75710, 76195);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75787, 75856);

                            f_25011_75787_75855($"        Entering:" + f_25011_75821_75854(f_25011_75831_75853(branch)));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75887, 75924);
                                for (int
            j = branch.EnteringRegions.Length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75878, 76176) || true) && (j >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75934, 75937)
            , j--, DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 75878, 76176))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 75878, 76176);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 75987, 76035);

                                    ControlFlowRegion
                                    r = f_25011_76009_76031(branch)[j]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76061, 76095);

                                    f_25011_76061_76094(remainedIn2, r);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76121, 76153);

                                    remainedIn2 = f_25011_76135_76152(r);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 299);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 299);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 75710, 76195);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76215, 76291);

                        f_25011_76215_76290(f_25011_76233_76260(remainedIn1), f_25011_76262_76289(remainedIn2));

                        string buildList(ImmutableArray<ControlFlowRegion> list)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 76311, 76728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76408, 76470);

                                var
                                builder = f_25011_76422_76469()
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76494, 76652);
                                    foreach (ControlFlowRegion r in f_25011_76526_76530_I(list))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 76494, 76652);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76580, 76629);

                                        f_25011_76580_76628(builder.Builder, $" {{{f_25011_76609_76623(r)}}}");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 76494, 76652);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 159);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 159);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76676, 76709);

                                return f_25011_76683_76708(builder);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 76311, 76728);

                                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                                f_25011_76422_76469()
                                {
                                    var return_v = PooledObjects.PooledStringBuilder.GetInstance();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76422, 76469);
                                    return return_v;
                                }


                                string
                                f_25011_76609_76623(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                                region)
                                {
                                    var return_v = getRegionId(region);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76609, 76623);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_25011_76580_76628(System.Text.StringBuilder
                                this_param, string
                                value)
                                {
                                    var return_v = this_param.Append(value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76580, 76628);
                                    return return_v;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                                f_25011_76526_76530_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76526, 76530);
                                    return return_v;
                                }


                                string
                                f_25011_76683_76708(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                                this_param)
                                {
                                    var return_v = this_param.ToStringAndFree();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76683, 76708);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 76311, 76728);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 76311, 76728);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 73798, 76743);

                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                        f_25011_73902_73920(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 73902, 73920);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_73989_74010(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.FinallyRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 73989, 74010);
                            return return_v;
                        }


                        bool
                        f_25011_73970_74011(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 73970, 74011);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_74053_74074(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.LeavingRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74053, 74074);
                            return return_v;
                        }


                        bool
                        f_25011_74034_74075(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 74034, 74075);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_74117_74139(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.EnteringRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74117, 74139);
                            return return_v;
                        }


                        bool
                        f_25011_74098_74140(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        enumerable)
                        {
                            var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 74098, 74140);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74216_74232(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74216, 74232);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74272_74288(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74272, 74288);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74363_74379(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74363, 74379);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74441_74457(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74441, 74457);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74543_74559(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74543, 74559);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74599_74615(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74599, 74615);
                            return return_v;
                        }


                        bool
                        f_25011_74163_74616(bool
                        condition)
                        {
                            var return_v = CustomAssert.True(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 74163, 74616);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74741_74757(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74741, 74757);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                        f_25011_74798_74814(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Semantics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74798, 74814);
                            return return_v;
                        }


                        bool
                        f_25011_74685_74815(bool
                        condition)
                        {
                            var return_v = CustomAssert.True(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 74685, 74815);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_74852_74870(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74852, 74870);
                            return return_v;
                        }


                        bool
                        f_25011_74852_74920(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                        sequence, System.Func<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch, bool>
                        predicate)
                        {
                            var return_v = sequence.Contains<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>(predicate);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 74852, 74920);
                            return return_v;
                        }


                        bool
                        f_25011_74834_74921(bool
                        condition)
                        {
                            var return_v = CustomAssert.True(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 74834, 74921);
                            return return_v;
                        }


                        bool
                        f_25011_74946_74976_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 74946, 74976);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_75064_75085(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.FinallyRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75064, 75085);
                            return return_v;
                        }


                        string
                        f_25011_75054_75086(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        list)
                        {
                            var return_v = buildList(list);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75054, 75086);
                            return return_v;
                        }


                        int
                        f_25011_75018_75087(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75018, 75087);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_75159_75184(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75159, 75184);
                            return return_v;
                        }


                        bool
                        f_25011_75207_75237_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75207, 75237);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_75322_75343(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.LeavingRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75322, 75343);
                            return return_v;
                        }


                        string
                        f_25011_75312_75344(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        list)
                        {
                            var return_v = buildList(list);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75312, 75344);
                            return return_v;
                        }


                        int
                        f_25011_75279_75345(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75279, 75345);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_75400_75421(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.LeavingRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75400, 75421);
                            return return_v;
                        }


                        bool
                        f_25011_75471_75504(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        actual)
                        {
                            var return_v = CustomAssert.Same((object?)expected, (object)actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75471, 75504);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_75545_75562(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75545, 75562);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_75400_75421_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75400, 75421);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        f_25011_75657_75675(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.Destination;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75657, 75675);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_75657_75691(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75657, 75691);
                            return return_v;
                        }


                        bool
                        f_25011_75714_75745_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75714, 75745);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_75831_75853(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.EnteringRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 75831, 75853);
                            return return_v;
                        }


                        string
                        f_25011_75821_75854(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        list)
                        {
                            var return_v = buildList(list);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75821, 75854);
                            return return_v;
                        }


                        int
                        f_25011_75787_75855(string
                        line)
                        {
                            appendLine(line);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 75787, 75855);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                        f_25011_76009_76031(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                        this_param)
                        {
                            var return_v = this_param.EnteringRegions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 76009, 76031);
                            return return_v;
                        }


                        bool
                        f_25011_76061_76094(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        actual)
                        {
                            var return_v = CustomAssert.Same((object?)expected, (object)actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76061, 76094);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_76135_76152(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 76135, 76152);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_76233_76260(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 76233, 76260);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_76262_76289(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 76262, 76289);
                            return return_v;
                        }


                        bool
                        f_25011_76215_76290(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        actual)
                        {
                            var return_v = CustomAssert.Same((object?)expected, (object?)actual);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76215, 76290);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 73798, 76743);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 73798, 76743);
                    }
                }

                void validateRoot(IOperation root)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 76759, 77651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76826, 76846);

                        f_25011_76826_76845(visitor, root);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76864, 76895);

                        f_25011_76864_76894(f_25011_76882_76893(root));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76913, 76970);

                        f_25011_76913_76969(f_25011_76931_76968(((Operation)root)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 76988, 77026);

                        f_25011_76988_77025(f_25011_77006_77024(root));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77044, 77144);

                        f_25011_77044_77143(f_25011_77062_77091(root), $"Unexpected node kind OperationKind.{f_25011_77131_77140(root)}");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77164, 77636);
                            foreach (var operation in f_25011_77190_77208_I(f_25011_77190_77208(root)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 77164, 77636);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77250, 77275);

                                f_25011_77250_77274(visitor, operation);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77297, 77336);

                                f_25011_77297_77335(f_25011_77318_77334(operation));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77358, 77420);

                                f_25011_77358_77419(f_25011_77376_77418(((Operation)operation)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77442, 77485);

                                f_25011_77442_77484(f_25011_77460_77483(operation));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77507, 77617);

                                f_25011_77507_77616(f_25011_77525_77559(operation), $"Unexpected node kind OperationKind.{f_25011_77599_77613(operation)}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 77164, 77636);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 473);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 473);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 76759, 77651);

                        int
                        f_25011_76826_76845(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                        this_param, Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            this_param.Visit(operation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76826, 76845);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_76882_76893(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 76882, 76893);
                            return return_v;
                        }


                        bool
                        f_25011_76864_76894(Microsoft.CodeAnalysis.IOperation?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76864, 76894);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SemanticModel?
                        f_25011_76931_76968(Microsoft.CodeAnalysis.Operation
                        this_param)
                        {
                            var return_v = this_param.OwningSemanticModel;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 76931, 76968);
                            return return_v;
                        }


                        bool
                        f_25011_76913_76969(Microsoft.CodeAnalysis.SemanticModel?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76913, 76969);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SemanticModel?
                        f_25011_77006_77024(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.SemanticModel;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 77006, 77024);
                            return return_v;
                        }


                        bool
                        f_25011_76988_77025(Microsoft.CodeAnalysis.SemanticModel?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 76988, 77025);
                            return return_v;
                        }


                        bool
                        f_25011_77062_77091(Microsoft.CodeAnalysis.IOperation
                        n)
                        {
                            var return_v = CanBeInControlFlowGraph(n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77062, 77091);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.OperationKind
                        f_25011_77131_77140(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 77131, 77140);
                            return return_v;
                        }


                        bool
                        f_25011_77044_77143(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.True(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77044, 77143);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_77190_77208(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            var return_v = operation.Descendants();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77190, 77208);
                            return return_v;
                        }


                        int
                        f_25011_77250_77274(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
                        this_param, Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            this_param.Visit(operation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77250, 77274);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_77318_77334(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 77318, 77334);
                            return return_v;
                        }


                        bool
                        f_25011_77297_77335(Microsoft.CodeAnalysis.IOperation?
                        @object)
                        {
                            var return_v = CustomAssert.NotNull((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77297, 77335);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SemanticModel?
                        f_25011_77376_77418(Microsoft.CodeAnalysis.Operation
                        this_param)
                        {
                            var return_v = this_param.OwningSemanticModel;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 77376, 77418);
                            return return_v;
                        }


                        bool
                        f_25011_77358_77419(Microsoft.CodeAnalysis.SemanticModel?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77358, 77419);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SemanticModel?
                        f_25011_77460_77483(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.SemanticModel;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 77460, 77483);
                            return return_v;
                        }


                        bool
                        f_25011_77442_77484(Microsoft.CodeAnalysis.SemanticModel?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77442, 77484);
                            return return_v;
                        }


                        bool
                        f_25011_77525_77559(Microsoft.CodeAnalysis.IOperation
                        n)
                        {
                            var return_v = CanBeInControlFlowGraph(n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77525, 77559);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.OperationKind
                        f_25011_77599_77613(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 77599, 77613);
                            return return_v;
                        }


                        bool
                        f_25011_77507_77616(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.True(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77507, 77616);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_77190_77208_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77190, 77208);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 76759, 77651);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 76759, 77651);
                    }
                }

                void validateLifetimeOfReferences(BasicBlock block, Func<string> finalGraph)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 77667, 79617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77776, 77805);

                        f_25011_77776_77804(referencedCaptureIds);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77823, 77858);

                        f_25011_77823_77857(referencedLocalsAndMethods);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77878, 78016);
                            foreach (IOperation operation in f_25011_77911_77927_I(f_25011_77911_77927(block)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 77878, 78016);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 77969, 77997);

                                f_25011_77969_77996(operation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 77878, 78016);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 139);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 139);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78036, 78162) || true) && (f_25011_78040_78057(block) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 78036, 78162);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78107, 78143);

                            f_25011_78107_78142(f_25011_78124_78141(block));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 78036, 78162);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78182, 78231);

                        ControlFlowRegion
                        region = f_25011_78209_78230(block)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78251, 78971) || true) && ((f_25011_78259_78285(referencedCaptureIds) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(25011, 78259, 78331) || f_25011_78294_78326(referencedLocalsAndMethods) != 0)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 78258, 78350) && region != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 78251, 78971);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78392, 78542);
                                    foreach (ILocalSymbol l in f_25011_78419_78432_I(f_25011_78419_78432(region)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 78392, 78542);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78482, 78519);

                                        f_25011_78482_78518(referencedLocalsAndMethods, l);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 78392, 78542);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 151);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 151);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78566, 78725);
                                    foreach (IMethodSymbol m in f_25011_78594_78615_I(f_25011_78594_78615(region)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 78566, 78725);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78665, 78702);

                                        f_25011_78665_78701(referencedLocalsAndMethods, m);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 78566, 78725);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 160);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 160);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78749, 78896);
                                    foreach (CaptureId id in f_25011_78774_78791_I(f_25011_78774_78791(region)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 78749, 78896);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78841, 78873);

                                        f_25011_78841_78872(referencedCaptureIds, id);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 78749, 78896);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 148);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 148);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78920, 78952);

                                region = f_25011_78929_78951(region);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 78251, 78971);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 78251, 78971);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 78251, 78971);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 78991, 79347) || true) && (f_25011_78995_79027(referencedLocalsAndMethods) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 78991, 79347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79074, 79126);

                            ISymbol
                            symbol = f_25011_79091_79125(referencedLocalsAndMethods)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79148, 79328);

                            f_25011_79148_79327(false, $"{((DynAbs.Tracing.TraceSender.Conditional_F1(25011, 79177, 79208) || ((f_25011_79177_79188(symbol) == SymbolKind.Local && DynAbs.Tracing.TraceSender.Conditional_F2(25011, 79211, 79218)) || DynAbs.Tracing.TraceSender.Conditional_F3(25011, 79221, 79229))) ? "Local" : "Method")} without owning region {f_25011_79255_79283(symbol)} in [{f_25011_79290_79307(block)}]\n{f_25011_79312_79324(finalGraph)}");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 78991, 79347);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79367, 79602) || true) && (f_25011_79371_79397(referencedCaptureIds) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79367, 79602);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79444, 79583);

                            f_25011_79444_79582(false, $"Capture [{f_25011_79481_79509(referencedCaptureIds).Value}] without owning region in [{f_25011_79545_79562(block)}]\n{f_25011_79567_79579(finalGraph)}");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79367, 79602);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 77667, 79617);

                        int
                        f_25011_77776_77804(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            this_param.Clear();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77776, 77804);
                            return 0;
                        }


                        int
                        f_25011_77823_77857(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param)
                        {
                            this_param.Clear();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77823, 77857);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        f_25011_77911_77927(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Operations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 77911, 77927);
                            return return_v;
                        }


                        int
                        f_25011_77969_77996(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            recordReferences(operation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77969, 77996);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        f_25011_77911_77927_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 77911, 77927);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation?
                        f_25011_78040_78057(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78040, 78057);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_25011_78124_78141(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78124, 78141);
                            return return_v;
                        }


                        int
                        f_25011_78107_78142(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            recordReferences(operation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 78107, 78142);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        f_25011_78209_78230(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78209, 78230);
                            return return_v;
                        }


                        int
                        f_25011_78259_78285(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78259, 78285);
                            return return_v;
                        }


                        int
                        f_25011_78294_78326(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78294, 78326);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        f_25011_78419_78432(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78419, 78432);
                            return return_v;
                        }


                        bool
                        f_25011_78482_78518(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param, Microsoft.CodeAnalysis.ILocalSymbol
                        item)
                        {
                            var return_v = this_param.Remove((Microsoft.CodeAnalysis.ISymbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 78482, 78518);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        f_25011_78419_78432_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 78419, 78432);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        f_25011_78594_78615(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.LocalFunctions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78594, 78615);
                            return return_v;
                        }


                        bool
                        f_25011_78665_78701(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param, Microsoft.CodeAnalysis.IMethodSymbol
                        item)
                        {
                            var return_v = this_param.Remove((Microsoft.CodeAnalysis.ISymbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 78665, 78701);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        f_25011_78594_78615_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 78594, 78615);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_78774_78791(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.CaptureIds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78774, 78791);
                            return return_v;
                        }


                        bool
                        f_25011_78841_78872(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Remove(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 78841, 78872);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        f_25011_78774_78791_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 78774, 78791);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                        f_25011_78929_78951(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        this_param)
                        {
                            var return_v = this_param.EnclosingRegion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78929, 78951);
                            return return_v;
                        }


                        int
                        f_25011_78995_79027(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 78995, 79027);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25011_79091_79125(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        source)
                        {
                            var return_v = source.First<Microsoft.CodeAnalysis.ISymbol>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79091, 79125);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_25011_79177_79188(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 79177, 79188);
                            return return_v;
                        }


                        string
                        f_25011_79255_79283(Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = symbol.ToTestDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79255, 79283);
                            return return_v;
                        }


                        string
                        f_25011_79290_79307(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79290, 79307);
                            return return_v;
                        }


                        string
                        f_25011_79312_79324(System.Func<string>
                        this_param)
                        {
                            var return_v = this_param.Invoke();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79312, 79324);
                            return return_v;
                        }


                        bool
                        f_25011_79148_79327(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.True(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79148, 79327);
                            return return_v;
                        }


                        int
                        f_25011_79371_79397(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 79371, 79397);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        f_25011_79481_79509(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        source)
                        {
                            var return_v = source.First<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79481, 79509);
                            return return_v;
                        }


                        string
                        f_25011_79545_79562(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        block)
                        {
                            var return_v = getBlockId(block);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79545, 79562);
                            return return_v;
                        }


                        string
                        f_25011_79567_79579(System.Func<string>
                        this_param)
                        {
                            var return_v = this_param.Invoke();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79567, 79579);
                            return return_v;
                        }


                        bool
                        f_25011_79444_79582(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.True(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79444, 79582);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 77667, 79617);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 77667, 79617);
                    }
                }

                void recordReferences(IOperation operation)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 79633, 83740);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79709, 83243);
                            foreach (IOperation node in f_25011_79737_79767_I(f_25011_79737_79767(operation)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79709, 83243);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79809, 79830);

                                IMethodSymbol
                                method
                                = default(IMethodSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79854, 83224);

                                switch (node)
                                {

                                    case ILocalReferenceOperation localReference:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79854, 83224);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 79991, 80606) || true) && (f_25011_79995_80055(f_25011_79995_80032(f_25011_79995_80015(localReference))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 79995, 80137) && !f_25011_80060_80137(f_25011_80081_80118(f_25011_80081_80101(localReference)), associatedSymbol)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79991, 80606);
                                            DynAbs.Tracing.TraceSender.TraceBreak(25011, 80569, 80575);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79991, 80606);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 80638, 80691);

                                        f_25011_80638_80690(
                                                                    referencedLocalsAndMethods, f_25011_80669_80689(localReference));
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 80721, 80727);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79854, 83224);

                                    case IMethodReferenceOperation methodReference:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79854, 83224);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 80830, 80862);

                                        method = f_25011_80839_80861(methodReference);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 80892, 81759) || true) && (f_25011_80896_80913(method) == MethodKind.LocalFunction)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 80892, 81759);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 81007, 81634) || true) && (f_25011_81011_81057(f_25011_81011_81034(method)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 81011, 81125) && !f_25011_81062_81125(f_25011_81083_81106(method), associatedSymbol)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 81007, 81634);
                                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 81593, 81599);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 81007, 81634);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 81670, 81728);

                                            f_25011_81670_81727(
                                                                            referencedLocalsAndMethods, f_25011_81701_81726(method));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 80892, 81759);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 81789, 81795);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79854, 83224);

                                    case IInvocationOperation invocation:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79854, 83224);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 81888, 81921);

                                        method = f_25011_81897_81920(invocation);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 81951, 82794) || true) && (f_25011_81955_81972(method) == MethodKind.LocalFunction)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 81951, 82794);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 82066, 82669) || true) && (f_25011_82070_82116(f_25011_82070_82093(method)) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 82070, 82160) && !f_25011_82121_82160(associatedSymbol)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 82066, 82669);
                                                DynAbs.Tracing.TraceSender.TraceBreak(25011, 82628, 82634);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 82066, 82669);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 82705, 82763);

                                            f_25011_82705_82762(
                                                                            referencedLocalsAndMethods, f_25011_82736_82761(method));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 81951, 82794);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 82824, 82830);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79854, 83224);

                                    case IFlowCaptureOperation flowCapture:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79854, 83224);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 82925, 82966);

                                        f_25011_82925_82965(referencedCaptureIds, f_25011_82950_82964(flowCapture));
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 82996, 83002);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79854, 83224);

                                    case IFlowCaptureReferenceOperation flowCaptureReference:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 79854, 83224);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83115, 83165);

                                        f_25011_83115_83164(referencedCaptureIds, f_25011_83140_83163(flowCaptureReference));
                                        DynAbs.Tracing.TraceSender.TraceBreak(25011, 83195, 83201);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79854, 83224);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 79709, 83243);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 1, 3535);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 1, 3535);
                        }
                        static bool isInAssociatedSymbol(ISymbol symbol, ISymbol associatedSymbol)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25011, 83263, 83725);
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83378, 83669) || true) && (symbol is IMethodSymbol m)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 83378, 83669);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83460, 83590) || true) && ((object)m == associatedSymbol)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 83460, 83590);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83551, 83563);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 83460, 83590);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83618, 83646);

                                        symbol = f_25011_83627_83645(m);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 83378, 83669);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25011, 83378, 83669);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25011, 83378, 83669);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83693, 83706);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25011, 83263, 83725);

                                Microsoft.CodeAnalysis.ISymbol
                                f_25011_83627_83645(Microsoft.CodeAnalysis.IMethodSymbol
                                this_param)
                                {
                                    var return_v = this_param.ContainingSymbol;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 83627, 83645);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 83263, 83725);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 83263, 83725);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 79633, 83740);

                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_79737_79767(Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            var return_v = operation.DescendantsAndSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79737, 79767);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ILocalSymbol
                        f_25011_79995_80015(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Local;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 79995, 80015);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25011_79995_80032(Microsoft.CodeAnalysis.ILocalSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 79995, 80032);
                            return return_v;
                        }


                        bool
                        f_25011_79995_80055(Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = symbol.IsTopLevelMainMethod();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79995, 80055);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ILocalSymbol
                        f_25011_80081_80101(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Local;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 80081, 80101);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25011_80081_80118(Microsoft.CodeAnalysis.ILocalSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 80081, 80118);
                            return return_v;
                        }


                        bool
                        f_25011_80060_80137(Microsoft.CodeAnalysis.ISymbol
                        symbol, Microsoft.CodeAnalysis.ISymbol
                        associatedSymbol)
                        {
                            var return_v = isInAssociatedSymbol(symbol, associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 80060, 80137);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ILocalSymbol
                        f_25011_80669_80689(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Local;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 80669, 80689);
                            return return_v;
                        }


                        bool
                        f_25011_80638_80690(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param, Microsoft.CodeAnalysis.ILocalSymbol
                        item)
                        {
                            var return_v = this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 80638, 80690);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IMethodSymbol
                        f_25011_80839_80861(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 80839, 80861);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_25011_80896_80913(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 80896, 80913);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25011_81011_81034(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 81011, 81034);
                            return return_v;
                        }


                        bool
                        f_25011_81011_81057(Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = symbol.IsTopLevelMainMethod();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 81011, 81057);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25011_81083_81106(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 81083, 81106);
                            return return_v;
                        }


                        bool
                        f_25011_81062_81125(Microsoft.CodeAnalysis.ISymbol
                        symbol, Microsoft.CodeAnalysis.ISymbol
                        associatedSymbol)
                        {
                            var return_v = isInAssociatedSymbol(symbol, associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 81062, 81125);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IMethodSymbol
                        f_25011_81701_81726(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 81701, 81726);
                            return return_v;
                        }


                        bool
                        f_25011_81670_81727(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param, Microsoft.CodeAnalysis.IMethodSymbol
                        item)
                        {
                            var return_v = this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 81670, 81727);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IMethodSymbol
                        f_25011_81897_81920(Microsoft.CodeAnalysis.Operations.IInvocationOperation
                        this_param)
                        {
                            var return_v = this_param.TargetMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 81897, 81920);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_25011_81955_81972(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 81955, 81972);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_25011_82070_82093(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 82070, 82093);
                            return return_v;
                        }


                        bool
                        f_25011_82070_82116(Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = symbol.IsTopLevelMainMethod();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 82070, 82116);
                            return return_v;
                        }


                        bool
                        f_25011_82121_82160(Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = symbol.IsTopLevelMainMethod();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 82121, 82160);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IMethodSymbol
                        f_25011_82736_82761(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 82736, 82761);
                            return return_v;
                        }


                        bool
                        f_25011_82705_82762(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param, Microsoft.CodeAnalysis.IMethodSymbol
                        item)
                        {
                            var return_v = this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 82705, 82762);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        f_25011_82950_82964(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 82950, 82964);
                            return return_v;
                        }


                        bool
                        f_25011_82925_82965(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 82925, 82965);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        f_25011_83140_83163(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 83140, 83163);
                            return return_v;
                        }


                        bool
                        f_25011_83115_83164(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 83115, 83164);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        f_25011_79737_79767_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 79737, 79767);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 79633, 83740);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 79633, 83740);
                    }
                }

                string getBlockId(BasicBlock block)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 83756, 83876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83824, 83861);

                        return $"B{f_25011_83835_83848(block)}{idSuffix}";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 83756, 83876);

                        int
                        f_25011_83835_83848(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 83835, 83848);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 83756, 83876);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 83756, 83876);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string getRegionId(ControlFlowRegion region)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 83892, 84025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 83969, 84010);

                        return $"R{f_25011_83980_83997(regionMap, region)}{idSuffix}";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 83892, 84025);

                        int
                        f_25011_83980_83997(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion, int>
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 83980, 83997);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 83892, 84025);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 83892, 84025);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string getOperationTree(IOperation operation)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 84041, 84392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84119, 84284);

                        var
                        walker = f_25011_84132_84283(graph, currentRegion, idSuffix, anonymousFunctionsMap, compilation, operation, initialIndent: 8 + indent, associatedSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84302, 84326);

                        f_25011_84302_84325(walker, operation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84344, 84377);

                        return f_25011_84351_84376(f_25011_84351_84365(walker));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 84041, 84392);

                        Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer
                        f_25011_84132_84283(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                        graph, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                        region, string
                        idSuffix, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                        anonymousFunctionsMap, Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.IOperation
                        root, int
                        initialIndent, Microsoft.CodeAnalysis.ISymbol
                        associatedSymbol)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer(graph, region, idSuffix, (System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>)anonymousFunctionsMap, compilation, root, initialIndent: initialIndent, associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 84132, 84283);
                            return return_v;
                        }


                        int
                        f_25011_84302_84325(Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer
                        this_param, Microsoft.CodeAnalysis.IOperation
                        operation)
                        {
                            this_param.Visit(operation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 84302, 84325);
                            return 0;
                        }


                        System.Text.StringBuilder
                        f_25011_84351_84365(Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer
                        this_param)
                        {
                            var return_v = this_param.Builder;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 84351, 84365);
                            return return_v;
                        }


                        string
                        f_25011_84351_84376(System.Text.StringBuilder
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 84351, 84376);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 84041, 84392);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 84041, 84392);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25011, 4585, 84403);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
                f_25011_4894_4906(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Blocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 4894, 4906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_5016_5026(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 5016, 5026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion, int>
                f_25011_5154_5170()
                {
                    var return_v = buildRegionMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5154, 5170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                f_25011_5209_5272()
                {
                    var return_v = PooledDictionary<IMethodSymbol, ControlFlowGraph>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5209, 5272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                f_25011_5315_5396()
                {
                    var return_v = PooledDictionary<IFlowAnonymousFunctionOperation, ControlFlowGraph>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5315, 5396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                f_25011_5444_5480()
                {
                    var return_v = PooledHashSet<ISymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5444, 5480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                f_25011_5522_5560()
                {
                    var return_v = PooledHashSet<CaptureId>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5522, 5560);
                    return return_v;
                }


                int
                f_25011_5713_5726(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 5713, 5726);
                    return return_v;
                }


                bool
                f_25011_5691_5727(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5691, 5727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
                f_25011_5756_5766(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 5756, 5766);
                    return return_v;
                }


                bool
                f_25011_5860_5887(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5860, 5887);
                    return return_v;
                }


                bool
                f_25011_5914_5957(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 5914, 5957);
                    return return_v;
                }


                bool
                f_25011_6066_6090(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6066, 6090);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25011_6136_6152(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Operations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6136, 6152);
                    return return_v;
                }


                bool
                f_25011_6117_6153(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6117, 6153);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                f_25011_6199_6217(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Predecessors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6199, 6217);
                    return return_v;
                }


                bool
                f_25011_6180_6218(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6180, 6218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_6263_6280(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6263, 6280);
                    return return_v;
                }


                bool
                f_25011_6245_6281(Microsoft.CodeAnalysis.IOperation?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6245, 6281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_6329_6355(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.FallThroughSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6329, 6355);
                    return return_v;
                }


                bool
                f_25011_6308_6356(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6308, 6356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                f_25011_6404_6430(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.FallThroughSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6404, 6430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                f_25011_6404_6442(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6404, 6442);
                    return return_v;
                }


                bool
                f_25011_6383_6443(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6383, 6443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_6488_6514(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6488, 6514);
                    return return_v;
                }


                bool
                f_25011_6470_6515(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6470, 6515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_6560_6570(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6560, 6570);
                    return return_v;
                }


                bool
                f_25011_6542_6586(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6542, 6586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_6646_6667(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6646, 6667);
                    return return_v;
                }


                bool
                f_25011_6613_6668(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6613, 6668);
                    return return_v;
                }


                int
                f_25011_6717_6748(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.FirstBlockOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6717, 6748);
                    return return_v;
                }


                bool
                f_25011_6695_6749(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6695, 6749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                f_25011_6805_6834(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6805, 6834);
                    return return_v;
                }


                bool
                f_25011_6776_6835(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6776, 6835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25011_6880_6907(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.ExceptionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6880, 6907);
                    return return_v;
                }


                bool
                f_25011_6862_6908(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6862, 6908);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                f_25011_6954_6974(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 6954, 6974);
                    return return_v;
                }


                bool
                f_25011_6935_6975(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 6935, 6975);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                f_25011_7021_7049(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7021, 7049);
                    return return_v;
                }


                bool
                f_25011_7002_7050(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7002, 7050);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                f_25011_7096_7120(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.CaptureIds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7096, 7120);
                    return return_v;
                }


                bool
                f_25011_7077_7121(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7077, 7121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                f_25011_7195_7213(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7195, 7213);
                    return return_v;
                }


                bool
                f_25011_7148_7214(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7148, 7214);
                    return return_v;
                }


                bool
                f_25011_7259_7276(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.IsReachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7259, 7276);
                    return return_v;
                }


                bool
                f_25011_7241_7277(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7241, 7277);
                    return return_v;
                }


                bool
                f_25011_7385_7425(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7385, 7425);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25011_7471_7487(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Operations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7471, 7487);
                    return return_v;
                }


                bool
                f_25011_7452_7488(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7452, 7488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_7533_7559(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.FallThroughSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7533, 7559);
                    return return_v;
                }


                bool
                f_25011_7515_7560(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7515, 7560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_7605_7631(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7605, 7631);
                    return return_v;
                }


                bool
                f_25011_7587_7632(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7587, 7632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_7677_7694(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7677, 7694);
                    return return_v;
                }


                bool
                f_25011_7659_7695(Microsoft.CodeAnalysis.IOperation?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7659, 7695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_7740_7750(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7740, 7750);
                    return return_v;
                }


                bool
                f_25011_7722_7766(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7722, 7766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_7826_7847(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7826, 7847);
                    return return_v;
                }


                bool
                f_25011_7793_7848(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7793, 7848);
                    return return_v;
                }


                int
                f_25011_7897_7927(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.LastBlockOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 7897, 7927);
                    return return_v;
                }


                bool
                f_25011_7875_7928(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 7875, 7928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
                f_25011_8069_8079(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8069, 8079);
                    return return_v;
                }


                bool
                f_25011_8019_8082(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 8019, 8082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_8158_8179(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8158, 8179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_8251_8272(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8251, 8272);
                    return return_v;
                }


                int
                f_25011_8274_8287(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8274, 8287);
                    return return_v;
                }


                int
                f_25011_8238_8288(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                region, int
                firstBlockOrdinal)
                {
                    enterRegions(region, firstBlockOrdinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 8238, 8288);
                    return 0;
                }


                System.Text.StringBuilder
                f_25011_8408_8434(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 8408, 8434);
                    return return_v;
                }


                string
                f_25011_8494_8511(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                block)
                {
                    var return_v = getBlockId(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 8494, 8511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
                f_25011_8517_8527(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8517, 8527);
                    return return_v;
                }


                bool
                f_25011_8530_8547(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.IsReachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8530, 8547);
                    return return_v;
                }


                int
                f_25011_8474_8575(string
                line)
                {
                    appendLine(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 8474, 8575);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                f_25011_8615_8633(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Predecessors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8615, 8633);
                    return return_v;
                }


                bool
                f_25011_8658_8679_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 8658, 8679);
                    return return_v;
                }


                int
                f_25011_8721_8735()
                {
                    appendIndent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 8721, 8735);
                    return 0;
                }


                System.Text.StringBuilder
                f_25011_8758_8799(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 8758, 8799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                f_25011_9125_9154(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9125, 9154);
                    return return_v;
                }


                bool
                f_25011_9100_9155(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                expected, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 9100, 9155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_9200_9224(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9200, 9224);
                    return return_v;
                }


                int
                f_25011_9298_9317(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9298, 9317);
                    return return_v;
                }


                bool
                f_25011_9251_9318(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 9251, 9318);
                    return return_v;
                }


                int
                f_25011_9374_9393(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9374, 9393);
                    return return_v;
                }


                int
                f_25011_9445_9464(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9445, 9464);
                    return return_v;
                }


                bool
                f_25011_9420_9479(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                expected, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 9420, 9479);
                    return return_v;
                }


                bool
                f_25011_9512_9552(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.IsConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9512, 9552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_9628_9660(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9628, 9660);
                    return return_v;
                }


                bool
                f_25011_9610_9680(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                actual)
                {
                    var return_v = CustomAssert.Same((object?)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 9610, 9680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                f_25011_9764_9789(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9764, 9789);
                    return return_v;
                }


                bool
                f_25011_9711_9790(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 9711, 9790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_9923_9955(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.FallThroughSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 9923, 9955);
                    return return_v;
                }


                bool
                f_25011_9905_9975(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                actual)
                {
                    var return_v = CustomAssert.Same((object?)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 9905, 9975);
                    return return_v;
                }


                string
                f_25011_10057_10080(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                block)
                {
                    var return_v = getBlockId(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10057, 10080);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25011_10031_10083(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10031, 10083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_10162_10203(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 10162, 10203);
                    return return_v;
                }


                bool
                f_25011_10416_10456(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.IsConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 10416, 10456);
                    return return_v;
                }


                bool
                f_25011_10398_10457(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10398, 10457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_10636_10668(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.FallThroughSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 10636, 10668);
                    return return_v;
                }


                bool
                f_25011_10618_10688(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                actual)
                {
                    var return_v = CustomAssert.Same((object?)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10618, 10688);
                    return return_v;
                }


                bool
                f_25011_10738_10778(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.IsConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 10738, 10778);
                    return return_v;
                }


                bool
                f_25011_10719_10779(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10719, 10779);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25011_10812_10838(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10812, 10838);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25011_10894_10919(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10894, 10919);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25011_10967_10993(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 10967, 10993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
                f_25011_11040_11050(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 11040, 11050);
                    return return_v;
                }


                int
                f_25011_11116_11150(string
                line)
                {
                    appendLine(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11116, 11150);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25011_11207_11223(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Operations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 11207, 11223);
                    return return_v;
                }


                int
                f_25011_11242_11293(string
                line)
                {
                    appendLine(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11242, 11293);
                    return 0;
                }


                int
                f_25011_11390_11413(Microsoft.CodeAnalysis.IOperation
                root)
                {
                    validateRoot(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11390, 11413);
                    return 0;
                }


                string
                f_25011_11461_11488(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = getOperationTree(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11461, 11488);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25011_11436_11489(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11436, 11489);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_25011_11338_11348_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11338, 11348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_11567_11593(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 11567, 11593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                f_25011_11618_11637(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 11618, 11637);
                    return return_v;
                }


                bool
                f_25011_11712_11751(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11712, 11751);
                    return return_v;
                }


                bool
                f_25011_11792_11832(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.IsConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 11792, 11832);
                    return return_v;
                }


                bool
                f_25011_11774_11833(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11774, 11833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_11883_11907(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 11883, 11907);
                    return return_v;
                }


                bool
                f_25011_11858_11908(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                expected, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 11858, 11908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                f_25011_11935_11964(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 11935, 11964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_12047_12076(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12047, 12076);
                    return return_v;
                }


                int
                f_25011_12047_12084(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12047, 12084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_12087_12116(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12087, 12116);
                    return return_v;
                }


                bool
                f_25011_12022_12117(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                expected, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12022, 12117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_12222_12249(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12222, 12249);
                    return return_v;
                }


                bool
                f_25011_12165_12250(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12165, 12250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_12329_12356(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12329, 12356);
                    return return_v;
                }


                bool
                f_25011_12273_12357(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12273, 12357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_12458_12485(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12458, 12485);
                    return return_v;
                }


                bool
                f_25011_12380_12486(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12380, 12486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                f_25011_12529_12548(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12529, 12548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                f_25011_12589_12608(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12589, 12608);
                    return return_v;
                }


                bool
                f_25011_12511_12647(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12511, 12647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                f_25011_12690_12709(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12690, 12709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_12828_12855(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12828, 12855);
                    return return_v;
                }


                string
                f_25011_12868_12911(ref Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                branch)
                {
                    var return_v = getDestinationString(ref branch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12868, 12911);
                    return return_v;
                }


                int
                f_25011_12788_12915(string
                line)
                {
                    appendLine(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12788, 12915);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_12959_12976(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 12959, 12976);
                    return return_v;
                }


                bool
                f_25011_12999_13026(Microsoft.CodeAnalysis.IOperation?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 12999, 13026);
                    return return_v;
                }


                int
                f_25011_13049_13068(Microsoft.CodeAnalysis.IOperation
                root)
                {
                    validateRoot(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13049, 13068);
                    return 0;
                }


                string
                f_25011_13112_13135(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = getOperationTree(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13112, 13135);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25011_13091_13136(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13091, 13136);
                    return return_v;
                }


                int
                f_25011_13159_13199(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                fromBlock, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                branch)
                {
                    validateBranch(fromBlock, branch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13159, 13199);
                    return 0;
                }


                System.Text.StringBuilder
                f_25011_13222_13248(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13222, 13248);
                    return return_v;
                }


                bool
                f_25011_13331_13367(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13331, 13367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                f_25011_13440_13459(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 13440, 13459);
                    return return_v;
                }


                bool
                f_25011_13390_13460(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13390, 13460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                f_25011_13531_13557(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.FallThroughSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 13531, 13557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
                f_25011_13582_13592(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 13582, 13592);
                    return return_v;
                }


                bool
                f_25011_13657_13686(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13657, 13686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_13727_13744(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 13727, 13744);
                    return return_v;
                }


                bool
                f_25011_13709_13745(Microsoft.CodeAnalysis.IOperation?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13709, 13745);
                    return return_v;
                }


                bool
                f_25011_13828_13860(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13828, 13860);
                    return return_v;
                }


                bool
                f_25011_13902_13935(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.IsConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 13902, 13935);
                    return return_v;
                }


                bool
                f_25011_13883_13936(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13883, 13936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_13986_14003(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 13986, 14003);
                    return return_v;
                }


                bool
                f_25011_13961_14004(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                expected, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 13961, 14004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                f_25011_14031_14053(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14031, 14053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_14136_14158(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14136, 14158);
                    return return_v;
                }


                int
                f_25011_14136_14166(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14136, 14166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                f_25011_14169_14191(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14169, 14191);
                    return return_v;
                }


                bool
                f_25011_14111_14192(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                expected, Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 14111, 14192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_14244_14264(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14244, 14264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                f_25011_14390_14412(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14390, 14412);
                    return return_v;
                }


                bool
                f_25011_14372_14413(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 14372, 14413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_14459_14480(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14459, 14480);
                    return return_v;
                }


                int
                f_25011_14459_14497(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.LastBlockOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14459, 14497);
                    return return_v;
                }


                int
                f_25011_14499_14512(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14499, 14512);
                    return return_v;
                }


                bool
                f_25011_14440_14513(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 14440, 14513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_14558_14579(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14558, 14579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                f_25011_14558_14584(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14558, 14584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_14620_14641(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14620, 14641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                f_25011_14620_14646(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14620, 14646);
                    return return_v;
                }


                bool
                f_25011_14540_14680(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 14540, 14680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_14752_14772(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14752, 14772);
                    return return_v;
                }


                string
                f_25011_14782_14818(ref Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                branch)
                {
                    var return_v = getDestinationString(ref branch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 14782, 14818);
                    return return_v;
                }


                int
                f_25011_14728_14822(string
                line)
                {
                    appendLine(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 14728, 14822);
                    return 0;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                f_25011_14864_14883(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.ConditionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14864, 14883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_14919_14936(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 14919, 14936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_15090_15110(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15090, 15110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_15150_15170(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15150, 15170);
                    return return_v;
                }


                bool
                f_25011_15035_15171(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15035, 15171);
                    return return_v;
                }


                int
                f_25011_15198_15217(Microsoft.CodeAnalysis.IOperation
                root)
                {
                    validateRoot(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15198, 15217);
                    return 0;
                }


                string
                f_25011_15265_15288(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = getOperationTree(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15265, 15288);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25011_15244_15289(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15244, 15289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_15445_15465(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15445, 15465);
                    return return_v;
                }


                bool
                f_25011_15388_15466(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15388, 15466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                f_25011_15549_15569(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                this_param)
                {
                    var return_v = this_param.Semantics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15549, 15569);
                    return return_v;
                }


                bool
                f_25011_15493_15570(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranchSemantics
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15493, 15570);
                    return return_v;
                }


                int
                f_25011_15618_15651(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                fromBlock, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                branch)
                {
                    validateBranch(fromBlock, branch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15618, 15651);
                    return 0;
                }


                int
                f_25011_15697_15727(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.LastBlockOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15697, 15727);
                    return return_v;
                }


                int
                f_25011_15731_15744(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15731, 15744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_25011_15825_15846(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15825, 15846);
                    return return_v;
                }


                int
                f_25011_15848_15861(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 15848, 15861);
                    return return_v;
                }


                int
                f_25011_15812_15862(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                region, int
                lastBlockOrdinal)
                {
                    leaveRegions(region, lastBlockOrdinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 15812, 15862);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                f_25011_16064_16084(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 16064, 16084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_16139_16159(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 16139, 16159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_16199_16240(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                localFunction)
                {
                    var return_v = this_param.GetLocalFunctionControlFlowGraph(localFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16199, 16240);
                    return return_v;
                }


                bool
                f_25011_16178_16241(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16178, 16241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_16281_16329(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                controlFlowGraph, Microsoft.CodeAnalysis.IMethodSymbol
                localFunction)
                {
                    var return_v = controlFlowGraph.GetLocalFunctionControlFlowGraphInScope(localFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16281, 16329);
                    return return_v;
                }


                bool
                f_25011_16260_16330(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16260, 16330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_25011_16374_16382(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 16374, 16382);
                    return return_v;
                }


                bool
                f_25011_16349_16383(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16349, 16383);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                f_25011_16064_16084_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16064, 16084);
                    return return_v;
                }


                int
                f_25011_16463_16486(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 16463, 16486);
                    return return_v;
                }


                bool
                f_25011_16415_16487(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16415, 16487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_16670_16722(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                anonymousFunction)
                {
                    var return_v = this_param.GetAnonymousFunctionControlFlowGraph(anonymousFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16670, 16722);
                    return return_v;
                }


                bool
                f_25011_16640_16723(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16640, 16723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_25011_16772_16831(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                controlFlowGraph, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                anonymousFunction)
                {
                    var return_v = controlFlowGraph.GetAnonymousFunctionControlFlowGraphInScope(anonymousFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16772, 16831);
                    return return_v;
                }


                bool
                f_25011_16742_16832(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16742, 16832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                f_25011_16876_16893(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 16876, 16893);
                    return return_v;
                }


                bool
                f_25011_16851_16894(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16851, 16894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                f_25011_16585_16606_I(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 16585, 16606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25011_16980_17003(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.OriginalOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 16980, 17003);
                    return return_v;
                }


                string
                f_25011_16980_17012(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 16980, 17012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25011_17116_17139(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.OriginalOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 17116, 17139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25011_17116_17146(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 17116, 17146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_25011_17116_17157(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 17116, 17157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_25011_17087_17158(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 17087, 17158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25011_17202_17225(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                this_param)
                {
                    var return_v = this_param.OriginalOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 17202, 17225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25011_17202_17232(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 17202, 17232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_25011_17202_17237(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 17202, 17237);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25011_17181_17238(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetDiagnostics((Microsoft.CodeAnalysis.Text.TextSpan?)span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 17181, 17238);
                    return return_v;
                }


                int
                f_25011_17992_18018(System.Func<string>
                finalGraph)
                {
                    verifyCaptures(finalGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 17992, 18018);
                    return 0;
                }


                int
                f_25011_18112_18159(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                block, System.Func<string>
                finalGraph)
                {
                    validateLifetimeOfReferences(block, finalGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18112, 18159);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
                f_25011_18072_18078_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18072, 18078);
                    return return_v;
                }


                int
                f_25011_18191_18207(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion, int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18191, 18207);
                    return 0;
                }


                int
                f_25011_18222_18246(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18222, 18246);
                    return 0;
                }


                int
                f_25011_18261_18289(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18261, 18289);
                    return 0;
                }


                int
                f_25011_18304_18337(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18304, 18337);
                    return 0;
                }


                int
                f_25011_18352_18379(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 18352, 18379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 4585, 84403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 4585, 84403);
            }
        }

        private static void AssertTrueWithGraph([DoesNotReturnIf(false)] bool value, string message, Func<string> finalGraph)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25011, 84415, 84682);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84557, 84671) || true) && (!value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 84557, 84671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84601, 84656);

                    f_25011_84601_84655(value, $"{message}\n{f_25011_84640_84652(finalGraph)}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 84557, 84671);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25011, 84415, 84682);

                string
                f_25011_84640_84652(System.Func<string>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 84640, 84652);
                    return return_v;
                }


                bool
                f_25011_84601_84655(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 84601, 84655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 84415, 84682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 84415, 84682);
            }
        }
        private sealed class OperationTreeSerializer : OperationTreeVerifier
        {
            private readonly ControlFlowGraph _graph;

            private readonly ControlFlowRegion _region;

            private readonly string _idSuffix;

            private readonly Dictionary<IFlowAnonymousFunctionOperation, ControlFlowGraph> _anonymousFunctionsMap;

            private readonly ISymbol _associatedSymbol;

            public OperationTreeSerializer(ControlFlowGraph graph, ControlFlowRegion region, string idSuffix,
                                                       Dictionary<IFlowAnonymousFunctionOperation, ControlFlowGraph> anonymousFunctionsMap,
                                                       Compilation compilation, IOperation root, int initialIndent, ISymbol associatedSymbol) : base(f_25011_85504_85515_C(compilation), root, initialIndent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25011, 85122, 85794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84821, 84827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84877, 84884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 84923, 84932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85026, 85048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85088, 85105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85570, 85585);

                    _graph = graph;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85603, 85620);

                    _region = region;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85638, 85659);

                    _idSuffix = idSuffix;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85677, 85724);

                    _anonymousFunctionsMap = anonymousFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85742, 85779);

                    _associatedSymbol = associatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25011, 85122, 85794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 85122, 85794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 85122, 85794);
                }
            }

            public System.Text.StringBuilder Builder
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 85851, 85862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 85854, 85862);
                        return _builder; DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 85851, 85862);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 85851, 85862);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 85851, 85862);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void VisitFlowAnonymousFunction(IFlowAnonymousFunctionOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 85879, 86617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86002, 86045);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFlowAnonymousFunction(operation), 25011, 86002, 86044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86065, 86080);

                    f_25011_86065_86079(this, "{");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86098, 86111);

                    f_25011_86098_86110(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86129, 86192);

                    var
                    g = f_25011_86137_86191(_graph, operation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86210, 86248);

                    int
                    id = f_25011_86219_86247(_anonymousFunctionsMap)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86266, 86307);

                    f_25011_86266_86306(_anonymousFunctionsMap, operation, g);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86325, 86403);

                    f_25011_86325_86402(OperationKind.AnonymousFunction, f_25011_86377_86401(f_25011_86377_86396(g)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86421, 86538);

                    f_25011_86421_86537(_builder, _compilation, g, _region, $"#A{id}{_idSuffix}", f_25011_86492_86513(_currentIndent) + 4, _associatedSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86556, 86571);

                    f_25011_86556_86570(this, "}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86589, 86602);

                    f_25011_86589_86601(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 85879, 86617);

                    int
                    f_25011_86065_86079(Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer
                    this_param, string
                    str)
                    {
                        this_param.LogString(str);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86065, 86079);
                        return 0;
                    }


                    int
                    f_25011_86098_86110(Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer
                    this_param)
                    {
                        this_param.LogNewLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86098, 86110);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    f_25011_86137_86191(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                    anonymousFunction)
                    {
                        var return_v = this_param.GetAnonymousFunctionControlFlowGraph(anonymousFunction);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86137, 86191);
                        return return_v;
                    }


                    int
                    f_25011_86219_86247(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 86219, 86247);
                        return return_v;
                    }


                    int
                    f_25011_86266_86306(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                    key, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86266, 86306);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_25011_86377_86396(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    this_param)
                    {
                        var return_v = this_param.OriginalOperation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 86377, 86396);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.OperationKind
                    f_25011_86377_86401(Microsoft.CodeAnalysis.IOperation
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 86377, 86401);
                        return return_v;
                    }


                    bool
                    f_25011_86325_86402(Microsoft.CodeAnalysis.OperationKind
                    expected, Microsoft.CodeAnalysis.OperationKind
                    actual)
                    {
                        var return_v = CustomAssert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86325, 86402);
                        return return_v;
                    }


                    int
                    f_25011_86492_86513(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 86492, 86513);
                        return return_v;
                    }


                    int
                    f_25011_86421_86537(System.Text.StringBuilder
                    stringBuilder, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                    graph, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    enclosing, string
                    idSuffix, int
                    indent, Microsoft.CodeAnalysis.ISymbol
                    associatedSymbol)
                    {
                        GetFlowGraph(stringBuilder, compilation, graph, enclosing, idSuffix, indent, associatedSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86421, 86537);
                        return 0;
                    }


                    int
                    f_25011_86556_86570(Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer
                    this_param, string
                    str)
                    {
                        this_param.LogString(str);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86556, 86570);
                        return 0;
                    }


                    int
                    f_25011_86589_86601(Microsoft.CodeAnalysis.Test.Utilities.ControlFlowGraphVerifier.OperationTreeSerializer
                    this_param)
                    {
                        this_param.LogNewLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 86589, 86601);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 85879, 86617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 85879, 86617);
                }
            }

            static OperationTreeSerializer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25011, 84694, 86628);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25011, 84694, 86628);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 84694, 86628);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25011, 84694, 86628);

            static Microsoft.CodeAnalysis.Compilation
            f_25011_85504_85515_C(Microsoft.CodeAnalysis.Compilation
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(25011, 85122, 85794);
                return return_v;
            }

        }

        private static bool CanBeInControlFlowGraph(IOperation n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25011, 86640, 94084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 86722, 93958);

                switch (f_25011_86730_86736(n))
                {

                    case OperationKind.Block:
                    case OperationKind.Switch:
                    case OperationKind.Loop:
                    case OperationKind.Branch:
                    case OperationKind.Lock:
                    case OperationKind.Try:
                    case OperationKind.Using:
                    case OperationKind.Conditional:
                    case OperationKind.Coalesce:
                    case OperationKind.ConditionalAccess:
                    case OperationKind.ConditionalAccessInstance:
                    case OperationKind.MemberInitializer:
                    case OperationKind.FieldInitializer:
                    case OperationKind.PropertyInitializer:
                    case OperationKind.ParameterInitializer:
                    case OperationKind.CatchClause:
                    case OperationKind.SwitchCase:
                    case OperationKind.CaseClause:
                    case OperationKind.VariableDeclarationGroup:
                    case OperationKind.VariableDeclaration:
                    case OperationKind.VariableDeclarator:
                    case OperationKind.VariableInitializer:
                    case OperationKind.Return:
                    case OperationKind.YieldBreak:
                    case OperationKind.Labeled:
                    case OperationKind.Throw:
                    case OperationKind.End:
                    case OperationKind.Empty:
                    case OperationKind.NameOf:
                    case OperationKind.AnonymousFunction:
                    case OperationKind.ObjectOrCollectionInitializer:
                    case OperationKind.LocalFunction:
                    case OperationKind.CoalesceAssignment:
                    case OperationKind.SwitchExpression:
                    case OperationKind.SwitchExpressionArm:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 86722, 93958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 88535, 88548);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 86722, 93958);

                    case OperationKind.Binary:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 86722, 93958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 88616, 88649);

                        var
                        binary = (IBinaryOperation)n
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 88671, 89207);

                        return (f_25011_88679_88698(binary) != Operations.BinaryOperatorKind.ConditionalAnd && (DynAbs.Tracing.TraceSender.Expression_True(25011, 88679, 88816) && f_25011_88750_88769(binary) != Operations.BinaryOperatorKind.ConditionalOr)) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 88678, 89206) || (f_25011_88851_88872(binary) == null && (DynAbs.Tracing.TraceSender.Expression_True(25011, 88851, 88960) && !f_25011_88915_88960(f_25011_88948_88959(binary))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 88851, 89046) && !f_25011_88995_89046(f_25011_89034_89045(binary))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 88851, 89125) && !f_25011_89081_89125(f_25011_89113_89124(binary))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 88851, 89205) && !f_25011_89160_89205(f_25011_89193_89204(binary)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 86722, 93958);

                    case OperationKind.InstanceReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 86722, 93958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 89439, 89494);

                        var
                        instanceReference = (IInstanceReferenceOperation)n
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 89516, 90279);

                        return f_25011_89523_89554(instanceReference) == InstanceReferenceKind.ContainingTypeInstance || (DynAbs.Tracing.TraceSender.Expression_False(25011, 89523, 89700) || f_25011_89631_89662(instanceReference) == InstanceReferenceKind.PatternInput) || (DynAbs.Tracing.TraceSender.Expression_False(25011, 89523, 90278) || (f_25011_89730_89761(instanceReference) == InstanceReferenceKind.ImplicitReceiver && (DynAbs.Tracing.TraceSender.Expression_True(25011, 89730, 89855) && f_25011_89833_89855(f_25011_89833_89839(n))) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 89730, 89942) && f_25011_89885_89893(n) is IPropertyReferenceOperation propertyReference) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 89730, 90003) && f_25011_89972_89998(propertyReference) == n) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 89730, 90104) && f_25011_90033_90057(propertyReference) is ISimpleAssignmentOperation simpleAssignment) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 89730, 90178) && f_25011_90134_90157(simpleAssignment) == propertyReference) && (DynAbs.Tracing.TraceSender.Expression_True(25011, 89730, 90277) && f_25011_90208_90236(f_25011_90208_90231(simpleAssignment)) == OperationKind.AnonymousObjectCreation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 86722, 93958);

                    case OperationKind.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 86722, 93958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 90345, 90382);

                        return !(n is IPlaceholderOperation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 86722, 93958);

                    case OperationKind.Invalid:
                    case OperationKind.YieldReturn:
                    case OperationKind.ExpressionStatement:
                    case OperationKind.Stop:
                    case OperationKind.RaiseEvent:
                    case OperationKind.Literal:
                    case OperationKind.Conversion:
                    case OperationKind.Invocation:
                    case OperationKind.ArrayElementReference:
                    case OperationKind.LocalReference:
                    case OperationKind.ParameterReference:
                    case OperationKind.FieldReference:
                    case OperationKind.MethodReference:
                    case OperationKind.PropertyReference:
                    case OperationKind.EventReference:
                    case OperationKind.FlowAnonymousFunction:
                    case OperationKind.ObjectCreation:
                    case OperationKind.TypeParameterObjectCreation:
                    case OperationKind.ArrayCreation:
                    case OperationKind.ArrayInitializer:
                    case OperationKind.IsType:
                    case OperationKind.Await:
                    case OperationKind.SimpleAssignment:
                    case OperationKind.CompoundAssignment:
                    case OperationKind.Parenthesized:
                    case OperationKind.EventAssignment:
                    case OperationKind.InterpolatedString:
                    case OperationKind.AnonymousObjectCreation:
                    case OperationKind.Tuple:
                    case OperationKind.TupleBinary:
                    case OperationKind.DynamicObjectCreation:
                    case OperationKind.DynamicMemberReference:
                    case OperationKind.DynamicInvocation:
                    case OperationKind.DynamicIndexerAccess:
                    case OperationKind.TranslatedQuery:
                    case OperationKind.DelegateCreation:
                    case OperationKind.DefaultValue:
                    case OperationKind.TypeOf:
                    case OperationKind.SizeOf:
                    case OperationKind.AddressOf:
                    case OperationKind.IsPattern:
                    case OperationKind.Increment:
                    case OperationKind.Decrement:
                    case OperationKind.DeconstructionAssignment:
                    case OperationKind.DeclarationExpression:
                    case OperationKind.OmittedArgument:
                    case OperationKind.Argument:
                    case OperationKind.InterpolatedStringText:
                    case OperationKind.Interpolation:
                    case OperationKind.ConstantPattern:
                    case OperationKind.DeclarationPattern:
                    case OperationKind.Unary:
                    case OperationKind.FlowCapture:
                    case OperationKind.FlowCaptureReference:
                    case OperationKind.IsNull:
                    case OperationKind.CaughtException:
                    case OperationKind.StaticLocalInitializationSemaphore:
                    case OperationKind.Discard:
                    case OperationKind.ReDim:
                    case OperationKind.ReDimClause:
                    case OperationKind.Range:
                    case OperationKind.RecursivePattern:
                    case OperationKind.DiscardPattern:
                    case OperationKind.PropertySubpattern:
                    case OperationKind.RelationalPattern:
                    case OperationKind.NegatedPattern:
                    case OperationKind.BinaryPattern:
                    case OperationKind.TypePattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25011, 86722, 93958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 93931, 93943);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25011, 86722, 93958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 93974, 94046);

                f_25011_93974_94045(false, $"Unhandled node kind OperationKind.{f_25011_94036_94042(n)}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 94060, 94073);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25011, 86640, 94084);

                Microsoft.CodeAnalysis.OperationKind
                f_25011_86730_86736(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 86730, 86736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25011_88679_88698(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 88679, 88698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
                f_25011_88750_88769(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 88750, 88769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_25011_88851_88872(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.OperatorMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 88851, 88872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25011_88948_88959(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 88948, 88959);
                    return return_v;
                }


                bool
                f_25011_88915_88960(Microsoft.CodeAnalysis.ITypeSymbol?
                type)
                {
                    var return_v = ITypeSymbolHelpers.IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 88915, 88960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25011_89034_89045(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89034, 89045);
                    return return_v;
                }


                bool
                f_25011_88995_89046(Microsoft.CodeAnalysis.ITypeSymbol?
                type)
                {
                    var return_v = ITypeSymbolHelpers.IsNullableOfBoolean(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 88995, 89046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25011_89113_89124(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89113, 89124);
                    return return_v;
                }


                bool
                f_25011_89081_89125(Microsoft.CodeAnalysis.ITypeSymbol?
                type)
                {
                    var return_v = ITypeSymbolHelpers.IsObjectType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 89081, 89125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25011_89193_89204(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89193, 89204);
                    return return_v;
                }


                bool
                f_25011_89160_89205(Microsoft.CodeAnalysis.ITypeSymbol?
                type)
                {
                    var return_v = ITypeSymbolHelpers.IsDynamicType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 89160, 89205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                f_25011_89523_89554(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
                this_param)
                {
                    var return_v = this_param.ReferenceKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89523, 89554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                f_25011_89631_89662(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
                this_param)
                {
                    var return_v = this_param.ReferenceKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89631, 89662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                f_25011_89730_89761(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
                this_param)
                {
                    var return_v = this_param.ReferenceKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89730, 89761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_25011_89833_89839(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89833, 89839);
                    return return_v;
                }


                bool
                f_25011_89833_89855(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89833, 89855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_89885_89893(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89885, 89893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_89972_89998(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 89972, 89998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_90033_90057(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 90033, 90057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25011_90134_90157(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 90134, 90157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25011_90208_90231(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 90208, 90231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25011_90208_90236(Microsoft.CodeAnalysis.IOperation?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 90208, 90236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_25011_94036_94042(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25011, 94036, 94042);
                    return return_v;
                }


                bool
                f_25011_93974_94045(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 93974, 94045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 86640, 94084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 86640, 94084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTopLevelMainMethod([NotNullWhen(true)] this ISymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 94210, 94441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 94213, 94441);
                return symbol is IMethodSymbol
                {
                    Name: WellKnownMemberNames.TopLevelStatementsEntryPointMethodName,
                    ContainingType: { } containingType
                } && (DynAbs.Tracing.TraceSender.Expression_True(25011, 94213, 94441) && f_25011_94406_94441(containingType)); DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 94210, 94441);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 94210, 94441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 94210, 94441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTopLevelMainType([NotNullWhen(true)] this ISymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25011, 94548, 94794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25011, 94551, 94794);
                return symbol is INamedTypeSymbol
                {
                    Name: WellKnownMemberNames.TopLevelStatementsEntryPointTypeName,
                    ContainingType: null,
                    ContainingNamespace: { IsGlobalNamespace: true }
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(25011, 94548, 94794);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25011, 94548, 94794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 94548, 94794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ControlFlowGraphVerifier()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25011, 837, 94802);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25011, 837, 94802);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25011, 837, 94802);
        }


        static bool
        f_25011_94406_94441(Microsoft.CodeAnalysis.INamedTypeSymbol
        symbol)
        {
            var return_v = symbol.IsTopLevelMainType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25011, 94406, 94441);
            return return_v;
        }

    }
}
