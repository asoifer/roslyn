// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class LocalRewriter
    {
        private abstract partial class DecisionDagRewriter : PatternLocalRewriter
        {
            protected abstract ArrayBuilder<BoundStatement> BuilderForSection(SyntaxNode section);

            private ArrayBuilder<BoundStatement> _loweredDecisionDag;

            protected readonly PooledDictionary<BoundDecisionDagNode, LabelSymbol> _dagNodeLabels;

            protected DecisionDagRewriter(
                            SyntaxNode node,
                            LocalRewriter localRewriter,
                            bool generateInstrumentation)
            : base(f_10474_1946_1950_C(node), localRewriter, generateInstrumentation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10474, 1764, 2021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 1412, 1431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 1665, 1747);
                    this._dagNodeLabels = f_10474_1682_1747(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10474, 1764, 2021);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 1764, 2021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 1764, 2021);
                }
            }

            private void ComputeLabelSet(BoundDecisionDag decisionDag)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 2037, 3890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 2206, 2277);

                    var
                    hasPredecessor = f_10474_2227_2276()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 2295, 3521);
                        foreach (BoundDecisionDagNode node in f_10474_2333_2369_I(f_10474_2333_2369(decisionDag)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 2295, 3521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 2411, 3502);

                            switch (node)
                            {

                                case BoundWhenDecisionDagNode w:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 2411, 3502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 2535, 2557);

                                    f_10474_2535_2556(this, node);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 2587, 2736) || true) && (f_10474_2591_2602(w) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 2587, 2736);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 2676, 2705);

                                        f_10474_2676_2704(this, f_10474_2692_2703(w));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 2587, 2736);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10474, 2766, 2772);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 2411, 3502);

                                case BoundLeafDecisionDagNode d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 2411, 3502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 2931, 2962);

                                    _dagNodeLabels[node] = f_10474_2954_2961(d);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10474, 2992, 2998);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 2411, 3502);

                                case BoundEvaluationDecisionDagNode e:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 2411, 3502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3092, 3116);

                                    f_10474_3092_3115(f_10474_3108_3114(e));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10474, 3146, 3152);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 2411, 3502);

                                case BoundTestDecisionDagNode p:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 2411, 3502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3240, 3268);

                                    f_10474_3240_3267(f_10474_3256_3266(p));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3298, 3327);

                                    f_10474_3298_3326(f_10474_3314_3325(p));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10474, 3357, 3363);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 2411, 3502);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 2411, 3502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3427, 3479);

                                    throw f_10474_3433_3478(f_10474_3468_3477(node));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 2411, 3502);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 2295, 3521);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 1, 1227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 1, 1227);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3541, 3563);

                    f_10474_3541_3562(
                                    hasPredecessor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3581, 3588);

                    return;

                    void notePredecessor(BoundDecisionDagNode successor)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 3608, 3875);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3701, 3856) || true) && (successor != null && (DynAbs.Tracing.TraceSender.Expression_True(10474, 3705, 3756) && !f_10474_3727_3756(hasPredecessor, successor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 3701, 3856);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3806, 3833);

                                f_10474_3806_3832(this, successor);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 3701, 3856);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 3608, 3875);

                            bool
                            f_10474_3727_3756(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            item)
                            {
                                var return_v = this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3727, 3756);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                            f_10474_3806_3832(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            dag)
                            {
                                var return_v = this_param.GetDagNodeLabel(dag);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3806, 3832);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 3608, 3875);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 3608, 3875);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 2037, 3890);

                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10474_2227_2276()
                    {
                        var return_v = PooledHashSet<BoundDecisionDagNode>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 2227, 2276);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10474_2333_2369(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    this_param)
                    {
                        var return_v = this_param.TopologicallySortedNodes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 2333, 2369);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_2535_2556(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 2535, 2556);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                    f_10474_2591_2602(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 2591, 2602);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_2692_2703(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 2692, 2703);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_2676_2704(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 2676, 2704);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_2954_2961(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 2954, 2961);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_3108_3114(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 3108, 3114);
                        return return_v;
                    }


                    int
                    f_10474_3092_3115(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    successor)
                    {
                        notePredecessor(successor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3092, 3115);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_3256_3266(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 3256, 3266);
                        return return_v;
                    }


                    int
                    f_10474_3240_3267(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    successor)
                    {
                        notePredecessor(successor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3240, 3267);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_3314_3325(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 3314, 3325);
                        return return_v;
                    }


                    int
                    f_10474_3298_3326(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    successor)
                    {
                        notePredecessor(successor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3298, 3326);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10474_3468_3477(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 3468, 3477);
                        return return_v;
                    }


                    System.Exception
                    f_10474_3433_3478(Microsoft.CodeAnalysis.CSharp.BoundKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3433, 3478);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10474_2333_2369_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 2333, 2369);
                        return return_v;
                    }


                    int
                    f_10474_3541_3562(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3541, 3562);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 2037, 3890);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 2037, 3890);
                }
            }

            protected new void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 3906, 4031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 3964, 3986);

                    f_10474_3964_3985(_dagNodeLabels);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 4004, 4016);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 10474, 4004, 4015);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 3906, 4031);

                    int
                    f_10474_3964_3985(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 3964, 3985);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 3906, 4031);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 3906, 4031);
                }
            }

            protected virtual LabelSymbol GetDagNodeLabel(BoundDecisionDagNode dag)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 4047, 4432);
                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label = default(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 4151, 4384) || true) && (!f_10474_4156_4210(_dagNodeLabels, dag, out label))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 4151, 4384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 4252, 4365);

                        f_10474_4252_4364(_dagNodeLabels, dag, label = (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 4284, 4317) || ((dag is BoundLeafDecisionDagNode && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 4320, 4327)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 4330, 4363))) ? f_10474_4320_4327((BoundLeafDecisionDagNode)dag) : f_10474_4330_4363(_factory, "dagNode"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 4151, 4384);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 4404, 4417);

                    return label;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 4047, 4432);

                    bool
                    f_10474_4156_4210(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 4156, 4210);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_4320_4327(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 4320, 4327);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10474_4330_4363(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, string
                    prefix)
                    {
                        var return_v = this_param.GenerateLabel(prefix);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 4330, 4363);
                        return return_v;
                    }


                    int
                    f_10474_4252_4364(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 4252, 4364);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 4047, 4432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 4047, 4432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected sealed class WhenClauseMightAssignPatternVariableWalker : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
            {
                private bool _mightAssignSomething;

                public bool MightAssignSomething(BoundExpression expr)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 5199, 5523);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5294, 5350) || true) && (expr == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 5294, 5350);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5337, 5350);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 5294, 5350);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5374, 5409);

                        this._mightAssignSomething = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5431, 5448);

                        f_10474_5431_5447(this, expr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5470, 5504);

                        return this._mightAssignSomething;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 5199, 5523);

                        Microsoft.CodeAnalysis.CSharp.BoundNode
                        f_10474_5431_5447(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.WhenClauseMightAssignPatternVariableWalker
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        node)
                        {
                            var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 5431, 5447);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 5199, 5523);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 5199, 5523);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode Visit(BoundNode node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 5543, 5977);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5700, 5789) || true) && (node is BoundExpression { ConstantValue: { } })
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 5700, 5789);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5777, 5789);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 5700, 5789);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5898, 5958);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 5905, 5931) || ((this._mightAssignSomething && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 5934, 5938)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 5941, 5957))) ? null : DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10474, 5941, 5957);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 5543, 5977);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 5543, 5977);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 5543, 5977);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitCall(BoundCall node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 5997, 6854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 6089, 6633);

                        bool
                        mightMutate =
                        f_10474_6220_6242(f_10474_6220_6231(node)) == MethodKind.LocalFunction || (DynAbs.Tracing.TraceSender.Expression_False(10474, 6220, 6461) || f_10474_6426_6461_M(!node.ArgumentRefKindsOpt.IsDefault)) || (DynAbs.Tracing.TraceSender.Expression_False(10474, 6220, 6632) || f_10474_6578_6632(f_10474_6602_6618(node), f_10474_6620_6631(node)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 6657, 6801) || true) && (mightMutate)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 6657, 6801);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 6699, 6728);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 6657, 6801);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 6657, 6801);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 6780, 6801);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCall(node), 10474, 6780, 6800);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 6657, 6801);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 6823, 6835);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 5997, 6854);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10474_6220_6231(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 6220, 6231);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_10474_6220_6242(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 6220, 6242);
                            return return_v;
                        }


                        bool
                        f_10474_6426_6461_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 6426, 6461);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10474_6602_6618(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 6602, 6618);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10474_6620_6631(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 6620, 6631);
                            return return_v;
                        }


                        bool
                        f_10474_6578_6632(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method)
                        {
                            var return_v = MethodMayMutateReceiver(receiver, method);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 6578, 6632);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 5997, 6854);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 5997, 6854);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private static bool MethodMayMutateReceiver(BoundExpression receiver, MethodSymbol method)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10474, 6874, 7418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 7005, 7399);

                        return
                                                method != null && (DynAbs.Tracing.TraceSender.Expression_True(10474, 7037, 7096) && f_10474_7080_7096_M(!method.IsStatic)) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 7037, 7154) && f_10474_7125_7154_M(!method.IsEffectivelyReadOnly)) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 7037, 7222) && f_10474_7183_7213_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10474_7183_7196(receiver), 10474, 7183, 7213)?.IsReferenceType) == false) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 7037, 7398) &&                        // methods of primitive types do not mutate their receiver
                                                !f_10474_7336_7398(f_10474_7336_7369(f_10474_7336_7357(method))));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10474, 6874, 7418);

                        bool
                        f_10474_7080_7096_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7080, 7096);
                            return return_v;
                        }


                        bool
                        f_10474_7125_7154_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7125, 7154);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10474_7183_7196(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7183, 7196);
                            return return_v;
                        }


                        bool?
                        f_10474_7183_7213_M(bool?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7183, 7213);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10474_7336_7357(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7336, 7357);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10474_7336_7369(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7336, 7369);
                            return return_v;
                        }


                        bool
                        f_10474_7336_7398(Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = specialType.IsPrimitiveRecursiveStruct();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 7336, 7398);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 6874, 7418);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 6874, 7418);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitPropertyAccess(BoundPropertyAccess node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 7438, 8055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 7550, 7822);

                        bool
                        mightMutate =
                        f_10474_7749_7821(f_10474_7773_7789(node), f_10474_7791_7820(f_10474_7791_7810(node)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 7846, 8000) || true) && (mightMutate)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 7846, 8000);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 7888, 7917);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 7846, 8000);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 7846, 8000);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 7969, 8000);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPropertyAccess(node), 10474, 7969, 7999);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 7846, 8000);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8024, 8036);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 7438, 8055);

                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10474_7773_7789(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7773, 7789);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        f_10474_7791_7810(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                        this_param)
                        {
                            var return_v = this_param.PropertySymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7791, 7810);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10474_7791_7820(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.GetMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 7791, 7820);
                            return return_v;
                        }


                        bool
                        f_10474_7749_7821(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method)
                        {
                            var return_v = MethodMayMutateReceiver(receiver, method);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 7749, 7821);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 7438, 8055);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 7438, 8055);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 8075, 8277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8195, 8224);

                        _mightAssignSomething = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8246, 8258);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 8075, 8277);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 8075, 8277);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 8075, 8277);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitCompoundAssignmentOperator(BoundCompoundAssignmentOperator node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 8297, 8515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8433, 8462);

                        _mightAssignSomething = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8484, 8496);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 8297, 8515);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 8297, 8515);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 8297, 8515);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitConversion(BoundConversion node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 8535, 9975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8639, 8672);

                        f_10474_8639_8671(f_10474_8655_8670(node));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8694, 8774) || true) && (!_mightAssignSomething)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 8694, 8774);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8747, 8774);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConversion(node), 10474, 8747, 8773);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 8694, 8774);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8796, 8808);

                        return null;

                        void visitConversion(Conversion conversion)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 8832, 9956);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 8924, 9933);

                                switch (conversion.Kind)
                                {

                                    case ConversionKind.MethodGroup:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 8924, 9933);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 9071, 9269) || true) && (f_10474_9075_9103(conversion.Method) == MethodKind.LocalFunction)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 9071, 9269);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 9205, 9234);

                                            _mightAssignSomething = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 9071, 9269);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10474, 9303, 9309);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 8924, 9933);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 8924, 9933);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 9381, 9866) || true) && (f_10474_9385_9428_M(!conversion.UnderlyingConversions.IsDefault))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 9381, 9866);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 9502, 9831);
                                                foreach (var underlying in f_10474_9529_9561_I(conversion.UnderlyingConversions))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 9502, 9831);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 9643, 9671);

                                                    f_10474_9643_9670(underlying);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 9713, 9792) || true) && (_mightAssignSomething)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 9713, 9792);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 9785, 9792);

                                                        return;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 9713, 9792);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 9502, 9831);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 1, 330);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 1, 330);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 9381, 9866);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10474, 9900, 9906);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 8924, 9933);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 8832, 9956);

                                Microsoft.CodeAnalysis.MethodKind
                                f_10474_9075_9103(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                this_param)
                                {
                                    var return_v = this_param.MethodKind;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 9075, 9103);
                                    return return_v;
                                }


                                bool
                                f_10474_9385_9428_M(bool
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 9385, 9428);
                                    return return_v;
                                }


                                int
                                f_10474_9643_9670(Microsoft.CodeAnalysis.CSharp.Conversion
                                conversion)
                                {
                                    visitConversion(conversion);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 9643, 9670);
                                    return 0;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                                f_10474_9529_9561_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 9529, 9561);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 8832, 9956);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 8832, 9956);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 8535, 9975);

                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10474_8655_8670(Microsoft.CodeAnalysis.CSharp.BoundConversion
                        this_param)
                        {
                            var return_v = this_param.Conversion;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 8655, 8670);
                            return return_v;
                        }


                        int
                        f_10474_8639_8671(Microsoft.CodeAnalysis.CSharp.Conversion
                        conversion)
                        {
                            visitConversion(conversion);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 8639, 8671);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 8535, 9975);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 8535, 9975);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 9995, 10475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10131, 10230);

                        bool
                        mightMutate =
                        f_10474_10175_10201_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10474_10175_10189(node), 10474, 10175, 10201)?.MethodKind) == MethodKind.LocalFunction
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10254, 10420) || true) && (mightMutate)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 10254, 10420);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10296, 10325);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 10254, 10420);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 10254, 10420);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10377, 10420);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDelegateCreationExpression(node), 10474, 10377, 10419);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 10254, 10420);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10444, 10456);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 9995, 10475);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        f_10474_10175_10189(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                        this_param)
                        {
                            var return_v = this_param.MethodOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 10175, 10189);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind?
                        f_10474_10175_10201_M(Microsoft.CodeAnalysis.MethodKind?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 10175, 10201);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 9995, 10475);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 9995, 10475);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitAddressOfOperator(BoundAddressOfOperator node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 10495, 10695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10613, 10642);

                        _mightAssignSomething = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10664, 10676);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 10495, 10695);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 10495, 10695);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 10495, 10695);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitDeconstructionAssignmentOperator(BoundDeconstructionAssignmentOperator node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 10715, 10945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10863, 10892);

                        _mightAssignSomething = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 10914, 10926);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 10715, 10945);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 10715, 10945);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 10715, 10945);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitIncrementOperator(BoundIncrementOperator node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 10965, 11165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11083, 11112);

                        _mightAssignSomething = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11134, 11146);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 10965, 11165);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 10965, 11165);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 10965, 11165);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitDynamicInvocation(BoundDynamicInvocation node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 11185, 11629);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11393, 11574) || true) && (f_10474_11397_11432_M(!node.ArgumentRefKindsOpt.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 11393, 11574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11459, 11488);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 11393, 11574);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 11393, 11574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11540, 11574);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicInvocation(node), 10474, 11540, 11573);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 11393, 11574);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11598, 11610);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 11185, 11629);

                        bool
                        f_10474_11397_11432_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 11397, 11432);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 11185, 11629);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 11185, 11629);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 11649, 12114);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11871, 12059) || true) && (f_10474_11875_11910_M(!node.ArgumentRefKindsOpt.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 11871, 12059);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 11937, 11966);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 11871, 12059);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 11871, 12059);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12018, 12059);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitObjectCreationExpression(node), 10474, 12018, 12058);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 11871, 12059);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12083, 12095);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 11649, 12114);

                        bool
                        f_10474_11875_11910_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 11875, 11910);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 11649, 12114);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 11649, 12114);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitDynamicObjectCreationExpression(BoundDynamicObjectCreationExpression node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 12134, 12530);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12280, 12475) || true) && (f_10474_12284_12319_M(!node.ArgumentRefKindsOpt.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 12280, 12475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12346, 12375);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 12280, 12475);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 12280, 12475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12427, 12475);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicObjectCreationExpression(node), 10474, 12427, 12474);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 12280, 12475);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12499, 12511);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 12134, 12530);

                        bool
                        f_10474_12284_12319_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 12284, 12319);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 12134, 12530);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 12134, 12530);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitObjectInitializerMember(BoundObjectInitializerMember node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 12550, 13013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12771, 12958) || true) && (f_10474_12775_12810_M(!node.ArgumentRefKindsOpt.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 12771, 12958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12837, 12866);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 12771, 12958);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 12771, 12958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12918, 12958);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitObjectInitializerMember(node), 10474, 12918, 12957);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 12771, 12958);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 12982, 12994);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 12550, 13013);

                        bool
                        f_10474_12775_12810_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 12775, 12810);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 12550, 13013);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 12550, 13013);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitIndexerAccess(BoundIndexerAccess node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 13033, 13704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13143, 13472);

                        bool
                        mightMutate =
                        f_10474_13187_13222_M(!node.ArgumentRefKindsOpt.IsDefault) || (DynAbs.Tracing.TraceSender.Expression_False(10474, 13187, 13471) || f_10474_13406_13471(f_10474_13430_13446(node), f_10474_13448_13470(f_10474_13448_13460(node))))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13496, 13649) || true) && (mightMutate)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 13496, 13649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13538, 13567);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 13496, 13649);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 13496, 13649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13619, 13649);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitIndexerAccess(node), 10474, 13619, 13648);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 13496, 13649);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13673, 13685);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 13033, 13704);

                        bool
                        f_10474_13187_13222_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 13187, 13222);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10474_13430_13446(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 13430, 13446);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        f_10474_13448_13460(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                        this_param)
                        {
                            var return_v = this_param.Indexer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 13448, 13460);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10474_13448_13470(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.GetMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 13448, 13470);
                            return return_v;
                        }


                        bool
                        f_10474_13406_13471(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method)
                        {
                            var return_v = MethodMayMutateReceiver(receiver, method);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 13406, 13471);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 13033, 13704);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 13033, 13704);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitDynamicIndexerAccess(BoundDynamicIndexerAccess node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 13724, 14087);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13848, 14032) || true) && (f_10474_13852_13887_M(!node.ArgumentRefKindsOpt.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 13848, 14032);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13914, 13943);

                            _mightAssignSomething = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 13848, 14032);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 13848, 14032);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 13995, 14032);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicIndexerAccess(node), 10474, 13995, 14031);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 13848, 14032);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 14056, 14068);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 13724, 14087);

                        bool
                        f_10474_13852_13887_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 13852, 13887);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 13724, 14087);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 13724, 14087);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public WhenClauseMightAssignPatternVariableWalker()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10474, 4973, 14102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 5157, 5178);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10474, 4973, 14102);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 4973, 14102);
                }


                static WhenClauseMightAssignPatternVariableWalker()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10474, 4973, 14102);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10474, 4973, 14102);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 4973, 14102);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10474, 4973, 14102);
            }

            protected BoundDecisionDag ShareTempsIfPossibleAndEvaluateInput(
                            BoundDecisionDag decisionDag,
                            BoundExpression loweredSwitchGoverningExpression,
                            ArrayBuilder<BoundStatement> result,
                            out BoundExpression savedInputExpression)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 14118, 15997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 14875, 14948);

                    var
                    mightAssignWalker = f_10474_14899_14947()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 14966, 15176);

                    bool
                    canShareTemps =
                                        !decisionDag.TopologicallySortedNodes
                                        .Any(node => node is BoundWhenDecisionDagNode w && mightAssignWalker.MightAssignSomething(w.WhenExpression))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 15196, 15943) || true) && (canShareTemps)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 15196, 15943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 15255, 15425);

                        decisionDag = f_10474_15269_15424(this, loweredSwitchGoverningExpression, decisionDag, expr => result.Add(_factory.ExpressionStatement(expr)), out savedInputExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 15196, 15943);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 15196, 15943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 15572, 15688);

                        BoundExpression
                        inputTemp = f_10474_15600_15687(_tempAllocator, f_10474_15623_15686(loweredSwitchGoverningExpression))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 15710, 15770);

                        f_10474_15710_15769(inputTemp != loweredSwitchGoverningExpression);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 15792, 15869);

                        f_10474_15792_15868(result, f_10474_15803_15867(_factory, inputTemp, loweredSwitchGoverningExpression));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 15891, 15924);

                        savedInputExpression = inputTemp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 15196, 15943);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 15963, 15982);

                    return decisionDag;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 14118, 15997);

                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.WhenClauseMightAssignPatternVariableWalker
                    f_10474_14899_14947()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.WhenClauseMightAssignPatternVariableWalker();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 14899, 14947);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    f_10474_15269_15424(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    loweredInput, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag, System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    addCode, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                    savedInputExpression)
                    {
                        var return_v = this_param.ShareTempsAndEvaluateInput(loweredInput, decisionDag, addCode, out savedInputExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 15269, 15424);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10474_15623_15686(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expr)
                    {
                        var return_v = BoundDagTemp.ForOriginalInput(expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 15623, 15686);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_15600_15687(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 15600, 15687);
                        return return_v;
                    }


                    int
                    f_10474_15710_15769(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 15710, 15769);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10474_15803_15867(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 15803, 15867);
                        return return_v;
                    }


                    int
                    f_10474_15792_15868(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 15792, 15868);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 14118, 15997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 14118, 15997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected ImmutableArray<BoundStatement> LowerDecisionDagCore(BoundDecisionDag decisionDag)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 16013, 19482);
                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label = default(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 16137, 16202);

                    _loweredDecisionDag = f_10474_16159_16201();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 16220, 16249);

                    f_10474_16220_16248(this, decisionDag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 16267, 16355);

                    ImmutableArray<BoundDecisionDagNode>
                    sortedNodes = f_10474_16318_16354(decisionDag)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 16373, 16404);

                    var
                    firstNode = sortedNodes[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 16422, 16882);

                    switch (firstNode)
                    {

                        case BoundWhenDecisionDagNode _:
                        case BoundLeafDecisionDagNode _:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 16422, 16882);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 16764, 16831);

                            f_10474_16764_16830(                        // If the first node is a leaf or when clause rather than the code for the
                                                                        // lowered decision dag, jump there to start.
                                                    _loweredDecisionDag, f_10474_16788_16829(_factory, f_10474_16802_16828(this, firstNode)));
                            DynAbs.Tracing.TraceSender.TraceBreak(10474, 16857, 16863);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 16422, 16882);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17006, 17246);
                        foreach (BoundDecisionDagNode node in f_10474_17044_17055_I(sortedNodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 17006, 17246);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17097, 17227) || true) && (node is BoundWhenDecisionDagNode w)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 17097, 17227);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17185, 17204);

                                f_10474_17185_17203(this, w);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 17097, 17227);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 17006, 17246);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 1, 241);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 1, 241);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17266, 17432);

                    ImmutableArray<BoundDecisionDagNode>
                    nodesToLower = sortedNodes.WhereAsArray(n => n.Kind != BoundKind.WhenDecisionDagNode && n.Kind != BoundKind.LeafDecisionDagNode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17450, 17519);

                    var
                    loweredNodes = f_10474_17469_17518()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17546, 17551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17553, 17581);
                        for (int
        i = 0
        ,
        length = nodesToLower.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17537, 19278) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17595, 17598)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 17537, 19278))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 17537, 19278);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17640, 17684);

                            BoundDecisionDagNode
                            node = nodesToLower[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17856, 17906);

                            bool
                            alreadyLowered = f_10474_17878_17905(loweredNodes, node)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 17928, 18072) || true) && (alreadyLowered && (DynAbs.Tracing.TraceSender.Expression_True(10474, 17932, 17990) && !f_10474_17951_17990(_dagNodeLabels, node, out _)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 17928, 18072);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18040, 18049);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 17928, 18072);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18096, 18275) || true) && (f_10474_18100_18155(_dagNodeLabels, node, out label))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 18096, 18275);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18205, 18252);

                                f_10474_18205_18251(_loweredDecisionDag, f_10474_18229_18250(_factory, label));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 18096, 18275);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18374, 18521) || true) && (!alreadyLowered && (DynAbs.Tracing.TraceSender.Expression_True(10474, 18378, 18439) && f_10474_18397_18439(this, node, loweredNodes)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 18374, 18521);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18489, 18498);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 18374, 18521);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18669, 18815) || true) && (f_10474_18673_18733(this, node, loweredNodes, nodesToLower, i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 18669, 18815);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18783, 18792);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 18669, 18815);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 18952, 19032);

                            BoundDecisionDagNode
                            nextNode = (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 18984, 19002) || ((((i + 1) < length) && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 19005, 19024)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 19027, 19031))) ? nodesToLower[i + 1] : null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 19054, 19198) || true) && (nextNode != null && (DynAbs.Tracing.TraceSender.Expression_True(10474, 19058, 19109) && f_10474_19078_19109(loweredNodes, nextNode)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 19054, 19198);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 19159, 19175);

                                nextNode = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 19054, 19198);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 19222, 19259);

                            f_10474_19222_19258(this, node, nextNode);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 1, 1742);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 1, 1742);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 19298, 19318);

                    f_10474_19298_19317(
                                    loweredNodes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 19336, 19390);

                    var
                    result = f_10474_19349_19389(_loweredDecisionDag)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 19408, 19435);

                    _loweredDecisionDag = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 19453, 19467);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 16013, 19482);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10474_16159_16201()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 16159, 16201);
                        return return_v;
                    }


                    int
                    f_10474_16220_16248(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag)
                    {
                        this_param.ComputeLabelSet(decisionDag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 16220, 16248);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10474_16318_16354(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    this_param)
                    {
                        var return_v = this_param.TopologicallySortedNodes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 16318, 16354);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_16802_16828(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 16802, 16828);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10474_16788_16829(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Goto(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 16788, 16829);
                        return return_v;
                    }


                    int
                    f_10474_16764_16830(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 16764, 16830);
                        return 0;
                    }


                    int
                    f_10474_17185_17203(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    whenClause)
                    {
                        this_param.LowerWhenClause(whenClause);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 17185, 17203);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10474_17044_17055_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 17044, 17055);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10474_17469_17518()
                    {
                        var return_v = PooledHashSet<BoundDecisionDagNode>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 17469, 17518);
                        return return_v;
                    }


                    bool
                    f_10474_17878_17905(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 17878, 17905);
                        return return_v;
                    }


                    bool
                    f_10474_17951_17990(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 17951, 17990);
                        return return_v;
                    }


                    bool
                    f_10474_18100_18155(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 18100, 18155);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10474_18229_18250(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Label(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 18229, 18250);
                        return return_v;
                    }


                    int
                    f_10474_18205_18251(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 18205, 18251);
                        return 0;
                    }


                    bool
                    f_10474_18397_18439(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    loweredNodes)
                    {
                        var return_v = this_param.GenerateSwitchDispatch(node, (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>)loweredNodes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 18397, 18439);
                        return return_v;
                    }


                    bool
                    f_10474_18673_18733(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    loweredNodes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    nodesToLower, int
                    indexOfNode)
                    {
                        var return_v = this_param.GenerateTypeTestAndCast(node, (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>)loweredNodes, nodesToLower, indexOfNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 18673, 18733);
                        return return_v;
                    }


                    bool
                    f_10474_19078_19109(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 19078, 19109);
                        return return_v;
                    }


                    int
                    f_10474_19222_19258(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                    nextNode)
                    {
                        this_param.LowerDecisionDagNode(node, nextNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 19222, 19258);
                        return 0;
                    }


                    int
                    f_10474_19298_19317(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 19298, 19317);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10474_19349_19389(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 19349, 19389);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 16013, 19482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 16013, 19482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool GenerateTypeTestAndCast(
                            BoundDecisionDagNode node,
                            HashSet<BoundDecisionDagNode> loweredNodes,
                            ImmutableArray<BoundDecisionDagNode> nodesToLower,
                            int indexOfNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 19835, 21456);
                    Microsoft.CodeAnalysis.CSharp.BoundExpression sideEffect = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                    Microsoft.CodeAnalysis.CSharp.BoundExpression test = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20112, 20160);

                    f_10474_20112_20159(node == nodesToLower[indexOfNode]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20178, 21408) || true) && (node is BoundTestDecisionDagNode testNode && (DynAbs.Tracing.TraceSender.Expression_True(10474, 20182, 20314) && f_10474_20248_20265(testNode) is BoundEvaluationDecisionDagNode evaluationNode) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 20182, 20462) && f_10474_20339_20462(this, f_10474_20363_20376(testNode), f_10474_20378_20403(evaluationNode), out sideEffect, out test)))
                                        )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 20178, 21408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20526, 20561);

                        var
                        whenTrue = f_10474_20541_20560(evaluationNode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20583, 20618);

                        var
                        whenFalse = f_10474_20599_20617(testNode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20640, 20723);

                        bool
                        canEliminateEvaluationNode = !f_10474_20675_20722(this._dagNodeLabels, evaluationNode)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20747, 20837) || true) && (canEliminateEvaluationNode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 20747, 20837);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20804, 20837);

                            f_10474_20804_20836(loweredNodes, evaluationNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 20747, 20837);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 20861, 21193);

                        var
                        nextNode =
                        (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 20901, 21153) || (((indexOfNode + 2 < nodesToLower.Length) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 20901, 20995) && canEliminateEvaluationNode) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 20901, 21071) && nodesToLower[indexOfNode + 1] == evaluationNode) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 20901, 21153) && !f_10474_21101_21153(loweredNodes, nodesToLower[indexOfNode + 2])) && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 21156, 21185)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 21188, 21192))) ? nodesToLower[indexOfNode + 2] : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21217, 21283);

                        f_10474_21217_21282(
                                            _loweredDecisionDag, f_10474_21241_21281(_factory, sideEffect));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21305, 21355);

                        f_10474_21305_21354(this, test, whenTrue, whenFalse, nextNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21377, 21389);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 20178, 21408);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21428, 21441);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 19835, 21456);

                    int
                    f_10474_20112_20159(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 20112, 20159);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_20248_20265(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 20248, 20265);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10474_20363_20376(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Test;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 20363, 20376);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    f_10474_20378_20403(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Evaluation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 20378, 20403);
                        return return_v;
                    }


                    bool
                    f_10474_20339_20462(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    test, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    evaluation, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                    sideEffect, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                    testExpression)
                    {
                        var return_v = this_param.TryLowerTypeTestAndCast(test, evaluation, out sideEffect, out testExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 20339, 20462);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_20541_20560(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 20541, 20560);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_20599_20617(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 20599, 20617);
                        return return_v;
                    }


                    bool
                    f_10474_20675_20722(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    key)
                    {
                        var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 20675, 20722);
                        return return_v;
                    }


                    bool
                    f_10474_20804_20836(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 20804, 20836);
                        return return_v;
                    }


                    bool
                    f_10474_21101_21153(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21101, 21153);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10474_21241_21281(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement(expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21241, 21281);
                        return return_v;
                    }


                    int
                    f_10474_21217_21282(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21217, 21282);
                        return 0;
                    }


                    int
                    f_10474_21305_21354(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    test, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    whenTrue, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    whenFalse, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                    nextNode)
                    {
                        this_param.GenerateTest(test, whenTrue, whenFalse, nextNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21305, 21354);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 19835, 21456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 19835, 21456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void GenerateTest(BoundExpression test, BoundDecisionDagNode whenTrue, BoundDecisionDagNode whenFalse, BoundDecisionDagNode nextNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 21472, 22659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21778, 21808);

                    _factory.Syntax = test.Syntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21826, 21853);

                    f_10474_21826_21852(test != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21873, 22644) || true) && (nextNode == whenFalse)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 21873, 22644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 21940, 22041);

                        f_10474_21940_22040(_loweredDecisionDag, f_10474_21964_22039(_factory, test, f_10474_21995_22020(this, whenTrue), jumpIfTrue: true));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 21873, 22644);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 21873, 22644);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 22134, 22644) || true) && (nextNode == whenTrue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 22134, 22644);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 22200, 22303);

                            f_10474_22200_22302(_loweredDecisionDag, f_10474_22224_22301(_factory, test, f_10474_22255_22281(this, whenFalse), jumpIfTrue: false));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 22134, 22644);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 22134, 22644);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 22435, 22536);

                            f_10474_22435_22535(_loweredDecisionDag, f_10474_22459_22534(_factory, test, f_10474_22490_22515(this, whenTrue), jumpIfTrue: true));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 22558, 22625);

                            f_10474_22558_22624(_loweredDecisionDag, f_10474_22582_22623(_factory, f_10474_22596_22622(this, whenFalse)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 22134, 22644);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 21873, 22644);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 21472, 22659);

                    int
                    f_10474_21826_21852(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21826, 21852);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_21995_22020(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21995, 22020);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_21964_22039(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label, bool
                    jumpIfTrue)
                    {
                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21964, 22039);
                        return return_v;
                    }


                    int
                    f_10474_21940_22040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 21940, 22040);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_22255_22281(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22255, 22281);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_22224_22301(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label, bool
                    jumpIfTrue)
                    {
                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22224, 22301);
                        return return_v;
                    }


                    int
                    f_10474_22200_22302(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22200, 22302);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_22490_22515(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22490, 22515);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_22459_22534(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label, bool
                    jumpIfTrue)
                    {
                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22459, 22534);
                        return return_v;
                    }


                    int
                    f_10474_22435_22535(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22435, 22535);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_22596_22622(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22596, 22622);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10474_22582_22623(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Goto(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22582, 22623);
                        return return_v;
                    }


                    int
                    f_10474_22558_22624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 22558, 22624);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 21472, 22659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 21472, 22659);
                }
            }

            private bool GenerateSwitchDispatch(BoundDecisionDagNode node, HashSet<BoundDecisionDagNode> loweredNodes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 22880, 25034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23019, 23062);

                    f_10474_23019_23061(!f_10474_23033_23060(loweredNodes, node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23080, 23152) || true) && (!f_10474_23085_23116(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 23080, 23152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23139, 23152);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 23080, 23152);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23172, 23228);

                    var
                    input = f_10474_23184_23227(f_10474_23184_23221(((BoundTestDecisionDagNode)node)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23246, 23320);

                    ValueDispatchNode
                    n = f_10474_23268_23319(this, node, loweredNodes, input)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23338, 23395);

                    f_10474_23338_23394(this, n, f_10474_23364_23393(_tempAllocator, input));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23413, 23425);

                    return true;

                    bool canGenerateSwitchDispatch(BoundDecisionDagNode node)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 23445, 25019);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23543, 24172);

                            switch (node)
                            {

                                case BoundTestDecisionDagNode { WhenFalse: BoundTestDecisionDagNode test2 } test1:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 23543, 24172);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23783, 23816);

                                    return f_10474_23790_23815(test1, test2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 23543, 24172);

                                case BoundTestDecisionDagNode { WhenTrue: BoundTestDecisionDagNode test2 } test1:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 23543, 24172);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 23953, 23986);

                                    return f_10474_23960_23985(test1, test2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 23543, 24172);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 23543, 24172);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24136, 24149);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 23543, 24172);
                            }

                            bool canDispatch(BoundTestDecisionDagNode test1, BoundTestDecisionDagNode test2)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 24196, 25000);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24325, 24411) || true) && (f_10474_24329_24367(this._dagNodeLabels, test2))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 24325, 24411);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24398, 24411);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 24325, 24411);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24439, 24483);

                                    f_10474_24439_24482(!f_10474_24453_24481(loweredNodes, test2));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24509, 24529);

                                    var
                                    t1 = f_10474_24518_24528(test1)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24555, 24575);

                                    var
                                    t2 = f_10474_24564_24574(test2)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24601, 24707) || true) && (!(t1 is BoundDagValueTest || (DynAbs.Tracing.TraceSender.Expression_False(10474, 24607, 24662) || t1 is BoundDagRelationalTest)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 24601, 24707);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24694, 24707);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 24601, 24707);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24733, 24839) || true) && (!(t2 is BoundDagValueTest || (DynAbs.Tracing.TraceSender.Expression_False(10474, 24739, 24794) || t2 is BoundDagRelationalTest)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 24733, 24839);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24826, 24839);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 24733, 24839);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24865, 24939) || true) && (!f_10474_24870_24895(f_10474_24870_24878(t1), f_10474_24886_24894(t2)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 24865, 24939);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24926, 24939);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 24865, 24939);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 24965, 24977);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 24196, 25000);

                                    bool
                                    f_10474_24329_24367(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                                    key)
                                    {
                                        var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)key);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 24329, 24367);
                                        return return_v;
                                    }


                                    bool
                                    f_10474_24453_24481(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                                    item)
                                    {
                                        var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 24453, 24481);
                                        return return_v;
                                    }


                                    int
                                    f_10474_24439_24482(bool
                                    condition)
                                    {
                                        Debug.Assert(condition);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 24439, 24482);
                                        return 0;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                                    f_10474_24518_24528(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                                    this_param)
                                    {
                                        var return_v = this_param.Test;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 24518, 24528);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                                    f_10474_24564_24574(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                                    this_param)
                                    {
                                        var return_v = this_param.Test;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 24564, 24574);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                                    f_10474_24870_24878(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                                    this_param)
                                    {
                                        var return_v = this_param.Input;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 24870, 24878);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                                    f_10474_24886_24894(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                                    this_param)
                                    {
                                        var return_v = this_param.Input;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 24886, 24894);
                                        return return_v;
                                    }


                                    bool
                                    f_10474_24870_24895(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                                    other)
                                    {
                                        var return_v = this_param.Equals(other);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 24870, 24895);
                                        return return_v;
                                    }

                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 24196, 25000);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 24196, 25000);
                                }
                                throw new System.Exception("Slicer error: unreachable code");
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 23445, 25019);

                            bool
                            f_10474_23790_23815(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            test1, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            test2)
                            {
                                var return_v = canDispatch(test1, test2);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23790, 23815);
                                return return_v;
                            }


                            bool
                            f_10474_23960_23985(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            test1, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            test2)
                            {
                                var return_v = canDispatch(test1, test2);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23960, 23985);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 23445, 25019);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 23445, 25019);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 22880, 25034);

                    bool
                    f_10474_23033_23060(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23033, 23060);
                        return return_v;
                    }


                    int
                    f_10474_23019_23061(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23019, 23061);
                        return 0;
                    }


                    bool
                    f_10474_23085_23116(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node)
                    {
                        var return_v = canGenerateSwitchDispatch(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23085, 23116);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10474_23184_23221(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Test;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 23184, 23221);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10474_23184_23227(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 23184, 23227);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_23268_23319(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    loweredNodes, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    input)
                    {
                        var return_v = this_param.GatherValueDispatchNodes(node, loweredNodes, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23268, 23319);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_23364_23393(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23364, 23393);
                        return return_v;
                    }


                    int
                    f_10474_23338_23394(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        this_param.LowerValueDispatchNode(n, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 23338, 23394);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 22880, 25034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 22880, 25034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ValueDispatchNode GatherValueDispatchNodes(
                            BoundDecisionDagNode node,
                            HashSet<BoundDecisionDagNode> loweredNodes,
                            BoundDagTemp input)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 25050, 25432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 25276, 25335);

                    IValueSetFactory
                    fac = f_10474_25299_25334(f_10474_25323_25333(input))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 25353, 25417);

                    return f_10474_25360_25416(this, node, loweredNodes, input, fac);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 25050, 25432);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_25323_25333(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 25323, 25333);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.IValueSetFactory?
                    f_10474_25299_25334(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = ValueSetFactory.ForType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 25299, 25334);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_25360_25416(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    loweredNodes, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    input, Microsoft.CodeAnalysis.CSharp.IValueSetFactory?
                    fac)
                    {
                        var return_v = this_param.GatherValueDispatchNodes(node, loweredNodes, input, fac);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 25360, 25416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 25050, 25432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 25050, 25432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ValueDispatchNode GatherValueDispatchNodes(
                            BoundDecisionDagNode node,
                            HashSet<BoundDecisionDagNode> loweredNodes,
                            BoundDagTemp input,
                            IValueSetFactory fac)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 25448, 28636);
                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label = default(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 25713, 26019) || true) && (f_10474_25717_25744(loweredNodes, node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 25713, 26019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 25786, 25865);

                        bool
                        foundLabel = f_10474_25804_25864(this._dagNodeLabels, node, out label)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 25887, 25912);

                        f_10474_25887_25911(foundLabel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 25934, 26000);

                        return f_10474_25941_25999(node.Syntax, label);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 25713, 26019);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26037, 26305) || true) && (!(node is BoundTestDecisionDagNode testNode && (DynAbs.Tracing.TraceSender.Expression_True(10474, 26043, 26121) && f_10474_26088_26121(f_10474_26088_26107(f_10474_26088_26101(testNode)), input))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 26037, 26305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26164, 26198);

                        // LAFHIS
                        var
                        label1 = f_10474_26176_26197(this, node)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26220, 26286);

                        return f_10474_26227_26285(node.Syntax, label1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 26037, 26305);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26325, 28621);

                    switch (f_10474_26333_26346(testNode))
                    {

                        case BoundDagRelationalTest relational:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 26325, 28621);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26484, 26511);

                                f_10474_26484_26510(loweredNodes, testNode);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26541, 26626);

                                var
                                whenTrue = f_10474_26556_26625(this, f_10474_26581_26598(testNode), loweredNodes, input, fac)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26656, 26743);

                                var
                                whenFalse = f_10474_26672_26742(this, f_10474_26697_26715(testNode), loweredNodes, input, fac)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 26773, 26934);

                                return f_10474_26780_26933(testNode.Syntax, f_10474_26849_26865(relational), f_10474_26867_26890(relational), whenTrue: whenTrue, whenFalse: whenFalse);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 26325, 28621);

                        case BoundDagValueTest value:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 26325, 28621);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 27165, 27192);

                                f_10474_27165_27191(                            // Gather up the (value, label) pairs, starting with the first one
                                                            loweredNodes, testNode);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 27222, 27303);

                                var
                                cases = f_10474_27234_27302()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 27333, 27408);

                                f_10474_27333_27407(cases, (value: f_10474_27351_27362(value), label: f_10474_27371_27405(this, f_10474_27387_27404(testNode))));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 27438, 27483);

                                BoundTestDecisionDagNode
                                previous = testNode
                                ;
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 27513, 28091) || true) && (f_10474_27520_27538(previous) is BoundTestDecisionDagNode p && (DynAbs.Tracing.TraceSender.Expression_True(10474, 27520, 27635) && f_10474_27605_27611(p) is BoundDagValueTest vd) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 27520, 27694) && f_10474_27672_27694(f_10474_27672_27680(vd), input)) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 27520, 27766) && !f_10474_27732_27766(this._dagNodeLabels, p)) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 27520, 27828) && !f_10474_27804_27828(loweredNodes, p)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 27513, 28091);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 27894, 27959);

                                        f_10474_27894_27958(cases, (value: f_10474_27912_27920(vd), label: f_10474_27929_27956(this, f_10474_27945_27955(p))));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 27993, 28013);

                                        f_10474_27993_28012(loweredNodes, p);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 28047, 28060);

                                        previous = p;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 27513, 28091);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 27513, 28091);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 27513, 28091);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 28123, 28210);

                                var
                                otherwise = f_10474_28139_28209(this, f_10474_28164_28182(previous), loweredNodes, input, fac)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 28240, 28331);

                                return f_10474_28247_28330(this, value.Syntax, otherwise, f_10474_28298_28324(cases), fac);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 26325, 28621);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 26325, 28621);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 28445, 28479);

                                // LAFHIS
                                var
                                label2 = f_10474_28457_28478(this, node)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 28509, 28575);

                                return f_10474_28516_28574(node.Syntax, label2);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 26325, 28621);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 25448, 28636);

                    bool
                    f_10474_25717_25744(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 25717, 25744);
                        return return_v;
                    }


                    bool
                    f_10474_25804_25864(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 25804, 25864);
                        return return_v;
                    }


                    int
                    f_10474_25887_25911(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 25887, 25911);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.LeafDispatchNode
                    f_10474_25941_25999(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                    Label)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.LeafDispatchNode(syntax, Label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 25941, 25999);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10474_26088_26101(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Test;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 26088, 26101);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10474_26088_26107(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 26088, 26107);
                        return return_v;
                    }


                    bool
                    f_10474_26088_26121(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    other)
                    {
                        var return_v = this_param.Equals(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 26088, 26121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_26176_26197(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 26176, 26197);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.LeafDispatchNode
                    f_10474_26227_26285(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    Label)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.LeafDispatchNode(syntax, Label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 26227, 26285);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10474_26333_26346(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Test;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 26333, 26346);
                        return return_v;
                    }


                    bool
                    f_10474_26484_26510(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 26484, 26510);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_26581_26598(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 26581, 26598);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_26556_26625(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    loweredNodes, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    input, Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                    fac)
                    {
                        var return_v = this_param.GatherValueDispatchNodes(node, loweredNodes, input, fac);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 26556, 26625);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_26697_26715(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 26697, 26715);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_26672_26742(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    loweredNodes, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    input, Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                    fac)
                    {
                        var return_v = this_param.GatherValueDispatchNodes(node, loweredNodes, input, fac);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 26672, 26742);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10474_26849_26865(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 26849, 26865);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    f_10474_26867_26890(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                    this_param)
                    {
                        var return_v = this_param.OperatorKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 26867, 26890);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_26780_26933(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.ConstantValue
                    value, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    op, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    whenTrue, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    whenFalse)
                    {
                        var return_v = ValueDispatchNode.RelationalDispatch.CreateBalanced(syntax, value, op, whenTrue: whenTrue, whenFalse: whenFalse);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 26780, 26933);
                        return return_v;
                    }


                    bool
                    f_10474_27165_27191(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27165, 27191);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    f_10474_27234_27302()
                    {
                        var return_v = ArrayBuilder<(ConstantValue value, LabelSymbol label)>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27234, 27302);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10474_27351_27362(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 27351, 27362);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_27387_27404(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 27387, 27404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_27371_27405(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27371, 27405);
                        return return_v;
                    }


                    int
                    f_10474_27333_27407(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    this_param, (Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27333, 27407);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_27520_27538(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 27520, 27538);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10474_27605_27611(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Test;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 27605, 27611);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10474_27672_27680(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 27672, 27680);
                        return return_v;
                    }


                    bool
                    f_10474_27672_27694(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    other)
                    {
                        var return_v = this_param.Equals(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27672, 27694);
                        return return_v;
                    }


                    bool
                    f_10474_27732_27766(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    key)
                    {
                        var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27732, 27766);
                        return return_v;
                    }


                    bool
                    f_10474_27804_27828(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27804, 27828);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10474_27912_27920(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 27912, 27920);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_27945_27955(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 27945, 27955);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_27929_27956(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27929, 27956);
                        return return_v;
                    }


                    int
                    f_10474_27894_27958(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    this_param, (Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27894, 27958);
                        return 0;
                    }


                    bool
                    f_10474_27993_28012(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 27993, 28012);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_28164_28182(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 28164, 28182);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_28139_28209(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    loweredNodes, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    input, Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                    fac)
                    {
                        var return_v = this_param.GatherValueDispatchNodes(node, loweredNodes, input, fac);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 28139, 28209);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    f_10474_28298_28324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 28298, 28324);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_28247_28330(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    otherwise, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    cases, Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                    fac)
                    {
                        var return_v = this_param.PushEqualityTestsIntoTree(syntax, otherwise, cases, fac);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 28247, 28330);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_28457_28478(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 28457, 28478);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.LeafDispatchNode
                    f_10474_28516_28574(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    Label)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.LeafDispatchNode(syntax, Label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 28516, 28574);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 25448, 28636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 25448, 28636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ValueDispatchNode PushEqualityTestsIntoTree(
                            SyntaxNode syntax,
                            ValueDispatchNode otherwise,
                            ImmutableArray<(ConstantValue value, LabelSymbol label)> cases,
                            IValueSetFactory fac)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 28815, 31335);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29102, 29159) || true) && (cases.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 29102, 29159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29142, 29159);

                        return otherwise;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 29102, 29159);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29179, 30395);

                    switch (otherwise)
                    {

                        case ValueDispatchNode.LeafDispatchNode leaf:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 29179, 30395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29309, 29380);

                            return f_10474_29316_29379(syntax, cases, leaf.Label);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 29179, 30395);

                        case ValueDispatchNode.SwitchDispatch sd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 29179, 30395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29469, 29562);

                            return f_10474_29476_29561(sd.Syntax, sd.Cases.Concat(cases), sd.Otherwise);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 29179, 30395);

                        case ValueDispatchNode.RelationalDispatch { Operator: var op, Value: var value, WhenTrue: var whenTrue, WhenFalse: var whenFalse } rel:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 29179, 30395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29745, 29812);

                            var (whenTrueCases, whenFalseCases) = f_10474_29783_29811(cases, op, value);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29838, 29913);

                            f_10474_29838_29912(cases.Length == whenTrueCases.Length + whenFalseCases.Length);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 29939, 30014);

                            whenTrue = f_10474_29950_30013(this, syntax, whenTrue, whenTrueCases, fac);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 30040, 30118);

                            whenFalse = f_10474_30052_30117(this, syntax, whenFalse, whenFalseCases, fac);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 30144, 30228);

                            var
                            result = f_10474_30157_30227(rel, whenTrue: whenTrue, whenFalse: whenFalse)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 30254, 30268);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 29179, 30395);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 29179, 30395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 30324, 30376);

                            throw f_10474_30330_30375(otherwise);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 29179, 30395);
                    }

                    (ImmutableArray<(ConstantValue value, LabelSymbol label)> whenTrueCases, ImmutableArray<(ConstantValue value, LabelSymbol label)> whenFalseCases)
                                        splitCases(ImmutableArray<(ConstantValue value, LabelSymbol label)> cases, BinaryOperatorKind op, ConstantValue value)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 30415, 31320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 30741, 30832);

                            var
                            whenTrueBuilder = f_10474_30763_30831()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 30854, 30946);

                            var
                            whenFalseBuilder = f_10474_30877_30945()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 30968, 30987);

                            op = f_10474_30973_30986(op);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31009, 31192);
                                foreach (var pair in f_10474_31030_31035_I(cases))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 31009, 31192);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31085, 31169);

                                    f_10474_31085_31168(((DynAbs.Tracing.TraceSender.Conditional_F1(10474, 31086, 31120) || ((f_10474_31086_31120(fac, op, pair.value, value) && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 31123, 31138)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 31141, 31157))) ? whenTrueBuilder : whenFalseBuilder), pair);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 31009, 31192);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 1, 184);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 1, 184);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31216, 31301);

                            return (f_10474_31224_31260(whenTrueBuilder), f_10474_31262_31299(whenFalseBuilder));
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 30415, 31320);

                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            f_10474_30763_30831()
                            {
                                var return_v = ArrayBuilder<(ConstantValue value, LabelSymbol label)>.GetInstance();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 30763, 30831);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            f_10474_30877_30945()
                            {
                                var return_v = ArrayBuilder<(ConstantValue value, LabelSymbol label)>.GetInstance();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 30877, 30945);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            f_10474_30973_30986(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            kind)
                            {
                                var return_v = kind.Operator();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 30973, 30986);
                                return return_v;
                            }


                            bool
                            f_10474_31086_31120(Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                            this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            relation, Microsoft.CodeAnalysis.ConstantValue
                            left, Microsoft.CodeAnalysis.ConstantValue
                            right)
                            {
                                var return_v = this_param.Related(relation, left, right);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31086, 31120);
                                return return_v;
                            }


                            int
                            f_10474_31085_31168(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            this_param, (Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31085, 31168);
                                return 0;
                            }


                            System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            f_10474_31030_31035_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31030, 31035);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            f_10474_31224_31260(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            this_param)
                            {
                                var return_v = this_param.ToImmutableAndFree();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31224, 31260);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            f_10474_31262_31299(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                            this_param)
                            {
                                var return_v = this_param.ToImmutableAndFree();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31262, 31299);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 30415, 31320);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 30415, 31320);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 28815, 31335);

                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.SwitchDispatch
                    f_10474_29316_29379(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    dispatches, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    otherwise)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.SwitchDispatch(syntax, dispatches, otherwise);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 29316, 29379);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.SwitchDispatch
                    f_10474_29476_29561(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    dispatches, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    otherwise)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.SwitchDispatch(syntax, dispatches, otherwise);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 29476, 29561);
                        return return_v;
                    }


                    (System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)> whenTrueCases, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)> whenFalseCases)
                    f_10474_29783_29811(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    cases, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    op, Microsoft.CodeAnalysis.ConstantValue
                    value)
                    {
                        var return_v = splitCases(cases, op, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 29783, 29811);
                        return return_v;
                    }


                    int
                    f_10474_29838_29912(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 29838, 29912);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_29950_30013(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    otherwise, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    cases, Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                    fac)
                    {
                        var return_v = this_param.PushEqualityTestsIntoTree(syntax, otherwise, cases, fac);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 29950, 30013);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_30052_30117(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    otherwise, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    cases, Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                    fac)
                    {
                        var return_v = this_param.PushEqualityTestsIntoTree(syntax, otherwise, cases, fac);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 30052, 30117);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    f_10474_30157_30227(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    whenTrue, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    whenFalse)
                    {
                        var return_v = this_param.WithTrueAndFalseChildren(whenTrue: whenTrue, whenFalse: whenFalse);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 30157, 30227);
                        return return_v;
                    }


                    System.Exception
                    f_10474_30330_30375(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 30330, 30375);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 28815, 31335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 28815, 31335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void LowerValueDispatchNode(ValueDispatchNode n, BoundExpression input)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 31351, 32127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31463, 32112);

                    switch (n)
                    {

                        case ValueDispatchNode.LeafDispatchNode leaf:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 31463, 32112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31585, 31636);

                            f_10474_31585_31635(_loweredDecisionDag, f_10474_31609_31634(_factory, leaf.Label));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31662, 31669);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 31463, 32112);

                        case ValueDispatchNode.SwitchDispatch eq:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 31463, 32112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31758, 31793);

                            f_10474_31758_31792(this, eq, input);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31819, 31826);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 31463, 32112);

                        case ValueDispatchNode.RelationalDispatch rel:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 31463, 32112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31920, 31960);

                            f_10474_31920_31959(this, rel, input);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 31986, 31993);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 31463, 32112);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 31463, 32112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32049, 32093);

                            throw f_10474_32055_32092(n);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 31463, 32112);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 31351, 32127);

                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10474_31609_31634(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Goto(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31609, 31634);
                        return return_v;
                    }


                    int
                    f_10474_31585_31635(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31585, 31635);
                        return 0;
                    }


                    int
                    f_10474_31758_31792(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.SwitchDispatch
                    node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        this_param.LowerSwitchDispatchNode(node, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31758, 31792);
                        return 0;
                    }


                    int
                    f_10474_31920_31959(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    rel, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        this_param.LowerRelationalDispatchNode(rel, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 31920, 31959);
                        return 0;
                    }


                    System.Exception
                    f_10474_32055_32092(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 32055, 32092);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 31351, 32127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 31351, 32127);
                }
            }

            private void LowerRelationalDispatchNode(ValueDispatchNode.RelationalDispatch rel, BoundExpression input)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 32143, 33558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32281, 32355);

                    var
                    test = f_10474_32292_32354(this, rel.Syntax, input, rel.Operator, rel.Value)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32373, 33543) || true) && (f_10474_32377_32389(rel) is ValueDispatchNode.LeafDispatchNode whenTrue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 32373, 33543);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32478, 32517);

                        LabelSymbol
                        trueLabel = whenTrue.Label
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32539, 32624);

                        f_10474_32539_32623(_loweredDecisionDag, f_10474_32563_32622(_factory, test, trueLabel, jumpIfTrue: true));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32646, 32691);

                        f_10474_32646_32690(this, f_10474_32669_32682(rel), input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 32373, 33543);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 32373, 33543);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32733, 33543) || true) && (f_10474_32737_32750(rel) is ValueDispatchNode.LeafDispatchNode whenFalse)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 32733, 33543);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32840, 32881);

                            LabelSymbol
                            falseLabel = whenFalse.Label
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 32903, 32990);

                            f_10474_32903_32989(_loweredDecisionDag, f_10474_32927_32988(_factory, test, falseLabel, jumpIfTrue: false));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33012, 33056);

                            f_10474_33012_33055(this, f_10474_33035_33047(rel), input);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 32733, 33543);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 32733, 33543);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33138, 33208);

                            LabelSymbol
                            falseLabel = f_10474_33163_33207(_factory, "relationalDispatch")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33230, 33317);

                            f_10474_33230_33316(_loweredDecisionDag, f_10474_33254_33315(_factory, test, falseLabel, jumpIfTrue: false));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33339, 33383);

                            f_10474_33339_33382(this, f_10474_33362_33374(rel), input);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33405, 33457);

                            f_10474_33405_33456(_loweredDecisionDag, f_10474_33429_33455(_factory, falseLabel));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33479, 33524);

                            f_10474_33479_33523(this, f_10474_33502_33515(rel), input);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 32733, 33543);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 32373, 33543);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 32143, 33558);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_32292_32354(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind, Microsoft.CodeAnalysis.ConstantValue
                    value)
                    {
                        var return_v = this_param.MakeRelationalTest(syntax, input, operatorKind, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 32292, 32354);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_32377_32389(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 32377, 32389);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_32563_32622(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label, bool
                    jumpIfTrue)
                    {
                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 32563, 32622);
                        return return_v;
                    }


                    int
                    f_10474_32539_32623(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 32539, 32623);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_32669_32682(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 32669, 32682);
                        return return_v;
                    }


                    int
                    f_10474_32646_32690(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        this_param.LowerValueDispatchNode(n, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 32646, 32690);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_32737_32750(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 32737, 32750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_32927_32988(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label, bool
                    jumpIfTrue)
                    {
                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 32927, 32988);
                        return return_v;
                    }


                    int
                    f_10474_32903_32989(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 32903, 32989);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_33035_33047(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 33035, 33047);
                        return return_v;
                    }


                    int
                    f_10474_33012_33055(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        this_param.LowerValueDispatchNode(n, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33012, 33055);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10474_33163_33207(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, string
                    prefix)
                    {
                        var return_v = this_param.GenerateLabel(prefix);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33163, 33207);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_33254_33315(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label, bool
                    jumpIfTrue)
                    {
                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33254, 33315);
                        return return_v;
                    }


                    int
                    f_10474_33230_33316(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33230, 33316);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_33362_33374(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 33362, 33374);
                        return return_v;
                    }


                    int
                    f_10474_33339_33382(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        this_param.LowerValueDispatchNode(n, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33339, 33382);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10474_33429_33455(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Label(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33429, 33455);
                        return return_v;
                    }


                    int
                    f_10474_33405_33456(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33405, 33456);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    f_10474_33502_33515(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 33502, 33515);
                        return return_v;
                    }


                    int
                    f_10474_33479_33523(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
                    n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        this_param.LowerValueDispatchNode(n, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33479, 33523);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 32143, 33558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 32143, 33558);
                }
            }
            private sealed class CasesComparer : IComparer<(ConstantValue value, LabelSymbol label)>
            {
                private readonly IValueSetFactory _fac;

                public CasesComparer(TypeSymbol type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10474, 33906, 34088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33883, 33887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 33984, 34021);

                        _fac = f_10474_33991_34020(type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34043, 34069);

                        f_10474_34043_34068(_fac is { });
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10474, 33906, 34088);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 33906, 34088);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 33906, 34088);
                    }
                }

                int IComparer<(ConstantValue value, LabelSymbol label)>.Compare((ConstantValue value, LabelSymbol label) left, (ConstantValue value, LabelSymbol label) right)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 34108, 35721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34307, 34326);

                        var
                        x = left.value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34348, 34368);

                        var
                        y = right.value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34390, 34867);

                        f_10474_34390_34866(f_10474_34403_34418(x) switch
                        {
                            ConstantValueTypeDiscriminator.Decimal when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34474, 34520) && DynAbs.Tracing.TraceSender.Expression_True(10474, 34474, 34520))
    => true,
                            ConstantValueTypeDiscriminator.Single when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34547, 34592) && DynAbs.Tracing.TraceSender.Expression_True(10474, 34547, 34592))
    => true,
                            ConstantValueTypeDiscriminator.Double when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34619, 34664) && DynAbs.Tracing.TraceSender.Expression_True(10474, 34619, 34664))
    => true,
                            ConstantValueTypeDiscriminator.NInt when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34691, 34734) && DynAbs.Tracing.TraceSender.Expression_True(10474, 34691, 34734))
    => true,
                            ConstantValueTypeDiscriminator.NUInt when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34761, 34805) && DynAbs.Tracing.TraceSender.Expression_True(10474, 34761, 34805))
    => true,
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34832, 34842) && DynAbs.Tracing.TraceSender.Expression_True(10474, 34832, 34842))
    => false
                        });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 34889, 34938);

                        f_10474_34889_34937(f_10474_34902_34917(y) == f_10474_34921_34936(x));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 35130, 35424);

                        return
                        (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 35162, 35170) || ((f_10474_35162_35170(x) && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 35173, 35174)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 35202, 35423))) ? 1 : (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 35202, 35210) || ((f_10474_35202_35210(y) && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 35213, 35215)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 35243, 35423))) ? -1 : (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 35243, 35297) || ((f_10474_35243_35297(_fac, BinaryOperatorKind.LessThanOrEqual, x, y) && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 35329, 35394)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 35422, 35423))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10474, 35330, 35384) || ((f_10474_35330_35384(_fac, BinaryOperatorKind.LessThanOrEqual, y, x) && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 35387, 35388)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 35391, 35393))) ? 0 : -1) : 1;

                        static bool isNaN(ConstantValue value)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 35487, 35701);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 35515, 35701);
                                return (f_10474_35516_35535(value) == ConstantValueTypeDiscriminator.Single || (DynAbs.Tracing.TraceSender.Expression_False(10474, 35516, 35640) || f_10474_35580_35599(value) == ConstantValueTypeDiscriminator.Double)) && (DynAbs.Tracing.TraceSender.Expression_True(10474, 35515, 35701) && f_10474_35670_35701(f_10474_35683_35700(value))); DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 35487, 35701);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 35487, 35701);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 35487, 35701);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 34108, 35721);

                        Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                        f_10474_34403_34418(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.Discriminator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 34403, 34418);
                            return return_v;
                        }


                        int
                        f_10474_34390_34866(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 34390, 34866);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                        f_10474_34902_34917(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.Discriminator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 34902, 34917);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                        f_10474_34921_34936(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.Discriminator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 34921, 34936);
                            return return_v;
                        }


                        int
                        f_10474_34889_34937(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 34889, 34937);
                            return 0;
                        }


                        bool
                        f_10474_35162_35170(Microsoft.CodeAnalysis.ConstantValue
                        value)
                        {
                            var return_v = isNaN(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 35162, 35170);
                            return return_v;
                        }


                        bool
                        f_10474_35202_35210(Microsoft.CodeAnalysis.ConstantValue
                        value)
                        {
                            var return_v = isNaN(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 35202, 35210);
                            return return_v;
                        }


                        bool
                        f_10474_35243_35297(Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        relation, Microsoft.CodeAnalysis.ConstantValue
                        left, Microsoft.CodeAnalysis.ConstantValue
                        right)
                        {
                            var return_v = this_param.Related(relation, left, right);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 35243, 35297);
                            return return_v;
                        }


                        bool
                        f_10474_35330_35384(Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        relation, Microsoft.CodeAnalysis.ConstantValue
                        left, Microsoft.CodeAnalysis.ConstantValue
                        right)
                        {
                            var return_v = this_param.Related(relation, left, right);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 35330, 35384);
                            return return_v;
                        }


                        static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                        f_10474_35516_35535(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.Discriminator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 35516, 35535);
                            return return_v;
                        }


                        static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                        f_10474_35580_35599(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.Discriminator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 35580, 35599);
                            return return_v;
                        }


                        static double
                        f_10474_35683_35700(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.DoubleValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 35683, 35700);
                            return return_v;
                        }


                        static bool
                        f_10474_35670_35701(double
                        d)
                        {
                            var return_v = double.IsNaN(d);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 35670, 35701);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 34108, 35721);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 34108, 35721);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static CasesComparer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10474, 33728, 35736);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10474, 33728, 35736);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 33728, 35736);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10474, 33728, 35736);

                Microsoft.CodeAnalysis.CSharp.IValueSetFactory?
                f_10474_33991_34020(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ValueSetFactory.ForType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 33991, 34020);
                    return return_v;
                }


                int
                f_10474_34043_34068(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 34043, 34068);
                    return 0;
                }

            }

            private void LowerSwitchDispatchNode(ValueDispatchNode.SwitchDispatch node, BoundExpression input)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 35752, 40646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 35883, 35925);

                    LabelSymbol
                    defaultLabel = node.Otherwise
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 35945, 40631) || true) && (f_10474_35949_35990(f_10474_35949_35959(input)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 35945, 40631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 36266, 36301);

                        MethodSymbol
                        stringEquality = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 36323, 36648) || true) && (f_10474_36327_36349(f_10474_36327_36337(input)) == SpecialType.System_String)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 36323, 36648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 36428, 36485);

                            f_10474_36428_36484(this, node.Cases.Length, node.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 36511, 36625);

                            stringEquality = f_10474_36528_36624(_localRewriter, node.Syntax, SpecialMember.System_String__op_Equality);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 36323, 36648);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 36672, 36773);

                        var
                        dispatch = f_10474_36687_36772(node.Syntax, input, node.Cases, defaultLabel, stringEquality)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 36795, 36829);

                        f_10474_36795_36828(_loweredDecisionDag, dispatch);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 35945, 40631);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 35945, 40631);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 36871, 40631) || true) && (f_10474_36875_36905(f_10474_36875_36885(input)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 36871, 40631);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 37111, 37174);

                            ImmutableArray<(ConstantValue value, LabelSymbol label)>
                            cases
                            = default(ImmutableArray<(ConstantValue value, LabelSymbol label)>);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 37196, 38202);

                            switch (f_10474_37204_37226(f_10474_37204_37214(input)))
                            {

                                case SpecialType.System_IntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 37196, 38202);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 37372, 37452);

                                        input = f_10474_37380_37451(_factory, f_10474_37397_37443(_factory, SpecialType.System_Int64), input);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 37486, 37583);

                                        cases = node.Cases.SelectAsArray(p => (ConstantValue.Create((long)p.value.Int32Value), p.label));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10474, 37617, 37623);

                                        break;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 37196, 38202);

                                case SpecialType.System_UIntPtr:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 37196, 38202);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 37777, 37858);

                                        input = f_10474_37785_37857(_factory, f_10474_37802_37849(_factory, SpecialType.System_UInt64), input);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 37892, 37991);

                                        cases = node.Cases.SelectAsArray(p => (ConstantValue.Create((ulong)p.value.UInt32Value), p.label));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10474, 38025, 38031);

                                        break;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 37196, 38202);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 37196, 38202);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 38126, 38179);

                                    throw f_10474_38132_38178(f_10474_38167_38177(input));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 37196, 38202);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 38226, 38328);

                            var
                            dispatch = f_10474_38241_38327(node.Syntax, input, cases, defaultLabel, equalityMethod: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 38350, 38384);

                            f_10474_38350_38383(_loweredDecisionDag, dispatch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 36871, 40631);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 36871, 40631);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 38705, 39195);

                            var
                            lessThanOrEqualOperator = f_10474_38735_38757(f_10474_38735_38745(input)) switch
                            {
                                SpecialType.System_Single when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 38813, 38881) && DynAbs.Tracing.TraceSender.Expression_True(10474, 38813, 38881))
