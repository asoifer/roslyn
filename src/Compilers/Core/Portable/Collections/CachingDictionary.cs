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
            foreach (var kvp in this.EnsureFullyPopulated())
            {
                array.AddRange(kvp.Value);
            }
        }

        /// <summary>
        /// Create an instance of the concurrent dictionary.
        /// </summary>
        /// <returns>The concurrent dictionary</returns>
        private ConcurrentDictionary<TKey, ImmutableArray<TElement>> CreateConcurrentDictionary()
        {
            return new ConcurrentDictionary<TKey, ImmutableArray<TElement>>(concurrencyLevel: 2, capacity: 0, comparer: _comparer);
        }

        /// <summary>
        /// Create a dictionary instance suitable for use as the fully populated map.
        /// </summary>
        /// <returns>A new, empty dictionary, suitable for use as the fully populated map.</returns>
        private IDictionary<TKey, ImmutableArray<TElement>> CreateDictionaryForFullyPopulatedMap(int capacity)
        {
            // CONSIDER: If capacity is small, consider using a more frugal data structure.
            return new Dictionary<TKey, ImmutableArray<TElement>>(capacity, _comparer);
        }

        /// <summary>
        /// Use the underlying (possibly slow) functions to get the values associated with a key.
        /// </summary>
        private ImmutableArray<TElement> GetOrCreateValue(TKey key)
        {
            ImmutableArray<TElement> elements;
            ConcurrentDictionary<TKey, ImmutableArray<TElement>>? concurrentMap;

            // Check if we're fully populated before trying to retrieve the elements.  If we are
            // and we don't get any elements back, then we don't have to go any further.
            var localMap = _map;

            if (localMap == null)
            {
                concurrentMap = CreateConcurrentDictionary();
                localMap = Interlocked.CompareExchange(ref _map, concurrentMap, null);
                if (localMap == null)
                {
                    return AddToConcurrentMap(concurrentMap, key);
                }
                // Some other thread beat us to the initial population
            }

            // first check to see if they are already cached
            if (localMap.TryGetValue(key, out elements))
            {
                return elements;
            }

            // How we proceed depends on whether we're fully populated.
            concurrentMap = localMap as ConcurrentDictionary<TKey, ImmutableArray<TElement>>;

            // If we're fully populated, the value wasn't found. Otherwise, lookup the new value and add it to the concurrent map.
            return concurrentMap == null ? s_emptySentinel : AddToConcurrentMap(concurrentMap, key);
        }

        /// <summary>
        /// Add a new value with the given key to the given concurrent map.
        /// </summary>
        /// <param name="map">The concurrent map to augment.</param>
        /// <param name="key">The key of the new entry.</param>
        /// <returns>The added entry. If there was a race, and another thread beat this one, then this returns the previously added entry.</returns>
        private ImmutableArray<TElement> AddToConcurrentMap(ConcurrentDictionary<TKey, ImmutableArray<TElement>> map, TKey key)
        {
            var elements = _getElementsOfKey(key);

            if (elements.IsDefaultOrEmpty)
            {
                // In this case, we're not fully populated, so remember that this was a failed
                // lookup.
                elements = s_emptySentinel;
            }

            return map.GetOrAdd(key, elements);
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
            Debug.Assert(IsNotFullyPopulatedMap(existingMap));

            // Enumerate all the keys and attempt to generate values for all of them.
            var allKeys = _getKeys(_comparer);
            Debug.Assert(_comparer == allKeys.Comparer);

            var fullyPopulatedMap = CreateDictionaryForFullyPopulatedMap(capacity: allKeys.Count);
            if (existingMap == null)
            {
                // The concurrent map has never been created.
                foreach (var key in allKeys)
                {
                    fullyPopulatedMap.Add(key, _getElementsOfKey(key));
                }
            }
            else
            {
                foreach (var key in allKeys)
                {
                    // Copy non-empty values from the existing map
                    ImmutableArray<TElement> elements;

                    if (!existingMap.TryGetValue(key, out elements))
                    {
                        elements = _getElementsOfKey(key);
                    }

                    Debug.Assert(elements != s_emptySentinel);
                    fullyPopulatedMap.Add(key, elements);
                }
            }

            return fullyPopulatedMap;
        }

        /// <summary>
        /// Fully populate the underlying dictionary. Once this returns, the dictionary is guaranteed 
        /// to have every key in it.
        /// </summary>
        private IDictionary<TKey, ImmutableArray<TElement>> EnsureFullyPopulated()
        {
            IDictionary<TKey, ImmutableArray<TElement>>? fullyPopulatedMap = null;

            var currentMap = _map;
            while (IsNotFullyPopulatedMap(currentMap))
            {
                if (fullyPopulatedMap == null)
                {
                    fullyPopulatedMap = CreateFullyPopulatedMap(currentMap);
                }

                var replacedMap = Interlocked.CompareExchange(ref _map, fullyPopulatedMap, currentMap);
                if (replacedMap == currentMap)
                {
                    // Normal exit.
                    return fullyPopulatedMap;
                }

                // Another thread either initialized a new ConcurrentMap or a fully-populated map.
                currentMap = replacedMap;
            }

            // The map is already fully populated
            return currentMap;
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
