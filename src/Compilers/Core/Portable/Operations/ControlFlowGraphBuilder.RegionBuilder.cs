// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    internal sealed partial class ControlFlowGraphBuilder
    {
        private class RegionBuilder
        {
            public ControlFlowRegionKind Kind;

            public RegionBuilder? Enclosing { get; private set; }

            public readonly ITypeSymbol? ExceptionType;

            public BasicBlockBuilder? FirstBlock;

            public BasicBlockBuilder? LastBlock;

            public ArrayBuilder<RegionBuilder>? Regions;

            public ImmutableArray<ILocalSymbol> Locals;

            public ArrayBuilder<(IMethodSymbol, ILocalFunctionOperation)>? LocalFunctions;

            public ArrayBuilder<CaptureId>? CaptureIds;

            public readonly bool IsStackSpillRegion;

            private bool _aboutToFree;

            public RegionBuilder(ControlFlowRegionKind kind, ITypeSymbol? exceptionType = null, ImmutableArray<ILocalSymbol> locals = default, bool isStackSpillRegion = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(457, 1281, 1786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 606, 610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 625, 686);
                    this.Enclosing = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 729, 742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 783, 800);
                    this.FirstBlock = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 841, 857);
                    this.LastBlock = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 908, 922);
                    this.Regions = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1057, 1078);
                    this.LocalFunctions = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1125, 1142);
                    this.CaptureIds = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1178, 1196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1235, 1255);
                    this._aboutToFree = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1477, 1587);

                    f_457_1477_1586(!isStackSpillRegion || (DynAbs.Tracing.TraceSender.Expression_False(457, 1490, 1585) || (kind == ControlFlowRegionKind.LocalLifetime && (DynAbs.Tracing.TraceSender.Expression_True(457, 1514, 1584) && locals.IsDefaultOrEmpty))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1605, 1617);

                    Kind = kind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1635, 1665);

                    ExceptionType = exceptionType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1683, 1713);

                    Locals = locals.NullToEmpty();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1731, 1771);

                    IsStackSpillRegion = isStackSpillRegion;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(457, 1281, 1786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 1281, 1786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 1281, 1786);
                }
            }

            [MemberNotNullWhen(false, nameof(FirstBlock), nameof(LastBlock))]
            public bool IsEmpty
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 1933, 2241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 1977, 2035);

                        f_457_1977_2034((FirstBlock == null) == (LastBlock == null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2164, 2190);

                        return FirstBlock == null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(457, 1933, 2241);

                        int
                        f_457_1977_2034(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 1977, 2034);
                            return 0;
                        }

