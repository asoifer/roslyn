// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;

namespace Roslyn.Utilities
{
    internal static class ThreadSafeFlagOperations
    {
        public static bool Set(ref int flags, int toSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(391, 333, 802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 406, 429);

                int
                oldState
                = default(int),
                newState
                = default(int);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(391, 443, 765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 478, 495);

                            oldState = flags;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 513, 541);

                            newState = oldState | toSet;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 559, 657) || true) && (newState == oldState)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(391, 559, 657);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 625, 638);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(391, 559, 657);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(391, 443, 765);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 443, 765) || true) && (f_391_693_751(ref flags, newState, oldState) != oldState)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(391, 443, 765);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(391, 443, 765);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 779, 791);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(391, 333, 802);

                int
                f_391_693_751(ref int
                location1, int
                value, int
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(391, 693, 751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(391, 333, 802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(391, 333, 802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Clear(ref int flags, int toClear)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(391, 814, 1290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 891, 914);

                int
                oldState
                = default(int),
                newState
                = default(int);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(391, 928, 1253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 963, 980);

                            oldState = flags;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 998, 1029);

                            newState = oldState & ~toClear;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 1047, 1145) || true) && (newState == oldState)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(391, 1047, 1145);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 1113, 1126);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(391, 1047, 1145);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(391, 928, 1253);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 928, 1253) || true) && (f_391_1181_1239(ref flags, newState, oldState) != oldState)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(391, 928, 1253);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(391, 928, 1253);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(391, 1267, 1279);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(391, 814, 1290);

                int
                f_391_1181_1239(ref int
                location1, int
                value, int
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(391, 1181, 1239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(391, 814, 1290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(391, 814, 1290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ThreadSafeFlagOperations()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(391, 270, 1297);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(391, 270, 1297);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(391, 270, 1297);
        }

    }
}
