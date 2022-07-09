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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 2676, 2837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2738, 2749);
                lock (_lockObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2783, 2811);

                    f_315_2783_2810(this, key, value, true);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 2676, 2837);

                int
                f_315_2783_2810(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, V
                value, bool
                throwExceptionIfKeyExists)
                {
                    this_param.UnsafeAdd(key, value, throwExceptionIfKeyExists);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 2783, 2810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 2676, 2837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 2676, 2837);
            }
        }

        private void MoveNodeToTop(LinkedListNode<K> node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 2849, 3100);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 2924, 3089) || true) && (!f_315_2929_2974(f_315_2952_2967(_nodeList), node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 2924, 3089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3008, 3031);

                    f_315_3008_3030(_nodeList, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3049, 3074);

                    f_315_3049_3073(_nodeList, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(315, 2924, 3089);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 2849, 3100);

                System.Collections.Generic.LinkedListNode<K>?
                f_315_2952_2967(System.Collections.Generic.LinkedList<K>
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(315, 2952, 2967);
                    return return_v;
                }


                bool
                f_315_2929_2974(System.Collections.Generic.LinkedListNode<K>?
                objA, System.Collections.Generic.LinkedListNode<K>
                objB)
                {
                    var return_v = object.ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 2929, 2974);
                    return return_v;
                }


                int
                f_315_3008_3030(System.Collections.Generic.LinkedList<K>
                this_param, System.Collections.Generic.LinkedListNode<K>
                node)
                {
                    this_param.Remove(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3008, 3030);
                    return 0;
                }


                int
                f_315_3049_3073(System.Collections.Generic.LinkedList<K>
                this_param, System.Collections.Generic.LinkedListNode<K>
                node)
                {
                    this_param.AddFirst(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3049, 3073);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 2849, 3100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 2849, 3100);
            }
        }

        /// <summary>
        /// Expects non-empty cache. Does not lock.
        /// </summary>
        private void UnsafeEvictLastNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 3212, 3441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3271, 3299);

                f_315_3271_3298(_capacity > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3313, 3343);

                var
                lastNode = f_315_3328_3342(_nodeList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3357, 3385);

                f_315_3357_3384(_nodeList, lastNode!);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3399, 3430);

                f_315_3399_3429(_cache, f_315_3413_3428(lastNode!));
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 3212, 3441);

                int
                f_315_3271_3298(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3271, 3298);
                    return 0;
                }


                System.Collections.Generic.LinkedListNode<K>?
                f_315_3328_3342(System.Collections.Generic.LinkedList<K>
                this_param)
                {
                    var return_v = this_param.Last;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(315, 3328, 3342);
                    return return_v;
                }


                int
                f_315_3357_3384(System.Collections.Generic.LinkedList<K>
                this_param, System.Collections.Generic.LinkedListNode<K>
                node)
                {
                    this_param.Remove(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3357, 3384);
                    return 0;
                }


                K
                f_315_3413_3428(System.Collections.Generic.LinkedListNode<K>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(315, 3413, 3428);
                    return return_v;
                }


                bool
                f_315_3399_3429(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>
                this_param, K
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3399, 3429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 3212, 3441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 3212, 3441);
            }
        }

        private void UnsafeAddNodeToTop(K key, V value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 3453, 3690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3525, 3563);

                var
                node = f_315_3536_3562(key)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3577, 3640);

                f_315_3577_3639(_cache, key, new CacheValue { Node = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => node, 315, 3593, 3638), Value = value });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3654, 3679);

                f_315_3654_3678(_nodeList, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 3453, 3690);

                System.Collections.Generic.LinkedListNode<K>
                f_315_3536_3562(K
                value)
                {
                    var return_v = new System.Collections.Generic.LinkedListNode<K>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3536, 3562);
                    return return_v;
                }


                int
                f_315_3577_3639(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>
                this_param, K
                key, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3577, 3639);
                    return 0;
                }


                int
                f_315_3654_3678(System.Collections.Generic.LinkedList<K>
                this_param, System.Collections.Generic.LinkedListNode<K>
                node)
                {
                    this_param.AddFirst(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3654, 3678);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 3453, 3690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 3453, 3690);
            }
        }

        /// <summary>
        /// Doesn't lock.
        /// </summary>
        private void UnsafeAdd(K key, V value, bool throwExceptionIfKeyExists)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 3776, 4582);
                Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue result = default(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3871, 4571) || true) && (f_315_3875_3914(_cache, key, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 3871, 4571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 3948, 4329) || true) && (throwExceptionIfKeyExists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 3948, 4329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4019, 4082);

                        throw f_315_4025_4081("Key already exists", nameof(key));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 3948, 4329);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 3948, 4329);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4124, 4329) || true) && (!f_315_4129_4155(result.Value, value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 4124, 4329);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4197, 4218);

                            result.Value = value;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4240, 4261);

                            _cache[key] = result;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4283, 4310);

                            f_315_4283_4309(this, result.Node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(315, 4124, 4329);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 3948, 4329);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(315, 3871, 4571);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 3871, 4571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4395, 4507) || true) && (f_315_4399_4411(_cache) == _capacity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 4395, 4507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4466, 4488);

                        f_315_4466_4487(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 4395, 4507);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 4525, 4556);

                    f_315_4525_4555(this, key, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(315, 3871, 4571);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 3776, 4582);

                bool
                f_315_3875_3914(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>
                this_param, K
                key, out Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 3875, 3914);
                    return return_v;
                }


                System.ArgumentException
                f_315_4025_4081(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 4025, 4081);
                    return return_v;
                }


                bool
                f_315_4129_4155(V
                this_param, V
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 4129, 4155);
                    return return_v;
                }


                int
                f_315_4283_4309(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, System.Collections.Generic.LinkedListNode<K>
                node)
                {
                    this_param.MoveNodeToTop(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 4283, 4309);
                    return 0;
                }


                int
                f_315_4399_4411(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(315, 4399, 4411);
                    return return_v;
                }


                int
                f_315_4466_4487(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param)
                {
                    this_param.UnsafeEvictLastNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 4466, 4487);
                    return 0;
                }


                int
                f_315_4525_4555(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, V
                value)
                {
                    this_param.UnsafeAddNodeToTop(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 4525, 4555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 3776, 4582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 3776, 4582);
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 5109, 5331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5219, 5230);
                lock (_lockObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5264, 5305);

                    return f_315_5271_5304(this, key, out value);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 5109, 5331);

                bool
                f_315_5271_5304(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, out V
                value)
                {
                    var return_v = this_param.UnsafeTryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 5271, 5304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 5109, 5331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 5109, 5331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Doesn't lock.
        /// </summary>
        public bool UnsafeTryGetValue(K key, [MaybeNullWhen(returnValue: false)] out V value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 5417, 5840);
                Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue result = default(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5527, 5829) || true) && (f_315_5531_5570(_cache, key, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 5527, 5829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5604, 5631);

                    f_315_5604_5630(this, result.Node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5649, 5670);

                    value = result.Value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5688, 5700);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(315, 5527, 5829);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 5527, 5829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5766, 5783);

                    value = default!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5801, 5814);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(315, 5527, 5829);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 5417, 5840);

                bool
                f_315_5531_5570(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue>
                this_param, K
                key, out Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>.CacheValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 5531, 5570);
                    return return_v;
                }


                int
                f_315_5604_5630(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, System.Collections.Generic.LinkedListNode<K>
                node)
                {
                    this_param.MoveNodeToTop(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 5604, 5630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 5417, 5840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 5417, 5840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public V GetOrAdd(K key, V value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 5852, 6249);
                V result = default(V);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5916, 5927);
                lock (_lockObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 5961, 6223) || true) && (f_315_5965_6003(this, key, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 5961, 6223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6045, 6059);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 5961, 6223);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 5961, 6223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6141, 6169);

                        f_315_6141_6168(this, key, value, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6191, 6204);

                        return value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 5961, 6223);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 5852, 6249);

                bool
                f_315_5965_6003(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, out V
                value)
                {
                    var return_v = this_param.UnsafeTryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 5965, 6003);
                    return return_v;
                }


                int
                f_315_6141_6168(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, V
                value, bool
                throwExceptionIfKeyExists)
                {
                    this_param.UnsafeAdd(key, value, throwExceptionIfKeyExists);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 6141, 6168);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 5852, 6249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 5852, 6249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public V GetOrAdd(K key, Func<V> creator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(315, 6261, 6710);
                V result = default(V);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6333, 6344);
                lock (_lockObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6378, 6684) || true) && (f_315_6382_6420(this, key, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 6378, 6684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6462, 6476);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 6378, 6684);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(315, 6378, 6684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6558, 6580);

                        var
                        value = f_315_6570_6579(creator)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6602, 6630);

                        f_315_6602_6629(this, key, value, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(315, 6652, 6665);

                        return value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(315, 6378, 6684);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(315, 6261, 6710);

                bool
                f_315_6382_6420(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, out V
                value)
                {
                    var return_v = this_param.UnsafeTryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 6382, 6420);
                    return return_v;
                }


                V
                f_315_6570_6579(System.Func<V>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 6570, 6579);
                    return return_v;
                }


                int
                f_315_6602_6629(Microsoft.CodeAnalysis.InternalUtilities.ConcurrentLruCache<K, V>
                this_param, K
                key, V
                value, bool
                throwExceptionIfKeyExists)
                {
                    this_param.UnsafeAdd(key, value, throwExceptionIfKeyExists);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(315, 6602, 6629);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(315, 6261, 6710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(315, 6261, 6710);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
