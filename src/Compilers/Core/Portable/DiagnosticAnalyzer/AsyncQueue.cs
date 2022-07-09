// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class AsyncQueue<TElement>
    {
        private readonly TaskCompletionSource<bool> _whenCompleted;

        private readonly Queue<TElement> _data;

        private Queue<TaskCompletionSource<Optional<TElement>>> _waiters;

        private bool _completed;

        private bool _disallowEnqueue;

        private object SyncObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 1455, 1476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 1461, 1474);

                    return _data;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(241, 1455, 1476);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 1405, 1487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 1405, 1487);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 1648, 1795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 1690, 1700);
                    lock (f_241_1690_1700())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 1742, 1761);

                        return f_241_1749_1760(_data);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(241, 1648, 1795);

                    object
                    f_241_1690_1700()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 1690, 1700);
                        return return_v;
                    }


                    int
                    f_241_1749_1760(System.Collections.Generic.Queue<TElement>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 1749, 1760);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 1607, 1806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 1607, 1806);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Adds an element to the tail of the queue.  This method will throw if the queue 
        /// is completed.
        /// </summary>
        /// <exception cref="InvalidOperationException">The queue is already completed.</exception>
        /// <param name="value">The value to add.</param>
        public void Enqueue(TElement value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 2145, 2395);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 2205, 2384) || true) && (!f_241_2210_2228(this, value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 2205, 2384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 2262, 2369);

                    throw f_241_2268_2368($"Cannot call {nameof(Enqueue)} when the queue is already completed.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(241, 2205, 2384);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 2145, 2395);

                bool
                f_241_2210_2228(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>
                this_param, TElement
                value)
                {
                    var return_v = this_param.EnqueueCore(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 2210, 2228);
                    return return_v;
                }


                System.InvalidOperationException
                f_241_2268_2368(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 2268, 2368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 2145, 2395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 2145, 2395);
            }
        }

        /// <summary>
        /// Tries to add an element to the tail of the queue.  This method will return false if the queue
        /// is completed.
        /// </summary>
        /// <param name="value">The value to add.</param>
        public bool TryEnqueue(TElement value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 2647, 2747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 2710, 2736);

                return f_241_2717_2735(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 2647, 2747);

                bool
                f_241_2717_2735(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>
                this_param, TElement
                value)
                {
                    var return_v = this_param.EnqueueCore(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 2717, 2735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 2647, 2747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 2647, 2747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool EnqueueCore(TElement value)
        {
retry:
            if (_disallowEnqueue)
            {
                throw new InvalidOperationException($"Cannot enqueue data after PromiseNotToEnqueue.");
            }

            TaskCompletionSource<Optional<TElement>> waiter;
            lock (SyncObject)
            {
                if (_completed)
                {
                    return false;
                }

                if (_waiters == null || _waiters.Count == 0)
                {
                    _data.Enqueue(value);
                    return true;
                }

                Debug.Assert(_data.Count == 0);
                waiter = _waiters.Dequeue();
            }

            Debug.Assert(waiter.Task.CreationOptions.HasFlag(TaskCreationOptions.RunContinuationsAsynchronously));
            if (!waiter.TrySetResult(value))
            {
                // A waiter was available in the queue, but was cancelled before we were able to assign this value
                goto retry;
            }

            return true;
        }

        /// <summary>
        /// Attempts to dequeue an existing item and return whether or not it was available.
        /// </summary>
        public bool TryDequeue(out TElement d)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 4026, 4373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4095, 4105);
                lock (f_241_4095_4105())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4139, 4277) || true) && (f_241_4143_4154(_data) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 4139, 4277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4201, 4223);

                        d = default(TElement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4245, 4258);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(241, 4139, 4277);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4297, 4317);

                    d = f_241_4301_4316(_data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4335, 4347);

                    return true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 4026, 4373);

                object
                f_241_4095_4105()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 4095, 4105);
                    return return_v;
                }


                int
                f_241_4143_4154(System.Collections.Generic.Queue<TElement>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 4143, 4154);
                    return return_v;
                }


                TElement
                f_241_4301_4316(System.Collections.Generic.Queue<TElement>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 4301, 4316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 4026, 4373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 4026, 4373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsCompleted
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 4550, 4696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4592, 4602);
                    lock (f_241_4592_4602())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 4644, 4662);

                        return _completed;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(241, 4550, 4696);

                    object
                    f_241_4592_4602()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 4592, 4602);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 4502, 4707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 4502, 4707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Signals that no further elements will be enqueued.  All outstanding and future
        /// Dequeue Task will be cancelled.
        /// </summary>
        /// <exception cref="InvalidOperationException">The queue is already completed.</exception>
        public void Complete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 5004, 5238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5051, 5227) || true) && (!f_241_5056_5070(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 5051, 5227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5104, 5212);

                    throw f_241_5110_5211($"Cannot call {nameof(Complete)} when the queue is already completed.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(241, 5051, 5227);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 5004, 5238);

                bool
                f_241_5056_5070(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>
                this_param)
                {
                    var return_v = this_param.CompleteCore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 5056, 5070);
                    return return_v;
                }


                System.InvalidOperationException
                f_241_5110_5211(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 5110, 5211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 5004, 5238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 5004, 5238);
            }
        }

        public void PromiseNotToEnqueue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 5250, 5343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5308, 5332);

                _disallowEnqueue = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 5250, 5343);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 5250, 5343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 5250, 5343);
            }
        }

        /// <summary>
        /// Same operation as <see cref="AsyncQueue{TElement}.Complete"/> except it will not
        /// throw if the queue is already completed.
        /// </summary>
        /// <returns>Whether or not the operation succeeded.</returns>
        public bool TryComplete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 5622, 5705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5672, 5694);

                return f_241_5679_5693(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 5622, 5705);

                bool
                f_241_5679_5693(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>
                this_param)
                {
                    var return_v = this_param.CompleteCore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 5679, 5693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 5622, 5705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 5622, 5705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CompleteCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 5717, 7307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5769, 5833);

                Queue<TaskCompletionSource<Optional<TElement>>>
                existingWaiters
                = default(Queue<TaskCompletionSource<Optional<TElement>>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5853, 5863);
                lock (f_241_5853_5863())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5897, 5985) || true) && (_completed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 5897, 5985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 5953, 5966);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(241, 5897, 5985);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 6005, 6023);

                    _completed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 6043, 6070);

                    existingWaiters = _waiters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 6088, 6104);

                    _waiters = null;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 6135, 7097) || true) && (f_241_6139_6161_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(existingWaiters, 241, 6139, 6161)?.Count) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 6135, 7097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 6716, 6821);

                    f_241_6716_6820(f_241_6729_6739(this) == 0, "we should not be cancelling the waiters when we have items in the queue");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 6839, 7082);
                        foreach (var tcs in f_241_6859_6874_I(existingWaiters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 6839, 7082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 6916, 7015);

                            f_241_6916_7014(f_241_6929_7013(f_241_6929_6953(f_241_6929_6937(tcs)), TaskCreationOptions.RunContinuationsAsynchronously));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 7037, 7063);

                            f_241_7037_7062(tcs, default);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(241, 6839, 7082);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(241, 1, 244);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(241, 1, 244);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(241, 6135, 7097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 7113, 7223);

                f_241_7113_7222(f_241_7126_7221(f_241_7126_7161(f_241_7126_7145(_whenCompleted)), TaskCreationOptions.RunContinuationsAsynchronously));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 7237, 7268);

                f_241_7237_7267(_whenCompleted, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 7284, 7296);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 5717, 7307);

                object
                f_241_5853_5863()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 5853, 5863);
                    return return_v;
                }


                int?
                f_241_6139_6161_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 6139, 6161);
                    return return_v;
                }


                int
                f_241_6729_6739(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 6729, 6739);
                    return return_v;
                }


                int
                f_241_6716_6820(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 6716, 6820);
                    return 0;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Optional<TElement>>
                f_241_6929_6937(System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 6929, 6937);
                    return return_v;
                }


                System.Threading.Tasks.TaskCreationOptions
                f_241_6929_6953(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Optional<TElement>>
                this_param)
                {
                    var return_v = this_param.CreationOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 6929, 6953);
                    return return_v;
                }


                bool
                f_241_6929_7013(System.Threading.Tasks.TaskCreationOptions
                this_param, System.Threading.Tasks.TaskCreationOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 6929, 7013);
                    return return_v;
                }


                int
                f_241_6916_7014(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 6916, 7014);
                    return 0;
                }


                bool
                f_241_7037_7062(System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>
                this_param, Microsoft.CodeAnalysis.Optional<TElement>
                result)
                {
                    var return_v = this_param.TrySetResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 7037, 7062);
                    return return_v;
                }


                System.Collections.Generic.Queue<System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>>
                f_241_6859_6874_I(System.Collections.Generic.Queue<System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 6859, 6874);
                    return return_v;
                }


                System.Threading.Tasks.Task<bool>
                f_241_7126_7145(System.Threading.Tasks.TaskCompletionSource<bool>
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 7126, 7145);
                    return return_v;
                }


                System.Threading.Tasks.TaskCreationOptions
                f_241_7126_7161(System.Threading.Tasks.Task<bool>
                this_param)
                {
                    var return_v = this_param.CreationOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 7126, 7161);
                    return return_v;
                }


                bool
                f_241_7126_7221(System.Threading.Tasks.TaskCreationOptions
                this_param, System.Threading.Tasks.TaskCreationOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 7126, 7221);
                    return return_v;
                }


                int
                f_241_7113_7222(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 7113, 7222);
                    return 0;
                }


                int
                f_241_7237_7267(System.Threading.Tasks.TaskCompletionSource<bool>
                this_param, bool
                result)
                {
                    this_param.SetResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 7237, 7267);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 5717, 7307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 5717, 7307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task WhenCompletedTask
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 7765, 7843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 7801, 7828);

                    return f_241_7808_7827(_whenCompleted);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(241, 7765, 7843);

                    System.Threading.Tasks.Task<bool>
                    f_241_7808_7827(System.Threading.Tasks.TaskCompletionSource<bool>
                    this_param)
                    {
                        var return_v = this_param.Task;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 7808, 7827);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 7711, 7854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 7711, 7854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Gets a task whose result is the element at the head of the queue. If the queue
        /// is empty, the returned task waits for an element to be enqueued. If <see cref="Complete"/> 
        /// is called before an element becomes available, the returned task is cancelled.
        /// </summary>
        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", OftenCompletesSynchronously = true)]
        public Task<TElement> DequeueAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var optionalResult = TryDequeueAsync(cancellationToken);
            if (optionalResult.IsCompletedSuccessfully)
            {
                var result = optionalResult.Result;
                return result.HasValue
                    ? Task.FromResult(result.Value)
                    : Task.FromCanceled<TElement>(new CancellationToken(canceled: true));
            }

            return dequeueSlowAsync(optionalResult);

            static async Task<TElement> dequeueSlowAsync(ValueTask<Optional<TElement>> optionalResult)
            {
                var result = await optionalResult.ConfigureAwait(false);
                if (!result.HasValue)
                    new CancellationToken(canceled: true).ThrowIfCancellationRequested();

                return result.Value;
            }
        }

        /// <summary>
        /// Gets a task whose result is the element at the head of the queue. If the queue
        /// is empty, the returned task waits for an element to be enqueued. If <see cref="Complete"/> 
        /// is called before an element becomes available, the returned task is completed and
        /// <see cref="Optional{T}.HasValue"/> will be <see langword="false"/>.
        /// </summary>
        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", OftenCompletesSynchronously = true)]
        public ValueTask<Optional<TElement>> TryDequeueAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(241, 9703, 11012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 9940, 9950);
                lock (f_241_9940_9950())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10163, 10315) || true) && (f_241_10167_10178(_data) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 10163, 10315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10224, 10296);

                        return f_241_10231_10295(f_241_10279_10294(_data));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(241, 10163, 10315);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10335, 10474) || true) && (_completed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 10335, 10474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10391, 10455);

                        return f_241_10398_10454(default(Optional<TElement>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(241, 10335, 10474);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10494, 10561);

                    _waiters ??= f_241_10507_10560();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10697, 10807);

                    var
                    waiter = f_241_10710_10806(TaskCreationOptions.RunContinuationsAsynchronously)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10825, 10871);

                    f_241_10825_10870(waiter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10889, 10914);

                    f_241_10889_10913(_waiters, waiter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 10932, 10986);

                    return f_241_10939_10985(f_241_10973_10984(waiter));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(241, 9703, 11012);

                object
                f_241_9940_9950()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 9940, 9950);
                    return return_v;
                }


                int
                f_241_10167_10178(System.Collections.Generic.Queue<TElement>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 10167, 10178);
                    return return_v;
                }


                TElement
                f_241_10279_10294(System.Collections.Generic.Queue<TElement>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10279, 10294);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Optional<TElement>>
                f_241_10231_10295(TElement
                result)
                {
                    var return_v = ValueTaskFactory.FromResult<Optional<TElement>>((Microsoft.CodeAnalysis.Optional<TElement>)result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10231, 10295);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Optional<TElement>>
                f_241_10398_10454(Microsoft.CodeAnalysis.Optional<TElement>
                result)
                {
                    var return_v = ValueTaskFactory.FromResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10398, 10454);
                    return return_v;
                }


                System.Collections.Generic.Queue<System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>>
                f_241_10507_10560()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10507, 10560);
                    return return_v;
                }


                System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>
                f_241_10710_10806(System.Threading.Tasks.TaskCreationOptions
                creationOptions)
                {
                    var return_v = new System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>(creationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10710, 10806);
                    return return_v;
                }


                int
                f_241_10825_10870(System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>
                taskCompletionSource, System.Threading.CancellationToken
                cancellationToken)
                {
                    AttachCancellation(taskCompletionSource, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10825, 10870);
                    return 0;
                }


                int
                f_241_10889_10913(System.Collections.Generic.Queue<System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>>
                this_param, System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10889, 10913);
                    return 0;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Optional<TElement>>
                f_241_10973_10984(System.Threading.Tasks.TaskCompletionSource<Microsoft.CodeAnalysis.Optional<TElement>>
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 10973, 10984);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Optional<TElement>>
                f_241_10939_10985(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Optional<TElement>>
                task)
                {
                    var return_v = new System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Optional<TElement>>(task);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 10939, 10985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 9703, 11012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 9703, 11012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AttachCancellation<T>(TaskCompletionSource<T> taskCompletionSource, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(241, 11717, 13308);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 11866, 11969) || true) && (f_241_11870_11902_M(!cancellationToken.CanBeCanceled) || (DynAbs.Tracing.TraceSender.Expression_False(241, 11870, 11943) || f_241_11906_11943(f_241_11906_11931(taskCompletionSource))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 11866, 11969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 11962, 11969);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(241, 11866, 11969);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 11985, 12159) || true) && (cancellationToken.IsCancellationRequested)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(241, 11985, 12159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 12064, 12119);

                    f_241_12064_12118(taskCompletionSource, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 12137, 12144);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(241, 11985, 12159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 12175, 12291);

                var
                cancelableTaskCompletionSource = f_241_12212_12290(taskCompletionSource, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 12305, 12713);

                cancelableTaskCompletionSource.CancellationTokenRegistration = cancellationToken.Register(static s =>
                {
                    var t = (CancelableTaskCompletionSource<T>)s!;
                    t.TaskCompletionSource.TrySetCanceled(t.CancellationToken);
                }, cancelableTaskCompletionSource, useSynchronizationContext: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 12729, 12845);

                f_241_12729_12844(f_241_12742_12843(f_241_12742_12783(f_241_12742_12767(taskCompletionSource)), TaskCreationOptions.RunContinuationsAsynchronously));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 12859, 13297);

                f_241_12859_13296(f_241_12859_12884(taskCompletionSource), static (_, s) =>
                                {
                                    var t = (CancelableTaskCompletionSource<T>)s!;
                                    t.CancellationTokenRegistration.Dispose();
                                }, cancelableTaskCompletionSource, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, f_241_13274_13295());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(241, 11717, 13308);

                bool
                f_241_11870_11902_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 11870, 11902);
                    return return_v;
                }


                System.Threading.Tasks.Task<T>
                f_241_11906_11931(System.Threading.Tasks.TaskCompletionSource<T>
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 11906, 11931);
                    return return_v;
                }


                bool
                f_241_11906_11943(System.Threading.Tasks.Task<T>
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 11906, 11943);
                    return return_v;
                }


                bool
                f_241_12064_12118(System.Threading.Tasks.TaskCompletionSource<T>
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.TrySetCanceled(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 12064, 12118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>.CancelableTaskCompletionSource<T>
                f_241_12212_12290(System.Threading.Tasks.TaskCompletionSource<T>
                taskCompletionSource, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>.CancelableTaskCompletionSource<T>(taskCompletionSource, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 12212, 12290);
                    return return_v;
                }


                System.Threading.Tasks.Task<T>
                f_241_12742_12767(System.Threading.Tasks.TaskCompletionSource<T>
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 12742, 12767);
                    return return_v;
                }


                System.Threading.Tasks.TaskCreationOptions
                f_241_12742_12783(System.Threading.Tasks.Task<T>
                this_param)
                {
                    var return_v = this_param.CreationOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 12742, 12783);
                    return return_v;
                }


                bool
                f_241_12742_12843(System.Threading.Tasks.TaskCreationOptions
                this_param, System.Threading.Tasks.TaskCreationOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 12742, 12843);
                    return return_v;
                }


                int
                f_241_12729_12844(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 12729, 12844);
                    return 0;
                }


                System.Threading.Tasks.Task<T>
                f_241_12859_12884(System.Threading.Tasks.TaskCompletionSource<T>
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 12859, 12884);
                    return return_v;
                }


                System.Threading.Tasks.TaskScheduler
                f_241_13274_13295()
                {
                    var return_v = TaskScheduler.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(241, 13274, 13295);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_241_12859_13296(System.Threading.Tasks.Task<T>
                this_param, System.Action<System.Threading.Tasks.Task<T>, object?>
                continuationAction, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<TElement>.CancelableTaskCompletionSource<T>
                state, System.Threading.CancellationToken
                cancellationToken, System.Threading.Tasks.TaskContinuationOptions
                continuationOptions, System.Threading.Tasks.TaskScheduler
                scheduler)
                {
                    var return_v = this_param.ContinueWith(continuationAction, (object)state, cancellationToken, continuationOptions, scheduler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 12859, 13296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 11717, 13308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 11717, 13308);
            }
        }
        private sealed class CancelableTaskCompletionSource<T>
        {
            internal CancelableTaskCompletionSource(TaskCompletionSource<T> taskCompletionSource, CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(241, 14376, 14646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 14937, 14999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 14531, 14575);

                    TaskCompletionSource = taskCompletionSource;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 14593, 14631);

                    CancellationToken = cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(241, 14376, 14646);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(241, 14376, 14646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 14376, 14646);
                }
            }

            internal CancellationToken CancellationToken { get; }

            internal TaskCompletionSource<T> TaskCompletionSource { get; }

            internal CancellationTokenRegistration CancellationTokenRegistration { get; set; }

            static CancelableTaskCompletionSource()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(241, 13967, 15230);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(241, 13967, 15230);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 13967, 15230);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(241, 13967, 15230);
        }

        public AsyncQueue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(241, 651, 15237);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 929, 1028);
            this._whenCompleted = f_241_946_1028(TaskCreationOptions.RunContinuationsAsynchronously); DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 1214, 1243);
            this._data = f_241_1222_1243(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 1310, 1318);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 1342, 1352);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(241, 1376, 1392);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(241, 651, 15237);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 651, 15237);
        }


        static AsyncQueue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(241, 651, 15237);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(241, 651, 15237);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(241, 651, 15237);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(241, 651, 15237);

        System.Threading.Tasks.TaskCompletionSource<bool>
        f_241_946_1028(System.Threading.Tasks.TaskCreationOptions
        creationOptions)
        {
            var return_v = new System.Threading.Tasks.TaskCompletionSource<bool>(creationOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 946, 1028);
            return return_v;
        }


        System.Collections.Generic.Queue<TElement>
        f_241_1222_1243()
        {
            var return_v = new System.Collections.Generic.Queue<TElement>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(241, 1222, 1243);
            return return_v;
        }

    }
}
