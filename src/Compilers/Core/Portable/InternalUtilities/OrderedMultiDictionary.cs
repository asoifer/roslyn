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
            SetWithInsertionOrder<V>? set;
            if (!_dictionary.TryGetValue(k, out set))
            {
                _keys.Add(k);
                set = new SetWithInsertionOrder<V>();
            }
            set.Add(v);
            _dictionary[k] = set;
        }

        public void AddRange(K k, IEnumerable<V> values)
        {
            foreach (var v in values)
            {
                Add(k, v);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<KeyValuePair<K, SetWithInsertionOrder<V>>> GetEnumerator()
        {
            foreach (var key in _keys)
            {
                yield return new KeyValuePair<K, SetWithInsertionOrder<V>>(
                    key, _dictionary[key]);
            }
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
