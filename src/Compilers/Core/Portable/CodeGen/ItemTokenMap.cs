// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class ItemTokenMap<T> where T : class
    {
        private readonly ConcurrentDictionary<T, uint> _itemToToken;

        private readonly ArrayBuilder<T> _items;

        public uint GetOrAddTokenFor(T item)
        {
            uint token;
            // NOTE: cannot use GetOrAdd here since items and itemToToken must be in sync
            // so if we do need to add we have to take a lock and modify both collections.
            if (_itemToToken.TryGetValue(item, out token))
            {
                return token;
            }

            return AddItem(item);
        }

        private uint AddItem(T item)
        {
            uint token;

            lock (_items)
            {
                if (_itemToToken.TryGetValue(item, out token))
                {
                    return token;
                }

                token = (uint)_items.Count;
                _items.Add(item);
                _itemToToken.Add(item, token);
            }

            return token;
        }

        public T GetItem(uint token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(61, 2066, 2217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 2125, 2131);
                lock (_items)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 2165, 2191);

                    return _items[(int)token];
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(61, 2066, 2217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(61, 2066, 2217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(61, 2066, 2217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<T> GetAllItems()
        {
            lock (_items)
            {
                return _items.ToArray();
            }
        }

        public ItemTokenMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(61, 900, 2392);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1017, 1101);
            this._itemToToken = f_61_1032_1101(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1145, 1175);
            this._items = f_61_1154_1175(); DynAbs.Tracing.TraceSender.TraceExitConstructor(61, 900, 2392);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(61, 900, 2392);
        }


        static ItemTokenMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(61, 900, 2392);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(61, 900, 2392);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(61, 900, 2392);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(61, 900, 2392);

        System.Collections.Concurrent.ConcurrentDictionary<T, uint>
        f_61_1032_1101(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<T, uint>((System.Collections.Generic.IEqualityComparer<T>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 1032, 1101);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
        f_61_1154_1175()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 1154, 1175);
            return return_v;
        }

    }
}
