// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class LocalDataFlowPass<TLocalState, TLocalFunctionState> : AbstractFlowPass<TLocalState, TLocalFunctionState>
            where TLocalState : LocalDataFlowPass<TLocalState, TLocalFunctionState>.ILocalDataFlowState
            where TLocalFunctionState : AbstractFlowPass<TLocalState, TLocalFunctionState>.AbstractLocalFunctionState
    {
        internal interface ILocalDataFlowState : ILocalState
        {

            bool NormalizeToBottom { get; }
        }

        protected readonly EmptyStructTypeCache _emptyStructTypeCache;

        protected LocalDataFlowPass(
                    CSharpCompilation compilation,
                    Symbol? member,
                    BoundNode node,
                    EmptyStructTypeCache emptyStructs,
                    bool trackUnassignments)
        : base(f_10898_1736_1747_C(compilation), member, node, nonMonotonicTransferFunction: trackUnassignments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10898, 1499, 1934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 1465, 1486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 1837, 1872);

                f_10898_1837_1871(emptyStructs != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 1886, 1923);

                _emptyStructTypeCache = emptyStructs;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10898, 1499, 1934);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 1499, 1934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 1499, 1934);
            }
        }

        protected LocalDataFlowPass(
                    CSharpCompilation compilation,
                    Symbol member,
                    BoundNode node,
                    EmptyStructTypeCache emptyStructs,
                    BoundNode firstInRegion,
                    BoundNode lastInRegion,
                    bool trackRegions,
                    bool trackUnassignments)
        : base(f_10898_2289_2300_C(compilation), member, node, firstInRegion, lastInRegion, trackRegions: trackRegions, nonMonotonicTransferFunction: trackUnassignments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10898, 1946, 2495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 1465, 1486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 2447, 2484);

                _emptyStructTypeCache = emptyStructs;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10898, 1946, 2495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 1946, 2495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 1946, 2495);
            }
        }

        protected abstract bool TryGetVariable(VariableIdentifier identifier, out int slot);

        protected abstract int AddVariable(VariableIdentifier identifier);

        protected int VariableSlot(Symbol symbol, int containingSlot = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10898, 3547, 3890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 3637, 3748);

                containingSlot = f_10898_3654_3747(this, ref symbol, containingSlot, forceContainingSlotsToExist: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 3764, 3773);

                int
                slot
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 3787, 3879);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10898, 3794, 3866) || ((f_10898_3794_3866(this, f_10898_3809_3855(symbol, containingSlot), out slot) && DynAbs.Tracing.TraceSender.Conditional_F2(10898, 3869, 3873)) || DynAbs.Tracing.TraceSender.Conditional_F3(10898, 3876, 3878))) ? slot : -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10898, 3547, 3890);

                int
                f_10898_3654_3747(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                containingSlot, bool
                forceContainingSlotsToExist)
                {
                    var return_v = this_param.DescendThroughTupleRestFields(ref symbol, containingSlot, forceContainingSlotsToExist: forceContainingSlotsToExist);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 3654, 3747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier
                f_10898_3809_3855(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                containingSlot)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier(symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 3809, 3855);
                    return return_v;
                }


                bool
                f_10898_3794_3866(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier
                identifier, out int
                slot)
                {
                    var return_v = this_param.TryGetVariable(identifier, out slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 3794, 3866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 3547, 3890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 3547, 3890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool IsEmptyStructType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10898, 3902, 4048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 3984, 4037);

                return f_10898_3991_4036(_emptyStructTypeCache, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10898, 3902, 4048);

                bool
                f_10898_3991_4036(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsEmptyStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 3991, 4036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 3902, 4048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 3902, 4048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual int GetOrCreateSlot(Symbol symbol, int containingSlot = 0, bool forceSlotEvenIfEmpty = false, bool createIfMissing = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10898, 4207, 5823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4372, 4406);

                f_10898_4372_4405(containingSlot >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4420, 4449);

                f_10898_4420_4448(symbol != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4465, 4520) || true) && (f_10898_4469_4480(symbol) == SymbolKind.RangeVariable)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 4465, 4520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4510, 4520);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 4465, 4520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4536, 4646);

                containingSlot = f_10898_4553_4645(this, ref symbol, containingSlot, forceContainingSlotsToExist: true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4662, 4822) || true) && (containingSlot < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 4662, 4822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4797, 4807);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 4662, 4822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4838, 4917);

                VariableIdentifier
                identifier = f_10898_4870_4916(symbol, containingSlot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 4931, 4940);

                int
                slot
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5064, 5518) || true) && (!f_10898_5069_5105(this, identifier, out slot))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 5064, 5518);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5139, 5230) || true) && (!createIfMissing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 5139, 5230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5201, 5211);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 5139, 5230);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5250, 5303);

                    var
                    variableType = f_10898_5269_5297(symbol).Type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5321, 5452) || true) && (!forceSlotEvenIfEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10898, 5325, 5381) && f_10898_5350_5381(this, variableType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 5321, 5452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5423, 5433);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 5321, 5452);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5472, 5503);

                    slot = f_10898_5479_5502(this, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 5064, 5518);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5534, 5784) || true) && (IsConditionalState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 5534, 5784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5590, 5624);

                    f_10898_5590_5623(this, ref this.StateWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5642, 5677);

                    f_10898_5642_5676(this, ref this.StateWhenFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 5534, 5784);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 5534, 5784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5743, 5769);

                    f_10898_5743_5768(this, ref this.State);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 5534, 5784);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 5800, 5812);

                return slot;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10898, 4207, 5823);

                int
                f_10898_4372_4405(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 4372, 4405);
                    return 0;
                }


                int
                f_10898_4420_4448(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 4420, 4448);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10898_4469_4480(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 4469, 4480);
                    return return_v;
                }


                int
                f_10898_4553_4645(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                containingSlot, bool
                forceContainingSlotsToExist)
                {
                    var return_v = this_param.DescendThroughTupleRestFields(ref symbol, containingSlot, forceContainingSlotsToExist: forceContainingSlotsToExist);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 4553, 4645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier
                f_10898_4870_4916(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                containingSlot)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier(symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 4870, 4916);
                    return return_v;
                }


                bool
                f_10898_5069_5105(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier
                identifier, out int
                slot)
                {
                    var return_v = this_param.TryGetVariable(identifier, out slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 5069, 5105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10898_5269_5297(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 5269, 5297);
                    return return_v;
                }


                bool
                f_10898_5350_5381(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsEmptyStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 5350, 5381);
                    return return_v;
                }


                int
                f_10898_5479_5502(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier
                identifier)
                {
                    var return_v = this_param.AddVariable(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 5479, 5502);
                    return return_v;
                }


                int
                f_10898_5590_5623(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 5590, 5623);
                    return 0;
                }


                int
                f_10898_5642_5676(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 5642, 5676);
                    return 0;
                }


                int
                f_10898_5743_5768(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 5743, 5768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 4207, 5823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 4207, 5823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract void Normalize(ref TLocalState state);

        private int DescendThroughTupleRestFields(ref Symbol symbol, int containingSlot, bool forceContainingSlotsToExist)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10898, 6662, 8205);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 6801, 8156) || true) && (symbol is TupleFieldSymbol fieldSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 6801, 8156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 6877, 6927);

                    TypeSymbol
                    containingType = f_10898_6905_6926(symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7040, 7082);

                    symbol = f_10898_7049_7081(fieldSymbol);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7212, 8141) || true) && (!f_10898_7220_7312(containingType, f_10898_7254_7275(symbol), TypeCompareKind.ConsiderEverything))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 7212, 8141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7354, 7469);

                            var
                            restField = f_10898_7370_7436(containingType, NamedTypeSymbol.ValueTupleRestFieldName).FirstOrDefault() as FieldSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7491, 7595) || true) && (restField is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 7491, 7595);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7562, 7572);

                                return -1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 7491, 7595);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7619, 8066) || true) && (forceContainingSlotsToExist)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 7619, 8066);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7700, 7760);

                                containingSlot = f_10898_7717_7759(this, restField, containingSlot);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 7619, 8066);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 7619, 8066);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 7858, 8043) || true) && (!f_10898_7863_7948(this, f_10898_7878_7927(restField, containingSlot), out containingSlot))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 7858, 8043);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 8006, 8016);

                                    return -1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 7858, 8043);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 7619, 8066);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 8090, 8122);

                            containingType = f_10898_8107_8121(restField);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 7212, 8141);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10898, 7212, 8141);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10898, 7212, 8141);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 6801, 8156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 8172, 8194);

                return containingSlot;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10898, 6662, 8205);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10898_6905_6926(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 6905, 6926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10898_7049_7081(Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 7049, 7081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10898_7254_7275(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 7254, 7275);
                    return return_v;
                }


                bool
                f_10898_7220_7312(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 7220, 7312);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10898_7370_7436(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 7370, 7436);
                    return return_v;
                }


                int
                f_10898_7717_7759(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 7717, 7759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier
                f_10898_7878_7927(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 7878, 7927);
                    return return_v;
                }


                bool
                f_10898_7863_7948(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>.VariableIdentifier
                identifier, out int
                slot)
                {
                    var return_v = this_param.TryGetVariable(identifier, out slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 7863, 7948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10898_8107_8121(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 8107, 8121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 6662, 8205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 6662, 8205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract bool TryGetReceiverAndMember(BoundExpression expr, out BoundExpression? receiver, [NotNullWhen(true)] out Symbol? member);

        protected virtual int MakeSlot(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10898, 8610, 9945);
                Microsoft.CodeAnalysis.CSharp.BoundExpression? receiver = default(Microsoft.CodeAnalysis.CSharp.BoundExpression?);
                Microsoft.CodeAnalysis.CSharp.Symbol? member = default(Microsoft.CodeAnalysis.CSharp.Symbol?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 8687, 9910);

                switch (f_10898_8695_8704(node))
                {

                    case BoundKind.ThisReference:
                    case BoundKind.BaseReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 8687, 9910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 8836, 8923);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10898, 8843, 8878) || (((object)f_10898_8851_8870() != null && DynAbs.Tracing.TraceSender.Conditional_F2(10898, 8881, 8917)) || DynAbs.Tracing.TraceSender.Conditional_F3(10898, 8920, 8922))) ? f_10898_8881_8917(this, f_10898_8897_8916()) : -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 8687, 9910);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 8687, 9910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 8984, 9039);

                        return f_10898_8991_9038(this, f_10898_9007_9037(((BoundLocal)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 8687, 9910);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 8687, 9910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 9104, 9167);

                        return f_10898_9111_9166(this, f_10898_9127_9165(((BoundParameter)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 8687, 9910);

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 8687, 9910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 9236, 9286);

                        return f_10898_9243_9285(this, f_10898_9252_9284(((BoundRangeVariable)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 8687, 9910);

                    case BoundKind.FieldAccess:
                    case BoundKind.EventAccess:
                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 8687, 9910);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 9446, 9739) || true) && (f_10898_9450_9530(this, node, out receiver, out member))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 9446, 9739);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 9580, 9650);

                            f_10898_9580_9649((receiver is null) != f_10898_9615_9648(member));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 9676, 9716);

                            return f_10898_9683_9715(this, receiver, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 9446, 9739);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10898, 9761, 9767);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 8687, 9910);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 8687, 9910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 9841, 9895);

                        return f_10898_9848_9894(this, f_10898_9857_9893(((BoundAssignmentOperator)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 8687, 9910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 9924, 9934);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10898, 8610, 9945);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10898_8695_8704(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 8695, 8704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10898_8851_8870()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 8851, 8870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10898_8897_8916()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 8897, 8916);
                    return return_v;
                }


                int
                f_10898_8881_8917(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 8881, 8917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10898_9007_9037(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 9007, 9037);
                    return return_v;
                }


                int
                f_10898_8991_9038(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 8991, 9038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10898_9127_9165(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 9127, 9165);
                    return return_v;
                }


                int
                f_10898_9111_9166(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 9111, 9166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10898_9252_9284(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 9252, 9284);
                    return return_v;
                }


                int
                f_10898_9243_9285(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 9243, 9285);
                    return return_v;
                }


                bool
                f_10898_9450_9530(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, out Microsoft.CodeAnalysis.CSharp.Symbol?
                member)
                {
                    var return_v = this_param.TryGetReceiverAndMember(expr, out receiver, out member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 9450, 9530);
                    return return_v;
                }


                bool
                f_10898_9615_9648(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 9615, 9648);
                    return return_v;
                }


                int
                f_10898_9580_9649(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 9580, 9649);
                    return 0;
                }


                int
                f_10898_9683_9715(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = this_param.MakeMemberSlot(receiverOpt, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 9683, 9715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10898_9857_9893(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 9857, 9893);
                    return return_v;
                }


                int
                f_10898_9848_9894(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 9848, 9894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 8610, 9945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 8610, 9945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected int MakeMemberSlot(BoundExpression? receiverOpt, Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10898, 9957, 10595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10055, 10074);

                int
                containingSlot
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10088, 10521) || true) && (f_10898_10092_10125(member))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 10088, 10521);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10159, 10253) || true) && (receiverOpt is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 10159, 10253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10224, 10234);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 10159, 10253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10271, 10310);

                    containingSlot = f_10898_10288_10309(this, receiverOpt);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10328, 10421) || true) && (containingSlot < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 10328, 10421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10392, 10402);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 10328, 10421);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 10088, 10521);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10898, 10088, 10521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10487, 10506);

                    containingSlot = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10898, 10088, 10521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10537, 10584);

                return f_10898_10544_10583(this, member, containingSlot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10898, 9957, 10595);

                bool
                f_10898_10092_10125(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 10092, 10125);
                    return return_v;
                }


                int
                f_10898_10288_10309(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 10288, 10309);
                    return return_v;
                }


                int
                f_10898_10544_10583(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.GetOrCreateSlot(symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 10544, 10583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 9957, 10595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 9957, 10595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static bool HasInitializer(Symbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10898, 10658, 10938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10661, 10938);
                return field switch
                {
                    SourceMemberFieldSymbol f when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10698, 10743) && DynAbs.Tracing.TraceSender.Expression_True(10898, 10698, 10743))
        => f_10898_10727_10743(f),
                    SynthesizedBackingFieldSymbol f when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10758, 10809) && DynAbs.Tracing.TraceSender.Expression_True(10898, 10758, 10809))
        => f_10898_10793_10809(f),
                    SourceFieldLikeEventSymbol e when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10824, 10902) && DynAbs.Tracing.TraceSender.Expression_True(10898, 10824, 10902))
        => f_10898_10856_10894_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10898_10856_10878(e), 10898, 10856, 10894)?.HasInitializer) == true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10898, 10917, 10927) && DynAbs.Tracing.TraceSender.Expression_True(10898, 10917, 10927))
        => false
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10898, 10658, 10938);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10898, 10658, 10938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10898, 10658, 10938);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10898_10727_10743(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
            this_param)
            {
                var return_v = this_param.HasInitializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 10727, 10743);
                return return_v;
            }


            bool
            f_10898_10793_10809(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
            this_param)
            {
                var return_v = this_param.HasInitializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 10793, 10809);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol?
            f_10898_10856_10878(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
            this_param)
            {
                var return_v = this_param.AssociatedEventField;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 10856, 10878);
                return return_v;
            }


            bool?
            f_10898_10856_10894_M(bool?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10898, 10856, 10894);
                return return_v;
            }

        }

        int
        f_10898_1837_1871(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10898, 1837, 1871);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10898_1736_1747_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10898, 1499, 1934);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10898_2289_2300_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10898, 1946, 2495);
            return return_v;
        }

    }
}
