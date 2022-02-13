// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class MethodToStateMachineRewriter : MethodToClassRewriter
    {
        internal readonly MethodSymbol OriginalMethod;

        private readonly bool _useFinalizerBookkeeping;

        protected abstract BoundStatement GenerateReturn(bool finished);

        protected readonly SyntheticBoundNodeFactory F;

        protected readonly FieldSymbol stateField;

        protected readonly LocalSymbol cachedState;

        protected readonly LocalSymbol cachedThis;

        private int _nextState;

        private Dictionary<LabelSymbol, List<int>> _dispatches;

        private bool _hasFinalizerState;

        private int _currentFinalizerState;

        private Dictionary<TypeSymbol, ArrayBuilder<StateMachineFieldSymbol>> _lazyAvailableReusableHoistedFields;

        private int _nextHoistedFieldId;

        private readonly EmptyStructTypeCache _emptyStructTypeCache;

        private readonly IReadOnlySet<Symbol> _hoistedVariables;

        private readonly SynthesizedLocalOrdinalsDispenser _synthesizedLocalOrdinals;

        private int _nextFreeHoistedLocalSlot;

        public MethodToStateMachineRewriter(
                    SyntheticBoundNodeFactory F,
                    MethodSymbol originalMethod,
                    FieldSymbol state,
                    IReadOnlySet<Symbol> hoistedVariables,
                    IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> nonReusableLocalProxies,
                    SynthesizedLocalOrdinalsDispenser synthesizedLocalOrdinals,
                    VariableSlotAllocator slotAllocatorOpt,
                    int nextFreeHoistedLocalSlot,
                    DiagnosticBag diagnostics,
                    bool useFinalizerBookkeeping)
        : base(f_10540_6097_6113_C(slotAllocatorOpt), f_10540_6115_6133(F), diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10540, 5527, 7988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 776, 790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 1137, 1161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 1418, 1419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 1604, 1614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 2096, 2107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 2944, 2954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 2979, 2989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 3357, 3411);
                this._dispatches = f_10540_3371_3411(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 3884, 3909);
                this._hasFinalizerState = true; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 4247, 4274);
                this._currentFinalizerState = -1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 4600, 4635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 4906, 4929);
                this._nextHoistedFieldId = 1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 5091, 5154);
                this._emptyStructTypeCache = f_10540_5115_5154(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 5343, 5360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 5424, 5449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 5472, 5497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6172, 6196);

                f_10540_6172_6195(F != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6210, 6247);

                f_10540_6210_6246(originalMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6261, 6289);

                f_10540_6261_6288(state != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6303, 6349);

                f_10540_6303_6348(nonReusableLocalProxies != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6363, 6397);

                f_10540_6363_6396(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6411, 6450);

                f_10540_6411_6449(hoistedVariables != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6464, 6508);

                f_10540_6464_6507(nextFreeHoistedLocalSlot >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6524, 6535);

                this.F = F;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6549, 6573);

                this.stateField = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6587, 6736);

                this.cachedState = f_10540_6606_6735(F, f_10540_6625_6664(F, SpecialType.System_Int32), syntax: f_10540_6674_6682(F), kind: SynthesizedLocalKind.StateMachineCachedState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6750, 6801);

                _useFinalizerBookkeeping = useFinalizerBookkeeping;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6815, 6860);

                _hasFinalizerState = useFinalizerBookkeeping;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6874, 6911);

                this.OriginalMethod = originalMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6925, 6962);

                _hoistedVariables = hoistedVariables;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 6976, 7029);

                _synthesizedLocalOrdinals = synthesizedLocalOrdinals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7043, 7096);

                _nextFreeHoistedLocalSlot = nextFreeHoistedLocalSlot;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7112, 7247);
                    foreach (var proxy in f_10540_7134_7157_I(nonReusableLocalProxies))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 7112, 7247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7191, 7232);

                        f_10540_7191_7231(this.proxies, proxy.Key, proxy.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 7112, 7247);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10540, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10540, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7335, 7384);

                var
                thisParameter = f_10540_7355_7383(originalMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7398, 7434);

                CapturedSymbolReplacement
                thisProxy
                = default(CapturedSymbolReplacement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7448, 7977) || true) && ((object)thisParameter != null && (DynAbs.Tracing.TraceSender.Expression_True(10540, 7452, 7536) && f_10540_7502_7536(f_10540_7502_7520(thisParameter))) && (DynAbs.Tracing.TraceSender.Expression_True(10540, 7452, 7606) && f_10540_7557_7606(proxies, thisParameter, out thisProxy)) && (DynAbs.Tracing.TraceSender.Expression_True(10540, 7452, 7695) && f_10540_7627_7666(f_10540_7627_7648(f_10540_7627_7640(F))) == OptimizationLevel.Release))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 7448, 7977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7729, 7823);

                    BoundExpression
                    thisProxyReplacement = f_10540_7768_7822(thisProxy, f_10540_7790_7798(F), frameType => F.This())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 7841, 7962);

                    this.cachedThis = f_10540_7859_7961(F, f_10540_7878_7903(thisProxyReplacement), syntax: f_10540_7913_7921(F), kind: SynthesizedLocalKind.FrameCache);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 7448, 7977);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10540, 5527, 7988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 5527, 7988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 5527, 7988);
            }
        }

        protected override bool NeedsProxy(Symbol localOrParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 8000, 8266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 8084, 8189);

                f_10540_8084_8188(f_10540_8097_8118(localOrParameter) == SymbolKind.Local || (DynAbs.Tracing.TraceSender.Expression_False(10540, 8097, 8187) || f_10540_8142_8163(localOrParameter) == SymbolKind.Parameter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 8203, 8255);

                return f_10540_8210_8254(_hoistedVariables, localOrParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 8000, 8266);

                Microsoft.CodeAnalysis.SymbolKind
                f_10540_8097_8118(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 8097, 8118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10540_8142_8163(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 8142, 8163);
                    return return_v;
                }


                int
                f_10540_8084_8188(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 8084, 8188);
                    return 0;
                }


                bool
                f_10540_8210_8254(Roslyn.Utilities.IReadOnlySet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 8210, 8254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 8000, 8266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 8000, 8266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeMap TypeMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 8337, 8398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 8343, 8396);

                    return f_10540_8350_8395(((SynthesizedContainer)f_10540_8373_8386(F)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 8337, 8398);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10540_8373_8386(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.CurrentType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 8373, 8386);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10540_8350_8395(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer?
                    this_param)
                    {
                        var return_v = this_param.TypeMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 8350, 8395);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 8278, 8409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 8278, 8409);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override MethodSymbol CurrentMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 8491, 8524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 8497, 8522);

                    return f_10540_8504_8521(F);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 8491, 8524);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10540_8504_8521(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.CurrentFunction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 8504, 8521);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 8421, 8535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 8421, 8535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 8621, 8666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 8627, 8664);

                    return f_10540_8634_8663(OriginalMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 8621, 8666);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10540_8634_8663(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 8634, 8663);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 8547, 8677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 8547, 8677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IReadOnlySet<Symbol> HoistedVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 8760, 8836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 8796, 8821);

                    return _hoistedVariables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 8760, 8836);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 8689, 8847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 8689, 8847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override BoundExpression FramePointer(SyntaxNode syntax, NamedTypeSymbol frameClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 8859, 9253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 8978, 9003);

                var
                oldSyntax = f_10540_8994_9002(F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9017, 9035);

                F.Syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9049, 9071);

                var
                result = f_10540_9062_9070(F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9085, 9179);

                f_10540_9085_9178(f_10540_9098_9177(frameClass, f_10540_9128_9139(result), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9193, 9214);

                F.Syntax = oldSyntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9228, 9242);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 8859, 9253);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_8994_9002(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 8994, 9002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10540_9062_9070(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 9062, 9070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_9128_9139(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 9128, 9139);
                    return return_v;
                }


                bool
                f_10540_9098_9177(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 9098, 9177);
                    return return_v;
                }


                int
                f_10540_9085_9178(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 9085, 9178);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 8859, 9253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 8859, 9253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void AddState(out int stateNumber, out GeneratedLabelSymbol resumeLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 9265, 9663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9372, 9399);

                stateNumber = _nextState++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9415, 9597) || true) && (_useFinalizerBookkeeping && (DynAbs.Tracing.TraceSender.Expression_True(10540, 9419, 9466) && !_hasFinalizerState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 9415, 9597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9500, 9538);

                    _currentFinalizerState = _nextState++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9556, 9582);

                    _hasFinalizerState = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 9415, 9597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9613, 9652);

                f_10540_9613_9651(this, stateNumber, out resumeLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 9265, 9663);

                int
                f_10540_9613_9651(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, int
                stateNumber, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                resumeLabel)
                {
                    this_param.AddState(stateNumber, out resumeLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 9613, 9651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 9265, 9663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 9265, 9663);
            }
        }

        protected void AddState(int stateNumber, out GeneratedLabelSymbol resumeLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 9675, 10110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9778, 9905) || true) && (_dispatches == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 9778, 9905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9835, 9890);

                    _dispatches = f_10540_9849_9889();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 9778, 9905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9921, 9967);

                resumeLabel = f_10540_9935_9966(F, "stateMachine");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 9981, 10010);

                var
                states = f_10540_9994_10009()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 10024, 10048);

                f_10540_10024_10047(states, stateNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 10062, 10099);

                f_10540_10062_10098(_dispatches, resumeLabel, states);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 9675, 10110);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>
                f_10540_9849_9889()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 9849, 9889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10540_9935_9966(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 9935, 9966);
                    return return_v;
                }


                System.Collections.Generic.List<int>
                f_10540_9994_10009()
                {
                    var return_v = new System.Collections.Generic.List<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 9994, 10009);
                    return return_v;
                }


                int
                f_10540_10024_10047(System.Collections.Generic.List<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10024, 10047);
                    return 0;
                }


                int
                f_10540_10062_10098(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                key, System.Collections.Generic.List<int>
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10062, 10098);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 9675, 10110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 9675, 10110);
            }
        }

        protected BoundStatement Dispatch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 10122, 10388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 10182, 10377);

                return f_10540_10189_10376(F, f_10540_10198_10218(F, cachedState), f_10540_10241_10353((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from kv in _dispatches orderby kv.Value[0] select F.SwitchSection(kv.Value, F.Goto(kv.Key)), 10540, 10242, 10333))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 10122, 10388);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10540_10198_10218(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10198, 10218);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10540_10241_10353(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10241, 10353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_10189_10376(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                ex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                sections)
                {
                    var return_v = this_param.Switch((Microsoft.CodeAnalysis.CSharp.BoundExpression)ex, sections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10189, 10376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 10122, 10388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 10122, 10388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequence(BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 10411, 10956);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 10752, 10897);
                    foreach (var local in f_10540_10774_10785_I(f_10540_10774_10785(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 10752, 10897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 10819, 10882);

                        f_10540_10819_10881(!f_10540_10833_10850(this, local) || (DynAbs.Tracing.TraceSender.Expression_False(10540, 10832, 10880) || f_10540_10854_10880(proxies, local)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 10752, 10897);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10540, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10540, 1, 146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 10913, 10945);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSequence(node), 10540, 10920, 10944);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 10411, 10956);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_10774_10785(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 10774, 10785);
                    return return_v;
                }


                bool
                f_10540_10833_10850(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localOrParameter)
                {
                    var return_v = this_param.NeedsProxy((Microsoft.CodeAnalysis.CSharp.Symbol)localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10833, 10850);
                    return return_v;
                }


                bool
                f_10540_10854_10880(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.Symbol)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10854, 10880);
                    return return_v;
                }


                int
                f_10540_10819_10881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10819, 10881);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_10774_10785_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 10774, 10785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 10411, 10956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 10411, 10956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement PossibleIteratorScope(ImmutableArray<LocalSymbol> locals, Func<BoundStatement> wrapped)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 11402, 15783);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 11537, 11630) || true) && (locals.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 11537, 11630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 11598, 11615);

                    return f_10540_11605_11614(wrapped);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 11537, 11630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 11646, 11733);

                var
                hoistedLocalsWithDebugScopes = f_10540_11681_11732()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 11747, 13634);
                    foreach (var local in f_10540_11769_11775_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 11747, 13634);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 11809, 11901) || true) && (!f_10540_11814_11831(this, local))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 11809, 11901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 11873, 11882);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 11809, 11901);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12027, 12218) || true) && (f_10540_12031_12044(local) != RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 12027, 12218);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12102, 12168);

                            f_10540_12102_12167(f_10540_12115_12136(local) == SynthesizedLocalKind.Spill);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12190, 12199);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 12027, 12218);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12238, 12270);

                        CapturedSymbolReplacement
                        proxy
                        = default(CapturedSymbolReplacement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12288, 12308);

                        bool
                        reused = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12326, 12641) || true) && (!f_10540_12331_12368(proxies, local, out proxy))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 12326, 12641);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12410, 12574);

                            proxy = f_10540_12418_12573(f_10540_12461_12554(this, f_10540_12495_12529(f_10540_12495_12502(), f_10540_12518_12528(local)).Type, out reused, local), isReusable: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12596, 12622);

                            f_10540_12596_12621(proxies, local, proxy);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 12326, 12641);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 12917, 13619) || true) && ((f_10540_12922_12943(local) == SynthesizedLocalKind.UserDefined && (DynAbs.Tracing.TraceSender.Expression_True(10540, 12922, 13043) && f_10540_13008_13015(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10540_12983_13007(local), 10540, 12983, 13015)) != SyntaxKind.SwitchSection)) || (DynAbs.Tracing.TraceSender.Expression_False(10540, 12921, 13133) || f_10540_13069_13090(local) == SynthesizedLocalKind.LambdaDisplayClass))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 12917, 13619);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 13421, 13600) || true) && (!reused)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 13421, 13600);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 13482, 13577);

                                f_10540_13482_13576(hoistedLocalsWithDebugScopes, ((CapturedToStateMachineFieldReplacement)proxy).HoistedField);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 13421, 13600);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 12917, 13619);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 11747, 13634);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10540, 1, 1888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10540, 1, 1888);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 13650, 13686);

                var
                translatedStatement = f_10540_13676_13685(wrapped)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 13700, 13774);

                var
                variableCleanup = f_10540_13722_13773()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 13970, 15072);
                    foreach (var local in f_10540_13992_13998_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 13970, 15072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14032, 14064);

                        CapturedSymbolReplacement
                        proxy
                        = default(CapturedSymbolReplacement);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14082, 14194) || true) && (!f_10540_14087_14124(proxies, local, out proxy))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 14082, 14194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14166, 14175);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 14082, 14194);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14214, 14280);

                        var
                        simpleProxy = proxy as CapturedToStateMachineFieldReplacement
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14298, 15057) || true) && (simpleProxy != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 14298, 15057);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14363, 14425);

                            f_10540_14363_14424(this, variableCleanup, simpleProxy.HoistedField);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14449, 14593) || true) && (proxy.IsReusable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 14449, 14593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14519, 14570);

                                f_10540_14519_14569(this, simpleProxy.HoistedField);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 14449, 14593);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 14298, 15057);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 14298, 15057);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14675, 15038);
                                foreach (var field in f_10540_14697_14757_I(((CapturedToExpressionSymbolReplacement)proxy).HoistedFields))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 14675, 15038);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14807, 14850);

                                    f_10540_14807_14849(this, variableCleanup, field);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14878, 15015) || true) && (proxy.IsReusable)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 14878, 15015);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 14956, 14988);

                                        f_10540_14956_14987(this, field);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 14878, 15015);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 14675, 15038);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10540, 1, 364);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10540, 1, 364);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 14298, 15057);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 13970, 15072);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10540, 1, 1103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10540, 1, 1103);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 15088, 15356) || true) && (f_10540_15092_15113(variableCleanup) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 15088, 15356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 15152, 15341);

                    translatedStatement = f_10540_15174_15340(F, translatedStatement, f_10540_15246_15339(F, f_10540_15254_15338(variableCleanup, (e, f) => (BoundStatement)f.ExpressionStatement(e), F)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 15088, 15356);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 15372, 15395);

                f_10540_15372_15394(
                            variableCleanup);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 15476, 15677) || true) && (f_10540_15480_15514(hoistedLocalsWithDebugScopes) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 15476, 15677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 15553, 15662);

                    translatedStatement = f_10540_15575_15661(this, f_10540_15597_15639(hoistedLocalsWithDebugScopes), translatedStatement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 15476, 15677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 15693, 15729);

                f_10540_15693_15728(
                            hoistedLocalsWithDebugScopes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 15745, 15772);

                return translatedStatement;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 11402, 15783);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_11605_11614(System.Func<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 11605, 11614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_11681_11732()
                {
                    var return_v = ArrayBuilder<StateMachineFieldSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 11681, 11732);
                    return return_v;
                }


                bool
                f_10540_11814_11831(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localOrParameter)
                {
                    var return_v = this_param.NeedsProxy((Microsoft.CodeAnalysis.CSharp.Symbol)localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 11814, 11831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10540_12031_12044(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 12031, 12044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10540_12115_12136(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 12115, 12136);
                    return return_v;
                }


                int
                f_10540_12102_12167(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 12102, 12167);
                    return 0;
                }


                bool
                f_10540_12331_12368(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 12331, 12368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10540_12495_12502()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 12495, 12502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_12518_12528(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 12518, 12528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10540_12495_12529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 12495, 12529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10540_12461_12554(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, out bool
                reused, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.GetOrAllocateReusableHoistedField(type, out reused, local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 12461, 12554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                f_10540_12418_12573(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                hoistedField, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement(hoistedField, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 12418, 12573);
                    return return_v;
                }


                int
                f_10540_12596_12621(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 12596, 12621);
                    return 0;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10540_12922_12943(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 12922, 12943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10540_12983_13007(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 12983, 13007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10540_13008_13015(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 13008, 13015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10540_13069_13090(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 13069, 13090);
                    return return_v;
                }


                int
                f_10540_13482_13576(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 13482, 13576);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_11769_11775_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 11769, 11775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_13676_13685(System.Func<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 13676, 13685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
                f_10540_13722_13773()
                {
                    var return_v = ArrayBuilder<BoundAssignmentOperator>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 13722, 13773);
                    return return_v;
                }


                bool
                f_10540_14087_14124(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 14087, 14124);
                    return return_v;
                }


                int
                f_10540_14363_14424(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
                cleanup, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.AddVariableCleanup(cleanup, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 14363, 14424);
                    return 0;
                }


                int
                f_10540_14519_14569(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.FreeReusableHoistedField(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 14519, 14569);
                    return 0;
                }


                int
                f_10540_14807_14849(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
                cleanup, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.AddVariableCleanup(cleanup, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 14807, 14849);
                    return 0;
                }


                int
                f_10540_14956_14987(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.FreeReusableHoistedField(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 14956, 14987);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_14697_14757_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 14697, 14757);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_13992_13998_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 13992, 13998);
                    return return_v;
                }


                int
                f_10540_15092_15113(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 15092, 15113);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10540_15254_15338(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.CSharp.BoundStatement>
                map, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                arg)
                {
                    var return_v = items.SelectAsArray<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.CSharp.BoundStatement>(map, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 15254, 15338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_15246_15339(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 15246, 15339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_15174_15340(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 15174, 15340);
                    return return_v;
                }


                int
                f_10540_15372_15394(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 15372, 15394);
                    return 0;
                }


                int
                f_10540_15480_15514(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 15480, 15514);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_15597_15639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 15597, 15639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_15575_15661(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedLocals, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = this_param.MakeStateMachineScope(hoistedLocals, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 15575, 15661);
                    return return_v;
                }


                int
                f_10540_15693_15728(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 15693, 15728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 11402, 15783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 11402, 15783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundBlock MakeStateMachineScope(ImmutableArray<StateMachineFieldSymbol> hoistedLocals, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 15927, 16164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16074, 16153);

                return f_10540_16081_16152(F, f_10540_16089_16151(f_10540_16116_16124(F), hoistedLocals, statement));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 15927, 16164);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_16116_16124(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 16116, 16124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope
                f_10540_16089_16151(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                fields, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope(syntax, fields, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 16089, 16151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_16081_16152(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 16081, 16152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 15927, 16164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 15927, 16164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryUnwrapBoundStateMachineScope(ref BoundStatement statement, out ImmutableArray<StateMachineFieldSymbol> hoistedLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10540, 16298, 17185);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16464, 17069) || true) && (f_10540_16468_16482(statement) == BoundKind.Block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 16464, 17069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16535, 16578);

                    var
                    rewrittenBlock = (BoundBlock)statement
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16596, 16648);

                    var
                    rewrittenStatements = f_10540_16622_16647(rewrittenBlock)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16666, 17054) || true) && (rewrittenStatements.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10540, 16670, 16763) && f_10540_16705_16732(rewrittenStatements[0]) == BoundKind.StateMachineScope))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 16666, 17054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16805, 16876);

                        var
                        stateMachineScope = (BoundStateMachineScope)rewrittenStatements[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16898, 16938);

                        statement = f_10540_16910_16937(stateMachineScope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 16960, 17001);

                        hoistedLocals = f_10540_16976_17000(stateMachineScope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 17023, 17035);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 16666, 17054);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 16464, 17069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 17085, 17147);

                hoistedLocals = ImmutableArray<StateMachineFieldSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 17161, 17174);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10540, 16298, 17185);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10540_16468_16482(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 16468, 16482);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10540_16622_16647(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 16622, 16647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10540_16705_16732(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 16705, 16732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_16910_16937(Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 16910, 16937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_16976_17000(Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope
                this_param)
                {
                    var return_v = this_param.Fields;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 16976, 17000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 16298, 17185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 16298, 17185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddVariableCleanup(ArrayBuilder<BoundAssignmentOperator> cleanup, FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 17197, 17508);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 17319, 17497) || true) && (f_10540_17323_17357(this, f_10540_17346_17356(field)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 17319, 17497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 17391, 17482);

                    f_10540_17391_17481(cleanup, f_10540_17403_17480(F, f_10540_17426_17450(F, f_10540_17434_17442(F), field), f_10540_17452_17479(F, f_10540_17468_17478(field))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 17319, 17497);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 17197, 17508);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_17346_17356(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 17346, 17356);
                    return return_v;
                }


                bool
                f_10540_17323_17357(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MightContainReferences(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 17323, 17357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10540_17434_17442(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 17434, 17442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10540_17426_17450(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 17426, 17450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_17468_17478(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 17468, 17478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_17452_17479(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.NullOrDefault(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 17452, 17479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10540_17403_17480(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 17403, 17480);
                    return return_v;
                }


                int
                f_10540_17391_17481(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 17391, 17481);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 17197, 17508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 17197, 17508);
            }
        }

        private bool MightContainReferences(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 17850, 18643);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 17927, 18008) || true) && (f_10540_17931_17951(type) || (DynAbs.Tracing.TraceSender.Expression_False(10540, 17931, 17994) || f_10540_17955_17968(type) == TypeKind.TypeParameter))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 17927, 18008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 17996, 18008);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 17927, 18008);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18058, 18109) || true) && (f_10540_18062_18075(type) != TypeKind.Struct)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 18058, 18109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18096, 18109);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 18058, 18109);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18137, 18208) || true) && (f_10540_18141_18157(type) == SpecialType.System_TypedReference)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 18137, 18208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18196, 18208);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 18137, 18208);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18222, 18277) || true) && (f_10540_18226_18242(type) != SpecialType.None)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 18222, 18277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18264, 18277);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 18222, 18277);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18303, 18396) || true) && (!f_10540_18308_18382(type, this.CompilationState.ModuleBuilderOpt.Compilation))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 18303, 18396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18384, 18396);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 18303, 18396);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18439, 18605);
                    foreach (var f in f_10540_18457_18508_I(f_10540_18457_18508(_emptyStructTypeCache, type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 18439, 18605);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18542, 18590) || true) && (f_10540_18546_18576(this, f_10540_18569_18575(f)))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 18542, 18590);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18578, 18590);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 18542, 18590);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 18439, 18605);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10540, 1, 167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10540, 1, 167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18619, 18632);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 17850, 18643);

                bool
                f_10540_17931_17951(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 17931, 17951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10540_17955_17968(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 17955, 17968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10540_18062_18075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 18062, 18075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10540_18141_18157(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 18141, 18157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10540_18226_18242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 18226, 18242);
                    return return_v;
                }


                bool
                f_10540_18308_18382(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 18308, 18382);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10540_18457_18508(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.GetStructInstanceFields(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 18457, 18508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_18569_18575(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 18569, 18575);
                    return return_v;
                }


                bool
                f_10540_18546_18576(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MightContainReferences(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 18546, 18576);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10540_18457_18508_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 18457, 18508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 17850, 18643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 17850, 18643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StateMachineFieldSymbol GetOrAllocateReusableHoistedField(TypeSymbol type, out bool reused, LocalSymbol local = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 18655, 19727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18805, 18850);

                ArrayBuilder<StateMachineFieldSymbol>
                fields
                = default(ArrayBuilder<StateMachineFieldSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 18864, 19176) || true) && (_lazyAvailableReusableHoistedFields != null && (DynAbs.Tracing.TraceSender.Expression_True(10540, 18868, 18980) && f_10540_18915_18980(_lazyAvailableReusableHoistedFields, type, out fields)) && (DynAbs.Tracing.TraceSender.Expression_True(10540, 18868, 19000) && f_10540_18984_18996(fields) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 18864, 19176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19034, 19060);

                    var
                    field = f_10540_19046_19059(fields)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19078, 19098);

                    f_10540_19078_19097(fields);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19116, 19130);

                    reused = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19148, 19161);

                    return field;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 18864, 19176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19192, 19207);

                reused = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19221, 19259);

                var
                slotIndex = _nextHoistedFieldId++
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19275, 19610) || true) && (f_10540_19279_19301_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(local, 10540, 19279, 19301)?.SynthesizedKind) == SynthesizedLocalKind.UserDefined)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 19275, 19610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19371, 19488);

                    string
                    fieldName = f_10540_19390_19487(SynthesizedLocalKind.UserDefined, slotIndex, f_10540_19476_19486(local))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19506, 19595);

                    return f_10540_19513_19594(F, type, fieldName, SynthesizedLocalKind.UserDefined, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 19275, 19610);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19626, 19716);

                return f_10540_19633_19715(F, type, f_10540_19659_19714(slotIndex));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 18655, 19727);

                bool
                f_10540_18915_18980(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 18915, 18980);
                    return return_v;
                }


                int
                f_10540_18984_18996(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 18984, 18996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10540_19046_19059(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 19046, 19059);
                    return return_v;
                }


                int
                f_10540_19078_19097(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 19078, 19097);
                    return 0;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind?
                f_10540_19279_19301_M(Microsoft.CodeAnalysis.SynthesizedLocalKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 19279, 19301);
                    return return_v;
                }


                string
                f_10540_19476_19486(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 19476, 19486);
                    return return_v;
                }


                string
                f_10540_19390_19487(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, int
                slotIndex, string
                localNameOpt)
                {
                    var return_v = GeneratedNames.MakeHoistedLocalFieldName(kind, slotIndex, localNameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 19390, 19487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10540_19513_19594(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, int
                slotIndex)
                {
                    var return_v = this_param.StateMachineField(type, name, synthesizedKind, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 19513, 19594);
                    return return_v;
                }


                string
                f_10540_19659_19714(int
                number)
                {
                    var return_v = GeneratedNames.ReusableHoistedLocalFieldName(number);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 19659, 19714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10540_19633_19715(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name)
                {
                    var return_v = this_param.StateMachineField(type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 19633, 19715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 18655, 19727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 18655, 19727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FreeReusableHoistedField(StateMachineFieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 19739, 20518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19832, 19877);

                ArrayBuilder<StateMachineFieldSymbol>
                fields
                = default(ArrayBuilder<StateMachineFieldSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 19891, 20473) || true) && (_lazyAvailableReusableHoistedFields == null || (DynAbs.Tracing.TraceSender.Expression_False(10540, 19895, 20014) || !f_10540_19943_20014(_lazyAvailableReusableHoistedFields, f_10540_19991_20001(field), out fields)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 19891, 20473);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20048, 20332) || true) && (_lazyAvailableReusableHoistedFields == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 20048, 20332);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20137, 20313);

                        _lazyAvailableReusableHoistedFields = f_10540_20175_20312(Symbols.SymbolEqualityComparer.IgnoringDynamicTupleNamesAndNullability);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 20048, 20332);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20352, 20458);

                    f_10540_20352_20457(
                                    _lazyAvailableReusableHoistedFields, f_10540_20392_20402(field), fields = f_10540_20413_20456());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 19891, 20473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20489, 20507);

                f_10540_20489_20506(
                            fields, field);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 19739, 20518);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_19991_20001(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 19991, 20001);
                    return return_v;
                }


                bool
                f_10540_19943_20014(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 19943, 20014);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>>
                f_10540_20175_20312(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20175, 20312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_20392_20402(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 20392, 20402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_20413_20456()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20413, 20456);
                    return return_v;
                }


                int
                f_10540_20352_20457(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20352, 20457);
                    return 0;
                }


                int
                f_10540_20489_20506(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20489, 20506);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 19739, 20518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 19739, 20518);
            }
        }

        private BoundExpression HoistRefInitialization(SynthesizedLocal local, BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 20530, 23001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20655, 20721);

                f_10540_20655_20720(f_10540_20668_20689(local) == SynthesizedLocalKind.Spill);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20735, 20773);

                f_10540_20735_20772(f_10540_20748_20763(local) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20787, 20829);

                f_10540_20787_20828(f_10540_20800_20827(this.OriginalMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20845, 20892);

                var
                right = (BoundExpression)f_10540_20874_20891(this, f_10540_20880_20890(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20908, 20970);

                var
                sideEffects = f_10540_20926_20969()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 20984, 21024);

                bool
                needsSacrificialEvaluation = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21038, 21110);

                var
                hoistedFields = f_10540_21058_21109()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21126, 21163);

                AwaitExpressionSyntax
                awaitSyntaxOpt
                = default(AwaitExpressionSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21177, 21194);

                int
                syntaxOffset
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21208, 21821) || true) && (f_10540_21212_21251(f_10540_21212_21233(f_10540_21212_21225(F))) == OptimizationLevel.Debug)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 21208, 21821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21312, 21380);

                    awaitSyntaxOpt = (AwaitExpressionSyntax)f_10540_21352_21379(local);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21398, 21537);

                    syntaxOffset = f_10540_21413_21536(OriginalMethod, f_10540_21455_21508(awaitSyntaxOpt), f_10540_21510_21535(awaitSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 21208, 21821);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 21208, 21821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21748, 21770);

                    awaitSyntaxOpt = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21788, 21806);

                    syntaxOffset = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 21208, 21821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21837, 21983);

                var
                replacement = f_10540_21855_21982(this, right, awaitSyntaxOpt, syntaxOffset, f_10540_21908_21921(local), sideEffects, hoistedFields, ref needsSacrificialEvaluation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 21999, 22128);

                f_10540_21999_22127(
                            proxies, local, f_10540_22018_22126(replacement, f_10540_22073_22107(hoistedFields), isReusable: true));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22144, 22658) || true) && (needsSacrificialEvaluation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 22144, 22658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22208, 22259);

                    var
                    type = f_10540_22219_22253(f_10540_22219_22226(), f_10540_22242_22252(local)).Type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22277, 22346);

                    var
                    sacrificialTemp = f_10540_22299_22345(F, type, refKind: RefKind.Ref)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22364, 22457);

                    f_10540_22364_22456(f_10540_22377_22455(type, f_10540_22401_22417(replacement), TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22475, 22643);

                    return f_10540_22482_22642(F, f_10540_22493_22531(sacrificialTemp), f_10540_22533_22565(sideEffects), f_10540_22567_22641(F, f_10540_22590_22614(F, sacrificialTemp), replacement, isRef: true));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 22144, 22658);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22674, 22798) || true) && (f_10540_22678_22695(sideEffects) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 22674, 22798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22734, 22753);

                    f_10540_22734_22752(sideEffects);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22771, 22783);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 22674, 22798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22814, 22844);

                var
                last = f_10540_22825_22843(sideEffects)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22858, 22883);

                f_10540_22858_22882(sideEffects);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 22897, 22990);

                return f_10540_22904_22989(F, ImmutableArray<LocalSymbol>.Empty, f_10540_22950_22982(sideEffects), last);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 20530, 23001);

                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10540_20668_20689(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 20668, 20689);
                    return return_v;
                }


                int
                f_10540_20655_20720(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20655, 20720);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_20748_20763(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.SyntaxOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 20748, 20763);
                    return return_v;
                }


                int
                f_10540_20735_20772(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20735, 20772);
                    return 0;
                }


                bool
                f_10540_20800_20827(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 20800, 20827);
                    return return_v;
                }


                int
                f_10540_20787_20828(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20787, 20828);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_20880_20890(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 20880, 20890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10540_20874_20891(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20874, 20891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10540_20926_20969()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 20926, 20969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_21058_21109()
                {
                    var return_v = ArrayBuilder<StateMachineFieldSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 21058, 21109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10540_21212_21225(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 21212, 21225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10540_21212_21233(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 21212, 21233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10540_21212_21251(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 21212, 21251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_21352_21379(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.GetDeclaratorSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 21352, 21379);
                    return return_v;
                }


                int
                f_10540_21455_21508(Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                node)
                {
                    var return_v = LambdaUtilities.GetDeclaratorPosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 21455, 21508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10540_21510_21535(Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 21510, 21535);
                    return return_v;
                }


                int
                f_10540_21413_21536(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                localPosition, Microsoft.CodeAnalysis.SyntaxTree
                localTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 21413, 21536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10540_21908_21921(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 21908, 21921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_21855_21982(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax?
                awaitSyntaxOpt, int
                syntaxOffset, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedFields, ref bool
                needsSacrificialEvaluation)
                {
                    var return_v = this_param.HoistExpression(expr, awaitSyntaxOpt, syntaxOffset, refKind, sideEffects, hoistedFields, ref needsSacrificialEvaluation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 21855, 21982);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_22073_22107(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22073, 22107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToExpressionSymbolReplacement
                f_10540_22018_22126(Microsoft.CodeAnalysis.CSharp.BoundExpression
                replacement, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedFields, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToExpressionSymbolReplacement(replacement, hoistedFields, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22018, 22126);
                    return return_v;
                }


                int
                f_10540_21999_22127(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                key, Microsoft.CodeAnalysis.CSharp.CapturedToExpressionSymbolReplacement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 21999, 22127);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10540_22219_22226()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 22219, 22226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_22242_22252(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 22242, 22252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10540_22219_22253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22219, 22253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10540_22299_22345(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.SynthesizedLocal(type, refKind: refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22299, 22345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10540_22401_22417(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 22401, 22417);
                    return return_v;
                }


                bool
                f_10540_22377_22455(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22377, 22455);
                    return return_v;
                }


                int
                f_10540_22364_22456(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22364, 22456);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_22493_22531(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22493, 22531);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10540_22533_22565(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22533, 22565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10540_22590_22614(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22590, 22614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10540_22567_22641(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right, isRef: isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22567, 22641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_22482_22642(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22482, 22642);
                    return return_v;
                }


                int
                f_10540_22678_22695(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 22678, 22695);
                    return return_v;
                }


                int
                f_10540_22734_22752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22734, 22752);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_22825_22843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22825, 22843);
                    return return_v;
                }


                int
                f_10540_22858_22882(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22858, 22882);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10540_22950_22982(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22950, 22982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_22904_22989(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 22904, 22989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 20530, 23001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 20530, 23001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression HoistExpression(
            BoundExpression expr,
            AwaitExpressionSyntax awaitSyntaxOpt,
            int syntaxOffset,
            RefKind refKind,
            ArrayBuilder<BoundExpression> sideEffects,
            ArrayBuilder<StateMachineFieldSymbol> hoistedFields,
            ref bool needsSacrificialEvaluation)
        {
            switch (expr.Kind)
            {
                case BoundKind.ArrayAccess:
                    {
                        var array = (BoundArrayAccess)expr;
                        BoundExpression expression = HoistExpression(array.Expression, awaitSyntaxOpt, syntaxOffset, RefKind.None, sideEffects, hoistedFields, ref needsSacrificialEvaluation);
                        var indices = ArrayBuilder<BoundExpression>.GetInstance();
                        foreach (var index in array.Indices)
                        {
                            indices.Add(HoistExpression(index, awaitSyntaxOpt, syntaxOffset, RefKind.None, sideEffects, hoistedFields, ref needsSacrificialEvaluation));
                        }

                        needsSacrificialEvaluation = true; // need to force array index out of bounds exceptions
                        return array.Update(expression, indices.ToImmutableAndFree(), array.Type);
                    }

                case BoundKind.FieldAccess:
                    {
                        var field = (BoundFieldAccess)expr;
                        if (field.FieldSymbol.IsStatic)
                        {
                            // the address of a static field, and the value of a readonly static field, is stable
                            if (refKind != RefKind.None || field.FieldSymbol.IsReadOnly) return expr;
                            goto default;
                        }

                        if (refKind == RefKind.None)
                        {
                            goto default;
                        }

                        var isFieldOfStruct = !field.FieldSymbol.ContainingType.IsReferenceType;

                        var receiver = HoistExpression(field.ReceiverOpt, awaitSyntaxOpt, syntaxOffset,
                            isFieldOfStruct ? refKind : RefKind.None, sideEffects, hoistedFields, ref needsSacrificialEvaluation);
                        if (receiver.Kind != BoundKind.ThisReference && !isFieldOfStruct)
                        {
                            needsSacrificialEvaluation = true; // need the null check in field receiver
                        }

                        return F.Field(receiver, field.FieldSymbol);
                    }

                case BoundKind.ThisReference:
                case BoundKind.BaseReference:
                case BoundKind.DefaultExpression:
                    return expr;

                case BoundKind.Call:
                    var call = (BoundCall)expr;
                    // NOTE: There are two kinds of 'In' arguments that we may see at this point:
                    //       - `RefKindExtensions.StrictIn`     (originally specified with 'In' modifier)
                    //       - `RefKind.In`                     (specified with no modifiers and matched an 'In' parameter)
                    //
                    //       It is allowed to spill ordinary `In` arguments by value if reference-preserving spilling is not possible.
                    //       The "strict" ones do not permit implicit copying, so the same situation should result in an error.
                    if (refKind != RefKind.None && refKind != RefKind.In)
                    {
                        Debug.Assert(call.Method.RefKind != RefKind.None);
                        F.Diagnostics.Add(ErrorCode.ERR_RefReturningCallAndAwait, F.Syntax.Location, call.Method);
                    }
                    // method call is not referentially transparent, we can only spill the result value.
                    refKind = RefKind.None;
                    goto default;

                case BoundKind.ConditionalOperator:
                    var conditional = (BoundConditionalOperator)expr;
                    // NOTE: There are two kinds of 'In' arguments that we may see at this point:
                    //       - `RefKindExtensions.StrictIn`     (originally specified with 'In' modifier)
                    //       - `RefKind.In`                     (specified with no modifiers and matched an 'In' parameter)
                    //
                    //       It is allowed to spill ordinary `In` arguments by value if reference-preserving spilling is not possible.
                    //       The "strict" ones do not permit implicit copying, so the same situation should result in an error.
                    if (refKind != RefKind.None && refKind != RefKind.RefReadOnly)
                    {
                        Debug.Assert(conditional.IsRef);
                        F.Diagnostics.Add(ErrorCode.ERR_RefConditionalAndAwait, F.Syntax.Location);
                    }
                    // conditional expr is not referentially transparent, we can only spill the result value.
                    refKind = RefKind.None;
                    goto default;

                default:
                    if (expr.ConstantValue != null)
                    {
                        return expr;
                    }

                    if (refKind != RefKind.None)
                    {
                        throw ExceptionUtilities.UnexpectedValue(expr.Kind);
                    }

                    TypeSymbol fieldType = expr.Type;
                    StateMachineFieldSymbol hoistedField;
                    if (F.Compilation.Options.OptimizationLevel == OptimizationLevel.Debug)
                    {
                        const SynthesizedLocalKind kind = SynthesizedLocalKind.AwaitByRefSpill;

                        Debug.Assert(awaitSyntaxOpt != null);

                        int ordinal = _synthesizedLocalOrdinals.AssignLocalOrdinal(kind, syntaxOffset);
                        var id = new LocalDebugId(syntaxOffset, ordinal);

                        // Editing await expression is not allowed. Thus all spilled fields will be present in the previous state machine.
                        // However, it may happen that the type changes, in which case we need to allocate a new slot.
                        int slotIndex;
                        if (slotAllocatorOpt == null ||
                            !slotAllocatorOpt.TryGetPreviousHoistedLocalSlotIndex(
                                awaitSyntaxOpt,
                                F.ModuleBuilderOpt.Translate(fieldType, awaitSyntaxOpt, Diagnostics),
                                kind,
                                id,
                                Diagnostics,
                                out slotIndex))
                        {
                            slotIndex = _nextFreeHoistedLocalSlot++;
                        }

                        string fieldName = GeneratedNames.MakeHoistedLocalFieldName(kind, slotIndex);
                        hoistedField = F.StateMachineField(expr.Type, fieldName, new LocalSlotDebugInfo(kind, id), slotIndex);
                    }
                    else
                    {
                        hoistedField = GetOrAllocateReusableHoistedField(fieldType, reused: out _);
                    }

                    hoistedFields.Add(hoistedField);

                    var replacement = F.Field(F.This(), hoistedField);
                    sideEffects.Add(F.AssignmentExpression(replacement, expr));
                    return replacement;
            }
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 30870, 31166);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 30942, 30972) || true) && (node == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 30942, 30972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 30960, 30972);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 30942, 30972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 30986, 31011);

                var
                oldSyntax = f_10540_31002_31010(F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31025, 31048);

                F.Syntax = node.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31062, 31092);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10540, 31075, 31091)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31106, 31127);

                F.Syntax = oldSyntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31141, 31155);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 30870, 31166);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_31002_31010(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 31002, 31010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 30870, 31166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 30870, 31166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBlock(BoundBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 31178, 31354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31256, 31343);

                return f_10540_31263_31342(this, f_10540_31285_31296(node), () => (BoundStatement)base.VisitBlock(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 31178, 31354);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_31285_31296(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 31285, 31296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_31263_31342(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Func<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                wrapped)
                {
                    var return_v = this_param.PossibleIteratorScope(locals, wrapped);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 31263, 31342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 31178, 31354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 31178, 31354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitScope(BoundScope node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 31366, 33799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31444, 31479);

                f_10540_31444_31478(f_10540_31457_31477_M(!node.Locals.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31493, 31556);

                var
                newLocalsBuilder = f_10540_31516_31555()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31570, 31657);

                var
                hoistedLocalsWithDebugScopes = f_10540_31605_31656()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31671, 31700);

                bool
                localsRewritten = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31714, 32525);
                    foreach (var local in f_10540_31736_31747_I(f_10540_31736_31747(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 31714, 32525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 31836, 32087);

                        f_10540_31836_32086(f_10540_31849_31870(local) == SynthesizedLocalKind.UserDefined && (DynAbs.Tracing.TraceSender.Expression_True(10540, 31849, 32085) && (f_10540_31957_31964(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10540_31932_31956(local), 10540, 31932, 31964)) == SyntaxKind.SwitchSection || (DynAbs.Tracing.TraceSender.Expression_False(10540, 31932, 32084) || f_10540_32043_32050(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10540_32018_32042(local), 10540, 32018, 32050)) == SyntaxKind.SwitchExpressionArm))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32107, 32130);

                        LocalSymbol
                        localToUse
                        = default(LocalSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32148, 32386) || true) && (f_10540_32152_32190(this, local, out localToUse))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 32148, 32386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32232, 32265);

                            f_10540_32232_32264(newLocalsBuilder, localToUse);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32287, 32336);

                            localsRewritten |= ((object)local != localToUse);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32358, 32367);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 32148, 32386);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32406, 32510);

                        f_10540_32406_32509(
                                        hoistedLocalsWithDebugScopes, ((CapturedToStateMachineFieldReplacement)f_10540_32480_32494(proxies, local)).HoistedField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 31714, 32525);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10540, 1, 812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10540, 1, 812);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32541, 32585);

                var
                statements = f_10540_32558_32584(this, f_10540_32568_32583(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32666, 33788) || true) && (f_10540_32670_32704(hoistedLocalsWithDebugScopes) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 32666, 33788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32743, 32769);

                    BoundStatement
                    translated
                    = default(BoundStatement);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32789, 33146) || true) && (f_10540_32793_32815(newLocalsBuilder) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 32789, 33146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32862, 32886);

                        f_10540_32862_32885(newLocalsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 32908, 32969);

                        translated = f_10540_32921_32968(node.Syntax, statements);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 32789, 33146);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 32789, 33146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33051, 33127);

                        translated = f_10540_33064_33126(node, f_10540_33076_33113(newLocalsBuilder), statements);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 32789, 33146);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33166, 33251);

                    return f_10540_33173_33250(this, f_10540_33195_33237(hoistedLocalsWithDebugScopes), translated);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 32666, 33788);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 32666, 33788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33317, 33353);

                    f_10540_33317_33352(hoistedLocalsWithDebugScopes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33371, 33409);

                    ImmutableArray<LocalSymbol>
                    newLocals
                    = default(ImmutableArray<LocalSymbol>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33429, 33711) || true) && (localsRewritten)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 33429, 33711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33490, 33540);

                        newLocals = f_10540_33502_33539(newLocalsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 33429, 33711);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 33429, 33711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33622, 33646);

                        f_10540_33622_33645(newLocalsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33668, 33692);

                        newLocals = f_10540_33680_33691(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 33429, 33711);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33731, 33773);

                    return f_10540_33738_33772(node, newLocals, statements);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 32666, 33788);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 31366, 33799);

                bool
                f_10540_31457_31477_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 31457, 31477);
                    return return_v;
                }


                int
                f_10540_31444_31478(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 31444, 31478);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_31516_31555()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 31516, 31555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_31605_31656()
                {
                    var return_v = ArrayBuilder<StateMachineFieldSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 31605, 31656);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_31736_31747(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 31736, 31747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10540_31849_31870(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 31849, 31870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_31932_31956(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 31932, 31956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10540_31957_31964(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 31957, 31964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10540_32018_32042(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 32018, 32042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10540_32043_32050(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 32043, 32050);
                    return return_v;
                }


                int
                f_10540_31836_32086(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 31836, 32086);
                    return 0;
                }


                bool
                f_10540_32152_32190(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                newLocal)
                {
                    var return_v = this_param.TryRewriteLocal(local, out newLocal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 32152, 32190);
                    return return_v;
                }


                int
                f_10540_32232_32264(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 32232, 32264);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                f_10540_32480_32494(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 32480, 32494);
                    return return_v;
                }


                int
                f_10540_32406_32509(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 32406, 32509);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_31736_31747_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 31736, 31747);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10540_32568_32583(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 32568, 32583);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10540_32558_32584(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundStatement>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 32558, 32584);
                    return return_v;
                }


                int
                f_10540_32670_32704(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 32670, 32704);
                    return return_v;
                }


                int
                f_10540_32793_32815(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 32793, 32815);
                    return return_v;
                }


                int
                f_10540_32862_32885(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 32862, 32885);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10540_32921_32968(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList(syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 32921, 32968);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_33076_33113(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33076, 33113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundScope
                f_10540_33064_33126(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33064, 33126);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10540_33195_33237(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33195, 33237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_33173_33250(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                hoistedLocals, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = this_param.MakeStateMachineScope(hoistedLocals, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33173, 33250);
                    return return_v;
                }


                int
                f_10540_33317_33352(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33317, 33352);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_33502_33539(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33502, 33539);
                    return return_v;
                }


                int
                f_10540_33622_33645(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33622, 33645);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10540_33680_33691(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 33680, 33691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundScope
                f_10540_33738_33772(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 33738, 33772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 31366, 33799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 31366, 33799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitForStatement(BoundForStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 33811, 33999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 33903, 33940);

                throw f_10540_33909_33939();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 33811, 33999);

                System.Exception
                f_10540_33909_33939()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 33909, 33939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 33811, 33999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 33811, 33999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUsingStatement(BoundUsingStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 34011, 34205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 34107, 34144);

                throw f_10540_34113_34143();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 34011, 34205);

                System.Exception
                f_10540_34113_34143()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 34113, 34143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 34011, 34205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 34011, 34205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 34217, 34654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 34494, 34568);

                BoundExpression
                expression = (BoundExpression)f_10540_34540_34567(this, f_10540_34551_34566(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 34582, 34643);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10540, 34589, 34609) || (((expression == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10540, 34612, 34616)) || DynAbs.Tracing.TraceSender.Conditional_F3(10540, 34619, 34642))) ? null : f_10540_34619_34642(node, expression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 34217, 34654);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_34551_34566(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 34551, 34566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10540_34540_34567(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 34540, 34567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10540_34619_34642(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Update(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 34619, 34642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 34217, 34654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 34217, 34654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 34666, 36138);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 34770, 34898) || true) && (f_10540_34774_34788(f_10540_34774_34783(node)) != BoundKind.Local)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 34770, 34898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 34841, 34883);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10540, 34848, 34882);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 34770, 34898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 34914, 34966);

                var
                leftLocal = f_10540_34930_34965(((BoundLocal)f_10540_34943_34952(node)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 34980, 35097) || true) && (!f_10540_34985_35006(this, leftLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 34980, 35097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 35040, 35082);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10540, 35047, 35081);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 34980, 35097);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 35113, 35282) || true) && (f_10540_35117_35147(proxies, leftLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 35113, 35282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 35181, 35207);

                    f_10540_35181_35206(f_10540_35194_35205_M(!node.IsRef));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 35225, 35267);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10540, 35232, 35266);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 35113, 35282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 35771, 35841);

                f_10540_35771_35840(f_10540_35784_35809(leftLocal) == SynthesizedLocalKind.Spill);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 35855, 35880);

                f_10540_35855_35879(f_10540_35868_35878(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 36062, 36127);

                return f_10540_36069_36126(this, leftLocal, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 34666, 36138);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_34774_34783(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 34774, 34783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10540_34774_34788(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 34774, 34788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_34943_34952(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 34943, 34952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10540_34930_34965(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 34930, 34965);
                    return return_v;
                }


                bool
                f_10540_34985_35006(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localOrParameter)
                {
                    var return_v = this_param.NeedsProxy((Microsoft.CodeAnalysis.CSharp.Symbol)localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 34985, 35006);
                    return return_v;
                }


                bool
                f_10540_35117_35147(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.Symbol)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 35117, 35147);
                    return return_v;
                }


                bool
                f_10540_35194_35205_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 35194, 35205);
                    return return_v;
                }


                int
                f_10540_35181_35206(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 35181, 35206);
                    return 0;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10540_35784_35809(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 35784, 35809);
                    return return_v;
                }


                int
                f_10540_35771_35840(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 35771, 35840);
                    return 0;
                }


                bool
                f_10540_35868_35878(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 35868, 35878);
                    return return_v;
                }


                int
                f_10540_35855_35879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 35855, 35879);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_36069_36126(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node)
                {
                    var return_v = this_param.HoistRefInitialization((Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal)local, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 36069, 36126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 34666, 36138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 34666, 36138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTryStatement(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 37274, 40392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37366, 37398);

                var
                oldDispatches = _dispatches
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37412, 37459);

                var
                oldFinalizerState = _currentFinalizerState
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37473, 37519);

                var
                oldHasFinalizerState = _hasFinalizerState
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37535, 37554);

                _dispatches = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37568, 37596);

                _currentFinalizerState = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37610, 37637);

                _hasFinalizerState = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37653, 37726);

                BoundBlock
                tryBlock = f_10540_37675_37725(F, (BoundStatement)f_10540_37699_37724(this, f_10540_37710_37723(node)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37740, 37782);

                GeneratedLabelSymbol
                dispatchLabel = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37796, 39378) || true) && (_dispatches != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 37796, 39378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37853, 37900);

                    dispatchLabel = f_10540_37869_37899(F, "tryDispatch");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 37918, 39011) || true) && (_hasFinalizerState)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 37918, 39011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 38079, 38124);

                        var
                        finalizer = f_10540_38095_38123(F, "finalizer")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 38146, 38217);

                        f_10540_38146_38216(_dispatches, finalizer, new List<int>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _currentFinalizerState, 10540, 38173, 38215) });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 38239, 38292);

                        var
                        skipFinalizer = f_10540_38259_38291(F, "skipFinalizer")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 38314, 38768);

                        tryBlock = f_10540_38325_38767(F, f_10540_38359_38382(F), f_10540_38409_38419(this), f_10540_38446_38467(F, skipFinalizer), f_10540_38494_38512(F, finalizer), f_10540_38570_38634(this, StateMachineStates.NotStartedStateMachine), f_10540_38661_38682(this, false), f_10540_38709_38731(F, skipFinalizer), tryBlock);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 37918, 39011);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 37918, 39011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 38850, 38992);

                        tryBlock = f_10540_38861_38991(F, f_10540_38895_38918(F), f_10540_38945_38955(this), tryBlock);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 37918, 39011);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39031, 39232) || true) && (oldDispatches == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 39031, 39232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39098, 39134);

                        f_10540_39098_39133(!oldHasFinalizerState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39156, 39213);

                        oldDispatches = f_10540_39172_39212();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 39031, 39232);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39252, 39363);

                    f_10540_39252_39362(
                                    oldDispatches, dispatchLabel, f_10540_39285_39361(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from kv in _dispatches.Values from n in kv orderby n select n, 10540, 39299, 39360)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 37796, 39378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39394, 39436);

                _hasFinalizerState = oldHasFinalizerState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39450, 39493);

                _currentFinalizerState = oldFinalizerState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39507, 39535);

                _dispatches = oldDispatches;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39551, 39630);

                ImmutableArray<BoundCatchBlock>
                catchBlocks = f_10540_39597_39629(this, f_10540_39612_39628(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39646, 39976);

                BoundBlock
                finallyBlockOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(10540, 39675, 39703) || ((f_10540_39675_39695(node) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10540, 39706, 39710)) || DynAbs.Tracing.TraceSender.Conditional_F3(10540, 39713, 39975))) ? null : f_10540_39713_39975(F, f_10540_39739_39762(F), f_10540_39781_39932(F, condition: f_10540_39819_39844(this), thenClause: f_10540_39879_39913(this, f_10540_39892_39912(node))), f_10540_39951_39974(F))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 39992, 40115);

                BoundStatement
                result = f_10540_40016_40114(node, tryBlock, catchBlocks, finallyBlockOpt, f_10540_40068_40088(node), f_10540_40090_40113(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 40131, 40351) || true) && ((object)dispatchLabel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 40131, 40351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 40198, 40336);

                    result = f_10540_40207_40335(F, f_10540_40237_40260(F), f_10540_40283_40305(F, dispatchLabel), result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 40131, 40351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 40367, 40381);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 37274, 40392);

                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_37710_37723(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 37710, 37723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10540_37699_37724(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 37699, 37724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_37675_37725(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 37675, 37725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10540_37869_37899(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 37869, 37899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10540_38095_38123(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38095, 38123);
                    return return_v;
                }


                int
                f_10540_38146_38216(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                key, System.Collections.Generic.List<int>
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38146, 38216);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10540_38259_38291(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38259, 38291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_38359_38382(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38359, 38382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_38409_38419(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.Dispatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38409, 38419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10540_38446_38467(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Goto((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38446, 38467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10540_38494_38512(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38494, 38512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10540_38570_38634(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, int
                stateNumber)
                {
                    var return_v = this_param.GenerateSetBothStates(stateNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38570, 38634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_38661_38682(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, bool
                finished)
                {
                    var return_v = this_param.GenerateReturn(finished);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38661, 38682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10540_38709_38731(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38709, 38731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_38325_38767(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38325, 38767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_38895_38918(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38895, 38918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_38945_38955(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.Dispatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38945, 38955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_38861_38991(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 38861, 38991);
                    return return_v;
                }


                int
                f_10540_39098_39133(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39098, 39133);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>
                f_10540_39172_39212()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39172, 39212);
                    return return_v;
                }


                System.Collections.Generic.List<int>
                f_10540_39285_39361(System.Collections.Generic.IEnumerable<int>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<int>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39285, 39361);
                    return return_v;
                }


                int
                f_10540_39252_39362(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                key, System.Collections.Generic.List<int>
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39252, 39362);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10540_39612_39628(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 39612, 39628);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10540_39597_39629(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39597, 39629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10540_39675_39695(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 39675, 39695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_39739_39762(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39739, 39762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10540_39819_39844(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param)
                {
                    var return_v = this_param.ShouldEnterFinallyBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39819, 39844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_39892_39912(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 39892, 39912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_39879_39913(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlock)
                {
                    var return_v = this_param.VisitFinally(finallyBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39879, 39913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_39781_39932(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundBlock
                thenClause)
                {
                    var return_v = this_param.If(condition: (Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39781, 39932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_39951_39974(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39951, 39974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_39713_39975(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 39713, 39975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10540_40068_40088(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyLabelOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 40068, 40088);
                    return return_v;
                }


                bool
                f_10540_40090_40113(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.PreferFaultHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 40090, 40113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                f_10540_40016_40114(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                finallyBlockOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                finallyLabelOpt, bool
                preferFaultHandler)
                {
                    var return_v = this_param.Update(tryBlock, catchBlocks, finallyBlockOpt, finallyLabelOpt, preferFaultHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40016, 40114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10540_40237_40260(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40237, 40260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10540_40283_40305(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40283, 40305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10540_40207_40335(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40207, 40335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 37274, 40392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 37274, 40392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual BoundBlock VisitFinally(BoundBlock finallyBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 40404, 40550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 40495, 40539);

                return (BoundBlock)f_10540_40514_40538(this, finallyBlock);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 40404, 40550);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10540_40514_40538(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40514, 40538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 40404, 40550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 40404, 40550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual BoundBinaryOperator ShouldEnterFinallyBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 40562, 40752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 40650, 40741);

                return f_10540_40657_40740(F, f_10540_40671_40691(F, cachedState), f_10540_40693_40739(F, StateMachineStates.FirstUnusedState));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 40562, 40752);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10540_40671_40691(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40671, 40691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10540_40693_40739(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40693, 40739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10540_40657_40740(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.IntLessThan((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 40657, 40740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 40562, 40752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 40562, 40752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundExpressionStatement GenerateSetBothStates(int stateNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 40865, 41151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41019, 41140);

                return f_10540_41026_41139(F, f_10540_41039_41068(F, f_10540_41047_41055(F), stateField), f_10540_41070_41138(F, f_10540_41093_41113(F, cachedState), f_10540_41115_41137(F, stateNumber)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 40865, 41151);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10540_41047_41055(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41047, 41055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10540_41039_41068(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41039, 41068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10540_41093_41113(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41093, 41113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10540_41115_41137(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41115, 41137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10540_41070_41138(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41070, 41138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10540_41026_41139(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41026, 41139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 40865, 41151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 40865, 41151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundStatement CacheThisIfNeeded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 41163, 41690);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41290, 41611) || true) && ((object)this.cachedThis != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 41290, 41611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41359, 41436);

                    CapturedSymbolReplacement
                    proxy = f_10540_41393_41435(proxies, f_10540_41401_41434(this.OriginalMethod))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41454, 41521);

                    var
                    fetchThis = f_10540_41470_41520(proxy, f_10540_41488_41496(F), frameType => F.This())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41539, 41596);

                    return f_10540_41546_41595(F, f_10540_41559_41583(F, this.cachedThis), fetchThis);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 41290, 41611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41654, 41679);

                return f_10540_41661_41678(F);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 41163, 41690);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10540_41401_41434(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 41401, 41434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                f_10540_41393_41435(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 41393, 41435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_41488_41496(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 41488, 41496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_41470_41520(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41470, 41520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10540_41559_41583(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41559, 41583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10540_41546_41595(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41546, 41595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10540_41661_41678(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.StatementList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41661, 41678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 41163, 41690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 41163, 41690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitThisReference(BoundThisReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 41702, 43207);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41851, 41967) || true) && ((object)this.cachedThis != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 41851, 41967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41920, 41952);

                    return f_10540_41927_41951(F, this.cachedThis);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 41851, 41967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 41983, 42037);

                var
                thisParameter = f_10540_42003_42036(this.OriginalMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 42051, 42083);

                CapturedSymbolReplacement
                proxy
                = default(CapturedSymbolReplacement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 42097, 43196) || true) && ((object)thisParameter == null || (DynAbs.Tracing.TraceSender.Expression_False(10540, 42101, 42180) || !f_10540_42135_42180(proxies, thisParameter, out proxy)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 42097, 43196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 42970, 43011);

                    return f_10540_42977_43010(node, f_10540_42989_43009(this, f_10540_42999_43008(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 42097, 43196);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 42097, 43196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 43077, 43105);

                    f_10540_43077_43104(proxy != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 43123, 43181);

                    return f_10540_43130_43180(proxy, f_10540_43148_43156(F), frameType => F.This());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 42097, 43196);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 41702, 43207);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10540_41927_41951(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 41927, 41951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10540_42003_42036(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 42003, 42036);
                    return return_v;
                }


                bool
                f_10540_42135_42180(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 42135, 42180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_42999_43008(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 42999, 43008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10540_42989_43009(Microsoft.CodeAnalysis.CSharp.MethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 42989, 43009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10540_42977_43010(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 42977, 43010);
                    return return_v;
                }


                int
                f_10540_43077_43104(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 43077, 43104);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_43148_43156(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 43148, 43156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_43130_43180(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 43130, 43180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 41702, 43207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 41702, 43207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBaseReference(BoundBaseReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10540, 43219, 43777);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 43443, 43559) || true) && ((object)this.cachedThis != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10540, 43443, 43559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 43512, 43544);

                    return f_10540_43519_43543(F, this.cachedThis);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10540, 43443, 43559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 43575, 43652);

                CapturedSymbolReplacement
                proxy = f_10540_43609_43651(proxies, f_10540_43617_43650(this.OriginalMethod))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 43666, 43694);

                f_10540_43666_43693(proxy != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10540, 43708, 43766);

                return f_10540_43715_43765(proxy, f_10540_43733_43741(F), frameType => F.This());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10540, 43219, 43777);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10540_43519_43543(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 43519, 43543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10540_43617_43650(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 43617, 43650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                f_10540_43609_43651(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 43609, 43651);
                    return return_v;
                }


                int
                f_10540_43666_43693(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 43666, 43693);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10540_43733_43741(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 43733, 43741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10540_43715_43765(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 43715, 43765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10540, 43219, 43777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 43219, 43777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodToStateMachineRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10540, 652, 43806);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10540, 652, 43806);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10540, 652, 43806);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10540, 652, 43806);

        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>
        f_10540_3371_3411()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, System.Collections.Generic.List<int>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 3371, 3411);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
        f_10540_5115_5154()
        {
            var return_v = EmptyStructTypeCache.CreateNeverEmpty();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 5115, 5154);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        f_10540_6115_6133(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.CompilationState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 6115, 6133);
            return return_v;
        }


        int
        f_10540_6172_6195(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6172, 6195);
            return 0;
        }


        int
        f_10540_6210_6246(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6210, 6246);
            return 0;
        }


        int
        f_10540_6261_6288(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6261, 6288);
            return 0;
        }


        int
        f_10540_6303_6348(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6303, 6348);
            return 0;
        }


        int
        f_10540_6363_6396(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6363, 6396);
            return 0;
        }


        int
        f_10540_6411_6449(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6411, 6449);
            return 0;
        }


        int
        f_10540_6464_6507(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6464, 6507);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10540_6625_6664(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.SpecialType
        st)
        {
            var return_v = this_param.SpecialType(st);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6625, 6664);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10540_6674_6682(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 6674, 6682);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        f_10540_6606_6735(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        type, Microsoft.CodeAnalysis.SyntaxNode
        syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
        kind)
        {
            var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntax: syntax, kind: kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 6606, 6735);
            return return_v;
        }


        int
        f_10540_7191_7231(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        key, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 7191, 7231);
            return 0;
        }


        System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
        f_10540_7134_7157_I(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 7134, 7157);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10540_7355_7383(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ThisParameter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7355, 7383);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10540_7502_7520(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7502, 7520);
            return return_v;
        }


        bool
        f_10540_7502_7536(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.IsReferenceType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7502, 7536);
            return return_v;
        }


        bool
        f_10540_7557_7606(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
        value)
        {
            var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 7557, 7606);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10540_7627_7640(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7627, 7640);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10540_7627_7648(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7627, 7648);
            return return_v;
        }


        Microsoft.CodeAnalysis.OptimizationLevel
        f_10540_7627_7666(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.OptimizationLevel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7627, 7666);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10540_7790_7798(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7790, 7798);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10540_7768_7822(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
        makeFrame)
        {
            var return_v = this_param.Replacement(node, makeFrame);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 7768, 7822);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10540_7878_7903(Microsoft.CodeAnalysis.CSharp.BoundExpression
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7878, 7903);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10540_7913_7921(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10540, 7913, 7921);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        f_10540_7859_7961(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        type, Microsoft.CodeAnalysis.SyntaxNode
        syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
        kind)
        {
            var return_v = this_param.SynthesizedLocal(type, syntax: syntax, kind: kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10540, 7859, 7961);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        f_10540_6097_6113_C(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10540, 5527, 7988);
            return return_v;
        }

    }
}
