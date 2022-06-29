// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal class CachingFactory<TKey, TValue> : CachingBase<CachingFactory<TKey, TValue>.Entry>
            where TKey : notnull
    {
        internal struct Entry
        {

            internal int hash;

            internal TValue value;
            static Entry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(97, 1927, 2038);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(97, 1927, 2038);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 1927, 2038);
            }
        }

        private readonly int _size;

        private readonly Func<TKey, TValue> _valueFactory;

        private readonly Func<TKey, int> _keyHash;

        private readonly Func<TKey, TValue, bool> _keyValueEquality;

        public CachingFactory(int size,
                        Func<TKey, TValue> valueFactory,
                        Func<TKey, int> keyHash,
                        Func<TKey, TValue, bool> keyValueEquality) : base(f_97_2475_2479_C(size))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(97, 2271, 2656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2071, 2076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2123, 2136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2180, 2188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2241, 2258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2505, 2518);

                _size = size;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2532, 2561);

                _valueFactory = valueFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2575, 2594);

                _keyHash = keyHash;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 2608, 2645);

                _keyValueEquality = keyValueEquality;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(97, 2271, 2656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(97, 2271, 2656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 2271, 2656);
            }
        }

        public void Add(TKey key, TValue value)
        {
            var hash = GetKeyHash(key);
            var idx = hash & mask;

            entries[idx].hash = hash;
            entries[idx].value = value;
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(returnValue: false)] out TValue value)
        {
            int hash = GetKeyHash(key);
            int idx = hash & mask;

            var entries = this.entries;
            if (entries[idx].hash == hash)
            {
                var candidate = entries[idx].value;
                if (_keyValueEquality(key, candidate))
                {
                    value = candidate;
                    return true;
                }
            }

            value = default!;
            return false;
        }

        public TValue GetOrMakeValue(TKey key)
        {
            int hash = GetKeyHash(key);
            int idx = hash & mask;

            var entries = this.entries;
            if (entries[idx].hash == hash)
            {
                var candidate = entries[idx].value;
                if (_keyValueEquality(key, candidate))
                {
                    return candidate;
                }
            }

            var value = _valueFactory(key);
            entries[idx].hash = hash;
            entries[idx].value = value;

            return value;
        }

        private int GetKeyHash(TKey key)
        {
            // Ensure result is non-zero to avoid
            // treating an empty entry as valid.
            int result = _keyHash(key) | _size;
            Debug.Assert(result != 0);
            return result;
        }

        static CachingFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(97, 1787, 4383);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(97, 1787, 4383);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 1787, 4383);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(97, 1787, 4383);

        static int
        f_97_2475_2479_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(97, 2271, 2656);
            return return_v;
        }

    }
    internal class CachingIdentityFactory<TKey, TValue> : CachingBase<CachingIdentityFactory<TKey, TValue>.Entry>
            where TKey : class
    {
        private readonly Func<TKey, TValue> _valueFactory;

        private readonly ObjectPool<CachingIdentityFactory<TKey, TValue>>? _pool;

        internal struct Entry
        {

            internal TKey key;

            internal TValue value;
        }

        public CachingIdentityFactory(int size, Func<TKey, TValue> valueFactory) : base(f_97_5345_5349_C(size))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(97, 5252, 5415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 5020, 5033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 5111, 5116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 5375, 5404);

                _valueFactory = valueFactory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(97, 5252, 5415);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(97, 5252, 5415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 5252, 5415);
            }
        }

        public CachingIdentityFactory(int size, Func<TKey, TValue> valueFactory, ObjectPool<CachingIdentityFactory<TKey, TValue>> pool) : this(f_97_5575_5579_C(size), valueFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(97, 5427, 5643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 5619, 5632);

                _pool = pool;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(97, 5427, 5643);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(97, 5427, 5643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 5427, 5643);
            }
        }

        public void Add(TKey key, TValue value)
        {
            var hash = RuntimeHelpers.GetHashCode(key);
            var idx = hash & mask;

            entries[idx].key = key;
            entries[idx].value = value;
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(returnValue: false)] out TValue value)
        {
            int hash = RuntimeHelpers.GetHashCode(key);
            int idx = hash & mask;

            var entries = this.entries;
            if ((object)entries[idx].key == (object)key)
            {
                value = entries[idx].value;
                return true;
            }

            value = default!;
            return false;
        }

        public TValue GetOrMakeValue(TKey key)
        {
            int hash = RuntimeHelpers.GetHashCode(key);
            int idx = hash & mask;

            var entries = this.entries;
            if ((object)entries[idx].key == (object)key)
            {
                return entries[idx].value;
            }

            var value = _valueFactory(key);
            entries[idx].key = key;
            entries[idx].value = value;

            return value;
        }

        public static ObjectPool<CachingIdentityFactory<TKey, TValue>> CreatePool(int size, Func<TKey, TValue> valueFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(97, 6922, 7309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7063, 7270);

                var
                pool = f_97_7074_7269(pool => new CachingIdentityFactory<TKey, TValue>(size, valueFactory, pool), f_97_7238_7264() * 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7286, 7298);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(97, 6922, 7309);

                int
                f_97_7238_7264()
                {
                    var return_v = Environment.ProcessorCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(97, 7238, 7264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CachingIdentityFactory<TKey, TValue>>
                f_97_7074_7269(System.Func<Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CachingIdentityFactory<TKey, TValue>>, Microsoft.CodeAnalysis.CachingIdentityFactory<TKey, TValue>>
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CachingIdentityFactory<TKey, TValue>>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(97, 7074, 7269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(97, 6922, 7309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 6922, 7309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(97, 7321, 7494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7364, 7381);

                var
                pool = _pool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7466, 7483);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pool, 97, 7466, 7482)?.Free(this), 97, 7471, 7482);
                DynAbs.Tracing.TraceSender.TraceExitMethod(97, 7321, 7494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(97, 7321, 7494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 7321, 7494);
            }
        }

        static CachingIdentityFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(97, 4830, 7501);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(97, 4830, 7501);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 4830, 7501);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(97, 4830, 7501);

        static int
        f_97_5345_5349_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(97, 5252, 5415);
            return return_v;
        }


        static int
        f_97_5575_5579_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(97, 5427, 5643);
            return return_v;
        }

    }
    internal abstract class CachingBase<TEntry>
    {
        protected readonly int mask;

        protected readonly TEntry[] entries;

        internal CachingBase(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(97, 7861, 8056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7798, 7802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7841, 7848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7916, 7950);

                var
                alignedSize = f_97_7934_7949(size)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 7964, 7992);

                this.mask = alignedSize - 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8006, 8045);

                this.entries = new TEntry[alignedSize];
                DynAbs.Tracing.TraceSender.TraceExitConstructor(97, 7861, 8056);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(97, 7861, 8056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 7861, 8056);
            }
        }

        private static int AlignSize(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(97, 8068, 8379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8131, 8154);

                f_97_8131_8153(size > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8170, 8177);

                size--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8191, 8209);

                size |= size >> 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8223, 8241);

                size |= size >> 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8255, 8273);

                size |= size >> 4;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8287, 8305);

                size |= size >> 8;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8319, 8338);

                size |= size >> 16;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(97, 8352, 8368);

                return size + 1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(97, 8068, 8379);

                int
                f_97_8131_8153(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(97, 8131, 8153);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(97, 8068, 8379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 8068, 8379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CachingBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(97, 7561, 8386);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(97, 7561, 8386);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(97, 7561, 8386);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(97, 7561, 8386);

        static int
        f_97_7934_7949(int
        size)
        {
            var return_v = AlignSize(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(97, 7934, 7949);
            return return_v;
        }

    }
}
