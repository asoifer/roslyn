// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    public sealed class ControlFlowRegion
    {
        public ControlFlowRegionKind Kind { get; }

        public ControlFlowRegion? EnclosingRegion { get; private set; }

        public ITypeSymbol? ExceptionType { get; }

        public int FirstBlockOrdinal { get; }

        public int LastBlockOrdinal { get; }

        public ImmutableArray<ControlFlowRegion> NestedRegions { get; }

        public ImmutableArray<ILocalSymbol> Locals { get; }

        public ImmutableArray<IMethodSymbol> LocalFunctions { get; }

        public ImmutableArray<CaptureId> CaptureIds { get; }

        internal ControlFlowRegion(ControlFlowRegionKind kind, int firstBlockOrdinal, int lastBlockOrdinal,
                                ImmutableArray<ControlFlowRegion> nestedRegions,
                                ImmutableArray<ILocalSymbol> locals,
                                ImmutableArray<IMethodSymbol> methods,
                                ImmutableArray<CaptureId> captureIds,
                                ITypeSymbol? exceptionType,
                                ControlFlowRegion? enclosingRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(459, 2381, 6479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 703, 745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 885, 948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 1201, 1243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 1416, 1453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 1625, 1661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 2882, 2919);

                f_459_2882_2918(firstBlockOrdinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 2933, 2985);

                f_459_2933_2984(lastBlockOrdinal >= firstBlockOrdinal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3001, 3013);

                Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3027, 3065);

                FirstBlockOrdinal = firstBlockOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3079, 3115);

                LastBlockOrdinal = lastBlockOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3129, 3159);

                ExceptionType = exceptionType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3173, 3203);

                Locals = locals.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3217, 3256);

                LocalFunctions = methods.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3270, 3308);

                CaptureIds = captureIds.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3322, 3366);

                NestedRegions = nestedRegions.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3380, 3414);

                EnclosingRegion = enclosingRegion;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3430, 3647);
                    foreach (ControlFlowRegion r in f_459_3462_3475_I(f_459_3462_3475()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(459, 3430, 3647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3509, 3589);

                        f_459_3509_3588(f_459_3522_3539(r) == null && (DynAbs.Tracing.TraceSender.Expression_True(459, 3522, 3587) && f_459_3551_3557(r) != ControlFlowRegionKind.Root));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3607, 3632);

                        r.EnclosingRegion = this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(459, 3430, 3647);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(459, 1, 218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(459, 1, 218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3672, 3689);

                int
                previousLast
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3705, 6460);

                switch (kind)
                {

                    case ControlFlowRegionKind.TryAndFinally:
                    case ControlFlowRegionKind.FilterAndHandler:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(459, 3705, 6460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3876, 3916);

                        f_459_3876_3915(f_459_3889_3902().Length == 2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 3938, 4082);

                        f_459_3938_4081(f_459_3951_3972(f_459_3951_3964()[0]) == ((DynAbs.Tracing.TraceSender.Conditional_F1(459, 3977, 4020) || ((kind == ControlFlowRegionKind.TryAndFinally && DynAbs.Tracing.TraceSender.Conditional_F2(459, 4023, 4048)) || DynAbs.Tracing.TraceSender.Conditional_F3(459, 4051, 4079))) ? ControlFlowRegionKind.Try : ControlFlowRegionKind.Filter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4104, 4251);

                        f_459_4104_4250(f_459_4117_4138(f_459_4117_4130()[1]) == ((DynAbs.Tracing.TraceSender.Conditional_F1(459, 4143, 4186) || ((kind == ControlFlowRegionKind.TryAndFinally && DynAbs.Tracing.TraceSender.Conditional_F2(459, 4189, 4218)) || DynAbs.Tracing.TraceSender.Conditional_F3(459, 4221, 4248))) ? ControlFlowRegionKind.Finally : ControlFlowRegionKind.Catch));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4273, 4343);

                        f_459_4273_4342(f_459_4286_4320(f_459_4286_4299()[0]) == firstBlockOrdinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4365, 4433);

                        f_459_4365_4432(f_459_4378_4411(f_459_4378_4391()[1]) == lastBlockOrdinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4455, 4545);

                        f_459_4455_4544(f_459_4468_4501(f_459_4468_4481()[0]) + 1 == f_459_4509_4543(f_459_4509_4522()[1]));
                        DynAbs.Tracing.TraceSender.TraceBreak(459, 4567, 4573);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(459, 3705, 6460);

                    case ControlFlowRegionKind.TryAndCatch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(459, 3705, 6460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4654, 4694);

                        f_459_4654_4693(f_459_4667_4680().Length >= 2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4716, 4781);

                        f_459_4716_4780(f_459_4729_4750(f_459_4729_4742()[0]) == ControlFlowRegionKind.Try);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4803, 4873);

                        f_459_4803_4872(f_459_4816_4850(f_459_4816_4829()[0]) == firstBlockOrdinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4895, 4944);

                        previousLast = f_459_4910_4943(f_459_4910_4923()[0]);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4977, 4982);

                            for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 4968, 5397) || true) && (i < f_459_4988_5001().Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 5010, 5013)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(459, 4968, 5397))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(459, 4968, 5397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 5063, 5102);

                                ControlFlowRegion
                                r = f_459_5085_5098()[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 5128, 5182);

                                f_459_5128_5181(previousLast + 1 == f_459_5161_5180(r));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 5208, 5242);

                                previousLast = f_459_5223_5241(r);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 5270, 5374);

                                f_459_5270_5373(f_459_5283_5289(r) == ControlFlowRegionKind.FilterAndHandler || (DynAbs.Tracing.TraceSender.Expression_False(459, 5283, 5372) || f_459_5335_5341(r) == ControlFlowRegionKind.Catch));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(459, 1, 430);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(459, 1, 430);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 5421, 5468);

                        f_459_5421_5467(previousLast == lastBlockOrdinal);
                        DynAbs.Tracing.TraceSender.TraceBreak(459, 5490, 5496);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(459, 3705, 6460);

                    case ControlFlowRegionKind.Root:
                    case ControlFlowRegionKind.LocalLifetime:
                    case ControlFlowRegionKind.Try:
                    case ControlFlowRegionKind.Filter:
                    case ControlFlowRegionKind.Catch:
                    case ControlFlowRegionKind.Finally:
                    case ControlFlowRegionKind.StaticLocalInitializer:
                    case ControlFlowRegionKind.ErroneousBody:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(459, 3705, 6460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 5961, 5998);

                        previousLast = firstBlockOrdinal - 1;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 6022, 6249);
                            foreach (ControlFlowRegion r in f_459_6054_6067_I(f_459_6054_6067()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(459, 6022, 6249);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 6117, 6166);

                                f_459_6117_6165(previousLast < f_459_6145_6164(r));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 6192, 6226);

                                previousLast = f_459_6207_6225(r);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(459, 6022, 6249);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(459, 1, 228);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(459, 1, 228);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 6273, 6320);

                        f_459_6273_6319(previousLast <= lastBlockOrdinal);
                        DynAbs.Tracing.TraceSender.TraceBreak(459, 6342, 6348);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(459, 3705, 6460);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(459, 3705, 6460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 6398, 6445);

                        throw f_459_6404_6444(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(459, 3705, 6460);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(459, 2381, 6479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(459, 2381, 6479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(459, 2381, 6479);
            }
        }

        internal bool ContainsBlock(int destinationOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(459, 6491, 6667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(459, 6567, 6656);

                return f_459_6574_6591() <= destinationOrdinal && (DynAbs.Tracing.TraceSender.Expression_True(459, 6574, 6655) && f_459_6617_6633() >= destinationOrdinal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(459, 6491, 6667);

                int
                f_459_6574_6591()
                {
                    var return_v = FirstBlockOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 6574, 6591);
                    return return_v;
                }


                int
                f_459_6617_6633()
                {
                    var return_v = LastBlockOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 6617, 6633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(459, 6491, 6667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(459, 6491, 6667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ControlFlowRegion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(459, 575, 6674);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(459, 575, 6674);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(459, 575, 6674);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(459, 575, 6674);

        static int
        f_459_2882_2918(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 2882, 2918);
            return 0;
        }


        static int
        f_459_2933_2984(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 2933, 2984);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_3462_3475()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 3462, 3475);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion?
        f_459_3522_3539(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.EnclosingRegion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 3522, 3539);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        f_459_3551_3557(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 3551, 3557);
            return return_v;
        }


        static int
        f_459_3509_3588(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 3509, 3588);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_3462_3475_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 3462, 3475);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_3889_3902()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 3889, 3902);
            return return_v;
        }


        static int
        f_459_3876_3915(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 3876, 3915);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_3951_3964()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 3951, 3964);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        f_459_3951_3972(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 3951, 3972);
            return return_v;
        }


        static int
        f_459_3938_4081(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 3938, 4081);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4117_4130()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4117, 4130);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        f_459_4117_4138(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4117, 4138);
            return return_v;
        }


        static int
        f_459_4104_4250(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 4104, 4250);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4286_4299()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4286, 4299);
            return return_v;
        }


        static int
        f_459_4286_4320(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.FirstBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4286, 4320);
            return return_v;
        }


        static int
        f_459_4273_4342(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 4273, 4342);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4378_4391()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4378, 4391);
            return return_v;
        }


        static int
        f_459_4378_4411(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.LastBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4378, 4411);
            return return_v;
        }


        static int
        f_459_4365_4432(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 4365, 4432);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4468_4481()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4468, 4481);
            return return_v;
        }


        static int
        f_459_4468_4501(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.LastBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4468, 4501);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4509_4522()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4509, 4522);
            return return_v;
        }


        static int
        f_459_4509_4543(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.FirstBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4509, 4543);
            return return_v;
        }


        static int
        f_459_4455_4544(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 4455, 4544);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4667_4680()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4667, 4680);
            return return_v;
        }


        static int
        f_459_4654_4693(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 4654, 4693);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4729_4742()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4729, 4742);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        f_459_4729_4750(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4729, 4750);
            return return_v;
        }


        static int
        f_459_4716_4780(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 4716, 4780);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4816_4829()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4816, 4829);
            return return_v;
        }


        static int
        f_459_4816_4850(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.FirstBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4816, 4850);
            return return_v;
        }


        static int
        f_459_4803_4872(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 4803, 4872);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4910_4923()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4910, 4923);
            return return_v;
        }


        static int
        f_459_4910_4943(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.LastBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4910, 4943);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_4988_5001()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 4988, 5001);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_5085_5098()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 5085, 5098);
            return return_v;
        }


        static int
        f_459_5161_5180(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.FirstBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 5161, 5180);
            return return_v;
        }


        static int
        f_459_5128_5181(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 5128, 5181);
            return 0;
        }


        static int
        f_459_5223_5241(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.LastBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 5223, 5241);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        f_459_5283_5289(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 5283, 5289);
            return return_v;
        }


        static Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        f_459_5335_5341(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 5335, 5341);
            return return_v;
        }


        static int
        f_459_5270_5373(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 5270, 5373);
            return 0;
        }


        static int
        f_459_5421_5467(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 5421, 5467);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_6054_6067()
        {
            var return_v = NestedRegions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 6054, 6067);
            return return_v;
        }


        static int
        f_459_6145_6164(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.FirstBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 6145, 6164);
            return return_v;
        }


        static int
        f_459_6117_6165(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 6117, 6165);
            return 0;
        }


        static int
        f_459_6207_6225(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
        this_param)
        {
            var return_v = this_param.LastBlockOrdinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(459, 6207, 6225);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        f_459_6054_6067_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 6054, 6067);
            return return_v;
        }


        static int
        f_459_6273_6319(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 6273, 6319);
            return 0;
        }


        static System.Exception
        f_459_6404_6444(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegionKind
        o)
        {
            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(459, 6404, 6444);
            return return_v;
        }

    }
}
