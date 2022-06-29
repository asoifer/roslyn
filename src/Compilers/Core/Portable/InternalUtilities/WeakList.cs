// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Roslyn.Utilities
{
    internal sealed class WeakList<T> : IEnumerable<T>
            where T : class
    {
        private WeakReference<T>[] _items;

        private int _size;

        public WeakList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(396, 587, 681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 540, 546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 569, 574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 629, 670);

                _items = f_396_638_669();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(396, 587, 681);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 587, 681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 587, 681);
            }
        }

        private void Resize()
        {
            Debug.Assert(_size == _items.Length);
            Debug.Assert(_items.Length == 0 || _items.Length >= MinimalNonEmptySize);

            int alive = _items.Length;
            int firstDead = -1;
            for (int i = 0; i < _items.Length; i++)
            {
                if (!_items[i].TryGetTarget(out _))
                {
                    if (firstDead == -1)
                    {
                        firstDead = i;
                    }

                    alive--;
                }
            }

            if (alive < _items.Length / 4)
            {
                // If we have just a few items left we shrink the array.
                // We avoid expanding the array until the number of new items added exceeds half of its capacity.
                Shrink(firstDead, alive);
            }
            else if (alive >= 3 * _items.Length / 4)
            {
                // If we have a lot of items alive we expand the array since just compacting them 
                // wouldn't free up much space (we would end up calling Resize again after adding a few more items).
                var newItems = new WeakReference<T>[GetExpandedSize(_items.Length)];

                if (firstDead >= 0)
                {
                    Compact(firstDead, newItems);
                }
                else
                {
                    Array.Copy(_items, 0, newItems, 0, _items.Length);
                    Debug.Assert(_size == _items.Length);
                }

                _items = newItems;
            }
            else
            {
                // Compact in-place to make space for new items at the end.
                // We will free up to length/4 slots in the array.
                Compact(firstDead, _items);
            }

            Debug.Assert(_items.Length > 0 && _size < 3 * _items.Length / 4, "length: " + _items.Length + " size: " + _size);
        }

        private void Shrink(int firstDead, int alive)
        {
            int newSize = GetExpandedSize(alive);
            var newItems = (newSize == _items.Length) ? _items : new WeakReference<T>[newSize];
            Compact(firstDead, newItems);
            _items = newItems;
        }

        private const int
        MinimalNonEmptySize = 4
        ;

        private static int GetExpandedSize(int baseSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(396, 3071, 3212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3144, 3201);

                return f_396_3151_3200((baseSize * 2) + 1, MinimalNonEmptySize);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(396, 3071, 3212);

                int
                f_396_3151_3200(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 3151, 3200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 3071, 3212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 3071, 3212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Copies all live references from <see cref="_items"/> to <paramref name="result"/>.
        /// Assumes that all references prior <paramref name="firstDead"/> are alive.
        /// </summary>
        private void Compact(int firstDead, WeakReference<T>[] result)
        {
            Debug.Assert(_items[firstDead].IsNull());

            if (!ReferenceEquals(_items, result))
            {
                Array.Copy(_items, 0, result, 0, firstDead);
            }

            int oldSize = _size;
            int j = firstDead;
            for (int i = firstDead + 1; i < oldSize; i++)
            {
                var item = _items[i];

                if (item.TryGetTarget(out _))
                {
                    result[j++] = item;
                }
            }

            _size = j;

            // free WeakReferences
            if (ReferenceEquals(_items, result))
            {
                while (j < oldSize)
                {
                    _items[j++] = null!;
                }
            }
        }

        public int WeakCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 4570, 4591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4576, 4589);

                    return _size;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(396, 4570, 4591);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 4525, 4602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 4525, 4602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public WeakReference<T> GetWeakReference(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 4614, 4871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4690, 4823) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(396, 4694, 4721) || index >= _size))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 4690, 4823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4755, 4808);

                    throw f_396_4761_4807(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 4690, 4823);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4839, 4860);

                return _items[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 4614, 4871);

                System.ArgumentOutOfRangeException
                f_396_4761_4807(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 4761, 4807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 4614, 4871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 4614, 4871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                Resize();
            }

            Debug.Assert(_size < _items.Length);
            _items[_size++] = new WeakReference<T>(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            int count = _size;
            int alive = _size;
            int firstDead = -1;

            for (int i = 0; i < count; i++)
            {
                T? item;
                if (_items[i].TryGetTarget(out item))
                {
                    yield return item;
                }
                else
                {
                    // object has been collected 

                    if (firstDead < 0)
                    {
                        firstDead = i;
                    }

                    alive--;
                }
            }

            if (alive == 0)
            {
                _items = Array.Empty<WeakReference<T>>();
                _size = 0;
            }
            else if (alive < _items.Length / 4)
            {
                // If we have just a few items left we shrink the array.
                Shrink(firstDead, alive);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        internal WeakReference<T>[] TestOnly_UnderlyingArray
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 6371, 6393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 6377, 6391);

                    return _items;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(396, 6371, 6393);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 6316, 6395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 6316, 6395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WeakList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(396, 421, 6402);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3035, 3058);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(396, 421, 6402);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 421, 6402);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(396, 421, 6402);

        static System.WeakReference<T>[]
        f_396_638_669()
        {
            var return_v = Array.Empty<WeakReference<T>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 638, 669);
            return return_v;
        }

    }
}
