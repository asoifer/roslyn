// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundDecisionDag
    {
        private ImmutableHashSet<LabelSymbol> _reachableLabels;

        private ImmutableArray<BoundDecisionDagNode> _topologicallySortedNodes;

        internal static ImmutableArray<BoundDecisionDagNode> Successors(BoundDecisionDagNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10551, 733, 1551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 848, 1540);

                switch (node)
                {

                    case BoundEvaluationDecisionDagNode p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 848, 1540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 954, 991);

                        return f_10551_961_990(f_10551_983_989(p));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 848, 1540);

                    case BoundTestDecisionDagNode p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 848, 1540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1063, 1117);

                        return f_10551_1070_1116(f_10551_1092_1103(p), f_10551_1105_1115(p));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 848, 1540);

                    case BoundLeafDecisionDagNode d:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 848, 1540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1189, 1239);

                        return ImmutableArray<BoundDecisionDagNode>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 848, 1540);

                    case BoundWhenDecisionDagNode w:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 848, 1540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1311, 1425);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10551, 1318, 1339) || (((f_10551_1319_1330(w) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10551, 1342, 1388)) || DynAbs.Tracing.TraceSender.Conditional_F3(10551, 1391, 1424))) ? f_10551_1342_1388(f_10551_1364_1374(w), f_10551_1376_1387(w)) : f_10551_1391_1424(f_10551_1413_1423(w));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 848, 1540);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 848, 1540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1473, 1525);

                        throw f_10551_1479_1524(f_10551_1514_1523(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 848, 1540);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10551, 733, 1551);

                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_983_989(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 983, 989);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_961_990(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 961, 990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_1092_1103(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1092, 1103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_1105_1115(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1105, 1115);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_1070_1116(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                item1, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 1070, 1116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10551_1319_1330(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1319, 1330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_1364_1374(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1364, 1374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_1376_1387(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1376, 1387);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_1342_1388(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                item1, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 1342, 1388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_1413_1423(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1413, 1423);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_1391_1424(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 1391, 1424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10551_1514_1523(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1514, 1523);
                    return return_v;
                }


                System.Exception
                f_10551_1479_1524(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 1479, 1524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 733, 1551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 733, 1551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableHashSet<LabelSymbol> ReachableLabels
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 1640, 2297);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1676, 2238) || true) && (_reachableLabels == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 1676, 2238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1746, 1854);

                        var
                        result = f_10551_1759_1853(Symbols.SymbolEqualityComparer.ConsiderEverything)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1876, 2148);
                            foreach (var node in f_10551_1897_1926_I(f_10551_1897_1926(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 1876, 2148);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 1976, 2125) || true) && (node is BoundLeafDecisionDagNode leaf)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 1976, 2125);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 2075, 2098);

                                    f_10551_2075_2097(result, f_10551_2086_2096(leaf));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 1976, 2125);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 1876, 2148);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10551, 1, 273);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10551, 1, 273);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 2172, 2219);

                        _reachableLabels = f_10551_2191_2218(result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 1676, 2238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 2258, 2282);

                    return _reachableLabels;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 1640, 2297);

                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>.Builder
                    f_10551_1759_1853(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                    equalityComparer)
                    {
                        var return_v = ImmutableHashSet.CreateBuilder<LabelSymbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>)equalityComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 1759, 1853);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10551_1897_1926(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    this_param)
                    {
                        var return_v = this_param.TopologicallySortedNodes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 1897, 1926);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10551_2086_2096(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 2086, 2096);
                        return return_v;
                    }


                    bool
                    f_10551_2075_2097(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>.Builder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 2075, 2097);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10551_1897_1926_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 1897, 1926);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10551_2191_2218(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>.Builder
                    builder)
                    {
                        var return_v = builder.ToImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 2191, 2218);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 1563, 2308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 1563, 2308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<BoundDecisionDagNode> TopologicallySortedNodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 2560, 3227);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 2596, 3159) || true) && (_topologicallySortedNodes.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 2596, 3159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 2818, 2959);

                        bool
                        wasAcyclic = f_10551_2836_2958(new[] { f_10551_2899_2912(this) }, Successors, out _topologicallySortedNodes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 3115, 3140);

                        f_10551_3115_3139(wasAcyclic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 2596, 3159);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 3179, 3212);

                    return _topologicallySortedNodes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 2560, 3227);

                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                    f_10551_2899_2912(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    this_param)
                    {
                        var return_v = this_param.RootNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 2899, 2912);
                        return return_v;
                    }


                    bool
                    f_10551_2836_2958(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode[]
                    nodes, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>>
                    successors, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    result)
                    {
                        var return_v = TopologicalSort.TryIterativeSort<BoundDecisionDagNode>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>)nodes, successors, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 2836, 2958);
                        return return_v;
                    }


                    int
                    f_10551_3115_3139(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 3115, 3139);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 2467, 3238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 2467, 3238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public BoundDecisionDag Rewrite(Func<BoundDecisionDagNode, Func<BoundDecisionDagNode, BoundDecisionDagNode>, BoundDecisionDagNode> makeReplacement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 3565, 5253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4024, 4105);

                ImmutableArray<BoundDecisionDagNode>
                sortedNodes = f_10551_4075_4104(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4345, 4438);

                var
                replacement = f_10551_4363_4437()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4454, 4548);

                Func<BoundDecisionDagNode, BoundDecisionDagNode>
                getReplacementForChild = n => replacement[n]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4714, 4740);

                    // Loop backwards through the topologically sorted nodes to translate them, so that we always visit a node after its successors
                    for (int
        i = sortedNodes.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4705, 5052) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4750, 4753)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 4705, 5052))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 4705, 5052);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4787, 4830);

                        BoundDecisionDagNode
                        node = sortedNodes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4848, 4893);

                        f_10551_4848_4892(!f_10551_4862_4891(replacement, node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 4911, 4988);

                        BoundDecisionDagNode
                        newNode = f_10551_4942_4987(makeReplacement, node, getReplacementForChild)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 5006, 5037);

                        f_10551_5006_5036(replacement, node, newNode);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10551, 1, 348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10551, 1, 348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 5126, 5167);

                var
                newRoot = f_10551_5140_5166(replacement, f_10551_5152_5165(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 5181, 5200);

                f_10551_5181_5199(replacement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 5214, 5242);

                return f_10551_5221_5241(this, newRoot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 3565, 5253);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_4075_4104(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.TopologicallySortedNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 4075, 4104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_4363_4437()
                {
                    var return_v = PooledDictionary<BoundDecisionDagNode, BoundDecisionDagNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 4363, 4437);
                    return return_v;
                }


                bool
                f_10551_4862_4891(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 4862, 4891);
                    return return_v;
                }


                int
                f_10551_4848_4892(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 4848, 4892);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_4942_4987(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                arg1, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 4942, 4987);
                    return return_v;
                }


                int
                f_10551_5006_5036(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                key, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5006, 5036);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5152_5165(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.RootNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 5152, 5165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5140_5166(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 5140, 5166);
                    return return_v;
                }


                int
                f_10551_5181_5199(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5181, 5199);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10551_5221_5241(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                rootNode)
                {
                    var return_v = this_param.Update(rootNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5221, 5241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 3565, 5253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 3565, 5253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundDecisionDagNode TrivialReplacement(BoundDecisionDagNode dag, Func<BoundDecisionDagNode, BoundDecisionDagNode> replacement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10551, 5497, 6367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 5663, 6356);

                switch (dag)
                {

                    case BoundEvaluationDecisionDagNode p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 5663, 6356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 5768, 5819);

                        return f_10551_5775_5818(p, f_10551_5784_5796(p), f_10551_5798_5817(replacement, f_10551_5810_5816(p)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 5663, 6356);

                    case BoundTestDecisionDagNode p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 5663, 6356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 5891, 5966);

                        return f_10551_5898_5965(p, f_10551_5907_5913(p), f_10551_5915_5938(replacement, f_10551_5927_5937(p)), f_10551_5940_5964(replacement, f_10551_5952_5963(p)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 5663, 6356);

                    case BoundWhenDecisionDagNode p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 5663, 6356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 6038, 6166);

                        return f_10551_6045_6165(p, f_10551_6054_6064(p), f_10551_6066_6082(p), f_10551_6084_6107(replacement, f_10551_6096_6106(p)), (DynAbs.Tracing.TraceSender.Conditional_F1(10551, 6109, 6130) || (((f_10551_6110_6121(p) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10551, 6133, 6157)) || DynAbs.Tracing.TraceSender.Conditional_F3(10551, 6160, 6164))) ? f_10551_6133_6157(replacement, f_10551_6145_6156(p)) : null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 5663, 6356);

                    case BoundLeafDecisionDagNode p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 5663, 6356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 6238, 6247);

                        return p;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 5663, 6356);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 5663, 6356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 6295, 6341);

                        throw f_10551_6301_6340(dag);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 5663, 6356);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10551, 5497, 6367);

                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10551_5784_5796(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Evaluation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 5784, 5796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5810_5816(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 5810, 5816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5798_5817(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5798, 5817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                f_10551_5775_5818(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                evaluation, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                next)
                {
                    var return_v = this_param.Update(evaluation, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5775, 5818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTest
                f_10551_5907_5913(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 5907, 5913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5927_5937(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 5927, 5937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5915_5938(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5915, 5938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5952_5963(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 5952, 5963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_5940_5964(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5940, 5964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                f_10551_5898_5965(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                test, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                whenTrue, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                whenFalse)
                {
                    var return_v = this_param.Update(test, whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 5898, 5965);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                f_10551_6054_6064(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Bindings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 6054, 6064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10551_6066_6082(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 6066, 6082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_6096_6106(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 6096, 6106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_6084_6107(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 6084, 6107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10551_6110_6121(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 6110, 6121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_6145_6156(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 6145, 6156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_6133_6157(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 6133, 6157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                f_10551_6045_6165(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenExpression, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                whenTrue, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                whenFalse)
                {
                    var return_v = this_param.Update(bindings, whenExpression, whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 6045, 6165);
                    return return_v;
                }


                System.Exception
                f_10551_6301_6340(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 6301, 6340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 5497, 6367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 5497, 6367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundDecisionDag SimplifyDecisionDagIfConstantInput(BoundExpression input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 6757, 9605);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 6863, 9594) || true) && (f_10551_6867_6886(input) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 6863, 9594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 6928, 6940);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 6863, 9594);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 6863, 9594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 7006, 7056);

                    ConstantValue
                    inputConstant = f_10551_7036_7055(input)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 7074, 7106);

                    return f_10551_7081_7105(this, makeReplacement);

                    BoundDecisionDagNode makeReplacement(BoundDecisionDagNode dag, Func<BoundDecisionDagNode, BoundDecisionDagNode> replacement)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 7238, 8031);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 7403, 7944) || true) && (dag is BoundTestDecisionDagNode p)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 7403, 7944);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 7627, 7921);

                                switch (f_10551_7635_7654(f_10551_7647_7653(p)))
                                {

                                    case true:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 7627, 7921);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 7756, 7787);

                                        return f_10551_7763_7786(replacement, f_10551_7775_7785(p));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 7627, 7921);

                                    case false:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 7627, 7921);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 7862, 7894);

                                        return f_10551_7869_7893(replacement, f_10551_7881_7892(p));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 7627, 7921);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 7403, 7944);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 7968, 8012);

                            return f_10551_7975_8011(dag, replacement);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 7238, 8031);

                            Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            f_10551_7647_7653(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Test;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 7647, 7653);
                                return return_v;
                            }


                            bool?
                            f_10551_7635_7654(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            choice)
                            {
                                var return_v = knownResult(choice);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 7635, 7654);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10551_7775_7785(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.WhenTrue;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 7775, 7785);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10551_7763_7786(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            arg)
                            {
                                var return_v = this_param.Invoke(arg);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 7763, 7786);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10551_7881_7892(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.WhenFalse;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 7881, 7892);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10551_7869_7893(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            arg)
                            {
                                var return_v = this_param.Invoke(arg);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 7869, 7893);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10551_7975_8011(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            dag, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                            replacement)
                            {
                                var return_v = TrivialReplacement(dag, replacement);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 7975, 8011);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 7238, 8031);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 7238, 8031);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    bool? knownResult(BoundDagTest choice)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 8135, 9579);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 8214, 8430) || true) && (f_10551_8218_8247_M(!f_10551_8219_8231(choice).IsOriginalInput))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 8214, 8430);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 8395, 8407);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 8214, 8430);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 8454, 9560);

                            switch (choice)
                            {

                                case BoundDagExplicitNullTest d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 8454, 9560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 8580, 8608);

                                    return f_10551_8587_8607(inputConstant);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 8454, 9560);

                                case BoundDagNonNullTest d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 8454, 9560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 8691, 8720);

                                    return f_10551_8698_8719_M(!inputConstant.IsNull);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 8454, 9560);

                                case BoundDagValueTest d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 8454, 9560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 8801, 8833);

                                    return f_10551_8808_8815(d) == inputConstant;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 8454, 9560);

                                case BoundDagTypeTest d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 8454, 9560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 8913, 8963);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10551, 8920, 8940) || ((f_10551_8920_8940(inputConstant) && DynAbs.Tracing.TraceSender.Conditional_F2(10551, 8943, 8955)) || DynAbs.Tracing.TraceSender.Conditional_F3(10551, 8958, 8962))) ? (bool?)false : null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 8454, 9560);

                                case BoundDagRelationalTest d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 8454, 9560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9049, 9093);

                                    var
                                    f = f_10551_9057_9092(f_10551_9081_9091(input))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9123, 9150) || true) && (f is null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 9123, 9150);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9138, 9150);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 9123, 9150);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9286, 9338);

                                    var
                                    set = f_10551_9296_9337(f, f_10551_9306_9327(f_10551_9306_9316(d)), f_10551_9329_9336(d))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9368, 9424);

                                    return f_10551_9375_9423(set, BinaryOperatorKind.Equal, inputConstant);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 8454, 9560);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 8454, 9560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9488, 9537);

                                    throw f_10551_9494_9536(choice);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 8454, 9560);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 8135, 9579);

                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10551_8219_8231(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 8219, 8231);
                                return return_v;
                            }


                            bool
                            f_10551_8218_8247_M(bool
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 8218, 8247);
                                return return_v;
                            }


                            bool
                            f_10551_8587_8607(Microsoft.CodeAnalysis.ConstantValue
                            this_param)
                            {
                                var return_v = this_param.IsNull;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 8587, 8607);
                                return return_v;
                            }


                            bool
                            f_10551_8698_8719_M(bool
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 8698, 8719);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ConstantValue
                            f_10551_8808_8815(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                            this_param)
                            {
                                var return_v = this_param.Value;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 8808, 8815);
                                return return_v;
                            }


                            bool
                            f_10551_8920_8940(Microsoft.CodeAnalysis.ConstantValue
                            this_param)
                            {
                                var return_v = this_param.IsNull;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 8920, 8940);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                            f_10551_9081_9091(Microsoft.CodeAnalysis.CSharp.BoundExpression
                            this_param)
                            {
                                var return_v = this_param.Type;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 9081, 9091);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.IValueSetFactory?
                            f_10551_9057_9092(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                            type)
                            {
                                var return_v = ValueSetFactory.ForType(type);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 9057, 9092);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            f_10551_9306_9316(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                            this_param)
                            {
                                var return_v = this_param.Relation;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 9306, 9316);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            f_10551_9306_9327(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            kind)
                            {
                                var return_v = kind.Operator();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 9306, 9327);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ConstantValue
                            f_10551_9329_9336(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                            this_param)
                            {
                                var return_v = this_param.Value;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 9329, 9336);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.IValueSet
                            f_10551_9296_9337(Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                            this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            relation, Microsoft.CodeAnalysis.ConstantValue
                            value)
                            {
                                var return_v = this_param.Related(relation, value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 9296, 9337);
                                return return_v;
                            }


                            bool
                            f_10551_9375_9423(Microsoft.CodeAnalysis.CSharp.IValueSet
                            this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            relation, Microsoft.CodeAnalysis.ConstantValue
                            value)
                            {
                                var return_v = this_param.Any(relation, value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 9375, 9423);
                                return return_v;
                            }


                            System.Exception
                            f_10551_9494_9536(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            o)
                            {
                                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 9494, 9536);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 8135, 9579);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 8135, 9579);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 6863, 9594);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 6757, 9605);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10551_6867_6886(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 6867, 6886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10551_7036_7055(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 7036, 7055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10551_7081_7105(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                makeReplacement)
                {
                    var return_v = this_param.Rewrite(makeReplacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 7081, 7105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 6757, 9605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 6757, 9605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal new string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 9864, 14447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9915, 9961);

                var
                allStates = f_10551_9931_9960(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 9975, 10058);

                var
                stateIdentifierMap = f_10551_10000_10057()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10081, 10086);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10072, 10202) || true) && (i < allStates.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10110, 10113)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 10072, 10202))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 10072, 10202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10147, 10187);

                        f_10551_10147_10186(stateIdentifierMap, allStates[i], i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10551, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10551, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10218, 10241);

                int
                nextTempNumber = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10255, 10335);

                var
                tempIdentifierMap = f_10551_10279_10334()
                ;

                int tempIdentifier(BoundDagEvaluation e)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 10349, 10560);
                        int value = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10422, 10545);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10551, 10429, 10440) || (((e == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10551, 10443, 10444)) || DynAbs.Tracing.TraceSender.Conditional_F3(10551, 10447, 10544))) ? 0 : (DynAbs.Tracing.TraceSender.Conditional_F1(10551, 10447, 10494) || ((f_10551_10447_10494(tempIdentifierMap, e, out value) && DynAbs.Tracing.TraceSender.Conditional_F2(10551, 10497, 10502)) || DynAbs.Tracing.TraceSender.Conditional_F3(10551, 10505, 10544))) ? value : tempIdentifierMap[e] = ++nextTempNumber;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 10349, 10560);

                        bool
                        f_10551_10447_10494(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation, int>?
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        key, out int
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10447, 10494);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 10349, 10560);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 10349, 10560);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string tempName(BoundDagTemp t)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 10576, 10741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10640, 10726);

                        return $"t{f_10551_10651_10675(f_10551_10666_10674(t))}{((DynAbs.Tracing.TraceSender.Conditional_F1(10551, 10678, 10690) || ((f_10551_10678_10685(t) != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10551, 10693, 10717)) || DynAbs.Tracing.TraceSender.Conditional_F3(10551, 10720, 10722))) ? $".{f_10551_10697_10715(f_10551_10697_10704(t))}" : "")}";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 10576, 10741);

                        Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                        f_10551_10666_10674(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 10666, 10674);
                            return return_v;
                        }


                        int
                        f_10551_10651_10675(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                        e)
                        {
                            var return_v = tempIdentifier(e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10651, 10675);
                            return return_v;
                        }


                        int
                        f_10551_10678_10685(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Index;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 10678, 10685);
                            return return_v;
                        }


                        int
                        f_10551_10697_10704(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Index;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 10697, 10704);
                            return return_v;
                        }


                        string
                        f_10551_10697_10715(int
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10697, 10715);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 10576, 10741);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 10576, 10741);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10757, 10811);

                var
                resultBuilder = f_10551_10777_10810()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10825, 10860);

                var
                result = resultBuilder.Builder
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10876, 12926);
                    foreach (var state in f_10551_10898_10907_I(allStates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 10876, 12926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 10941, 10998);

                        f_10551_10941_10997(result, $"State " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_10551_10971_10996(stateIdentifierMap, state)).ToString(), 10551, 10971, 10996));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11016, 12911);

                        switch (state)
                        {

                            case BoundTestDecisionDagNode node:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11016, 12911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11132, 11187);

                                f_10551_11132_11186(result, $"  Test: {f_10551_11161_11183(f_10551_11173_11182(node))}");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11213, 11393) || true) && (f_10551_11217_11230(node) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11213, 11393);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11296, 11366);

                                    f_10551_11296_11365(result, $"  WhenTrue: {f_10551_11329_11362(stateIdentifierMap, f_10551_11348_11361(node))}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11213, 11393);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11421, 11604) || true) && (f_10551_11425_11439(node) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11421, 11604);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11505, 11577);

                                    f_10551_11505_11576(result, $"  WhenFalse: {f_10551_11539_11573(stateIdentifierMap, f_10551_11558_11572(node))}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11421, 11604);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10551, 11630, 11636);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11016, 12911);

                            case BoundEvaluationDecisionDagNode node:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11016, 12911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11725, 11786);

                                f_10551_11725_11785(result, $"  Test: {f_10551_11754_11782(f_10551_11766_11781(node))}");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11812, 11980) || true) && (f_10551_11816_11825(node) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11812, 11980);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 11891, 11953);

                                    f_10551_11891_11952(result, $"  Next: {f_10551_11920_11949(stateIdentifierMap, f_10551_11939_11948(node))}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11812, 11980);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10551, 12006, 12012);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11016, 12911);

                            case BoundWhenDecisionDagNode node:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11016, 12911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12095, 12162);

                                f_10551_12095_12161(result, $"  WhenClause: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10551_12133_12152(node), 10551, 12133, 12160)?.Syntax).ToString(), 10551, 12133, 12160));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12188, 12368) || true) && (f_10551_12192_12205(node) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 12188, 12368);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12271, 12341);

                                    f_10551_12271_12340(result, $"  WhenTrue: {f_10551_12304_12337(stateIdentifierMap, f_10551_12323_12336(node))}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 12188, 12368);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12396, 12579) || true) && (f_10551_12400_12414(node) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 12396, 12579);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12480, 12552);

                                    f_10551_12480_12551(result, $"  WhenFalse: {f_10551_12514_12548(stateIdentifierMap, f_10551_12533_12547(node))}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 12396, 12579);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10551, 12605, 12611);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11016, 12911);

                            case BoundLeafDecisionDagNode node:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11016, 12911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12694, 12756);

                                f_10551_12694_12755(result, $"  Case: {f_10551_12723_12738(f_10551_12723_12733(node))}" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (node.Syntax).ToString(), 10551, 12743, 12754));
                                DynAbs.Tracing.TraceSender.TraceBreak(10551, 12782, 12788);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11016, 12911);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 11016, 12911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12844, 12892);

                                throw f_10551_12850_12891(state);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 11016, 12911);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 10876, 12926);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10551, 1, 2051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10551, 1, 2051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12942, 12968);

                f_10551_12942_12967(
                            stateIdentifierMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 12982, 13007);

                f_10551_12982_13006(tempIdentifierMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13021, 13060);

                return f_10551_13028_13059(resultBuilder);

                string dumpDagTest(BoundDagTest d)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10551, 13076, 14436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13143, 14421);

                        switch (d)
                        {

                            case BoundDagTypeEvaluation a:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 13143, 14421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13250, 13324);

                                return $"t{f_10551_13261_13278(a)}={f_10551_13281_13287(a)}(t{f_10551_13291_13308(a)} as {f_10551_13314_13320(a)})";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 13143, 14421);

                            case BoundDagEvaluation e:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 13143, 14421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13398, 13460);

                                return $"t{f_10551_13409_13426(e)}={f_10551_13429_13435(e)}(t{f_10551_13439_13456(e)})";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 13143, 14421);

                            case BoundDagTypeTest b:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 13143, 14421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13532, 13585);

                                return $"?{f_10551_13543_13549(d)}({f_10551_13552_13569(f_10551_13561_13568(d))} is {f_10551_13575_13581(b)})";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 13143, 14421);

                            case BoundDagValueTest v:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 13143, 14421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13658, 13712);

                                return $"?{f_10551_13669_13675(d)}({f_10551_13678_13695(f_10551_13687_13694(d))} == {f_10551_13701_13708(v)})";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 13143, 14421);

                            case BoundDagRelationalTest r:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 13143, 14421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13790, 14213);

                                var
                                operatorName = f_10551_13809_13830(f_10551_13809_13819(r)) switch
                                {
                                    BinaryOperatorKind.LessThan when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13894, 13928) && DynAbs.Tracing.TraceSender.Expression_True(10551, 13894, 13928))
