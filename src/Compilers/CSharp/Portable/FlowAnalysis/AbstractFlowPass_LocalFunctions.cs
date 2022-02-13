// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class AbstractFlowPass<TLocalState, TLocalFunctionState>
    {
        internal abstract class AbstractLocalFunctionState
        {
            public TLocalState StateFromBottom;

            public TLocalState StateFromTop;

            public AbstractLocalFunctionState(TLocalState stateFromBottom, TLocalState stateFromTop)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10879, 1578, 1794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 1015, 1030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 1549, 1561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 1822, 1837);
                    this.Visited = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 1699, 1733);

                    StateFromBottom = stateFromBottom;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 1751, 1779);

                    StateFromTop = stateFromTop;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10879, 1578, 1794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10879, 1578, 1794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10879, 1578, 1794);
                }
            }

            public bool Visited;

            static AbstractLocalFunctionState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10879, 431, 1849);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10879, 431, 1849);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10879, 431, 1849);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10879, 431, 1849);
        }

        protected abstract TLocalFunctionState CreateLocalFunctionState(LocalFunctionSymbol symbol);

        private SmallDictionary<LocalFunctionSymbol, TLocalFunctionState>? _localFuncVarUsages;

        protected TLocalFunctionState GetOrCreateLocalFuncUsages(LocalFunctionSymbol localFunc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10879, 2071, 2558);
                TLocalFunctionState usages = default(TLocalFunctionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2183, 2271);

                if (_localFuncVarUsages is null)
                    DynAbs.Tracing.TraceSender.TraceEnterExpression(10879, 2183, 2271);

                _localFuncVarUsages ??= f_10879_2207_2270();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2287, 2519) || true) && (!f_10879_2292_2367(_localFuncVarUsages, localFunc, out usages))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 2287, 2519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2401, 2446);

                    usages = f_10879_2410_2445(this, localFunc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2464, 2504);

                    _localFuncVarUsages[localFunc] = usages;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 2287, 2519);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2533, 2547);

                return usages;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10879, 2071, 2558);

                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol, TLocalFunctionState>
                f_10879_2207_2270()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol, TLocalFunctionState>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 2207, 2270);
                    return return_v;
                }


                bool
                f_10879_2292_2367(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                key, out TLocalFunctionState?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 2292, 2367);
                    return return_v;
                }


                TLocalFunctionState
                f_10879_2410_2445(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol)
                {
                    var return_v = this_param.CreateLocalFunctionState(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 2410, 2445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10879, 2071, 2558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10879, 2071, 2558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode? VisitLocalFunctionStatement(BoundLocalFunctionStatement localFunc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10879, 2570, 6644);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2688, 2891) || true) && (f_10879_2692_2717(f_10879_2692_2708(localFunc)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 2688, 2891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2864, 2876);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 2688, 2891);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2907, 2942);

                var
                oldSymbol = this.CurrentSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2956, 2995);

                var
                localFuncSymbol = f_10879_2978_2994(localFunc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3009, 3046);

                this.CurrentSymbol = localFuncSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3062, 3093);

                var
                oldPending = f_10879_3079_3092(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3382, 3410);

                var
                savedState = this.State
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3424, 3453);

                this.State = f_10879_3437_3452(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3469, 3534);

                Optional<TLocalState>
                savedNonMonotonicState = NonMonotonicState
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3548, 3665) || true) && (_nonMonotonicTransfer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 3548, 3665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3607, 3650);

                    NonMonotonicState = f_10879_3627_3649(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 3548, 3665);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3681, 3762) || true) && (f_10879_3685_3716_M(!localFunc.WasCompilerGenerated))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 3681, 3762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 3718, 3762);

                    f_10879_3718_3761(this, f_10879_3734_3760(localFuncSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 3681, 3762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4032, 4101);

                var
                localFunctionState = f_10879_4057_4100(this, localFuncSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4115, 4184);

                var
                savedLocalFunctionState = f_10879_4145_4183(this, localFunctionState)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4200, 4232);

                var
                oldPending2 = f_10879_4218_4231(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4408, 4550) || true) && (f_10879_4412_4438(localFuncSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 4408, 4550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4472, 4535);

                    f_10879_4472_4534(f_10879_4472_4487(), f_10879_4492_4533(null, this.State, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 4408, 4550);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4566, 4594);

                f_10879_4566_4593(this, f_10879_4578_4592(localFunc));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4608, 4636);

                f_10879_4608_4635(this, oldPending2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4705, 4768);

                ImmutableArray<PendingBranch>
                pendingReturns = f_10879_4752_4767(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4782, 4809);

                f_10879_4782_4808(this, oldPending);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4825, 4851);

                Location?
                location = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4867, 5003) || true) && (f_10879_4871_4914_M(!localFuncSymbol.Locations.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 4867, 5003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 4948, 4988);

                    location = f_10879_4959_4984(localFuncSymbol)[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 4867, 5003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5019, 5091);

                f_10879_5019_5090(this, f_10879_5035_5061(localFuncSymbol), localFunc.Syntax, location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5185, 5216);

                var
                stateAtReturn = this.State
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5230, 5775);
                    foreach (PendingBranch pending in f_10879_5264_5278_I(pendingReturns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 5230, 5775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5312, 5339);

                        this.State = pending.State;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5357, 5391);

                        BoundNode
                        branch = pending.Branch
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5545, 5700);

                        f_10879_5545_5699(this, f_10879_5561_5587(localFuncSymbol), DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(branch, 10879, 5608, 5622)?.Syntax, (DynAbs.Tracing.TraceSender.Conditional_F1(10879, 5643, 5680) || ((f_10879_5643_5671_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(branch, 10879, 5643, 5671)?.WasCompilerGenerated) == false && DynAbs.Tracing.TraceSender.Conditional_F2(10879, 5683, 5687)) || DynAbs.Tracing.TraceSender.Conditional_F3(10879, 5690, 5698))) ? null : location);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5720, 5760);

                        f_10879_5720_5759(this, ref stateAtReturn, ref this.State);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 5230, 5775);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10879, 1, 546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10879, 1, 546);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 5861, 6463) || true) && (f_10879_5865_6010(this, savedLocalFunctionState, localFunctionState, ref stateAtReturn) && (DynAbs.Tracing.TraceSender.Expression_True(10879, 5865, 6057) && localFunctionState.Visited))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 5861, 6463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6367, 6395);

                    stateChangedAfterUse = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6413, 6448);

                    localFunctionState.Visited = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 5861, 6463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6479, 6503);

                this.State = savedState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6517, 6560);

                NonMonotonicState = savedNonMonotonicState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6574, 6605);

                this.CurrentSymbol = oldSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6621, 6633);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10879, 2570, 6644);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10879_2692_2708(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 2692, 2708);
                    return return_v;
                }


                bool
                f_10879_2692_2717(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 2692, 2717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10879_2978_2994(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 2978, 2994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                f_10879_3079_3092(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 3079, 3092);
                    return return_v;
                }


                TLocalState
                f_10879_3437_3452(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.TopState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 3437, 3452);
                    return return_v;
                }


                TLocalState
                f_10879_3627_3649(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.ReachableBottomState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 3627, 3649);
                    return return_v;
                }


                bool
                f_10879_3685_3716_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 3685, 3716);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10879_3734_3760(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 3734, 3760);
                    return return_v;
                }


                int
                f_10879_3718_3761(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.EnterParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 3718, 3761);
                    return 0;
                }


                TLocalFunctionState
                f_10879_4057_4100(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                localFunc)
                {
                    var return_v = this_param.GetOrCreateLocalFuncUsages(localFunc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4057, 4100);
                    return return_v;
                }


                TLocalFunctionState
                f_10879_4145_4183(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalFunctionState
                state)
                {
                    var return_v = this_param.LocalFunctionStart(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4145, 4183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                f_10879_4218_4231(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4218, 4231);
                    return return_v;
                }


                bool
                f_10879_4412_4438(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 4412, 4438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10879_4472_4487()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 4472, 4487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10879_4492_4533(Microsoft.CodeAnalysis.CSharp.BoundNode
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch(branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4492, 4533);
                    return return_v;
                }


                int
                f_10879_4472_4534(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4472, 4534);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10879_4578_4592(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 4578, 4592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10879_4566_4593(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                node)
                {
                    var return_v = this_param.VisitAlways((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4566, 4593);
                    return return_v;
                }


                int
                f_10879_4608_4635(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4608, 4635);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10879_4752_4767(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.RemoveReturns();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4752, 4767);
                    return return_v;
                }


                int
                f_10879_4782_4808(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 4782, 4808);
                    return 0;
                }


                bool
                f_10879_4871_4914_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 4871, 4914);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10879_4959_4984(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 4959, 4984);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10879_5035_5061(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 5035, 5061);
                    return return_v;
                }


                int
                f_10879_5019_5090(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location?
                location)
                {
                    this_param.LeaveParameters(parameters, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 5019, 5090);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10879_5561_5587(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 5561, 5587);
                    return return_v;
                }


                bool?
                f_10879_5643_5671_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10879, 5643, 5671);
                    return return_v;
                }


                int
                f_10879_5545_5699(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.SyntaxNode?
                syntax, Microsoft.CodeAnalysis.Location?
                location)
                {
                    this_param.LeaveParameters(parameters, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 5545, 5699);
                    return 0;
                }


                bool
                f_10879_5720_5759(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 5720, 5759);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10879_5264_5278_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 5264, 5278);
                    return return_v;
                }


                bool
                f_10879_5865_6010(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalFunctionState
                savedState, TLocalFunctionState
                currentState, ref TLocalState
                stateAtReturn)
                {
                    var return_v = this_param.RecordStateChange(savedState, currentState, ref stateAtReturn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 5865, 6010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10879, 2570, 6644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10879, 2570, 6644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool RecordStateChange(
                    TLocalFunctionState savedState,
                    TLocalFunctionState currentState,
                    ref TLocalState stateAtReturn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10879, 6656, 7573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6848, 6928);

                bool
                anyChanged = f_10879_6866_6927(this, savedState, currentState, ref stateAtReturn)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 6942, 7011);

                anyChanged |= f_10879_6956_7010(this, ref currentState.StateFromTop, ref stateAtReturn);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 7027, 7530) || true) && (NonMonotonicState.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10879, 7027, 7530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 7091, 7127);

                    var
                    value = NonMonotonicState.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 7398, 7433);

                    f_10879_7398_7432(this, ref value, ref stateAtReturn);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 7451, 7515);

                    anyChanged |= f_10879_7465_7514(this, ref currentState.StateFromBottom, ref value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10879, 7027, 7530);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 7544, 7562);

                return anyChanged;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10879, 6656, 7573);

                bool
                f_10879_6866_6927(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalFunctionState
                savedState, TLocalFunctionState
                currentState, ref TLocalState
                stateAtReturn)
                {
                    var return_v = this_param.LocalFunctionEnd(savedState, currentState, ref stateAtReturn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 6866, 6927);
                    return return_v;
                }


                bool
                f_10879_6956_7010(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 6956, 7010);
                    return return_v;
                }


                bool
                f_10879_7398_7432(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Meet(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 7398, 7432);
                    return return_v;
                }


                bool
                f_10879_7465_7514(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10879, 7465, 7514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10879, 6656, 7573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10879, 6656, 7573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual TLocalFunctionState LocalFunctionStart(TLocalFunctionState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10879, 8038, 8046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 8041, 8046);
                return state; DynAbs.Tracing.TraceSender.TraceExitMethod(10879, 8038, 8046);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10879, 8038, 8046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10879, 8038, 8046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool LocalFunctionEnd(
                    TLocalFunctionState savedState,
                    TLocalFunctionState currentState,
                    ref TLocalState stateAtReturn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10879, 8495, 8720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 8696, 8709);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10879, 8495, 8720);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10879, 8495, 8720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10879, 8495, 8720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