#pragma warning restore CS8775
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 1802, 2256);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 1802, 2256);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            [MemberNotNullWhen(true, nameof(Regions))]
            public bool HasRegions
            {
                [MemberNotNullWhen(true, nameof(Regions))]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 2351, 2372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2354, 2372);
                        return f_457_2354_2368_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Regions, 457, 2354, 2368)?.Count) > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(457, 2351, 2372);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 2351, 2372);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 2351, 2372);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            [MemberNotNullWhen(true, nameof(LocalFunctions))]
            public bool HasLocalFunctions
            {
                [MemberNotNullWhen(true, nameof(LocalFunctions))]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 2480, 2508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2483, 2508);
                        return f_457_2483_2504_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(LocalFunctions, 457, 2483, 2504)?.Count) > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(457, 2480, 2508);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 2480, 2508);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 2480, 2508);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            [MemberNotNullWhen(true, nameof(CaptureIds))]
            public bool HasCaptureIds
            {
                [MemberNotNullWhen(true, nameof(CaptureIds))]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 2608, 2632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2611, 2632);
                        return f_457_2611_2628_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CaptureIds, 457, 2611, 2628)?.Count) > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(457, 2608, 2632);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 2608, 2632);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 2608, 2632);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void AboutToFree()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 2686, 2708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2689, 2708);
                    _aboutToFree = true; DynAbs.Tracing.TraceSender.TraceExitMethod(457, 2686, 2708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 2686, 2708);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 2686, 2708);
                }
            }

            [MemberNotNull(nameof(CaptureIds))]
            public void AddCaptureId(int captureId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 2733, 3133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2854, 2903);

                    f_457_2854_2902(Kind != ControlFlowRegionKind.Root);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2923, 3057) || true) && (CaptureIds == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 2923, 3057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 2987, 3038);

                        CaptureIds = f_457_3000_3037();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 2923, 3057);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3077, 3118);

                    f_457_3077_3117(
                                    CaptureIds, f_457_3092_3116(captureId));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 2733, 3133);

                    int
                    f_457_2854_2902(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 2854, 2902);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                    f_457_3000_3037()
                    {
                        var return_v = ArrayBuilder<CaptureId>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3000, 3037);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                    f_457_3092_3116(int
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.CaptureId(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3092, 3116);
                        return return_v;
                    }


                    int
                    f_457_3077_3117(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.CaptureId
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3077, 3117);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 2733, 3133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 2733, 3133);
                }
            }

            public void AddCaptureIds(ArrayBuilder<CaptureId>? others)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 3149, 3612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3240, 3289);

                    f_457_3240_3288(Kind != ControlFlowRegionKind.Root);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3309, 3395) || true) && (others == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 3309, 3395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3369, 3376);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 3309, 3395);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3415, 3549) || true) && (CaptureIds == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 3415, 3549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3479, 3530);

                        CaptureIds = f_457_3492_3529();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 3415, 3549);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3569, 3597);

                    f_457_3569_3596(
                                    CaptureIds, others);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 3149, 3612);

                    int
                    f_457_3240_3288(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3240, 3288);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                    f_457_3492_3529()
                    {
                        var return_v = ArrayBuilder<CaptureId>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3492, 3529);
                        return return_v;
                    }


                    int
                    f_457_3569_3596(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3569, 3596);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 3149, 3612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 3149, 3612);
                }
            }

            [MemberNotNull(nameof(LocalFunctions))]
            public void Add(IMethodSymbol symbol, ILocalFunctionOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 3628, 4233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3786, 3820);

                    f_457_3786_3819(!IsStackSpillRegion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3838, 3887);

                    f_457_3838_3886(Kind != ControlFlowRegionKind.Root);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3905, 3965);

                    f_457_3905_3964(f_457_3918_3935(symbol) == MethodKind.LocalFunction);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 3985, 4158) || true) && (LocalFunctions == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 3985, 4158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4053, 4139);

                        LocalFunctions = f_457_4070_4138();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 3985, 4158);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4178, 4218);

                    f_457_4178_4217(
                                    LocalFunctions, (symbol, operation));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 3628, 4233);

                    int
                    f_457_3786_3819(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3786, 3819);
                        return 0;
                    }


                    int
                    f_457_3838_3886(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3838, 3886);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_457_3918_3935(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 3918, 3935);
                        return return_v;
                    }


                    int
                    f_457_3905_3964(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 3905, 3964);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    f_457_4070_4138()
                    {
                        var return_v = ArrayBuilder<(IMethodSymbol, ILocalFunctionOperation)>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 4070, 4138);
                        return return_v;
                    }


                    int
                    f_457_4178_4217(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    this_param, (Microsoft.CodeAnalysis.IMethodSymbol symbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation)
                    item)
                    {
                        this_param.Add(((Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation))item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 4178, 4217);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 3628, 4233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 3628, 4233);
                }
            }

            public void AddRange(ArrayBuilder<(IMethodSymbol, ILocalFunctionOperation)>? others)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 4249, 4930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4366, 4415);

                    f_457_4366_4414(Kind != ControlFlowRegionKind.Root);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4435, 4521) || true) && (others == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 4435, 4521);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4495, 4502);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 4435, 4521);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4541, 4670);

                    f_457_4541_4669(f_457_4554_4668(others, ((IMethodSymbol m, ILocalFunctionOperation _) tuple) => tuple.m.MethodKind == MethodKind.LocalFunction));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4690, 4863) || true) && (LocalFunctions == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 4690, 4863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4758, 4844);

                        LocalFunctions = f_457_4775_4843();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 4690, 4863);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 4883, 4915);

                    f_457_4883_4914(
                                    LocalFunctions, others);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 4249, 4930);

                    int
                    f_457_4366_4414(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 4366, 4414);
                        return 0;
                    }


                    bool
                    f_457_4554_4668(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    builder, System.Func<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation), bool>
                    predicate)
                    {
                        var return_v = builder.All<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 4554, 4668);
                        return return_v;
                    }


                    int
                    f_457_4541_4669(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 4541, 4669);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    f_457_4775_4843()
                    {
                        var return_v = ArrayBuilder<(IMethodSymbol, ILocalFunctionOperation)>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 4775, 4843);
                        return return_v;
                    }


                    int
                    f_457_4883_4914(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 4883, 4914);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 4249, 4930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 4249, 4930);
                }
            }

            [MemberNotNull(nameof(Regions))]
            public void Add(RegionBuilder region)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 4946, 7290);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5062, 5194) || true) && (Regions == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 5062, 5194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5123, 5175);

                        Regions = f_457_5133_5174();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 5062, 5194);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5225, 5337);

                    f_457_5225_5336(f_457_5238_5254(region) == null || (DynAbs.Tracing.TraceSender.Expression_False(457, 5238, 5335) || (f_457_5267_5283(region)._aboutToFree && (DynAbs.Tracing.TraceSender.Expression_True(457, 5267, 5334) && f_457_5300_5326(f_457_5300_5316(region)) == this))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5364, 5388);

                    region.Enclosing = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5406, 5426);

                    f_457_5406_5425(Regions, region);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5457, 5510);

                    ControlFlowRegionKind
                    lastKind = f_457_5490_5504(Regions).Kind
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5528, 7267);

                    switch (Kind)
                    {

                        case ControlFlowRegionKind.FilterAndHandler:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 5528, 7267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5652, 5685);

                            f_457_5652_5684(f_457_5665_5678(Regions) <= 2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5711, 5818);

                            f_457_5711_5817(lastKind == ((DynAbs.Tracing.TraceSender.Conditional_F1(457, 5737, 5754) || ((f_457_5737_5750(Regions) < 2 && DynAbs.Tracing.TraceSender.Conditional_F2(457, 5757, 5785)) || DynAbs.Tracing.TraceSender.Conditional_F3(457, 5788, 5815))) ? ControlFlowRegionKind.Filter : ControlFlowRegionKind.Catch));
                            DynAbs.Tracing.TraceSender.TraceBreak(457, 5844, 5850);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(457, 5528, 7267);

                        case ControlFlowRegionKind.TryAndCatch:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 5528, 7267);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 5939, 6320) || true) && (f_457_5943_5956(Regions) == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 5939, 6320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 6019, 6071);

                                f_457_6019_6070(lastKind == ControlFlowRegionKind.Try);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 5939, 6320);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 5939, 6320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 6185, 6293);

                                f_457_6185_6292(lastKind == ControlFlowRegionKind.Catch || (DynAbs.Tracing.TraceSender.Expression_False(457, 6198, 6291) || lastKind == ControlFlowRegionKind.FilterAndHandler));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 5939, 6320);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(457, 6346, 6352);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(457, 5528, 7267);

                        case ControlFlowRegionKind.TryAndFinally:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 5528, 7267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 6443, 6476);

                            f_457_6443_6475(f_457_6456_6469(Regions) <= 2);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 6502, 6831) || true) && (f_457_6506_6519(Regions) == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 6502, 6831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 6582, 6634);

                                f_457_6582_6633(lastKind == ControlFlowRegionKind.Try);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 6502, 6831);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 6502, 6831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 6748, 6804);

                                f_457_6748_6803(lastKind == ControlFlowRegionKind.Finally);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 6502, 6831);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(457, 6857, 6863);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(457, 5528, 7267);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 5528, 7267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 6921, 6976);

                            f_457_6921_6975(lastKind != ControlFlowRegionKind.Filter);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7002, 7056);

                            f_457_7002_7055(lastKind != ControlFlowRegionKind.Catch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7082, 7138);

                            f_457_7082_7137(lastKind != ControlFlowRegionKind.Finally);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7164, 7216);

                            f_457_7164_7215(lastKind != ControlFlowRegionKind.Try);
                            DynAbs.Tracing.TraceSender.TraceBreak(457, 7242, 7248);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(457, 5528, 7267);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 4946, 7290);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    f_457_5133_5174()
                    {
                        var return_v = ArrayBuilder<RegionBuilder>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 5133, 5174);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder?
                    f_457_5238_5254(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        var return_v = this_param.Enclosing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 5238, 5254);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_5267_5283(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        var return_v = this_param.Enclosing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 5267, 5283);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_5300_5316(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        var return_v = this_param.Enclosing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 5300, 5316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder?
                    f_457_5300_5326(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        var return_v = this_param.Enclosing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 5300, 5326);
                        return return_v;
                    }


                    int
                    f_457_5225_5336(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 5225, 5336);
                        return 0;
                    }


                    int
                    f_457_5406_5425(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 5406, 5425);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_5490_5504(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Last();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 5490, 5504);
                        return return_v;
                    }


                    int
                    f_457_5665_5678(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 5665, 5678);
                        return return_v;
                    }


                    int
                    f_457_5652_5684(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 5652, 5684);
                        return 0;
                    }


                    int
                    f_457_5737_5750(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 5737, 5750);
                        return return_v;
                    }


                    int
                    f_457_5711_5817(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 5711, 5817);
                        return 0;
                    }


                    int
                    f_457_5943_5956(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 5943, 5956);
                        return return_v;
                    }


                    int
                    f_457_6019_6070(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 6019, 6070);
                        return 0;
                    }


                    int
                    f_457_6185_6292(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 6185, 6292);
                        return 0;
                    }


                    int
                    f_457_6456_6469(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 6456, 6469);
                        return return_v;
                    }


                    int
                    f_457_6443_6475(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 6443, 6475);
                        return 0;
                    }


                    int
                    f_457_6506_6519(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 6506, 6519);
                        return return_v;
                    }


                    int
                    f_457_6582_6633(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 6582, 6633);
                        return 0;
                    }


                    int
                    f_457_6748_6803(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 6748, 6803);
                        return 0;
                    }


                    int
                    f_457_6921_6975(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 6921, 6975);
                        return 0;
                    }


                    int
                    f_457_7002_7055(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7002, 7055);
                        return 0;
                    }


                    int
                    f_457_7082_7137(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7082, 7137);
                        return 0;
                    }


                    int
                    f_457_7164_7215(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7164, 7215);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 4946, 7290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 4946, 7290);
                }
            }

            public void Remove(RegionBuilder region)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 7306, 7825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7379, 7418);

                    f_457_7379_7417(f_457_7392_7408(region) == this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7436, 7466);

                    f_457_7436_7465(Regions != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7486, 7766) || true) && (f_457_7490_7503(Regions) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 7486, 7766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7550, 7585);

                        f_457_7550_7584(f_457_7563_7573(Regions, 0) == region);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7607, 7623);

                        f_457_7607_7622(Regions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 7486, 7766);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 7486, 7766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7705, 7747);

                        f_457_7705_7746(Regions, f_457_7722_7745(Regions, region));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 7486, 7766);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7786, 7810);

                    region.Enclosing = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 7306, 7825);

                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder?
                    f_457_7392_7408(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        var return_v = this_param.Enclosing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 7392, 7408);
                        return return_v;
                    }


                    int
                    f_457_7379_7417(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7379, 7417);
                        return 0;
                    }


                    int
                    f_457_7436_7465(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7436, 7465);
                        return 0;
                    }


                    int
                    f_457_7490_7503(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 7490, 7503);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_7563_7573(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 7563, 7573);
                        return return_v;
                    }


                    int
                    f_457_7550_7584(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7550, 7584);
                        return 0;
                    }


                    int
                    f_457_7607_7622(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7607, 7622);
                        return 0;
                    }


                    int
                    f_457_7722_7745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    item)
                    {
                        var return_v = this_param.IndexOf(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7722, 7745);
                        return return_v;
                    }


                    int
                    f_457_7705_7746(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, int
                    index)
                    {
                        this_param.RemoveAt(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7705, 7746);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 7306, 7825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 7306, 7825);
                }
            }

            public void ReplaceRegion(RegionBuilder toReplace, ArrayBuilder<RegionBuilder> replaceWith)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 7841, 9560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 7965, 8007);

                    f_457_7965_8006(f_457_7978_7997(toReplace) == this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8025, 8112);

                    f_457_8025_8111(toReplace.FirstBlock!.Ordinal <= f_457_8071_8090(replaceWith).FirstBlock!.Ordinal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8130, 8214);

                    f_457_8130_8213(toReplace.LastBlock!.Ordinal >= f_457_8175_8193(replaceWith).LastBlock!.Ordinal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8232, 8262);

                    f_457_8232_8261(Regions != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8282, 8295);

                    int
                    insertAt
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8315, 8591) || true) && (f_457_8319_8332(Regions) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 8315, 8591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8379, 8417);

                        f_457_8379_8416(f_457_8392_8402(Regions, 0) == toReplace);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8439, 8452);

                        insertAt = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 8315, 8591);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 8315, 8591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8534, 8572);

                        insertAt = f_457_8545_8571(Regions, toReplace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 8315, 8591);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8611, 8652);

                    int
                    replaceWithCount = f_457_8634_8651(replaceWith)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8670, 9498) || true) && (replaceWithCount == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 8670, 9498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8737, 8775);

                        RegionBuilder
                        single = f_457_8760_8774(replaceWith, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8797, 8821);

                        single.Enclosing = this;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8843, 8870);

                        Regions[insertAt] = single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 8670, 9498);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 8670, 9498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 8952, 8986);

                        int
                        originalCount = f_457_8972_8985(Regions)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9008, 9061);

                        Regions.Count = replaceWithCount - 1 + originalCount;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9094, 9115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9117, 9138);

                            for (int
        i = originalCount - 1
        ,
        j = f_457_9121_9134(Regions) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9085, 9259) || true) && (i > insertAt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9154, 9157)
        , i--, DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9159, 9162)
        , j--, DynAbs.Tracing.TraceSender.TraceExitCondition(457, 9085, 9259))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 9085, 9259);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9212, 9236);

                                Regions[j] = f_457_9225_9235(Regions, i);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 175);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 175);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9283, 9479);
                            foreach (RegionBuilder region in f_457_9316_9327_I(replaceWith))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 9283, 9479);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9377, 9401);

                                region.Enclosing = this;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9427, 9456);

                                Regions[insertAt++] = region;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 9283, 9479);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 197);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 197);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 8670, 9498);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9518, 9545);

                    toReplace.Enclosing = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 7841, 9560);

                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder?
                    f_457_7978_7997(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        var return_v = this_param.Enclosing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 7978, 7997);
                        return return_v;
                    }


                    int
                    f_457_7965_8006(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 7965, 8006);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_8071_8090(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.First();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 8071, 8090);
                        return return_v;
                    }


                    int
                    f_457_8025_8111(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 8025, 8111);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_8175_8193(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Last();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 8175, 8193);
                        return return_v;
                    }


                    int
                    f_457_8130_8213(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 8130, 8213);
                        return 0;
                    }


                    int
                    f_457_8232_8261(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 8232, 8261);
                        return 0;
                    }


                    int
                    f_457_8319_8332(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 8319, 8332);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_8392_8402(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 8392, 8402);
                        return return_v;
                    }


                    int
                    f_457_8379_8416(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 8379, 8416);
                        return 0;
                    }


                    int
                    f_457_8545_8571(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    item)
                    {
                        var return_v = this_param.IndexOf(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 8545, 8571);
                        return return_v;
                    }


                    int
                    f_457_8634_8651(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 8634, 8651);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_8760_8774(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 8760, 8774);
                        return return_v;
                    }


                    int
                    f_457_8972_8985(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 8972, 8985);
                        return return_v;
                    }


                    int
                    f_457_9121_9134(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 9121, 9134);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_9225_9235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 9225, 9235);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    f_457_9316_9327_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 9316, 9327);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 7841, 9560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 7841, 9560);
                }
            }

            [MemberNotNull(nameof(FirstBlock), nameof(LastBlock))]
            public void ExtendToInclude(BasicBlockBuilder block)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 9576, 10902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9729, 9757);

                    f_457_9729_9756(block != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 9775, 10061);

                    f_457_9775_10060((Kind != ControlFlowRegionKind.FilterAndHandler && (DynAbs.Tracing.TraceSender.Expression_True(457, 9789, 9911) && Kind != ControlFlowRegionKind.TryAndCatch) && (DynAbs.Tracing.TraceSender.Expression_True(457, 9789, 9989) && Kind != ControlFlowRegionKind.TryAndFinally)) || (DynAbs.Tracing.TraceSender.Expression_False(457, 9788, 10059) || f_457_10025_10040(Regions!).LastBlock == block));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10081, 10849) || true) && (FirstBlock == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 10081, 10849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10145, 10177);

                        f_457_10145_10176(LastBlock == null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10201, 10385) || true) && (f_457_10205_10216_M(!HasRegions))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 10201, 10385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10266, 10285);

                            FirstBlock = block;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10311, 10329);

                            LastBlock = block;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10355, 10362);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(457, 10201, 10385);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10409, 10449);

                        FirstBlock = f_457_10422_10437(Regions).FirstBlock;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10471, 10504);

                        f_457_10471_10503(FirstBlock != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10526, 10597);

                        f_457_10526_10596(f_457_10539_10552(Regions) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(457, 10539, 10595) && f_457_10561_10576(Regions).LastBlock == block));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 10081, 10849);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 10081, 10849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10679, 10728);

                        f_457_10679_10727(LastBlock!.Ordinal < block.Ordinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10750, 10830);

                        f_457_10750_10829(f_457_10763_10774_M(!HasRegions) || (DynAbs.Tracing.TraceSender.Expression_False(457, 10763, 10828) || f_457_10778_10792(Regions).LastBlock!.Ordinal <= block.Ordinal));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 10081, 10849);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10869, 10887);

                    LastBlock = block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 9576, 10902);

                    int
                    f_457_9729_9756(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 9729, 9756);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_10025_10040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Last();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10025, 10040);
                        return return_v;
                    }


                    int
                    f_457_9775_10060(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 9775, 10060);
                        return 0;
                    }


                    int
                    f_457_10145_10176(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10145, 10176);
                        return 0;
                    }


                    bool
                    f_457_10205_10216_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 10205, 10216);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_10422_10437(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.First();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10422, 10437);
                        return return_v;
                    }


                    int
                    f_457_10471_10503(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10471, 10503);
                        return 0;
                    }


                    int
                    f_457_10539_10552(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 10539, 10552);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_10561_10576(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.First();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10561, 10576);
                        return return_v;
                    }


                    int
                    f_457_10526_10596(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10526, 10596);
                        return 0;
                    }


                    int
                    f_457_10679_10727(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10679, 10727);
                        return 0;
                    }


                    bool
                    f_457_10763_10774_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 10763, 10774);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    f_457_10778_10792(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Last();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10778, 10792);
                        return return_v;
                    }


                    int
                    f_457_10750_10829(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10750, 10829);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 9576, 10902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 9576, 10902);
                }
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 10918, 11358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 10980, 11007);

                    f_457_10980_11006(_aboutToFree);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11034, 11051);

                    Enclosing = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11069, 11087);

                    FirstBlock = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11105, 11122);

                    LastBlock = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11140, 11156);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Regions, 457, 11140, 11155)?.Free(), 457, 11148, 11155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11174, 11189);

                    Regions = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11207, 11230);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(LocalFunctions, 457, 11207, 11229)?.Free(), 457, 11222, 11229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11248, 11270);

                    LocalFunctions = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11288, 11307);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CaptureIds, 457, 11288, 11306)?.Free(), 457, 11299, 11306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 11325, 11343);

                    CaptureIds = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 10918, 11358);

                    int
                    f_457_10980_11006(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 10980, 11006);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 10918, 11358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 10918, 11358);
                }
            }

            public ControlFlowRegion ToImmutableRegionAndFree(ArrayBuilder<BasicBlockBuilder> blocks,
                                                                          ArrayBuilder<IMethodSymbol> localFunctions,
                                                                          ImmutableDictionary<IMethodSymbol, (ControlFlowRegion region, ILocalFunctionOperation operation, int ordinal)>.Builder localFunctionsMap,
                                                                          ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)>.Builder? anonymousFunctionsMapOpt,
                                                                          ControlFlowRegion? enclosing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 11374, 15950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12100, 12128);

                    f_457_12100_12127(!_aboutToFree);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12155, 12178);

                    f_457_12155_12177(f_457_12168_12176_M(!IsEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12198, 12246);

                    int
                    localFunctionsBefore = f_457_12225_12245(localFunctions)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12266, 12511) || true) && (f_457_12270_12287())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 12266, 12511);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12329, 12492);
                            foreach ((IMethodSymbol method, IOperation _) in f_457_12378_12392_I(LocalFunctions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 12329, 12492);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12442, 12469);

                                f_457_12442_12468(localFunctions, method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 12329, 12492);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 164);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 164);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 12266, 12511);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12531, 12576);

                    ImmutableArray<ControlFlowRegion>
                    subRegions
                    = default(ImmutableArray<ControlFlowRegion>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12596, 13213) || true) && (f_457_12600_12610())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 12596, 13213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12652, 12725);

                        var
                        builder = f_457_12666_12724(f_457_12710_12723(Regions))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12749, 12993);
                            foreach (RegionBuilder region in f_457_12782_12789_I(Regions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 12749, 12993);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 12839, 12970);

                                f_457_12839_12969(builder, f_457_12851_12968(region, blocks, localFunctions, localFunctionsMap, anonymousFunctionsMapOpt, enclosing: null));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 12749, 12993);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 245);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 245);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 13017, 13059);

                        subRegions = f_457_13030_13058(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 12596, 13213);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 12596, 13213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 13141, 13194);

                        subRegions = ImmutableArray<ControlFlowRegion>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 12596, 13213);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 13233, 13288);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CaptureIds, 457, 13233, 13287)?.Sort((x, y) => x.Value.CompareTo(y.Value)), 457, 13244, 13287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 13308, 13839);

                    var result = new ControlFlowRegion(Kind, FirstBlock.Ordinal, LastBlock.Ordinal, subRegions,
                                                   Locals,
                                                   (LocalFunctions != null ? LocalFunctions.SelectAsArray(((IMethodSymbol, ILocalFunctionOperation) tuple) => tuple.Item1) : default),
                                                   CaptureIds?.ToImmutable() ?? default,
                                                   ExceptionType,
                                                   enclosing);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 13859, 14173) || true) && (f_457_13863_13880())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 13859, 14173);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 13922, 14154);
                            foreach ((IMethodSymbol method, ILocalFunctionOperation operation) in f_457_13992_14006_I(LocalFunctions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 13922, 14154);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14056, 14131);

                                f_457_14056_14130(localFunctionsMap, method, (result, operation, localFunctionsBefore++));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 13922, 14154);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 233);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 233);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(457, 13859, 14173);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14193, 14242);

                    int
                    firstBlockWithoutRegion = FirstBlock.Ordinal
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14262, 14613);
                        foreach (ControlFlowRegion region in f_457_14299_14309_I(subRegions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 14262, 14613);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14360, 14387);
                                for (int
            i = firstBlockWithoutRegion
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14351, 14516) || true) && (i < f_457_14393_14417(region))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14419, 14422)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(457, 14351, 14516))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 14351, 14516);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14472, 14493);

                                    f_457_14472_14492(f_457_14482_14491(blocks, i));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 166);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 166);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14540, 14594);

                            firstBlockWithoutRegion = f_457_14566_14589(region) + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(457, 14262, 14613);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 352);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 352);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14642, 14669);

                        for (int
        i = firstBlockWithoutRegion
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14633, 14780) || true) && (i <= LastBlock.Ordinal)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14695, 14698)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(457, 14633, 14780))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 14633, 14780);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14740, 14761);

                            f_457_14740_14760(f_457_14750_14759(blocks, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 148);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14811, 14825);

                    f_457_14811_14824(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14852, 14859);

                    f_457_14852_14858(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14877, 14891);

                    return result;

                    void setRegion(BasicBlockBuilder block)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 14911, 15935);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 14991, 15026);

                            f_457_14991_15025(block.Region == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 15048, 15070);

                            block.Region = result;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 15192, 15916) || true) && (anonymousFunctionsMapOpt != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 15192, 15916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 15278, 15458);

                                (ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)>.Builder map, ControlFlowRegion region)
                                argument = (anonymousFunctionsMapOpt, result)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 15486, 15792) || true) && (f_457_15490_15509(block))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 15486, 15792);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 15567, 15765);
                                        foreach (IOperation o in f_457_15592_15611_I(f_457_15592_15611(block)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 15567, 15765);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 15677, 15734);

                                            f_457_15677_15733(AnonymousFunctionsMapBuilder.Instance, o, argument);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(457, 15567, 15765);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 199);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 199);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(457, 15486, 15792);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 15820, 15893);

                                f_457_15820_15892(
                                                        AnonymousFunctionsMapBuilder.Instance, block.BranchValue, argument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 15192, 15916);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(457, 14911, 15935);

                            int
                            f_457_14991_15025(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 14991, 15025);
                                return 0;
                            }


                            bool
                            f_457_15490_15509(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                            this_param)
                            {
                                var return_v = this_param.HasStatements;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 15490, 15509);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                            f_457_15592_15611(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                            this_param)
                            {
                                var return_v = this_param.StatementsOpt;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 15592, 15611);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.IOperation?
                            f_457_15677_15733(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder.AnonymousFunctionsMapBuilder
                            this_param, Microsoft.CodeAnalysis.IOperation
                            operation, (System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>.Builder map, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region)
                            argument)
                            {
                                var return_v = this_param.Visit(operation, argument);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 15677, 15733);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                            f_457_15592_15611_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 15592, 15611);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.IOperation?
                            f_457_15820_15892(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder.AnonymousFunctionsMapBuilder
                            this_param, Microsoft.CodeAnalysis.IOperation?
                            operation, (System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>.Builder map, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region)
                            argument)
                            {
                                var return_v = this_param.Visit(operation, argument);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 15820, 15892);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 14911, 15935);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 14911, 15935);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(457, 11374, 15950);

                    int
                    f_457_12100_12127(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12100, 12127);
                        return 0;
                    }


                    bool
                    f_457_12168_12176_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 12168, 12176);
                        return return_v;
                    }


                    int
                    f_457_12155_12177(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12155, 12177);
                        return 0;
                    }


                    int
                    f_457_12225_12245(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 12225, 12245);
                        return return_v;
                    }


                    bool
                    f_457_12270_12287()
                    {
                        var return_v = HasLocalFunctions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 12270, 12287);
                        return return_v;
                    }


                    int
                    f_457_12442_12468(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12442, 12468);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    f_457_12378_12392_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12378, 12392);
                        return return_v;
                    }


                    bool
                    f_457_12600_12610()
                    {
                        var return_v = HasRegions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 12600, 12610);
                        return return_v;
                    }


                    int
                    f_457_12710_12723(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 12710, 12723);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_457_12666_12724(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<ControlFlowRegion>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12666, 12724);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    f_457_12851_12968(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    blocks, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>
                    localFunctions, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.IMethodSymbol, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal)>.Builder
                    localFunctionsMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>.Builder?
                    anonymousFunctionsMapOpt, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                    enclosing)
                    {
                        var return_v = this_param.ToImmutableRegionAndFree(blocks, localFunctions, localFunctionsMap, anonymousFunctionsMapOpt, enclosing: enclosing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12851, 12968);
                        return return_v;
                    }


                    int
                    f_457_12839_12969(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12839, 12969);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    f_457_12782_12789_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 12782, 12789);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_457_13030_13058(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 13030, 13058);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>?
                    f_457_13527_13606(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    items, System.Func<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation), Microsoft.CodeAnalysis.IMethodSymbol>
                    map)
                    {
                        var return_v = items?.SelectAsArray<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation), Microsoft.CodeAnalysis.IMethodSymbol>(map);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 13527, 13606);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>?
                    f_457_13671_13696_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 13671, 13696);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    f_457_13321_13838(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                    kind, int
                    firstBlockOrdinal, int
                    lastBlockOrdinal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    nestedRegions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                    locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                    methods, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.CaptureId>
                    captureIds, Microsoft.CodeAnalysis.ITypeSymbol?
                    exceptionType, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                    enclosingRegion)
                    {
                        var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion(kind, firstBlockOrdinal, lastBlockOrdinal, nestedRegions, locals, methods, captureIds, exceptionType, enclosingRegion);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 13321, 13838);
                        return return_v;
                    }


                    bool
                    f_457_13863_13880()
                    {
                        var return_v = HasLocalFunctions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 13863, 13880);
                        return return_v;
                    }


                    int
                    f_457_14056_14130(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.IMethodSymbol, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal)>.Builder
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    key, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion result, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int)
                    value)
                    {
                        this_param.Add(key, ((Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, int ordinal))value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 14056, 14130);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    f_457_13992_14006_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.IMethodSymbol, Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation)>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 13992, 14006);
                        return return_v;
                    }


                    int
                    f_457_14393_14417(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    this_param)
                    {
                        var return_v = this_param.FirstBlockOrdinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 14393, 14417);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    f_457_14482_14491(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 14482, 14491);
                        return return_v;
                    }


                    int
                    f_457_14472_14492(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    block)
                    {
                        setRegion(block);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 14472, 14492);
                        return 0;
                    }


                    int
                    f_457_14566_14589(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    this_param)
                    {
                        var return_v = this_param.LastBlockOrdinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 14566, 14589);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_457_14299_14309_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 14299, 14309);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    f_457_14750_14759(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 14750, 14759);
                        return return_v;
                    }


                    int
                    f_457_14740_14760(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    block)
                    {
                        setRegion(block);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 14740, 14760);
                        return 0;
                    }


                    int
                    f_457_14811_14824(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        this_param.AboutToFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 14811, 14824);
                        return 0;
                    }


                    int
                    f_457_14852_14858(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 14852, 14858);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 11374, 15950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 11374, 15950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private sealed class AnonymousFunctionsMapBuilder :
                            OperationVisitor<(ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)>.Builder map, ControlFlowRegion region), IOperation>
            {
                public static readonly AnonymousFunctionsMapBuilder Instance;

                public override IOperation? VisitFlowAnonymousFunction(
                                    IFlowAnonymousFunctionOperation operation,
                                    (ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)>.Builder map, ControlFlowRegion region) argument)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 16349, 16842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 16674, 16741);

                        f_457_16674_16740(argument.map, operation, (argument.region, f_457_16720_16738(argument.map)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 16763, 16823);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFlowAnonymousFunction(operation, argument), 457, 16770, 16822);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(457, 16349, 16842);

                        int
                        f_457_16720_16738(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>.Builder
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 16720, 16738);
                            return return_v;
                        }


                        int
                        f_457_16674_16740(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>.Builder
                        this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
                        key, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int Count)
                        value)
                        {
                            this_param.Add(key, ((Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal))value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 16674, 16740);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 16349, 16842);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 16349, 16842);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal override IOperation? VisitNoneOperation(IOperation operation, (ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)>.Builder map, ControlFlowRegion region) argument)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 16862, 17177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 17117, 17158);

                        return f_457_17124_17157(this, operation, argument);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(457, 16862, 17177);

                        Microsoft.CodeAnalysis.IOperation?
                        f_457_17124_17157(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder.AnonymousFunctionsMapBuilder
                        this_param, Microsoft.CodeAnalysis.IOperation
                        operation, (System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>.Builder map, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region)
                        argument)
                        {
                            var return_v = this_param.DefaultVisit(operation, argument);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 17124, 17157);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 16862, 17177);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 16862, 17177);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override IOperation? DefaultVisit(
                                    IOperation operation,
                                    (ImmutableDictionary<IFlowAnonymousFunctionOperation, (ControlFlowRegion region, int ordinal)>.Builder map, ControlFlowRegion region) argument)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(457, 17197, 17705);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 17487, 17650);
                            foreach (IOperation child in f_457_17516_17554_I(f_457_17516_17554(((Operation)operation))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(457, 17487, 17650);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 17604, 17627);

                                f_457_17604_17626(this, child, argument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(457, 17487, 17650);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(457, 1, 164);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(457, 1, 164);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 17674, 17686);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(457, 17197, 17705);

                        Microsoft.CodeAnalysis.Operation.Enumerable
                        f_457_17516_17554(Microsoft.CodeAnalysis.Operation
                        this_param)
                        {
                            var return_v = this_param.ChildOperations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 17516, 17554);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IOperation?
                        f_457_17604_17626(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder.AnonymousFunctionsMapBuilder
                        this_param, Microsoft.CodeAnalysis.IOperation
                        operation, (System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation, (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region, int ordinal)>.Builder map, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion region)
                        argument)
                        {
                            var return_v = this_param.Visit(operation, argument);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 17604, 17626);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Operation.Enumerable
                        f_457_17516_17554_I(Microsoft.CodeAnalysis.Operation.Enumerable
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 17516, 17554);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(457, 17197, 17705);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 17197, 17705);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public AnonymousFunctionsMapBuilder()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(457, 15966, 17720);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(457, 15966, 17720);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 15966, 17720);
                }


                static AnonymousFunctionsMapBuilder()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(457, 15966, 17720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(457, 16283, 16328);
                    Instance = f_457_16294_16328(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(457, 15966, 17720);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 15966, 17720);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(457, 15966, 17720);

                static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder.AnonymousFunctionsMapBuilder
                f_457_16294_16328()
                {
                    var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.RegionBuilder.AnonymousFunctionsMapBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 16294, 16328);
                    return return_v;
                }

            }

            static RegionBuilder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(457, 525, 17731);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(457, 525, 17731);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(457, 525, 17731);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(457, 525, 17731);

            static int
            f_457_1477_1586(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(457, 1477, 1586);
                return 0;
            }


            int?
            f_457_2354_2368_M(int?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 2354, 2368);
                return return_v;
            }


            int?
            f_457_2483_2504_M(int?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 2483, 2504);
                return return_v;
            }


            int?
            f_457_2611_2628_M(int?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(457, 2611, 2628);
                return return_v;
            }

        }
    }
}
