// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.InternalUtilities
{
    internal class ConcurrentLruCache<K, V>
            where K : notnull
            where V : notnull
    {
        private readonly int _capacity;

        private struct CacheValue
        {

            public V Value;

            public LinkedListNode<K> Node;
            static CacheValue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(315, 678, 798);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(315, 678, 798);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 678, 798);
            }
        }

        private readonly Dictionary<K, CacheValue> _cache;

        private readonly LinkedList<K> _nodeList;

        private readonly object _lockObject;

        public ConcurrentLruCache(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(315, 1055, 1396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 656, 665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 853, 859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 901, 910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1023, 1042);
                this._lockObject = f_315_1037_1042();
                object
f_315_1037_1042()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 1037, 1042);
                    return return_v;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1119, 1241) || true) && (capacity <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 1119, 1241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1170, 1226);

                    throw f_315_1176_1225(nameof(capacity));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(315, 1119, 1241);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1255, 1276);

                _capacity = capacity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1290, 1339);

                _cache = f_315_1299_1338<K>(capacity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1353, 1385);

                _nodeList = f_315_1365_1384<K>();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(315, 1055, 1396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 1055, 1396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 1055, 1396);
            }
        }

        public ConcurrentLruCache(KeyValuePair<K, V>[] array)
        : this(f_315_1809_1821_C(f_315_1809_1821(array)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(315, 1735, 1973);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1847, 1962);
                    foreach (var kvp in f_315_1867_1872_I(array))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 1847, 1962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 1906, 1947);

                        f_315_1906_1946(this, kvp.Key, kvp.Value, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 1847, 1962);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(315, 1, 116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(315, 1, 116);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(315, 1735, 1973);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 1735, 1973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 1735, 1973);
            }
        }

        internal IEnumerable<KeyValuePair<K, V>> TestingEnumerable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 2157, 2653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2199, 2210);
                    lock (_lockObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2252, 2300);

                        var
                        copy = new KeyValuePair<K, V>[f_315_2286_2298(_cache)]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2322, 2336);

                        int
                        index = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2358, 2585);
                            foreach (K key in f_315_2376_2385_I(_nodeList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 2358, 2585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2435, 2562);

                                copy[index++] = f_315_2451_2561(key, _cache[key].Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(315, 2358, 2585);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(315, 1, 228);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(315, 1, 228);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2607, 2619);

                        return copy;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(315, 2157, 2653);

                    int
                    f_315_2286_2298(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(315, 2286, 2298);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<K, V>
                    f_315_2451_2561(K
                    key, V
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<K, V>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 2451, 2561);
                        return return_v;
                    }


                    System.Collections.Generic.LinkedList<K>
                    f_315_2376_2385_I(System.Collections.Generic.LinkedList<K>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 2376, 2385);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 2074, 2664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 2074, 2664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Add(K key, V value)
        {
            lock (_lockObject)
            {
                UnsafeAdd(key, value, true);
            }
        }

        private void MoveNodeToTop(LinkedListNode<K> node)
        {
            if (!object.ReferenceEquals(_nodeList.First, node))
            {
                _nodeList.Remove(node);
                _nodeList.AddFirst(node);
            }
        }

        /// <summary>
        /// Expects non-empty cache. Does not lock.
        /// </summary>
        private void UnsafeEvictLastNode()
        {
            Debug.Assert(_capacity > 0);
            var lastNode = _nodeList.Last;
            _nodeList.Remove(lastNode!);
            _cache.Remove(lastNode!.Value);
        }

        private void UnsafeAddNodeToTop(K key, V value)
        {
            var node = new LinkedListNode<K>(key);
            _cache.Add(key, new CacheValue { Node = node, Value = value });
            _nodeList.AddFirst(node);
        }

        /// <summary>
        /// Doesn't lock.
        /// </summary>
        private void UnsafeAdd(K key, V value, bool throwExceptionIfKeyExists)
        {
            if (_cache.TryGetValue(key, out var result))
            {
                if (throwExceptionIfKeyExists)
                {
                    throw new ArgumentException("Key already exists", nameof(key));
                }
                else if (!result.Value.Equals(value))
                {
                    result.Value = value;
                    _cache[key] = result;
                    MoveNodeToTop(result.Node);
                }
            }
            else
            {
                if (_cache.Count == _capacity)
                {
                    UnsafeEvictLastNode();
                }
                UnsafeAddNodeToTop(key, value);
            }
        }

        public V this[K key]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 4639, 4914);
                    Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue result = default(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue);
                    V value = default(V);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4675, 4899) || true) && (f_315_4679_4710(this, key, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 4675, 4899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4752, 4765);

                        return value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 4675, 4899);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 4675, 4899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4847, 4880);

                        throw f_315_4853_4879();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 4675, 4899);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(315, 4639, 4914);

                    bool
                    f_315_4679_4710(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                    this_param, K
                    key, out V
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 4679, 4710);
                        return return_v;
                    }


                    System.Collections.Generic.KeyNotFoundException
                    f_315_4853_4879()
                    {
                        var return_v = new System.Collections.Generic.KeyNotFoundException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 4853, 4879);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 4639, 4914);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 4639, 4914);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 4928, 5086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4970, 4981);
                    lock (_lockObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5023, 5052);

                        f_315_5023_5051(this, key, value, false);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(315, 4928, 5086);

                    int
                    f_315_5023_5051(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                    this_param, K
                    key, V
                    value, bool
                    throwExceptionIfKeyExists)
                    {
                        this_param.UnsafeAdd(key, value, throwExceptionIfKeyExists);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 5023, 5051);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 4928, 5086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 4928, 5086);
                }
            }
        }

        public bool TryGetValue(K key, [MaybeNullWhen(returnValue: false)] out V value)
        {
            lock (_lockObject)
            {
                return UnsafeTryGetValue(key, out value);
            }
        }

        /// <summary>
        /// Doesn't lock.
        /// </summary>
        public bool UnsafeTryGetValue(K key, [MaybeNullWhen(returnValue: false)] out V value)
        {
            if (_cache.TryGetValue(key, out var result))
            {
                MoveNodeToTop(result.Node);
                value = result.Value;
                return true;
            }
            else
            {
                value = default!;
                return false;
            }
        }

        public V GetOrAdd(K key, V value)
        {
            lock (_lockObject)
            {
                if (UnsafeTryGetValue(key, out var result))
                {
                    return result;
                }
                else
                {
                    UnsafeAdd(key, value, true);
                    return value;
                }
            }
        }

        public V GetOrAdd(K key, Func<V> creator)
        {
            lock (_lockObject)
            {
                if (UnsafeTryGetValue(key, out var result))
                {
                    return result;
                }
                else
                {
                    var value = creator();
                    UnsafeAdd(key, value, true);
                    return value;
                }
            }
        }

        public V GetOrAdd<T>(K key, T arg, Func<T, V> creator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 6722, 7187);
                V result = default(V);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6807, 6818);
                lock (_lockObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6852, 7161) || true) && (f_315_6856_6894(this, key, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 6852, 7161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6936, 6950);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 6852, 7161);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 6852, 7161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 7032, 7057);

                        var
                        value = f_315_7044_7056(creator, arg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 7079, 7107);

                        f_315_7079_7106(this, key, value, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 7129, 7142);

                        return value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 6852, 7161);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 6722, 7187);

                bool
                f_315_6856_6894(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, out V
                value)
                {
                    var return_v = this_param.UnsafeTryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 6856, 6894);
                    return return_v;
                }


                V
                f_315_7044_7056(System.Func<T, V>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 7044, 7056);
                    return return_v;
                }


                int
                f_315_7079_7106(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, V
                value, bool
                throwExceptionIfKeyExists)
                {
                    this_param.UnsafeAdd(key, value, throwExceptionIfKeyExists);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 7079, 7106);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 6722, 7187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 6722, 7187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConcurrentLruCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(315, 525, 7194);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(315, 525, 7194);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 525, 7194);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(315, 525, 7194);

        static System.ArgumentOutOfRangeException
        f_315_1176_1225(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 1176, 1225);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>
        f_315_1299_1338<K>(int
        capacity) where K : notnull

        {
            var return_v = new System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 1299, 1338);
            return return_v;
        }


        static System.Collections.Generic.LinkedList<K>
        f_315_1365_1384<K>() where K : notnull

        {
            var return_v = new System.Collections.Generic.LinkedList<K>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 1365, 1384);
            return return_v;
        }


        static int
        f_315_1809_1821(System.Collections.Generic.KeyValuePair<K, V>[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(315, 1809, 1821);
            return return_v;
        }


        static int
        f_315_1906_1946<K, V>(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
        this_param, K
        key, V
        value, bool
        throwExceptionIfKeyExists) where K : notnull
                where V : notnull

        {
            this_param.UnsafeAdd(key, value, throwExceptionIfKeyExists);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 1906, 1946);
            return 0;
        }


        System.Collections.Generic.KeyValuePair<K, V>[]
        f_315_1867_1872_I(System.Collections.Generic.KeyValuePair<K, V>[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 1867, 1872);
            return return_v;
        }


        static int
        f_315_1809_1821_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(315, 1735, 1973);
            return return_v;
        }

    }
}
