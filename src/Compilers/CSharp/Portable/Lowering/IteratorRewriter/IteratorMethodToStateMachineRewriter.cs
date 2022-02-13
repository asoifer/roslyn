// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class IteratorMethodToStateMachineRewriter : MethodToStateMachineRewriter
    {
        private readonly FieldSymbol _current;

        private YieldsInTryAnalysis _yieldsInTryAnalysis;

        private int _tryNestingLevel;

        private LabelSymbol _exitLabel;

        private LocalSymbol _methodValue;

        private IteratorFinallyFrame _currentFinallyFrame;

        private int _nextFinalizeState;

        internal IteratorMethodToStateMachineRewriter(
                    SyntheticBoundNodeFactory F,
                    MethodSymbol originalMethod,
                    FieldSymbol state,
                    FieldSymbol current,
                    IReadOnlySet<Symbol> hoistedVariables,
                    IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> nonReusableLocalProxies,
                    SynthesizedLocalOrdinalsDispenser synthesizedLocalOrdinals,
                    VariableSlotAllocator slotAllocatorOpt,
                    int nextFreeHoistedLocalSlot,
                    DiagnosticBag diagnostics)
        : base(f_10467_3017_3018_C(F), originalMethod, state, hoistedVariables, nonReusableLocalProxies, synthesizedLocalOrdinals, slotAllocatorOpt, nextFreeHoistedLocalSlot, diagnostics, useFinalizerBookkeeping: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10467, 2446, 3255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 889, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 1050, 1070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 1243, 1259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 1290, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 1331, 1343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 1646, 1695);
                this._currentFinallyFrame = f_10467_1669_1695(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 2362, 2426);
                this._nextFinalizeState = StateMachineStates.FinishedStateMachine - 1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 3225, 3244);

                _current = current;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10467, 2446, 3255);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 2446, 3255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 2446, 3255);
            }
        }

        internal void GenerateMoveNextAndDispose(BoundStatement body, SynthesizedImplementationMethod moveNextMethod, SynthesizedImplementationMethod disposeMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 3267, 7381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 3498, 3551);

                _yieldsInTryAnalysis = f_10467_3521_3550(body);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 3565, 3772) || true) && (f_10467_3569_3612(_yieldsInTryAnalysis))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 3565, 3772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 3738, 3757);

                    _tryNestingLevel++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 3565, 3772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 3938, 3973);

                F.CurrentFunction = moveNextMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 3987, 4004);

                int
                initialState
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 4018, 4052);

                GeneratedLabelSymbol
                initialLabel
                = default(GeneratedLabelSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 4066, 4111);

                f_10467_4066_4110(this, out initialState, out initialLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 4125, 4167);

                var
                newBody = (BoundStatement)f_10467_4155_4166(this, body)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 4532, 5188);

                newBody = f_10467_4542_5187(F, (DynAbs.Tracing.TraceSender.Conditional_F1(10467, 4550, 4576) || (((object)cachedThis == null && DynAbs.Tracing.TraceSender.Conditional_F2(10467, 4612, 4646)) || DynAbs.Tracing.TraceSender.Conditional_F3(10467, 4682, 4728))) ? f_10467_4612_4646(cachedState) : f_10467_4682_4728(cachedState, cachedThis), f_10467_4753_4776(
                                    F), f_10467_4799_4864(F, f_10467_4812_4832(F, cachedState), f_10467_4834_4863(F, f_10467_4842_4850(F), stateField)), f_10467_4887_4906(this), f_10467_4929_4939(this), f_10467_4962_4992(this, finished: true), f_10467_5015_5036(F, initialLabel), f_10467_5059_5156(F, f_10467_5072_5101(F, f_10467_5080_5088(F), stateField), f_10467_5103_5155(F, StateMachineStates.NotStartedStateMachine)), newBody);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 5814, 6269) || true) && (f_10467_5818_5861(_yieldsInTryAnalysis))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 5814, 6269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6104, 6185);

                    var
                    faultBlock = f_10467_6121_6184(F, f_10467_6129_6183(F, f_10467_6151_6182(F, f_10467_6158_6166(F), disposeMethod)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6203, 6254);

                    newBody = f_10467_6213_6253(F, newBody, faultBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 5814, 6269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6285, 6317);

                newBody = f_10467_6295_6316(this, newBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6331, 6384);

                f_10467_6331_6383(F, f_10467_6345_6382(F, body.Syntax, newBody));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6548, 6582);

                F.CurrentFunction = disposeMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6596, 6633);

                var
                rootFrame = _currentFinallyFrame
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6649, 7370) || true) && (rootFrame.knownStates == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 6649, 7370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6756, 6782);

                    f_10467_6756_6781(                // nothing to finalize
                                    F, f_10467_6770_6780(F));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 6649, 7370);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 6649, 7370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6848, 6901);

                    var
                    stateLocal = f_10467_6865_6900(F, f_10467_6884_6899(stateField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6919, 6951);

                    var
                    state = f_10467_6931_6950(F, stateLocal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 6971, 7308);

                    var
                    disposeBody = f_10467_6989_7307(F, f_10467_7035_7081(stateLocal), f_10467_7120_7184(F, f_10467_7133_7152(F, stateLocal), f_10467_7154_7183(F, f_10467_7162_7170(F), stateField)), f_10467_7223_7257(this, rootFrame, state), f_10467_7296_7306(F))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 7328, 7355);

                    f_10467_7328_7354(
                                    F, disposeBody);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 6649, 7370);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 3267, 7381);

                Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.YieldsInTryAnalysis
                f_10467_3521_3550(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.YieldsInTryAnalysis(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 3521, 3550);
                    return return_v;
                }


                bool
                f_10467_3569_3612(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.YieldsInTryAnalysis
                this_param)
                {
                    var return_v = this_param.ContainsYieldsInTrys();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 3569, 3612);
                    return return_v;
                }


                int
                f_10467_4066_4110(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, out int
                stateNumber, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                resumeLabel)
                {
                    this_param.AddState(out stateNumber, out resumeLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4066, 4110);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_4155_4166(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4155, 4166);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10467_4612_4646(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4612, 4646);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10467_4682_4728(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4682, 4728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_4753_4776(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4753, 4776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10467_4812_4832(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4812, 4832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_4842_4850(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4842, 4850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_4834_4863(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4834, 4863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_4799_4864(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4799, 4864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_4887_4906(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.CacheThisIfNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4887, 4906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_4929_4939(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.Dispatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4929, 4939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_4962_4992(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, bool
                finished)
                {
                    var return_v = this_param.GenerateReturn(finished: finished);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4962, 4992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10467_5015_5036(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 5015, 5036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_5080_5088(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 5080, 5088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_5072_5101(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 5072, 5101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_5103_5155(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 5103, 5155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_5059_5156(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 5059, 5156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_4542_5187(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 4542, 5187);
                    return return_v;
                }


                bool
                f_10467_5818_5861(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.YieldsInTryAnalysis
                this_param)
                {
                    var return_v = this_param.ContainsYieldsInTrys();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 5818, 5861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_6158_6166(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6158, 6166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10467_6151_6182(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6151, 6182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_6129_6183(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6129, 6183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_6121_6184(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6121, 6184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                f_10467_6213_6253(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                tryBlock, Microsoft.CodeAnalysis.CSharp.BoundBlock
                faultBlock)
                {
                    var return_v = this_param.Fault((Microsoft.CodeAnalysis.CSharp.BoundBlock)tryBlock, faultBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6213, 6253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_6295_6316(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                newBody)
                {
                    var return_v = this_param.HandleReturn(newBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6295, 6316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_6345_6382(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = this_param.SequencePoint(syntax, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6345, 6382);
                    return return_v;
                }


                int
                f_10467_6331_6383(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6331, 6383);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10467_6770_6780(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6770, 6780);
                    return return_v;
                }


                int
                f_10467_6756_6781(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6756, 6781);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10467_6884_6899(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 6884, 6899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10467_6865_6900(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6865, 6900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10467_6931_6950(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6931, 6950);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10467_7035_7081(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7035, 7081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10467_7133_7152(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7133, 7152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_7162_7170(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7162, 7170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_7154_7183(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7154, 7183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_7120_7184(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7120, 7184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_7223_7257(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                frame, Microsoft.CodeAnalysis.CSharp.BoundLocal
                state)
                {
                    var return_v = this_param.EmitFinallyFrame(frame, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7223, 7257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10467_7296_7306(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7296, 7306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_6989_7307(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 6989, 7307);
                    return return_v;
                }


                int
                f_10467_7328_7354(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7328, 7354);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 3267, 7381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 3267, 7381);
            }
        }

        private BoundStatement HandleReturn(BoundStatement newBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 7393, 8304);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 7477, 8262) || true) && ((object)_exitLabel == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 7477, 8262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 7605, 7711);

                    newBody = f_10467_7615_7710(F, newBody, f_10467_7683_7709(F, f_10467_7692_7708(F, false)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 7477, 8262);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 7477, 8262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 7921, 8247);

                    newBody = f_10467_7931_8246(F, f_10467_7965_8013(_methodValue), newBody, f_10467_8074_8136(F, f_10467_8087_8113(this.F, _methodValue), f_10467_8115_8135(this.F, true)), f_10467_8163_8182(F, _exitLabel), f_10467_8209_8245(F, f_10467_8218_8244(this.F, _methodValue)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 7477, 8262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 8278, 8293);

                return newBody;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 7393, 8304);

                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_7692_7708(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7692, 7708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10467_7683_7709(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7683, 7709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_7615_7710(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7615, 7710);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10467_7965_8013(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7965, 8013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10467_8087_8113(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 8087, 8113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_8115_8135(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 8115, 8135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_8074_8136(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 8074, 8136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10467_8163_8182(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 8163, 8182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10467_8218_8244(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 8218, 8244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10467_8209_8245(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 8209, 8245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_7931_8246(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 7931, 8246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 7393, 8304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 7393, 8304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement EmitFinallyFrame(IteratorFinallyFrame frame, BoundLocal state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 10214, 11473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 10324, 10351);

                BoundStatement
                body = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 10365, 10993) || true) && (frame.knownStates != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 10365, 10993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 10428, 10470);

                    var
                    breakLabel = f_10467_10445_10469(F, "break")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 10488, 10833);

                    var
                    sections = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from ft in frame.knownStates
                                                                                       group ft.Key by ft.Value into g
                                                                                       select F.SwitchSection(
                                                                        new List<int>(g),
                                                                        EmitFinallyFrame(g.Key, state),
                                                                        F.Goto(breakLabel)), 10467, 10503, 10832)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 10853, 10978);

                    body = f_10467_10860_10977(F, f_10467_10890_10934(F, state, f_10467_10906_10933(sections)), f_10467_10957_10976(F, breakLabel));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 10365, 10993);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11009, 11342) || true) && (!f_10467_11014_11028(frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 11009, 11342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11062, 11118);

                    var
                    tryBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(10467, 11077, 11089) || ((body != null && DynAbs.Tracing.TraceSender.Conditional_F2(10467, 11092, 11105)) || DynAbs.Tracing.TraceSender.Conditional_F3(10467, 11108, 11117))) ? f_10467_11092_11105(F, body) : f_10467_11108_11117(F)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11136, 11327);

                    body = f_10467_11143_11326(F, tryBlock, ImmutableArray<BoundCatchBlock>.Empty, f_10467_11262_11325(F, f_10467_11270_11324(F, f_10467_11292_11323(F, f_10467_11299_11307(F), frame.handler))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 11009, 11342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11358, 11436);

                f_10467_11358_11435(body != null, "we should have either sub-dispatch or a handler");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11450, 11462);

                return body;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 10214, 11473);

                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10467_10445_10469(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 10445, 10469);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10467_10906_10933(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 10906, 10933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_10890_10934(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                ex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                sections)
                {
                    var return_v = this_param.Switch((Microsoft.CodeAnalysis.CSharp.BoundExpression)ex, sections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 10890, 10934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10467_10957_10976(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 10957, 10976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_10860_10977(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 10860, 10977);
                    return return_v;
                }


                bool
                f_10467_11014_11028(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                this_param)
                {
                    var return_v = this_param.IsRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11014, 11028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_11092_11105(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11092, 11105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_11108_11117(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11108, 11117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_11299_11307(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11299, 11307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10467_11292_11323(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11292, 11323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_11270_11324(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11270, 11324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_11262_11325(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11262, 11325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_11143_11326(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlock)
                {
                    var return_v = this_param.Try(tryBlock, catchBlocks, finallyBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11143, 11326);
                    return return_v;
                }


                int
                f_10467_11358_11435(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11358, 11435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 10214, 11473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 10214, 11473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundStatement GenerateReturn(bool finished)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 11485, 12461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11573, 11621);

                BoundLiteral
                result = f_10467_11595_11620(this.F, !finished)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11637, 12450) || true) && (_tryNestingLevel == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 11637, 12450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11696, 11720);

                    return f_10467_11703_11719(F, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 11637, 12450);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 11637, 12450);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11786, 11993) || true) && ((object)_exitLabel == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 11786, 11993);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11858, 11905);

                        _exitLabel = f_10467_11871_11904(this.F, "exitLabel");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 11927, 11974);

                        _methodValue = f_10467_11942_11973(F, f_10467_11961_11972(result));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 11786, 11993);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 12013, 12047);

                    var
                    gotoExit = f_10467_12028_12046(F, _exitLabel)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 12067, 12290) || true) && (finished)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 12067, 12290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 12211, 12271);

                        gotoExit = (BoundGotoStatement)f_10467_12242_12270(this, gotoExit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 12067, 12290);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 12310, 12435);

                    return f_10467_12317_12434(this.F, f_10467_12353_12401(F, f_10467_12366_12392(this.F, _methodValue), result), gotoExit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 11637, 12450);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 11485, 12461);

                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_11595_11620(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11595, 11620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10467_11703_11719(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11703, 11719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10467_11871_11904(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11871, 11904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10467_11961_11972(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 11961, 11972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10467_11942_11973(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.SynthesizedLocal(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 11942, 11973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10467_12028_12046(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 12028, 12046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_12242_12270(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                node)
                {
                    var return_v = this_param.VisitGotoStatement(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 12242, 12270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10467_12366_12392(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 12366, 12392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_12353_12401(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 12353, 12401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_12317_12434(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 12317, 12434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 11485, 12461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 11485, 12461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldBreakStatement(BoundYieldBreakStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 12503, 12658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 12609, 12647);

                return f_10467_12616_12646(this, finished: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 12503, 12658);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_12616_12646(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, bool
                finished)
                {
                    var return_v = this_param.GenerateReturn(finished: finished);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 12616, 12646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 12503, 12658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 12503, 12658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldReturnStatement(BoundYieldReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 12670, 13826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 13117, 13133);

                int
                stateNumber
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 13147, 13180);

                GeneratedLabelSymbol
                resumeLabel
                = default(GeneratedLabelSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 13194, 13237);

                f_10467_13194_13236(this, out stateNumber, out resumeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 13251, 13294);

                f_10467_13251_13293(_currentFinallyFrame, stateNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 13310, 13376);

                var
                rewrittenExpression = (BoundExpression)f_10467_13353_13375(this, f_10467_13359_13374(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 13392, 13815);

                return f_10467_13399_13814(F, f_10467_13425_13487(F, f_10467_13438_13465(F, f_10467_13446_13454(F), _current), rewrittenExpression), f_10467_13506_13573(F, f_10467_13519_13548(F, f_10467_13527_13535(F), stateField), f_10467_13550_13572(F, stateNumber)), f_10467_13592_13623(this, finished: false), f_10467_13642_13662(F, resumeLabel), f_10467_13681_13704(F), f_10467_13723_13813(F, f_10467_13736_13765(F, f_10467_13744_13752(F), stateField), f_10467_13767_13812(F, _currentFinallyFrame.finalizeState)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 12670, 13826);

                int
                f_10467_13194_13236(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, out int
                stateNumber, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                resumeLabel)
                {
                    this_param.AddState(out stateNumber, out resumeLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13194, 13236);
                    return 0;
                }


                int
                f_10467_13251_13293(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                this_param, int
                state)
                {
                    this_param.AddState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13251, 13293);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10467_13359_13374(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 13359, 13374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_13353_13375(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13353, 13375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_13446_13454(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13446, 13454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_13438_13465(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13438, 13465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_13425_13487(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13425, 13487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_13527_13535(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13527, 13535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_13519_13548(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13519, 13548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_13550_13572(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13550, 13572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_13506_13573(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13506, 13573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_13592_13623(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, bool
                finished)
                {
                    var return_v = this_param.GenerateReturn(finished: finished);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13592, 13623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10467_13642_13662(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13642, 13662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_13681_13704(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13681, 13704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_13744_13752(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13744, 13752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_13736_13765(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13736, 13765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_13767_13812(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13767, 13812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_13723_13813(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13723, 13813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_13399_13814(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13399, 13814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 12670, 13826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 12670, 13826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitGotoStatement(BoundGotoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 13838, 14446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 13932, 14020);

                BoundExpression
                caseExpressionOpt = (BoundExpression)f_10467_13985_14019(this, f_10467_13996_14018(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14034, 14114);

                BoundLabel
                labelExpressionOpt = (BoundLabel)f_10467_14078_14113(this, f_10467_14089_14112(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14128, 14197);

                var
                proxyLabel = f_10467_14145_14196(_currentFinallyFrame, f_10467_14185_14195(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14211, 14351);

                f_10467_14211_14350(f_10467_14224_14234(node) == proxyLabel || (DynAbs.Tracing.TraceSender.Expression_False(10467, 14224, 14303) || !(f_10467_14254_14271(F) is IteratorFinallyMethodSymbol)), "should not be proxying branches in finally");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14365, 14435);

                return f_10467_14372_14434(node, proxyLabel, caseExpressionOpt, labelExpressionOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 13838, 14446);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10467_13996_14018(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.CaseExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 13996, 14018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_13985_14019(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 13985, 14019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabel?
                f_10467_14089_14112(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.LabelExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 14089, 14112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_14078_14113(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabel?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 14078, 14113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10467_14185_14195(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 14185, 14195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10467_14145_14196(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.ProxyLabelIfNeeded(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 14145, 14196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10467_14224_14234(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 14224, 14234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10467_14254_14271(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 14254, 14271);
                    return return_v;
                }


                int
                f_10467_14211_14350(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 14211, 14350);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10467_14372_14434(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundExpression
                caseExpressionOpt, Microsoft.CodeAnalysis.CSharp.BoundLabel
                labelExpressionOpt)
                {
                    var return_v = this_param.Update(label, caseExpressionOpt, labelExpressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 14372, 14434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 13838, 14446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 13838, 14446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 14458, 14722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14556, 14658);

                f_10467_14556_14657(f_10467_14569_14579(node) == f_10467_14583_14634(_currentFinallyFrame, f_10467_14623_14633(node)), "conditional leave?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14672, 14711);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConditionalGoto(node), 10467, 14679, 14710);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 14458, 14722);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10467_14569_14579(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 14569, 14579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10467_14623_14633(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 14623, 14633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10467_14583_14634(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.ProxyLabelIfNeeded(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 14583, 14634);
                    return return_v;
                }


                int
                f_10467_14556_14657(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 14556, 14657);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 14458, 14722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 14458, 14722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTryStatement(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 14734, 18973);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14911, 15455) || true) && (!f_10467_14916_14936(this, node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 14911, 15455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 14970, 14989);

                    _tryNestingLevel++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15007, 15369);

                    var
                    result = f_10467_15020_15368(node, f_10467_15082_15102(this, f_10467_15088_15101(node)), f_10467_15141_15168(this, f_10467_15151_15167(node)), f_10467_15219_15246(this, f_10467_15225_15245(node)), f_10467_15285_15305(node), f_10467_15344_15367(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15389, 15408);

                    _tryNestingLevel--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15426, 15440);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 14911, 15455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15471, 15550);

                f_10467_15471_15549(node.CatchBlocks.IsEmpty, "try with yields must have no catches");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15564, 15644);

                f_10467_15564_15643(f_10467_15577_15597(node) != null, "try with yields must have finally");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15709, 15737);

                var
                frame = f_10467_15721_15736(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15751, 15770);

                _tryNestingLevel++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15784, 15846);

                var
                rewrittenBody = (BoundStatement)f_10467_15820_15845(this, f_10467_15831_15844(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15862, 15892);

                f_10467_15862_15891(!f_10467_15876_15890(frame));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 15906, 16022);

                f_10467_15906_16021(f_10467_15919_15964(frame.parent.knownStates, frame), "parent must be aware about states in the child frame");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16038, 16072);

                var
                finallyMethod = frame.handler
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16086, 16121);

                var
                origMethod = f_10467_16103_16120(F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16198, 16232);

                F.CurrentFunction = finallyMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16246, 16318);

                var
                rewrittenHandler = (BoundStatement)f_10467_16285_16317(this, f_10467_16296_16316(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16334, 16353);

                _tryNestingLevel--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16367, 16378);

                f_10467_16367_16377(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16541, 16620);

                f_10467_16541_16619(frame.parent.finalizeState == _currentFinallyFrame.finalizeState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 16634, 17158);

                rewrittenHandler = f_10467_16653_17157(F, (DynAbs.Tracing.TraceSender.Conditional_F1(10467, 16661, 16692) || (((object)this.cachedThis != null && DynAbs.Tracing.TraceSender.Conditional_F2(10467, 16740, 16778)) || DynAbs.Tracing.TraceSender.Conditional_F3(10467, 16826, 16859))) ? f_10467_16740_16778(this.cachedThis) : ImmutableArray<LocalSymbol>.Empty, f_10467_16894_16976(F, f_10467_16907_16936(F, f_10467_16915_16923(F), stateField), f_10467_16938_16975(F, frame.parent.finalizeState)), f_10467_17011_17030(this), rewrittenHandler, f_10467_17116_17126(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17174, 17206);

                f_10467_17174_17205(
                            F, rewrittenHandler);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17220, 17251);

                F.CurrentFunction = origMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17269, 17333);

                var
                bodyStatements = f_10467_17290_17332()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17638, 17734);

                f_10467_17638_17733(
                            // add a call to the handler after the try body.
                            //
                            // {
                            //      this.state = finalizeState;
                            //      body;
                            //      this.Finally();   // will reset the state to the finally state of the parent.
                            // }
                            bodyStatements, f_10467_17657_17732(F, f_10467_17670_17699(F, f_10467_17678_17686(F), stateField), f_10467_17701_17731(F, frame.finalizeState)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17748, 17782);

                f_10467_17748_17781(bodyStatements, rewrittenBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17796, 17871);

                f_10467_17796_17870(bodyStatements, f_10467_17815_17869(F, f_10467_17837_17868(F, f_10467_17844_17852(F), finallyMethod)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17935, 18894) || true) && (frame.proxyLabels != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 17935, 18894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 17998, 18047);

                    var
                    dropThrough = f_10467_18016_18046(F, "dropThrough")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18065, 18105);

                    f_10467_18065_18104(bodyStatements, f_10467_18084_18103(F, dropThrough));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18123, 18149);

                    var
                    parent = frame.parent
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18169, 18818);
                        foreach (var p in f_10467_18187_18204_I(frame.proxyLabels))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10467, 18169, 18818);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18246, 18266);

                            var
                            proxy = p.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18288, 18312);

                            var
                            destination = p.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18378, 18413);

                            f_10467_18378_18412(
                                                // branch lands here
                                                bodyStatements, f_10467_18397_18411(F, proxy));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18509, 18584);

                            f_10467_18509_18583(
                                                // finalize current state, proceed to destination.
                                                bodyStatements, f_10467_18528_18582(F, f_10467_18550_18581(F, f_10467_18557_18565(F), finallyMethod)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18680, 18737);

                            var
                            parentProxy = f_10467_18698_18736(parent, destination)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18759, 18799);

                            f_10467_18759_18798(bodyStatements, f_10467_18778_18797(F, parentProxy));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 18169, 18818);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10467, 1, 650);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10467, 1, 650);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18838, 18879);

                    f_10467_18838_18878(
                                    bodyStatements, f_10467_18857_18877(F, dropThrough));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10467, 17935, 18894);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 18910, 18962);

                return f_10467_18917_18961(F, f_10467_18925_18960(bodyStatements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 14734, 18973);

                bool
                f_10467_14916_14936(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement)
                {
                    var return_v = this_param.ContainsYields(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 14916, 14936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_15088_15101(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 15088, 15101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_15082_15102(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15082, 15102);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10467_15151_15167(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 15151, 15167);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10467_15141_15168(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15141, 15168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10467_15225_15245(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 15225, 15245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_15219_15246(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15219, 15246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10467_15285_15305(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyLabelOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 15285, 15305);
                    return return_v;
                }


                bool
                f_10467_15344_15367(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.PreferFaultHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 15344, 15367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                f_10467_15020_15368(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundNode
                finallyBlockOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                finallyLabelOpt, bool
                preferFaultHandler)
                {
                    var return_v = this_param.Update((Microsoft.CodeAnalysis.CSharp.BoundBlock)tryBlock, catchBlocks, (Microsoft.CodeAnalysis.CSharp.BoundBlock)finallyBlockOpt, finallyLabelOpt, preferFaultHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15020, 15368);
                    return return_v;
                }


                int
                f_10467_15471_15549(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15471, 15549);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10467_15577_15597(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 15577, 15597);
                    return return_v;
                }


                int
                f_10467_15564_15643(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15564, 15643);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                f_10467_15721_15736(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement)
                {
                    var return_v = this_param.PushFrame(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15721, 15736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_15831_15844(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 15831, 15844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_15820_15845(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15820, 15845);
                    return return_v;
                }


                bool
                f_10467_15876_15890(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                this_param)
                {
                    var return_v = this_param.IsRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15876, 15890);
                    return return_v;
                }


                int
                f_10467_15862_15891(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15862, 15891);
                    return 0;
                }


                bool
                f_10467_15919_15964(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame>
                this_param, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                value)
                {
                    var return_v = this_param.ContainsValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15919, 15964);
                    return return_v;
                }


                int
                f_10467_15906_16021(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 15906, 16021);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10467_16103_16120(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 16103, 16120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_16296_16316(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 16296, 16316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10467_16285_16317(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16285, 16317);
                    return return_v;
                }


                int
                f_10467_16367_16377(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param)
                {
                    this_param.PopFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16367, 16377);
                    return 0;
                }


                int
                f_10467_16541_16619(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16541, 16619);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10467_16740_16778(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16740, 16778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_16915_16923(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16915, 16923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_16907_16936(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16907, 16936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_16938_16975(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16938, 16975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_16894_16976(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16894, 16976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10467_17011_17030(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.CacheThisIfNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17011, 17030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10467_17116_17126(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17116, 17126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_16653_17157(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 16653, 17157);
                    return return_v;
                }


                int
                f_10467_17174_17205(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17174, 17205);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10467_17290_17332()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17290, 17332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_17678_17686(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17678, 17686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10467_17670_17699(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17670, 17699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10467_17701_17731(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17701, 17731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_17657_17732(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17657, 17732);
                    return return_v;
                }


                int
                f_10467_17638_17733(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17638, 17733);
                    return 0;
                }


                int
                f_10467_17748_17781(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17748, 17781);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_17844_17852(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17844, 17852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10467_17837_17868(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17837, 17868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_17815_17869(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17815, 17869);
                    return return_v;
                }


                int
                f_10467_17796_17870(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 17796, 17870);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10467_18016_18046(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18016, 18046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10467_18084_18103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Goto((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18084, 18103);
                    return return_v;
                }


                int
                f_10467_18065_18104(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18065, 18104);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10467_18397_18411(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18397, 18411);
                    return return_v;
                }


                int
                f_10467_18378_18412(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18378, 18412);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10467_18557_18565(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18557, 18565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10467_18550_18581(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18550, 18581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10467_18528_18582(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18528, 18582);
                    return return_v;
                }


                int
                f_10467_18509_18583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18509, 18583);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10467_18698_18736(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.ProxyLabelIfNeeded(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18698, 18736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10467_18778_18797(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18778, 18797);
                    return return_v;
                }


                int
                f_10467_18759_18798(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18759, 18798);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10467_18187_18204_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18187, 18204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10467_18857_18877(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18857, 18877);
                    return return_v;
                }


                int
                f_10467_18838_18878(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18838, 18878);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10467_18925_18960(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18925, 18960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10467_18917_18961(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 18917, 18961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 14734, 18973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 14734, 18973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IteratorFinallyFrame PushFrame(BoundTryStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 18985, 19442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19077, 19110);

                var
                state = _nextFinalizeState--
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19126, 19176);

                var
                finallyMethod = f_10467_19146_19175(this, state)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19190, 19314);

                var
                newFrame = f_10467_19205_19313(_currentFinallyFrame, state, finallyMethod, f_10467_19274_19312(_yieldsInTryAnalysis, statement))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19328, 19353);

                f_10467_19328_19352(newFrame, state);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19369, 19401);

                _currentFinallyFrame = newFrame;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19415, 19431);

                return newFrame;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 18985, 19442);

                Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol
                f_10467_19146_19175(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter
                this_param, int
                state)
                {
                    var return_v = this_param.MakeSynthesizedFinally(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 19146, 19175);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10467_19274_19312(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.YieldsInTryAnalysis
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement)
                {
                    var return_v = this_param.Labels(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 19274, 19312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                f_10467_19205_19313(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                parent, int
                finalizeState, Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol
                handler, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                labels)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame(parent, finalizeState, handler, labels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 19205, 19313);
                    return return_v;
                }


                int
                f_10467_19328_19352(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                this_param, int
                state)
                {
                    this_param.AddState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 19328, 19352);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 18985, 19442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 18985, 19442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PopFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 19454, 19598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19502, 19536);

                var
                result = _currentFinallyFrame
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19550, 19587);

                _currentFinallyFrame = result.parent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 19454, 19598);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 19454, 19598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 19454, 19598);
            }
        }

        private bool ContainsYields(BoundTryStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 19610, 19756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19691, 19745);

                return f_10467_19698_19744(_yieldsInTryAnalysis, statement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 19610, 19756);

                bool
                f_10467_19698_19744(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.YieldsInTryAnalysis
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement)
                {
                    var return_v = this_param.ContainsYields(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 19698, 19744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 19610, 19756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 19610, 19756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IteratorFinallyMethodSymbol MakeSynthesizedFinally(int state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10467, 19768, 20213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19862, 19921);

                var
                stateMachineType = (IteratorStateMachine)f_10467_19907_19920(F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 19935, 20058);

                var
                finallyMethod = f_10467_19955_20057(stateMachineType, f_10467_20005_20056(state))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 20074, 20167);

                f_10467_20074_20166(f_10467_20074_20092(F), stateMachineType, f_10467_20136_20165(finallyMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10467, 20181, 20202);

                return finallyMethod;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10467, 19768, 20213);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10467_19907_19920(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 19907, 19920);
                    return return_v;
                }


                string
                f_10467_20005_20056(int
                iteratorState)
                {
                    var return_v = GeneratedNames.MakeIteratorFinallyMethodName(iteratorState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 20005, 20056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol
                f_10467_19955_20057(Microsoft.CodeAnalysis.CSharp.IteratorStateMachine?
                stateMachineType, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol(stateMachineType, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 19955, 20057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10467_20074_20092(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10467, 20074, 20092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10467_20136_20165(Microsoft.CodeAnalysis.CSharp.IteratorFinallyMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 20136, 20165);
                    return return_v;
                }


                int
                f_10467_20074_20166(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.IteratorStateMachine?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 20074, 20166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10467, 19768, 20213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 19768, 20213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IteratorMethodToStateMachineRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10467, 607, 20242);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10467, 607, 20242);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10467, 607, 20242);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10467, 607, 20242);

        Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
        f_10467_1669_1695()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10467, 1669, 1695);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        f_10467_3017_3018_C(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10467, 2446, 3255);
            return return_v;
        }

    }
}
