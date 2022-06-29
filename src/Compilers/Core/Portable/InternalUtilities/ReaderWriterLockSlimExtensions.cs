// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading;

namespace Roslyn.Utilities
{
    internal static class ReaderWriterLockSlimExtensions
    {
        internal static ReadLockExiter DisposableRead(this ReaderWriterLockSlim @lock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(357, 354, 501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 457, 490);

                return f_357_464_489(@lock);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(357, 354, 501);

                Roslyn.Utilities.ReaderWriterLockSlimExtensions.ReadLockExiter
                f_357_464_489(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = new Roslyn.Utilities.ReaderWriterLockSlimExtensions.ReadLockExiter(@lock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 464, 489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 354, 501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 354, 501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [NonCopyable]
        internal readonly struct ReadLockExiter : IDisposable
        {

            private readonly ReaderWriterLockSlim _lock;

            internal ReadLockExiter(ReaderWriterLockSlim @lock)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(357, 674, 827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 758, 772);

                    _lock = @lock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 790, 812);

                    f_357_790_811(@lock);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(357, 674, 827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 674, 827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 674, 827);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(357, 843, 933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 897, 918);

                    f_357_897_917(_lock);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(357, 843, 933);

                    int
                    f_357_897_917(System.Threading.ReaderWriterLockSlim
                    this_param)
                    {
                        this_param.ExitReadLock();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 897, 917);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 843, 933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 843, 933);
                }
            }
            static ReadLockExiter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(357, 513, 944);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(357, 513, 944);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 513, 944);
            }

            static int
            f_357_790_811(System.Threading.ReaderWriterLockSlim
            this_param)
            {
                this_param.EnterReadLock();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 790, 811);
                return 0;
            }

        }

        internal static UpgradeableReadLockExiter DisposableUpgradeableRead(this ReaderWriterLockSlim @lock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(357, 956, 1136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1081, 1125);

                return f_357_1088_1124(@lock);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(357, 956, 1136);

                Roslyn.Utilities.ReaderWriterLockSlimExtensions.UpgradeableReadLockExiter
                f_357_1088_1124(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = new Roslyn.Utilities.ReaderWriterLockSlimExtensions.UpgradeableReadLockExiter(@lock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 1088, 1124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 956, 1136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 956, 1136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [NonCopyable]
        internal readonly struct UpgradeableReadLockExiter : IDisposable
        {

            private readonly ReaderWriterLockSlim _lock;

            internal UpgradeableReadLockExiter(ReaderWriterLockSlim @lock)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(357, 1320, 1495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1415, 1429);

                    _lock = @lock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1447, 1480);

                    f_357_1447_1479(@lock);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(357, 1320, 1495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 1320, 1495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 1320, 1495);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(357, 1511, 1740);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1565, 1673) || true) && (f_357_1569_1590(_lock))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(357, 1565, 1673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1632, 1654);

                        f_357_1632_1653(_lock);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(357, 1565, 1673);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1693, 1725);

                    f_357_1693_1724(
                                    _lock);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(357, 1511, 1740);

                    bool
                    f_357_1569_1590(System.Threading.ReaderWriterLockSlim
                    this_param)
                    {
                        var return_v = this_param.IsWriteLockHeld;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(357, 1569, 1590);
                        return return_v;
                    }


                    int
                    f_357_1632_1653(System.Threading.ReaderWriterLockSlim
                    this_param)
                    {
                        this_param.ExitWriteLock();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 1632, 1653);
                        return 0;
                    }


                    int
                    f_357_1693_1724(System.Threading.ReaderWriterLockSlim
                    this_param)
                    {
                        this_param.ExitUpgradeableReadLock();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 1693, 1724);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 1511, 1740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 1511, 1740);
                }
            }

            public void EnterWrite()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(357, 1756, 1851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1813, 1836);

                    f_357_1813_1835(_lock);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(357, 1756, 1851);

                    int
                    f_357_1813_1835(System.Threading.ReaderWriterLockSlim
                    this_param)
                    {
                        this_param.EnterWriteLock();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 1813, 1835);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 1756, 1851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 1756, 1851);
                }
            }
            static UpgradeableReadLockExiter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(357, 1148, 1862);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(357, 1148, 1862);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 1148, 1862);
            }

            static int
            f_357_1447_1479(System.Threading.ReaderWriterLockSlim
            this_param)
            {
                this_param.EnterUpgradeableReadLock();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 1447, 1479);
                return 0;
            }

        }

        internal static WriteLockExiter DisposableWrite(this ReaderWriterLockSlim @lock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(357, 1874, 2024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 1979, 2013);

                return f_357_1986_2012(@lock);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(357, 1874, 2024);

                Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter
                f_357_1986_2012(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = new Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter(@lock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 1986, 2012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 1874, 2024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 1874, 2024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [NonCopyable]
        internal readonly struct WriteLockExiter : IDisposable
        {

            private readonly ReaderWriterLockSlim _lock;

            internal WriteLockExiter(ReaderWriterLockSlim @lock)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(357, 2198, 2353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 2283, 2297);

                    _lock = @lock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 2315, 2338);

                    f_357_2315_2337(@lock);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(357, 2198, 2353);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 2198, 2353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 2198, 2353);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(357, 2369, 2460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 2423, 2445);

                    f_357_2423_2444(_lock);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(357, 2369, 2460);

                    int
                    f_357_2423_2444(System.Threading.ReaderWriterLockSlim
                    this_param)
                    {
                        this_param.ExitWriteLock();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 2423, 2444);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 2369, 2460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 2369, 2460);
                }
            }
            static WriteLockExiter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(357, 2036, 2471);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(357, 2036, 2471);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 2036, 2471);
            }

            static int
            f_357_2315_2337(System.Threading.ReaderWriterLockSlim
            this_param)
            {
                this_param.EnterWriteLock();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 2315, 2337);
                return 0;
            }

        }

        internal static void AssertCanRead(this ReaderWriterLockSlim @lock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(357, 2483, 2760);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 2575, 2749) || true) && (f_357_2579_2600_M(!@lock.IsReadLockHeld) && (DynAbs.Tracing.TraceSender.Expression_True(357, 2579, 2636) && f_357_2604_2636_M(!@lock.IsUpgradeableReadLockHeld)) && (DynAbs.Tracing.TraceSender.Expression_True(357, 2579, 2662) && f_357_2640_2662_M(!@lock.IsWriteLockHeld)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(357, 2575, 2749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 2696, 2734);

                    throw f_357_2702_2733();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(357, 2575, 2749);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(357, 2483, 2760);

                bool
                f_357_2579_2600_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(357, 2579, 2600);
                    return return_v;
                }


                bool
                f_357_2604_2636_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(357, 2604, 2636);
                    return return_v;
                }


                bool
                f_357_2640_2662_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(357, 2640, 2662);
                    return return_v;
                }


                System.InvalidOperationException
                f_357_2702_2733()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 2702, 2733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 2483, 2760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 2483, 2760);
            }
        }

        internal static void AssertCanWrite(this ReaderWriterLockSlim @lock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(357, 2772, 2989);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 2865, 2978) || true) && (f_357_2869_2891_M(!@lock.IsWriteLockHeld))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(357, 2865, 2978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(357, 2925, 2963);

                    throw f_357_2931_2962();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(357, 2865, 2978);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(357, 2772, 2989);

                bool
                f_357_2869_2891_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(357, 2869, 2891);
                    return return_v;
                }


                System.InvalidOperationException
                f_357_2931_2962()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(357, 2931, 2962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(357, 2772, 2989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 2772, 2989);
            }
        }

        static ReaderWriterLockSlimExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(357, 285, 2996);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(357, 285, 2996);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(357, 285, 2996);
        }

    }
}
