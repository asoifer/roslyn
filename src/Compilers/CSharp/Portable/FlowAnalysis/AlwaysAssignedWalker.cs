// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class AlwaysAssignedWalker : AbstractRegionDataFlowPass
    {
        private LocalState _endOfRegionState;

        private readonly HashSet<LabelSymbol> _labelsInside;

        private AlwaysAssignedWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        : base(f_10883_1215_1226_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10883, 1055, 1292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 934, 951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 1000, 1042);
                this._labelsInside = f_10883_1016_1042(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10883, 1055, 1292);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 1055, 1292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 1055, 1292);
            }
        }

        internal static IEnumerable<Symbol> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10883, 1304, 1911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 1483, 1577);

                var
                walker = f_10883_1496_1576(compilation, member, node, firstInRegion, lastInRegion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 1591, 1614);

                bool
                badRegion = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 1664, 1707);

                    var
                    result = f_10883_1677_1706(walker, ref badRegion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 1725, 1802);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10883, 1732, 1741) || ((badRegion && DynAbs.Tracing.TraceSender.Conditional_F2(10883, 1744, 1792)) || DynAbs.Tracing.TraceSender.Conditional_F3(10883, 1795, 1801))) ? f_10883_1744_1792() : result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10883, 1831, 1900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 1871, 1885);

                    f_10883_1871_1884(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10883, 1831, 1900);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10883, 1304, 1911);

                Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                f_10883_1496_1576(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker(compilation, member, node, firstInRegion, lastInRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 1496, 1576);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10883_1677_1706(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 1677, 1706);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10883_1744_1792()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 1744, 1792);
                    return return_v;
                }


                int
                f_10883_1871_1884(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 1871, 1884);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 1304, 1911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 1304, 1911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<Symbol> Analyze(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 1923, 2698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 1996, 2030);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Analyze(ref badRegion, null), 10883, 1996, 2029);
                base.Analyze(ref badRegion, null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 1996, 2029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2044, 2085);

                List<Symbol>
                result = f_10883_2066_2084()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2099, 2123);

                f_10883_2099_2122(f_10883_2112_2121_M(!IsInside));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2137, 2657) || true) && (f_10883_2141_2168(_endOfRegionState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 2137, 2657);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2202, 2642);
                        foreach (var i in f_10883_2220_2257_I(_endOfRegionState.Assigned.TrueBits()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 2202, 2642);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2299, 2410) || true) && (i >= f_10883_2308_2328(variableBySlot))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 2299, 2410);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2378, 2387);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 2299, 2410);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2434, 2465);

                            var
                            v = f_10883_2442_2464(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.variableBySlot, 10883, 2442, 2461), i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2487, 2623) || true) && (v.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10883, 2491, 2529) && !(v.Symbol is FieldSymbol)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 2487, 2623);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2579, 2600);

                                f_10883_2579_2599(result, v.Symbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 2487, 2623);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 2202, 2642);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10883, 1, 441);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10883, 1, 441);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 2137, 2657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2673, 2687);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 1923, 2698);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10883_2066_2084()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 2066, 2084);
                    return return_v;
                }


                bool
                f_10883_2112_2121_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 2112, 2121);
                    return return_v;
                }


                int
                f_10883_2099_2122(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 2099, 2122);
                    return 0;
                }


                bool
                f_10883_2141_2168(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 2141, 2168);
                    return return_v;
                }


                int
                f_10883_2308_2328(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 2308, 2328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10883_2442_2464(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 2442, 2464);
                    return return_v;
                }


                int
                f_10883_2579_2599(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 2579, 2599);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<int>
                f_10883_2220_2257_I(System.Collections.Generic.IEnumerable<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 2220, 2257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 1923, 2698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 1923, 2698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void WriteArgument(BoundExpression arg, RefKind refKind, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 2710, 2998);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2887, 2987) || true) && (refKind == RefKind.Out)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 2887, 2987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 2947, 2972);

                    f_10883_2947_2971(this, arg, value: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 2887, 2987);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 2710, 2998);

                int
                f_10883_2947_2971(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 2947, 2971);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 2710, 2998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 2710, 2998);
            }
        }

        protected override void ResolveBranch(PendingBranch pending, LabelSymbol label, BoundStatement target, ref bool labelStateChanged)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 3010, 3533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 3232, 3440) || true) && (f_10883_3236_3244() && (DynAbs.Tracing.TraceSender.Expression_True(10883, 3236, 3270) && pending.Branch != null) && (DynAbs.Tracing.TraceSender.Expression_True(10883, 3236, 3317) && !f_10883_3275_3317(this, f_10883_3290_3316(pending.Branch.Syntax))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 3232, 3440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 3351, 3425);

                    pending.State = (DynAbs.Tracing.TraceSender.Conditional_F1(10883, 3367, 3390) || ((f_10883_3367_3390(pending.State) && DynAbs.Tracing.TraceSender.Conditional_F2(10883, 3393, 3403)) || DynAbs.Tracing.TraceSender.Conditional_F3(10883, 3406, 3424))) ? f_10883_3393_3403(this) : f_10883_3406_3424(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 3232, 3440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 3456, 3522);

                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ResolveBranch(pending, label, target, ref labelStateChanged), 10883, 3456, 3521);
                base.ResolveBranch(pending, label, target, ref labelStateChanged);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 3456, 3521);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 3010, 3533);

                bool
                f_10883_3236_3244()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 3236, 3244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10883_3290_3316(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 3290, 3316);
                    return return_v;
                }


                bool
                f_10883_3275_3317(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 3275, 3317);
                    return return_v;
                }


                bool
                f_10883_3367_3390(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 3367, 3390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10883_3393_3403(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param)
                {
                    var return_v = this_param.TopState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 3393, 3403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10883_3406_3424(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 3406, 3424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 3010, 3533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 3010, 3533);
            }
        }

        public override BoundNode VisitLabel(BoundLabel node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 3545, 3708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 3623, 3654);

                f_10883_3623_3653(this, node, f_10883_3642_3652(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 3668, 3697);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabel(node), 10883, 3675, 3696);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 3545, 3708);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10883_3642_3652(Microsoft.CodeAnalysis.CSharp.BoundLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 3642, 3652);
                    return return_v;
                }


                int
                f_10883_3623_3653(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabel
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.ResolveLabel((Microsoft.CodeAnalysis.CSharp.BoundNode)node, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 3623, 3653);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 3545, 3708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 3545, 3708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLabeledStatement(BoundLabeledStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 3720, 3916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 3820, 3851);

                f_10883_3820_3850(this, node, f_10883_3839_3849(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 3865, 3905);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabeledStatement(node), 10883, 3872, 3904);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 3720, 3916);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10883_3839_3849(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 3839, 3849);
                    return return_v;
                }


                int
                f_10883_3820_3850(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.ResolveLabel((Microsoft.CodeAnalysis.CSharp.BoundNode)node, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 3820, 3850);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 3720, 3916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 3720, 3916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ResolveLabel(BoundNode node, LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 3928, 4110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4013, 4099) || true) && (node.Syntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10883, 4017, 4072) && f_10883_4040_4072(this, f_10883_4055_4071(node.Syntax))))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 4013, 4099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4074, 4099);

                    f_10883_4074_4098(_labelsInside, label);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 4013, 4099);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 3928, 4110);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_10883_4055_4071(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 4055, 4071);
                    return return_v;
                }


                bool
                f_10883_4040_4072(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4040, 4072);
                    return return_v;
                }


                bool
                f_10883_4074_4098(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4074, 4098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 3928, 4110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 3928, 4110);
            }
        }

        protected override void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 4122, 4252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4184, 4208);

                this.State = f_10883_4197_4207(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4222, 4241);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EnterRegion(), 10883, 4222, 4240);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 4122, 4252);

                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10883_4197_4207(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param)
                {
                    var return_v = this_param.TopState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4197, 4207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 4122, 4252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 4122, 4252);
            }
        }

        protected override void LeaveRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10883, 4264, 5154);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4326, 4782) || true) && (this.IsConditionalState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 4326, 4782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4554, 4596);

                    _endOfRegionState = f_10883_4574_4595(StateWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4614, 4662);

                    f_10883_4614_4661(this, ref _endOfRegionState, ref StateWhenFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 4326, 4782);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 4326, 4782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4728, 4767);

                    _endOfRegionState = f_10883_4748_4766(this.State);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 4326, 4782);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4798, 5108);
                    foreach (var branch in f_10883_4821_4841_I(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.PendingBranches, 10883, 4821, 4841)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 4798, 5108);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 4875, 5093) || true) && (branch.Branch != null && (DynAbs.Tracing.TraceSender.Expression_True(10883, 4879, 4945) && f_10883_4904_4945(this, f_10883_4919_4944(branch.Branch.Syntax))) && (DynAbs.Tracing.TraceSender.Expression_True(10883, 4879, 4986) && !f_10883_4950_4986(_labelsInside, branch.Label)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10883, 4875, 5093);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 5028, 5074);

                            f_10883_5028_5073(this, ref _endOfRegionState, ref branch.State);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 4875, 5093);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10883, 4798, 5108);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10883, 1, 311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10883, 1, 311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10883, 5124, 5143);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LeaveRegion(), 10883, 5124, 5142);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10883, 4264, 5154);

                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10883_4574_4595(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4574, 4595);
                    return return_v;
                }


                bool
                f_10883_4614_4661(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4614, 4661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10883_4748_4766(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4748, 4766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10883_4919_4944(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10883, 4919, 4944);
                    return return_v;
                }


                bool
                f_10883_4904_4945(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4904, 4945);
                    return return_v;
                }


                bool
                f_10883_4950_4986(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4950, 4986);
                    return return_v;
                }


                bool
                f_10883_5028_5073(Microsoft.CodeAnalysis.CSharp.AlwaysAssignedWalker
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 5028, 5073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                f_10883_4821_4841_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 4821, 4841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10883, 4264, 5154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 4264, 5154);
            }
        }

        static AlwaysAssignedWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10883, 834, 5161);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10883, 834, 5161);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10883, 834, 5161);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10883, 834, 5161);

        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
        f_10883_1016_1042()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10883, 1016, 1042);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10883_1215_1226_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10883, 1055, 1292);
            return return_v;
        }

    }
}
