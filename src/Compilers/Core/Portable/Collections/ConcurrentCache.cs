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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(98, 1565, 2005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1632, 1673);

                var
                hash = f_98_1643_1672(_keyComparer, key)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1687, 1709);

                var
                idx = hash & mask
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1725, 1755);

                var
                entry = this.entries[idx]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1769, 1909) || true) && (entry != null && (DynAbs.Tracing.TraceSender.Expression_True(98, 1773, 1808) && entry.hash == hash) && (DynAbs.Tracing.TraceSender.Expression_True(98, 1773, 1847) && f_98_1812_1847(_keyComparer, entry.key, key)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(98, 1769, 1909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1881, 1894);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(98, 1769, 1909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1925, 1968);

                entries[idx] = f_98_1940_1967(hash, key, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 1982, 1994);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(98, 1565, 2005);

                int
                f_98_1643_1672(System.Collections.Generic.IEqualityComparer<TKey>
                this_param, TKey
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(98, 1643, 1672);
                    return return_v;
                }


                bool
                f_98_1812_1847(System.Collections.Generic.IEqualityComparer<TKey>
                this_param, TKey
                x, TKey
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(98, 1812, 1847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConcurrentCache<TKey, TValue>.Entry
                f_98_1940_1967(int
                hash, TKey
                key, TValue?
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConcurrentCache<TKey, TValue>.Entry(hash, key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(98, 1940, 1967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(98, 1565, 2005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(98, 1565, 2005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(returnValue: false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(98, 2017, 2514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2129, 2170);

                int
                hash = f_98_2140_2169(_keyComparer, key)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2184, 2206);

                int
                idx = hash & mask
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2222, 2252);

                var
                entry = this.entries[idx]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2266, 2443) || true) && (entry != null && (DynAbs.Tracing.TraceSender.Expression_True(98, 2270, 2305) && entry.hash == hash) && (DynAbs.Tracing.TraceSender.Expression_True(98, 2270, 2344) && f_98_2309_2344(_keyComparer, entry.key, key)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(98, 2266, 2443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2378, 2398);

                    value = entry.value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2416, 2428);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(98, 2266, 2443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2459, 2476);

                value = default!;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(98, 2490, 2503);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(98, 2017, 2514);

                int
                f_98_2140_2169(System.Collections.Generic.IEqualityComparer<TKey>
                this_param, TKey
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(98, 2140, 2169);
                    return return_v;
                }


                bool
                f_98_2309_2344(System.Collections.Generic.IEqualityComparer<TKey>
                this_param, TKey
                x, TKey
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(98, 2309, 2344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(98, 2017, 2514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(98, 2017, 2514);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
