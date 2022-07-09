// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal sealed class OrderedMultiDictionary<K, V> : IEnumerable<KeyValuePair<K, SetWithInsertionOrder<V>>>
            where K : notnull
    {
        private readonly Dictionary<K, SetWithInsertionOrder<V>> _dictionary;

        private readonly List<K> _keys;

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(352, 674, 694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 677, 694);
                    return f_352_677_694(_dictionary); DynAbs.Tracing.TraceSender.TraceExitMethod(352, 674, 694);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 674, 694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 674, 694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(352, 734, 742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 737, 742);
                    return _keys; DynAbs.Tracing.TraceSender.TraceExitMethod(352, 734, 742);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 734, 742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 734, 742);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        // Returns an empty set if there is no such key in the dictionary.
        public SetWithInsertionOrder<V> this[K k]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(352, 897, 1099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 933, 963);

                    SetWithInsertionOrder<V>?
                    set
                    = default(SetWithInsertionOrder<V>?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 981, 1084);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(352, 988, 1023) || ((f_352_988_1023(_dictionary, k, out set) && DynAbs.Tracing.TraceSender.Conditional_F2(352, 1047, 1050)) || DynAbs.Tracing.TraceSender.Conditional_F3(352, 1053, 1083))) ? set : f_352_1053_1083();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(352, 897, 1099);

                    bool
                    f_352_988_1023(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.SetWithInsertionOrder<V>>
                    this_param, K
                    key, out Roslyn.Utilities.SetWithInsertionOrder<V>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 988, 1023);
                        return return_v;
                    }


                    Roslyn.Utilities.SetWithInsertionOrder<V>
                    f_352_1053_1083()
                    {
                        var return_v = new Roslyn.Utilities.SetWithInsertionOrder<V>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1053, 1083);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 897, 1099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 897, 1099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public OrderedMultiDictionary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(352, 1122, 1285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 592, 603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 639, 644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1178, 1238);

                _dictionary = f_352_1192_1237<K, V>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1252, 1274);

                _keys = f_352_1260_1273<K>();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(352, 1122, 1285);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 1122, 1285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 1122, 1285);
            }
        }

        public void Add(K k, V v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(352, 1297, 1619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1347, 1377);

                SetWithInsertionOrder<V>?
                set
                = default(SetWithInsertionOrder<V>?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1391, 1548) || true) && (!f_352_1396_1431(_dictionary, k, out set))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(352, 1391, 1548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1465, 1478);

                    f_352_1465_1477(_keys, k);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1496, 1533);

                    set = f_352_1502_1532();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(352, 1391, 1548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1562, 1573);

                f_352_1562_1572(set, v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1587, 1608);

                _dictionary[k] = set;
                DynAbs.Tracing.TraceSender.TraceExitMethod(352, 1297, 1619);

                bool
                f_352_1396_1431(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.SetWithInsertionOrder<V>>
                this_param, K
                key, out Roslyn.Utilities.SetWithInsertionOrder<V>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1396, 1431);
                    return return_v;
                }


                int
                f_352_1465_1477(System.Collections.Generic.List<K>
                this_param, K
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1465, 1477);
                    return 0;
                }


                Roslyn.Utilities.SetWithInsertionOrder<V>
                f_352_1502_1532()
                {
                    var return_v = new Roslyn.Utilities.SetWithInsertionOrder<V>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1502, 1532);
                    return return_v;
                }


                bool
                f_352_1562_1572(Roslyn.Utilities.SetWithInsertionOrder<V>
                this_param, V?
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1562, 1572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 1297, 1619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 1297, 1619);
            }
        }

        public void AddRange(K k, IEnumerable<V> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(352, 1631, 1798);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1704, 1787);
                    foreach (var v in f_352_1722_1728_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(352, 1704, 1787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1762, 1772);

                        f_352_1762_1771(this, k, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(352, 1704, 1787);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(352, 1, 84);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(352, 1, 84);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(352, 1631, 1798);

                int
                f_352_1762_1771(Roslyn.Utilities.OrderedMultiDictionary<K, V>
                this_param, K
                k, V?
                v)
                {
                    this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1762, 1771);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<V>
                f_352_1722_1728_I(System.Collections.Generic.IEnumerable<V>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1722, 1728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 1631, 1798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 1631, 1798);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(352, 1850, 1868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1853, 1868);
                return f_352_1853_1868(this); DynAbs.Tracing.TraceSender.TraceExitMethod(352, 1850, 1868);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 1850, 1868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 1850, 1868);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K, Roslyn.Utilities.SetWithInsertionOrder<V>>>
            f_352_1853_1868(Roslyn.Utilities.OrderedMultiDictionary<K, V>
            this_param)
            {
                var return_v = this_param.GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1853, 1868);
                return return_v;
            }

        }

        public IEnumerator<KeyValuePair<K, SetWithInsertionOrder<V>>> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(352, 1881, 2172);

                var listYield = new List<KeyValuePair<K, SetWithInsertionOrder<V>>>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 1983, 2161);
                    foreach (var key in f_352_2003_2008_I(_keys))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(352, 1983, 2161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(352, 2042, 2146);

                        listYield.Add(f_352_2055_2145(key, f_352_2128_2144(_dictionary, key)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(352, 1983, 2161);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(352, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(352, 1, 179);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(352, 1881, 2172);

                return listYield.GetEnumerator();

                Roslyn.Utilities.SetWithInsertionOrder<V>
                f_352_2128_2144(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.SetWithInsertionOrder<V>>
                this_param, K
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(352, 2128, 2144);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<K, Roslyn.Utilities.SetWithInsertionOrder<V>>
                f_352_2055_2145(K
                key, Roslyn.Utilities.SetWithInsertionOrder<V>
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<K, Roslyn.Utilities.SetWithInsertionOrder<V>>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 2055, 2145);
                    return return_v;
                }


                System.Collections.Generic.List<K>
                f_352_2003_2008_I(System.Collections.Generic.List<K>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 2003, 2008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(352, 1881, 2172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 1881, 2172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OrderedMultiDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(352, 384, 2179);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(352, 384, 2179);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(352, 384, 2179);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(352, 384, 2179);

        int
        f_352_677_694(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.SetWithInsertionOrder<V>>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(352, 677, 694);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<K, Roslyn.Utilities.SetWithInsertionOrder<V>>
        f_352_1192_1237<K, V>() where K : notnull

        {
            var return_v = new System.Collections.Generic.Dictionary<K, Roslyn.Utilities.SetWithInsertionOrder<V>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1192, 1237);
            return return_v;
        }


        static System.Collections.Generic.List<K>
        f_352_1260_1273<K>() where K : notnull

        {
            var return_v = new System.Collections.Generic.List<K>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(352, 1260, 1273);
            return return_v;
        }

    }
}