=> "<",
                                    BinaryOperatorKind.LessThanOrEqual when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 13959, 14001) && DynAbs.Tracing.TraceSender.Expression_True(10551, 13959, 14001))
=> "<=",
                                    BinaryOperatorKind.GreaterThan when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 14032, 14069) && DynAbs.Tracing.TraceSender.Expression_True(10551, 14032, 14069))
=> ">",
                                    BinaryOperatorKind.GreaterThanOrEqual when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 14100, 14145) && DynAbs.Tracing.TraceSender.Expression_True(10551, 14100, 14145))
=> ">=",
                                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 14176, 14185) && DynAbs.Tracing.TraceSender.Expression_True(10551, 14176, 14185))
=> "??"
                                }
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 14239, 14305);

                                return $"?{f_10551_14250_14256(d)}({f_10551_14259_14276(f_10551_14268_14275(d))} {operatorName} {f_10551_14294_14301(r)})";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 13143, 14421);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10551, 13143, 14421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10551, 14361, 14402);

                                return $"?{f_10551_14372_14378(d)}({f_10551_14381_14398(f_10551_14390_14397(d))})";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10551, 13143, 14421);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 13076, 14436);

                        int
                        f_10551_13261_13278(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        e)
                        {
                            var return_v = tempIdentifier((Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13261, 13278);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundKind
                        f_10551_13281_13287(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13281, 13287);
                            return return_v;
                        }


                        int
                        f_10551_13291_13308(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        e)
                        {
                            var return_v = tempIdentifier((Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13291, 13308);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10551_13314_13320(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13314, 13320);
                            return return_v;
                        }


                        int
                        f_10551_13409_13426(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        e)
                        {
                            var return_v = tempIdentifier(e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13409, 13426);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundKind
                        f_10551_13429_13435(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13429, 13435);
                            return return_v;
                        }


                        int
                        f_10551_13439_13456(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        e)
                        {
                            var return_v = tempIdentifier(e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13439, 13456);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundKind
                        f_10551_13543_13549(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13543, 13549);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10551_13561_13568(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13561, 13568);
                            return return_v;
                        }


                        string
                        f_10551_13552_13569(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        t)
                        {
                            var return_v = tempName(t);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13552, 13569);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10551_13575_13581(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13575, 13581);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundKind
                        f_10551_13669_13675(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13669, 13675);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10551_13687_13694(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13687, 13694);
                            return return_v;
                        }


                        string
                        f_10551_13678_13695(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        t)
                        {
                            var return_v = tempName(t);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13678, 13695);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10551_13701_13708(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13701, 13708);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        f_10551_13809_13819(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                        this_param)
                        {
                            var return_v = this_param.Relation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 13809, 13819);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        f_10551_13809_13830(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        kind)
                        {
                            var return_v = kind.Operator();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13809, 13830);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundKind
                        f_10551_14250_14256(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 14250, 14256);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10551_14268_14275(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 14268, 14275);
                            return return_v;
                        }


                        string
                        f_10551_14259_14276(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        t)
                        {
                            var return_v = tempName(t);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 14259, 14276);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10551_14294_14301(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 14294, 14301);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundKind
                        f_10551_14372_14378(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 14372, 14378);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10551_14390_14397(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 14390, 14397);
                            return return_v;
                        }


                        string
                        f_10551_14381_14398(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        t)
                        {
                            var return_v = tempName(t);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 14381, 14398);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 13076, 14436);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 13076, 14436);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10551, 9864, 14447);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_9931_9960(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.TopologicallySortedNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 9931, 9960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                f_10551_10000_10057()
                {
                    var return_v = PooledDictionary<BoundDecisionDagNode, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10000, 10057);
                    return return_v;
                }


                int
                f_10551_10147_10186(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10147, 10186);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation, int>
                f_10551_10279_10334()
                {
                    var return_v = PooledDictionary<BoundDagEvaluation, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10279, 10334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10551_10777_10810()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10777, 10810);
                    return return_v;
                }


                int
                f_10551_10971_10996(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 10971, 10996);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_10941_10997(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10941, 10997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTest
                f_10551_11173_11182(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11173, 11182);
                    return return_v;
                }


                string
                f_10551_11161_11183(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                d)
                {
                    var return_v = dumpDagTest(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 11161, 11183);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_11132_11186(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 11132, 11186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10551_11217_11230(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11217, 11230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_11348_11361(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11348, 11361);
                    return return_v;
                }


                int
                f_10551_11329_11362(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11329, 11362);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_11296_11365(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 11296, 11365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10551_11425_11439(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11425, 11439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_11558_11572(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11558, 11572);
                    return return_v;
                }


                int
                f_10551_11539_11573(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11539, 11573);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_11505_11576(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 11505, 11576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10551_11766_11781(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Evaluation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11766, 11781);
                    return return_v;
                }


                string
                f_10551_11754_11782(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                d)
                {
                    var return_v = dumpDagTest((Microsoft.CodeAnalysis.CSharp.BoundDagTest)d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 11754, 11782);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_11725_11785(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 11725, 11785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10551_11816_11825(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11816, 11825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_11939_11948(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11939, 11948);
                    return return_v;
                }


                int
                f_10551_11920_11949(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 11920, 11949);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_11891_11952(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 11891, 11952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10551_12133_12152(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12133, 12152);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_12095_12161(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 12095, 12161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10551_12192_12205(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12192, 12205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_12323_12336(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12323, 12336);
                    return return_v;
                }


                int
                f_10551_12304_12337(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12304, 12337);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_12271_12340(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 12271, 12340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10551_12400_12414(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12400, 12414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10551_12533_12547(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12533, 12547);
                    return return_v;
                }


                int
                f_10551_12514_12548(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12514, 12548);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_12480_12551(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 12480, 12551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10551_12723_12733(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12723, 12733);
                    return return_v;
                }


                string
                f_10551_12723_12738(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10551, 12723, 12738);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10551_12694_12755(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 12694, 12755);
                    return return_v;
                }


                System.Exception
                f_10551_12850_12891(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 12850, 12891);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10551_10898_10907_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 10898, 10907);
                    return return_v;
                }


                int
                f_10551_12942_12967(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 12942, 12967);
                    return 0;
                }


                int
                f_10551_12982_13006(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation, int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 12982, 13006);
                    return 0;
                }


                string
                f_10551_13028_13059(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10551, 13028, 13059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10551, 9864, 14447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 9864, 14447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundDecisionDag()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10551, 529, 14462);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10551, 529, 14462);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10551, 529, 14462);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10551, 529, 14462);
    }
}
