// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class ClosureConversion
    {
        internal sealed partial class Analysis
        {
            public readonly PooledHashSet<MethodSymbol> MethodsConvertedToDelegates;

            public bool CanTakeRefParameters(MethodSymbol function)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 1605, 1782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 1608, 1782);
                    return f_10451_1608_1625_M(!function.IsAsync) && (DynAbs.Tracing.TraceSender.Expression_True(10451, 1608, 1649) && f_10451_1629_1649_M(!function.IsIterator)) && (DynAbs.Tracing.TraceSender.Expression_True(10451, 1608, 1782) && !f_10451_1736_1782(MethodsConvertedToDelegates, function)); DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 1605, 1782);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 1605, 1782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 1605, 1782);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_10451_1608_1625_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 1608, 1625);
                    return return_v;
                }


                bool
                f_10451_1629_1649_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 1629, 1649);
                    return return_v;
                }


                bool
                f_10451_1736_1782(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 1736, 1782);
                    return return_v;
                }

            }

            public readonly Scope ScopeTree;

            private readonly MethodSymbol _topLevelMethod;

            private readonly int _topLevelMethodOrdinal;

            private readonly VariableSlotAllocator _slotAllocatorOpt;

            private readonly TypeCompilationState _compilationState;

            private Analysis(
                            Scope scopeTree,
                            PooledHashSet<MethodSymbol> methodsConvertedToDelegates,
                            MethodSymbol topLevelMethod,
                            int topLevelMethodOrdinal,
                            VariableSlotAllocator slotAllocatorOpt,
                            TypeCompilationState compilationState)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10451, 2224, 2924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 1339, 1366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 1937, 1946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 1993, 2008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2044, 2066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2120, 2137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2190, 2207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2585, 2607);

                    ScopeTree = scopeTree;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2625, 2683);

                    MethodsConvertedToDelegates = methodsConvertedToDelegates;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2701, 2734);

                    _topLevelMethod = topLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2752, 2799);

                    _topLevelMethodOrdinal = topLevelMethodOrdinal;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2817, 2854);

                    _slotAllocatorOpt = slotAllocatorOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 2872, 2909);

                    _compilationState = compilationState;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10451, 2224, 2924);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 2224, 2924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 2224, 2924);
                }
            }

            public static Analysis Analyze(
                            BoundNode node,
                            MethodSymbol method,
                            int topLevelMethodOrdinal,
                            MethodSymbol substitutedSourceMethod,
                            VariableSlotAllocator slotAllocatorOpt,
                            TypeCompilationState compilationState,
                            ArrayBuilder<ClosureDebugInfo> closureDebugInfo,
                            DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10451, 2940, 4544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 3397, 3473);

                    var
                    methodsConvertedToDelegates = f_10451_3431_3472()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 3491, 3671);

                    var
                    scopeTree = f_10451_3507_3670(node, method, methodsConvertedToDelegates, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 3689, 3721);

                    f_10451_3689_3720(scopeTree != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 3741, 4003);

                    var
                    analysis = f_10451_3756_4002(scopeTree, methodsConvertedToDelegates, method, topLevelMethodOrdinal, slotAllocatorOpt, compilationState)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4023, 4060);

                    f_10451_4023_4059(
                                    analysis);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4078, 4125);

                    f_10451_4078_4124(analysis);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4143, 4439) || true) && (f_10451_4147_4201(f_10451_4147_4183(compilationState.Compilation)) == OptimizationLevel.Release)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 4143, 4439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4391, 4420);

                        f_10451_4391_4419(                    // This can affect when a variable is in scope whilst debugging, so only do this in release mode.
                                            analysis);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 4143, 4439);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4457, 4495);

                    f_10451_4457_4494(analysis);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4513, 4529);

                    return analysis;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10451, 2940, 4544);

                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10451_3431_3472()
                    {
                        var return_v = PooledHashSet<MethodSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 3431, 3472);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    f_10451_3507_3670(Microsoft.CodeAnalysis.CSharp.BoundNode
                    node, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    topLevelMethod, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    methodsConvertedToDelegates, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = ScopeTreeBuilder.Build(node, topLevelMethod, (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>)methodsConvertedToDelegates, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 3507, 3670);
                        return return_v;
                    }


                    int
                    f_10451_3689_3720(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 3689, 3720);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                    f_10451_3756_4002(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    scopeTree, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    methodsConvertedToDelegates, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    topLevelMethod, int
                    topLevelMethodOrdinal, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                    slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis(scopeTree, methodsConvertedToDelegates, topLevelMethod, topLevelMethodOrdinal, slotAllocatorOpt, compilationState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 3756, 4002);
                        return return_v;
                    }


                    int
                    f_10451_4023_4059(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                    this_param)
                    {
                        this_param.MakeAndAssignEnvironments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 4023, 4059);
                        return 0;
                    }


                    int
                    f_10451_4078_4124(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                    this_param)
                    {
                        this_param.ComputeLambdaScopesAndFrameCaptures();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 4078, 4124);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10451_4147_4183(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 4147, 4183);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.OptimizationLevel
                    f_10451_4147_4201(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.OptimizationLevel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 4147, 4201);
                        return return_v;
                    }


                    int
                    f_10451_4391_4419(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                    this_param)
                    {
                        this_param.MergeEnvironments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 4391, 4419);
                        return 0;
                    }


                    int
                    f_10451_4457_4494(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                    this_param)
                    {
                        this_param.InlineThisOnlyEnvironments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 4457, 4494);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 2940, 4544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 2940, 4544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static BoundNode FindNodeToAnalyze(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10451, 4560, 5719);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4651, 5704) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 4651, 5704);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4704, 5685);

                            switch (f_10451_4712_4721(node))
                            {

                                case BoundKind.SequencePoint:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 4704, 5685);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 4830, 4877);

                                    node = f_10451_4837_4876(((BoundSequencePoint)node));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10451, 4907, 4913);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 4704, 5685);

                                case BoundKind.SequencePointWithSpan:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 4704, 5685);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 5008, 5063);

                                    node = f_10451_5015_5062(((BoundSequencePointWithSpan)node));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10451, 5093, 5099);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 4704, 5685);

                                case BoundKind.Block:
                                case BoundKind.StatementList:
                                case BoundKind.FieldEqualsValue:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 4704, 5685);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 5291, 5303);

                                    return node;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 4704, 5685);

                                case BoundKind.GlobalStatementInitializer:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 4704, 5685);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 5403, 5460);

                                    return f_10451_5410_5459(((BoundGlobalStatementInitializer)node));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 4704, 5685);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 4704, 5685);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 5610, 5662);

                                    throw f_10451_5616_5661(f_10451_5651_5660(node));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 4704, 5685);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 4651, 5704);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 4651, 5704);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 4651, 5704);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10451, 4560, 5719);

                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10451_4712_4721(Microsoft.CodeAnalysis.CSharp.BoundNode?
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 4712, 4721);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement?
                    f_10451_4837_4876(Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                    this_param)
                    {
                        var return_v = this_param.StatementOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 4837, 4876);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement?
                    f_10451_5015_5062(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                    this_param)
                    {
                        var return_v = this_param.StatementOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 5015, 5062);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10451_5410_5459(Microsoft.CodeAnalysis.CSharp.BoundGlobalStatementInitializer
                    this_param)
                    {
                        var return_v = this_param.Statement;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 5410, 5459);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10451_5651_5660(Microsoft.CodeAnalysis.CSharp.BoundNode
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 5651, 5660);
                        return return_v;
                    }


                    System.Exception
                    f_10451_5616_5661(Microsoft.CodeAnalysis.CSharp.BoundKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 5616, 5661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 4560, 5719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 4560, 5719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void ComputeLambdaScopesAndFrameCaptures()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 6310, 8731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 6393, 8716);

                    f_10451_6393_8715(ScopeTree, (scope, function) =>
                                    {
                                        if (function.CapturedEnvironments.Count > 0)
                                        {
                                            var capturedEnvs = PooledHashSet<ClosureEnvironment>.GetInstance();
                                            capturedEnvs.AddAll(function.CapturedEnvironments);

                        // Find the nearest captured class environment, if one exists
                        var curScope = scope;
                                            while (curScope != null)
                                            {
                                                var env = curScope.DeclaredEnvironment;
                                                if (!(env is null) && capturedEnvs.Remove(env) && !env.IsStruct)
                                                {
                                                    function.ContainingEnvironmentOpt = env;
                                                    break;
                                                }
                                                curScope = curScope.Parent;
                                            }

                        // Now we need to walk up the scopes to find environment captures
                        var oldEnv = curScope?.DeclaredEnvironment;
                                            curScope = curScope?.Parent;
                                            while (curScope != null)
                                            {
                                                if (capturedEnvs.Count == 0)
                                                {
                                                    break;
                                                }

                                                var env = curScope.DeclaredEnvironment;
                                                if (!(env is null))
                                                {
                                                    if (!env.IsStruct)
                                                    {
                                                        Debug.Assert(!oldEnv.IsStruct);
                                                        oldEnv.CapturesParent = true;
                                                        oldEnv = env;
                                                    }
                                                    capturedEnvs.Remove(env);
                                                }
                                                curScope = curScope.Parent;
                                            }

                                            if (capturedEnvs.Count > 0)
                                            {
                                                throw ExceptionUtilities.Unreachable;
                                            }

                                            capturedEnvs.Free();

                                        }
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 6310, 8731);

                    int
                    f_10451_6393_8715(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    scope, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    action)
                    {
                        VisitNestedFunctions(scope, action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 6393, 8715);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 6310, 8731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 6310, 8731);
                }
            }

            private void InlineThisOnlyEnvironments()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 9152, 12543);
                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol thisParam = default(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9281, 9450) || true) && (!f_10451_9286_9340(_topLevelMethod, out thisParam) || (DynAbs.Tracing.TraceSender.Expression_False(10451, 9285, 9382) || thisParam == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 9281, 9450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9424, 9431);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 9281, 9450);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9470, 9510);

                    var
                    env = ScopeTree.DeclaredEnvironment
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9614, 9697) || true) && (env is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 9614, 9697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9671, 9678);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 9614, 9697);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9792, 9962) || true) && (f_10451_9796_9823(env.CapturedVariables) > 1 || (DynAbs.Tracing.TraceSender.Expression_False(10451, 9796, 9894) || !f_10451_9853_9894(env.CapturedVariables, thisParam)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 9792, 9962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9936, 9943);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 9792, 9962);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 9982, 12027) || true) && (env.IsStruct)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 9982, 12027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 10191, 10457);

                        bool
                        cantRemove = f_10451_10209_10456(ScopeTree, (scope, closure) =>
                                            {
                                                return closure.CapturedEnvironments.Contains(env) &&
                                                    closure.ContainingEnvironmentOpt != null;
                                            })
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 10481, 10581) || true) && (!cantRemove)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 10481, 10581);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 10546, 10558);

                            f_10451_10546_10557();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 10481, 10581);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 9982, 12027);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 9982, 12027);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 11027, 12027) || true) && (f_10451_11031_11091(_topLevelMethod) is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 11027, 12027);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 11681, 11693);

                            f_10451_11681_11692();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 11715, 12008);

                            f_10451_11715_12007(ScopeTree, (scope, closure) =>
                                                {
                                                    if (closure.ContainingEnvironmentOpt == env)
                                                    {
                                                        closure.ContainingEnvironmentOpt = null;
                                                    }
                                                });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 11027, 12027);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 9982, 12027);
                    }

                    void RemoveEnv()
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 12047, 12528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 12104, 12141);

                            ScopeTree.DeclaredEnvironment = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 12163, 12509);

                            f_10451_12163_12508(ScopeTree, (scope, nested) =>
                                                {
                                                    var index = nested.CapturedEnvironments.IndexOf(env);
                                                    if (index >= 0)
                                                    {
                                                        nested.CapturedEnvironments.RemoveAt(index);
                                                    }
                                                });
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 12047, 12528);

                            int
                            f_10451_12163_12508(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                            scope, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                            action)
                            {
                                VisitNestedFunctions(scope, action);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 12163, 12508);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 12047, 12528);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 12047, 12528);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 9152, 12543);

                    bool
                    f_10451_9286_9340(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    thisParameter)
                    {
                        var return_v = this_param.TryGetThisParameter(out thisParameter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 9286, 9340);
                        return return_v;
                    }


                    int
                    f_10451_9796_9823(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 9796, 9823);
                        return return_v;
                    }


                    bool
                    f_10451_9853_9894(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    value)
                    {
                        var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 9853, 9894);
                        return return_v;
                    }


                    bool
                    f_10451_10209_10456(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    scope, System.Func<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction, bool>
                    func)
                    {
                        var return_v = CheckNestedFunctions(scope, func);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 10209, 10456);
                        return return_v;
                    }


                    int
                    f_10451_10546_10557()
                    {
                        RemoveEnv();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 10546, 10557);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10451_11031_11091(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    member)
                    {
                        var return_v = VarianceSafety.GetEnclosingVariantInterface((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 11031, 11091);
                        return return_v;
                    }


                    int
                    f_10451_11681_11692()
                    {
                        RemoveEnv();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 11681, 11692);
                        return 0;
                    }


                    int
                    f_10451_11715_12007(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    scope, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    action)
                    {
                        VisitNestedFunctions(scope, action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 11715, 12007);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 9152, 12543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 9152, 12543);
                }
            }

            private void MakeAndAssignEnvironments()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 12559, 16538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 12632, 16523);

                    f_10451_12632_16522(ScopeTree, scope =>
                                    {
                    // Currently all variables declared in the same scope are added
                    // to the same closure environment
                    var variablesInEnvironment = scope.DeclaredVariables;

                    // Don't create empty environments
                    if (variablesInEnvironment.Count == 0)
                                        {
                                            return;
                                        }

                    // First walk the nested scopes to find all closures which
                    // capture variables from this scope. They all need to capture
                    // this environment. This includes closures which captured local
                    // functions that capture those variables, so multiple passes may
                    // be needed. This will also decide if the environment is a struct
                    // or a class.

                    // If we are in a variant interface, runtime might not consider the 
                    // method synthesized directly within the interface as variant safe.
                    // For simplicity we do not perform precise analysis whether this would
                    // definitely be the case. If we are in a variant interface, we always force
                    // creation of a display class.
                    bool isStruct = VarianceSafety.GetEnclosingVariantInterface(_topLevelMethod) is null;
                                        var closures = new SetWithInsertionOrder<NestedFunction>();
                                        bool addedItem;

                    // This loop is O(n), where n is the length of the chain
                    //   L_1 <- L_2 <- L_3 ...
                    // where L_1 represents a local function that directly captures the current
                    // environment, L_2 represents a local function that directly captures L_1,
                    // L_3 represents a local function that captures L_2, and so on.
                    //
                    // Each iteration of the loop runs a visitor that is proportional to the
                    // number of closures in nested scopes, so we hope that the total number
                    // of nested functions and function chains is small in any real-world code.
                    do
                                        {
                                            addedItem = false;
                                            VisitNestedFunctions(scope, (closureScope, closure) =>
                                            {
                                                if (!closures.Contains(closure) &&
                                                    (closure.CapturedVariables.Overlaps(scope.DeclaredVariables) ||
                                                     closure.CapturedVariables.Overlaps(closures.Select(c => c.OriginalMethodSymbol))))
                                                {
                                                    closures.Add(closure);
                                                    addedItem = true;
                                                    isStruct &= CanTakeRefParameters(closure.OriginalMethodSymbol);
                                                }
                                            });
                                        } while (addedItem == true);

                    // Next create the environment and add it to the declaration scope
                    var env = new ClosureEnvironment(variablesInEnvironment, isStruct);
                                        Debug.Assert(scope.DeclaredEnvironment is null);
                                        scope.DeclaredEnvironment = env;

                                        _topLevelMethod.TryGetThisParameter(out var thisParam);
                                        foreach (var closure in closures)
                                        {
                                            closure.CapturedEnvironments.Add(env);
                                            if (thisParam != null && env.CapturedVariables.Contains(thisParam))
                                            {
                                                closure.CapturesThis = true;
                                            }
                                        }
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 12559, 16538);

                    int
                    f_10451_12632_16522(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    treeRoot, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    action)
                    {
                        VisitScopeTree(treeRoot, action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 12632, 16522);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 12559, 16538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 12559, 16538);
                }
            }

            private PooledDictionary<Scope, PooledHashSet<NestedFunction>> CalculateFunctionsCapturingScopeVariables()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 16746, 19523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 16885, 16992);

                    var
                    closuresCapturingScopeVariables = f_10451_16923_16991()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 17085, 17170);

                    var
                    environmentsToScopes = f_10451_17112_17169()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 17190, 18174);

                    f_10451_17190_18173(ScopeTree, scope =>
                                    {
                                        if (!(scope.DeclaredEnvironment is null))
                                        {
                                            closuresCapturingScopeVariables[scope] = PooledHashSet<NestedFunction>.GetInstance();
                                            environmentsToScopes[scope.DeclaredEnvironment] = scope;
                                        }

                                        foreach (var closure in scope.NestedFunctions)
                                        {
                                            foreach (var env in closure.CapturedEnvironments)
                                            {
                            // A closure should only ever capture a scope which is an ancestor of its own,
                            // which we should have already visited
                            Debug.Assert(environmentsToScopes.ContainsKey(env));

                                                closuresCapturingScopeVariables[environmentsToScopes[env]].Add(closure);
                                            }
                                        }
                                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18194, 18222);

                    f_10451_18194_18221(
                                    environmentsToScopes);

                    // if a function captures a scope, which captures its parent, then the closure also captures the parents scope.
                    // we update closuresCapturingScopeVariables to reflect this.


                    // LAFHIS
                    try
                    {                       
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18450, 19449);
                        foreach (var (scope, capturingClosures) in f_10451_16923_16991_M(closuresCapturingScopeVariables))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 18450, 19449);
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18566, 18639) || true) && (scope.DeclaredEnvironment is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 18566, 18639);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18630, 18639);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 18566, 18639);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18663, 18688);

                            var
                            currentScope = scope
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18710, 19430) || true) && (currentScope.DeclaredEnvironment is null || (DynAbs.Tracing.TraceSender.Expression_False(10451, 18717, 18808) || currentScope.DeclaredEnvironment.CapturesParent))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 18710, 19430);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18858, 18893);

                                    currentScope = currentScope.Parent;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 18921, 19067) || true) && (currentScope == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 18921, 19067);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 19003, 19040);

                                        throw f_10451_19009_19039();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 18921, 19067);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 19095, 19307) || true) && (currentScope.DeclaredEnvironment is null || (DynAbs.Tracing.TraceSender.Expression_False(10451, 19099, 19213) || currentScope.DeclaredEnvironment.IsStruct))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 19095, 19307);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 19271, 19280);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 19095, 19307);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 19335, 19407);

                                    f_10451_19335_19406(f_10451_19335_19380(closuresCapturingScopeVariables, currentScope), capturingClosures);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 18710, 19430);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 18710, 19430);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 18710, 19430);
                            }

                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 18450, 19449);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 18450, 19449);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 18450, 19449);
                    }

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 19469, 19508);

                    return closuresCapturingScopeVariables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 16746, 19523);

                    Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                    f_10451_16923_16991()
                    {
                        var return_v = PooledDictionary<Scope, PooledHashSet<NestedFunction>>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 16923, 16991);
                        return return_v;
                    }

                    Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                    f_10451_16923_16991_M(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>> i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 18493, 18524);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    f_10451_17112_17169()
                    {
                        var return_v = PooledDictionary<ClosureEnvironment, Scope>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 17112, 17169);
                        return return_v;
                    }


                    int
                    f_10451_17190_18173(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    treeRoot, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    action)
                    {
                        VisitScopeTree(treeRoot, action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 17190, 18173);
                        return 0;
                    }


                    int
                    f_10451_18194_18221(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 18194, 18221);
                        return 0;
                    }


                    System.Exception
                    f_10451_19009_19039()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 19009, 19039);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    f_10451_19335_19380(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 19335, 19380);
                        return return_v;
                    }


                    bool
                    f_10451_19335_19406(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    set, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    values)
                    {
                        var return_v = set.AddAll<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>)values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 19335, 19406);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 16746, 19523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 16746, 19523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void MergeEnvironments()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 20198, 24256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20263, 20345);

                    var
                    closuresCapturingScopeVariables = f_10451_20301_20344(this)
                    ;

                    // Desde acá
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20465, 24004);
                        // now we merge environments into their parent environments if it is safe to do so

                        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                        f_10451_20513_20544_I(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>> i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 20513, 20544);
                            return return_v;
                        }

                        foreach (var (scope, closuresCapturingScope) in f_10451_20513_20544_I(closuresCapturingScopeVariables))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 20465, 24004);
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20586, 20659) || true) && (f_10451_20590_20618(closuresCapturingScope) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 20586, 20659);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20650, 20659);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 20586, 20659);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20683, 20724);

                            var
                            scopeEnv = scope.DeclaredEnvironment
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20821, 20878) || true) && (scopeEnv.IsStruct)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 20821, 20878);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20869, 20878);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 20821, 20878);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20902, 20924);

                            var
                            bestScope = scope
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 20946, 20971);

                            var
                            currentScope = scope
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 21404, 22856) || true) && (currentScope.Parent != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 21404, 22856);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 21488, 21561) || true) && (f_10451_21492_21524_M(!currentScope.CanMergeWithParent))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 21488, 21561);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10451, 21555, 21561);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 21488, 21561);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 21589, 21627);

                                    var
                                    parentScope = currentScope.Parent
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 21906, 21948);

                                    var
                                    env = parentScope.DeclaredEnvironment
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 21974, 22156) || true) && (env is null || (DynAbs.Tracing.TraceSender.Expression_False(10451, 21978, 22005) || env.IsStruct))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 21974, 22156);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22063, 22090);

                                        currentScope = parentScope;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22120, 22129);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 21974, 22156);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22184, 22264);

                                    var
                                    closuresCapturingParentScope = f_10451_22219_22263(closuresCapturingScopeVariables, parentScope)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22622, 22726) || true) && (!f_10451_22627_22689(closuresCapturingParentScope, closuresCapturingScope))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 22622, 22726);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10451, 22720, 22726);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 22622, 22726);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22754, 22778);

                                    bestScope = parentScope;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22806, 22833);

                                    currentScope = parentScope;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 21404, 22856);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 21404, 22856);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 21404, 22856);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22882, 22982) || true) && (bestScope == scope)
                            ) // no better scope was found, so continue

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 22882, 22982);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 22973, 22982);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 22882, 22982);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23087, 23133);

                            var
                            targetEnv = bestScope.DeclaredEnvironment
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23157, 23323);
                                foreach (var variable in f_10451_23182_23208_I(scopeEnv.CapturedVariables))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 23157, 23323);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23258, 23300);

                                    f_10451_23258_23299(targetEnv.CapturedVariables, variable);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 23157, 23323);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 167);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 167);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23347, 23380);

                            scope.DeclaredEnvironment = null;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23404, 23985);
                                foreach (var closure in f_10451_23428_23450_I(closuresCapturingScope))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 23404, 23985);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23500, 23546);

                                    f_10451_23500_23545(closure.CapturedEnvironments, scopeEnv);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23574, 23756) || true) && (!f_10451_23579_23627(closure.CapturedEnvironments, targetEnv))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 23574, 23756);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23685, 23729);

                                        f_10451_23685_23728(closure.CapturedEnvironments, targetEnv);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 23574, 23756);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23784, 23962) || true) && (closure.ContainingEnvironmentOpt == scopeEnv)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 23784, 23962);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 23890, 23935);

                                        closure.ContainingEnvironmentOpt = targetEnv;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 23784, 23962);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 23404, 23985);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 582);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 582);
                            }
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 20465, 24004);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 20465, 24004);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 20465, 24004);
                    }
                    // Hasta acá

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24052, 24182);
                        foreach (var set in f_10451_24072_24110_I(f_10451_24072_24110(closuresCapturingScopeVariables)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 24052, 24182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24152, 24163);

                            f_10451_24152_24162(set);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 24052, 24182);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 131);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 131);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24202, 24241);

                    f_10451_24202_24240(
                                    closuresCapturingScopeVariables);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 20198, 24256);

                    Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                    f_10451_20301_20344(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                    this_param)
                    {
                        var return_v = this_param.CalculateFunctionsCapturingScopeVariables();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 20301, 20344);
                        return return_v;
                    }


                    int
                    f_10451_20590_20618(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 20590, 20618);
                        return return_v;
                    }


                    bool
                    f_10451_21492_21524_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 21492, 21524);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    f_10451_22219_22263(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 22219, 22263);
                        return return_v;
                    }


                    bool
                    f_10451_22627_22689(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    this_param, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    other)
                    {
                        var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 22627, 22689);
                        return return_v;
                    }


                    bool
                    f_10451_23258_23299(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    value)
                    {
                        var return_v = this_param.Add(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 23258, 23299);
                        return return_v;
                    }


                    Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10451_23182_23208_I(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 23182, 23208);
                        return return_v;
                    }


                    bool
                    f_10451_23500_23545(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                    element)
                    {
                        var return_v = this_param.Remove(element);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 23500, 23545);
                        return return_v;
                    }


                    bool
                    f_10451_23579_23627(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment?
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 23579, 23627);
                        return return_v;
                    }


                    int
                    f_10451_23685_23728(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment?
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 23685, 23728);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    f_10451_23428_23450_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 23428, 23450);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>.ValueCollection
                    f_10451_24072_24110(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 24072, 24110);
                        return return_v;
                    }


                    int
                    f_10451_24152_24162(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 24152, 24162);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>.ValueCollection
                    f_10451_24072_24110_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 24072, 24110);
                        return return_v;
                    }


                    int
                    f_10451_24202_24240(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 24202, 24240);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 20198, 24256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 20198, 24256);
                }
            }

            internal DebugId GetTopLevelMethodId()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 24272, 24493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24343, 24478);

                    return f_10451_24350_24377_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_slotAllocatorOpt, 10451, 24350, 24377)?.MethodId) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CodeGen.DebugId?>(10451, 24350, 24477) ?? f_10451_24381_24477(_topLevelMethodOrdinal, f_10451_24417_24476(_compilationState.ModuleBuilderOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 24272, 24493);

                    Microsoft.CodeAnalysis.CodeGen.DebugId?
                    f_10451_24350_24377_M(Microsoft.CodeAnalysis.CodeGen.DebugId?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 24350, 24377);
                        return return_v;
                    }


                    int
                    f_10451_24417_24476(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                    this_param)
                    {
                        var return_v = this_param.CurrentGenerationOrdinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 24417, 24476);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.DebugId
                    f_10451_24381_24477(int
                    ordinal, int
                    generation)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId(ordinal, generation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 24381, 24477);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 24272, 24493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 24272, 24493);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal DebugId GetClosureId(SyntaxNode syntax, ArrayBuilder<ClosureDebugInfo> closureDebugInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 24509, 25439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24639, 24668);

                    f_10451_24639_24667(syntax != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24688, 24706);

                    DebugId
                    closureId
                    = default(DebugId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24724, 24750);

                    DebugId
                    previousClosureId
                    = default(DebugId);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24768, 25153) || true) && (_slotAllocatorOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10451, 24772, 24871) && f_10451_24801_24871(_slotAllocatorOpt, syntax, out previousClosureId)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 24768, 25153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 24913, 24943);

                        closureId = previousClosureId;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 24768, 25153);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 24768, 25153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25025, 25134);

                        closureId = f_10451_25037_25133(f_10451_25049_25071(closureDebugInfo), f_10451_25073_25132(_compilationState.ModuleBuilderOpt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 24768, 25153);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25173, 25301);

                    int
                    syntaxOffset = f_10451_25192_25300(_topLevelMethod, f_10451_25235_25280(syntax), f_10451_25282_25299(syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25319, 25387);

                    f_10451_25319_25386(closureDebugInfo, f_10451_25340_25385(syntaxOffset, closureId));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25407, 25424);

                    return closureId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 24509, 25439);

                    int
                    f_10451_24639_24667(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 24639, 24667);
                        return 0;
                    }


                    bool
                    f_10451_24801_24871(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    closureSyntax, out Microsoft.CodeAnalysis.CodeGen.DebugId
                    closureId)
                    {
                        var return_v = this_param.TryGetPreviousClosure(closureSyntax, out closureId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 24801, 24871);
                        return return_v;
                    }


                    int
                    f_10451_25049_25071(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 25049, 25071);
                        return return_v;
                    }


                    int
                    f_10451_25073_25132(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                    this_param)
                    {
                        var return_v = this_param.CurrentGenerationOrdinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 25073, 25132);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.DebugId
                    f_10451_25037_25133(int
                    ordinal, int
                    generation)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId(ordinal, generation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 25037, 25133);
                        return return_v;
                    }


                    int
                    f_10451_25235_25280(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = LambdaUtilities.GetDeclaratorPosition(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 25235, 25280);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10451_25282_25299(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 25282, 25299);
                        return return_v;
                    }


                    int
                    f_10451_25192_25300(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, int
                    localPosition, Microsoft.CodeAnalysis.SyntaxTree
                    localTree)
                    {
                        var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 25192, 25300);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo
                    f_10451_25340_25385(int
                    syntaxOffset, Microsoft.CodeAnalysis.CodeGen.DebugId
                    closureId)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo(syntaxOffset, closureId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 25340, 25385);
                        return return_v;
                    }


                    int
                    f_10451_25319_25386(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                    this_param, Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 25319, 25386);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 24509, 25439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 24509, 25439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static Scope GetVariableDeclarationScope(Scope startingScope, Symbol variable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10451, 25586, 27050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25704, 25822) || true) && (variable is ParameterSymbol p && (DynAbs.Tracing.TraceSender.Expression_True(10451, 25708, 25749) && f_10451_25741_25749(p)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 25704, 25822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25791, 25803);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 25704, 25822);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25842, 25875);

                    var
                    currentScope = startingScope
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25893, 27005) || true) && (currentScope != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 25893, 27005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 25962, 26929);

                            switch (f_10451_25970_25983(variable))
                            {

                                case SymbolKind.Parameter:
                                case SymbolKind.Local:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 25962, 26929);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 26137, 26307) || true) && (f_10451_26141_26190(currentScope.DeclaredVariables, variable))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 26137, 26307);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 26256, 26276);

                                        return currentScope;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 26137, 26307);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10451, 26337, 26343);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 25962, 26929);

                                case SymbolKind.Method:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 25962, 26929);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 26424, 26748);
                                        foreach (var function in f_10451_26449_26477_I(currentScope.NestedFunctions))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 26424, 26748);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 26543, 26717) || true) && (function.OriginalMethodSymbol == variable)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 26543, 26717);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 26662, 26682);

                                                return currentScope;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 26543, 26717);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 26424, 26748);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 325);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 325);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10451, 26778, 26784);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 25962, 26929);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 25962, 26929);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 26850, 26906);

                                    throw f_10451_26856_26905(f_10451_26891_26904(variable));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 25962, 26929);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 26951, 26986);

                            currentScope = currentScope.Parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 25893, 27005);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 25893, 27005);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 25893, 27005);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 27023, 27035);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10451, 25586, 27050);

                    bool
                    f_10451_25741_25749(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsThis;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 25741, 25749);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10451_25970_25983(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 25970, 25983);
                        return return_v;
                    }


                    bool
                    f_10451_26141_26190(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    value)
                    {
                        var return_v = this_param.Contains(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 26141, 26190);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    f_10451_26449_26477_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 26449, 26477);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10451_26891_26904(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 26891, 26904);
                        return return_v;
                    }


                    System.Exception
                    f_10451_26856_26905(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 26856, 26905);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 25586, 27050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 25586, 27050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static Scope GetScopeParent(Scope treeRoot, BoundNode scopeNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10451, 27270, 27516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 27374, 27450);

                    var
                    correspondingScope = f_10451_27399_27449(treeRoot, scopeNode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 27468, 27501);

                    return correspondingScope.Parent;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10451, 27270, 27516);

                    Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    f_10451_27399_27449(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    treeRoot, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = GetScopeWithMatchingBoundNode(treeRoot, node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 27399, 27449);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 27270, 27516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 27270, 27516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static Scope GetScopeWithMatchingBoundNode(Scope treeRoot, BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10451, 27708, 28499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 27822, 27886);

                    return f_10451_27829_27845(treeRoot) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>(10451, 27829, 27885) ?? throw f_10451_27855_27885());

                    Scope Helper(Scope currentScope)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 27906, 28484);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 27979, 28106) || true) && (currentScope.BoundNode == node)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 27979, 28106);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 28063, 28083);

                                return currentScope;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 27979, 28106);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 28130, 28429);
                                foreach (var nestedScope in f_10451_28158_28183_I(currentScope.NestedScopes))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 28130, 28429);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 28233, 28265);

                                    var
                                    found = f_10451_28245_28264(nestedScope)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 28291, 28406) || true) && (found != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 28291, 28406);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 28366, 28379);

                                        return found;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 28291, 28406);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 28130, 28429);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 300);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 300);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 28453, 28465);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 27906, 28484);

                            Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                            f_10451_28245_28264(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                            currentScope)
                            {
                                var return_v = Helper(currentScope);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 28245, 28264);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                            f_10451_28158_28183_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 28158, 28183);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 27906, 28484);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 27906, 28484);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10451, 27708, 28499);

                    Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    f_10451_27829_27845(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    currentScope)
                    {
                        var return_v = Helper(currentScope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 27829, 27845);
                        return return_v;
                    }


                    System.Exception
                    f_10451_27855_27885()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 27855, 27885);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 27708, 28499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 27708, 28499);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static (NestedFunction, Scope) GetVisibleNestedFunction(Scope startingScope, MethodSymbol functionSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10451, 28808, 29513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 28953, 28986);

                    var
                    currentScope = startingScope
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 29004, 29443) || true) && (currentScope != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 29004, 29443);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 29073, 29367);
                                foreach (var function in f_10451_29098_29126_I(currentScope.NestedFunctions))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 29073, 29367);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 29176, 29344) || true) && (function.OriginalMethodSymbol == functionSymbol)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 29176, 29344);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 29285, 29317);

                                        return (function, currentScope);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 29176, 29344);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 29073, 29367);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 295);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 295);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 29389, 29424);

                            currentScope = currentScope.Parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 29004, 29443);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 29004, 29443);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 29004, 29443);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 29461, 29498);

                    throw f_10451_29467_29497();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10451, 28808, 29513);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    f_10451_29098_29126_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 29098, 29126);
                        return return_v;
                    }


                    System.Exception
                    f_10451_29467_29497()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 29467, 29497);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 28808, 29513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 28808, 29513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static NestedFunction GetNestedFunctionInTree(Scope treeRoot, MethodSymbol functionSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10451, 29717, 30663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 29847, 29911);

                    return f_10451_29854_29870(treeRoot) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>(10451, 29854, 29910) ?? throw f_10451_29880_29910());

                    NestedFunction helper(Scope scope)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 29931, 30648);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30006, 30277);
                                foreach (var function in f_10451_30031_30052_I(scope.NestedFunctions))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 30006, 30277);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30102, 30254) || true) && (function.OriginalMethodSymbol == functionSymbol)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 30102, 30254);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30211, 30227);

                                        return function;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 30102, 30254);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 30006, 30277);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 272);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 272);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30301, 30593);
                                foreach (var nestedScope in f_10451_30329_30347_I(scope.NestedScopes))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 30301, 30593);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30397, 30429);

                                    var
                                    found = f_10451_30409_30428(nestedScope)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30455, 30570) || true) && (found != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10451, 30455, 30570);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30530, 30543);

                                        return found;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 30455, 30570);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10451, 30301, 30593);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10451, 1, 293);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10451, 1, 293);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30617, 30629);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 29931, 30648);

                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                            f_10451_30031_30052_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 30031, 30052);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                            f_10451_30409_30428(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                            scope)
                            {
                                var return_v = helper(scope);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 30409, 30428);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                            f_10451_30329_30347_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 30329, 30347);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 29931, 30648);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 29931, 30648);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10451, 29717, 30663);

                    Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                    f_10451_29854_29870(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    scope)
                    {
                        var return_v = helper(scope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 29854, 29870);
                        return return_v;
                    }


                    System.Exception
                    f_10451_29880_29910()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10451, 29880, 29910);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 29717, 30663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 29717, 30663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10451, 30679, 30815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30730, 30765);

                    f_10451_30730_30764(MethodsConvertedToDelegates);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10451, 30783, 30800);

                    f_10451_30783_30799(ScopeTree);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10451, 30679, 30815);

                    int
                    f_10451_30730_30764(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 30730, 30764);
                        return 0;
                    }


                    int
                    f_10451_30783_30799(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10451, 30783, 30799);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10451, 30679, 30815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 30679, 30815);
                }
            }

            static Analysis()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10451, 923, 30826);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10451, 923, 30826);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 923, 30826);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10451, 923, 30826);
        }

        static ClosureConversion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10451, 561, 30833);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10451, 561, 30833);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10451, 561, 30833);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10451, 561, 30833);
    }
}
