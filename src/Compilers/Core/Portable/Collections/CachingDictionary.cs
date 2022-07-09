// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Collections
{
    internal class CachingDictionary<TKey, TElement>
            where TKey : notnull
    {
        private readonly Func<TKey, ImmutableArray<TElement>> _getElementsOfKey;

        private readonly Func<IEqualityComparer<TKey>, HashSet<TKey>> _getKeys;

        private readonly IEqualityComparer<TKey> _comparer;

        private IDictionary<TKey, ImmutableArray<TElement>>? _map;

        private static readonly ImmutableArray<TElement> s_emptySentinel;

        public CachingDictionary(
                    Func<TKey, ImmutableArray<TElement>> getElementsOfKey,
                    Func<IEqualityComparer<TKey>, HashSet<TKey>> getKeys,
                    IEqualityComparer<TKey> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(96, 2964, 3312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 1509, 1526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 1599, 1607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 1659, 1668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 2145, 2149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 3196, 3233);

                _getElementsOfKey = getElementsOfKey;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 3247, 3266);

                _getKeys = getKeys;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 3280, 3301);

                _comparer = comparer;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(96, 2964, 3312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 2964, 3312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 2964, 3312);
            }
        }

        public bool Contains(TKey key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 3434, 3529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 3489, 3518);

                return this[key].Length != 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 3434, 3529);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 3434, 3529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 3434, 3529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Get the values associated with a key. 
        /// </summary>
        /// <param name="key">Key to look up.</param>
        /// <returns>All values associated with key. Returns an empty IEnumerable if
        /// no values are associated. Never returns null.</returns>
        public ImmutableArray<TElement> this[TKey key]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 3921, 4006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 3957, 3991);

                    return f_96_3964_3990(this, key);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(96, 3921, 4006);

                    System.Collections.Immutable.ImmutableArray<TElement>
                    f_96_3964_3990(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                    this_param, TKey
                    key)
                    {
                        var return_v = this_param.GetOrCreateValue(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 3964, 3990);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 3921, 4006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 3921, 4006);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 4215, 4307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 4251, 4292);

                    return f_96_4258_4291(f_96_4258_4285(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(96, 4215, 4307);

                    System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                    f_96_4258_4285(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                    this_param)
                    {
                        var return_v = this_param.EnsureFullyPopulated();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 4258, 4285);
                        return return_v;
                    }


                    int
                    f_96_4258_4291(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(96, 4258, 4291);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 4174, 4318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 4174, 4318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 4520, 4611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 4556, 4596);

                    return f_96_4563_4595(f_96_4563_4590(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(96, 4520, 4611);

                    System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                    f_96_4563_4590(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                    this_param)
                    {
                        var return_v = this_param.EnsureFullyPopulated();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 4563, 4590);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<TKey>
                    f_96_4563_4595(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(96, 4563, 4595);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 4466, 4622);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 4466, 4622);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Add the values from all keys to a flat array.
        /// Forces a full population of the cache.
        /// </summary>
        /// <param name="array"></param>
        public void AddValues(ArrayBuilder<TElement> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 4834, 5043);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 4910, 5032);
                    foreach (var kvp in f_96_4930_4957_I(f_96_4930_4957(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 4910, 5032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 4991, 5017);

                        f_96_4991_5016(array, kvp.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(96, 4910, 5032);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(96, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(96, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 4834, 5043);

                System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                f_96_4930_4957(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param)
                {
                    var return_v = this_param.EnsureFullyPopulated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 4930, 4957);
                    return return_v;
                }


                int
                f_96_4991_5016(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TElement>
                this_param, System.Collections.Immutable.ImmutableArray<TElement>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 4991, 5016);
                    return 0;
                }


                System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                f_96_4930_4957_I(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 4930, 4957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 4834, 5043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 4834, 5043);
            }
        }

        /// <summary>
        /// Create an instance of the concurrent dictionary.
        /// </summary>
        /// <returns>The concurrent dictionary</returns>
        private ConcurrentDictionary<TKey, ImmutableArray<TElement>> CreateConcurrentDictionary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 5222, 5466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 5336, 5455);

                return f_96_5343_5454(concurrencyLevel: 2, capacity: 0, comparer: _comparer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 5222, 5466);

                System.Collections.Concurrent.ConcurrentDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                f_96_5343_5454(int
                concurrencyLevel, int
                capacity, System.Collections.Generic.IEqualityComparer<TKey>
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>(concurrencyLevel: concurrencyLevel, capacity: capacity, comparer: comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 5343, 5454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 5222, 5466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 5222, 5466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Create a dictionary instance suitable for use as the fully populated map.
        /// </summary>
        /// <returns>A new, empty dictionary, suitable for use as the fully populated map.</returns>
        private IDictionary<TKey, ImmutableArray<TElement>> CreateDictionaryForFullyPopulatedMap(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 5714, 6020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 5934, 6009);

                return f_96_5941_6008(capacity, _comparer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 5714, 6020);

                System.Collections.Generic.Dictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                f_96_5941_6008(int
                capacity, System.Collections.Generic.IEqualityComparer<TKey>
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>(capacity, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 5941, 6008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 5714, 6020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 5714, 6020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Use the underlying (possibly slow) functions to get the values associated with a key.
        /// </summary>
        private ImmutableArray<TElement> GetOrCreateValue(TKey key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 6178, 7640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6262, 6296);

                ImmutableArray<TElement>
                elements
                = default(ImmutableArray<TElement>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6310, 6378);

                ConcurrentDictionary<TKey, ImmutableArray<TElement>>?
                concurrentMap
                = default(ConcurrentDictionary<TKey, ImmutableArray<TElement>>?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6582, 6602);

                var
                localMap = _map
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6618, 7037) || true) && (localMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 6618, 7037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6672, 6717);

                    concurrentMap = f_96_6688_6716(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6735, 6805);

                    localMap = f_96_6746_6804(ref _map, concurrentMap, null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6823, 6950) || true) && (localMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 6823, 6950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 6885, 6931);

                        return f_96_6892_6930(this, concurrentMap, key);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(96, 6823, 6950);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(96, 6618, 7037);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 7115, 7223) || true) && (f_96_7119_7158(localMap, key, out elements))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 7115, 7223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 7192, 7208);

                    return elements;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(96, 7115, 7223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 7312, 7393);

                concurrentMap = localMap as ConcurrentDictionary<TKey, ImmutableArray<TElement>>;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 7541, 7629);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(96, 7548, 7569) || ((concurrentMap == null && DynAbs.Tracing.TraceSender.Conditional_F2(96, 7572, 7587)) || DynAbs.Tracing.TraceSender.Conditional_F3(96, 7590, 7628))) ? s_emptySentinel : f_96_7590_7628(this, concurrentMap, key);
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 6178, 7640);

                System.Collections.Concurrent.ConcurrentDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                f_96_6688_6716(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param)
                {
                    var return_v = this_param.CreateConcurrentDictionary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 6688, 6716);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                f_96_6746_6804(ref System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                location1, System.Collections.Concurrent.ConcurrentDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                value, System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 6746, 6804);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TElement>
                f_96_6892_6930(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, System.Collections.Concurrent.ConcurrentDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                map, TKey
                key)
                {
                    var return_v = this_param.AddToConcurrentMap(map, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 6892, 6930);
                    return return_v;
                }


                bool
                f_96_7119_7158(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                this_param, TKey
                key, out System.Collections.Immutable.ImmutableArray<TElement>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 7119, 7158);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TElement>
                f_96_7590_7628(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, System.Collections.Concurrent.ConcurrentDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                map, TKey
                key)
                {
                    var return_v = this_param.AddToConcurrentMap(map, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 7590, 7628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 6178, 7640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 6178, 7640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Add a new value with the given key to the given concurrent map.
        /// </summary>
        /// <param name="map">The concurrent map to augment.</param>
        /// <param name="key">The key of the new entry.</param>
        /// <returns>The added entry. If there was a race, and another thread beat this one, then this returns the previously added entry.</returns>
        private ImmutableArray<TElement> AddToConcurrentMap(ConcurrentDictionary<TKey, ImmutableArray<TElement>> map, TKey key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 8061, 8550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 8205, 8243);

                var
                elements = f_96_8220_8242(this, key)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 8259, 8488) || true) && (elements.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 8259, 8488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 8446, 8473);

                    elements = s_emptySentinel;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(96, 8259, 8488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 8504, 8539);

                return f_96_8511_8538(map, key, elements);
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 8061, 8550);

                System.Collections.Immutable.ImmutableArray<TElement>
                f_96_8220_8242(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, TKey
                arg)
                {
                    var return_v = this_param._getElementsOfKey(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 8220, 8242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TElement>
                f_96_8511_8538(System.Collections.Concurrent.ConcurrentDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                this_param, TKey
                key, System.Collections.Immutable.ImmutableArray<TElement>
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 8511, 8538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 8061, 8550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 8061, 8550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNotFullyPopulatedMap([NotNullWhen(returnValue: false)] IDictionary<TKey, ImmutableArray<TElement>>? existingMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(96, 8802, 9070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 8961, 9059);

                return existingMap == null || (DynAbs.Tracing.TraceSender.Expression_False(96, 8968, 9058) || existingMap is ConcurrentDictionary<TKey, ImmutableArray<TElement>>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(96, 8802, 9070);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 8802, 9070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 8802, 9070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Create the fully populated map from an existing map and the key generator.
        /// </summary>
        /// <param name="existingMap">The existing map which may be null or a ConcurrentDictionary.</param>
        /// <returns></returns>
        private IDictionary<TKey, ImmutableArray<TElement>> CreateFullyPopulatedMap(IDictionary<TKey, ImmutableArray<TElement>>? existingMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 9359, 10763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 9517, 9567);

                f_96_9517_9566(f_96_9530_9565(existingMap));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 9670, 9704);

                var
                allKeys = f_96_9684_9703(this, _comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 9718, 9762);

                f_96_9718_9761(_comparer == f_96_9744_9760(allKeys));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 9778, 9864);

                var
                fullyPopulatedMap = f_96_9802_9863(this, capacity: f_96_9849_9862(allKeys))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 9878, 10711) || true) && (existingMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 9878, 10711);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 9998, 10137);
                        foreach (var key in f_96_10018_10025_I(allKeys))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 9998, 10137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10067, 10118);

                            f_96_10067_10117(fullyPopulatedMap, key, f_96_10094_10116(this, key));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(96, 9998, 10137);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(96, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(96, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(96, 9878, 10711);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 9878, 10711);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10203, 10696);
                        foreach (var key in f_96_10223_10230_I(allKeys))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 10203, 10696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10340, 10374);

                            ImmutableArray<TElement>
                            elements
                            = default(ImmutableArray<TElement>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10398, 10552) || true) && (!f_96_10403_10445(existingMap, key, out elements))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 10398, 10552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10495, 10529);

                                elements = f_96_10506_10528(this, key);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(96, 10398, 10552);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10576, 10618);

                            f_96_10576_10617(elements != s_emptySentinel);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10640, 10677);

                            f_96_10640_10676(fullyPopulatedMap, key, elements);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(96, 10203, 10696);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(96, 1, 494);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(96, 1, 494);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(96, 9878, 10711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 10727, 10752);

                return fullyPopulatedMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 9359, 10763);

                bool
                f_96_9530_9565(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                existingMap)
                {
                    var return_v = IsNotFullyPopulatedMap(existingMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 9530, 9565);
                    return return_v;
                }


                int
                f_96_9517_9566(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 9517, 9566);
                    return 0;
                }


                System.Collections.Generic.HashSet<TKey>
                f_96_9684_9703(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, System.Collections.Generic.IEqualityComparer<TKey>
                arg)
                {
                    var return_v = this_param._getKeys(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 9684, 9703);
                    return return_v;
                }


                System.Collections.Generic.IEqualityComparer<TKey>
                f_96_9744_9760(System.Collections.Generic.HashSet<TKey>
                this_param)
                {
                    var return_v = this_param.Comparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(96, 9744, 9760);
                    return return_v;
                }


                int
                f_96_9718_9761(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 9718, 9761);
                    return 0;
                }


                int
                f_96_9849_9862(System.Collections.Generic.HashSet<TKey>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(96, 9849, 9862);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                f_96_9802_9863(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, int
                capacity)
                {
                    var return_v = this_param.CreateDictionaryForFullyPopulatedMap(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 9802, 9863);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TElement>
                f_96_10094_10116(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, TKey
                arg)
                {
                    var return_v = this_param._getElementsOfKey(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10094, 10116);
                    return return_v;
                }


                int
                f_96_10067_10117(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                this_param, TKey
                key, System.Collections.Immutable.ImmutableArray<TElement>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10067, 10117);
                    return 0;
                }


                System.Collections.Generic.HashSet<TKey>
                f_96_10018_10025_I(System.Collections.Generic.HashSet<TKey>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10018, 10025);
                    return return_v;
                }


                bool
                f_96_10403_10445(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                this_param, TKey
                key, out System.Collections.Immutable.ImmutableArray<TElement>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10403, 10445);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TElement>
                f_96_10506_10528(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, TKey
                arg)
                {
                    var return_v = this_param._getElementsOfKey(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10506, 10528);
                    return return_v;
                }


                int
                f_96_10576_10617(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10576, 10617);
                    return 0;
                }


                int
                f_96_10640_10676(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                this_param, TKey
                key, System.Collections.Immutable.ImmutableArray<TElement>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10640, 10676);
                    return 0;
                }


                System.Collections.Generic.HashSet<TKey>
                f_96_10223_10230_I(System.Collections.Generic.HashSet<TKey>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 10223, 10230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 9359, 10763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 9359, 10763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Fully populate the underlying dictionary. Once this returns, the dictionary is guaranteed 
        /// to have every key in it.
        /// </summary>
        private IDictionary<TKey, ImmutableArray<TElement>> EnsureFullyPopulated()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(96, 10964, 11939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11063, 11133);

                IDictionary<TKey, ImmutableArray<TElement>>?
                fullyPopulatedMap = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11149, 11171);

                var
                currentMap = _map
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11185, 11843) || true) && (f_96_11192_11226(currentMap))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 11185, 11843);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11260, 11406) || true) && (fullyPopulatedMap == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 11260, 11406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11331, 11387);

                            fullyPopulatedMap = f_96_11351_11386(this, currentMap);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(96, 11260, 11406);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11426, 11513);

                        var
                        replacedMap = f_96_11444_11512(ref _map, fullyPopulatedMap, currentMap)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11531, 11683) || true) && (replacedMap == currentMap)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(96, 11531, 11683);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11639, 11664);

                            return fullyPopulatedMap;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(96, 11531, 11683);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11803, 11828);

                        currentMap = replacedMap;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(96, 11185, 11843);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(96, 11185, 11843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(96, 11185, 11843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 11910, 11928);

                return currentMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(96, 10964, 11939);

                bool
                f_96_11192_11226(System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                existingMap)
                {
                    var return_v = IsNotFullyPopulatedMap(existingMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 11192, 11226);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                f_96_11351_11386(Microsoft.CodeAnalysis.Collections.CachingDictionary<TKey, TElement>
                this_param, System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                existingMap)
                {
                    var return_v = this_param.CreateFullyPopulatedMap(existingMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 11351, 11386);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                f_96_11444_11512(ref System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                location1, System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>
                value, System.Collections.Generic.IDictionary<TKey, System.Collections.Immutable.ImmutableArray<TElement>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(96, 11444, 11512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(96, 10964, 11939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 10964, 11939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CachingDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(96, 1360, 11946);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(96, 2351, 2399);
            s_emptySentinel = ImmutableArray<TElement>.Empty; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(96, 1360, 11946);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(96, 1360, 11946);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(96, 1360, 11946);
    }
}
