// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class MethodBody : Cci.IMethodBody
    {
        private readonly Cci.IMethodDefinition _parent;

        private readonly ImmutableArray<byte> _ilBits;

        private readonly ushort _maxStack;

        private readonly ImmutableArray<Cci.ILocalDefinition> _locals;

        private readonly ImmutableArray<Cci.ExceptionHandlerRegion> _exceptionHandlers;

        private readonly bool _areLocalsZeroed;

        private readonly ImmutableArray<Cci.SequencePoint> _sequencePoints;

        private readonly ImmutableArray<Cci.LocalScope> _localScopes;

        private readonly Cci.IImportScope _importScopeOpt;

        private readonly string _stateMachineTypeNameOpt;

        private readonly ImmutableArray<StateMachineHoistedLocalScope> _stateMachineHoistedLocalScopes;

        private readonly bool _hasDynamicLocalVariables;

        private readonly StateMachineMoveNextBodyDebugInfo _stateMachineMoveNextDebugInfoOpt;

        private readonly DebugId _methodId;

        private readonly ImmutableArray<EncHoistedLocalInfo> _stateMachineHoistedLocalSlots;

        private readonly ImmutableArray<LambdaDebugInfo> _lambdaDebugInfo;

        private readonly ImmutableArray<ClosureDebugInfo> _closureDebugInfo;

        private readonly ImmutableArray<Cci.ITypeReference> _stateMachineAwaiterSlots;

        private readonly DynamicAnalysisMethodBodyData _dynamicAnalysisDataOpt;

        public MethodBody(
                    ImmutableArray<byte> ilBits,
                    ushort maxStack,
                    Cci.IMethodDefinition parent,
                    DebugId methodId,
                    ImmutableArray<Cci.ILocalDefinition> locals,
                    SequencePointList sequencePoints,
                    DebugDocumentProvider debugDocumentProvider,
                    ImmutableArray<Cci.ExceptionHandlerRegion> exceptionHandlers,
                    bool areLocalsZeroed,
                    bool hasStackalloc,
                    ImmutableArray<Cci.LocalScope> localScopes,
                    bool hasDynamicLocalVariables,
                    Cci.IImportScope importScopeOpt,
                    ImmutableArray<LambdaDebugInfo> lambdaDebugInfo,
                    ImmutableArray<ClosureDebugInfo> closureDebugInfo,
                    string stateMachineTypeNameOpt,
                    ImmutableArray<StateMachineHoistedLocalScope> stateMachineHoistedLocalScopes,
                    ImmutableArray<EncHoistedLocalInfo> stateMachineHoistedLocalSlots,
                    ImmutableArray<Cci.ITypeReference> stateMachineAwaiterSlots,
                    StateMachineMoveNextBodyDebugInfo stateMachineMoveNextDebugInfoOpt,
                    DynamicAnalysisMethodBodyData dynamicAnalysisDataOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(76, 2246, 4692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 633, 640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 733, 742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 936, 952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 1255, 1270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 1305, 1329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 1467, 1492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 1554, 1587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 2210, 2233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 7298, 7332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3452, 3484);

                f_76_3452_3483(f_76_3465_3482_M(!locals.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3498, 3541);

                f_76_3498_3540(f_76_3511_3539_M(!exceptionHandlers.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3555, 3592);

                f_76_3555_3591(f_76_3568_3590_M(!localScopes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3608, 3625);

                _ilBits = ilBits;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3639, 3660);

                _maxStack = maxStack;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3674, 3691);

                _parent = parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3705, 3726);

                _methodId = methodId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3740, 3757);

                _locals = locals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3771, 3810);

                _exceptionHandlers = exceptionHandlers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3824, 3859);

                _areLocalsZeroed = areLocalsZeroed;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3873, 3903);

                HasStackalloc = hasStackalloc;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3917, 3944);

                _localScopes = localScopes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 3958, 4011);

                _hasDynamicLocalVariables = hasDynamicLocalVariables;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4025, 4058);

                _importScopeOpt = importScopeOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4072, 4107);

                _lambdaDebugInfo = lambdaDebugInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4121, 4158);

                _closureDebugInfo = closureDebugInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4172, 4223);

                _stateMachineTypeNameOpt = stateMachineTypeNameOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4237, 4302);

                _stateMachineHoistedLocalScopes = stateMachineHoistedLocalScopes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4316, 4379);

                _stateMachineHoistedLocalSlots = stateMachineHoistedLocalSlots;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4393, 4446);

                _stateMachineAwaiterSlots = stateMachineAwaiterSlots;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4460, 4529);

                _stateMachineMoveNextDebugInfoOpt = stateMachineMoveNextDebugInfoOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4543, 4592);

                _dynamicAnalysisDataOpt = dynamicAnalysisDataOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4606, 4681);

                _sequencePoints = f_76_4624_4680(sequencePoints, debugDocumentProvider);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(76, 2246, 4692);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 2246, 4692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 2246, 4692);
            }
        }

        private static ImmutableArray<Cci.SequencePoint> GetSequencePoints(SequencePointList? sequencePoints, DebugDocumentProvider debugDocumentProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(76, 4704, 5281);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4875, 5023) || true) && (sequencePoints == null || (DynAbs.Tracing.TraceSender.Expression_False(76, 4879, 4927) || f_76_4905_4927(sequencePoints)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(76, 4875, 5023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 4961, 5008);

                    return ImmutableArray<Cci.SequencePoint>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(76, 4875, 5023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5039, 5113);

                var
                sequencePointsBuilder = f_76_5067_5112()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5127, 5206);

                f_76_5127_5205(sequencePoints, debugDocumentProvider, sequencePointsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5220, 5270);

                return f_76_5227_5269(sequencePointsBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(76, 4704, 5281);

                bool
                f_76_4905_4927(Microsoft.CodeAnalysis.CodeGen.SequencePointList
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(76, 4905, 4927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.SequencePoint>
                f_76_5067_5112()
                {
                    var return_v = ArrayBuilder<Cci.SequencePoint>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(76, 5067, 5112);
                    return return_v;
                }


                int
                f_76_5127_5205(Microsoft.CodeAnalysis.CodeGen.SequencePointList
                this_param, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                documentProvider, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.SequencePoint>
                builder)
                {
                    this_param.GetSequencePoints(documentProvider, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(76, 5127, 5205);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                f_76_5227_5269(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.SequencePoint>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(76, 5227, 5269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 4704, 5281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 4704, 5281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        DynamicAnalysisMethodBodyData Cci.IMethodBody.DynamicAnalysisData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5359, 5385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5362, 5385);
                    return _dynamicAnalysisDataOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5359, 5385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5359, 5385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5359, 5385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ExceptionHandlerRegion> Cci.IMethodBody.ExceptionRegions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5474, 5495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5477, 5495);
                    return _exceptionHandlers; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5474, 5495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5474, 5495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5474, 5495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodBody.AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5545, 5564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5548, 5564);
                    return _areLocalsZeroed; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5545, 5564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5545, 5564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5545, 5564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ILocalDefinition> Cci.IMethodBody.LocalVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5645, 5655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5648, 5655);
                    return _locals; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5645, 5655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5645, 5655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5645, 5655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodDefinition Cci.IMethodBody.MethodDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5723, 5733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5726, 5733);
                    return _parent; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5723, 5733);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5723, 5733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5723, 5733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        StateMachineMoveNextBodyDebugInfo Cci.IMethodBody.MoveNextBodyInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5813, 5849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5816, 5849);
                    return _stateMachineMoveNextDebugInfoOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5813, 5849);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5813, 5849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5813, 5849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.IMethodBody.MaxStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5894, 5906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5897, 5906);
                    return _maxStack; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5894, 5906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5894, 5906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5894, 5906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<byte> IL
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 5950, 5960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 5953, 5960);
                    return _ilBits; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 5950, 5960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 5950, 5960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 5950, 5960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.SequencePoint> SequencePoints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6029, 6047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6032, 6047);
                    return _sequencePoints; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6029, 6047);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6029, 6047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6029, 6047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.LocalScope> Cci.IMethodBody.LocalScopes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6119, 6134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6122, 6134);
                    return _localScopes; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6119, 6134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6119, 6134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6119, 6134);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IImportScope Cci.IMethodBody.ImportScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6332, 6350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6335, 6350);
                    return _importScopeOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6332, 6350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6332, 6350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6332, 6350);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string Cci.IMethodBody.StateMachineTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6407, 6434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6410, 6434);
                    return _stateMachineTypeNameOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6407, 6434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6407, 6434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6407, 6434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<StateMachineHoistedLocalScope> Cci.IMethodBody.StateMachineHoistedLocalScopes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6553, 6587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6556, 6587);
                    return _stateMachineHoistedLocalScopes; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6553, 6587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6553, 6587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6553, 6587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<EncHoistedLocalInfo> Cci.IMethodBody.StateMachineHoistedLocalSlots
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6695, 6728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6698, 6728);
                    return _stateMachineHoistedLocalSlots; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6695, 6728);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6695, 6728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6695, 6728);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ITypeReference> Cci.IMethodBody.StateMachineAwaiterSlots
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6830, 6858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6833, 6858);
                    return _stateMachineAwaiterSlots; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6830, 6858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6830, 6858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6830, 6858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodBody.HasDynamicLocalVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6917, 6945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6920, 6945);
                    return _hasDynamicLocalVariables; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6917, 6945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6917, 6945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6917, 6945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DebugId MethodId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 6982, 6994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 6985, 6994);
                    return _methodId; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 6982, 6994);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 6982, 6994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 6982, 6994);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<LambdaDebugInfo> LambdaDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 7062, 7081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 7065, 7081);
                    return _lambdaDebugInfo; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 7062, 7081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 7062, 7081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 7062, 7081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ClosureDebugInfo> ClosureDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(76, 7151, 7171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(76, 7154, 7171);
                    return _closureDebugInfo; DynAbs.Tracing.TraceSender.TraceExitMethod(76, 7151, 7171);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(76, 7151, 7171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 7151, 7171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasStackalloc { get; }

        static MethodBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(76, 527, 7339);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(76, 527, 7339);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(76, 527, 7339);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(76, 527, 7339);

        bool
        f_76_3465_3482_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(76, 3465, 3482);
            return return_v;
        }


        static int
        f_76_3452_3483(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(76, 3452, 3483);
            return 0;
        }


        bool
        f_76_3511_3539_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(76, 3511, 3539);
            return return_v;
        }


        static int
        f_76_3498_3540(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(76, 3498, 3540);
            return 0;
        }


        bool
        f_76_3568_3590_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(76, 3568, 3590);
            return return_v;
        }


        static int
        f_76_3555_3591(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(76, 3555, 3591);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
        f_76_4624_4680(Microsoft.CodeAnalysis.CodeGen.SequencePointList
        sequencePoints, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
        debugDocumentProvider)
        {
            var return_v = GetSequencePoints(sequencePoints, debugDocumentProvider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(76, 4624, 4680);
            return return_v;
        }

    }
}
