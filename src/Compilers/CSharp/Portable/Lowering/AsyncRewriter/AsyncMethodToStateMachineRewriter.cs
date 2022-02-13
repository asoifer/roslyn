// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class AsyncMethodToStateMachineRewriter : MethodToStateMachineRewriter
    {
        protected readonly MethodSymbol _method;

        protected readonly FieldSymbol _asyncMethodBuilderField;

        protected readonly AsyncMethodBuilderMemberCollection _asyncMethodBuilderMemberCollection;

        protected readonly LabelSymbol _exprReturnLabel;

        private readonly LabelSymbol _exitLabel;

        private readonly LocalSymbol _exprRetValue;

        private readonly LoweredDynamicOperationFactory _dynamicFactory;

        private readonly Dictionary<TypeSymbol, FieldSymbol> _awaiterFields;

        private int _nextAwaiterId;

        private readonly Dictionary<BoundValuePlaceholderBase, BoundExpression> _placeholderMap;

        internal AsyncMethodToStateMachineRewriter(
                    MethodSymbol method,
                    int methodOrdinal,
                    AsyncMethodBuilderMemberCollection asyncMethodBuilderMemberCollection,
                    SyntheticBoundNodeFactory F,
                    FieldSymbol state,
                    FieldSymbol builder,
                    IReadOnlySet<Symbol> hoistedVariables,
                    IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> nonReusableLocalProxies,
                    SynthesizedLocalOrdinalsDispenser synthesizedLocalOrdinals,
                    VariableSlotAllocator slotAllocatorOpt,
                    int nextFreeHoistedLocalSlot,
                    DiagnosticBag diagnostics)
        : base(f_10447_3514_3515_C(F), method, state, hoistedVariables, nonReusableLocalProxies, synthesizedLocalOrdinals, slotAllocatorOpt, nextFreeHoistedLocalSlot, diagnostics, useFinalizerBookkeeping: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10447, 2838, 4661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 947, 954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 1353, 1377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 1916, 1932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 2121, 2131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 2519, 2532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 2593, 2608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 2674, 2688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 2711, 2725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 2810, 2825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 3714, 3731);

                _method = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 3745, 3818);

                _asyncMethodBuilderMemberCollection = asyncMethodBuilderMemberCollection;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 3832, 3867);

                _asyncMethodBuilderField = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 3881, 3930);

                _exprReturnLabel = f_10447_3900_3929(F, "exprReturn");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 3944, 3986);

                _exitLabel = f_10447_3957_3985(F, "exitLabel");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 4002, 4246);

                _exprRetValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 4018, 4067) || ((f_10447_4018_4067(method, f_10447_4053_4066(F)) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 4087, 4221)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 4241, 4245))) ? f_10447_4087_4221(F, asyncMethodBuilderMemberCollection.ResultType, syntax: f_10447_4161_4169(F), kind: SynthesizedLocalKind.AsyncMethodReturnValue) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 4262, 4333);

                _dynamicFactory = f_10447_4280_4332(F, methodOrdinal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 4347, 4476);

                _awaiterFields = f_10447_4364_4475(Symbols.SymbolEqualityComparer.IgnoringDynamicTupleNamesAndNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 4490, 4555);

                _nextAwaiterId = f_10447_4507_4549_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(slotAllocatorOpt, 10447, 4507, 4549)?.PreviousAwaiterSlotCount) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10447, 4507, 4554) ?? 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 4571, 4650);

                _placeholderMap = f_10447_4589_4649();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10447, 2838, 4661);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 2838, 4661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 2838, 4661);
            }
        }

        private FieldSymbol GetAwaiterField(TypeSymbol awaiterType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 4673, 5876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 4757, 4776);

                FieldSymbol
                result
                = default(FieldSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5168, 5835) || true) && (!f_10447_5173_5224(_awaiterFields, awaiterType, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 5168, 5835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5258, 5272);

                    int
                    slotIndex
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5290, 5558) || true) && (slotAllocatorOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10447, 5294, 5468) || !f_10447_5323_5468(slotAllocatorOpt, f_10447_5371_5437(f_10447_5371_5389(F), awaiterType, f_10447_5413_5421(F), f_10447_5423_5436(F)), f_10447_5439_5452(F), out slotIndex)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 5290, 5558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5510, 5539);

                        slotIndex = _nextAwaiterId++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 5290, 5558);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5578, 5645);

                    string
                    fieldName = f_10447_5597_5644(slotIndex)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5663, 5762);

                    result = f_10447_5672_5761(F, awaiterType, fieldName, SynthesizedLocalKind.AwaiterField, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5780, 5820);

                    f_10447_5780_5819(_awaiterFields, awaiterType, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 5168, 5835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 5851, 5865);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 4673, 5876);

                bool
                f_10447_5173_5224(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 5173, 5224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10447_5371_5389(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 5371, 5389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10447_5413_5421(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 5413, 5421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10447_5423_5436(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 5423, 5436);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10447_5371_5437(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 5371, 5437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10447_5439_5452(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 5439, 5452);
                    return return_v;
                }


                bool
                f_10447_5323_5468(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                this_param, Microsoft.Cci.ITypeReference
                currentType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out int
                slotIndex)
                {
                    var return_v = this_param.TryGetPreviousAwaiterSlotIndex(currentType, diagnostics, out slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 5323, 5468);
                    return return_v;
                }


                string
                f_10447_5597_5644(int
                slotIndex)
                {
                    var return_v = GeneratedNames.AsyncAwaiterFieldName(slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 5597, 5644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10447_5672_5761(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, int
                slotIndex)
                {
                    var return_v = this_param.StateMachineField(type, name, synthesizedKind, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 5672, 5761);
                    return return_v;
                }


                int
                f_10447_5780_5819(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 5780, 5819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 4673, 5876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 4673, 5876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GenerateMoveNext(BoundStatement body, MethodSymbol moveNextMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 5989, 9224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6094, 6129);

                F.CurrentFunction = moveNextMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6143, 6190);

                BoundStatement
                rewrittenBody = f_10447_6174_6189(this, body)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6206, 6269);

                ImmutableArray<StateMachineFieldSymbol>
                rootScopeHoistedLocals
                = default(ImmutableArray<StateMachineFieldSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6283, 6362);

                f_10447_6283_6361(ref rewrittenBody, out rootScopeHoistedLocals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6378, 6439);

                var
                bodyBuilder = f_10447_6396_6438()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6455, 6496);

                f_10447_6455_6495(
                            bodyBuilder, f_10447_6471_6494(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6510, 6593);

                f_10447_6510_6592(bodyBuilder, f_10447_6526_6591(F, f_10447_6539_6559(F, cachedState), f_10447_6561_6590(F, f_10447_6569_6577(F), stateField)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6607, 6644);

                f_10447_6607_6643(bodyBuilder, f_10447_6623_6642(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6660, 6749);

                var
                exceptionLocal = f_10447_6681_6748(F, f_10447_6700_6747(F, WellKnownType.System_Exception))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 6763, 7236);

                f_10447_6763_7235(bodyBuilder, f_10447_6797_7216(this, f_10447_6839_7112(F, ImmutableArray<LocalSymbol>.Empty, f_10447_6954_6977(                        // switch (state) ...
                                        F), f_10447_7004_7014(this), rewrittenBody), f_10447_7135_7215(F, f_10447_7149_7214(this, exceptionLocal, rootScopeHoistedLocals))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 7345, 7388);

                f_10447_7345_7387(
                            // ReturnLabel (for the rewritten return expressions in the user's method body)
                            bodyBuilder, f_10447_7361_7386(F, _exprReturnLabel));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 7447, 7559);

                var
                stateDone = f_10447_7463_7558(F, f_10447_7476_7505(F, f_10447_7484_7492(F), stateField), f_10447_7507_7557(F, StateMachineStates.FinishedStateMachine))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 7573, 7612);

                var
                block = body.Syntax as BlockSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 7626, 8158) || true) && (block == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 7626, 8158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 7780, 7807);

                    f_10447_7780_7806(                // this happens, for example, in (async () => await e) where there is no block syntax
                                    bodyBuilder, stateDone);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 7626, 8158);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 7626, 8158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 7873, 7960);

                    f_10447_7873_7959(bodyBuilder, f_10447_7889_7958(F, block, block.CloseBraceToken.Span, stateDone));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 7978, 8019);

                    f_10447_7978_8018(bodyBuilder, f_10447_7994_8017(F));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 7626, 8158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8174, 8244);

                f_10447_8174_8243(
                            bodyBuilder, f_10447_8190_8242(this, rootScopeHoistedLocals));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8260, 8301);

                f_10447_8260_8300(
                            bodyBuilder, f_10447_8276_8299(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8385, 8422);

                f_10447_8385_8421(
                            // this code is hidden behind a hidden sequence point.
                            bodyBuilder, f_10447_8401_8420(F, _exitLabel));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8436, 8464);

                f_10447_8436_8463(bodyBuilder, f_10447_8452_8462(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8480, 8533);

                var
                newStatements = f_10447_8500_8532(bodyBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8549, 8602);

                var
                locals = f_10447_8562_8601()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8616, 8640);

                f_10447_8616_8639(locals, cachedState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8654, 8709) || true) && ((object)cachedThis != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 8654, 8709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8686, 8709);

                    f_10447_8686_8708(locals, cachedThis);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 8654, 8709);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8723, 8784) || true) && ((object)_exprRetValue != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 8723, 8784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8758, 8784);

                    f_10447_8758_8783(locals, _exprRetValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 8723, 8784);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 8800, 9007);

                var
                newBody =
                f_10447_8831_9006(F, body.Syntax, f_10447_8903_9005(F, f_10447_8937_8964(locals), newStatements))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 9023, 9174) || true) && (rootScopeHoistedLocals.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 9023, 9174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 9094, 9159);

                    newBody = f_10447_9104_9158(this, rootScopeHoistedLocals, newBody);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 9023, 9174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 9190, 9213);

                f_10447_9190_9212(
                            F, newBody);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 5989, 9224);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_6174_6189(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    var return_v = this_param.VisitBody(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6174, 6189);
                    return return_v;
                }


                bool
                f_10447_6283_6361(ref Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedLocals)
                {
                    var return_v = TryUnwrapBoundStateMachineScope(ref statement, out hoistedLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6283, 6361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_6396_6438()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6396, 6438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_6471_6494(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6471, 6494);
                    return return_v;
                }


                int
                f_10447_6455_6495(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6455, 6495);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_6539_6559(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6539, 6559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_6569_6577(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6569, 6577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_6561_6590(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6561, 6590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_6526_6591(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6526, 6591);
                    return return_v;
                }


                int
                f_10447_6510_6592(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6510, 6592);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_6623_6642(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.CacheThisIfNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6623, 6642);
                    return return_v;
                }


                int
                f_10447_6607_6643(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6607, 6643);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_6700_6747(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6700, 6747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10447_6681_6748(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6681, 6748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_6954_6977(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6954, 6977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_7004_7014(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.Dispatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7004, 7014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_6839_7112(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6839, 7112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10447_7149_7214(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                exceptionLocal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedLocals)
                {
                    var return_v = this_param.GenerateExceptionHandling(exceptionLocal, hoistedLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7149, 7214);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10447_7135_7215(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundCatchBlock[]
                catchBlocks)
                {
                    var return_v = this_param.CatchBlocks(catchBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7135, 7215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_6797_7216(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks)
                {
                    var return_v = this_param.GenerateTopLevelTry(tryBlock, catchBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6797, 7216);
                    return return_v;
                }


                int
                f_10447_6763_7235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 6763, 7235);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10447_7361_7386(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7361, 7386);
                    return return_v;
                }


                int
                f_10447_7345_7387(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7345, 7387);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_7484_7492(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7484, 7492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_7476_7505(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7476, 7505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10447_7507_7557(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7507, 7557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_7463_7558(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7463, 7558);
                    return return_v;
                }


                int
                f_10447_7780_7806(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7780, 7806);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_7889_7958(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.SequencePointWithSpan((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, span, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7889, 7958);
                    return return_v;
                }


                int
                f_10447_7873_7959(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7873, 7959);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_7994_8017(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7994, 8017);
                    return return_v;
                }


                int
                f_10447_7978_8018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 7978, 8018);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_8190_8242(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedLocals)
                {
                    var return_v = this_param.GenerateHoistedLocalsCleanup(hoistedLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8190, 8242);
                    return return_v;
                }


                int
                f_10447_8174_8243(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8174, 8243);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_8276_8299(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.GenerateSetResultCall();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8276, 8299);
                    return return_v;
                }


                int
                f_10447_8260_8300(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8260, 8300);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10447_8401_8420(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8401, 8420);
                    return return_v;
                }


                int
                f_10447_8385_8421(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8385, 8421);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10447_8452_8462(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8452, 8462);
                    return return_v;
                }


                int
                f_10447_8436_8463(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8436, 8463);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_8500_8532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8500, 8532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_8562_8601()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8562, 8601);
                    return return_v;
                }


                int
                f_10447_8616_8639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8616, 8639);
                    return 0;
                }


                int
                f_10447_8686_8708(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8686, 8708);
                    return 0;
                }


                int
                f_10447_8758_8783(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8758, 8783);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_8937_8964(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8937, 8964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_8903_9005(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8903, 9005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_8831_9006(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundBlock
                statement)
                {
                    var return_v = this_param.SequencePoint(syntax, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 8831, 9006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_9104_9158(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedLocals, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = this_param.MakeStateMachineScope(hoistedLocals, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9104, 9158);
                    return return_v;
                }


                int
                f_10447_9190_9212(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9190, 9212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 5989, 9224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 5989, 9224);
            }
        }

        protected virtual BoundStatement GenerateTopLevelTry(BoundBlock tryBlock, ImmutableArray<BoundCatchBlock> catchBlocks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 9368, 9399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 9371, 9399);
                return f_10447_9371_9399(F, tryBlock, catchBlocks); DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 9368, 9399);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 9368, 9399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 9368, 9399);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.BoundStatement
            f_10447_9371_9399(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
            tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
            catchBlocks)
            {
                var return_v = this_param.Try(tryBlock, catchBlocks);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9371, 9399);
                return return_v;
            }

        }

        protected virtual BoundStatement GenerateSetResultCall()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 9412, 9966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 9537, 9955);

                return f_10447_9544_9954(F, f_10447_9584_9953(F, f_10447_9613_9656(F, f_10447_9621_9629(F), _asyncMethodBuilderField), _asyncMethodBuilderMemberCollection.SetResult, (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 9747, 9797) || ((f_10447_9747_9797(_method, f_10447_9783_9796(F)) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 9825, 9887)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 9915, 9952))) ? f_10447_9825_9887(f_10447_9864_9886(F, _exprRetValue)) : ImmutableArray<BoundExpression>.Empty));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 9412, 9966);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_9621_9629(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9621, 9629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_9613_9656(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9613, 9656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10447_9783_9796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 9783, 9796);
                    return return_v;
                }


                bool
                f_10447_9747_9797(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = method.IsAsyncReturningGenericTask(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9747, 9797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_9864_9886(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9864, 9886);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10447_9825_9887(Microsoft.CodeAnalysis.CSharp.BoundLocal
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9825, 9887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10447_9584_9953(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9584, 9953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_9544_9954(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 9544, 9954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 9412, 9966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 9412, 9966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundCatchBlock GenerateExceptionHandling(LocalSymbol exceptionLocal, ImmutableArray<StateMachineFieldSymbol> hoistedLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 9978, 11745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 10623, 10806);

                BoundStatement
                assignFinishedState =
                f_10447_10677_10805(F, f_10447_10699_10804(F, f_10447_10722_10751(F, f_10447_10730_10738(F), stateField), f_10447_10753_10803(F, StateMachineStates.FinishedStateMachine)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 10972, 11047);

                BoundStatement
                callSetException = f_10447_11006_11046(this, exceptionLocal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 11063, 11734);

                return f_10447_11070_11733(f_10447_11108_11116(F), f_10447_11135_11172(exceptionLocal), f_10447_11191_11214(F, exceptionLocal), f_10447_11233_11252(exceptionLocal), exceptionFilterPrologueOpt: null, exceptionFilterOpt: null, body: f_10447_11371_11670(F, assignFinishedState, f_10447_11470_11513(this, hoistedLocals), callSetException, f_10447_11648_11669(this, false)), isSynthesizedAsyncCatchAll: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 9978, 11745);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_10730_10738(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 10730, 10738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_10722_10751(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 10722, 10751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10447_10753_10803(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 10753, 10803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10447_10699_10804(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 10699, 10804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_10677_10805(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 10677, 10805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_11006_11046(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                exceptionLocal)
                {
                    var return_v = this_param.GenerateSetExceptionCall(exceptionLocal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11006, 11046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10447_11108_11116(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 11108, 11116);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_11135_11172(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11135, 11172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_11191_11214(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11191, 11214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_11233_11252(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 11233, 11252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_11470_11513(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedLocals)
                {
                    var return_v = this_param.GenerateHoistedLocalsCleanup(hoistedLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11470, 11513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_11648_11669(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, bool
                finished)
                {
                    var return_v = this_param.GenerateReturn(finished);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11648, 11669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_11371_11670(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11371, 11670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10447_11070_11733(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundLocal
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCatchBlock(syntax, locals, (Microsoft.CodeAnalysis.CSharp.BoundExpression)exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt: exceptionFilterPrologueOpt, exceptionFilterOpt: exceptionFilterOpt, body: body, isSynthesizedAsyncCatchAll: isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11070, 11733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 9978, 11745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 9978, 11745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundStatement GenerateHoistedLocalsCleanup(ImmutableArray<StateMachineFieldSymbol> hoistedLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 11757, 12699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 11890, 11947);

                var
                builder = f_10447_11904_11946()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12077, 12627);
                    foreach (var hoistedLocal in f_10447_12106_12119_I(hoistedLocals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 12077, 12627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12153, 12203);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12221, 12297);

                        var
                        isManagedType = f_10447_12241_12296(f_10447_12241_12258(hoistedLocal), ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12315, 12391);

                        f_10447_12315_12390(f_10447_12315_12328(F), hoistedLocal.Locations.FirstOrNone(), useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12409, 12497) || true) && (!isManagedType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 12409, 12497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12469, 12478);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 12409, 12497);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12517, 12612);

                        f_10447_12517_12611(
                                        builder, f_10447_12529_12610(F, f_10447_12542_12573(F, f_10447_12550_12558(F), hoistedLocal), f_10447_12575_12609(F, f_10447_12591_12608(hoistedLocal))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 12077, 12627);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10447, 1, 551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10447, 1, 551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12643, 12688);

                return f_10447_12650_12687(F, f_10447_12658_12686(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 11757, 12699);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_11904_11946()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 11904, 11946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_12241_12258(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 12241, 12258);
                    return return_v;
                }


                bool
                f_10447_12241_12296(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsManagedType(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12241, 12296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10447_12315_12328(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 12315, 12328);
                    return return_v;
                }


                bool
                f_10447_12315_12390(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12315, 12390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_12550_12558(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12550, 12558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_12542_12573(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12542, 12573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_12591_12608(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 12591, 12608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_12575_12609(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.NullOrDefault(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12575, 12609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_12529_12610(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12529, 12610);
                    return return_v;
                }


                int
                f_10447_12517_12611(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12517, 12611);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10447_12106_12119_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12106, 12119);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_12658_12686(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12658, 12686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_12650_12687(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12650, 12687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 11757, 12699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 11757, 12699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual BoundStatement GenerateSetExceptionCall(LocalSymbol exceptionLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 12711, 13208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12821, 12861);

                f_10447_12821_12860(f_10447_12834_12859_M(!f_10447_12835_12848().IsIterator));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 12958, 13197);

                return f_10447_12965_13196(F, f_10447_13005_13195(F, f_10447_13034_13077(F, f_10447_13042_13050(F), _asyncMethodBuilderField), _asyncMethodBuilderMemberCollection.SetException, f_10447_13171_13194(F, exceptionLocal)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 12711, 13208);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10447_12835_12848()
                {
                    var return_v = CurrentMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 12835, 12848);
                    return return_v;
                }


                bool
                f_10447_12834_12859_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 12834, 12859);
                    return return_v;
                }


                int
                f_10447_12821_12860(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12821, 12860);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_13042_13050(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 13042, 13050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_13034_13077(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 13034, 13077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_13171_13194(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 13171, 13194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10447_13005_13195(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 13005, 13195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_12965_13196(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 12965, 13196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 12711, 13208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 12711, 13208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override BoundStatement GenerateReturn(bool finished)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 13220, 13352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 13315, 13341);

                return f_10447_13322_13340(F, _exitLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 13220, 13352);

                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10447_13322_13340(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 13322, 13340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 13220, 13352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 13220, 13352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual BoundStatement VisitBody(BoundStatement body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 13469, 13499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 13472, 13499);
                return (BoundStatement)f_10447_13488_13499(this, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 13469, 13499);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 13469, 13499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 13469, 13499);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.BoundNode
            f_10447_13488_13499(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
            this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
            node)
            {
                var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 13488, 13499);
                return return_v;
            }

        }

        public sealed override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 13512, 14413);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 13625, 14226) || true) && (f_10447_13629_13649(f_10447_13629_13644(node)) == BoundKind.AwaitExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 13625, 14226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 13712, 13798);

                    return f_10447_13719_13797(this, f_10447_13762_13777(node), resultPlace: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 13625, 14226);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 13625, 14226);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 13832, 14226) || true) && (f_10447_13836_13856(f_10447_13836_13851(node)) == BoundKind.AssignmentOperator)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 13832, 14226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 13922, 13980);

                        var
                        expression = (BoundAssignmentOperator)f_10447_13964_13979(node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 13998, 14211) || true) && (f_10447_14002_14023(f_10447_14002_14018(expression)) == BoundKind.AwaitExpression)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 13998, 14211);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 14094, 14192);

                            return f_10447_14101_14191(this, f_10447_14144_14160(expression), resultPlace: f_10447_14175_14190(expression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 13998, 14211);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 13832, 14226);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 13625, 14226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 14242, 14310);

                BoundExpression
                expr = (BoundExpression)f_10447_14282_14309(this, f_10447_14293_14308(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 14324, 14402);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 14331, 14345) || (((expr != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 14348, 14365)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 14368, 14401))) ? f_10447_14348_14365(node, expr) : (BoundStatement)f_10447_14384_14401(F);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 13512, 14413);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_13629_13644(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 13629, 13644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10447_13629_13649(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 13629, 13649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_13762_13777(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 13762, 13777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_13719_13797(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                resultPlace)
                {
                    var return_v = this_param.VisitAwaitExpression((Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression)node, resultPlace: resultPlace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 13719, 13797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_13836_13851(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 13836, 13851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10447_13836_13856(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 13836, 13856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_13964_13979(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 13964, 13979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_14002_14018(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 14002, 14018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10447_14002_14023(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 14002, 14023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_14144_14160(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 14144, 14160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_14175_14190(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 14175, 14190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_14101_14191(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                resultPlace)
                {
                    var return_v = this_param.VisitAwaitExpression((Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression)node, resultPlace: resultPlace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 14101, 14191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_14293_14308(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 14293, 14308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10447_14282_14309(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 14282, 14309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_14348_14365(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Update(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 14348, 14365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10447_14384_14401(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.StatementList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 14384, 14401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 13512, 14413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 13512, 14413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitAwaitExpression(BoundAwaitExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 14425, 14660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 14612, 14649);

                throw f_10447_14618_14648();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 14425, 14660);

                System.Exception
                f_10447_14618_14648()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 14618, 14648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 14425, 14660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 14425, 14660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitBadExpression(BoundBadExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 14672, 14846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 14823, 14835);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 14672, 14846);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 14672, 14846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 14672, 14846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundBlock VisitAwaitExpression(BoundAwaitExpression node, BoundExpression resultPlace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 14858, 17817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 14978, 15035);

                var
                expression = (BoundExpression)f_10447_15012_15034(this, f_10447_15018_15033(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15049, 15124);

                var
                awaitablePlaceholder = f_10447_15076_15123(f_10447_15076_15094(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15140, 15275) || true) && (awaitablePlaceholder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 15140, 15275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15206, 15260);

                    f_10447_15206_15259(_placeholderMap, awaitablePlaceholder, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 15140, 15275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15291, 15501);

                var
                getAwaiter = (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 15308, 15336) || ((f_10447_15308_15336(f_10447_15308_15326(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 15356, 15427)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 15447, 15500))) ? f_10447_15356_15427(this, expression, null, WellKnownMemberNames.GetAwaiter) : (BoundExpression)f_10447_15464_15500(this, f_10447_15470_15499(f_10447_15470_15488(node)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15517, 15567);

                resultPlace = (BoundExpression)f_10447_15548_15566(this, resultPlace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15581, 15654);

                MethodSymbol
                getResult = f_10447_15606_15653(this, f_10447_15624_15652(f_10447_15624_15642(node)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15668, 15819);

                MethodSymbol
                isCompletedMethod = (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 15701, 15749) || ((((object)f_10447_15710_15740(f_10447_15710_15728(node)) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 15752, 15811)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 15814, 15818))) ? f_10447_15752_15811(this, f_10447_15770_15810(f_10447_15770_15800(f_10447_15770_15788(node)))) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15833, 15872);

                TypeSymbol
                type = f_10447_15851_15871(this, f_10447_15861_15870(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15888, 16014) || true) && (awaitablePlaceholder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 15888, 16014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 15954, 15999);

                    f_10447_15954_15998(_placeholderMap, awaitablePlaceholder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 15888, 16014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 16237, 16327);

                f_10447_16237_16326(f_10447_16250_16296(node.Syntax, SyntaxKind.AwaitExpression) || (DynAbs.Tracing.TraceSender.Expression_False(10447, 16250, 16325) || f_10447_16300_16325(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 16343, 16454);

                var
                awaiterTemp = f_10447_16361_16453(F, f_10447_16380_16395(getAwaiter), syntax: node.Syntax, kind: SynthesizedLocalKind.Awaiter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 16468, 17138);

                var
                awaitIfIncomplete = f_10447_16492_17137(F, f_10447_16587_16684(                    // temp $awaiterTemp = <expr>.GetAwaiter();
                                    F, f_10447_16626_16646(F, awaiterTemp), getAwaiter), f_10447_16838_16861(
                                    // hidden sequence point facilitates EnC method remapping, see explanation on SynthesizedLocalKind.Awaiter:
                                    F), f_10447_16950_17136(
                                    // if(!($awaiterTemp.IsCompleted)) { ... }
                                    F, condition: f_10447_16992_17053(F, f_10447_16998_17052(this, awaiterTemp, isCompletedMethod)), thenClause: f_10447_17092_17135(this, awaiterTemp)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 17152, 17378);

                BoundExpression
                getResultCall = f_10447_17184_17377(this, f_10447_17223_17243(F, awaiterTemp), getResult, WellKnownMemberNames.GetResult, resultsDiscarded: resultPlace == null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 17454, 17648);

                BoundStatement
                getResultStatement = (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 17490, 17531) || ((resultPlace != null && (DynAbs.Tracing.TraceSender.Expression_True(10447, 17490, 17531) && !f_10447_17514_17531(type)) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 17551, 17591)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 17611, 17647))) ? f_10447_17551_17591(F, resultPlace, getResultCall) : f_10447_17611_17647(F, getResultCall)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 17664, 17806);

                return f_10447_17671_17805(F, f_10447_17697_17731(awaiterTemp), awaitIfIncomplete, getResultStatement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 14858, 17817);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_15018_15033(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15018, 15033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10447_15012_15034(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15012, 15034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10447_15076_15094(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15076, 15094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder?
                f_10447_15076_15123(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.AwaitableInstancePlaceholder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15076, 15123);
                    return return_v;
                }


                int
                f_10447_15206_15259(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                key, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15206, 15259);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10447_15308_15326(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15308, 15326);
                    return return_v;
                }


                bool
                f_10447_15308_15336(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.IsDynamic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15308, 15336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_15356_15427(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, string
                methodName)
                {
                    var return_v = this_param.MakeCallMaybeDynamic(receiver, methodSymbol, methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15356, 15427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10447_15470_15488(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15470, 15488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10447_15470_15499(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetAwaiter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15470, 15499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10447_15464_15500(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15464, 15500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10447_15548_15566(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15548, 15566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10447_15624_15642(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15624, 15642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10447_15624_15652(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15624, 15652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10447_15606_15653(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15606, 15653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10447_15710_15728(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15710, 15728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                f_10447_15710_15740(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15710, 15740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10447_15770_15788(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15770, 15788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10447_15770_15800(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15770, 15800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10447_15770_15810(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15770, 15810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10447_15752_15811(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15752, 15811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_15861_15870(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 15861, 15870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_15851_15871(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15851, 15871);
                    return return_v;
                }


                bool
                f_10447_15954_15998(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                key)
                {
                    var return_v = this_param.Remove((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 15954, 15998);
                    return return_v;
                }


                bool
                f_10447_16250_16296(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16250, 16296);
                    return return_v;
                }


                bool
                f_10447_16300_16325(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 16300, 16325);
                    return return_v;
                }


                int
                f_10447_16237_16326(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16237, 16326);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10447_16380_16395(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 16380, 16395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10447_16361_16453(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = this_param.SynthesizedLocal(type, syntax: syntax, kind: kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16361, 16453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_16626_16646(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16626, 16646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_16587_16684(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16587, 16684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_16838_16861(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16838, 16861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_16998_17052(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                awaiterTemp, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getIsCompletedMethod)
                {
                    var return_v = this_param.GenerateGetIsCompleted(awaiterTemp, getIsCompletedMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16998, 17052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_16992_17053(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Not(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16992, 17053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_17092_17135(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                awaiterTemp)
                {
                    var return_v = this_param.GenerateAwaitForIncompleteTask(awaiterTemp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17092, 17135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_16950_17136(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundBlock
                thenClause)
                {
                    var return_v = this_param.If(condition: condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16950, 17136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_16492_17137(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 16492, 17137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_17223_17243(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17223, 17243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_17184_17377(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, string
                methodName, bool
                resultsDiscarded)
                {
                    var return_v = this_param.MakeCallMaybeDynamic((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, methodSymbol, methodName, resultsDiscarded: resultsDiscarded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17184, 17377);
                    return return_v;
                }


                bool
                f_10447_17514_17531(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17514, 17531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_17551_17591(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17551, 17591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_17611_17647(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17611, 17647);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_17697_17731(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17697, 17731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_17671_17805(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 17671, 17805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 14858, 17817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 14858, 17817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAwaitableValuePlaceholder(BoundAwaitableValuePlaceholder node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 17829, 17987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 17947, 17976);

                return f_10447_17954_17975(_placeholderMap, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 17829, 17987);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_17954_17975(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 17954, 17975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 17829, 17987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 17829, 17987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeCallMaybeDynamic(
                    BoundExpression receiver,
                    MethodSymbol methodSymbol = null,
                    string methodName = null,
                    bool resultsDiscarded = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 17999, 19178);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 18238, 18575) || true) && ((object)methodSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 18238, 18575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 18337, 18368);

                    f_10447_18337_18367(receiver != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 18388, 18560);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 18395, 18416) || ((f_10447_18395_18416(methodSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 18440, 18505)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 18529, 18559))) ? f_10447_18440_18505(F, f_10447_18453_18480(methodSymbol), methodSymbol, receiver) : f_10447_18529_18559(F, receiver, methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 18238, 18575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 18616, 18649);

                f_10447_18616_18648(methodName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 18663, 19167);

                return f_10447_18670_19151(_dynamicFactory, methodName, receiver, typeArgumentsWithAnnotations: ImmutableArray<TypeWithAnnotations>.Empty, loweredArguments: ImmutableArray<BoundExpression>.Empty, argumentNames: ImmutableArray<string>.Empty, refKinds: ImmutableArray<RefKind>.Empty, hasImplicitReceiver: false, resultDiscarded: resultsDiscarded).ToExpression();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 17999, 19178);

                int
                f_10447_18337_18367(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 18337, 18367);
                    return 0;
                }


                bool
                f_10447_18395_18416(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 18395, 18416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_18453_18480(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 18453, 18480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_18440_18505(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 18440, 18505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10447_18529_18559(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 18529, 18559);
                    return return_v;
                }


                int
                f_10447_18616_18648(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 18616, 18648);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10447_18670_19151(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, bool
                hasImplicitReceiver, bool
                resultDiscarded)
                {
                    var return_v = this_param.MakeDynamicMemberInvocation(name, loweredReceiver, typeArgumentsWithAnnotations: typeArgumentsWithAnnotations, loweredArguments: loweredArguments, argumentNames: argumentNames, refKinds: refKinds, hasImplicitReceiver: hasImplicitReceiver, resultDiscarded: resultDiscarded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 18670, 19151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 17999, 19178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 17999, 19178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression GenerateGetIsCompleted(LocalSymbol awaiterTemp, MethodSymbol getIsCompletedMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 19190, 19957);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 19321, 19872) || true) && (f_10447_19325_19353(f_10447_19325_19341(awaiterTemp)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 19321, 19872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 19387, 19857);

                    return f_10447_19394_19841(_dynamicFactory, f_10447_19454_19629(_dynamicFactory, f_10447_19517_19537(F, awaiterTemp), WellKnownMemberNames.IsCompleted, false).ToExpression(), isExplicit: true, isArrayIndex: false, isChecked: false, resultType: f_10447_19799_19840(F, SpecialType.System_Boolean)).ToExpression();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 19321, 19872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 19888, 19946);

                return f_10447_19895_19945(F, f_10447_19902_19922(F, awaiterTemp), getIsCompletedMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 19190, 19957);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_19325_19341(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 19325, 19341);
                    return return_v;
                }


                bool
                f_10447_19325_19353(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 19325, 19353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_19517_19537(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 19517, 19537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10447_19454_19629(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                loweredReceiver, string
                name, bool
                resultIndexed)
                {
                    var return_v = this_param.MakeDynamicGetMember((Microsoft.CodeAnalysis.CSharp.BoundExpression)loweredReceiver, name, resultIndexed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 19454, 19629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_19799_19840(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 19799, 19840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10447_19394_19841(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredOperand, bool
                isExplicit, bool
                isArrayIndex, bool
                isChecked, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicConversion(loweredOperand, isExplicit: isExplicit, isArrayIndex: isArrayIndex, isChecked: isChecked, resultType: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 19394, 19841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_19902_19922(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 19902, 19922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10447_19895_19945(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 19895, 19945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 19190, 19957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 19190, 19957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundBlock GenerateAwaitForIncompleteTask(LocalSymbol awaiterTemp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 19969, 22676);
                int stateNumber = default(int);
                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol resumeLabel = default(Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 20068, 20136);

                f_10447_20068_20135(this, out stateNumber, out resumeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 20152, 20317);

                TypeSymbol
                awaiterFieldType = (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 20182, 20220) || ((f_10447_20182_20220(f_10447_20182_20198(awaiterTemp)) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 20240, 20280)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 20300, 20316))) ? f_10447_20240_20280(F, SpecialType.System_Object) : f_10447_20300_20316(awaiterTemp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 20333, 20394);

                FieldSymbol
                awaiterField = f_10447_20360_20393(this, awaiterFieldType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 20410, 20472);

                var
                blockBuilder = f_10447_20429_20471()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 20488, 20620);

                f_10447_20488_20619(
                            blockBuilder, f_10447_20584_20618(this, stateNumber));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 20636, 20791);

                f_10447_20636_20790(
                            blockBuilder, f_10447_20746_20789(                    // Emit await yield point to be injected into PDB
                                    F, NoOpStatementFlavor.AwaitYieldPoint));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 20807, 21213);

                f_10447_20807_21212(
                            blockBuilder, f_10447_20903_21211(                    // this.<>t__awaiter = $awaiterTemp
                                    F, f_10447_20938_20969(F, f_10447_20946_20954(F), awaiterField), (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 20992, 21085) || (((f_10447_20993_21084(f_10447_21011_21028(awaiterField), f_10447_21030_21046(awaiterTemp), TypeCompareKind.ConsiderEverything2))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 21113, 21133)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 21161, 21210))) ? f_10447_21113_21133(F, awaiterTemp) : f_10447_21161_21210(F, awaiterFieldType, f_10447_21189_21209(F, awaiterTemp))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 21229, 21415);

                f_10447_21229_21414(
                            blockBuilder, (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 21246, 21274) || ((f_10447_21246_21274(f_10447_21246_21262(awaiterTemp)) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 21294, 21338)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 21358, 21413))) ? f_10447_21294_21338(this, awaiterTemp) : f_10447_21358_21413(this, f_10447_21383_21399(awaiterTemp), awaiterTemp));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 21431, 21489);

                f_10447_21431_21488(
                            blockBuilder, f_10447_21466_21487(this, false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 21505, 21562);

                f_10447_21505_21561(
                            blockBuilder, f_10447_21540_21560(F, resumeLabel));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 21578, 21735);

                f_10447_21578_21734(
                            blockBuilder, f_10447_21689_21733(                    // Emit await resume point to be injected into PDB
                                    F, NoOpStatementFlavor.AwaitResumePoint));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 21751, 22270);

                f_10447_21751_22269(
                            blockBuilder, f_10447_21951_22268(                    // $awaiterTemp = this.<>t__awaiter   or   $awaiterTemp = (AwaiterType)this.<>t__awaiter
                                                                                  // $this.<>t__awaiter = null;
                                    F, f_10447_21986_22006(F, awaiterTemp), (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 22029, 22120) || ((f_10447_22029_22120(f_10447_22047_22063(awaiterTemp), f_10447_22065_22082(awaiterField), TypeCompareKind.ConsiderEverything2) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 22148, 22179)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 22207, 22267))) ? f_10447_22148_22179(F, f_10447_22156_22164(F), awaiterField) : f_10447_22207_22267(F, f_10447_22217_22233(awaiterTemp), f_10447_22235_22266(F, f_10447_22243_22251(F), awaiterField))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 22286, 22404);

                f_10447_22286_22403(
                            blockBuilder, f_10447_22321_22402(F, f_10447_22334_22365(F, f_10447_22342_22350(F), awaiterField), f_10447_22367_22401(F, f_10447_22383_22400(awaiterField))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 22420, 22599);

                f_10447_22420_22598(
                            blockBuilder, f_10447_22533_22597(this, StateMachineStates.NotStartedStateMachine));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 22615, 22665);

                return f_10447_22622_22664(F, f_10447_22630_22663(blockBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 19969, 22676);

                int
                f_10447_20068_20135(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, out int
                stateNumber, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                resumeLabel)
                {
                    this_param.AddState(out stateNumber, out resumeLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20068, 20135);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_20182_20198(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 20182, 20198);
                    return return_v;
                }


                bool
                f_10447_20182_20220(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20182, 20220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_20240_20280(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20240, 20280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_20300_20316(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 20300, 20316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10447_20360_20393(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                awaiterType)
                {
                    var return_v = this_param.GetAwaiterField(awaiterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20360, 20393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_20429_20471()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20429, 20471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_20584_20618(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, int
                stateNumber)
                {
                    var return_v = this_param.GenerateSetBothStates(stateNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20584, 20618);
                    return return_v;
                }


                int
                f_10447_20488_20619(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20488, 20619);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_20746_20789(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                noOpStatementFlavor)
                {
                    var return_v = this_param.NoOp(noOpStatementFlavor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20746, 20789);
                    return return_v;
                }


                int
                f_10447_20636_20790(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20636, 20790);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_20946_20954(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20946, 20954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_20938_20969(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20938, 20969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_21011_21028(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 21011, 21028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_21030_21046(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 21030, 21046);
                    return return_v;
                }


                bool
                f_10447_20993_21084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20993, 21084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_21113_21133(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21113, 21133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_21189_21209(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21189, 21209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_21161_21210(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21161, 21210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_20903_21211(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20903, 21211);
                    return return_v;
                }


                int
                f_10447_20807_21212(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 20807, 21212);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_21246_21262(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 21246, 21262);
                    return return_v;
                }


                bool
                f_10447_21246_21274(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21246, 21274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_21294_21338(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                awaiterTemp)
                {
                    var return_v = this_param.GenerateAwaitOnCompletedDynamic(awaiterTemp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21294, 21338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_21383_21399(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 21383, 21399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_21358_21413(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                loweredAwaiterType, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                awaiterTemp)
                {
                    var return_v = this_param.GenerateAwaitOnCompleted(loweredAwaiterType, awaiterTemp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21358, 21413);
                    return return_v;
                }


                int
                f_10447_21229_21414(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21229, 21414);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_21466_21487(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, bool
                finished)
                {
                    var return_v = this_param.GenerateReturn(finished);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21466, 21487);
                    return return_v;
                }


                int
                f_10447_21431_21488(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21431, 21488);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10447_21540_21560(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21540, 21560);
                    return return_v;
                }


                int
                f_10447_21505_21561(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21505, 21561);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_21689_21733(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                noOpStatementFlavor)
                {
                    var return_v = this_param.NoOp(noOpStatementFlavor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21689, 21733);
                    return return_v;
                }


                int
                f_10447_21578_21734(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21578, 21734);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_21986_22006(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21986, 22006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_22047_22063(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 22047, 22063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_22065_22082(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 22065, 22082);
                    return return_v;
                }


                bool
                f_10447_22029_22120(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22029, 22120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_22156_22164(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22156, 22164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_22148_22179(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22148, 22179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_22217_22233(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 22217, 22233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_22243_22251(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22243, 22251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_22235_22266(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22235, 22266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_22207_22267(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                arg)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22207, 22267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_21951_22268(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21951, 22268);
                    return return_v;
                }


                int
                f_10447_21751_22269(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 21751, 22269);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_22342_22350(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22342, 22350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_22334_22365(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22334, 22365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_22383_22400(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 22383, 22400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_22367_22401(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.NullOrDefault(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22367, 22401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_22321_22402(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22321, 22402);
                    return return_v;
                }


                int
                f_10447_22286_22403(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22286, 22403);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_22533_22597(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, int
                stateNumber)
                {
                    var return_v = this_param.GenerateSetBothStates(stateNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22533, 22597);
                    return return_v;
                }


                int
                f_10447_22420_22598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22420, 22598);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_22630_22663(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22630, 22663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_22622_22664(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 22622, 22664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 19969, 22676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 19969, 22676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement GenerateAwaitOnCompletedDynamic(LocalSymbol awaiterTemp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 22688, 26663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 23505, 23689);

                var
                criticalNotifyCompletedTemp = f_10447_23539_23688(F, f_10447_23576_23664(F, WellKnownType.System_Runtime_CompilerServices_ICriticalNotifyCompletion), null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 23705, 23874);

                var
                notifyCompletionTemp = f_10447_23732_23873(F, f_10447_23769_23849(F, WellKnownType.System_Runtime_CompilerServices_INotifyCompletion), null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 23890, 23999);

                LocalSymbol
                thisTemp = (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 23913, 23955) || (((f_10447_23914_23936(f_10447_23914_23927(F)) == TypeKind.Class) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 23958, 23991)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 23994, 23998))) ? f_10447_23958_23991(F, f_10447_23977_23990(F)) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 24015, 24077);

                var
                blockBuilder = f_10447_24034_24076()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 24093, 24374);

                f_10447_24093_24373(
                            blockBuilder, f_10447_24128_24372(F, f_10447_24163_24199(F, criticalNotifyCompletedTemp), f_10447_24311_24371(                        // Use reference conversion rather than dynamic conversion:
                                        F, f_10447_24316_24336(F, awaiterTemp), f_10447_24338_24370(criticalNotifyCompletedTemp))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 24390, 24519) || true) && (thisTemp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 24390, 24519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 24444, 24504);

                    f_10447_24444_24503(blockBuilder, f_10447_24461_24502(F, f_10447_24474_24491(F, thisTemp), f_10447_24493_24501(F)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 24390, 24519);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 24535, 26298);

                f_10447_24535_26297(
                            blockBuilder, f_10447_24570_26296(F, condition: f_10447_24608_24701(F, f_10447_24622_24658(F, criticalNotifyCompletedTemp), f_10447_24660_24700(F, f_10447_24667_24699(criticalNotifyCompletedTemp))), thenClause: f_10447_24738_25766(F, f_10447_24772_24815(notifyCompletionTemp), f_10447_24842_25131(F, f_10447_24885_24914(F, notifyCompletionTemp), f_10447_25042_25130(                                // Use reference conversion rather than dynamic conversion:
                                                F, f_10447_25052_25077(notifyCompletionTemp), f_10447_25079_25099(F, awaiterTemp), Conversion.ExplicitReference)), f_10447_25158_25592(F, f_10447_25210_25591(F, f_10447_25251_25294(F, f_10447_25259_25267(F), _asyncMethodBuilderField), f_10447_25329_25508(_asyncMethodBuilderMemberCollection.AwaitOnCompleted, f_10447_25430_25455(notifyCompletionTemp), f_10447_25494_25507(f_10447_25494_25502(F))), f_10447_25543_25572(F, notifyCompletionTemp), f_10447_25574_25590(F, thisTemp))), f_10447_25619_25765(F, f_10447_25662_25691(F, notifyCompletionTemp), f_10447_25722_25764(F, f_10447_25738_25763(notifyCompletionTemp)))), elseClauseOpt: f_10447_25806_26295(F, f_10447_25840_26294(F, f_10447_25892_26293(F, f_10447_25933_25976(F, f_10447_25941_25949(F), _asyncMethodBuilderField), f_10447_26011_26203(_asyncMethodBuilderMemberCollection.AwaitUnsafeOnCompleted, f_10447_26118_26150(criticalNotifyCompletedTemp), f_10447_26189_26202(f_10447_26189_26197(F))), f_10447_26238_26274(F, criticalNotifyCompletedTemp), f_10447_26276_26292(F, thisTemp))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 26314, 26495);

                f_10447_26314_26494(
                            blockBuilder, f_10447_26349_26493(F, f_10447_26384_26420(F, criticalNotifyCompletedTemp), f_10447_26443_26492(F, f_10447_26459_26491(criticalNotifyCompletedTemp))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 26511, 26652);

                return f_10447_26518_26651(F, f_10447_26544_26598(criticalNotifyCompletedTemp, thisTemp), f_10447_26617_26650(blockBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 22688, 26663);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_23576_23664(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 23576, 23664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10447_23539_23688(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode?
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 23539, 23688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_23769_23849(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 23769, 23849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10447_23732_23873(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode?
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 23732, 23873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10447_23914_23927(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 23914, 23927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10447_23914_23936(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 23914, 23936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_23977_23990(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 23977, 23990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10447_23958_23991(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 23958, 23991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_24034_24076()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24034, 24076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_24163_24199(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24163, 24199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_24316_24336(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24316, 24336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_24338_24370(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 24338, 24370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                f_10447_24311_24371(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.As((Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24311, 24371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_24128_24372(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24128, 24372);
                    return return_v;
                }


                int
                f_10447_24093_24373(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24093, 24373);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_24474_24491(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24474, 24491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_24493_24501(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24493, 24501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_24461_24502(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24461, 24502);
                    return return_v;
                }


                int
                f_10447_24444_24503(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24444, 24503);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_24622_24658(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24622, 24658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_24667_24699(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 24667, 24699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_24660_24700(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24660, 24700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10447_24608_24701(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24608, 24701);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_24772_24815(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24772, 24815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_24885_24914(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24885, 24914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_25052_25077(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 25052, 25077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_25079_25099(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25079, 25099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_25042_25130(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25042, 25130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_24842_25131(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24842, 25131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_25259_25267(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25259, 25267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_25251_25294(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25251, 25294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_25430_25455(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 25430, 25455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_25494_25502(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25494, 25502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_25494_25507(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 25494, 25507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10447_25329_25508(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25329, 25508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_25543_25572(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25543, 25572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_25574_25590(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                thisTempOpt)
                {
                    var return_v = this_param.This(thisTempOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25574, 25590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10447_25210_25591(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg0, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg1)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25210, 25591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_25158_25592(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25158, 25592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_25662_25691(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25662, 25691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_25738_25763(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 25738, 25763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_25722_25764(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.NullOrDefault(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25722, 25764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_25619_25765(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25619, 25765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_24738_25766(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24738, 25766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_25941_25949(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25941, 25949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_25933_25976(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25933, 25976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_26118_26150(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 26118, 26150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_26189_26197(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26189, 26197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_26189_26202(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 26189, 26202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10447_26011_26203(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26011, 26203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_26238_26274(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26238, 26274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_26276_26292(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                thisTempOpt)
                {
                    var return_v = this_param.This(thisTempOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26276, 26292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10447_25892_26293(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg0, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg1)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25892, 26293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_25840_26294(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25840, 26294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_25806_26295(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 25806, 26295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10447_24570_26296(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundBlock
                thenClause, Microsoft.CodeAnalysis.CSharp.BoundBlock
                elseClauseOpt)
                {
                    var return_v = this_param.If(condition: (Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause, elseClauseOpt: (Microsoft.CodeAnalysis.CSharp.BoundStatement)elseClauseOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24570, 26296);
                    return return_v;
                }


                int
                f_10447_24535_26297(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 24535, 26297);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_26384_26420(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26384, 26420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_26459_26491(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 26459, 26491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_26443_26492(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.NullOrDefault(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26443, 26492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_26349_26493(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26349, 26493);
                    return return_v;
                }


                int
                f_10447_26314_26494(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26314, 26494);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_26544_26598(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                first, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                secondOpt)
                {
                    var return_v = SingletonOrPair(first, secondOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26544, 26598);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10447_26617_26650(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26617, 26650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_26518_26651(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 26518, 26651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 22688, 26663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 22688, 26663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement GenerateAwaitOnCompleted(TypeSymbol loweredAwaiterType, LocalSymbol awaiterTemp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 26675, 28577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 27011, 27120);

                LocalSymbol
                thisTemp = (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 27034, 27076) || (((f_10447_27035_27057(f_10447_27035_27048(F)) == TypeKind.Class) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 27079, 27112)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 27115, 27119))) ? f_10447_27079_27112(F, f_10447_27098_27111(F)) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 27136, 27186);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 27200, 27500);

                var
                useUnsafeOnCompleted = f_10447_27227_27488(f_10447_27227_27252(f_10447_27227_27240(F)), loweredAwaiterType, f_10447_27343_27446(f_10447_27343_27356(F), WellKnownType.System_Runtime_CompilerServices_ICriticalNotifyCompletion), ref useSiteDiagnostics).IsImplicit
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 27516, 27752);

                var
                onCompleted = f_10447_27534_27751(((DynAbs.Tracing.TraceSender.Conditional_F1(10447, 27535, 27555) || ((useUnsafeOnCompleted && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 27575, 27633)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 27653, 27705))) ? _asyncMethodBuilderMemberCollection.AwaitUnsafeOnCompleted : _asyncMethodBuilderMemberCollection.AwaitOnCompleted), loweredAwaiterType, f_10447_27737_27750(f_10447_27737_27745(F)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 27766, 27983) || true) && (_asyncMethodBuilderMemberCollection.CheckGenericMethodConstraints)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 27766, 27983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 27869, 27968);

                    f_10447_27869_27967(onCompleted, f_10447_27898_27923(f_10447_27898_27911(F)), f_10447_27925_27933(F), f_10447_27935_27948(F), this.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 27766, 27983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 27999, 28210);

                BoundExpression
                result =
                f_10447_28041_28209(F, f_10447_28070_28113(F, f_10447_28078_28086(F), _asyncMethodBuilderField), onCompleted, f_10447_28170_28190(F, awaiterTemp), f_10447_28192_28208(F, thisTemp))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 28226, 28513) || true) && (thisTemp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 28226, 28513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 28280, 28498);

                    result = f_10447_28289_28497(F, f_10447_28322_28353(thisTemp), f_10447_28376_28467(f_10447_28415_28466(F, f_10447_28438_28455(F, thisTemp), f_10447_28457_28465(F))), result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 28226, 28513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 28529, 28566);

                return f_10447_28536_28565(F, result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 26675, 28577);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10447_27035_27048(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27035, 27048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10447_27035_27057(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27035, 27057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_27098_27111(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27098, 27111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10447_27079_27112(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 27079, 27112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10447_27227_27240(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27227, 27240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10447_27227_27252(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27227, 27252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10447_27343_27356(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27343, 27356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10447_27343_27446(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 27343, 27446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10447_27227_27488(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 27227, 27488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_27737_27745(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 27737, 27745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10447_27737_27750(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27737, 27750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10447_27534_27751(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 27534, 27751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10447_27898_27911(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27898, 27911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10447_27898_27923(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27898, 27923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10447_27925_27933(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27925, 27933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10447_27935_27948(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 27935, 27948);
                    return return_v;
                }


                bool
                f_10447_27869_27967(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = method.CheckConstraints((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, syntaxNode, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 27869, 27967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_28078_28086(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28078, 28086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10447_28070_28113(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28070, 28113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_28170_28190(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28170, 28190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_28192_28208(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                thisTempOpt)
                {
                    var return_v = this_param.This(thisTempOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28192, 28208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10447_28041_28209(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg0, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg1)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28041, 28209);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_28322_28353(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28322, 28353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_28438_28455(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28438, 28455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10447_28457_28465(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28457, 28465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10447_28415_28466(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28415, 28466);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10447_28376_28467(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28376, 28467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_28289_28497(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28289, 28497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_28536_28565(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28536, 28565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 26675, 28577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 26675, 28577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<LocalSymbol> SingletonOrPair(LocalSymbol first, LocalSymbol secondOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10447, 28589, 28825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 28714, 28814);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10447, 28721, 28740) || (((secondOpt == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10447, 28743, 28771)) || DynAbs.Tracing.TraceSender.Conditional_F3(10447, 28774, 28813))) ? f_10447_28743_28771(first) : f_10447_28774_28813(first, secondOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10447, 28589, 28825);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_28743_28771(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28743, 28771);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10447_28774_28813(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 28774, 28813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 28589, 28825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 28589, 28825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitReturnStatement(BoundReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10447, 28837, 29329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 28942, 29270) || true) && (f_10447_28946_28964(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10447, 28942, 29270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 29006, 29071);

                    f_10447_29006_29070(f_10447_29019_29069(_method, f_10447_29055_29068(F)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 29089, 29255);

                    return f_10447_29096_29254(F, f_10447_29126_29206(F, f_10447_29139_29161(F, _exprRetValue), f_10447_29180_29205(this, f_10447_29186_29204(node))), f_10447_29229_29253(F, _exprReturnLabel));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10447, 28942, 29270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10447, 29286, 29318);

                return f_10447_29293_29317(F, _exprReturnLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10447, 28837, 29329);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10447_28946_28964(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 28946, 28964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10447_29055_29068(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 29055, 29068);
                    return return_v;
                }


                bool
                f_10447_29019_29069(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = method.IsAsyncReturningGenericTask(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29019, 29069);
                    return return_v;
                }


                int
                f_10447_29006_29070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29006, 29070);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10447_29139_29161(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29139, 29161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10447_29186_29204(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 29186, 29204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10447_29180_29205(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29180, 29205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10447_29126_29206(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundNode
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29126, 29206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10447_29229_29253(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29229, 29253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10447_29096_29254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29096, 29254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10447_29293_29317(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 29293, 29317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10447, 28837, 29329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 28837, 29329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AsyncMethodToStateMachineRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10447, 731, 29365);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10447, 731, 29365);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10447, 731, 29365);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10447, 731, 29365);

        Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
        f_10447_3900_3929(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, string
        prefix)
        {
            var return_v = this_param.GenerateLabel(prefix);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 3900, 3929);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
        f_10447_3957_3985(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, string
        prefix)
        {
            var return_v = this_param.GenerateLabel(prefix);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 3957, 3985);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10447_4053_4066(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 4053, 4066);
            return return_v;
        }


        bool
        f_10447_4018_4067(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = method.IsAsyncReturningGenericTask(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 4018, 4067);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10447_4161_4169(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 4161, 4169);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        f_10447_4087_4221(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, Microsoft.CodeAnalysis.SyntaxNode
        syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
        kind)
        {
            var return_v = this_param.SynthesizedLocal(type, syntax: syntax, kind: kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 4087, 4221);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
        f_10447_4280_4332(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        factory, int
        methodOrdinal)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory(factory, methodOrdinal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 4280, 4332);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
        f_10447_4364_4475(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 4364, 4475);
            return return_v;
        }


        int?
        f_10447_4507_4549_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10447, 4507, 4549);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10447_4589_4649()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10447, 4589, 4649);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        f_10447_3514_3515_C(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10447, 2838, 4661);
            return return_v;
        }

    }
}
