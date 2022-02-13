// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class AsyncIteratorMethodToStateMachineRewriter : AsyncMethodToStateMachineRewriter
    {
        private readonly AsyncIteratorInfo _asyncIteratorInfo;

        private LabelSymbol _currentDisposalLabel;

        private readonly LabelSymbol _exprReturnLabelTrue;

        private int _nextYieldReturnState;

        internal AsyncIteratorMethodToStateMachineRewriter(MethodSymbol method,
                    int methodOrdinal,
                    AsyncMethodBuilderMemberCollection asyncMethodBuilderMemberCollection,
                    AsyncIteratorInfo asyncIteratorInfo,
                    SyntheticBoundNodeFactory F,
                    FieldSymbol state,
                    FieldSymbol builder,
                    IReadOnlySet<Symbol> hoistedVariables,
                    IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> nonReusableLocalProxies,
                    SynthesizedLocalOrdinalsDispenser synthesizedLocalOrdinals,
                    VariableSlotAllocator slotAllocatorOpt,
                    int nextFreeHoistedLocalSlot,
                    DiagnosticBag diagnostics)
        : base(f_10445_2957_2963_C(method), methodOrdinal, asyncMethodBuilderMemberCollection, F, state, builder, hoistedVariables, nonReusableLocalProxies, synthesizedLocalOrdinals, slotAllocatorOpt, nextFreeHoistedLocalSlot, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10445, 2237, 3452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 1057, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 1712, 1733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 1987, 2007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 2142, 2217);
                this._nextYieldReturnState = StateMachineStates.InitialAsyncIteratorStateMachine; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 3223, 3263);

                f_10445_3223_3262(asyncIteratorInfo != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 3279, 3318);

                _asyncIteratorInfo = asyncIteratorInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 3332, 3373);

                _currentDisposalLabel = _exprReturnLabel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 3387, 3441);

                _exprReturnLabelTrue = f_10445_3410_3440(F, "yieldReturn");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10445, 2237, 3452);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 2237, 3452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 2237, 3452);
            }
        }

        protected override BoundStatement GenerateSetResultCall()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 3464, 5216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 4070, 4127);

                var
                builder = f_10445_4084_4126()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 4279, 4321);

                f_10445_4279_4320(this, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 4337, 4706);

                f_10445_4337_4705(
                            builder, f_10445_4372_4399(this), f_10445_4481_4514(false), f_10445_4533_4543(F), f_10445_4562_4591(F, _exprReturnLabelTrue), f_10445_4672_4704(true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 4722, 4767);

                return f_10445_4729_4766(F, f_10445_4737_4765(builder));

                BoundExpressionStatement generateSetResultOnPromise(bool result)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 4783, 5205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 4973, 5066);

                        BoundFieldAccess
                        promiseField = f_10445_5005_5065(F, f_10445_5021_5064(_asyncIteratorInfo))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 5084, 5190);

                        return f_10445_5091_5189(F, f_10445_5113_5188(F, promiseField, f_10445_5134_5168(_asyncIteratorInfo), f_10445_5170_5187(F, result)));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 4783, 5205);

                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10445_5021_5064(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                        this_param)
                        {
                            var return_v = this_param.PromiseOfValueOrEndField;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 5021, 5064);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        f_10445_5005_5065(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f)
                        {
                            var return_v = this_param.InstanceField(f);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5005, 5065);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10445_5134_5168(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                        this_param)
                        {
                            var return_v = this_param.SetResultMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 5134, 5168);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        f_10445_5170_5187(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, bool
                        value)
                        {
                            var return_v = this_param.Literal(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5170, 5187);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundCall
                        f_10445_5113_5188(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        arg0)
                        {
                            var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5113, 5188);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                        f_10445_5091_5189(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                        expr)
                        {
                            var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5091, 5189);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 4783, 5205);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 4783, 5205);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 3464, 5216);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10445_4084_4126()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4084, 4126);
                    return return_v;
                }


                int
                f_10445_4279_4320(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                builder)
                {
                    this_param.AddDisposeCombinedTokensIfNeeded(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4279, 4320);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_4372_4399(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.GenerateCompleteOnBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4372, 4399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_4481_4514(bool
                result)
                {
                    var return_v = generateSetResultOnPromise(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4481, 4514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10445_4533_4543(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4533, 4543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10445_4562_4591(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4562, 4591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_4672_4704(bool
                result)
                {
                    var return_v = generateSetResultOnPromise(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4672, 4704);
                    return return_v;
                }


                int
                f_10445_4337_4705(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4337, 4705);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10445_4737_4765(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4737, 4765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_4729_4766(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 4729, 4766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 3464, 5216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 3464, 5216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpressionStatement GenerateCompleteOnBuilder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 5228, 5751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 5379, 5740);

                return f_10445_5386_5739(F, f_10445_5426_5738(F, f_10445_5455_5498(F, f_10445_5463_5471(F), _asyncMethodBuilderField), _asyncMethodBuilderMemberCollection.SetResult, ImmutableArray<BoundExpression>.Empty));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 5228, 5751);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10445_5463_5471(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5463, 5471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10445_5455_5498(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5455, 5498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10445_5426_5738(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5426, 5738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_5386_5739(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 5386, 5739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 5228, 5751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 5228, 5751);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddDisposeCombinedTokensIfNeeded(ArrayBuilder<BoundStatement> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 5763, 6686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 6007, 6675) || true) && (f_10445_6011_6049(_asyncIteratorInfo) is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10445, 6007, 6675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 6093, 6172);

                    var
                    combinedTokens = f_10445_6114_6171(F, f_10445_6122_6130(F), f_10445_6132_6170(_asyncIteratorInfo))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 6190, 6242);

                    TypeSymbol
                    combinedTokensType = f_10445_6222_6241(combinedTokens)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 6262, 6660);

                    f_10445_6262_6659(
                                    builder, f_10445_6296_6658(F, f_10445_6301_6361(F, combinedTokens, f_10445_6334_6360(F, combinedTokensType)), thenClause: f_10445_6400_6657(F, f_10445_6438_6569(F, f_10445_6460_6568(F, combinedTokens, f_10445_6483_6567(F, WellKnownMember.System_Threading_CancellationTokenSource__Dispose))), f_10445_6600_6656(F, combinedTokens, f_10445_6629_6655(F, combinedTokensType)))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10445, 6007, 6675);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 5763, 6686);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10445_6011_6049(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                this_param)
                {
                    var return_v = this_param.CombinedTokensField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 6011, 6049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10445_6122_6130(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6122, 6130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10445_6132_6170(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                this_param)
                {
                    var return_v = this_param.CombinedTokensField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 6132, 6170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10445_6114_6171(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6114, 6171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10445_6222_6241(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 6222, 6241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10445_6334_6360(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6334, 6360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10445_6301_6361(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectNotEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6301, 6361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10445_6483_6567(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6483, 6567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10445_6460_6568(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6460, 6568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_6438_6569(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6438, 6569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10445_6629_6655(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6629, 6655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_6600_6656(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6600, 6656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_6400_6657(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6400, 6657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_6296_6658(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundBlock
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6296, 6658);
                    return return_v;
                }


                int
                f_10445_6262_6659(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6262, 6659);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 5763, 6686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 5763, 6686);
            }
        }

        protected override BoundStatement GenerateSetExceptionCall(LocalSymbol exceptionLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 6698, 7522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 6809, 6866);

                var
                builder = f_10445_6823_6865()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 7018, 7060);

                f_10445_7018_7059(this, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 7117, 7158);

                f_10445_7117_7157(
                            // this.builder.Complete();
                            builder, f_10445_7129_7156(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 7229, 7450);

                f_10445_7229_7449(
                            // _promiseOfValueOrEnd.SetException(ex);
                            builder, f_10445_7241_7448(F, f_10445_7263_7447(F, f_10445_7288_7348(F, f_10445_7304_7347(_asyncIteratorInfo)), f_10445_7367_7404(_asyncIteratorInfo), f_10445_7423_7446(F, exceptionLocal))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 7466, 7511);

                return f_10445_7473_7510(F, f_10445_7481_7509(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 6698, 7522);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10445_6823_6865()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 6823, 6865);
                    return return_v;
                }


                int
                f_10445_7018_7059(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                builder)
                {
                    this_param.AddDisposeCombinedTokensIfNeeded(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7018, 7059);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_7129_7156(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.GenerateCompleteOnBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7129, 7156);
                    return return_v;
                }


                int
                f_10445_7117_7157(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7117, 7157);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10445_7304_7347(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                this_param)
                {
                    var return_v = this_param.PromiseOfValueOrEndField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 7304, 7347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10445_7288_7348(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.InstanceField(f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7288, 7348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10445_7367_7404(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                this_param)
                {
                    var return_v = this_param.SetExceptionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 7367, 7404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10445_7423_7446(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7423, 7446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10445_7263_7447(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7263, 7447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_7241_7448(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7241, 7448);
                    return return_v;
                }


                int
                f_10445_7229_7449(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7229, 7449);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10445_7481_7509(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7481, 7509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_7473_7510(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7473, 7510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 6698, 7522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 6698, 7522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement GenerateJumpToCurrentDisposalLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 7534, 7917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 7618, 7664);

                f_10445_7618_7663(_currentDisposalLabel is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 7678, 7906);

                return f_10445_7685_7905(F, f_10445_7745_7797(                // if (disposeMode)
                                F, f_10445_7761_7796(_asyncIteratorInfo)), thenClause: f_10445_7875_7904(F, _currentDisposalLabel));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 7534, 7917);

                int
                f_10445_7618_7663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7618, 7663);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10445_7761_7796(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                this_param)
                {
                    var return_v = this_param.DisposeModeField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 7761, 7796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10445_7745_7797(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.InstanceField(f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7745, 7797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10445_7875_7904(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7875, 7904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_7685_7905(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                condition, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 7685, 7905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 7534, 7917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 7534, 7917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement AppendJumpToCurrentDisposalLabel(BoundStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 7929, 8282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 8030, 8076);

                f_10445_8030_8075(_currentDisposalLabel is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 8177, 8271);

                return f_10445_8184_8270(F, node, f_10445_8233_8269(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 7929, 8282);

                int
                f_10445_8030_8075(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 8030, 8075);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_8233_8269(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.GenerateJumpToCurrentDisposalLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 8233, 8269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_8184_8270(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 8184, 8270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 7929, 8282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 7929, 8282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundBinaryOperator ShouldEnterFinallyBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 8294, 8856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 8751, 8845);

                return f_10445_8758_8844(F, f_10445_8769_8789(F, cachedState), f_10445_8791_8843(F, StateMachineStates.NotStartedStateMachine));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 8294, 8856);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10445_8769_8789(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 8769, 8789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10445_8791_8843(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 8791, 8843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10445_8758_8844(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.IntEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 8758, 8844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 8294, 8856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 8294, 8856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundStatement VisitBody(BoundStatement body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 9239, 10199);
                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol resumeLabel = default(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 9538, 9581);

                var
                initialState = _nextYieldReturnState--
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 9595, 9628);

                f_10445_9595_9627(initialState == -3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 9642, 9703);

                f_10445_9642_9702(this, initialState, out resumeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 9719, 9767);

                var
                rewrittenBody = (BoundStatement)f_10445_9755_9766(this, body)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 9783, 9844);

                f_10445_9783_9843(f_10445_9796_9842(_exprReturnLabel, _currentDisposalLabel));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 9858, 10188);

                return f_10445_9865_10187(F, f_10445_9891_9911(F, resumeLabel), f_10445_9958_9994(this), f_10445_10056_10120(this, StateMachineStates.NotStartedStateMachine), rewrittenBody);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 9239, 10199);

                int
                f_10445_9595_9627(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9595, 9627);
                    return 0;
                }


                int
                f_10445_9642_9702(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, int
                stateNumber, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                resumeLabel)
                {
                    this_param.AddState(stateNumber, out resumeLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9642, 9702);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10445_9755_9766(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9755, 9766);
                    return return_v;
                }


                bool
                f_10445_9796_9842(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9796, 9842);
                    return return_v;
                }


                int
                f_10445_9783_9843(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9783, 9843);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10445_9891_9911(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9891, 9911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_9958_9994(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.GenerateJumpToCurrentDisposalLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9958, 9994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_10056_10120(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, int
                stateNumber)
                {
                    var return_v = this_param.GenerateSetBothStates(stateNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 10056, 10120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_9865_10187(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 9865, 10187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 9239, 10199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 9239, 10199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldReturnStatement(BoundYieldReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 10211, 12342);
                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol resumeLabel = default(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 10843, 10885);

                var
                stateNumber = _nextYieldReturnState--
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 10899, 10959);

                f_10445_10899_10958(this, stateNumber, out resumeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 10975, 11041);

                var
                rewrittenExpression = (BoundExpression)f_10445_11018_11040(this, f_10445_11024_11039(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11055, 11117);

                var
                blockBuilder = f_10445_11074_11116()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11133, 11296);

                f_10445_11133_11295(
                            blockBuilder, f_10445_11211_11294(                // _current = expression;
                                F, f_10445_11224_11272(F, f_10445_11240_11271(_asyncIteratorInfo)), rewrittenExpression));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11312, 11444);

                f_10445_11312_11443(
                            blockBuilder, f_10445_11408_11442(this, stateNumber));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11460, 11572);

                f_10445_11460_11571(
                            blockBuilder, f_10445_11542_11570(                // goto _exprReturnLabelTrue;
                                F, _exprReturnLabelTrue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11588, 11687);

                f_10445_11588_11686(
                            blockBuilder, f_10445_11665_11685(                // <next_state_label>: ;
                                F, resumeLabel));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11703, 11745);

                f_10445_11703_11744(
                            blockBuilder, f_10445_11720_11743(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11761, 11932);

                f_10445_11761_11931(
                            blockBuilder, f_10445_11866_11930(this, StateMachineStates.NotStartedStateMachine));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 11948, 11994);

                f_10445_11948_11993(_currentDisposalLabel is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 12052, 12189);

                f_10445_12052_12188(blockBuilder, f_10445_12151_12187(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 12205, 12265);

                f_10445_12205_12264(
                            blockBuilder, f_10445_12240_12263(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 12281, 12331);

                return f_10445_12288_12330(F, f_10445_12296_12329(blockBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 10211, 12342);

                int
                f_10445_10899_10958(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, int
                stateNumber, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                resumeLabel)
                {
                    this_param.AddState(stateNumber, out resumeLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 10899, 10958);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10445_11024_11039(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 11024, 11039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10445_11018_11040(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11018, 11040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10445_11074_11116()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11074, 11116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10445_11240_11271(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                this_param)
                {
                    var return_v = this_param.CurrentField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 11240, 11271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10445_11224_11272(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.InstanceField(f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11224, 11272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_11211_11294(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11211, 11294);
                    return return_v;
                }


                int
                f_10445_11133_11295(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11133, 11295);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_11408_11442(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, int
                stateNumber)
                {
                    var return_v = this_param.GenerateSetBothStates(stateNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11408, 11442);
                    return return_v;
                }


                int
                f_10445_11312_11443(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11312, 11443);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10445_11542_11570(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11542, 11570);
                    return return_v;
                }


                int
                f_10445_11460_11571(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11460, 11571);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10445_11665_11685(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11665, 11685);
                    return return_v;
                }


                int
                f_10445_11588_11686(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11588, 11686);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_11720_11743(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11720, 11743);
                    return return_v;
                }


                int
                f_10445_11703_11744(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11703, 11744);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_11866_11930(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, int
                stateNumber)
                {
                    var return_v = this_param.GenerateSetBothStates(stateNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11866, 11930);
                    return return_v;
                }


                int
                f_10445_11761_11931(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11761, 11931);
                    return 0;
                }


                int
                f_10445_11948_11993(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 11948, 11993);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_12151_12187(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.GenerateJumpToCurrentDisposalLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12151, 12187);
                    return return_v;
                }


                int
                f_10445_12052_12188(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12052, 12188);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_12240_12263(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12240, 12263);
                    return return_v;
                }


                int
                f_10445_12205_12264(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12205, 12264);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10445_12296_12329(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12296, 12329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_12288_12330(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12288, 12330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 10211, 12342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 10211, 12342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldBreakStatement(BoundYieldBreakStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 12354, 12929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 12460, 12501);

                f_10445_12460_12500(_asyncIteratorInfo != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 12625, 12671);

                f_10445_12625_12670(_currentDisposalLabel is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 12728, 12918);

                return f_10445_12735_12917(F, f_10445_12801_12821(this, true), f_10445_12887_12916(                // goto currentDisposalLabel;
                                F, _currentDisposalLabel));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 12354, 12929);

                int
                f_10445_12460_12500(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12460, 12500);
                    return 0;
                }


                int
                f_10445_12625_12670(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12625, 12670);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_12801_12821(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, bool
                value)
                {
                    var return_v = this_param.SetDisposeMode(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12801, 12821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10445_12887_12916(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12887, 12916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_12735_12917(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 12735, 12917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 12354, 12929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 12354, 12929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpressionStatement SetDisposeMode(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 12941, 13128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 13025, 13117);

                return f_10445_13032_13116(F, f_10445_13045_13097(F, f_10445_13061_13096(_asyncIteratorInfo)), f_10445_13099_13115(F, value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 12941, 13128);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10445_13061_13096(Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                this_param)
                {
                    var return_v = this_param.DisposeModeField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 13061, 13096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10445_13045_13097(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.InstanceField(f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 13045, 13097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10445_13099_13115(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 13099, 13115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10445_13032_13116(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 13032, 13116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 12941, 13128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 12941, 13128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTryStatement(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 14250, 15720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 14342, 14389);

                var
                savedDisposalLabel = _currentDisposalLabel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 14403, 15150) || true) && (f_10445_14407_14427(node) is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10445, 14403, 15150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 14471, 14522);

                    var
                    finallyEntry = f_10445_14490_14521(F, "finallyEntry")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 14540, 14577);

                    _currentDisposalLabel = finallyEntry;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 14782, 14988);

                    node = f_10445_14789_14987(node, tryBlock: f_10445_14833_14878(F, f_10445_14841_14854(node), f_10445_14856_14877(F, finallyEntry)), f_10445_14901_14917(node), f_10445_14919_14939(node), f_10445_14941_14961(node), f_10445_14963_14986(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10445, 14403, 15150);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10445, 14403, 15150);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15022, 15150) || true) && (f_10445_15026_15046(node) is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10445, 15022, 15150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15090, 15135);

                        _currentDisposalLabel = f_10445_15114_15134(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10445, 15022, 15150);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10445, 14403, 15150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15166, 15224);

                var
                result = (BoundStatement)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTryStatement(node), 10445, 15195, 15223)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15240, 15283);

                _currentDisposalLabel = savedDisposalLabel;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15299, 15558) || true) && (f_10445_15303_15323(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10445, 15303, 15366) && _currentDisposalLabel is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10445, 15299, 15558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15493, 15543);

                    result = f_10445_15502_15542(this, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10445, 15299, 15558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15695, 15709);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 14250, 15720);

                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10445_14407_14427(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 14407, 14427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10445_14490_14521(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 14490, 14521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_14841_14854(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 14841, 14854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10445_14856_14877(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 14856, 14877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_14833_14878(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 14833, 14878);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10445_14901_14917(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 14901, 14917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_14919_14939(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 14919, 14939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10445_14941_14961(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyLabelOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 14941, 14961);
                    return return_v;
                }


                bool
                f_10445_14963_14986(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.PreferFaultHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 14963, 14986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                f_10445_14789_14987(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlockOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                finallyLabelOpt, bool
                preferFaultHandler)
                {
                    var return_v = this_param.Update(tryBlock: tryBlock, catchBlocks, finallyBlockOpt, finallyLabelOpt, preferFaultHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 14789, 14987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10445_15026_15046(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyLabelOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 15026, 15046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10445_15114_15134(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyLabelOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 15114, 15134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10445_15303_15323(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 15303, 15323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_15502_15542(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.AppendJumpToCurrentDisposalLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 15502, 15542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 14250, 15720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 14250, 15720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundBlock VisitFinally(BoundBlock finallyBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 15732, 16148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15903, 15950);

                var
                savedDisposalLabel = _currentDisposalLabel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 15964, 15993);

                _currentDisposalLabel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 16007, 16052);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFinally(finallyBlock), 10445, 16020, 16051)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 16066, 16109);

                _currentDisposalLabel = savedDisposalLabel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 16123, 16137);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 15732, 16148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 15732, 16148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 15732, 16148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitExtractedFinallyBlock(BoundExtractedFinallyBlock extractedFinally)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10445, 16508, 17011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 16752, 16820);

                BoundStatement
                result = f_10445_16776_16819(this, f_10445_16789_16818(extractedFinally))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 16836, 16970) || true) && (_currentDisposalLabel is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10445, 16836, 16970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 16905, 16955);

                    result = f_10445_16914_16954(this, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10445, 16836, 16970);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10445, 16986, 17000);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10445, 16508, 17011);

                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_16789_16818(Microsoft.CodeAnalysis.CSharp.BoundExtractedFinallyBlock
                this_param)
                {
                    var return_v = this_param.FinallyBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10445, 16789, 16818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10445_16776_16819(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlock)
                {
                    var return_v = this_param.VisitFinally(finallyBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 16776, 16819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10445_16914_16954(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.AppendJumpToCurrentDisposalLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 16914, 16954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10445, 16508, 17011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 16508, 17011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AsyncIteratorMethodToStateMachineRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10445, 906, 17049);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10445, 906, 17049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10445, 906, 17049);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10445, 906, 17049);

        int
        f_10445_3223_3262(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 3223, 3262);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
        f_10445_3410_3440(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, string
        prefix)
        {
            var return_v = this_param.GenerateLabel(prefix);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10445, 3410, 3440);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10445_2957_2963_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10445, 2237, 3452);
            return return_v;
        }

    }
}
