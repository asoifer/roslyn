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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 2830, 2933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 2884, 2922);

                return f_316_2891_2921(_dictionary, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 2830, 2933);

                bool
                f_316_2891_2921(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
                this_param, T
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 2891, 2921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 2830, 2933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 2830, 2933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Attempts to add a value to the set.
        /// </summary>
        /// <param name="value">The value to add.</param>
        /// <returns>true if the value was added to the set. If the value already exists, this method returns false.</returns>
        public bool Add(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 3228, 3324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 3277, 3313);

                return f_316_3284_3312(_dictionary, value, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 3228, 3324);

                bool
                f_316_3284_3312(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
                this_param, T
                key, int
                value)
                {
                    var return_v = this_param.TryAdd(key, (byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 3284, 3312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 3228, 3324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 3228, 3324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void AddRange(IEnumerable<T>? values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 3336, 3575);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 3405, 3564) || true) && (values != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(316, 3405, 3564);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 3457, 3549);
                        foreach (var v in f_316_3475_3481_I(values))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(316, 3457, 3549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 3523, 3530);

                            f_316_3523_3529(this, v);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(316, 3457, 3549);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(316, 1, 93);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(316, 1, 93);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(316, 3405, 3564);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 3336, 3575);

                bool
                f_316_3523_3529(Roslyn.Utilities.ConcurrentSet<T>
                this_param, T
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 3523, 3529);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_316_3475_3481_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 3475, 3481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 3336, 3575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 3336, 3575);
            }
        }

        /// <summary>
        /// Attempts to remove a value from the set.
        /// </summary>
        /// <param name="value">The value to remove.</param>
        /// <returns>true if the value was removed successfully; otherwise false.</returns>
        public bool Remove(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 3843, 3949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 3895, 3938);

                return f_316_3902_3937(_dictionary, value, out _);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 3843, 3949);

                bool
                f_316_3902_3937(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
                this_param, T
                key, out byte
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 3902, 3937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 3843, 3949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 3843, 3949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Clear the set
        /// </summary>
        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 4035, 4110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 4079, 4099);

                f_316_4079_4098(_dictionary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 4035, 4110);

                int
                f_316_4079_4098(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 4079, 4098);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 4035, 4110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 4035, 4110);
            }
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 4904, 5253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 5204, 5242);

                return f_316_5211_5241(_dictionary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 4904, 5253);

                Roslyn.Utilities.ConcurrentSet<T>.KeyEnumerator
                f_316_5211_5241(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
                data)
                {
                    var return_v = new Roslyn.Utilities.ConcurrentSet<T>.KeyEnumerator((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T, byte>>)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 5211, 5241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 4904, 5253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 4904, 5253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerator<T> GetEnumeratorImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 5265, 5683);

                var listYield = new List<T>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 5571, 5672);
                    foreach (var kvp in f_316_5591_5602_I(_dictionary))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(316, 5571, 5672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 5636, 5657);

                        listYield.Add(kvp.Key);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(316, 5571, 5672);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(316, 1, 102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(316, 1, 102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 5265, 5683);

                return listYield.GetEnumerator();

                System.Collections.Concurrent.ConcurrentDictionary<T, byte>
                f_316_5591_5602_I(System.Collections.Concurrent.ConcurrentDictionary<T, byte>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 5591, 5602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 5265, 5683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 5265, 5683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 5695, 5803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 5765, 5792);

                return f_316_5772_5791(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 5695, 5803);

                System.Collections.Generic.IEnumerator<T>
                f_316_5772_5791(Roslyn.Utilities.ConcurrentSet<T>
                this_param)
                {
                    var return_v = this_param.GetEnumeratorImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 5772, 5791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 5695, 5803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 5695, 5803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 5815, 5917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 5879, 5906);

                return f_316_5886_5905(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 5815, 5917);

                System.Collections.Generic.IEnumerator<T>
                f_316_5886_5905(Roslyn.Utilities.ConcurrentSet<T>
                this_param)
                {
                    var return_v = this_param.GetEnumeratorImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 5886, 5905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 5815, 5917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 5815, 5917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void ICollection<T>.Add(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 5929, 6006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 5985, 5995);

                f_316_5985_5994(this, item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 5929, 6006);

                bool
                f_316_5985_5994(Roslyn.Utilities.ConcurrentSet<T>
                this_param, T
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 5985, 5994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 5929, 6006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 5929, 6006);
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(316, 6018, 6432);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 6314, 6421);
                    foreach (var element in f_316_6338_6342_I(this))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(316, 6314, 6421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(316, 6376, 6406);

                        array[arrayIndex++] = element;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(316, 6314, 6421);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(316, 1, 108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(316, 1, 108);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(316, 6018, 6432);

                Roslyn.Utilities.ConcurrentSet<T>
                f_316_6338_6342_I(Roslyn.Utilities.ConcurrentSet<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(316, 6338, 6342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(316, 6018, 6432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(316, 6018, 6432);
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
