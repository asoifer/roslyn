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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 1046, 1142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1100, 1131);

                return f_335_1107_1130(_map, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(335, 1046, 1142);

                bool
                f_335_1107_1130(System.Collections.Immutable.ImmutableDictionary<T, uint>
                this_param, T
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 1107, 1130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 1046, 1142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 1046, 1142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableSetWithInsertionOrder<T> Add(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 1154, 1530);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1310, 1398) || true) && (f_335_1314_1337(_map, value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(335, 1310, 1398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1371, 1383);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(335, 1310, 1398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1414, 1519);

                return f_335_1421_1518(f_335_1459_1493(_map, value, _nextElementValue), _nextElementValue + 1u);
                DynAbs.Tracing.TraceSender.TraceExitMethod(335, 1154, 1530);

                bool
                f_335_1314_1337(System.Collections.Immutable.ImmutableDictionary<T, uint>
                this_param, T
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 1314, 1337);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<T, uint>
                f_335_1459_1493(System.Collections.Immutable.ImmutableDictionary<T, uint>
                this_param, T
                key, uint
                value)
                {
                    var return_v = this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 1459, 1493);
                    return return_v;
                }


                Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>
                f_335_1421_1518(System.Collections.Immutable.ImmutableDictionary<T, uint>
                map, uint
                nextElementValue)
                {
                    var return_v = new Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>(map, nextElementValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 1421, 1518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 1154, 1530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 1154, 1530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableSetWithInsertionOrder<T> Remove(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 1542, 1959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1623, 1660);

                var
                modifiedMap = f_335_1641_1659(_map, value)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1674, 1829) || true) && (modifiedMap == _map)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(335, 1674, 1829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1802, 1814);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(335, 1674, 1829);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 1845, 1948);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(335, 1852, 1867) || ((f_335_1852_1862(this) == 1 && DynAbs.Tracing.TraceSender.Conditional_F2(335, 1870, 1875)) || DynAbs.Tracing.TraceSender.Conditional_F3(335, 1878, 1947))) ? Empty : f_335_1878_1947(modifiedMap, _nextElementValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(335, 1542, 1959);

                System.Collections.Immutable.ImmutableDictionary<T, uint>
                f_335_1641_1659(System.Collections.Immutable.ImmutableDictionary<T, uint>
                this_param, T
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 1641, 1659);
                    return return_v;
                }


                int
                f_335_1852_1862(Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(335, 1852, 1862);
                    return return_v;
                }


                Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>
                f_335_1878_1947(System.Collections.Immutable.ImmutableDictionary<T, uint>
                map, uint
                nextElementValue)
                {
                    var return_v = new Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>(map, nextElementValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 1878, 1947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 1542, 1959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 1542, 1959);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 2122, 2234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 2180, 2223);

                return "{" + f_335_2193_2216(", ", this) + "}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(335, 2122, 2234);

                string
                f_335_2193_2216(string
                separator, Roslyn.Utilities.ImmutableSetWithInsertionOrder<T>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<T>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 2193, 2216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 2122, 2234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 2122, 2234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerator<T> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 2246, 2352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 2308, 2341);

                return f_335_2315_2340(f_335_2315_2324(_map));
                DynAbs.Tracing.TraceSender.TraceExitMethod(335, 2246, 2352);

                System.Collections.Generic.IEnumerable<T>
                f_335_2315_2324(System.Collections.Immutable.ImmutableDictionary<T, uint>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(335, 2315, 2324);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_335_2315_2340(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 2315, 2340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 2246, 2352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 2246, 2352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(335, 2364, 2472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(335, 2428, 2461);

                return f_335_2435_2460(f_335_2435_2444(_map));
                DynAbs.Tracing.TraceSender.TraceExitMethod(335, 2364, 2472);

                System.Collections.Generic.IEnumerable<T>
                f_335_2435_2444(System.Collections.Immutable.ImmutableDictionary<T, uint>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(335, 2435, 2444);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_335_2435_2460(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(335, 2435, 2460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(335, 2364, 2472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(335, 2364, 2472);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
