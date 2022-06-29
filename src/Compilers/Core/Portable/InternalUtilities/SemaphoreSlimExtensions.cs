// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roslyn.Utilities
{
    internal static class SemaphoreSlimExtensions
    {
        public static SemaphoreDisposer DisposableWait(this SemaphoreSlim semaphore, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(364, 378, 625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(364, 526, 560);

                f_364_526_559(semaphore, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(364, 574, 614);

                return f_364_581_613(semaphore);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(364, 378, 625);

                int
                f_364_526_559(System.Threading.SemaphoreSlim
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Wait(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(364, 526, 559);
                    return 0;
                }


                Roslyn.Utilities.SemaphoreSlimExtensions.SemaphoreDisposer
                f_364_581_613(System.Threading.SemaphoreSlim
                semaphore)
                {
                    var return_v = new Roslyn.Utilities.SemaphoreSlimExtensions.SemaphoreDisposer(semaphore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(364, 581, 613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(364, 378, 625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(364, 378, 625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/36114", OftenCompletesSynchronously = true)]
        public static async ValueTask<SemaphoreDisposer> DisposableWaitAsync(this SemaphoreSlim semaphore, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(364, 637, 1056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(364, 924, 991);

                await f_364_930_990(f_364_930_968(semaphore, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(364, 1005, 1045);

                return f_364_1012_1044(semaphore);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(364, 637, 1056);

                System.Threading.Tasks.Task
                f_364_930_968(System.Threading.SemaphoreSlim
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.WaitAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(364, 930, 968);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_364_930_990(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(364, 930, 990);
                    return return_v;
                }


                Roslyn.Utilities.SemaphoreSlimExtensions.SemaphoreDisposer
                f_364_1012_1044(System.Threading.SemaphoreSlim
                semaphore)
                {
                    var return_v = new Roslyn.Utilities.SemaphoreSlimExtensions.SemaphoreDisposer(semaphore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(364, 1012, 1044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(364, 637, 1056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(364, 637, 1056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [NonCopyable]
        internal struct SemaphoreDisposer : IDisposable
        {

            private readonly SemaphoreSlim _semaphore;

            public SemaphoreDisposer(SemaphoreSlim semaphore)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(364, 1221, 1341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(364, 1303, 1326);

                    _semaphore = semaphore;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(364, 1221, 1341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(364, 1221, 1341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(364, 1221, 1341);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(364, 1357, 1447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(364, 1411, 1432);

                    f_364_1411_1431(_semaphore);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(364, 1357, 1447);

                    int
                    f_364_1411_1431(System.Threading.SemaphoreSlim
                    this_param)
                    {
                        var return_v = this_param.Release();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(364, 1411, 1431);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(364, 1357, 1447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(364, 1357, 1447);
                }
            }
            static SemaphoreDisposer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(364, 1068, 1458);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(364, 1068, 1458);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(364, 1068, 1458);
            }
        }

        static SemaphoreSlimExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(364, 316, 1465);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(364, 316, 1465);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(364, 316, 1465);
        }

    }
}
