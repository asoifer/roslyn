// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Reflection.Metadata;

namespace Microsoft.Cci
{
    internal abstract class ExceptionHandlerRegion
    {
        public int TryStartOffset { get; }

        public int TryEndOffset { get; }

        public int HandlerStartOffset { get; }

        public int HandlerEndOffset { get; }

        public ExceptionHandlerRegion(
                    int tryStartOffset,
                    int tryEndOffset,
                    int handlerStartOffset,
                    int handlerEndOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(483, 1259, 2024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 713, 747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 875, 907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1041, 1079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1211, 1247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1450, 1494);

                f_483_1450_1493(tryStartOffset < tryEndOffset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1508, 1557);

                f_483_1508_1556(tryEndOffset <= handlerStartOffset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1571, 1623);

                f_483_1571_1622(handlerStartOffset < handlerEndOffset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1637, 1671);

                f_483_1637_1670(tryStartOffset >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1685, 1717);

                f_483_1685_1716(tryEndOffset >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1731, 1769);

                f_483_1731_1768(handlerStartOffset >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1783, 1819);

                f_483_1783_1818(handlerEndOffset >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1835, 1867);

                TryStartOffset = tryStartOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1881, 1909);

                TryEndOffset = tryEndOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1923, 1963);

                HandlerStartOffset = handlerStartOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 1977, 2013);

                HandlerEndOffset = handlerEndOffset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(483, 1259, 2024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 1259, 2024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 1259, 2024);
            }
        }

        public int HandlerLength
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 2061, 2101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 2064, 2101);
                    return f_483_2064_2080() - f_483_2083_2101(); DynAbs.Tracing.TraceSender.TraceExitMethod(483, 2061, 2101);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 2061, 2101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 2061, 2101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int TryLength
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 2133, 2165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 2136, 2165);
                    return f_483_2136_2148() - f_483_2151_2165(); DynAbs.Tracing.TraceSender.TraceExitMethod(483, 2133, 2165);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 2133, 2165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 2133, 2165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract ExceptionRegionKind HandlerKind { get; }

        public virtual ITypeReference? ExceptionType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 2658, 2721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 2694, 2706);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 2658, 2721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 2589, 2732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 2589, 2732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int FilterDecisionStartOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 2943, 2960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 2949, 2958);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 2943, 2960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 2874, 2971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 2874, 2971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExceptionHandlerRegion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(483, 532, 2978);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(483, 532, 2978);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 532, 2978);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(483, 532, 2978);

        static int
        f_483_1450_1493(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 1450, 1493);
            return 0;
        }


        static int
        f_483_1508_1556(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 1508, 1556);
            return 0;
        }


        static int
        f_483_1571_1622(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 1571, 1622);
            return 0;
        }


        static int
        f_483_1637_1670(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 1637, 1670);
            return 0;
        }


        static int
        f_483_1685_1716(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 1685, 1716);
            return 0;
        }


        static int
        f_483_1731_1768(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 1731, 1768);
            return 0;
        }


        static int
        f_483_1783_1818(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 1783, 1818);
            return 0;
        }


        int
        f_483_2064_2080()
        {
            var return_v = HandlerEndOffset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(483, 2064, 2080);
            return return_v;
        }


        int
        f_483_2083_2101()
        {
            var return_v = HandlerStartOffset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(483, 2083, 2101);
            return return_v;
        }


        int
        f_483_2136_2148()
        {
            var return_v = TryEndOffset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(483, 2136, 2148);
            return return_v;
        }


        int
        f_483_2151_2165()
        {
            var return_v = TryStartOffset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(483, 2151, 2165);
            return return_v;
        }

    }
    internal sealed class ExceptionHandlerRegionFinally : ExceptionHandlerRegion
    {
        public ExceptionHandlerRegionFinally(
                    int tryStartOffset,
                    int tryEndOffset,
                    int handlerStartOffset,
                    int handlerEndOffset)
        : base(f_483_3273_3287_C(tryStartOffset), tryEndOffset, handlerStartOffset, handlerEndOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(483, 3079, 3362);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(483, 3079, 3362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 3079, 3362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 3079, 3362);
            }
        }

        public override ExceptionRegionKind HandlerKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 3446, 3489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 3452, 3487);

                    return ExceptionRegionKind.Finally;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 3446, 3489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 3374, 3500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 3374, 3500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExceptionHandlerRegionFinally()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(483, 2986, 3507);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(483, 2986, 3507);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 2986, 3507);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(483, 2986, 3507);

        static int
        f_483_3273_3287_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(483, 3079, 3362);
            return return_v;
        }

    }
    internal sealed class ExceptionHandlerRegionFault : ExceptionHandlerRegion
    {
        public ExceptionHandlerRegionFault(
                    int tryStartOffset,
                    int tryEndOffset,
                    int handlerStartOffset,
                    int handlerEndOffset)
        : base(f_483_3798_3812_C(tryStartOffset), tryEndOffset, handlerStartOffset, handlerEndOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(483, 3606, 3887);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(483, 3606, 3887);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 3606, 3887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 3606, 3887);
            }
        }

        public override ExceptionRegionKind HandlerKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 3971, 4012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 3977, 4010);

                    return ExceptionRegionKind.Fault;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 3971, 4012);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 3899, 4023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 3899, 4023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExceptionHandlerRegionFault()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(483, 3515, 4030);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(483, 3515, 4030);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 3515, 4030);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(483, 3515, 4030);

        static int
        f_483_3798_3812_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(483, 3606, 3887);
            return return_v;
        }

    }
    internal sealed class ExceptionHandlerRegionCatch : ExceptionHandlerRegion
    {
        private readonly ITypeReference _exceptionType;

        public ExceptionHandlerRegionCatch(
                    int tryStartOffset,
                    int tryEndOffset,
                    int handlerStartOffset,
                    int handlerEndOffset,
                    ITypeReference exceptionType)
        : base(f_483_4423_4437_C(tryStartOffset), tryEndOffset, handlerStartOffset, handlerEndOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(483, 4188, 4557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 4161, 4175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 4515, 4546);

                _exceptionType = exceptionType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(483, 4188, 4557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 4188, 4557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 4188, 4557);
            }
        }

        public override ExceptionRegionKind HandlerKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 4641, 4682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 4647, 4680);

                    return ExceptionRegionKind.Catch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 4641, 4682);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 4569, 4693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 4569, 4693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ITypeReference ExceptionType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 4774, 4804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 4780, 4802);

                    return _exceptionType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 4774, 4804);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 4705, 4815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 4705, 4815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExceptionHandlerRegionCatch()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(483, 4038, 4822);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(483, 4038, 4822);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 4038, 4822);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(483, 4038, 4822);

        static int
        f_483_4423_4437_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(483, 4188, 4557);
            return return_v;
        }

    }
    internal sealed class ExceptionHandlerRegionFilter : ExceptionHandlerRegion
    {
        private readonly int _filterDecisionStartOffset;

        public ExceptionHandlerRegionFilter(
                    int tryStartOffset,
                    int tryEndOffset,
                    int handlerStartOffset,
                    int handlerEndOffset,
                    int filterDecisionStartOffset)
        : base(f_483_5219_5233_C(tryStartOffset), tryEndOffset, handlerStartOffset, handlerEndOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(483, 4982, 5438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 4943, 4969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 5311, 5356);

                f_483_5311_5355(filterDecisionStartOffset >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 5372, 5427);

                _filterDecisionStartOffset = filterDecisionStartOffset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(483, 4982, 5438);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 4982, 5438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 4982, 5438);
            }
        }

        public override ExceptionRegionKind HandlerKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 5522, 5564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 5528, 5562);

                    return ExceptionRegionKind.Filter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 5522, 5564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 5450, 5575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 5450, 5575);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int FilterDecisionStartOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(483, 5657, 5699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(483, 5663, 5697);

                    return _filterDecisionStartOffset;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(483, 5657, 5699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(483, 5587, 5710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 5587, 5710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExceptionHandlerRegionFilter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(483, 4830, 5717);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(483, 4830, 5717);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(483, 4830, 5717);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(483, 4830, 5717);

        static int
        f_483_5311_5355(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(483, 5311, 5355);
            return 0;
        }


        static int
        f_483_5219_5233_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(483, 4982, 5438);
            return return_v;
        }

    }
}
