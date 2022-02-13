// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class DataFlowsInWalker : AbstractRegionDataFlowPass
    {
        private readonly HashSet<Symbol> _dataFlowsIn;

        private DataFlowsInWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion,
                    HashSet<Symbol> unassignedVariables, HashSet<PrefixUnaryExpressionSyntax> unassignedVariableAddressOfSyntaxes)
        : base(f_10887_1404_1415_C(compilation), member, node, firstInRegion, lastInRegion, unassignedVariables, unassignedVariableAddressOfSyntaxes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10887, 1123, 1539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 1074, 1110);
                this._dataFlowsIn = f_10887_1089_1110(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10887, 1123, 1539);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 1123, 1539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 1123, 1539);
            }
        }

        internal static HashSet<Symbol> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion,
                    HashSet<Symbol> unassignedVariables, HashSet<PrefixUnaryExpressionSyntax> unassignedVariableAddressOfSyntaxes, out bool? succeeded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10887, 1551, 2372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 1871, 2020);

                var
                walker = f_10887_1884_2019(compilation, member, node, firstInRegion, lastInRegion, unassignedVariables, unassignedVariableAddressOfSyntaxes)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2070, 2093);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2111, 2154);

                    var
                    result = f_10887_2124_2153(walker, ref badRegion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2172, 2195);

                    succeeded = !badRegion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2213, 2263);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10887, 2220, 2229) || ((badRegion && DynAbs.Tracing.TraceSender.Conditional_F2(10887, 2232, 2253)) || DynAbs.Tracing.TraceSender.Conditional_F3(10887, 2256, 2262))) ? f_10887_2232_2253() : result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10887, 2292, 2361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2332, 2346);

                    f_10887_2332_2345(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10887, 2292, 2361);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10887, 1551, 2372);

                Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                f_10887_1884_2019(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                unassignedVariables, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                unassignedVariableAddressOfSyntaxes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker(compilation, member, node, firstInRegion, lastInRegion, unassignedVariables, unassignedVariableAddressOfSyntaxes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 1884, 2019);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10887_2124_2153(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2124, 2153);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10887_2232_2253()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2232, 2253);
                    return return_v;
                }


                int
                f_10887_2332_2345(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2332, 2345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 1551, 2372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 1551, 2372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HashSet<Symbol> Analyze(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10887, 2384, 2539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2460, 2494);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Analyze(ref badRegion, null), 10887, 2460, 2493);
                base.Analyze(ref badRegion, null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2460, 2493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2508, 2528);

                return _dataFlowsIn;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10887, 2384, 2539);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 2384, 2539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 2384, 2539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalState ResetState(LocalState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10887, 2551, 2824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2623, 2659);

                bool
                unreachable = f_10887_2642_2658_M(!state.Reachable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2673, 2692);

                state = f_10887_2681_2691(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2706, 2786) || true) && (unreachable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10887, 2706, 2786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2755, 2771);

                    f_10887_2755_2770(state, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10887, 2706, 2786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2800, 2813);

                return state;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10887, 2551, 2824);

                bool
                f_10887_2642_2658_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 2642, 2658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10887_2681_2691(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param)
                {
                    var return_v = this_param.TopState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2681, 2691);
                    return return_v;
                }


                int
                f_10887_2755_2770(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    this_param.Assign(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2755, 2770);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 2551, 2824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 2551, 2824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10887, 2836, 3013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2898, 2934);

                this.State = f_10887_2911_2933(this, this.State);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2948, 2969);

                f_10887_2948_2968(_dataFlowsIn);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 2983, 3002);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EnterRegion(), 10887, 2983, 3001);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10887, 2836, 3013);

                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10887_2911_2933(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    var return_v = this_param.ResetState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2911, 2933);
                    return return_v;
                }


                int
                f_10887_2948_2968(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 2948, 2968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 2836, 3013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 2836, 3013);
            }
        }

        protected override void NoteBranch(
                    PendingBranch pending,
                    BoundNode gotoStmt,
                    BoundStatement targetStmt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10887, 3025, 3564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 3194, 3232);

                f_10887_3194_3231(targetStmt);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 3246, 3490) || true) && (f_10887_3250_3280_M(!gotoStmt.WasCompilerGenerated) && (DynAbs.Tracing.TraceSender.Expression_True(10887, 3250, 3316) && f_10887_3284_3316_M(!targetStmt.WasCompilerGenerated)) && (DynAbs.Tracing.TraceSender.Expression_True(10887, 3250, 3357) && !f_10887_3321_3357(this, f_10887_3336_3356(gotoStmt.Syntax))) && (DynAbs.Tracing.TraceSender.Expression_True(10887, 3250, 3399) && f_10887_3361_3399(this, f_10887_3376_3398(targetStmt.Syntax))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10887, 3246, 3490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 3433, 3475);

                    pending.State = f_10887_3449_3474(this, pending.State);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10887, 3246, 3490);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 3506, 3553);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.NoteBranch(pending, gotoStmt, targetStmt), 10887, 3506, 3552);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10887, 3025, 3564);

                int
                f_10887_3194_3231(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    node.AssertIsLabeledStatement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 3194, 3231);
                    return 0;
                }


                bool
                f_10887_3250_3280_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3250, 3280);
                    return return_v;
                }


                bool
                f_10887_3284_3316_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3284, 3316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10887_3336_3356(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3336, 3356);
                    return return_v;
                }


                bool
                f_10887_3321_3357(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 3321, 3357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10887_3376_3398(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3376, 3398);
                    return return_v;
                }


                bool
                f_10887_3361_3399(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 3361, 3399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10887_3449_3474(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    var return_v = this_param.ResetState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 3449, 3474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 3025, 3564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 3025, 3564);
            }
        }

        public override BoundNode VisitRangeVariable(BoundRangeVariable node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10887, 3576, 3882);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 3670, 3843) || true) && (f_10887_3674_3682() && (DynAbs.Tracing.TraceSender.Expression_True(10887, 3674, 3751) && !f_10887_3687_3751(this, f_10887_3702_3750(f_10887_3702_3736(f_10887_3702_3726(node))[0]))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10887, 3670, 3843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 3785, 3828);

                    f_10887_3785_3827(_dataFlowsIn, f_10887_3802_3826(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10887, 3670, 3843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 3859, 3871);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10887, 3576, 3882);

                bool
                f_10887_3674_3682()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3674, 3682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10887_3702_3726(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3702, 3726);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10887_3702_3736(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3702, 3736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10887_3702_3750(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3702, 3750);
                    return return_v;
                }


                bool
                f_10887_3687_3751(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 3687, 3751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10887_3802_3826(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 3802, 3826);
                    return return_v;
                }


                bool
                f_10887_3785_3827(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 3785, 3827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 3576, 3882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 3576, 3882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ReportUnassigned(Symbol symbol, SyntaxNode node, int slot, bool skipIfUseBeforeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10887, 3894, 4552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 4089, 4455) || true) && (f_10887_4093_4118(this, f_10887_4108_4117(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10887, 4089, 4455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 4354, 4440);

                    f_10887_4354_4439(                // if the field access is reported as unassigned it should mean the original local
                                                      // or parameter flows in, so we should get the symbol associated with the expression
                                    _dataFlowsIn, (DynAbs.Tracing.TraceSender.Conditional_F1(10887, 4371, 4402) || ((f_10887_4371_4382(symbol) == SymbolKind.Field && DynAbs.Tracing.TraceSender.Conditional_F2(10887, 4405, 4429)) || DynAbs.Tracing.TraceSender.Conditional_F3(10887, 4432, 4438))) ? f_10887_4405_4429(this, slot) : symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10887, 4089, 4455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 4471, 4541);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReportUnassigned(symbol, node, slot, skipIfUseBeforeDeclaration), 10887, 4471, 4540);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10887, 3894, 4552);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_10887_4108_4117(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 4108, 4117);
                    return return_v;
                }


                bool
                f_10887_4093_4118(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 4093, 4118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10887_4371_4382(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 4371, 4382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10887_4405_4429(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNonMemberSymbol(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 4405, 4429);
                    return return_v;
                }


                bool
                f_10887_4354_4439(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 4354, 4439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 3894, 4552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 3894, 4552);
            }
        }

        protected override void ReportUnassignedOutParameter(
                    ParameterSymbol parameter,
                    SyntaxNode node,
                    Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10887, 4564, 4987);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 4744, 4899) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(10887, 4748, 4793) && node is ReturnStatementSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10887, 4748, 4822) && f_10887_4797_4822(this, f_10887_4812_4821(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10887, 4744, 4899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 4856, 4884);

                    f_10887_4856_4883(_dataFlowsIn, parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10887, 4744, 4899);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10887, 4915, 4976);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReportUnassignedOutParameter(parameter, node, location), 10887, 4915, 4975);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10887, 4564, 4987);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_10887_4812_4821(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10887, 4812, 4821);
                    return return_v;
                }


                bool
                f_10887_4797_4822(Microsoft.CodeAnalysis.CSharp.DataFlowsInWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 4797, 4822);
                    return return_v;
                }


                bool
                f_10887_4856_4883(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 4856, 4883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10887, 4564, 4987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 4564, 4987);
            }
        }

        static DataFlowsInWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10887, 838, 4994);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10887, 838, 4994);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10887, 838, 4994);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10887, 838, 4994);

        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10887_1089_1110()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10887, 1089, 1110);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10887_1404_1415_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10887, 1123, 1539);
            return return_v;
        }

    }
}
