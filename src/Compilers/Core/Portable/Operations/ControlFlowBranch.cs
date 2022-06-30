// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    public sealed class ControlFlowBranch
    {
        private ImmutableArray<ControlFlowRegion> _lazyLeavingRegions;

        private ImmutableArray<ControlFlowRegion> _lazyFinallyRegions;

        private ImmutableArray<ControlFlowRegion> _lazyEnteringRegions;

        internal ControlFlowBranch(
                    BasicBlock source,
                    BasicBlock? destination,
                    ControlFlowBranchSemantics semantics,
                    bool isConditionalSuccessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(448, 876, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1363, 1396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1508, 1547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1702, 1754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1949, 1992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1091, 1107);

                Source = source;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1121, 1147);

                Destination = destination;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1161, 1183);

                Semantics = semantics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 1197, 1245);

                IsConditionalSuccessor = isConditionalSuccessor;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(448, 876, 1256);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(448, 876, 1256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(448, 876, 1256);
            }
        }

        public BasicBlock Source { get; }

        public BasicBlock? Destination { get; }

        public ControlFlowBranchSemantics Semantics { get; }

        public bool IsConditionalSuccessor { get; }

        public ImmutableArray<ControlFlowRegion> LeavingRegions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(448, 2256, 2946);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 2292, 2884) || true) && (_lazyLeavingRegions.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 2292, 2884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 2367, 2408);

                        ImmutableArray<ControlFlowRegion>
                        result
                        = default(ImmutableArray<ControlFlowRegion>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 2432, 2765) || true) && (f_448_2436_2447() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 2432, 2765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 2505, 2554);

                            result = ImmutableArray<ControlFlowRegion>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(448, 2432, 2765);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 2432, 2765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 2652, 2742);

                            result = f_448_2661_2741(f_448_2661_2720(f_448_2676_2695(f_448_2676_2687()), f_448_2697_2719(f_448_2697_2703())));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(448, 2432, 2765);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 2789, 2865);

                        f_448_2789_2864(ref _lazyLeavingRegions, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(448, 2292, 2884);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 2904, 2931);

                    return _lazyLeavingRegions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(448, 2256, 2946);

                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                    f_448_2436_2447()
                    {
                        var return_v = Destination;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 2436, 2447);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    f_448_2676_2687()
                    {
                        var return_v = Destination;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 2676, 2687);
                        return return_v;
                    }


                    int
                    f_448_2676_2695(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 2676, 2695);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    f_448_2697_2703()
                    {
                        var return_v = Source;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 2697, 2703);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    f_448_2697_2719(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingRegion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 2697, 2719);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_448_2661_2720(int
                    destinationOrdinal, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    source)
                    {
                        var return_v = CollectRegions(destinationOrdinal, source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 2661, 2720);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_448_2661_2741(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 2661, 2741);
                        return return_v;
                    }


                    bool
                    f_448_2789_2864(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 2789, 2864);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(448, 2176, 2957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(448, 2176, 2957);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static ArrayBuilder<ControlFlowRegion> CollectRegions(int destinationOrdinal, ControlFlowRegion source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(448, 2969, 3527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3105, 3165);

                var
                builder = f_448_3119_3164()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3181, 3485) || true) && (!f_448_3189_3229(source, destinationOrdinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 3181, 3485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3263, 3319);

                        f_448_3263_3318(f_448_3276_3287(source) != ControlFlowRegionKind.Root);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3337, 3382);

                        f_448_3337_3381(f_448_3350_3372(source) != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3400, 3420);

                        f_448_3400_3419(builder, source);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3438, 3470);

                        source = f_448_3447_3469(source);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(448, 3181, 3485);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(448, 3181, 3485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(448, 3181, 3485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3501, 3516);

                return builder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(448, 2969, 3527);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                f_448_3119_3164()
                {
                    var return_v = ArrayBuilder<ControlFlowRegion>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 3119, 3164);
                    return return_v;
                }


                bool
                f_448_3189_3229(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param, int
                destinationOrdinal)
                {
                    var return_v = this_param.ContainsBlock(destinationOrdinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 3189, 3229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                f_448_3276_3287(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 3276, 3287);
                    return return_v;
                }


                int
                f_448_3263_3318(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 3263, 3318);
                    return 0;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
                f_448_3350_3372(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 3350, 3372);
                    return return_v;
                }


                int
                f_448_3337_3381(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 3337, 3381);
                    return 0;
                }


                int
                f_448_3400_3419(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 3400, 3419);
                    return 0;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                f_448_3447_3469(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                this_param)
                {
                    var return_v = this_param.EnclosingRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 3447, 3469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(448, 2969, 3527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(448, 2969, 3527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<ControlFlowRegion> EnteringRegions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(448, 3793, 4614);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3829, 4551) || true) && (_lazyEnteringRegions.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 3829, 4551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3905, 3946);

                        ImmutableArray<ControlFlowRegion>
                        result
                        = default(ImmutableArray<ControlFlowRegion>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 3970, 4431) || true) && (f_448_3974_3985() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 3970, 4431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 4043, 4092);

                            result = ImmutableArray<ControlFlowRegion>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(448, 3970, 4431);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 3970, 4431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 4190, 4292);

                            ArrayBuilder<ControlFlowRegion>
                            builder = f_448_4232_4291(f_448_4247_4261(f_448_4247_4253()), f_448_4263_4290(f_448_4263_4274()))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 4318, 4344);

                            f_448_4318_4343(builder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 4370, 4408);

                            result = f_448_4379_4407(builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(448, 3970, 4431);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 4455, 4532);

                        f_448_4455_4531(ref _lazyEnteringRegions, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(448, 3829, 4551);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 4571, 4599);

                    return _lazyEnteringRegions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(448, 3793, 4614);

                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                    f_448_3974_3985()
                    {
                        var return_v = Destination;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 3974, 3985);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    f_448_4247_4253()
                    {
                        var return_v = Source;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 4247, 4253);
                        return return_v;
                    }


                    int
                    f_448_4247_4261(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 4247, 4261);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    f_448_4263_4274()
                    {
                        var return_v = Destination;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 4263, 4274);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    f_448_4263_4290(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingRegion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 4263, 4290);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_448_4232_4291(int
                    destinationOrdinal, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    source)
                    {
                        var return_v = CollectRegions(destinationOrdinal, source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 4232, 4291);
                        return return_v;
                    }


                    int
                    f_448_4318_4343(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param)
                    {
                        this_param.ReverseContents();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 4318, 4343);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_448_4379_4407(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 4379, 4407);
                        return return_v;
                    }


                    bool
                    f_448_4455_4531(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 4455, 4531);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(448, 3712, 4625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(448, 3712, 4625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ControlFlowRegion> FinallyRegions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(448, 4927, 6234);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 4963, 6172) || true) && (_lazyFinallyRegions.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 4963, 6172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5038, 5086);

                        ArrayBuilder<ControlFlowRegion>?
                        builder = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5108, 5174);

                        ImmutableArray<ControlFlowRegion>
                        leavingRegions = f_448_5159_5173()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5196, 5235);

                        int
                        stopAt = leavingRegions.Length - 1
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5266, 5271);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5257, 5927) || true) && (i < stopAt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5285, 5288)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(448, 5257, 5927))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 5257, 5927);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5338, 5904) || true) && (f_448_5342_5364(leavingRegions[i]) == ControlFlowRegionKind.Try && (DynAbs.Tracing.TraceSender.Expression_True(448, 5342, 5462) && f_448_5397_5423(leavingRegions[i + 1]) == ControlFlowRegionKind.TryAndFinally))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 5338, 5904);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5520, 5692) || true) && (builder == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(448, 5520, 5692);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5605, 5661);

                                        builder = f_448_5615_5660();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(448, 5520, 5692);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5724, 5780);

                                    f_448_5724_5779(
                                                                builder, leavingRegions[i + 1].NestedRegions.Last());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5810, 5877);

                                    f_448_5810_5876(f_448_5823_5842(f_448_5823_5837(builder)) == ControlFlowRegionKind.Finally);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(448, 5338, 5904);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(448, 1, 671);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(448, 1, 671);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 5951, 6053);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(448, 5964, 5979) || ((builder == null && DynAbs.Tracing.TraceSender.Conditional_F2(448, 5982, 6021)) || DynAbs.Tracing.TraceSender.Conditional_F3(448, 6024, 6052))) ? ImmutableArray<ControlFlowRegion>.Empty : f_448_6024_6052(builder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 6077, 6153);

                        f_448_6077_6152(ref _lazyFinallyRegions, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(448, 4963, 6172);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(448, 6192, 6219);

                    return _lazyFinallyRegions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(448, 4927, 6234);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_448_5159_5173()
                    {
                        var return_v = LeavingRegions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 5159, 5173);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                    f_448_5342_5364(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 5342, 5364);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                    f_448_5397_5423(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 5397, 5423);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_448_5615_5660()
                    {
                        var return_v = ArrayBuilder<ControlFlowRegion>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 5615, 5660);
                        return return_v;
                    }


                    int
                    f_448_5724_5779(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 5724, 5779);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    f_448_5823_5837(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param)
                    {
                        var return_v = this_param.Last();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 5823, 5837);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
                    f_448_5823_5842(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(448, 5823, 5842);
                        return return_v;
                    }


                    int
                    f_448_5810_5876(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 5810, 5876);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    f_448_6024_6052(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 6024, 6052);
                        return return_v;
                    }


                    bool
                    f_448_6077_6152(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(448, 6077, 6152);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(448, 4847, 6245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(448, 4847, 6245);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ControlFlowBranch()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(448, 603, 6252);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(448, 603, 6252);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(448, 603, 6252);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(448, 603, 6252);
    }
}
