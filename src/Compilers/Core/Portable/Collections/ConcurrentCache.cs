// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal class ConcurrentCache<TKey, TValue> : CachingBase<ConcurrentCache<TKey, TValue>.Entry>
            where TKey : notnull
    {
        private readonly IEqualityComparer<TKey> _keyComparer;
        internal class Entry
        {
            internal readonly int hash;

            internal readonly TKey key;

            internal readonly TValue value;

            internal Entry(int hash, TKey key, TValue value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(98, 1083, 1266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 976, 980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1018, 1021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1061, 1066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1164, 1181);

                    this.hash = hash;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1199, 1214);

                    this.key = key;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1232, 1251);

                    this.value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(98, 1083, 1266);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(98, 1083, 1266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(98, 1083, 1266);
                }
            }

            static Entry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(98, 909, 1277);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(98, 909, 1277);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(98, 909, 1277);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(98, 909, 1277);
        }

        public ConcurrentCache(int size, IEqualityComparer<TKey> keyComparer)
        : base(f_98_1379_1383_C(size))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(98, 1289, 1447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 839, 851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1409, 1436);

                _keyComparer = keyComparer;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(98, 1289, 1447);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(98, 1289, 1447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(98, 1289, 1447);
            }
        }

        public ConcurrentCache(int size)
        : this(f_98_1512_1516_C(size), f_98_1518_1548<TKey>())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(98, 1459, 1553);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(98, 1459, 1553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(98, 1459, 1553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(98, 1459, 1553);
            }
        }

        public bool TryAdd(TKey key, TValue value)
        {
            var hash = _keyComparer.GetHashCode(key);
            var idx = hash & mask;

            var entry = this.entries[idx];
            if (entry != null && entry.hash == hash && _keyComparer.Equals(entry.key, key))
            {
                return false;
            }

            entries[idx] = new Entry(hash, key, value);
            return true;
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(returnValue: false)] out TValue value)
        {
            int hash = _keyComparer.GetHashCode(key);
            int idx = hash & mask;

            var entry = this.entries[idx];
            if (entry != null && entry.hash == hash && _keyComparer.Equals(entry.key, key))
            {
                value = entry.value;
                return true;
            }

            value = default!;
            return false;
        }

        static ConcurrentCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(98, 656, 2521);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(98, 656, 2521);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(98, 656, 2521);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(98, 656, 2521);

        static int
        f_98_1379_1383_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(98, 1289, 1447);
            return return_v;
        }


        static System.Collections.Generic.EqualityComparer<TKey>
        f_98_1518_1548<TKey>() where TKey : notnull

        {
            var return_v = EqualityComparer<TKey>.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(98, 1518, 1548);
            return return_v;
        }


        static int
        f_98_1512_1516_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(98, 1459, 1553);
            return return_v;
        }

    }
}
