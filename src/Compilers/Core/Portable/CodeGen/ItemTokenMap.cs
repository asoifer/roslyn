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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(61, 1188, 1612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1249, 1260);

                uint
                token
                = default(uint);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1457, 1564) || true) && (f_61_1461_1502(_itemToToken, item, out token))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(61, 1457, 1564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1536, 1549);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(61, 1457, 1564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1580, 1601);

                return f_61_1587_1600(this, item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(61, 1188, 1612);

                bool
                f_61_1461_1502(System.Collections.Concurrent.ConcurrentDictionary<T, uint>
                this_param, T
                key, out uint
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 1461, 1502);
                    return return_v;
                }


                uint
                f_61_1587_1600(Microsoft.CodeAnalysis.CodeGen.ItemTokenMap<T>
                this_param, T
                item)
                {
                    var return_v = this_param.AddItem(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 1587, 1600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(61, 1188, 1612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(61, 1188, 1612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private uint AddItem(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(61, 1624, 2054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1677, 1688);

                uint
                token
                = default(uint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1710, 1716);

                lock (_items)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1750, 1869) || true) && (f_61_1754_1795(_itemToToken, item, out token))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(61, 1750, 1869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1837, 1850);

                        return token;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(61, 1750, 1869);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1889, 1916);

                    token = (uint)f_61_1903_1915(_items);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1934, 1951);

                    f_61_1934_1950(_items, item);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 1969, 1999);

                    f_61_1969_1998(_itemToToken, item, token);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 2030, 2043);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(61, 1624, 2054);

                bool
                f_61_1754_1795(System.Collections.Concurrent.ConcurrentDictionary<T, uint>
                this_param, T
                key, out uint
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 1754, 1795);
                    return return_v;
                }


                int
                f_61_1903_1915(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(61, 1903, 1915);
                    return return_v;
                }


                int
                f_61_1934_1950(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 1934, 1950);
                    return 0;
                }


                int
                f_61_1969_1998(System.Collections.Concurrent.ConcurrentDictionary<T, uint>
                dict, T
                key, uint
                value)
                {
                    dict.Add<T, uint>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 1969, 1998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(61, 1624, 2054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(61, 1624, 2054);
            }
            throw new System.Exception("Slicer error: unreachable code");
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

                    return f_61_2172_2190(_items, (int)token);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(61, 2066, 2217);

                T
                f_61_2172_2190(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(61, 2172, 2190);
                    return return_v;
                }

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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(61, 2229, 2385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 2295, 2301);
                lock (_items)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(61, 2335, 2359);

                    return f_61_2342_2358(_items);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(61, 2229, 2385);

                T[]
                f_61_2342_2358(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(61, 2342, 2358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(61, 2229, 2385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(61, 2229, 2385);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
