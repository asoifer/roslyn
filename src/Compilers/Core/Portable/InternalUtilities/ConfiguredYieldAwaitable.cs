// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Roslyn.Utilities
{

    internal readonly struct ConfiguredYieldAwaitable
    {

        private readonly YieldAwaitable _awaitable;

        private readonly bool _continueOnCapturedContext;

        public ConfiguredYieldAwaitable(YieldAwaitable awaitable, bool continueOnCapturedContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(317, 708, 925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 822, 845);

                _awaitable = awaitable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 859, 914);

                _continueOnCapturedContext = continueOnCapturedContext;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(317, 708, 925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(317, 708, 925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 708, 925);
            }
        }

        public ConfiguredYieldAwaiter GetAwaiter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(317, 993, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 996, 1075);
                return f_317_996_1075(_awaitable.GetAwaiter(), _continueOnCapturedContext); DynAbs.Tracing.TraceSender.TraceExitMethod(317, 993, 1075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(317, 993, 1075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 993, 1075);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Utilities.ConfiguredYieldAwaitable.ConfiguredYieldAwaiter
            f_317_996_1075(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter
            awaiter, bool
            continueOnCapturedContext)
            {
                var return_v = new Roslyn.Utilities.ConfiguredYieldAwaitable.ConfiguredYieldAwaiter(awaiter, continueOnCapturedContext);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(317, 996, 1075);
                return return_v;
            }

        }

        public readonly struct ConfiguredYieldAwaiter
                    : INotifyCompletion, ICriticalNotifyCompletion
        {

            private static readonly WaitCallback s_runContinuation;

            private readonly YieldAwaitable.YieldAwaiter _awaiter;

            private readonly bool _continueOnCapturedContext;

            public ConfiguredYieldAwaiter(YieldAwaitable.YieldAwaiter awaiter, bool continueOnCapturedContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(317, 1490, 1728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 1621, 1640);

                    _awaiter = awaiter;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 1658, 1713);

                    _continueOnCapturedContext = continueOnCapturedContext;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(317, 1490, 1728);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(317, 1490, 1728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 1490, 1728);
                }
            }

            public bool IsCompleted
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(317, 1768, 1791);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 1771, 1791);
                        return _awaiter.IsCompleted; DynAbs.Tracing.TraceSender.TraceExitMethod(317, 1768, 1791);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(317, 1768, 1791);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 1768, 1791);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void GetResult()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(317, 1849, 1872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 1852, 1872);
                    _awaiter.GetResult(); DynAbs.Tracing.TraceSender.TraceExitMethod(317, 1849, 1872);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(317, 1849, 1872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 1849, 1872);
                }
            }

            public void OnCompleted(Action continuation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(317, 1889, 2434);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 1966, 2419) || true) && (_continueOnCapturedContext)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(317, 1966, 2419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 2143, 2178);

                        _awaiter.OnCompleted(continuation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(317, 1966, 2419);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(317, 1966, 2419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 2338, 2400);

                        f_317_2338_2399(s_runContinuation, continuation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(317, 1966, 2419);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(317, 1889, 2434);

                    bool
                    f_317_2338_2399(System.Threading.WaitCallback
                    callBack, System.Action
                    state)
                    {
                        var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(317, 2338, 2399);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(317, 1889, 2434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 1889, 2434);
                }
            }

            public void UnsafeOnCompleted(Action continuation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(317, 2450, 3013);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 2533, 2998) || true) && (_continueOnCapturedContext)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(317, 2533, 2998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 2710, 2751);

                        _awaiter.UnsafeOnCompleted(continuation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(317, 2533, 2998);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(317, 2533, 2998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 2911, 2979);

                        f_317_2911_2978(s_runContinuation, continuation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(317, 2533, 2998);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(317, 2450, 3013);

                    bool
                    f_317_2911_2978(System.Threading.WaitCallback
                    callBack, System.Action
                    state)
                    {
                        var return_v = ThreadPool.UnsafeQueueUserWorkItem(callBack, (object)state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(317, 2911, 2978);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(317, 2450, 3013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 2450, 3013);
                }
            }
            static ConfiguredYieldAwaiter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(317, 1088, 3024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(317, 1255, 1340);
                s_runContinuation = static continuation => ((Action)continuation!)(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(317, 1088, 3024);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 1088, 3024);
            }
        }
        static ConfiguredYieldAwaitable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(317, 528, 3031);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(317, 528, 3031);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(317, 528, 3031);
        }
    }
}
