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
            if (!EnqueueCore(value))
            {
                throw new InvalidOperationException($"Cannot call {nameof(Enqueue)} when the queue is already completed.");
            }
        }

        /// <summary>
        /// Tries to add an element to the tail of the queue.  This method will return false if the queue
        /// is completed.
        /// </summary>
        /// <param name="value">The value to add.</param>
        public bool TryEnqueue(TElement value)
        {
            return EnqueueCore(value);
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
            lock (SyncObject)
            {
                if (_data.Count == 0)
                {
                    d = default(TElement);
                    return false;
                }

                d = _data.Dequeue();
                return true;
            }
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
            if (!CompleteCore())
            {
                throw new InvalidOperationException($"Cannot call {nameof(Complete)} when the queue is already completed.");
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
            return CompleteCore();
        }

        private bool CompleteCore()
        {
            Queue<TaskCompletionSource<Optional<TElement>>> existingWaiters;
            lock (SyncObject)
            {
                if (_completed)
                {
                    return false;
                }

                _completed = true;

                existingWaiters = _waiters;
                _waiters = null;
            }

            if (existingWaiters?.Count > 0)
            {
                // cancel waiters.
                // NOTE: AsyncQueue has an invariant that 
                //       the queue can either have waiters or items, not both
                //       adding an item would "unwait" the waiters
                //       the fact that we _had_ waiters at the time we completed the queue
                //       guarantees that there is no items in the queue now or in the future, 
                //       so it is safe to cancel waiters with no loss of diagnostics
                Debug.Assert(this.Count == 0, "we should not be cancelling the waiters when we have items in the queue");
                foreach (var tcs in existingWaiters)
                {
                    Debug.Assert(tcs.Task.CreationOptions.HasFlag(TaskCreationOptions.RunContinuationsAsynchronously));
                    tcs.TrySetResult(default);
                }
            }

            Debug.Assert(_whenCompleted.Task.CreationOptions.HasFlag(TaskCreationOptions.RunContinuationsAsynchronously));
            _whenCompleted.SetResult(true);

            return true;
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
            lock (SyncObject)
            {
                // No matter what the state we allow DequeueAsync to drain the existing items 
                // in the queue.  This keeps the behavior in line with TryDequeue
                if (_data.Count > 0)
                {
                    return ValueTaskFactory.FromResult<Optional<TElement>>(_data.Dequeue());
                }

                if (_completed)
                {
                    return ValueTaskFactory.FromResult(default(Optional<TElement>));
                }

                _waiters ??= new Queue<TaskCompletionSource<Optional<TElement>>>();

                // Continuations run asynchronously to ensure user code does not execute within protected regions.
                var waiter = new TaskCompletionSource<Optional<TElement>>(TaskCreationOptions.RunContinuationsAsynchronously);
                AttachCancellation(waiter, cancellationToken);
                _waiters.Enqueue(waiter);
                return new ValueTask<Optional<TElement>>(waiter.Task);
            }
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
