// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal sealed class MultiDictionary<K, V> : IEnumerable<KeyValuePair<K, MultiDictionary<K, V>.ValueSet>>
            where K : notnull
    {
        public struct ValueSet : IEnumerable<V>
        {

            public struct Enumerator : IEnumerator<V>
            {

                [AllowNull]
                private readonly V _value;

                private ImmutableHashSet<V>.Enumerator _values;

                private int _count;

                public Enumerator(ValueSet v)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(346, 968, 1979);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1038, 1960) || true) && (v._value == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 1038, 1960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1108, 1125);

                            _value = default;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1151, 1169);

                            _values = default;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1195, 1206);

                            _count = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(346, 1038, 1960);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 1038, 1960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1304, 1346);

                            var
                            set = v._value as ImmutableHashSet<V>
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1372, 1877) || true) && (set == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 1372, 1877);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1445, 1466);

                                _value = (V)v._value;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1496, 1514);

                                _values = default;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1544, 1555);

                                _count = 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(346, 1372, 1877);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 1372, 1877);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1669, 1686);

                                _value = default;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1716, 1746);

                                _values = f_346_1726_1745(set);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1776, 1795);

                                _count = f_346_1785_1794<V>(set);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1825, 1850);

                                f_346_1825_1849(_count > 1);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(346, 1372, 1877);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 1905, 1937);

                            f_346_1905_1936(_count == v.Count);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(346, 1038, 1960);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(346, 968, 1979);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 968, 1979);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 968, 1979);
                    }
                }

                public void Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 1999, 2058);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(346, 1999, 2058);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 1999, 2058);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 1999, 2058);
                    }
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 2078, 2191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 2138, 2172);

                        throw f_346_2144_2171();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(346, 2078, 2191);

                        System.NotSupportedException
                        f_346_2144_2171()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 2144, 2171);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 2078, 2191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 2078, 2191);
                    }
                }

                object? IEnumerator.Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 2239, 2254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 2242, 2254);
                            return this.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(346, 2239, 2254);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 2239, 2254);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 2239, 2254);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public V Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 2510, 2630);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 2562, 2607);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(346, 2569, 2579) || ((_count > 1 && DynAbs.Tracing.TraceSender.Conditional_F2(346, 2582, 2597)) || DynAbs.Tracing.TraceSender.Conditional_F3(346, 2600, 2606))) ? _values.Current : _value;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(346, 2510, 2630);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 2453, 2649);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 2453, 2649);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 2669, 3289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 2732, 3270);

                        switch (_count)
                        {

                            case 0:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 2732, 3270);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 2833, 2846);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(346, 2732, 3270);

                            case 1:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 2732, 3270);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 2911, 2922);

                                _count = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 2952, 2964);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(346, 2732, 3270);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 2732, 3270);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 3030, 3161) || true) && (_values.MoveNext())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 3030, 3161);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 3118, 3130);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(346, 3030, 3161);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 3193, 3204);

                                _count = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 3234, 3247);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(346, 2732, 3270);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(346, 2669, 3289);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 2669, 3289);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 2669, 3289);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(346, 717, 3304);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(346, 717, 3304);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 717, 3304);
                }

                static System.Collections.Immutable.ImmutableHashSet<V>.Enumerator
                f_346_1726_1745<V>(System.Collections.Immutable.ImmutableHashSet<V>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 1726, 1745);
                    return return_v;
                }


                static int
                f_346_1785_1794<V>(System.Collections.Immutable.ImmutableHashSet<V>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(346, 1785, 1794);
                    return return_v;
                }


                static int
                f_346_1825_1849(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 1825, 1849);
                    return 0;
                }


                static int
                f_346_1905_1936(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 1905, 1936);
                    return 0;
                }

            }

            private readonly object? _value;

            private readonly IEqualityComparer<V> _equalityComparer;

            public int Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 3556, 4293);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 3600, 3700) || true) && (_value == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 3600, 3700);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 3668, 3677);

                            return 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(346, 3600, 3700);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4074, 4114);

                        var
                        set = _value as ImmutableHashSet<V>
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4136, 4233) || true) && (set == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 4136, 4233);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4201, 4210);

                            return 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(346, 4136, 4233);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4257, 4274);

                        return f_346_4264_4273(set);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(346, 3556, 4293);

                        int
                        f_346_4264_4273(System.Collections.Immutable.ImmutableHashSet<V>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(346, 4264, 4273);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 3507, 4308);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 3507, 4308);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ValueSet(object? value, IEqualityComparer<V>? equalityComparer = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(346, 4324, 4560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4434, 4449);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4467, 4545);

                    _equalityComparer = equalityComparer ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEqualityComparer<V>?>(346, 4487, 4544) ?? f_346_4507_4544<V>(ImmutableHashSet<V>.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(346, 4324, 4560);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 4324, 4560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 4324, 4560);
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 4576, 4686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4648, 4671);

                    return GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 4576, 4686);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 4576, 4686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 4576, 4686);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator<V> IEnumerable<V>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 4702, 4818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4780, 4803);

                    return GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 4702, 4818);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 4702, 4818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 4702, 4818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Enumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 4834, 4943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 4900, 4928);

                    return f_346_4907_4927(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 4834, 4943);

                    Roslyn.Utilities.MultiDictionary<K, V>.ValueSet.Enumerator
                    f_346_4907_4927(Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
                    v)
                    {
                        var return_v = new Roslyn.Utilities.MultiDictionary<K, V>.ValueSet.Enumerator(v);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 4907, 4927);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 4834, 4943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 4834, 4943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ValueSet Add(V v)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 4959, 5498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5016, 5045);

                    f_346_5016_5044(_value != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5065, 5105);

                    var
                    set = _value as ImmutableHashSet<V>
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5123, 5412) || true) && (set == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 5123, 5412);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5180, 5308) || true) && (f_346_5184_5223(_equalityComparer, _value!, v))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 5180, 5308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5273, 5285);

                            return this;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(346, 5180, 5308);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5332, 5393);

                        set = f_346_5338_5392(_equalityComparer, _value!);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(346, 5123, 5412);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5432, 5483);

                    return f_346_5439_5482(f_346_5452_5462(set, v), _equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 4959, 5498);

                    int
                    f_346_5016_5044(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5016, 5044);
                        return 0;
                    }


                    bool
                    f_346_5184_5223(System.Collections.Generic.IEqualityComparer<V>
                    this_param, object
                    x, V?
                    y)
                    {
                        var return_v = this_param.Equals((V)x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5184, 5223);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<V>
                    f_346_5338_5392(System.Collections.Generic.IEqualityComparer<V>
                    equalityComparer, object
                    item)
                    {
                        var return_v = ImmutableHashSet.Create(equalityComparer, (V)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5338, 5392);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<V>
                    f_346_5452_5462(System.Collections.Immutable.ImmutableHashSet<V>
                    this_param, V?
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5452, 5462);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
                    f_346_5439_5482(System.Collections.Immutable.ImmutableHashSet<V>
                    value, System.Collections.Generic.IEqualityComparer<V>
                    equalityComparer)
                    {
                        var return_v = new Roslyn.Utilities.MultiDictionary<K, V>.ValueSet((object)value, equalityComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5439, 5482);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 4959, 5498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 4959, 5498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Contains(V v)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 5514, 5811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5572, 5612);

                    var
                    set = _value as ImmutableHashSet<V>
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5630, 5753) || true) && (set == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 5630, 5753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5687, 5734);

                        return f_346_5694_5733(_equalityComparer, _value!, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(346, 5630, 5753);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5773, 5796);

                    return f_346_5780_5795(set, v);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 5514, 5811);

                    bool
                    f_346_5694_5733(System.Collections.Generic.IEqualityComparer<V>
                    this_param, object
                    x, V?
                    y)
                    {
                        var return_v = this_param.Equals((V)x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5694, 5733);
                        return return_v;
                    }


                    bool
                    f_346_5780_5795(System.Collections.Immutable.ImmutableHashSet<V>
                    this_param, V?
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5780, 5795);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 5514, 5811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 5514, 5811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Contains(V v, IEqualityComparer<V> comparer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 5827, 6163);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5916, 6115);
                        foreach (V other in f_346_5936_5940_I(this))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 5916, 6115);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 5982, 6096) || true) && (f_346_5986_6011(comparer, other, v))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 5982, 6096);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6061, 6073);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(346, 5982, 6096);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(346, 5916, 6115);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(346, 1, 200);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(346, 1, 200);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6135, 6148);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 5827, 6163);

                    bool
                    f_346_5986_6011(System.Collections.Generic.IEqualityComparer<V>
                    this_param, V?
                    x, V?
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5986, 6011);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
                    f_346_5936_5940_I(Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 5936, 5940);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 5827, 6163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 5827, 6163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public V Single()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 6179, 6336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6229, 6261);

                    f_346_6229_6260(_value is V);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6304, 6321);

                    return (V)_value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 6179, 6336);

                    int
                    f_346_6229_6260(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 6229, 6260);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 6179, 6336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 6179, 6336);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(ValueSet other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 6352, 6464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6419, 6449);

                    return _value == other._value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 6352, 6464);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 6352, 6464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 6352, 6464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static ValueSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(346, 653, 6475);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(346, 653, 6475);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 653, 6475);
            }

            static System.Collections.Generic.IEqualityComparer<V>
            f_346_4507_4544<V>(System.Collections.Immutable.ImmutableHashSet<V>
            this_param)
            {
                var return_v = this_param.KeyComparer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(346, 4507, 4544);
                return return_v;
            }

        }

        private readonly Dictionary<K, ValueSet> _dictionary;

        private readonly IEqualityComparer<V>? _valueComparer;

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 6635, 6655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6638, 6655);
                    return f_346_6638_6655(_dictionary); DynAbs.Tracing.TraceSender.TraceExitMethod(346, 6635, 6655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 6635, 6655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 6635, 6655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 6688, 6713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6691, 6713);
                    return f_346_6691_6708(_dictionary) == 0; DynAbs.Tracing.TraceSender.TraceExitMethod(346, 6688, 6713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 6688, 6713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 6688, 6713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Dictionary<K, ValueSet>.KeyCollection Keys
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 6776, 6795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6779, 6795);
                    return f_346_6779_6795(_dictionary); DynAbs.Tracing.TraceSender.TraceExitMethod(346, 6776, 6795);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 6776, 6795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 6776, 6795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Dictionary<K, ValueSet>.ValueCollection Values
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 6862, 6883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6865, 6883);
                    return f_346_6865_6883(_dictionary); DynAbs.Tracing.TraceSender.TraceExitMethod(346, 6862, 6883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 6862, 6883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 6862, 6883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly ValueSet _emptySet;

        // Returns an empty set if there is no such key in the dictionary.
        public ValueSet this[K k]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 7088, 7204);
                    Roslyn.Utilities.MultiDictionary<K, V>.ValueSet set = default(Roslyn.Utilities.MultiDictionary<K, V>.ValueSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7124, 7189);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(346, 7131, 7170) || ((f_346_7131_7170(_dictionary, k, out set) && DynAbs.Tracing.TraceSender.Conditional_F2(346, 7173, 7176)) || DynAbs.Tracing.TraceSender.Conditional_F3(346, 7179, 7188))) ? set : _emptySet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(346, 7088, 7204);

                    bool
                    f_346_7131_7170(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
                    this_param, K
                    key, out Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 7131, 7170);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 7088, 7204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 7088, 7204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MultiDictionary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(346, 7227, 7331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6528, 6539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6591, 6605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6922, 6949);
                this._emptySet = f_346_6934_6949(null, null);

                Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
