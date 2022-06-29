// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal sealed partial class ILBuilder
    {
        private readonly OptimizationLevel _optimizations;

        internal readonly LocalSlotManager LocalSlotManager;

        private readonly LocalScopeManager _scopeManager;

        internal readonly ITokenDeferral module;

        internal readonly BasicBlock leaderBlock;

        private EmitState _emitState;

        private BasicBlock _lastCompleteBlock;

        private BasicBlock _currentBlock;

        private SyntaxTree _lastSeqPointTree;

        private readonly SmallDictionary<object, LabelInfo> _labelInfos;

        private readonly bool _areLocalsZeroed;

        private int _instructionCountAtLastLabel;

        internal ImmutableArray<byte> RealizedIL;

        internal ImmutableArray<Cci.ExceptionHandlerRegion> RealizedExceptionHandlers;

        internal SequencePointList RealizedSequencePoints;

        public ArrayBuilder<RawSequencePoint> SeqPointsOpt;

        private ArrayBuilder<ILMarker> _allocatedILMarkers;

        private bool _pendingBlockCreate;

        internal ILBuilder(ITokenDeferral module, LocalSlotManager localSlotManager, OptimizationLevel optimizations, bool areLocalsZeroed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(56, 3036, 3714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 711, 725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 771, 787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 833, 846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 925, 931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1035, 1046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1117, 1135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1165, 1178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1210, 1227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1292, 1303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1336, 1352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1375, 1408);
                this._instructionCountAtLastLabel = -1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1658, 1680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 1869, 1881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 2752, 2771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3004, 3023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40888, 40926);
                this._initialHiddenSequencePointMarker = -1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 48354, 48405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3192, 3234);

                f_56_3192_3233(BitConverter.IsLittleEndian);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3250, 3271);

                this.module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3285, 3326);

                this.LocalSlotManager = localSlotManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3340, 3372);

                _emitState = default(EmitState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3386, 3426);

                _scopeManager = f_56_3402_3425();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3442, 3504);

                leaderBlock = _currentBlock = f_56_3472_3503(_scopeManager, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3520, 3609);

                _labelInfos = f_56_3534_3608(ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3623, 3654);

                _optimizations = optimizations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3668, 3703);

                _areLocalsZeroed = areLocalsZeroed;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(56, 3036, 3714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 3036, 3714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 3036, 3714);
            }
        }

        public bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 3754, 3773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3757, 3773);
                    return _areLocalsZeroed; DynAbs.Tracing.TraceSender.TraceExitMethod(56, 3754, 3773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 3754, 3773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 3754, 3773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private BasicBlock GetCurrentBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 3786, 4066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3847, 3909);

                f_56_3847_3908(!_pendingBlockCreate || (DynAbs.Tracing.TraceSender.Expression_False(56, 3860, 3907) || (_currentBlock == null)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3925, 4018) || true) && (_currentBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 3925, 4018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 3984, 4003);

                    f_56_3984_4002(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 3925, 4018);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4034, 4055);

                return _currentBlock;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 3786, 4066);

                int
                f_56_3847_3908(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 3847, 3908);
                    return 0;
                }


                int
                f_56_3984_4002(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CreateBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 3984, 4002);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 3786, 4066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 3786, 4066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CreateBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 4078, 4280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4129, 4165);

                f_56_4129_4164(_currentBlock == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4181, 4225);

                var
                block = f_56_4193_4224(_scopeManager, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4239, 4269);

                f_56_4239_4268(this, block);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 4078, 4280);

                int
                f_56_4129_4164(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4129, 4164);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_4193_4224(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    var return_v = this_param.CreateBlock(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4193, 4224);
                    return return_v;
                }


                int
                f_56_4239_4268(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    this_param.UpdatesForCreatedBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4239, 4268);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 4078, 4280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 4078, 4280);
            }
        }

        private SwitchBlock CreateSwitchBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 4292, 4579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4394, 4405);

                f_56_4394_4404(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4421, 4485);

                SwitchBlock
                switchBlock = f_56_4447_4484(_scopeManager, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4499, 4535);

                f_56_4499_4534(this, switchBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4549, 4568);

                return switchBlock;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 4292, 4579);

                int
                f_56_4394_4404(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4394, 4404);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                f_56_4447_4484(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    var return_v = this_param.CreateSwitchBlock(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4447, 4484);
                    return return_v;
                }


                int
                f_56_4499_4534(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                block)
                {
                    this_param.UpdatesForCreatedBlock((Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock)block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4499, 4534);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 4292, 4579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 4292, 4579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void UpdatesForCreatedBlock(BasicBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 4591, 4901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4669, 4691);

                _currentBlock = block;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4705, 4756);

                f_56_4705_4755(_lastCompleteBlock.NextBlock == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4770, 4807);

                _lastCompleteBlock.NextBlock = block;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4821, 4849);

                _pendingBlockCreate = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4863, 4890);

                f_56_4863_4889(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 4591, 4901);

                int
                f_56_4705_4755(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4705, 4755);
                    return 0;
                }


                int
                f_56_4863_4889(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.ReconcileTrailingMarkers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 4863, 4889);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 4591, 4901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 4591, 4901);
            }
        }

        private void CreateBlockIfPending()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 4913, 5238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 4973, 5227) || true) && (_pendingBlockCreate)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 4973, 5227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5030, 5066);

                    f_56_5030_5065(_currentBlock == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5084, 5103);

                    f_56_5084_5102(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5123, 5159);

                    f_56_5123_5158(_currentBlock != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5177, 5212);

                    f_56_5177_5211(!_pendingBlockCreate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 4973, 5227);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 4913, 5238);

                int
                f_56_5030_5065(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 5030, 5065);
                    return 0;
                }


                int
                f_56_5084_5102(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CreateBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 5084, 5102);
                    return 0;
                }


                int
                f_56_5123_5158(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 5123, 5158);
                    return 0;
                }


                int
                f_56_5177_5211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 5177, 5211);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 4913, 5238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 4913, 5238);
            }
        }

        private void EndBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 5250, 5501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5298, 5326);

                f_56_5298_5325(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5342, 5490) || true) && (_currentBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 5342, 5490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5401, 5436);

                    _lastCompleteBlock = _currentBlock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5454, 5475);

                    _currentBlock = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 5342, 5490);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 5250, 5501);

                int
                f_56_5298_5325(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CreateBlockIfPending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 5298, 5325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 5250, 5501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 5250, 5501);
            }
        }

        private void ReconcileTrailingMarkers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 5513, 7333);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 5883, 7322) || true) && (_lastCompleteBlock != null && (DynAbs.Tracing.TraceSender.Expression_True(56, 5887, 5979) && f_56_5934_5963(_lastCompleteBlock) == ILOpCode.Nop) && (DynAbs.Tracing.TraceSender.Expression_True(56, 5887, 6036) && f_56_6000_6031(_lastCompleteBlock) >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(56, 5887, 6169) && _allocatedILMarkers[f_56_6077_6108(_lastCompleteBlock)].BlockOffset == f_56_6125_6169(_lastCompleteBlock)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 5883, 7322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6203, 6224);

                    int
                    startMarker = -1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6242, 6261);

                    int
                    endMarker = -1
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6281, 6931) || true) && (f_56_6288_6319(_lastCompleteBlock) >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(56, 6288, 6463) && _allocatedILMarkers[f_56_6371_6402(_lastCompleteBlock)].BlockOffset == f_56_6419_6463(_lastCompleteBlock)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 6281, 6931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6505, 6595);

                            f_56_6505_6594((startMarker < 0) || (DynAbs.Tracing.TraceSender.Expression_False(56, 6518, 6593) || (startMarker == (f_56_6556_6587(_lastCompleteBlock) + 1))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6617, 6663);

                            startMarker = f_56_6631_6662(_lastCompleteBlock);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6685, 6819) || true) && (endMarker < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 6685, 6819);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6752, 6796);

                                endMarker = f_56_6764_6795(_lastCompleteBlock);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 6685, 6819);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6841, 6912);

                            f_56_6841_6911(_lastCompleteBlock, f_56_6879_6910(_lastCompleteBlock));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 6281, 6931);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 6281, 6931);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 6281, 6931);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 6951, 6995);

                    BasicBlock
                    current = f_56_6972_6994(this)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7022, 7042);
                        for (int
        marker = startMarker
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7013, 7307) || true) && (marker <= endMarker)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7065, 7073)
        , marker++, DynAbs.Tracing.TraceSender.TraceExitCondition(56, 7013, 7307))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 7013, 7307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7115, 7143);

                            f_56_7115_7142(current, marker);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7165, 7288);

                            _allocatedILMarkers[marker] = new ILMarker() { BlockOffset = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (int)f_56_7231_7264(current), 56, 7195, 7287), AbsoluteOffset = -1 };
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 295);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 5883, 7322);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 5513, 7333);

                System.Reflection.Metadata.ILOpCode
                f_56_5934_5963(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 5934, 5963);
                    return return_v;
                }


                int
                f_56_6000_6031(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6000, 6031);
                    return return_v;
                }


                int
                f_56_6077_6108(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6077, 6108);
                    return return_v;
                }


                int
                f_56_6125_6169(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructionsLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6125, 6169);
                    return return_v;
                }


                int
                f_56_6288_6319(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6288, 6319);
                    return return_v;
                }


                int
                f_56_6371_6402(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6371, 6402);
                    return return_v;
                }


                int
                f_56_6419_6463(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructionsLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6419, 6463);
                    return return_v;
                }


                int
                f_56_6556_6587(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6556, 6587);
                    return return_v;
                }


                int
                f_56_6505_6594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 6505, 6594);
                    return 0;
                }


                int
                f_56_6631_6662(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6631, 6662);
                    return return_v;
                }


                int
                f_56_6764_6795(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6764, 6795);
                    return return_v;
                }


                int
                f_56_6879_6910(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 6879, 6910);
                    return return_v;
                }


                int
                f_56_6841_6911(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, int
                marker)
                {
                    this_param.RemoveTailILMarker(marker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 6841, 6911);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_6972_6994(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 6972, 6994);
                    return return_v;
                }


                int
                f_56_7115_7142(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, int
                marker)
                {
                    this_param.AddILMarker(marker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 7115, 7142);
                    return 0;
                }


                int
                f_56_7231_7264(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructionsLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 7231, 7264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 5513, 7333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 5513, 7333);
            }
        }

        private ExceptionHandlerScope EnclosingExceptionHandler
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 7401, 7443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7404, 7443);
                    return f_56_7404_7443(_scopeManager); DynAbs.Tracing.TraceSender.TraceExitMethod(56, 7401, 7443);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 7401, 7443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 7401, 7443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool InExceptionHandler
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 7489, 7530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7492, 7530);
                    return f_56_7492_7522(this) != null; DynAbs.Tracing.TraceSender.TraceExitMethod(56, 7489, 7530);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 7489, 7530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 7489, 7530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void Realize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 7696, 7977);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7744, 7966) || true) && (this.RealizedIL.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 7744, 7966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7807, 7828);

                    f_56_7807_7827(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7886, 7907);

                    _currentBlock = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 7925, 7951);

                    _lastCompleteBlock = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 7744, 7966);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 7696, 7977);

                int
                f_56_7807_7827(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.RealizeBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 7807, 7827);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 7696, 7977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 7696, 7977);
            }
        }

        internal ImmutableArray<Cci.LocalScope> GetAllScopes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 8144, 8185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 8147, 8185);
                return f_56_8147_8185(_scopeManager); DynAbs.Tracing.TraceSender.TraceExitMethod(56, 8144, 8185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 8144, 8185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 8144, 8185);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
            f_56_8147_8185(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
            this_param)
            {
                var return_v = this_param.GetAllScopesWithLocals();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 8147, 8185);
                return return_v;
            }

        }

        internal ImmutableArray<StateMachineHoistedLocalScope> GetHoistedLocalScopes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 8298, 8922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 8866, 8911);

                return f_56_8873_8910(_scopeManager);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 8298, 8922);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                f_56_8873_8910(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param)
                {
                    var return_v = this_param.GetHoistedLocalScopes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 8873, 8910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 8298, 8922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 8298, 8922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void FreeBasicBlocks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 8934, 9363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 8990, 9022);

                f_56_8990_9021(_scopeManager);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 9038, 9184) || true) && (this.SeqPointsOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 9038, 9184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 9101, 9126);

                    f_56_9101_9125(this.SeqPointsOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 9144, 9169);

                    this.SeqPointsOpt = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 9038, 9184);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 9200, 9352) || true) && (_allocatedILMarkers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 9200, 9352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 9265, 9292);

                    f_56_9265_9291(_allocatedILMarkers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 9310, 9337);

                    _allocatedILMarkers = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 9200, 9352);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 8934, 9363);

                int
                f_56_8990_9021(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param)
                {
                    this_param.FreeBasicBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 8990, 9021);
                    return 0;
                }


                int
                f_56_9101_9125(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 9101, 9125);
                    return 0;
                }


                int
                f_56_9265_9291(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ILMarker>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 9265, 9291);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 8934, 9363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 8934, 9363);
            }
        }

        internal ushort MaxStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 9400, 9430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 9403, 9430);
                    return (ushort)_emitState.MaxStack; DynAbs.Tracing.TraceSender.TraceExitMethod(56, 9400, 9430);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 9400, 9430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 9400, 9430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int InstructionsEmitted
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 10047, 10080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10050, 10080);
                    return _emitState.InstructionsEmitted; DynAbs.Tracing.TraceSender.TraceExitMethod(56, 10047, 10080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 10047, 10080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 10047, 10080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void MarkReachableBlocks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 10186, 10693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10245, 10329);

                f_56_10245_10328(f_56_10258_10327(this, block => (block.Reachability == Reachability.NotReachable)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10345, 10427);

                ArrayBuilder<BasicBlock>
                reachableBlocks = f_56_10388_10426()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10441, 10489);

                f_56_10441_10488(reachableBlocks, leaderBlock);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10505, 10645) || true) && (f_56_10512_10533(reachableBlocks) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 10505, 10645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10572, 10630);

                        f_56_10572_10629(reachableBlocks, f_56_10607_10628(reachableBlocks));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 10505, 10645);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 10505, 10645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 10505, 10645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10659, 10682);

                f_56_10659_10681(reachableBlocks);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 10186, 10693);

                bool
                f_56_10258_10327(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Func<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock, bool>
                predicate)
                {
                    var return_v = this_param.AllBlocks(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10258, 10327);
                    return return_v;
                }


                int
                f_56_10245_10328(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10245, 10328);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                f_56_10388_10426()
                {
                    var return_v = ArrayBuilder<BasicBlock>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10388, 10426);
                    return return_v;
                }


                int
                f_56_10441_10488(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    MarkReachableFrom(reachableBlocks, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10441, 10488);
                    return 0;
                }


                int
                f_56_10512_10533(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 10512, 10533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_10607_10628(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10607, 10628);
                    return return_v;
                }


                int
                f_56_10572_10629(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    MarkReachableFrom(reachableBlocks, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10572, 10629);
                    return 0;
                }


                int
                f_56_10659_10681(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10659, 10681);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 10186, 10693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 10186, 10693);
            }
        }

        private static void PushReachableBlockToProcess(ArrayBuilder<BasicBlock> reachableBlocks, BasicBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 10705, 10976);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10837, 10965) || true) && (block.Reachability == Reachability.NotReachable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 10837, 10965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 10922, 10950);

                    f_56_10922_10949(reachableBlocks, block);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 10837, 10965);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 10705, 10976);

                int
                f_56_10922_10949(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                builder, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 10922, 10949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 10705, 10976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 10705, 10976);
            }
        }

        /// <summary>
        /// Marks blocks that are recursively reachable from the given block.
        /// </summary>
        private static void MarkReachableFrom(ArrayBuilder<BasicBlock> reachableBlocks, BasicBlock block)
        {
tryAgain:

            if (block != null && block.Reachability == Reachability.NotReachable)
            {
                block.Reachability = Reachability.Reachable;

                var branchCode = block.BranchCode;
                if (branchCode == ILOpCode.Nop && block.Type == BlockType.Normal)
                {
                    block = block.NextBlock;
                    goto tryAgain;
                }

                if (branchCode.CanFallThrough())
                {
                    PushReachableBlockToProcess(reachableBlocks, block.NextBlock);
                }
                else
                {
                    // If this block is an "endfinally" block, then clear
                    // the reachability of the following special block.
                    if (branchCode == ILOpCode.Endfinally)
                    {
                        var enclosingFinally = block.EnclosingHandler;
                        enclosingFinally?.UnblockFinally();
                    }
                }

                switch (block.Type)
                {
                    case BlockType.Switch:
                        MarkReachableFromSwitch(reachableBlocks, block);
                        break;

                    case BlockType.Try:
                        MarkReachableFromTry(reachableBlocks, block);
                        break;

                    default:
                        MarkReachableFromBranch(reachableBlocks, block);
                        break;
                }
            }
        }

        private static void MarkReachableFromBranch(ArrayBuilder<BasicBlock> reachableBlocks, BasicBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 12822, 13919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 12950, 12986);

                var
                branchBlock = f_56_12968_12985(block)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 13002, 13908) || true) && (branchBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 13002, 13908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 13396, 13459);

                    var
                    blockedDest = f_56_13414_13458(block, branchBlock)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 13477, 13893) || true) && (blockedDest == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 13477, 13893);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 13542, 13600);

                        f_56_13542_13599(reachableBlocks, branchBlock);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 13477, 13893);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 13477, 13893);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 13819, 13874);

                        f_56_13819_13873(block, blockedDest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 13477, 13893);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 13002, 13908);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 12822, 13919);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_12968_12985(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 12968, 12985);
                    return return_v;
                }


                object
                f_56_13414_13458(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                src, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                dest)
                {
                    var return_v = BlockedBranchDestination(src, dest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 13414, 13458);
                    return return_v;
                }


                int
                f_56_13542_13599(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    PushReachableBlockToProcess(reachableBlocks, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 13542, 13599);
                    return 0;
                }


                int
                f_56_13819_13873(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block, object
                blockedDest)
                {
                    RedirectBranchToBlockedDestination(block, blockedDest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 13819, 13873);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 12822, 13919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 12822, 13919);
            }
        }

        private static void RedirectBranchToBlockedDestination(BasicBlock block, object blockedDest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 13931, 14536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 14097, 14144);

                f_56_14097_14143(            // replace destination, keep opcode
                            block, blockedDest, f_56_14126_14142(block));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 14300, 14339);

                var
                newBranchBlock = f_56_14321_14338(block)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 14353, 14525) || true) && (newBranchBlock.Reachability == Reachability.NotReachable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 14353, 14525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 14447, 14510);

                    f_56_14447_14464(block).Reachability = Reachability.BlockedByFinally;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 14353, 14525);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 13931, 14536);

                System.Reflection.Metadata.ILOpCode
                f_56_14126_14142(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 14126, 14142);
                    return return_v;
                }


                int
                f_56_14097_14143(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, object
                newLabel, System.Reflection.Metadata.ILOpCode
                branchCode)
                {
                    this_param.SetBranch(newLabel, branchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 14097, 14143);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_14321_14338(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 14321, 14338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_14447_14464(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 14447, 14464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 13931, 14536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 13931, 14536);
            }
        }

        private static object BlockedBranchDestination(BasicBlock src, BasicBlock dest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 14728, 15138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 14832, 14870);

                var
                srcHandler = f_56_14849_14869(src)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 14957, 15040) || true) && (srcHandler == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 14957, 15040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 15013, 15025);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 14957, 15040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 15056, 15127);

                return f_56_15063_15126(f_56_15092_15113(dest), srcHandler);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 14728, 15138);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_14849_14869(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 14849, 14869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_15092_15113(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 15092, 15113);
                    return return_v;
                }


                object
                f_56_15063_15126(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                destHandler, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                srcHandler)
                {
                    var return_v = BlockedBranchDestinationSlow(destHandler, srcHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 15063, 15126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 14728, 15138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 14728, 15138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object BlockedBranchDestinationSlow(ExceptionHandlerScope destHandler, ExceptionHandlerScope srcHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 15150, 16853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 15294, 15328);

                ScopeInfo
                destHandlerScope = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 15342, 15470) || true) && (destHandler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 15342, 15470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 15399, 15455);

                    destHandlerScope = f_56_15418_15454(destHandler);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 15342, 15470);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 15703, 16814) || true) && (srcHandler != destHandler)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 15703, 16814);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16040, 16166) || true) && (f_56_16044_16079(srcHandler) == destHandlerScope)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 16040, 16166);
                            DynAbs.Tracing.TraceSender.TraceBreak(56, 16141, 16147);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 16040, 16166);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16186, 16712) || true) && (f_56_16190_16205(srcHandler) == ScopeType.Try)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 16186, 16712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16264, 16327);

                            var
                            handlerBlock = f_56_16283_16305(srcHandler).NextExceptionHandler
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16349, 16693) || true) && (f_56_16353_16370(handlerBlock) == BlockType.Finally)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 16349, 16693);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16441, 16517);

                                var
                                blockedDest = f_56_16459_16516(f_56_16459_16488(handlerBlock))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16543, 16670) || true) && (blockedDest != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 16543, 16670);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16624, 16643);

                                    return blockedDest;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 16543, 16670);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 16349, 16693);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 16186, 16712);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16732, 16799);

                        srcHandler = f_56_16745_16798(f_56_16745_16780(srcHandler));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 15703, 16814);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 15703, 16814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 15703, 16814);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 16830, 16842);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 15150, 16853);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                f_56_15418_15454(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.ContainingExceptionScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 15418, 15454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                f_56_16044_16079(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.ContainingExceptionScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16044, 16079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ScopeType
                f_56_16190_16205(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16190, 16205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                f_56_16283_16305(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.LeaderBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16283, 16305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BlockType
                f_56_16353_16370(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16353, 16370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_16459_16488(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                this_param)
                {
                    var return_v = this_param.EnclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16459, 16488);
                    return return_v;
                }


                object
                f_56_16459_16516(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.BlockedByFinallyDestination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16459, 16516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                f_56_16745_16780(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.ContainingExceptionScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16745, 16780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_16745_16798(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                this_param)
                {
                    var return_v = this_param.ContainingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 16745, 16798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 15150, 16853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 15150, 16853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void MarkReachableFromTry(ArrayBuilder<BasicBlock> reachableBlocks, BasicBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 16865, 19033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 17112, 17189);

                var
                handlerBlock = ((ExceptionHandlerLeaderBlock)block).NextExceptionHandler
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 17203, 17238);

                f_56_17203_17237(handlerBlock != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 17383, 18958) || true) && (f_56_17387_17404(handlerBlock) == BlockType.Finally)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 17383, 18958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 17459, 17515);

                    f_56_17459_17514(handlerBlock.NextExceptionHandler == null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 17852, 18345) || true) && (handlerBlock.Reachability != Reachability.Reachable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 17852, 18345);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18095, 18142);

                        block.Reachability = Reachability.NotReachable;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18164, 18216);

                        f_56_18164_18215(reachableBlocks, block);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18238, 18297);

                        f_56_18238_18296(reachableBlocks, handlerBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18319, 18326);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 17852, 18345);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 17383, 18958);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 17383, 18958);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18571, 18943) || true) && (handlerBlock != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 18571, 18943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18640, 18772);

                            f_56_18640_18771(f_56_18653_18670(handlerBlock) == BlockType.Catch || (DynAbs.Tracing.TraceSender.Expression_False(56, 18653, 18729) || f_56_18693_18710(handlerBlock) == BlockType.Fault) || (DynAbs.Tracing.TraceSender.Expression_False(56, 18653, 18770) || f_56_18733_18750(handlerBlock) == BlockType.Filter));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18794, 18853);

                            f_56_18794_18852(reachableBlocks, handlerBlock);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18875, 18924);

                            handlerBlock = handlerBlock.NextExceptionHandler;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 18571, 18943);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 18571, 18943);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 18571, 18943);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 17383, 18958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 18974, 19022);

                f_56_18974_19021(reachableBlocks, block);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 16865, 19033);

                int
                f_56_17203_17237(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 17203, 17237);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BlockType
                f_56_17387_17404(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 17387, 17404);
                    return return_v;
                }


                int
                f_56_17459_17514(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 17459, 17514);
                    return 0;
                }


                int
                f_56_18164_18215(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    PushReachableBlockToProcess(reachableBlocks, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 18164, 18215);
                    return 0;
                }


                int
                f_56_18238_18296(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                block)
                {
                    PushReachableBlockToProcess(reachableBlocks, (Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock)block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 18238, 18296);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BlockType
                f_56_18653_18670(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 18653, 18670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BlockType
                f_56_18693_18710(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 18693, 18710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BlockType
                f_56_18733_18750(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 18733, 18750);
                    return return_v;
                }


                int
                f_56_18640_18771(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 18640, 18771);
                    return 0;
                }


                int
                f_56_18794_18852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                block)
                {
                    PushReachableBlockToProcess(reachableBlocks, (Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock)block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 18794, 18852);
                    return 0;
                }


                int
                f_56_18974_19021(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    MarkReachableFromBranch(reachableBlocks, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 18974, 19021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 16865, 19033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 16865, 19033);
            }
        }

        private static void MarkReachableFromSwitch(ArrayBuilder<BasicBlock> reachableBlocks, BasicBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 19045, 19548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 19173, 19210);

                var
                switchBlock = (SwitchBlock)block
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 19224, 19282);

                var
                blockBuilder = f_56_19243_19281()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 19296, 19338);

                f_56_19296_19337(switchBlock, blockBuilder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 19354, 19501);
                    foreach (var targetBlock in f_56_19382_19394_I(blockBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 19354, 19501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 19428, 19486);

                        f_56_19428_19485(reachableBlocks, targetBlock);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 19354, 19501);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 19517, 19537);

                f_56_19517_19536(
                            blockBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 19045, 19548);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                f_56_19243_19281()
                {
                    var return_v = ArrayBuilder<BasicBlock>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 19243, 19281);
                    return return_v;
                }


                int
                f_56_19296_19337(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                branchBlocksBuilder)
                {
                    this_param.GetBranchBlocks(branchBlocksBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 19296, 19337);
                    return 0;
                }


                int
                f_56_19428_19485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                reachableBlocks, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    PushReachableBlockToProcess(reachableBlocks, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 19428, 19485);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                f_56_19382_19394_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 19382, 19394);
                    return return_v;
                }


                int
                f_56_19517_19536(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 19517, 19536);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 19045, 19548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 19045, 19548);
            }
        }

        private bool OptimizeLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 19769, 20183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20110, 20172);

                return f_56_20117_20141(this) | f_56_20144_20171(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 19769, 20183);

                bool
                f_56_20117_20141(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.ForwardLabelsNoLeaving();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 20117, 20141);
                    return return_v;
                }


                bool
                f_56_20144_20171(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.ForwardLabelsAllowLeaving();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 20144, 20171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 19769, 20183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 19769, 20183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ForwardLabelsNoLeaving()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 20195, 22188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20257, 20282);

                bool
                madeChanges = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20298, 20328);

                var
                labels = f_56_20311_20327(_labelInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20344, 20354);

                bool
                done
                = default(bool);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 20368, 22142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20403, 20415);

                            done = true;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20435, 22112);
                                foreach (object label in f_56_20460_20466_I(labels))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 20435, 22112);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20508, 20543);

                                    var
                                    labelInfo = f_56_20524_20542(_labelInfos, label)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20565, 20596);

                                    var
                                    targetBlock = labelInfo.bb
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20620, 20673);

                                    f_56_20620_20672(!f_56_20634_20671(targetBlock));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20697, 22093) || true) && (f_56_20701_20737(targetBlock))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 20697, 22093);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20787, 20819);

                                        BasicBlock
                                        targetsTarget = null
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20845, 21253);

                                        switch (f_56_20853_20875(targetBlock))
                                        {

                                            case ILOpCode.Br:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 20845, 21253);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20984, 21024);

                                                targetsTarget = f_56_21000_21023(targetBlock);
                                                DynAbs.Tracing.TraceSender.TraceBreak(56, 21058, 21064);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 20845, 21253);

                                            case ILOpCode.Nop:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 20845, 21253);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21148, 21186);

                                                targetsTarget = targetBlock.NextBlock;
                                                DynAbs.Tracing.TraceSender.TraceBreak(56, 21220, 21226);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 20845, 21253);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21281, 22070) || true) && ((targetsTarget != null) && (DynAbs.Tracing.TraceSender.Expression_True(56, 21285, 21342) && (targetsTarget != targetBlock)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 21281, 22070);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21400, 21450);

                                            var
                                            currentHandler = f_56_21421_21449(targetBlock)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21480, 21528);

                                            var
                                            newHandler = f_56_21497_21527(targetsTarget)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21657, 22043) || true) && (currentHandler == newHandler)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 21657, 22043);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21755, 21815);

                                                _labelInfos[label] = labelInfo.WithNewTarget(targetsTarget);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21849, 21868);

                                                madeChanges = true;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 21999, 22012);

                                                done = false;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 21657, 22043);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 21281, 22070);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 20697, 22093);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 20435, 22112);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 1678);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 1678);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 20368, 22142);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 20368, 22142) || true) && (!done)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 20368, 22142);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 20368, 22142);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22158, 22177);

                return madeChanges;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 20195, 22188);

                Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                f_56_20311_20327(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 20311, 20327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                f_56_20524_20542(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 20524, 20542);
                    return return_v;
                }


                bool
                f_56_20634_20671(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                block)
                {
                    var return_v = IsSpecialEndHandlerBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 20634, 20671);
                    return return_v;
                }


                int
                f_56_20620_20672(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 20620, 20672);
                    return 0;
                }


                bool
                f_56_20701_20737(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                this_param)
                {
                    var return_v = this_param.HasNoRegularInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 20701, 20737);
                    return return_v;
                }


                System.Reflection.Metadata.ILOpCode
                f_56_20853_20875(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 20853, 20875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_21000_21023(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 21000, 21023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_21421_21449(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 21421, 21449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_21497_21527(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 21497, 21527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                f_56_20460_20466_I(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 20460, 20466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 20195, 22188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 20195, 22188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ForwardLabelsAllowLeaving()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 22200, 24437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22265, 22290);

                bool
                madeChanges = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22306, 22336);

                var
                labels = f_56_22319_22335(_labelInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22352, 22362);

                bool
                done
                = default(bool);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 22376, 24391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22411, 22423);

                            done = true;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22443, 24361);
                                foreach (object label in f_56_22468_22474_I(labels))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 22443, 24361);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22516, 22551);

                                    var
                                    labelInfo = f_56_22532_22550(_labelInfos, label)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22573, 22778) || true) && (labelInfo.targetOfConditionalBranches)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 22573, 22778);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22746, 22755);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 22573, 22778);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22802, 22833);

                                    var
                                    targetBlock = labelInfo.bb
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22857, 22910);

                                    f_56_22857_22909(!f_56_22871_22908(targetBlock));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22934, 24342) || true) && (f_56_22938_22974(targetBlock))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 22934, 24342);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23024, 23056);

                                        BasicBlock
                                        targetsTarget = null
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23082, 23490);

                                        switch (f_56_23090_23112(targetBlock))
                                        {

                                            case ILOpCode.Br:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 23082, 23490);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23221, 23261);

                                                targetsTarget = f_56_23237_23260(targetBlock);
                                                DynAbs.Tracing.TraceSender.TraceBreak(56, 23295, 23301);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 23082, 23490);

                                            case ILOpCode.Nop:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 23082, 23490);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23385, 23423);

                                                targetsTarget = targetBlock.NextBlock;
                                                DynAbs.Tracing.TraceSender.TraceBreak(56, 23457, 23463);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 23082, 23490);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23518, 24319) || true) && ((targetsTarget != null) && (DynAbs.Tracing.TraceSender.Expression_True(56, 23522, 23579) && (targetsTarget != targetBlock)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 23518, 24319);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23637, 23687);

                                            var
                                            currentHandler = f_56_23658_23686(targetBlock)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23717, 23765);

                                            var
                                            newHandler = f_56_23734_23764(targetsTarget)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 23878, 24292) || true) && (f_56_23882_23938(currentHandler, newHandler))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 23878, 24292);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 24004, 24064);

                                                _labelInfos[label] = labelInfo.WithNewTarget(targetsTarget);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 24098, 24117);

                                                madeChanges = true;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 24248, 24261);

                                                done = false;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 23878, 24292);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 23518, 24319);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 22934, 24342);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 22443, 24361);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 1919);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 1919);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 22376, 24391);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 22376, 24391) || true) && (!done)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 22376, 24391);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 22376, 24391);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 24407, 24426);

                return madeChanges;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 22200, 24437);

                Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                f_56_22319_22335(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 22319, 22335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                f_56_22532_22550(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 22532, 22550);
                    return return_v;
                }


                bool
                f_56_22871_22908(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                block)
                {
                    var return_v = IsSpecialEndHandlerBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 22871, 22908);
                    return return_v;
                }


                int
                f_56_22857_22909(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 22857, 22909);
                    return 0;
                }


                bool
                f_56_22938_22974(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                this_param)
                {
                    var return_v = this_param.HasNoRegularInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 22938, 22974);
                    return return_v;
                }


                System.Reflection.Metadata.ILOpCode
                f_56_23090_23112(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 23090, 23112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_23237_23260(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 23237, 23260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_23658_23686(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 23658, 23686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_23734_23764(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.EnclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 23734, 23764);
                    return return_v;
                }


                bool
                f_56_23882_23938(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                currentHandler, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                newHandler)
                {
                    var return_v = CanMoveLabelToAnotherHandler(currentHandler, newHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 23882, 23938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                f_56_22468_22474_I(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 22468, 22474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 22200, 24437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 22200, 24437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CanMoveLabelToAnotherHandler(ExceptionHandlerScope currentHandler,
                                                         ExceptionHandlerScope newHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 24449, 26929);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26071, 26211) || true) && (newHandler == null && (DynAbs.Tracing.TraceSender.Expression_True(56, 26075, 26150) && f_56_26097_26150(f_56_26097_26136(currentHandler))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 26071, 26211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26184, 26196);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 26071, 26211);
                }
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 26297, 26889);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26332, 26437) || true) && (currentHandler == newHandler)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 26332, 26437);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26406, 26418);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 26332, 26437);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26457, 26518);

                            var
                            containerScope = f_56_26478_26517(currentHandler)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26536, 26772) || true) && (!f_56_26541_26569(containerScope))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 26536, 26772);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26740, 26753);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 26536, 26772);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26792, 26842);

                            currentHandler = f_56_26809_26841(containerScope);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 26297, 26889);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26297, 26889) || true) && (currentHandler != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 26297, 26889);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 26297, 26889);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 26905, 26918);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 24449, 26929);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                f_56_26097_26136(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.ContainingExceptionScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 26097, 26136);
                    return return_v;
                }


                bool
                f_56_26097_26150(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                this_param)
                {
                    var return_v = this_param.FinallyOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 26097, 26150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                f_56_26478_26517(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                this_param)
                {
                    var return_v = this_param.ContainingExceptionScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 26478, 26517);
                    return return_v;
                }


                bool
                f_56_26541_26569(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                this_param)
                {
                    var return_v = this_param.FinallyOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 26541, 26569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                f_56_26809_26841(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                this_param)
                {
                    var return_v = this_param.ContainingHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 26809, 26841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 24449, 26929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 24449, 26929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool DropUnreachableBlocks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 27090, 27951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27151, 27172);

                bool
                dropped = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27221, 27247);

                var
                current = leaderBlock
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27261, 27661) || true) && (current.NextBlock != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 27261, 27661);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27327, 27646) || true) && (current.NextBlock.Reachability == Reachability.NotReachable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 27327, 27646);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27432, 27480);

                            current.NextBlock = current.NextBlock.NextBlock;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27502, 27517);

                            dropped = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 27327, 27646);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 27327, 27646);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27599, 27627);

                            current = current.NextBlock;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 27327, 27646);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 27261, 27661);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 27261, 27661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 27261, 27661);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27771, 27909);

                f_56_27771_27908(f_56_27784_27907(this, block => (block.Reachability == Reachability.Reachable) || (block.Reachability == Reachability.BlockedByFinally)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 27925, 27940);

                return dropped;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 27090, 27951);

                bool
                f_56_27784_27907(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Func<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock, bool>
                predicate)
                {
                    var return_v = this_param.AllBlocks(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 27784, 27907);
                    return return_v;
                }


                int
                f_56_27771_27908(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 27771, 27908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 27090, 27951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 27090, 27951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MarkAllBlocksUnreachable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 28053, 28367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28150, 28176);

                var
                current = leaderBlock
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28190, 28356) || true) && (current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 28190, 28356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28246, 28295);

                        current.Reachability = Reachability.NotReachable;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28313, 28341);

                        current = current.NextBlock;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 28190, 28356);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 28190, 28356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 28190, 28356);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 28053, 28367);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 28053, 28367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 28053, 28367);
            }
        }

        private void ComputeOffsets()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 28379, 28671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28433, 28459);

                var
                current = leaderBlock
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28473, 28660) || true) && (current.NextBlock != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 28473, 28660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28539, 28599);

                        current.NextBlock.Start = current.Start + f_56_28581_28598(current);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 28617, 28645);

                        current = current.NextBlock;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 28473, 28660);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 28473, 28660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 28473, 28660);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 28379, 28671);

                int
                f_56_28581_28598(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.TotalSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 28581, 28598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 28379, 28671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 28379, 28671);
            }
        }

        private void RewriteSpecialBlocks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 28974, 30286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 29034, 29060);

                var
                current = leaderBlock
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 29076, 30106) || true) && (current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 29076, 30106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 29296, 29422);

                        f_56_29296_29421(current.Reachability != Reachability.BlockedByFinally || (DynAbs.Tracing.TraceSender.Expression_False(56, 29309, 29420) || f_56_29387_29420(current)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 29442, 30045) || true) && (f_56_29446_29479(current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 29442, 30045);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 29521, 30026) || true) && (current.Reachability == Reachability.BlockedByFinally)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 29521, 30026);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 29769, 29806);

                                f_56_29769_29805(                        // BranchLabel points to the same block, so the BranchCode
                                                                         // is changed from Nop to Br_s.
                                                        current, ILOpCode.Br_s);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 29521, 30026);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 29521, 30026);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 29965, 30003);

                                f_56_29965_30002(                        // special block becomes a true nop
                                                        current, null, ILOpCode.Nop);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 29521, 30026);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 29442, 30045);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30063, 30091);

                        current = current.NextBlock;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 29076, 30106);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 29076, 30106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 29076, 30106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30208, 30275);

                f_56_30208_30274(f_56_30221_30273(this, block => !IsSpecialEndHandlerBlock(block)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 28974, 30286);

                bool
                f_56_29387_29420(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    var return_v = IsSpecialEndHandlerBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 29387, 29420);
                    return return_v;
                }


                int
                f_56_29296_29421(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 29296, 29421);
                    return 0;
                }


                bool
                f_56_29446_29479(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block)
                {
                    var return_v = IsSpecialEndHandlerBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 29446, 29479);
                    return return_v;
                }


                int
                f_56_29769_29805(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, System.Reflection.Metadata.ILOpCode
                newBranchCode)
                {
                    this_param.SetBranchCode(newBranchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 29769, 29805);
                    return 0;
                }


                int
                f_56_29965_30002(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, object
                newLabel, System.Reflection.Metadata.ILOpCode
                branchCode)
                {
                    this_param.SetBranch(newLabel, branchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 29965, 30002);
                    return 0;
                }


                bool
                f_56_30221_30273(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Func<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock, bool>
                predicate)
                {
                    var return_v = this_param.AllBlocks(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 30221, 30273);
                    return return_v;
                }


                int
                f_56_30208_30274(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 30208, 30274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 28974, 30286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 28974, 30286);
            }
        }

        private static bool IsSpecialEndHandlerBlock(BasicBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(56, 30494, 30852);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30581, 30712) || true) && ((f_56_30586_30602(block) != ILOpCode.Nop) || (DynAbs.Tracing.TraceSender.Expression_False(56, 30585, 30650) || (f_56_30624_30641(block) == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 30581, 30712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30684, 30697);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 30581, 30712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30774, 30815);

                f_56_30774_30814(f_56_30787_30804(block) == block);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30829, 30841);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(56, 30494, 30852);

                System.Reflection.Metadata.ILOpCode
                f_56_30586_30602(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 30586, 30602);
                    return return_v;
                }


                object
                f_56_30624_30641(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 30624, 30641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_30787_30804(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 30787, 30804);
                    return return_v;
                }


                int
                f_56_30774_30814(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 30774, 30814);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 30494, 30852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 30494, 30852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RewriteBranchesAcrossExceptionHandlers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 30864, 31159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30942, 30968);

                var
                current = leaderBlock
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 30982, 31148) || true) && (current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 30982, 31148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 31038, 31087);

                        f_56_31038_31086(current);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 31105, 31133);

                        current = current.NextBlock;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 30982, 31148);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 30982, 31148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 30982, 31148);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 30864, 31159);

                int
                f_56_31038_31086(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    this_param.RewriteBranchesAcrossExceptionHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 31038, 31086);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 30864, 31159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 30864, 31159);
            }
        }

        private bool ComputeOffsetsAndAdjustBranches()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 32154, 33012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32225, 32242);

                f_56_32225_32241(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32258, 32289);

                bool
                branchesOptimized = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32303, 32313);

                int
                delta
                = default(int);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 32327, 32891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32362, 32372);

                            delta = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32390, 32416);

                            var
                            current = leaderBlock
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32434, 32857) || true) && (current != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 32434, 32857);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32498, 32528);

                                    f_56_32498_32527(current, delta);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32552, 32729) || true) && (_optimizations == OptimizationLevel.Release)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 32552, 32729);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32649, 32706);

                                        branchesOptimized |= f_56_32670_32705(current, ref delta);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 32552, 32729);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32753, 32788);

                                    f_56_32753_32787(
                                                        current, ref delta);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32810, 32838);

                                    current = current.NextBlock;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 32434, 32857);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 32434, 32857);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(56, 32434, 32857);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 32327, 32891);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32327, 32891) || true) && (delta < 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 32327, 32891);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 32327, 32891);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 32976, 33001);

                return branchesOptimized;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 32154, 33012);

                int
                f_56_32225_32241(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.ComputeOffsets();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 32225, 32241);
                    return 0;
                }


                int
                f_56_32498_32527(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, int
                delta)
                {
                    this_param.AdjustForDelta(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 32498, 32527);
                    return 0;
                }


                bool
                f_56_32670_32705(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, ref int
                delta)
                {
                    var return_v = this_param.OptimizeBranches(ref delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 32670, 32705);
                    return return_v;
                }


                int
                f_56_32753_32787(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, ref int
                delta)
                {
                    this_param.ShortenBranches(ref delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 32753, 32787);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 32154, 33012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 32154, 33012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RealizeBlocks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 33024, 38057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 33517, 33539);

                f_56_33517_33538(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 33553, 33576);

                f_56_33553_33575(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 33590, 33614);

                f_56_33590_33613(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 33630, 34000) || true) && (_optimizations == OptimizationLevel.Release && (DynAbs.Tracing.TraceSender.Expression_True(56, 33634, 33697) && f_56_33681_33697(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 33630, 34000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 33876, 33903);

                    f_56_33876_33902(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 33921, 33943);

                    f_56_33921_33942(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 33961, 33985);

                    f_56_33961_33984(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 33630, 34000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34062, 34103);

                f_56_34062_34102(this);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34188, 34704) || true) && (f_56_34195_34228(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 34188, 34704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34442, 34469);

                        f_56_34442_34468(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34487, 34509);

                        f_56_34487_34508(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34527, 34689) || true) && (!f_56_34532_34555(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 34527, 34689);
                            DynAbs.Tracing.TraceSender.TraceBreak(56, 34664, 34670);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 34527, 34689);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 34188, 34704);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 34188, 34704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 34188, 34704);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34784, 34833);

                var
                writer = f_56_34797_34832()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34858, 34877);

                    for (var
        block = leaderBlock
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34849, 37826) || true) && (block != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 34894, 34917)
        , block = block.NextBlock, DynAbs.Tracing.TraceSender.TraceExitCondition(56, 34849, 37826))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 34849, 37826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35047, 35090);

                        int
                        blockFirstMarker = f_56_35070_35089(block)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35108, 35714) || true) && (blockFirstMarker >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 35108, 35714);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35175, 35216);

                            int
                            blockLastMarker = f_56_35197_35215(block)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35238, 35288);

                            f_56_35238_35287(blockLastMarker >= blockFirstMarker);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35319, 35339);
                                for (int
            i = blockFirstMarker
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35310, 35695) || true) && (i <= blockLastMarker)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35363, 35366)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(56, 35310, 35695))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 35310, 35695);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35416, 35469);

                                    int
                                    blockOffset = _allocatedILMarkers[i].BlockOffset
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35495, 35543);

                                    int
                                    absoluteOffset = f_56_35516_35528(writer) + blockOffset
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35569, 35672);

                                    _allocatedILMarkers[i] = new ILMarker() { BlockOffset = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => blockOffset, 56, 35594, 35671), AbsoluteOffset = absoluteOffset };
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 386);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 386);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 35108, 35714);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35734, 35784);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_56_35734_35759(block), 56, 35734, 35783).WriteContentTo(writer), 56, 35760, 35783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 35804, 37811);

                        switch (f_56_35812_35828(block))
                        {

                            case ILOpCode.Nop:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 35804, 37811);
                                DynAbs.Tracing.TraceSender.TraceBreak(56, 35914, 35920);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 35804, 37811);

                            case ILOpCode.Switch:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 35804, 37811);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36140, 36177);

                                f_56_36140_36176(writer, ILOpCode.Switch);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36205, 36242);

                                var
                                switchBlock = (SwitchBlock)block
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36268, 36314);

                                f_56_36268_36313(writer, f_56_36287_36312(switchBlock));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36342, 36405);

                                int
                                switchBlockEnd = switchBlock.Start + f_56_36383_36404(switchBlock)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36433, 36491);

                                var
                                blockBuilder = f_56_36452_36490()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36517, 36559);

                                f_56_36517_36558(switchBlock, blockBuilder);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36587, 36766);
                                    foreach (var branchBlock in f_56_36615_36627_I(blockBuilder))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 36587, 36766);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36685, 36739);

                                        f_56_36685_36738(writer, branchBlock.Start - switchBlockEnd);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 36587, 36766);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 180);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 180);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36794, 36814);

                                f_56_36794_36813(
                                                        blockBuilder);
                                DynAbs.Tracing.TraceSender.TraceBreak(56, 36842, 36848);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 35804, 37811);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 35804, 37811);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36906, 36944);

                                f_56_36906_36943(writer, f_56_36926_36942(block));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 36972, 37758) || true) && (f_56_36976_36993(block) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 36972, 37758);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37059, 37096);

                                    int
                                    target = f_56_37072_37089(block).Start
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37126, 37174);

                                    int
                                    curBlockEnd = block.Start + f_56_37158_37173(block)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37204, 37238);

                                    int
                                    offset = target - curBlockEnd
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37270, 37731) || true) && (f_56_37274_37313(f_56_37274_37290(block)) == 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 37270, 37731);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37384, 37415);

                                        sbyte
                                        btOffset = (sbyte)offset
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37449, 37482);

                                        f_56_37449_37481(btOffset == offset);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37516, 37544);

                                        f_56_37516_37543(writer, btOffset);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 37270, 37731);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 37270, 37731);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37674, 37700);

                                        f_56_37674_37699(writer, offset);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 37270, 37731);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 36972, 37758);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(56, 37786, 37792);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 35804, 37811);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 2978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 2978);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37842, 37886);

                this.RealizedIL = f_56_37860_37885(writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37900, 37914);

                f_56_37900_37913(writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37930, 37954);

                f_56_37930_37953(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 37970, 38046);

                this.RealizedExceptionHandlers = f_56_38003_38045(_scopeManager);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 33024, 38057);

                int
                f_56_33517_33538(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.MarkReachableBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 33517, 33538);
                    return 0;
                }


                int
                f_56_33553_33575(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.RewriteSpecialBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 33553, 33575);
                    return 0;
                }


                bool
                f_56_33590_33613(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.DropUnreachableBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 33590, 33613);
                    return return_v;
                }


                bool
                f_56_33681_33697(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.OptimizeLabels();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 33681, 33697);
                    return return_v;
                }


                int
                f_56_33876_33902(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.MarkAllBlocksUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 33876, 33902);
                    return 0;
                }


                int
                f_56_33921_33942(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.MarkReachableBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 33921, 33942);
                    return 0;
                }


                bool
                f_56_33961_33984(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.DropUnreachableBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 33961, 33984);
                    return return_v;
                }


                int
                f_56_34062_34102(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.RewriteBranchesAcrossExceptionHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 34062, 34102);
                    return 0;
                }


                bool
                f_56_34195_34228(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.ComputeOffsetsAndAdjustBranches();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 34195, 34228);
                    return return_v;
                }


                int
                f_56_34442_34468(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.MarkAllBlocksUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 34442, 34468);
                    return 0;
                }


                int
                f_56_34487_34508(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.MarkReachableBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 34487, 34508);
                    return 0;
                }


                bool
                f_56_34532_34555(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.DropUnreachableBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 34532, 34555);
                    return return_v;
                }


                Microsoft.Cci.PooledBlobBuilder
                f_56_34797_34832()
                {
                    var return_v = Cci.PooledBlobBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 34797, 34832);
                    return return_v;
                }


                int
                f_56_35070_35089(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.FirstILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 35070, 35089);
                    return return_v;
                }


                int
                f_56_35197_35215(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.LastILMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 35197, 35215);
                    return return_v;
                }


                int
                f_56_35238_35287(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 35238, 35287);
                    return 0;
                }


                int
                f_56_35516_35528(Microsoft.Cci.PooledBlobBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 35516, 35528);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_56_35734_35759(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 35734, 35759);
                    return return_v;
                }


                System.Reflection.Metadata.ILOpCode
                f_56_35812_35828(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 35812, 35828);
                    return return_v;
                }


                int
                f_56_36140_36176(Microsoft.Cci.PooledBlobBuilder
                writer, System.Reflection.Metadata.ILOpCode
                code)
                {
                    WriteOpCode((System.Reflection.Metadata.BlobBuilder)writer, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36140, 36176);
                    return 0;
                }


                uint
                f_56_36287_36312(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param)
                {
                    var return_v = this_param.BranchesCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 36287, 36312);
                    return return_v;
                }


                int
                f_56_36268_36313(Microsoft.Cci.PooledBlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36268, 36313);
                    return 0;
                }


                int
                f_56_36383_36404(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param)
                {
                    var return_v = this_param.TotalSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 36383, 36404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                f_56_36452_36490()
                {
                    var return_v = ArrayBuilder<BasicBlock>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36452, 36490);
                    return return_v;
                }


                int
                f_56_36517_36558(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                branchBlocksBuilder)
                {
                    this_param.GetBranchBlocks(branchBlocksBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36517, 36558);
                    return 0;
                }


                int
                f_56_36685_36738(Microsoft.Cci.PooledBlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36685, 36738);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                f_56_36615_36627_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36615, 36627);
                    return return_v;
                }


                int
                f_56_36794_36813(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36794, 36813);
                    return 0;
                }


                System.Reflection.Metadata.ILOpCode
                f_56_36926_36942(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 36926, 36942);
                    return return_v;
                }


                int
                f_56_36906_36943(Microsoft.Cci.PooledBlobBuilder
                writer, System.Reflection.Metadata.ILOpCode
                code)
                {
                    WriteOpCode((System.Reflection.Metadata.BlobBuilder)writer, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 36906, 36943);
                    return 0;
                }


                object
                f_56_36976_36993(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 36976, 36993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_37072_37089(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 37072, 37089);
                    return return_v;
                }


                int
                f_56_37158_37173(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.TotalSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 37158, 37173);
                    return return_v;
                }


                System.Reflection.Metadata.ILOpCode
                f_56_37274_37290(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 37274, 37290);
                    return return_v;
                }


                int
                f_56_37274_37313(System.Reflection.Metadata.ILOpCode
                opCode)
                {
                    var return_v = opCode.GetBranchOperandSize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 37274, 37313);
                    return return_v;
                }


                int
                f_56_37449_37481(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 37449, 37481);
                    return 0;
                }


                int
                f_56_37516_37543(Microsoft.Cci.PooledBlobBuilder
                this_param, sbyte
                value)
                {
                    this_param.WriteSByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 37516, 37543);
                    return 0;
                }


                int
                f_56_37674_37699(Microsoft.Cci.PooledBlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 37674, 37699);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_56_37860_37885(Microsoft.Cci.PooledBlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 37860, 37885);
                    return return_v;
                }


                int
                f_56_37900_37913(Microsoft.Cci.PooledBlobBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 37900, 37913);
                    return 0;
                }


                int
                f_56_37930_37953(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.RealizeSequencePoints();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 37930, 37953);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                f_56_38003_38045(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param)
                {
                    var return_v = this_param.GetExceptionHandlerRegions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 38003, 38045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 33024, 38057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 33024, 38057);
            }
        }

        private void RealizeSequencePoints()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 38069, 39852);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38130, 39841) || true) && (this.SeqPointsOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 38130, 39841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38360, 38380);

                    int
                    lastOffset = -1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38400, 38488);

                    ArrayBuilder<RawSequencePoint>
                    seqPoints = f_56_38443_38487()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38506, 39613);
                        foreach (var seqPoint in f_56_38531_38548_I(this.SeqPointsOpt))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 38506, 39613);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38590, 38649);

                            int
                            offset = f_56_38603_38648(this, seqPoint.ILMarker)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38671, 39594) || true) && (offset >= 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 38671, 39594);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38780, 39571) || true) && (lastOffset != offset)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 38780, 39571);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 38862, 38896);

                                    f_56_38862_38895(lastOffset < offset);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 39068, 39117);

                                    f_56_39068_39116((lastOffset >= 0) || (DynAbs.Tracing.TraceSender.Expression_False(56, 39081, 39115) || (offset == 0)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 39228, 39248);

                                    lastOffset = offset;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 39278, 39302);

                                    f_56_39278_39301(seqPoints, seqPoint);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 38780, 39571);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 38780, 39571);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 39502, 39544);

                                    seqPoints[f_56_39512_39527(seqPoints) - 1] = seqPoint;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 38780, 39571);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(56, 38671, 39594);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 38506, 39613);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 1, 1108);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(56, 1, 1108);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 39633, 39789) || true) && (f_56_39637_39652(seqPoints) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 39633, 39789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 39698, 39770);

                        this.RealizedSequencePoints = f_56_39728_39769(seqPoints, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 39633, 39789);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 39809, 39826);

                    f_56_39809_39825(
                                    seqPoints);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 38130, 39841);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 38069, 39852);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                f_56_38443_38487()
                {
                    var return_v = ArrayBuilder<RawSequencePoint>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 38443, 38487);
                    return return_v;
                }


                int
                f_56_38603_38648(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                ilMarker)
                {
                    var return_v = this_param.GetILOffsetFromMarker(ilMarker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 38603, 38648);
                    return return_v;
                }


                int
                f_56_38862_38895(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 38862, 38895);
                    return 0;
                }


                int
                f_56_39068_39116(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 39068, 39116);
                    return 0;
                }


                int
                f_56_39278_39301(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param, Microsoft.CodeAnalysis.CodeGen.RawSequencePoint
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 39278, 39301);
                    return 0;
                }


                int
                f_56_39512_39527(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 39512, 39527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                f_56_38531_38548_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 38531, 38548);
                    return return_v;
                }


                int
                f_56_39637_39652(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 39637, 39652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SequencePointList
                f_56_39728_39769(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                seqPointBuilder, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    var return_v = SequencePointList.Create(seqPointBuilder, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 39728, 39769);
                    return return_v;
                }


                int
                f_56_39809_39825(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 39809, 39825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 38069, 39852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 38069, 39852);
            }
        }

        internal void DefineSequencePoint(SyntaxTree syntaxTree, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 39995, 40864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40091, 40124);

                var
                curBlock = f_56_40106_40123(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40138, 40169);

                _lastSeqPointTree = syntaxTree;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40185, 40328) || true) && (this.SeqPointsOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 40185, 40328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40248, 40313);

                    this.SeqPointsOpt = f_56_40268_40312();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 40185, 40328);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40408, 40750) || true) && (_initialHiddenSequencePointMarker >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 40408, 40750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40484, 40527);

                    f_56_40484_40526(f_56_40497_40520(this.SeqPointsOpt) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40545, 40678);

                    f_56_40545_40677(this.SeqPointsOpt, f_56_40567_40676(syntaxTree, _initialHiddenSequencePointMarker, RawSequencePoint.HiddenSequencePointSpan));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40696, 40735);

                    _initialHiddenSequencePointMarker = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 40408, 40750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 40766, 40853);

                f_56_40766_40852(
                            this.SeqPointsOpt, f_56_40788_40851(syntaxTree, f_56_40821_40844(this), span));
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 39995, 40864);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_40106_40123(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40106, 40123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                f_56_40268_40312()
                {
                    var return_v = ArrayBuilder<RawSequencePoint>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40268, 40312);
                    return return_v;
                }


                int
                f_56_40497_40520(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 40497, 40520);
                    return return_v;
                }


                int
                f_56_40484_40526(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40484, 40526);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.RawSequencePoint
                f_56_40567_40676(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                ilMarker, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.RawSequencePoint(syntaxTree, ilMarker, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40567, 40676);
                    return return_v;
                }


                int
                f_56_40545_40677(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param, Microsoft.CodeAnalysis.CodeGen.RawSequencePoint
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40545, 40677);
                    return 0;
                }


                int
                f_56_40821_40844(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.AllocateILMarker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40821, 40844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.RawSequencePoint
                f_56_40788_40851(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                ilMarker, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.RawSequencePoint(syntaxTree, ilMarker, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40788, 40851);
                    return return_v;
                }


                int
                f_56_40766_40852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param, Microsoft.CodeAnalysis.CodeGen.RawSequencePoint
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 40766, 40852);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 39995, 40864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 39995, 40864);
            }
        }

        private int _initialHiddenSequencePointMarker;

        internal void DefineHiddenSequencePoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 41894, 42334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 41960, 42002);

                var
                lastDebugDocument = _lastSeqPointTree
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 42159, 42323) || true) && (lastDebugDocument != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 42159, 42323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 42222, 42308);

                    f_56_42222_42307(this, lastDebugDocument, RawSequencePoint.HiddenSequencePointSpan);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 42159, 42323);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 41894, 42334);

                int
                f_56_42222_42307(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.DefineSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 42222, 42307);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 41894, 42334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 41894, 42334);
            }
        }

        internal void DefineInitialHiddenSequencePoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 42532, 43029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 42605, 42657);

                f_56_42605_42656(_initialHiddenSequencePointMarker < 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 42891, 42951);

                _initialHiddenSequencePointMarker = f_56_42927_42950(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 42965, 43018);

                f_56_42965_43017(_initialHiddenSequencePointMarker == 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 42532, 43029);

                int
                f_56_42605_42656(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 42605, 42656);
                    return 0;
                }


                int
                f_56_42927_42950(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.AllocateILMarker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 42927, 42950);
                    return return_v;
                }


                int
                f_56_42965_43017(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 42965, 43017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 42532, 43029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 42532, 43029);
            }
        }

        internal void SetInitialDebugDocument(SyntaxTree initialSequencePointTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 43358, 43513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 43457, 43502);

                _lastSeqPointTree = initialSequencePointTree;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 43358, 43513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 43358, 43513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 43358, 43513);
            }
        }

        [Conditional("DEBUG")]
        internal void AssertStackEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 43525, 43664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 43614, 43653);

                f_56_43614_43652(_emitState.CurStack == 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 43525, 43664);

                int
                f_56_43614_43652(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 43614, 43652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 43525, 43664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 43525, 43664);
            }
        }

        internal bool IsJustPastLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 43758, 43986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 43814, 43891);

                f_56_43814_43890(_emitState.InstructionsEmitted >= _instructionCountAtLastLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 43905, 43975);

                return _emitState.InstructionsEmitted == _instructionCountAtLastLabel;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 43758, 43986);

                int
                f_56_43814_43890(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 43814, 43890);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 43758, 43986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 43758, 43986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void OpenLocalScope(ScopeType scopeType = ScopeType.Variable, Cci.ITypeReference exceptionType = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 43998, 46380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 44134, 44317) || true) && (scopeType == ScopeType.TryCatchFinally && (DynAbs.Tracing.TraceSender.Expression_True(56, 44138, 44197) && f_56_44180_44197(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 44134, 44317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 44231, 44259);

                    f_56_44231_44258(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 44277, 44302);

                    f_56_44277_44301(this, ILOpCode.Nop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 44134, 44317);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 44333, 44820) || true) && (scopeType == ScopeType.Finally)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 44333, 44820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 44743, 44805);

                    _instructionCountAtLastLabel = _emitState.InstructionsEmitted;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 44333, 44820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 44836, 44847);

                f_56_44836_44846(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 44906, 44968);

                var
                scope = f_56_44918_44967(_scopeManager, scopeType, exceptionType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 45202, 46369);

                switch (scopeType)
                {

                    case ScopeType.Try:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 45202, 46369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 45294, 45329);

                        f_56_45294_45328(!_pendingBlockCreate);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 45351, 45378);

                        _pendingBlockCreate = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(56, 45400, 45406);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 45202, 46369);

                    case ScopeType.Catch:
                    case ScopeType.Filter:
                    case ScopeType.Finally:
                    case ScopeType.Fault:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 45202, 46369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 45589, 45624);

                        f_56_45589_45623(!_pendingBlockCreate);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 45646, 45673);

                        _pendingBlockCreate = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 46023, 46051);

                        f_56_46023_46050(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(56, 46075, 46081);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 45202, 46369);

                    case ScopeType.Variable:
                    case ScopeType.TryCatchFinally:
                    case ScopeType.StateMachineVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 45202, 46369);
                        DynAbs.Tracing.TraceSender.TraceBreak(56, 46248, 46254);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 45202, 46369);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 45202, 46369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 46302, 46354);

                        throw f_56_46308_46353(scopeType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 45202, 46369);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 43998, 46380);

                bool
                f_56_44180_44197(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.IsJustPastLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 44180, 44197);
                    return return_v;
                }


                int
                f_56_44231_44258(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.DefineHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 44231, 44258);
                    return 0;
                }


                int
                f_56_44277_44301(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 44277, 44301);
                    return 0;
                }


                int
                f_56_44836_44846(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 44836, 44846);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                f_56_44918_44967(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                scopeType, Microsoft.Cci.ITypeReference?
                exceptionType)
                {
                    var return_v = this_param.OpenScope(scopeType, exceptionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 44918, 44967);
                    return return_v;
                }


                int
                f_56_45294_45328(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 45294, 45328);
                    return 0;
                }


                int
                f_56_45589_45623(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 45589, 45623);
                    return 0;
                }


                int
                f_56_46023_46050(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.DefineHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 46023, 46050);
                    return 0;
                }


                System.Exception
                f_56_46308_46353(Microsoft.CodeAnalysis.CodeGen.ScopeType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 46308, 46353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 43998, 46380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 43998, 46380);
            }
        }

        internal bool PossiblyDefinedOutsideOfTry(LocalDefinition local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 46470, 46521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 46473, 46521);
                return f_56_46473_46521(_scopeManager, local); DynAbs.Tracing.TraceSender.TraceExitMethod(56, 46470, 46521);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 46470, 46521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 46470, 46521);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_56_46473_46521(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
            this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
            local)
            {
                var return_v = this_param.PossiblyDefinedOutsideOfTry(local);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 46473, 46521);
                return return_v;
            }

        }

        internal void MarkFilterConditionEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 46668, 47123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 46731, 46773);

                f_56_46731_46772(_scopeManager, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 47084, 47112);

                f_56_47084_47111(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 46668, 47123);

                int
                f_56_46731_46772(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    this_param.FinishFilterCondition(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 46731, 46772);
                    return 0;
                }


                int
                f_56_47084_47111(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.DefineHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 47084, 47111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 46668, 47123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 46668, 47123);
            }
        }

        internal void CloseLocalScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 47135, 47350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 47191, 47224);

                f_56_47191_47223(_scopeManager, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 47238, 47249);

                f_56_47238_47248(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 47308, 47339);

                f_56_47308_47338(_scopeManager, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 47135, 47350);

                int
                f_56_47191_47223(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    this_param.ClosingScope(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 47191, 47223);
                    return 0;
                }


                int
                f_56_47238_47248(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 47238, 47248);
                    return 0;
                }


                int
                f_56_47308_47338(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    this_param.CloseScope(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 47308, 47338);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 47135, 47350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 47135, 47350);
            }
        }

        internal void DefineUserDefinedStateMachineHoistedLocal(int slotIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 47362, 47694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 47638, 47683);

                f_56_47638_47682(            // Add user-defined local into the current scope.
                                             // We emit custom debug information for these locals that is used by the EE to reconstruct their scopes.
                            _scopeManager, slotIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 47362, 47694);

                int
                f_56_47638_47682(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, int
                slotIndex)
                {
                    this_param.AddUserHoistedLocal(slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 47638, 47682);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 47362, 47694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 47362, 47694);
            }
        }

        internal void AddLocalToScope(LocalDefinition local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 47806, 47994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 47883, 47939);

                HasDynamicLocal |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => f_56_47902_47938_M(!local.DynamicTransformFlags.IsEmpty), 56, 47883, 47898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 47953, 47983);

                f_56_47953_47982(_scopeManager, local);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 47806, 47994);

                bool
                f_56_47902_47938_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 47902, 47938);
                    return return_v;
                }


                int
                f_56_47953_47982(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                variable)
                {
                    this_param.AddLocal(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 47953, 47982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 47806, 47994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 47806, 47994);
            }
        }

        internal void AddLocalConstantToScope(LocalConstantDefinition localConstant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 48106, 48342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 48207, 48271);

                HasDynamicLocal |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => f_56_48226_48270_M(!localConstant.DynamicTransformFlags.IsEmpty), 56, 48207, 48222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 48285, 48331);

                f_56_48285_48330(_scopeManager, localConstant);
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 48106, 48342);

                bool
                f_56_48226_48270_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 48226, 48270);
                    return return_v;
                }


                int
                f_56_48285_48330(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition
                constant)
                {
                    this_param.AddLocalConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 48285, 48330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 48106, 48342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 48106, 48342);
            }
        }

        internal bool HasDynamicLocal { get; private set; }

        internal ILBuilder GetSnapshot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 48685, 48879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 48742, 48791);

                var
                snapshot = (ILBuilder)f_56_48768_48790(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 48805, 48838);

                snapshot.RealizedIL = RealizedIL;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 48852, 48868);

                return snapshot;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 48685, 48879);

                object
                f_56_48768_48790(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.MemberwiseClone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 48768, 48790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 48685, 48879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 48685, 48879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AllBlocks(Func<BasicBlock, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 48891, 49263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 48972, 48998);

                var
                current = leaderBlock
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49012, 49226) || true) && (current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 49012, 49226);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49068, 49165) || true) && (!f_56_49073_49091(predicate, current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 49068, 49165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49133, 49146);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(56, 49068, 49165);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49183, 49211);

                        current = current.NextBlock;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(56, 49012, 49226);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(56, 49012, 49226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(56, 49012, 49226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49240, 49252);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 48891, 49263);

                bool
                f_56_49073_49091(System.Func<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock, bool>
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 49073, 49091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 48891, 49263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 48891, 49263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int AllocateILMarker()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 49275, 50047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49331, 49411);

                f_56_49331_49410(this.RealizedIL.IsDefault, "Too late to allocate a new IL marker");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49425, 49564) || true) && (_allocatedILMarkers == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 49425, 49564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49490, 49549);

                    _allocatedILMarkers = f_56_49512_49548();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 49425, 49564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49580, 49620);

                BasicBlock
                curBlock = f_56_49602_49619(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49634, 49665);

                f_56_49634_49664(curBlock != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49681, 49720);

                int
                marker = f_56_49694_49719(_allocatedILMarkers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49734, 49763);

                f_56_49734_49762(curBlock, marker);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 49779, 50006);

                f_56_49779_50005(
                            _allocatedILMarkers, new ILMarker()
                            {
                                BlockOffset = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (int)f_56_49895_49929(curBlock), 56, 49821, 49990),
                                AbsoluteOffset = -1
                            });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50022, 50036);

                return marker;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 49275, 50047);

                int
                f_56_49331_49410(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 49331, 49410);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ILMarker>
                f_56_49512_49548()
                {
                    var return_v = ArrayBuilder<ILMarker>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 49512, 49548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_56_49602_49619(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 49602, 49619);
                    return return_v;
                }


                int
                f_56_49634_49664(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 49634, 49664);
                    return 0;
                }


                int
                f_56_49694_49719(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ILMarker>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 49694, 49719);
                    return return_v;
                }


                int
                f_56_49734_49762(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, int
                marker)
                {
                    this_param.AddILMarker(marker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 49734, 49762);
                    return 0;
                }


                int
                f_56_49895_49929(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructionsLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 49895, 49929);
                    return return_v;
                }


                int
                f_56_49779_50005(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ILMarker>
                this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ILMarker
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 49779, 50005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 49275, 50047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 49275, 50047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetILOffsetFromMarker(int ilMarker)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 50059, 50494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50130, 50220);

                f_56_50130_50219(f_56_50143_50164_M(!RealizedIL.IsDefault), "Builder must be realized to perform this operation");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50234, 50317);

                f_56_50234_50316(_allocatedILMarkers != null, "There are not markers in this builder");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50331, 50417);

                f_56_50331_50416(ilMarker >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(56, 50344, 50397) && ilMarker < f_56_50372_50397(_allocatedILMarkers)), "Wrong builder?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50431, 50483);

                return _allocatedILMarkers[ilMarker].AbsoluteOffset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 50059, 50494);

                bool
                f_56_50143_50164_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 50143, 50164);
                    return return_v;
                }


                int
                f_56_50130_50219(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 50130, 50219);
                    return 0;
                }


                int
                f_56_50234_50316(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 50234, 50316);
                    return 0;
                }


                int
                f_56_50372_50397(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ILMarker>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 50372, 50397);
                    return return_v;
                }


                int
                f_56_50331_50416(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 50331, 50416);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 50059, 50494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 50059, 50494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(56, 50506, 50968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50577, 50679);

                var
                visType = f_56_50591_50678("Roslyn.Test.Utilities.ILBuilderVisualizer, Roslyn.Test.Utilities", false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50693, 50923) || true) && (visType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(56, 50693, 50923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50746, 50820);

                    var
                    method = f_56_50759_50819(f_56_50759_50780(visType), "ILBuilderToString")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50838, 50908);

                    return (string)f_56_50853_50907(method, null, new object[] { this, null, null });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(56, 50693, 50923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(56, 50947, 50957);

                return "";
                DynAbs.Tracing.TraceSender.TraceExitMethod(56, 50506, 50968);

                System.Type?
                f_56_50591_50678(string
                typeName, bool
                throwOnError)
                {
                    var return_v = Type.GetType(typeName, throwOnError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 50591, 50678);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_56_50759_50780(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 50759, 50780);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_56_50759_50819(System.Reflection.TypeInfo
                this_param, string
                name)
                {
                    var return_v = this_param.GetDeclaredMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 50759, 50819);
                    return return_v;
                }


                object?
                f_56_50853_50907(System.Reflection.MethodInfo?
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 50853, 50907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(56, 50506, 50968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 50506, 50968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct ILMarker
        {

            public int BlockOffset;

            public int AbsoluteOffset;
            static ILMarker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(56, 50980, 51102);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(56, 50980, 51102);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(56, 50980, 51102);
            }
        }

        static int
        f_56_3192_3233(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 3192, 3233);
            return 0;
        }


        static Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
        f_56_3402_3425()
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 3402, 3425);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
        f_56_3472_3503(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
        this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
        builder)
        {
            var return_v = this_param.CreateBlock(builder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 3472, 3503);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
        f_56_3534_3608(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>((System.Collections.Generic.IEqualityComparer<object>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(56, 3534, 3608);
            return return_v;
        }


        Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
        f_56_7404_7443(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
        this_param)
        {
            var return_v = this_param.EnclosingExceptionHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 7404, 7443);
            return return_v;
        }


        Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
        f_56_7492_7522(Microsoft.CodeAnalysis.CodeGen.ILBuilder
        this_param)
        {
            var return_v = this_param.EnclosingExceptionHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(56, 7492, 7522);
            return return_v;
        }

    }
}