=> BinaryOperatorKind.FloatLessThanOrEqual,
                                SpecialType.System_Double when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 38908, 38977) && DynAbs.Tracing.TraceSender.Expression_True(10474, 38908, 38977))
=> BinaryOperatorKind.DoubleLessThanOrEqual,
                                SpecialType.System_Decimal when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39004, 39075) && DynAbs.Tracing.TraceSender.Expression_True(10474, 39004, 39075))
=> BinaryOperatorKind.DecimalLessThanOrEqual,
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39102, 39171) && DynAbs.Tracing.TraceSender.Expression_True(10474, 39102, 39171))
=> throw f_10474_39113_39171(f_10474_39148_39170(f_10474_39148_39158(input)))
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39219, 39278);

                            var
                            cases = node.Cases.Sort(f_10474_39247_39276(f_10474_39265_39275(input)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39300, 39336);

                            f_10474_39300_39335(0, cases.Length);

                            int
                    f_10474_39300_39335(int
                    firstIndex, int
                    count)
                            {
                                lowerFloatDispatch(firstIndex, count);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39300, 39335);
                                return 0;
                            }

                            void lowerFloatDispatch(int firstIndex, int count)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 39360, 40612);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39459, 40589) || true) && (count <= 3)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 39459, 40589);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39540, 39554);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39556, 39582);
                                            for (int
                i = firstIndex
                ,
                limit = firstIndex + count
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39531, 39830) || true) && (i < limit)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39595, 39598)
                , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 39531, 39830))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 39531, 39830);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39664, 39799);

                                                f_10474_39664_39798(_loweredDecisionDag, f_10474_39688_39797(_factory, f_10474_39713_39762(this, node.Syntax, input, cases[i].value), cases[i].label, jumpIfTrue: true));
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 1, 300);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 1, 300);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 39862, 39915);

                                        f_10474_39862_39914(
                                                                    _loweredDecisionDag, f_10474_39886_39913(_factory, defaultLabel));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 39459, 40589);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 39459, 40589);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 40029, 40050);

                                        int
                                        half = count / 2
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 40080, 40135);

                                        var
                                        gt = f_10474_40089_40134(_factory, "greaterThanMidpoint")
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 40165, 40339);

                                        f_10474_40165_40338(_loweredDecisionDag, f_10474_40189_40337(_factory, f_10474_40214_40313(this, node.Syntax, input, lessThanOrEqualOperator, cases[firstIndex + half - 1].value), gt, jumpIfTrue: false));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 40369, 40406);

                                        f_10474_40369_40405(firstIndex, half);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 40436, 40480);

                                        f_10474_40436_40479(_loweredDecisionDag, f_10474_40460_40478(_factory, gt));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 40510, 40562);

                                        f_10474_40510_40561(firstIndex + half, count - half);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 39459, 40589);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 39360, 40612);

                                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                                    f_10474_39713_39762(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                                    input, Microsoft.CodeAnalysis.ConstantValue
                                    value)
                                    {
                                        var return_v = this_param.MakeValueTest(syntax, input, value);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39713, 39762);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                                    f_10474_39688_39797(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                                    label, bool
                                    jumpIfTrue)
                                    {
                                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39688, 39797);
                                        return return_v;
                                    }


                                    int
                                    f_10474_39664_39798(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                                    item)
                                    {
                                        this_param.Add(item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39664, 39798);
                                        return 0;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                                    f_10474_39886_39913(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                                    label)
                                    {
                                        var return_v = this_param.Goto(label);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39886, 39913);
                                        return return_v;
                                    }


                                    int
                                    f_10474_39862_39914(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                                    item)
                                    {
                                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39862, 39914);
                                        return 0;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                                    f_10474_40089_40134(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                                    this_param, string
                                    prefix)
                                    {
                                        var return_v = this_param.GenerateLabel(prefix);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40089, 40134);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                                    f_10474_40214_40313(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                                    input, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                                    operatorKind, Microsoft.CodeAnalysis.ConstantValue
                                    value)
                                    {
                                        var return_v = this_param.MakeRelationalTest(syntax, input, operatorKind, value);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40214, 40313);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                                    f_10474_40189_40337(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                                    label, bool
                                    jumpIfTrue)
                                    {
                                        var return_v = this_param.ConditionalGoto(condition, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, jumpIfTrue: jumpIfTrue);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40189, 40337);
                                        return return_v;
                                    }


                                    int
                                    f_10474_40165_40338(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                                    item)
                                    {
                                        this_param.Add(item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40165, 40338);
                                        return 0;
                                    }


                                    int
                                    f_10474_40369_40405(int
                                    firstIndex, int
                                    count)
                                    {
                                        lowerFloatDispatch(firstIndex, count);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40369, 40405);
                                        return 0;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                                    f_10474_40460_40478(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                                    label)
                                    {
                                        var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40460, 40478);
                                        return return_v;
                                    }


                                    int
                                    f_10474_40436_40479(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                                    item)
                                    {
                                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40436, 40479);
                                        return 0;
                                    }


                                    int
                                    f_10474_40510_40561(int
                                    firstIndex, int
                                    count)
                                    {
                                        lowerFloatDispatch(firstIndex, count);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 40510, 40561);
                                        return 0;
                                    }

                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 39360, 40612);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 39360, 40612);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 36871, 40631);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 35945, 40631);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 35752, 40646);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10474_35949_35959(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 35949, 35959);
                        return return_v;
                    }


                    bool
                    f_10474_35949_35990(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type)
                    {
                        var return_v = type.IsValidV6SwitchGoverningType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 35949, 35990);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_36327_36337(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 36327, 36337);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10474_36327_36349(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 36327, 36349);
                        return return_v;
                    }


                    int
                    f_10474_36428_36484(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, int
                    labelsCount, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNode)
                    {
                        this_param.EnsureStringHashFunction(labelsCount, syntaxNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 36428, 36484);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10474_36528_36624(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.SpecialMember
                    specialMember)
                    {
                        var return_v = this_param.UnsafeGetSpecialTypeMethod(syntax, specialMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 36528, 36624);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    f_10474_36687_36772(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    cases, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    defaultLabel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    equalityMethod)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch(syntax, expression, cases, defaultLabel, equalityMethod);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 36687, 36772);
                        return return_v;
                    }


                    int
                    f_10474_36795_36828(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 36795, 36828);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_36875_36885(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 36875, 36885);
                        return return_v;
                    }


                    bool
                    f_10474_36875_36905(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNativeIntegerType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 36875, 36905);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_37204_37214(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 37204, 37214);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10474_37204_37226(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 37204, 37226);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10474_37397_37443(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 37397, 37443);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_37380_37451(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 37380, 37451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10474_37802_37849(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 37802, 37849);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_37785_37857(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 37785, 37857);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_38167_38177(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 38167, 38177);
                        return return_v;
                    }


                    System.Exception
                    f_10474_38132_38178(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 38132, 38178);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    f_10474_38241_38327(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    cases, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    defaultLabel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    equalityMethod)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch(syntax, expression, cases, defaultLabel, equalityMethod: equalityMethod);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 38241, 38327);
                        return return_v;
                    }


                    int
                    f_10474_38350_38383(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 38350, 38383);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_38735_38745(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 38735, 38745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10474_38735_38757(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 38735, 38757);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_39148_39158(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 39148, 39158);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10474_39148_39170(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 39148, 39170);
                        return return_v;
                    }


                    System.Exception
                    f_10474_39113_39171(Microsoft.CodeAnalysis.SpecialType
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39113, 39171);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10474_39265_39275(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 39265, 39275);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.CasesComparer
                    f_10474_39247_39276(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.CasesComparer(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 39247, 39276);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 35752, 40646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 35752, 40646);
                }
            }

            private void EnsureStringHashFunction(int labelsCount, SyntaxNode syntaxNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 40941, 43804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 41051, 41090);

                    var
                    module = f_10474_41064_41089(_localRewriter)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 41108, 41280) || true) && (module == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 41108, 41280);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 41254, 41261);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 41108, 41280);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 41686, 41859) || true) && (!CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter.ShouldGenerateHashTableSwitch(module, labelsCount))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 41686, 41859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 41833, 41840);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 41686, 41859);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 42734, 42825);

                    var
                    privateImplClass = f_10474_42757_42824(module, syntaxNode, _localRewriter._diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 42843, 43034) || true) && (f_10474_42847_42958(privateImplClass, CodeAnalysis.CodeGen.PrivateImplementationDetails.SynthesizedStringHashFunctionName) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 42843, 43034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43008, 43015);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 42843, 43034);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43126, 43229);

                    var
                    charsMember = f_10474_43144_43228(_localRewriter._compilation, SpecialMember.System_String__Chars)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43247, 43392) || true) && ((object)charsMember == null || (DynAbs.Tracing.TraceSender.Expression_False(10474, 43251, 43324) || f_10474_43282_43316(charsMember) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 43247, 43392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43366, 43373);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 43247, 43392);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43412, 43484);

                    TypeSymbol
                    returnType = f_10474_43436_43483(_factory, SpecialType.System_UInt32)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43502, 43573);

                    TypeSymbol
                    paramType = f_10474_43525_43572(_factory, SpecialType.System_String)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43593, 43706);

                    var
                    method = f_10474_43606_43705(module.SourceModule, privateImplClass, returnType, paramType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 43724, 43789);

                    f_10474_43724_43788(privateImplClass, f_10474_43765_43787(method));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 40941, 43804);

                    Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                    f_10474_41064_41089(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param)
                    {
                        var return_v = this_param.EmitModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 41064, 41089);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                    f_10474_42757_42824(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetPrivateImplClass(syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 42757, 42824);
                        return return_v;
                    }


                    Microsoft.Cci.IMethodDefinition?
                    f_10474_42847_42958(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMethod(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 42847, 42958);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10474_43144_43228(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialMember
                    specialMember)
                    {
                        var return_v = this_param.GetSpecialTypeMember(specialMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 43144, 43228);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_10474_43282_43316(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 43282, 43316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10474_43436_43483(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 43436, 43483);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10474_43525_43572(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 43525, 43572);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod
                    f_10474_43606_43705(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    containingModule, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                    privateImplType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    returnType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    paramType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod(containingModule, privateImplType, returnType, paramType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 43606, 43705);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10474_43765_43787(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 43765, 43787);
                        return return_v;
                    }


                    bool
                    f_10474_43724_43788(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    method)
                    {
                        var return_v = this_param.TryAddSynthesizedMethod((Microsoft.Cci.IMethodDefinition)method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 43724, 43788);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 40941, 43804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 40941, 43804);
                }
            }

            private void LowerWhenClause(BoundWhenDecisionDagNode whenClause)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 43820, 47073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 44420, 44481);

                    var
                    whenTrue = (BoundLeafDecisionDagNode)f_10474_44461_44480(whenClause)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 44499, 44561);

                    LabelSymbol
                    labelToSectionScope = f_10474_44533_44560(this, whenClause)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 44581, 44664);

                    ArrayBuilder<BoundStatement>
                    sectionBuilder = f_10474_44627_44663(this, whenClause.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 44682, 44738);

                    f_10474_44682_44737(sectionBuilder, f_10474_44701_44736(_factory, labelToSectionScope));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 44756, 45518);
                        foreach (BoundPatternBinding binding in f_10474_44796_44815_I(f_10474_44796_44815(whenClause)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 44756, 45518);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 44857, 44935);

                            BoundExpression
                            left = f_10474_44880_44934(_localRewriter, binding.VariableAccess)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45159, 45236);

                            f_10474_45159_45235(f_10474_45172_45181(left) == BoundKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10474, 45172, 45234) && left == binding.VariableAccess));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45258, 45334);

                            BoundExpression
                            right = f_10474_45282_45333(_tempAllocator, binding.TempContainingValue)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45356, 45499) || true) && (left != right)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 45356, 45499);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45423, 45476);

                                f_10474_45423_45475(sectionBuilder, f_10474_45442_45474(_factory, left, right));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 45356, 45499);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 44756, 45518);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10474, 1, 763);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10474, 1, 763);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45538, 45575);

                    var
                    whenFalse = f_10474_45554_45574(whenClause)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45593, 45635);

                    var
                    trueLabel = f_10474_45609_45634(this, whenTrue)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45653, 47058) || true) && (f_10474_45657_45682(whenClause) != null && (DynAbs.Tracing.TraceSender.Expression_True(10474, 45657, 45755) && f_10474_45694_45733(f_10474_45694_45719(whenClause)) != f_10474_45737_45755()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 45653, 47058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45797, 45833);

                        _factory.Syntax = whenClause.Syntax;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 45855, 46001);

                        BoundStatement
                        conditionalGoto = f_10474_45888_46000(_factory, f_10474_45913_45970(_localRewriter, f_10474_45944_45969(whenClause)), trueLabel, jumpIfTrue: true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46140, 46428) || true) && (f_10474_46144_46167() && (DynAbs.Tracing.TraceSender.Expression_True(10474, 46144, 46218) && f_10474_46171_46218_M(!f_10474_46172_46197(whenClause).WasCompilerGenerated)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 46140, 46428);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46268, 46405);

                            conditionalGoto = f_10474_46286_46404(_localRewriter._instrumenter, f_10474_46361_46386(whenClause), conditionalGoto);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 46140, 46428);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46452, 46488);

                        f_10474_46452_46487(
                                            sectionBuilder, conditionalGoto);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46512, 46544);

                        f_10474_46512_46543(whenFalse != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46684, 46748);

                        BoundStatement
                        jump = f_10474_46706_46747(_factory, f_10474_46720_46746(this, whenFalse))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46770, 46858);

                        f_10474_46770_46857(sectionBuilder, (DynAbs.Tracing.TraceSender.Conditional_F1(10474, 46789, 46812) || ((f_10474_46789_46812() && DynAbs.Tracing.TraceSender.Conditional_F2(10474, 46815, 46849)) || DynAbs.Tracing.TraceSender.Conditional_F3(10474, 46852, 46856))) ? f_10474_46815_46849(_factory, jump) : jump);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 45653, 47058);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 45653, 47058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46940, 46972);

                        f_10474_46940_46971(whenFalse == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 46994, 47039);

                        f_10474_46994_47038(sectionBuilder, f_10474_47013_47037(_factory, trueLabel));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 45653, 47058);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 43820, 47073);

                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_44461_44480(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 44461, 44480);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_44533_44560(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 44533, 44560);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10474_44627_44663(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    section)
                    {
                        var return_v = this_param.BuilderForSection(section);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 44627, 44663);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10474_44701_44736(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Label(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 44701, 44736);
                        return return_v;
                    }


                    int
                    f_10474_44682_44737(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 44682, 44737);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                    f_10474_44796_44815(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Bindings;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 44796, 44815);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10474_44880_44934(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.VisitExpression(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 44880, 44934);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10474_45172_45181(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 45172, 45181);
                        return return_v;
                    }


                    int
                    f_10474_45159_45235(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 45159, 45235);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_45282_45333(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 45282, 45333);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10474_45442_45474(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 45442, 45474);
                        return return_v;
                    }


                    int
                    f_10474_45423_45475(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 45423, 45475);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                    f_10474_44796_44815_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 44796, 44815);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                    f_10474_45554_45574(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 45554, 45574);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_45609_45634(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 45609, 45634);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10474_45657_45682(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 45657, 45682);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_45694_45719(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 45694, 45719);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10474_45694_45733(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 45694, 45733);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10474_45737_45755()
                    {
                        var return_v = ConstantValue.True;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 45737, 45755);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_45944_45969(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 45944, 45969);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10474_45913_45970(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.VisitExpression(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 45913, 45970);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_45888_46000(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label, bool
                    jumpIfTrue)
                    {
                        var return_v = this_param.ConditionalGoto(condition, label, jumpIfTrue: jumpIfTrue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 45888, 46000);
                        return return_v;
                    }


                    bool
                    f_10474_46144_46167()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 46144, 46167);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_46172_46197(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 46172, 46197);
                        return return_v;
                    }


                    bool
                    f_10474_46171_46218_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 46171, 46218);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_46361_46386(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 46361, 46386);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_46286_46404(Microsoft.CodeAnalysis.CSharp.Instrumenter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    ifConditionGotoBody)
                    {
                        var return_v = this_param.InstrumentSwitchWhenClauseConditionalGotoBody(original, ifConditionGotoBody);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46286, 46404);
                        return return_v;
                    }


                    int
                    f_10474_46452_46487(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46452, 46487);
                        return 0;
                    }


                    int
                    f_10474_46512_46543(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46512, 46543);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_46720_46746(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46720, 46746);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10474_46706_46747(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Goto(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46706, 46747);
                        return return_v;
                    }


                    bool
                    f_10474_46789_46812()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 46789, 46812);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_46815_46849(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    statementOpt)
                    {
                        var return_v = this_param.HiddenSequencePoint(statementOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46815, 46849);
                        return return_v;
                    }


                    int
                    f_10474_46770_46857(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46770, 46857);
                        return 0;
                    }


                    int
                    f_10474_46940_46971(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46940, 46971);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10474_47013_47037(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Goto(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 47013, 47037);
                        return return_v;
                    }


                    int
                    f_10474_46994_47038(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 46994, 47038);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 43820, 47073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 43820, 47073);
                }
            }

            private void LowerDecisionDagNode(BoundDecisionDagNode node, BoundDecisionDagNode nextNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10474, 47262, 49167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 47386, 47416);

                    _factory.Syntax = node.Syntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 47434, 49152);

                    switch (node)
                    {

                        case BoundEvaluationDecisionDagNode evaluationNode:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 47434, 49152);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 47596, 47668);

                                BoundExpression
                                sideEffect = f_10474_47625_47667(this, f_10474_47641_47666(evaluationNode))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 47698, 47731);

                                f_10474_47698_47730(sideEffect != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 47761, 47827);

                                f_10474_47761_47826(_loweredDecisionDag, f_10474_47785_47825(_factory, sideEffect));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 48155, 48273) || true) && (f_10474_48159_48182())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 48155, 48273);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 48217, 48273);

                                    f_10474_48217_48272(_loweredDecisionDag, f_10474_48241_48271(_factory));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 48155, 48273);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 48305, 48630) || true) && (nextNode != f_10474_48321_48340(evaluationNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 48305, 48630);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 48522, 48599);

                                    f_10474_48522_48598(                                // We only need a goto if we would not otherwise fall through to the desired state
                                                                    _loweredDecisionDag, f_10474_48546_48597(_factory, f_10474_48560_48596(this, f_10474_48576_48595(evaluationNode))));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 48305, 48630);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10474, 48685, 48691);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 47434, 49152);

                        case BoundTestDecisionDagNode testNode:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 47434, 49152);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 48811, 48864);

                                BoundExpression
                                test = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LowerTest(f_10474_48849_48862(testNode)), 10474, 48834, 48863)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 48894, 48962);

                                f_10474_48894_48961(this, test, f_10474_48913_48930(testNode), f_10474_48932_48950(testNode), nextNode);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10474, 49017, 49023);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 47434, 49152);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10474, 47434, 49152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10474, 49081, 49133);

                            throw f_10474_49087_49132(f_10474_49122_49131(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10474, 47434, 49152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10474, 47262, 49167);

                    Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    f_10474_47641_47666(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Evaluation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 47641, 47666);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10474_47625_47667(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    evaluation)
                    {
                        var return_v = this_param.LowerEvaluation(evaluation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 47625, 47667);
                        return return_v;
                    }


                    int
                    f_10474_47698_47730(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 47698, 47730);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10474_47785_47825(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement(expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 47785, 47825);
                        return return_v;
                    }


                    int
                    f_10474_47761_47826(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 47761, 47826);
                        return 0;
                    }


                    bool
                    f_10474_48159_48182()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 48159, 48182);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10474_48241_48271(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.HiddenSequencePoint();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 48241, 48271);
                        return return_v;
                    }


                    int
                    f_10474_48217_48272(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 48217, 48272);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_48321_48340(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 48321, 48340);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_48576_48595(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 48576, 48595);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10474_48560_48596(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    dag)
                    {
                        var return_v = this_param.GetDagNodeLabel(dag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 48560, 48596);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10474_48546_48597(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Goto(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 48546, 48597);
                        return return_v;
                    }


                    int
                    f_10474_48522_48598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 48522, 48598);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10474_48849_48862(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Test;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 48849, 48862);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_48913_48930(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 48913, 48930);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10474_48932_48950(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.WhenFalse;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 48932, 48950);
                        return return_v;
                    }


                    int
                    f_10474_48894_48961(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    test, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    whenTrue, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    whenFalse, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    nextNode)
                    {
                        this_param.GenerateTest(test, whenTrue, whenFalse, nextNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 48894, 48961);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10474_49122_49131(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10474, 49122, 49131);
                        return return_v;
                    }


                    System.Exception
                    f_10474_49087_49132(Microsoft.CodeAnalysis.CSharp.BoundKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 49087, 49132);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10474, 47262, 49167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 47262, 49167);
                }
            }

            static DecisionDagRewriter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10474, 718, 49178);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10474, 718, 49178);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10474, 718, 49178);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10474, 718, 49178);

            Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
            f_10474_1682_1747()
            {
                var return_v = PooledDictionary<BoundDecisionDagNode, LabelSymbol>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10474, 1682, 1747);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxNode
            f_10474_1946_1950_C(Microsoft.CodeAnalysis.SyntaxNode
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10474, 1764, 2021);
                return return_v;
            }

        }
    }
}
