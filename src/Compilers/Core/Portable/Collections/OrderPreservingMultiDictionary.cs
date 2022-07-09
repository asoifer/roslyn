// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Collections
{
    internal sealed class OrderPreservingMultiDictionary<K, V> :
            IEnumerable<KeyValuePair<K, OrderPreservingMultiDictionary<K, V>.ValueSet>>
            where K : notnull
            where V : notnull
    {
        private readonly ObjectPool<OrderPreservingMultiDictionary<K, V>>? _pool;

        private OrderPreservingMultiDictionary(ObjectPool<OrderPreservingMultiDictionary<K, V>> pool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(110, 1104, 1246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1086, 1091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 2849, 2860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1222, 1235);

                _pool = pool;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(110, 1104, 1246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 1104, 1246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 1104, 1246);
            }
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 1258, 1697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1301, 1652) || true) && (_dictionary != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 1301, 1652);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1452, 1561);
                        foreach (var kvp in f_110_1472_1483_I(_dictionary))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 1452, 1561);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1525, 1542);

                            kvp.Value.Free();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 1452, 1561);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 110);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 110);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1581, 1600);

                    f_110_1581_1599(
                                    _dictionary);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1618, 1637);

                    _dictionary = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 1301, 1652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1668, 1686);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_pool, 110, 1668, 1685)?.Free(this), 110, 1674, 1685);
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 1258, 1697);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                f_110_1472_1483_I(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 1472, 1483);
                    return return_v;
                }


                int
                f_110_1581_1599(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 1581, 1599);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 1258, 1697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 1258, 1697);
            }
        }

        private static readonly ObjectPool<OrderPreservingMultiDictionary<K, V>> s_poolInstance;

        public static ObjectPool<OrderPreservingMultiDictionary<K, V>> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 1895, 2211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1995, 2154);

                var
                pool = f_110_2006_2153(pool => new OrderPreservingMultiDictionary<K, V>(pool), 16)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 2188, 2200);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 1895, 2211);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>>
                f_110_2006_2153(System.Func<Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>>, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>>
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 2006, 2153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 1895, 2211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 1895, 2211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static OrderPreservingMultiDictionary<K, V> GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 2223, 2439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 2312, 2353);

                var
                instance = f_110_2327_2352(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 2367, 2398);

                f_110_2367_2397(f_110_2380_2396(instance));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 2412, 2428);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 2223, 2439);

                Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>
                f_110_2327_2352(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 2327, 2352);
                    return return_v;
                }


                bool
                f_110_2380_2396(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 2380, 2396);
                    return return_v;
                }


                int
                f_110_2367_2397(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 2367, 2397);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 2223, 2439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 2223, 2439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Dictionary<K, ValueSet> s_emptyDictionary;

        private PooledDictionary<K, ValueSet>? _dictionary;

        public OrderPreservingMultiDictionary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(110, 2873, 2934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1086, 1091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 2849, 2860);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(110, 2873, 2934);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 2873, 2934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 2873, 2934);
            }
        }

        private void EnsureDictionary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 2946, 3073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3002, 3062);

                _dictionary ??= f_110_3018_3061();
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 2946, 3073);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                f_110_3018_3061()
                {
                    var return_v = PooledDictionary<K, ValueSet>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 3018, 3061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 2946, 3073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 2946, 3073);
            }
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 3105, 3127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3108, 3127);
                    return _dictionary == null; DynAbs.Tracing.TraceSender.TraceExitMethod(110, 3105, 3127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 3105, 3127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 3105, 3127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Add a value to the dictionary.
        /// </summary>
        public void Add(K k, V v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 3231, 3818);
                Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet valueSet = default(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3281, 3807) || true) && (_dictionary is object && (DynAbs.Tracing.TraceSender.Expression_True(110, 3285, 3354) && f_110_3310_3354(_dictionary, k, out valueSet)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 3281, 3807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3388, 3422);

                    f_110_3388_3421(valueSet.Count >= 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3607, 3650);

                    _dictionary[k] = valueSet.WithAddedItem(v);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 3281, 3807);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 3281, 3807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3716, 3740);

                    f_110_3716_3739(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3758, 3792);

                    _dictionary![k] = f_110_3776_3791(v);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 3281, 3807);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 3231, 3818);

                bool
                f_110_3310_3354(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                this_param, K
                key, out Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 3310, 3354);
                    return return_v;
                }


                int
                f_110_3388_3421(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 3388, 3421);
                    return 0;
                }


                int
                f_110_3716_3739(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>
                this_param)
                {
                    this_param.EnsureDictionary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 3716, 3739);
                    return 0;
                }


                Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet
                f_110_3776_3791(V
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 3776, 3791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 3231, 3818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 3231, 3818);
            }
        }

        public bool TryGetValue<TArg>(K key, Func<V, TArg, bool> predicate, TArg arg, [MaybeNullWhen(false)] out V value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 3830, 4271);
                Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet valueSet = default(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3968, 4201) || true) && (_dictionary is not null && (DynAbs.Tracing.TraceSender.Expression_True(110, 3972, 4045) && f_110_3999_4045(_dictionary, key, out valueSet)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 3968, 4201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 4079, 4113);

                    f_110_4079_4112(valueSet.Count >= 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 4131, 4186);

                    return valueSet.TryGetValue(predicate, arg, out value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 3968, 4201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 4217, 4233);

                value = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 4247, 4260);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 3830, 4271);

                bool
                f_110_3999_4045(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                this_param, K
                key, out Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 3999, 4045);
                    return return_v;
                }


                int
                f_110_4079_4112(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 4079, 4112);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 3830, 4271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 3830, 4271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Dictionary<K, ValueSet>.Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 4283, 4469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 4365, 4458);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(110, 4372, 4391) || ((_dictionary is null && DynAbs.Tracing.TraceSender.Conditional_F2(110, 4394, 4427)) || DynAbs.Tracing.TraceSender.Conditional_F3(110, 4430, 4457))) ? f_110_4394_4427(s_emptyDictionary) : f_110_4430_4457(_dictionary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 4283, 4469);

                System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>.Enumerator
                f_110_4394_4427(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 4394, 4427);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>.Enumerator
                f_110_4430_4457(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 4430, 4457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 4283, 4469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 4283, 4469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<KeyValuePair<K, ValueSet>> IEnumerable<KeyValuePair<K, ValueSet>>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 4481, 4633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 4599, 4622);

                return f_110_4606_4621(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 4481, 4633);

                System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>.Enumerator
                f_110_4606_4621(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 4606, 4621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 4481, 4633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 4481, 4633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 9511, 9621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9583, 9606);

                return GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 9511, 9621);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 9511, 9621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 9511, 9621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Get all values associated with K, in the order they were added.
        /// Returns empty read-only array if no values were present.
        /// </summary>
        public ImmutableArray<V> this[K k]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 5008, 5322);
                    Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet valueSet = default(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 5044, 5256) || true) && (_dictionary is object && (DynAbs.Tracing.TraceSender.Expression_True(110, 5048, 5117) && f_110_5073_5117(_dictionary, k, out valueSet)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 5044, 5256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 5159, 5193);

                        f_110_5159_5192(valueSet.Count >= 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 5215, 5237);

                        return valueSet.Items;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 5044, 5256);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 5276, 5307);

                    return ImmutableArray<V>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 5008, 5322);

                    bool
                    f_110_5073_5117(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                    this_param, K
                    key, out Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 5073, 5117);
                        return return_v;
                    }


                    int
                    f_110_5159_5192(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 5159, 5192);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 5008, 5322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 5008, 5322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(K key, V value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 5345, 5558);
                Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet valueSet = default(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 5406, 5547);

                return _dictionary is object && (DynAbs.Tracing.TraceSender.Expression_True(110, 5413, 5501) && f_110_5455_5501(_dictionary, key, out valueSet)) && (DynAbs.Tracing.TraceSender.Expression_True(110, 5413, 5546) && valueSet.Contains(value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(110, 5345, 5558);

                bool
                f_110_5455_5501(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                this_param, K
                key, out Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 5455, 5501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 5345, 5558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 5345, 5558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Dictionary<K, ValueSet>.KeyCollection Keys
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 5738, 5817);
                    Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet valueSet = default(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 5744, 5815);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(110, 5751, 5770) || ((_dictionary is null && DynAbs.Tracing.TraceSender.Conditional_F2(110, 5773, 5795)) || DynAbs.Tracing.TraceSender.Conditional_F3(110, 5798, 5814))) ? f_110_5773_5795(s_emptyDictionary) : f_110_5798_5814(_dictionary);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 5738, 5817);

                    System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>.KeyCollection
                    f_110_5773_5795(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 5773, 5795);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>.KeyCollection
                    f_110_5798_5814(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 5798, 5814);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 5664, 5828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 5664, 5828);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public struct ValueSet : IEnumerable<V>
        {

            private readonly object _value;

            internal ValueSet(V value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(110, 6121, 6210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6180, 6195);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(110, 6121, 6210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 6121, 6210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 6121, 6210);
                }
            }

            internal ValueSet(ArrayBuilder<V> values)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(110, 6226, 6331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6300, 6316);

                    _value = values;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(110, 6226, 6331);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 6226, 6331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 6226, 6331);
                }
            }

            internal void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 6347, 6499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6400, 6445);

                    var
                    arrayBuilder = _value as ArrayBuilder<V>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6463, 6484);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(arrayBuilder, 110, 6463, 6483)?.Free(), 110, 6476, 6483);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 6347, 6499);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 6347, 6499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 6347, 6499);
                }
            }

            internal V this[int index]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 6574, 7247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6618, 6648);

                        f_110_6618_6647(this.Count >= 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6672, 6717);

                        var
                        arrayBuilder = _value as ArrayBuilder<V>
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6739, 7228) || true) && (arrayBuilder == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 6739, 7228);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6813, 7080) || true) && (index == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 6813, 7080);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6885, 6902);

                                return (V)_value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 6813, 7080);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 6813, 7080);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7016, 7053);

                                throw f_110_7022_7052();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 6813, 7080);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 6739, 7228);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 6739, 7228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7178, 7205);

                            return f_110_7185_7204(arrayBuilder, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 6739, 7228);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(110, 6574, 7247);

                        int
                        f_110_6618_6647(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 6618, 6647);
                            return 0;
                        }


                        System.IndexOutOfRangeException
                        f_110_7022_7052()
                        {
                            var return_v = new System.IndexOutOfRangeException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 7022, 7052);
                            return return_v;
                        }


                        V
                        f_110_7185_7204(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 7185, 7204);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 6574, 7247);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 6574, 7247);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool TryGetValue<TArg>(Func<V, TArg, bool> predicate, TArg arg, [MaybeNullWhen(false)] out V value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 7278, 8254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7417, 7447);

                    f_110_7417_7446(this.Count >= 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7465, 7510);

                    var
                    arrayBuilder = _value as ArrayBuilder<V>
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7528, 8172) || true) && (arrayBuilder is not null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 7528, 8172);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7598, 7859);
                            foreach (var v in f_110_7616_7628_I(arrayBuilder))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 7598, 7859);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7678, 7836) || true) && (f_110_7682_7699(predicate, v, arg))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 7678, 7836);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7757, 7767);

                                    value = v;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7797, 7809);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 7678, 7836);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 7598, 7859);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 262);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 262);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 7528, 8172);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 7528, 8172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7941, 7969);

                        var
                        singleValue = (V)_value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 7991, 8153) || true) && (f_110_7995_8022(predicate, singleValue, arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 7991, 8153);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8072, 8092);

                            value = singleValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8118, 8130);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 7991, 8153);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 7528, 8172);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8192, 8208);

                    value = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8226, 8239);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 7278, 8254);

                    int
                    f_110_7417_7446(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 7417, 7446);
                        return 0;
                    }


                    bool
                    f_110_7682_7699(System.Func<V, TArg, bool>
                    this_param, V
                    arg1, TArg?
                    arg2)
                    {
                        var return_v = this_param.Invoke(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 7682, 7699);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    f_110_7616_7628_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 7616, 7628);
                        return return_v;
                    }


                    bool
                    f_110_7995_8022(System.Func<V, TArg, bool>
                    this_param, V
                    arg1, TArg?
                    arg2)
                    {
                        var return_v = this_param.Invoke(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 7995, 8022);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 7278, 8254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 7278, 8254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool Contains(V item)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 8270, 8613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8333, 8363);

                    f_110_8333_8362(this.Count >= 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8381, 8426);

                    var
                    arrayBuilder = _value as ArrayBuilder<V>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8444, 8598);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(110, 8451, 8471) || ((arrayBuilder == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(110, 8495, 8546)) || DynAbs.Tracing.TraceSender.Conditional_F3(110, 8570, 8597))) ? f_110_8495_8546(f_110_8495_8522(), item, _value) : f_110_8570_8597(arrayBuilder, item);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 8270, 8613);

                    int
                    f_110_8333_8362(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 8333, 8362);
                        return 0;
                    }


                    System.Collections.Generic.EqualityComparer<V>
                    f_110_8495_8522()
                    {
                        var return_v = EqualityComparer<V>.Default;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 8495, 8522);
                        return return_v;
                    }


                    bool
                    f_110_8495_8546(System.Collections.Generic.EqualityComparer<V>
                    this_param, V
                    x, object
                    y)
                    {
                        var return_v = this_param.Equals(x, (V)y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 8495, 8546);
                        return return_v;
                    }


                    bool
                    f_110_8570_8597(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    this_param, V
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 8570, 8597);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 8270, 8613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 8270, 8613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ImmutableArray<V> Items
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 8694, 9277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8738, 8768);

                        f_110_8738_8767(this.Count >= 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8792, 8837);

                        var
                        arrayBuilder = _value as ArrayBuilder<V>
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8859, 9258) || true) && (arrayBuilder == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 8859, 9258);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 8986, 9034);

                            f_110_8986_9033(_value is V, "Item must be a a V");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9060, 9103);

                            return f_110_9067_9102(_value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 8859, 9258);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 8859, 9258);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9201, 9235);

                            return f_110_9208_9234(arrayBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 8859, 9258);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(110, 8694, 9277);

                        int
                        f_110_8738_8767(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 8738, 8767);
                            return 0;
                        }


                        int
                        f_110_8986_9033(bool
                        condition, string
                        message)
                        {
                            Debug.Assert(condition, message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 8986, 9033);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<V>
                        f_110_9067_9102(object
                        item)
                        {
                            var return_v = ImmutableArray.Create<V>((V)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 9067, 9102);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<V>
                        f_110_9208_9234(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 9208, 9234);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 8629, 9292);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 8629, 9292);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal int Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 9428, 9494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9431, 9494);
                        return (DynAbs.Tracing.TraceSender.Conditional_F1(110, 9431, 9456) || ((_value is ArrayBuilder<V> && DynAbs.Tracing.TraceSender.Conditional_F2(110, 9459, 9490)) || DynAbs.Tracing.TraceSender.Conditional_F3(110, 9493, 9494))) ? f_110_9459_9490(((ArrayBuilder<V>)_value)) : 1; DynAbs.Tracing.TraceSender.TraceExitMethod(110, 9428, 9494);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 9428, 9494);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 9428, 9494);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 9511, 9621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9583, 9606);

                    return GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 9511, 9621);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 9511, 9621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 9511, 9621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator<V> IEnumerable<V>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 9637, 9753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9715, 9738);

                    return GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 9637, 9753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 9637, 9753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 9637, 9753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Enumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 9769, 9878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9835, 9863);

                    return f_110_9842_9862(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 9769, 9878);

                    Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet.Enumerator
                    f_110_9842_9862(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet
                    valueSet)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet.Enumerator(valueSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 9842, 9862);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 9769, 9878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 9769, 9878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ValueSet WithAddedItem(V item)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 9894, 11027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 9966, 9996);

                    f_110_9966_9995(this.Count >= 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10016, 10061);

                    var
                    arrayBuilder = _value as ArrayBuilder<V>
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10079, 10958) || true) && (arrayBuilder == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 10079, 10958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10214, 10262);

                        f_110_10214_10261(_value is V, "_value must be a V");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10683, 10739);

                        arrayBuilder = f_110_10698_10738(capacity: 2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10761, 10789);

                        f_110_10761_10788(arrayBuilder, _value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10811, 10834);

                        f_110_10811_10833(arrayBuilder, item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 10079, 10958);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 10079, 10958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10916, 10939);

                        f_110_10916_10938(arrayBuilder, item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 10079, 10958);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 10978, 11012);

                    return f_110_10985_11011(arrayBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 9894, 11027);

                    int
                    f_110_9966_9995(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 9966, 9995);
                        return 0;
                    }


                    int
                    f_110_10214_10261(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 10214, 10261);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    f_110_10698_10738(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<V>.GetInstance(capacity: capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 10698, 10738);
                        return return_v;
                    }


                    int
                    f_110_10761_10788(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    this_param, object
                    item)
                    {
                        this_param.Add((V)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 10761, 10788);
                        return 0;
                    }


                    int
                    f_110_10811_10833(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    this_param, V
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 10811, 10833);
                        return 0;
                    }


                    int
                    f_110_10916_10938(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    this_param, V
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 10916, 10938);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet
                    f_110_10985_11011(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
                    values)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet(values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 10985, 11011);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 9894, 11027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 9894, 11027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public struct Enumerator : IEnumerator<V>
            {

                private readonly ValueSet _valueSet;

                private readonly int _count;

                private int _index;

                public Enumerator(ValueSet valueSet)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(110, 11256, 11502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11333, 11354);

                        _valueSet = valueSet;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11376, 11401);

                        _count = _valueSet.Count;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11423, 11449);

                        f_110_11423_11448(_count >= 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11471, 11483);

                        _index = -1;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(110, 11256, 11502);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 11256, 11502);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 11256, 11502);
                    }
                }

                public V Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 11539, 11559);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11542, 11559);
                            return _valueSet[_index]; DynAbs.Tracing.TraceSender.TraceExitMethod(110, 11539, 11559);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 11539, 11559);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 11539, 11559);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                object IEnumerator.Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 11607, 11617);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11610, 11617);
                            return Current; DynAbs.Tracing.TraceSender.TraceExitMethod(110, 11607, 11617);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 11607, 11617);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 11607, 11617);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 11638, 11774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11701, 11710);

                        _index++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11732, 11755);

                        return _index < _count;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(110, 11638, 11774);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 11638, 11774);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 11638, 11774);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 11794, 11885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 11854, 11866);

                        _index = -1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(110, 11794, 11885);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 11794, 11885);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 11794, 11885);
                    }
                }

                public void Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 11905, 11964);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(110, 11905, 11964);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 11905, 11964);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 11905, 11964);
                    }
                }
                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 11043, 11979);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 11043, 11979);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 11043, 11979);
                }

                static int
                f_110_11423_11448(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 11423, 11448);
                    return 0;
                }

            }
            static ValueSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 5840, 11990);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 5840, 11990);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 5840, 11990);
            }

            int
            f_110_9459_9490(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<V>
            this_param)
            {
                var return_v = this_param.Count;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 9459, 9490);
                return return_v;
            }

        }

        static OrderPreservingMultiDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 776, 11997);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 1806, 1835);
            s_poolInstance = f_110_1823_1835(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 2689, 2714);
            s_emptyDictionary = f_110_2709_2714<K>();

            static System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>
                f_110_2709_2714<K>()
            {
                var return_v = new System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>.ValueSet>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 2709, 2714);
                return return_v;
            }

            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 776, 11997);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 776, 11997);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(110, 776, 11997);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<K, V>>
        f_110_1823_1835()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 1823, 1835);
            return return_v;
        }

    }
}