f_346_6934_6949(object?
value, System.Collections.Generic.IEqualityComparer<V>?
equalityComparer)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<K, V>.ValueSet(value, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 6934, 6949);
                    return return_v;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7276, 7320);

                _dictionary = f_346_7290_7319<K>();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(346, 7227, 7331);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 7227, 7331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 7227, 7331);
            }
        }

        public MultiDictionary(IEqualityComparer<K> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(346, 7343, 7484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6528, 6539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6591, 6605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6922, 6949);
                this._emptySet = new(null, null); DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7421, 7473);

                _dictionary = f_346_7435_7472<K>(comparer);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(346, 7343, 7484);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 7343, 7484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 7343, 7484);
            }
        }

        public MultiDictionary(int capacity, IEqualityComparer<K> comparer, IEqualityComparer<V>? valueComparer = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(346, 7496, 7750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6528, 6539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6591, 6605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 6922, 6949);
                this._emptySet = new(null, null); DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7632, 7694);

                _dictionary = f_346_7646_7693<K>(capacity, comparer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7708, 7739);

                _valueComparer = valueComparer;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(346, 7496, 7750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 7496, 7750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 7496, 7750);
            }
        }

        public bool Add(K k, V v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 7762, 8264);
                Roslyn.Utilities.MultiDictionary<K, V>.ValueSet set = default(Roslyn.Utilities.MultiDictionary<K, V>.ValueSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7812, 7829);

                ValueSet
                updated
                = default(ValueSet);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7845, 8186) || true) && (f_346_7849_7893(_dictionary, k, out set))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 7845, 8186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7927, 7948);

                    updated = set.Add(v);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 7966, 8063) || true) && (updated.Equals(set))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 7966, 8063);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8031, 8044);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(346, 7966, 8063);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(346, 7845, 8186);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(346, 7845, 8186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8129, 8171);

                    updated = f_346_8139_8170(v, _valueComparer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(346, 7845, 8186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8202, 8227);

                _dictionary[k] = updated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8241, 8253);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(346, 7762, 8264);

                bool
                f_346_7849_7893(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
                this_param, K
                key, out Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 7849, 7893);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<K, V>.ValueSet
                f_346_8139_8170(V?
                value, System.Collections.Generic.IEqualityComparer<V>?
                equalityComparer)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<K, V>.ValueSet((object?)value, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 8139, 8170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 7762, 8264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 7762, 8264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 8276, 8374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8340, 8363);

                return f_346_8347_8362(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(346, 8276, 8374);

                System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>.Enumerator
                f_346_8347_8362(Roslyn.Utilities.MultiDictionary<K, V>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 8347, 8362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 8276, 8374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 8276, 8374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Dictionary<K, ValueSet>.Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 8386, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8468, 8503);

                return f_346_8475_8502(_dictionary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(346, 8386, 8514);

                System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>.Enumerator
                f_346_8475_8502(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 8475, 8502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 8386, 8514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 8386, 8514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<KeyValuePair<K, ValueSet>> IEnumerable<KeyValuePair<K, ValueSet>>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 8526, 8678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8644, 8667);

                return f_346_8651_8666(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(346, 8526, 8678);

                System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>.Enumerator
                f_346_8651_8666(Roslyn.Utilities.MultiDictionary<K, V>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 8651, 8666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 8526, 8678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 8526, 8678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ContainsKey(K k)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 8690, 8788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8743, 8777);

                return f_346_8750_8776(_dictionary, k);
                DynAbs.Tracing.TraceSender.TraceExitMethod(346, 8690, 8788);

                bool
                f_346_8750_8776(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
                this_param, K
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 8750, 8776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 8690, 8788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 8690, 8788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 8800, 8877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8846, 8866);

                f_346_8846_8865(_dictionary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(346, 8800, 8877);

                int
                f_346_8846_8865(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 8846, 8865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 8800, 8877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 8800, 8877);
            }
        }

        public void Remove(K key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(346, 8889, 8974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(346, 8939, 8963);

                f_346_8939_8962(_dictionary, key);
                DynAbs.Tracing.TraceSender.TraceExitMethod(346, 8889, 8974);

                bool
                f_346_8939_8962(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
                this_param, K
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 8939, 8962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(346, 8889, 8974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 8889, 8974);
            }
        }

        static MultiDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(346, 503, 8981);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(346, 503, 8981);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(346, 503, 8981);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(346, 503, 8981);

        int
        f_346_6638_6655(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(346, 6638, 6655);
            return return_v;
        }


        int
        f_346_6691_6708(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(346, 6691, 6708);
            return return_v;
        }


        System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>.KeyCollection
        f_346_6779_6795(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
        this_param)
        {
            var return_v = this_param.Keys;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(346, 6779, 6795);
            return return_v;
        }


        System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>.ValueCollection
        f_346_6865_6883(System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
        this_param)
        {
            var return_v = this_param.Values;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(346, 6865, 6883);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
        f_346_7290_7319<K>() where K : notnull

        {
            var return_v = new System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 7290, 7319);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
        f_346_7435_7472<K>(System.Collections.Generic.IEqualityComparer<K>
        comparer) where K : notnull

        {
            var return_v = new System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>(comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 7435, 7472);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>
        f_346_7646_7693<K>(int
        capacity, System.Collections.Generic.IEqualityComparer<K>
        comparer) where K : notnull

        {
            var return_v = new System.Collections.Generic.Dictionary<K, Roslyn.Utilities.MultiDictionary<K, V>.ValueSet>(capacity, comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(346, 7646, 7693);
            return return_v;
        }

    }
}
