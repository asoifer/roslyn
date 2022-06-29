// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace Roslyn.Utilities
{
    [DebuggerDisplay("Count = {Count}")]
    internal sealed class ConcurrentSet<T> : ICollection<T>
            where T : notnull
    {
        private const int
        DefaultConcurrencyLevel = 2
        ;

        private const int
        DefaultCapacity = 31
        ;

        private readonly ConcurrentDictionary<T, byte> _dictionary;

        public ConcurrentSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(316, 1491, 1639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 1344, 1355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 1538, 1628);

                _dictionary = f_316_1552_1627<T>(DefaultConcurrencyLevel, DefaultCapacity);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(316, 1491, 1639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 1491, 1639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 1491, 1639);
            }
        }

        public ConcurrentSet(IEqualityComparer<T> equalityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(316, 1874, 2077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 1344, 1355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 1958, 2066);

                _dictionary = f_316_1972_2065<T>(DefaultConcurrencyLevel, DefaultCapacity, equalityComparer);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(316, 1874, 2077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 1874, 2077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 1874, 2077);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 2275, 2295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 2278, 2295);
                    return f_316_2278_2295(_dictionary); DynAbs.Tracing.TraceSender.TraceExitMethod(316, 2275, 2295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 2275, 2295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 2275, 2295);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 2486, 2508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 2489, 2508);
                    return f_316_2489_2508(_dictionary); DynAbs.Tracing.TraceSender.TraceExitMethod(316, 2486, 2508);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 2486, 2508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 2486, 2508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 2544, 2552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 2547, 2552);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(316, 2544, 2552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 2544, 2552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 2544, 2552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Determine whether the given value is in the set.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <returns>true if the set contains the specified value; otherwise, false.</returns>
        public bool Contains(T value)
        {
            return _dictionary.ContainsKey(value);
        }

        /// <summary>
        /// Attempts to add a value to the set.
        /// </summary>
        /// <param name="value">The value to add.</param>
        /// <returns>true if the value was added to the set. If the value already exists, this method returns false.</returns>
        public bool Add(T value)
        {
            return _dictionary.TryAdd(value, 0);
        }

        public void AddRange(IEnumerable<T>? values)
        {
            if (values != null)
            {
                foreach (var v in values)
                {
                    Add(v);
                }
            }
        }

        /// <summary>
        /// Attempts to remove a value from the set.
        /// </summary>
        /// <param name="value">The value to remove.</param>
        /// <returns>true if the value was removed successfully; otherwise false.</returns>
        public bool Remove(T value)
        {
            return _dictionary.TryRemove(value, out _);
        }

        /// <summary>
        /// Clear the set
        /// </summary>
        public void Clear()
        {
            _dictionary.Clear();
        }

        public struct KeyEnumerator
        {

            private readonly IEnumerator<KeyValuePair<T, byte>> _kvpEnumerator;

            internal KeyEnumerator(IEnumerable<KeyValuePair<T, byte>> data)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(316, 4257, 4406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 4353, 4391);

                    _kvpEnumerator = f_316_4370_4390(data);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(316, 4257, 4406);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 4257, 4406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 4257, 4406);
                }
            }

            public T Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 4439, 4468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 4442, 4468);
                        return _kvpEnumerator.Current.Key; DynAbs.Tracing.TraceSender.TraceExitMethod(316, 4439, 4468);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 4439, 4468);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 4439, 4468);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 4485, 4588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 4540, 4573);

                    return f_316_4547_4572(_kvpEnumerator);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(316, 4485, 4588);

                    bool
                    f_316_4547_4572(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T, byte>>
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 4547, 4572);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 4485, 4588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 4485, 4588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 4604, 4694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 4656, 4679);

                    f_316_4656_4678(_kvpEnumerator);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(316, 4604, 4694);

                    int
                    f_316_4656_4678(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T, byte>>
                    this_param)
                    {
                        this_param.Reset();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 4656, 4678);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 4604, 4694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 4604, 4694);
                }
            }
            static KeyEnumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(316, 4122, 4705);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(316, 4122, 4705);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 4122, 4705);
            }

            static System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T, byte>>
            f_316_4370_4390(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T, byte>>
            this_param)
            {
                var return_v = this_param.GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 4370, 4390);
                return return_v;
            }

        }

        /// <summary>
        /// Obtain an enumerator that iterates through the elements in the set.
        /// </summary>
        /// <returns>An enumerator for the set.</returns>
        public KeyEnumerator GetEnumerator()
        {
            // PERF: Do not use dictionary.Keys here because that creates a snapshot
            // of the collection resulting in a List<T> allocation. Instead, use the
            // KeyValuePair enumerator and pick off the Key part.
            return new KeyEnumerator(_dictionary);
        }

        private IEnumerator<T> GetEnumeratorImpl()
        {
            // PERF: Do not use dictionary.Keys here because that creates a snapshot
            // of the collection resulting in a List<T> allocation. Instead, use the
            // KeyValuePair enumerator and pick off the Key part.
            foreach (var kvp in _dictionary)
            {
                yield return kvp.Key;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumeratorImpl();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorImpl();
        }

        void ICollection<T>.Add(T item)
        {
            Add(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            // PERF: Do not use dictionary.Keys here because that creates a snapshot
            // of the collection resulting in a List<T> allocation.
            // Instead, enumerate the set and copy over the elements.
            foreach (var element in this)
            {
                array[arrayIndex++] = element;
            }
        }

        static ConcurrentSet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(316, 454, 6439);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 971, 998);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 1138, 1158);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(316, 454, 6439);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 454, 6439);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(316, 454, 6439);

        static System.Collections.Concurrent.ConcurrentDictionary<T, byte>
        f_316_1552_1627<T>(int
        concurrencyLevel, int
        capacity) where T : notnull

        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<T, byte>(concurrencyLevel, capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 1552, 1627);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<T, byte>
        f_316_1972_2065<T>(int
        concurrencyLevel, int
        capacity, System.Collections.Generic.IEqualityComparer<T>
        comparer) where T : notnull

        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<T, byte>(concurrencyLevel, capacity, comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 1972, 2065);
            return return_v;
        }


        int
        f_316_2278_2295(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(316, 2278, 2295);
            return return_v;
        }


        bool
        f_316_2489_2508(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
        this_param)
        {
            var return_v = this_param.IsEmpty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(316, 2489, 2508);
            return return_v;
        }

    }
}
