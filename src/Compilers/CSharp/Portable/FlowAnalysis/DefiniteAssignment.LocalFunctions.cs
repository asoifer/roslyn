// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DefiniteAssignmentPass
    {
        internal sealed class LocalFunctionState : AbstractLocalFunctionState
        {
            public BitVector ReadVars;

            public BitVector CapturedMask;

            public BitVector InvertedCapturedMask;

            public LocalFunctionState(LocalState stateFromBottom, LocalState stateFromTop)
            : base(f_10890_803_818_C(stateFromBottom), stateFromTop)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10890, 700, 850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 525, 551);
                    this.ReadVars = BitVector.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 585, 614);
                    this.CapturedMask = BitVector.Null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 646, 683);
                    this.InvertedCapturedMask = BitVector.Null; DynAbs.Tracing.TraceSender.TraceExitConstructor(10890, 700, 850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 700, 850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 700, 850);
                }
            }

            static LocalFunctionState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10890, 414, 861);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10890, 414, 861);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 414, 861);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10890, 414, 861);

            static Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
            f_10890_803_818_C(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10890, 700, 850);
                return return_v;
            }

        }

        protected override LocalFunctionState CreateLocalFunctionState(LocalFunctionSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 977, 1006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 980, 1006);
                return f_10890_980_1006(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 977, 1006);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 977, 1006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 977, 1006);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState
            f_10890_980_1006(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
            this_param)
            {
                var return_v = this_param.CreateLocalFunctionState();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 980, 1006);
                return return_v;
            }

        }

        private LocalFunctionState CreateLocalFunctionState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 1086, 1341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1089, 1341);
                return f_10890_1089_1341(f_10890_1224_1303(BitVector.AllSet(f_10890_1256_1276(variableBySlot)), normalizeToBottom: true), f_10890_1322_1340(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 1086, 1341);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 1086, 1341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 1086, 1341);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10890_1256_1276(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
            this_param)
            {
                var return_v = this_param.Count;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 1256, 1276);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
            f_10890_1224_1303(Microsoft.CodeAnalysis.BitVector
            assigned, bool
            normalizeToBottom)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState(assigned, normalizeToBottom: normalizeToBottom);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 1224, 1303);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
            f_10890_1322_1340(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
            this_param)
            {
                var return_v = this_param.UnreachableState();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 1322, 1340);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState
            f_10890_1089_1341(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
            stateFromBottom, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
            stateFromTop)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState(stateFromBottom, stateFromTop);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 1089, 1341);
                return return_v;
            }

        }

        protected override void VisitLocalFunctionUse(
                    LocalFunctionSymbol localFunc,
                    LocalFunctionState localFunctionState,
                    SyntaxNode syntax,
                    bool isCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 1354, 2236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1579, 1614);

                f_10890_1579_1613(_usedLocalFunctions, localFunc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1711, 1751);

                var
                reads = localFunctionState.ReadVars
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1845, 1853);

                    // Start at slot 1 (slot 0 just indicates reachability)
                    for (int
        slot = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1836, 2135) || true) && (slot < reads.Capacity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1878, 1884)
        , slot++, DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 1836, 2135))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 1836, 2135);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1918, 2120) || true) && (reads[slot])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 1918, 2120);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 1975, 2016);

                            var
                            symbol = variableBySlot[slot].Symbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 2038, 2101);

                            f_10890_2038_2100(this, symbol, syntax, slot);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 1918, 2120);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10890, 1, 300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10890, 1, 300);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 2151, 2225);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionUse(localFunc, localFunctionState, syntax, isCall), 10890, 2151, 2224);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 1354, 2236);

                bool
                f_10890_1579_1613(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 1579, 1613);
                    return return_v;
                }


                int
                f_10890_2038_2100(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                slot)
                {
                    this_param.CheckIfAssignedDuringLocalFunctionReplay(symbol, node, slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 2038, 2100);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 1354, 2236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 1354, 2236);
            }
        }

        private void CheckIfAssignedDuringLocalFunctionReplay(Symbol symbol, SyntaxNode node, int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 2750, 3769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 2870, 2904);

                f_10890_2870_2903(!IsConditionalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 2918, 3758) || true) && ((object)symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 2918, 3758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 2978, 2995);

                    f_10890_2978_2994(this, symbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3015, 3743) || true) && (f_10890_3019_3039(this.State))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 3015, 3743);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3081, 3220) || true) && (slot >= this.State.Assigned.Capacity)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 3081, 3220);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3171, 3197);

                            f_10890_3171_3196(this, ref this.State);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 3081, 3220);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3244, 3724) || true) && (slot > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10890, 3248, 3288) && !f_10890_3261_3288(this.State, slot)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 3244, 3724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3601, 3701);

                            f_10890_3601_3700(this, symbol, node, slot, skipIfUseBeforeDeclaration: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 3244, 3724);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 3015, 3743);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 2918, 3758);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 2750, 3769);

                int
                f_10890_2870_2903(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 2870, 2903);
                    return 0;
                }


                int
                f_10890_2978_2994(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                variable)
                {
                    this_param.NoteRead(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 2978, 2994);
                    return 0;
                }


                bool
                f_10890_3019_3039(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 3019, 3039);
                    return return_v;
                }


                int
                f_10890_3171_3196(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 3171, 3196);
                    return 0;
                }


                bool
                f_10890_3261_3288(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 3261, 3288);
                    return return_v;
                }


                int
                f_10890_3601_3700(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                slot, bool
                skipIfUseBeforeDeclaration)
                {
                    this_param.ReportUnassignedIfNotCapturedInLocalFunction(symbol, node, slot, skipIfUseBeforeDeclaration: skipIfUseBeforeDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 3601, 3700);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 2750, 3769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 2750, 3769);
            }
        }

        private void RecordReadInLocalFunction(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 3781, 5032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3854, 3912);

                var
                localFunc = f_10890_3870_3911(CurrentSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3928, 3960);

                f_10890_3928_3959(localFunc != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 3976, 4027);

                var
                usages = f_10890_3989_4026(this, localFunc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4265, 4310);

                VariableIdentifier
                id = f_10890_4289_4309(variableBySlot, slot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4324, 4372);

                var
                type = f_10890_4335_4366(id.Symbol).Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4388, 4449);

                f_10890_4388_4448(!f_10890_4402_4447(_emptyStructTypeCache, type));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4465, 5021) || true) && (f_10890_4469_4517(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 4465, 5021);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4551, 4911);
                        foreach (var field in f_10890_4573_4624_I(f_10890_4573_4624(_emptyStructTypeCache, type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 4551, 4911);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4666, 4711);

                            int
                            fieldSlot = f_10890_4682_4710(this, field, slot)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4733, 4892) || true) && (fieldSlot > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10890, 4737, 4782) && !f_10890_4755_4782(State, fieldSlot)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 4733, 4892);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4832, 4869);

                                f_10890_4832_4868(this, fieldSlot);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 4733, 4892);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 4551, 4911);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10890, 1, 361);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10890, 1, 361);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 4465, 5021);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 4465, 5021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 4977, 5006);

                    usages.ReadVars[slot] = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 4465, 5021);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 3781, 5032);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10890_3870_3911(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetNearestLocalFunctionOpt(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 3870, 3911);
                    return return_v;
                }


                int
                f_10890_3928_3959(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 3928, 3959);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState
                f_10890_3989_4026(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                localFunc)
                {
                    var return_v = this_param.GetOrCreateLocalFuncUsages(localFunc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 3989, 4026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10890_4289_4309(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 4289, 4309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10890_4335_4366(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4335, 4366);
                    return return_v;
                }


                bool
                f_10890_4402_4447(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsEmptyStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4402, 4447);
                    return return_v;
                }


                int
                f_10890_4388_4448(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4388, 4448);
                    return 0;
                }


                bool
                f_10890_4469_4517(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = EmptyStructTypeCache.IsTrackableStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4469, 4517);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10890_4573_4624(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.GetStructInstanceFields(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4573, 4624);
                    return return_v;
                }


                int
                f_10890_4682_4710(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4682, 4710);
                    return return_v;
                }


                bool
                f_10890_4755_4782(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4755, 4782);
                    return return_v;
                }


                int
                f_10890_4832_4868(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    this_param.RecordReadInLocalFunction(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4832, 4868);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10890_4573_4624_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 4573, 4624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 3781, 5032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 3781, 5032);
            }
        }

        private BitVector GetCapturedBitmask()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 5044, 5369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5107, 5136);

                int
                n = f_10890_5115_5135(variableBySlot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5150, 5187);

                BitVector
                mask = BitVector.AllSet(n)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5210, 5218);
                    for (int
        slot = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5201, 5330) || true) && (slot < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5230, 5236)
        , slot++, DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 5201, 5330))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 5201, 5330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5270, 5315);

                        mask[slot] = f_10890_5283_5314(this, slot);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10890, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10890, 1, 130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5346, 5358);

                return mask;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 5044, 5369);

                int
                f_10890_5115_5135(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 5115, 5135);
                    return return_v;
                }


                bool
                f_10890_5283_5314(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    var return_v = this_param.IsCapturedInLocalFunction(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 5283, 5314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 5044, 5369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 5044, 5369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsCapturedInLocalFunction(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 5381, 6088);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5454, 5482) || true) && (slot <= 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 5454, 5482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5469, 5482);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 5454, 5482);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5630, 5679);

                var
                rootVarInfo = f_10890_5648_5678(variableBySlot, f_10890_5663_5677(this, slot))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5695, 5731);

                var
                rootSymbol = rootVarInfo.Symbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5910, 5975);

                var
                nearestLocalFunc = f_10890_5933_5974(CurrentSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 5991, 6077);

                return !(nearestLocalFunc is null) && (DynAbs.Tracing.TraceSender.Expression_True(10890, 5998, 6076) && f_10890_6029_6076(rootSymbol, nearestLocalFunc));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 5381, 6088);

                int
                f_10890_5663_5677(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    var return_v = this_param.RootSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 5663, 5677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10890_5648_5678(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 5648, 5678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10890_5933_5974(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetNearestLocalFunctionOpt(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 5933, 5974);
                    return return_v;
                }


                bool
                f_10890_6029_6076(Microsoft.CodeAnalysis.CSharp.Symbol
                variable, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                containingSymbol)
                {
                    var return_v = Symbol.IsCaptured(variable, (Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol)containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 6029, 6076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 5381, 6088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 5381, 6088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static LocalFunctionSymbol GetNearestLocalFunctionOpt(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10890, 6100, 6577);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 6201, 6540) || true) && (symbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 6201, 6540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 6256, 6474) || true) && (f_10890_6260_6271(symbol) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10890, 6260, 6378) && f_10890_6317_6350(((MethodSymbol)symbol)) == MethodKind.LocalFunction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 6256, 6474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 6420, 6455);

                            return (LocalFunctionSymbol)symbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 6256, 6474);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 6492, 6525);

                        symbol = f_10890_6501_6524(symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 6201, 6540);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10890, 6201, 6540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10890, 6201, 6540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 6554, 6566);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10890, 6100, 6577);

                Microsoft.CodeAnalysis.SymbolKind
                f_10890_6260_6271(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 6260, 6271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10890_6317_6350(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 6317, 6350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10890_6501_6524(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10890, 6501, 6524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 6100, 6577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 6100, 6577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalFunctionState LocalFunctionStart(LocalFunctionState startState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 6589, 7264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7071, 7115);

                var
                savedState = f_10890_7088_7114(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7129, 7179);

                savedState.ReadVars = startState.ReadVars.Clone();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7193, 7221);

                startState.ReadVars.Clear();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7235, 7253);

                return savedState;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 6589, 7264);

                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState
                f_10890_7088_7114(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.CreateLocalFunctionState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 7088, 7114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 6589, 7264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 6589, 7264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool LocalFunctionEnd(
                    LocalFunctionState savedState,
                    LocalFunctionState currentState,
                    ref LocalState stateAtReturn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10890, 7517, 8775);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7716, 7999) || true) && (currentState.CapturedMask.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 7716, 7999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7786, 7835);

                    currentState.CapturedMask = f_10890_7814_7834(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7853, 7923);

                    currentState.InvertedCapturedMask = currentState.CapturedMask.Clone();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 7941, 7984);

                    currentState.InvertedCapturedMask.Invert();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 7716, 7999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8092, 8156);

                stateAtReturn.Assigned.IntersectWith(currentState.CapturedMask);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8170, 8407) || true) && (NonMonotonicState.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10890, 8170, 8407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8234, 8270);

                    var
                    state = NonMonotonicState.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8288, 8348);

                    state.Assigned.UnionWith(currentState.InvertedCapturedMask);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8366, 8392);

                    NonMonotonicState = state;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10890, 8170, 8407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8515, 8559);

                var
                capturedAndRead = currentState.ReadVars
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8573, 8630);

                capturedAndRead.IntersectWith(currentState.CapturedMask);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10890, 8710, 8764);

                return savedState.ReadVars.UnionWith(capturedAndRead);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10890, 7517, 8775);

                Microsoft.CodeAnalysis.BitVector
                f_10890_7814_7834(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.GetCapturedBitmask();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10890, 7814, 7834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10890, 7517, 8775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10890, 7517, 8775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
