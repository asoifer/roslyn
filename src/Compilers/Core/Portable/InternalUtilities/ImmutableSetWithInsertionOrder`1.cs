// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Roslyn.Utilities
{
    internal sealed class ImmutableSetWithInsertionOrder<T> : IEnumerable<T>
            where T : notnull
    {
        public static readonly ImmutableSetWithInsertionOrder<T> Empty;

        private readonly ImmutableDictionary<T, uint> _map;

        private readonly uint _nextElementValue;

        private ImmutableSetWithInsertionOrder(ImmutableDictionary<T, uint> map, uint nextElementValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(335, 751, 944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 684, 688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 721, 738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 871, 882);

                _map = map;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 896, 933);

                _nextElementValue = nextElementValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(335, 751, 944);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 751, 944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 751, 944);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 997, 1023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1003, 1021);

                    return f_335_1010_1020(_map);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(335, 997, 1023);

                    int
                    f_335_1010_1020(System.Collections.Immutable.ImmutableDictionary<T, uint>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(335, 1010, 1020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 956, 1034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 956, 1034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(T value)
        {
            return _map.ContainsKey(value);
        }

        public ImmutableSetWithInsertionOrder<T> Add(T value)
        {
            // no reason to cause allocations if value is already in the set
            if (_map.ContainsKey(value))
            {
                return this;
            }

            return new ImmutableSetWithInsertionOrder<T>(_map.Add(value, _nextElementValue), _nextElementValue + 1u);
        }

        public ImmutableSetWithInsertionOrder<T> Remove(T value)
        {
            var modifiedMap = _map.Remove(value);
            if (modifiedMap == _map)
            {
                // no reason to cause allocations if value is missing
                return this;
            }

            return this.Count == 1 ? Empty : new ImmutableSetWithInsertionOrder<T>(modifiedMap, _nextElementValue);
        }

        public IEnumerable<T> InInsertionOrder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 2034, 2099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 2040, 2097);

                    return f_335_2047_2096(f_335_2047_2075(_map, kv => kv.Value), kv => kv.Key);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(335, 2034, 2099);

                    System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<T, uint>>
                    f_335_2047_2075(System.Collections.Immutable.ImmutableDictionary<T, uint>
                    source, System.Func<System.Collections.Generic.KeyValuePair<T, uint>, uint>
                    keySelector)
                    {
                        var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<T, uint>, uint>(keySelector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 2047, 2075);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<T>
                    f_335_2047_2096(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<T, uint>>
                    source, System.Func<System.Collections.Generic.KeyValuePair<T, uint>, T>
                    selector)
                    {
                        var return_v = source.Select<System.Collections.Generic.KeyValuePair<T, uint>, T>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 2047, 2096);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 1971, 2110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 1971, 2110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            return "{" + string.Join(", ", this) + "}";
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _map.Keys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _map.Keys.GetEnumerator();
        }

        static ImmutableSetWithInsertionOrder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(335, 364, 2479);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 537, 625);
            Empty = f_335_545_625<T>(f_335_583_620<T>(), 0u); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(335, 364, 2479);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 364, 2479);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(335, 364, 2479);

        static System.Collections.Immutable.ImmutableDictionary<T, uint>
        f_335_583_620<T>()
        {
            var return_v = ImmutableDictionary.Create<T, uint>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 583, 620);
            return return_v;
        }


        static Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>
        f_335_545_625<T>(System.Collections.Immutable.ImmutableDictionary<T, uint>
        map, uint
        nextElementValue)
        {
            var return_v = new Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>(map, nextElementValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 545, 625);
            return return_v;
        }

    }
}
