// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class DataFlowsOutWalker : AbstractRegionDataFlowPass
    {
        private readonly ImmutableArray<ISymbol> _dataFlowsIn;

        private DataFlowsOutWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion, HashSet<Symbol> unassignedVariables, ImmutableArray<ISymbol> dataFlowsIn)
        : base(f_10888_1242_1253_C(compilation), member, node, firstInRegion, lastInRegion, unassignedVariables, trackUnassignments: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10888, 1010, 1407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 2575, 2612);
                this._dataFlowsOut = f_10888_2591_2612(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 2791, 2830);
                this._assignedInside = f_10888_2809_2830(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 1369, 1396);

                _dataFlowsIn = dataFlowsIn;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10888, 1010, 1407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 1010, 1407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 1010, 1407);
            }
        }

        internal static HashSet<Symbol> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion, HashSet<Symbol> unassignedVariables, ImmutableArray<ISymbol> dataFlowsIn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10888, 1419, 2530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 1668, 1794);

                var
                walker = f_10888_1681_1793(compilation, member, node, firstInRegion, lastInRegion, unassignedVariables, dataFlowsIn)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 1844, 1867);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 1885, 1928);

                    var
                    result = f_10888_1898_1927(walker, ref badRegion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 2371, 2421);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10888, 2378, 2387) || ((badRegion && DynAbs.Tracing.TraceSender.Conditional_F2(10888, 2390, 2411)) || DynAbs.Tracing.TraceSender.Conditional_F3(10888, 2414, 2420))) ? f_10888_2390_2411() : result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10888, 2450, 2519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 2490, 2504);

                    f_10888_2490_2503(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10888, 2450, 2519);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10888, 1419, 2530);

                Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                f_10888_1681_1793(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                unassignedVariables, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                dataFlowsIn)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker(compilation, member, node, firstInRegion, lastInRegion, unassignedVariables, dataFlowsIn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 1681, 1793);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10888_1898_1927(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 1898, 1927);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10888_2390_2411()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 2390, 2411);
                    return return_v;
                }


                int
                f_10888_2490_2503(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 2490, 2503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 1419, 2530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 1419, 2530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly HashSet<Symbol> _dataFlowsOut;

        private readonly HashSet<Symbol> _assignedInside;

        private HashSet<Symbol> Analyze(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 2851, 3007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 2927, 2961);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Analyze(ref badRegion, null), 10888, 2927, 2960);
                base.Analyze(ref badRegion, null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 2927, 2960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 2975, 2996);

                return _dataFlowsOut;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 2851, 3007);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 2851, 3007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 2851, 3007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<PendingBranch> Scan(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 3019, 3196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3117, 3139);

                f_10888_3117_3138(_dataFlowsOut);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3153, 3185);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Scan(ref badRegion), 10888, 3160, 3184);
                var temp = base.Scan(ref badRegion);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 3160, 3184);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 3019, 3196);

                int
                f_10888_3117_3138(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 3117, 3138);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 3019, 3196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 3019, 3196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 3208, 3958);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3554, 3912);
                    foreach (ISymbol variable in f_10888_3583_3595_I(_dataFlowsIn))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 3554, 3912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3629, 3674);

                        Symbol
                        variableSymbol = f_10888_3653_3673(variable)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3692, 3740);

                        int
                        slot = f_10888_3703_3739(this, variableSymbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3758, 3897) || true) && (slot > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10888, 3762, 3802) && !f_10888_3775_3802(this.State, slot)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 3758, 3897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3844, 3878);

                            f_10888_3844_3877(_dataFlowsOut, variableSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 3758, 3897);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 3554, 3912);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10888, 1, 359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10888, 1, 359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 3928, 3947);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EnterRegion(), 10888, 3928, 3946);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 3208, 3958);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10888_3653_3673(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 3653, 3673);
                    return return_v;
                }


                int
                f_10888_3703_3739(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 3703, 3739);
                    return return_v;
                }


                bool
                f_10888_3775_3802(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 3775, 3802);
                    return return_v;
                }


                bool
                f_10888_3844_3877(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 3844, 3877);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10888_3583_3595_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 3583, 3595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 3208, 3958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 3208, 3958);
            }
        }

        protected override void NoteWrite(Symbol variable, BoundExpression value, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 3970, 4667);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4202, 4602) || true) && (f_10888_4206_4226(this.State) && (DynAbs.Tracing.TraceSender.Expression_True(10888, 4206, 4238) && f_10888_4230_4238()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4202, 4602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4272, 4312);

                    var
                    param = variable as ParameterSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4330, 4435) || true) && (f_10888_4334_4349(this, param))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4330, 4435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4391, 4416);

                        f_10888_4391_4415(_dataFlowsOut, param);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4330, 4435);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4466, 4579) || true) && ((object)param != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4466, 4579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4533, 4560);

                        f_10888_4533_4559(_assignedInside, param);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4466, 4579);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4202, 4602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4618, 4656);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.NoteWrite(variable, value, read), 10888, 4618, 4655);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 3970, 4667);

                bool
                f_10888_4206_4226(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 4206, 4226);
                    return return_v;
                }


                bool
                f_10888_4230_4238()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 4230, 4238);
                    return return_v;
                }


                bool
                f_10888_4334_4349(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                param)
                {
                    var return_v = this_param.FlowsOut(param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 4334, 4349);
                    return return_v;
                }


                bool
                f_10888_4391_4415(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol?)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 4391, 4415);
                    return return_v;
                }


                bool
                f_10888_4533_4559(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 4533, 4559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 3970, 4667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 3970, 4667);
            }
        }

        private Symbol GetNodeSymbol(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 4690, 8071);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4759, 8032) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4759, 8032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4812, 8017);

                        switch (f_10888_4820_4829(node))
                        {

                            case BoundKind.DeclarationPattern:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 4962, 5025);

                                    return f_10888_4969_5009(((BoundDeclarationPattern)node)) as LocalSymbol;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.RecursivePattern:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 5165, 5226);

                                    return f_10888_5172_5210(((BoundRecursivePattern)node)) as LocalSymbol;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.FieldAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 5361, 5402);

                                    var
                                    fieldAccess = (BoundFieldAccess)node
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 5432, 5675) || true) && (f_10888_5436_5504(this, f_10888_5455_5478(fieldAccess), f_10888_5480_5503(fieldAccess)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 5432, 5675);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 5570, 5601);

                                        node = f_10888_5577_5600(fieldAccess);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 5635, 5644);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 5432, 5675);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 5707, 5719);

                                    return null;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.LocalDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 5859, 5908);

                                    return f_10888_5866_5907(((BoundLocalDeclaration)node));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.ThisReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 6045, 6072);

                                    return f_10888_6052_6071();
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.Local:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 6201, 6239);

                                    return f_10888_6208_6238(((BoundLocal)node));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 6372, 6418);

                                    return f_10888_6379_6417(((BoundParameter)node));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.CatchBlock:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 6552, 6612);

                                    var
                                    local = ((BoundCatchBlock)node).Locals.FirstOrDefault()
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 6642, 6725);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10888, 6649, 6709) || ((f_10888_6649_6671_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(local, 10888, 6649, 6671)?.DeclarationKind) == LocalDeclarationKind.CatchVariable && DynAbs.Tracing.TraceSender.Conditional_F2(10888, 6712, 6717)) || DynAbs.Tracing.TraceSender.Conditional_F3(10888, 6720, 6724))) ? local : null;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.RangeVariable:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 6862, 6916);

                                    return f_10888_6869_6915(((BoundRangeVariable)node));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.EventAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7051, 7092);

                                    var
                                    eventAccess = (BoundEventAccess)node
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7122, 7192);

                                    FieldSymbol
                                    associatedField = f_10888_7152_7191(f_10888_7152_7175(eventAccess))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7222, 7605) || true) && ((object)associatedField != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 7222, 7605);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7323, 7574) || true) && (f_10888_7327_7387(this, f_10888_7346_7369(eventAccess), associatedField))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 7323, 7574);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7461, 7492);

                                            node = f_10888_7468_7491(eventAccess);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7530, 7539);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 7323, 7574);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 7222, 7605);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7635, 7647);

                                    return null;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            case BoundKind.LocalFunctionStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7793, 7843);

                                    return f_10888_7800_7842(((BoundLocalFunctionStatement)node));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 4812, 8017);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 7959, 7971);

                                    return null;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4812, 8017);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 4759, 8032);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10888, 4759, 8032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10888, 4759, 8032);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8048, 8060);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 4690, 8071);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10888_4820_4829(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 4820, 4829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10888_4969_5009(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 4969, 5009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10888_5172_5210(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 5172, 5210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10888_5455_5478(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 5455, 5478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10888_5480_5503(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 5480, 5503);
                    return return_v;
                }


                bool
                f_10888_5436_5504(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 5436, 5504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10888_5577_5600(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 5577, 5600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10888_5866_5907(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 5866, 5907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10888_6052_6071()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 6052, 6071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10888_6208_6238(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 6208, 6238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10888_6379_6417(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 6379, 6417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind?
                f_10888_6649_6671_M(Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 6649, 6671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10888_6869_6915(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 6869, 6915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10888_7152_7175(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 7152, 7175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10888_7152_7191(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 7152, 7191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10888_7346_7369(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 7346, 7369);
                    return return_v;
                }


                bool
                f_10888_7327_7387(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 7327, 7387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10888_7468_7491(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 7468, 7491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10888_7800_7842(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 7800, 7842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 4690, 8071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 4690, 8071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void AssignImpl(BoundNode node, BoundExpression value, bool isRef, bool written, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 8091, 9053);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8226, 8975) || true) && (f_10888_8230_8238())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 8226, 8975);
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8306, 8344);

                        Symbol
                        variable = f_10888_8324_8343(this, node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8366, 8497) || true) && ((object)variable != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 8366, 8497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8444, 8474);

                            f_10888_8444_8473(_assignedInside, variable);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 8366, 8497);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8542, 8558);

                    written = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8705, 8960) || true) && (f_10888_8709_8724(State))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 8705, 8960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8766, 8802);

                        ParameterSymbol
                        param = f_10888_8790_8801(this, node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8824, 8941) || true) && (f_10888_8828_8843(this, param))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 8824, 8941);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8893, 8918);

                            f_10888_8893_8917(_dataFlowsOut, param);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 8824, 8941);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 8705, 8960);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 8226, 8975);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 8991, 9042);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AssignImpl(node, value, isRef, written, read), 10888, 8991, 9041);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 8091, 9053);

                bool
                f_10888_8230_8238()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 8230, 8238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10888_8324_8343(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.GetNodeSymbol(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 8324, 8343);
                    return return_v;
                }


                bool
                f_10888_8444_8473(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 8444, 8473);
                    return return_v;
                }


                bool
                f_10888_8709_8724(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 8709, 8724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10888_8790_8801(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.Param(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 8790, 8801);
                    return return_v;
                }


                bool
                f_10888_8828_8843(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                param)
                {
                    var return_v = this_param.FlowsOut(param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 8828, 8843);
                    return return_v;
                }


                bool
                f_10888_8893_8917(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 8893, 8917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 8091, 9053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 8091, 9053);
            }
        }

        private bool FlowsOut(ParameterSymbol param)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 9065, 9288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 9134, 9277);

                return (object)param != null && (DynAbs.Tracing.TraceSender.Expression_True(10888, 9141, 9195) && f_10888_9166_9179(param) != RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10888, 9141, 9226) && f_10888_9199_9226_M(!param.IsImplicitlyDeclared)) && (DynAbs.Tracing.TraceSender.Expression_True(10888, 9141, 9276) && !f_10888_9231_9276(this, f_10888_9246_9275(f_10888_9246_9261(param)[0])));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 9065, 9288);

                Microsoft.CodeAnalysis.RefKind
                f_10888_9166_9179(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9166, 9179);
                    return return_v;
                }


                bool
                f_10888_9199_9226_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9199, 9226);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10888_9246_9261(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9246, 9261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10888_9246_9275(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9246, 9275);
                    return return_v;
                }


                bool
                f_10888_9231_9276(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 9231, 9276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 9065, 9288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 9065, 9288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSymbol Param(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 9300, 9638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 9370, 9627);

                switch (f_10888_9378_9387(node))
                {

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 9370, 9627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 9447, 9493);

                        return f_10888_9454_9492(((BoundParameter)node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 9370, 9627);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 9370, 9627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 9541, 9573);

                        return f_10888_9548_9572(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 9370, 9627);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 9370, 9627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 9600, 9612);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 9370, 9627);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 9300, 9638);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10888_9378_9387(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9378, 9387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10888_9454_9492(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9454, 9492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10888_9548_9572(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param)
                {
                    var return_v = this_param.MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9548, 9572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 9300, 9638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 9300, 9638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitQueryClause(BoundQueryClause node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 9650, 9786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 9740, 9775);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitQueryClause(node), 10888, 9747, 9774);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 9650, 9786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 9650, 9786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 9650, 9786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ReportUnassigned(Symbol symbol, SyntaxNode node, int slot, bool skipIfUseBeforeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 9798, 10387);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 9938, 10290) || true) && (f_10888_9942_9951_M(!IsInside))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 9938, 10290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 10188, 10275);

                    f_10888_10188_10274(                // If the field access is reported as unassigned it should mean the original local
                                                        // or parameter flows out, so we should get the symbol associated with the expression
                                    _dataFlowsOut, (DynAbs.Tracing.TraceSender.Conditional_F1(10888, 10206, 10237) || ((f_10888_10206_10217(symbol) == SymbolKind.Field && DynAbs.Tracing.TraceSender.Conditional_F2(10888, 10240, 10264)) || DynAbs.Tracing.TraceSender.Conditional_F3(10888, 10267, 10273))) ? f_10888_10240_10264(this, slot) : symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 9938, 10290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 10306, 10376);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReportUnassigned(symbol, node, slot, skipIfUseBeforeDeclaration), 10888, 10306, 10375);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 9798, 10387);

                bool
                f_10888_9942_9951_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 9942, 9951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10888_10206_10217(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10888, 10206, 10217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10888_10240_10264(Microsoft.CodeAnalysis.CSharp.DataFlowsOutWalker
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNonMemberSymbol(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 10240, 10264);
                    return return_v;
                }


                bool
                f_10888_10188_10274(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 10188, 10274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 9798, 10387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 9798, 10387);
            }
        }

        protected override void ReportUnassignedOutParameter(ParameterSymbol parameter, SyntaxNode node, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10888, 10399, 10792);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 10539, 10706) || true) && (!f_10888_10544_10577(_dataFlowsOut, parameter) && (DynAbs.Tracing.TraceSender.Expression_True(10888, 10543, 10628) && (node == null || (DynAbs.Tracing.TraceSender.Expression_False(10888, 10582, 10627) || node is ReturnStatementSyntax))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10888, 10539, 10706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 10662, 10691);

                    f_10888_10662_10690(_dataFlowsOut, parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10888, 10539, 10706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10888, 10720, 10781);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReportUnassignedOutParameter(parameter, node, location), 10888, 10720, 10780);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10888, 10399, 10792);

                bool
                f_10888_10544_10577(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 10544, 10577);
                    return return_v;
                }


                bool
                f_10888_10662_10690(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 10662, 10690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10888, 10399, 10792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 10399, 10792);
            }
        }

        static DataFlowsOutWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10888, 865, 10799);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10888, 865, 10799);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10888, 865, 10799);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10888, 865, 10799);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10888_1242_1253_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10888, 1010, 1407);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10888_2591_2612()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 2591, 2612);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10888_2809_2830()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10888, 2809, 2830);
            return return_v;
        }

    }
}
