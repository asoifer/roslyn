// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Roslyn.Utilities
{
    internal class ConsList<T> : IEnumerable<T>
    {
        public static readonly ConsList<T> Empty;

        private readonly T? _head;

        private readonly ConsList<T>? _tail;

        internal struct Enumerator : IEnumerator<T>
        {

            private T? _current;

            private ConsList<T> _tail;

            internal Enumerator(ConsList<T> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(318, 860, 995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 930, 949);

                    _current = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 967, 980);

                    _tail = list;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(318, 860, 995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 860, 995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 860, 995);
                }
            }

            public T Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 1060, 1289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1104, 1132);

                        f_318_1104_1131(_tail != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1253, 1270);

                        return _current!;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(318, 1060, 1289);

                        int
                        f_318_1104_1131(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 1104, 1131);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 1011, 1304);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 1011, 1304);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 1320, 1908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1375, 1399);

                    var
                    currentTail = _tail
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1417, 1449);

                    var
                    newTail = currentTail._tail
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1469, 1823) || true) && (newTail != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(318, 1469, 1823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1702, 1732);

                        _current = currentTail._head!;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1754, 1770);

                        _tail = newTail;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1792, 1804);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(318, 1469, 1823);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1843, 1862);

                    _current = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 1880, 1893);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(318, 1320, 1908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 1320, 1908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 1320, 1908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 1924, 1975);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(318, 1924, 1975);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 1924, 1975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 1924, 1975);
                }
            }

            object? IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 2051, 2134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2095, 2115);

                        return this.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(318, 2051, 2134);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 1991, 2149);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 1991, 2149);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 2165, 2266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2217, 2251);

                    throw f_318_2223_2250();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(318, 2165, 2266);

                    System.NotSupportedException
                    f_318_2223_2250()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 2223, 2250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 2165, 2266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 2165, 2266);
                }
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(318, 716, 2277);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(318, 716, 2277);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 716, 2277);
            }
        }

        private ConsList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(318, 2289, 2386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 652, 657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 698, 703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2332, 2348);

                _head = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2362, 2375);

                _tail = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(318, 2289, 2386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 2289, 2386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 2289, 2386);
            }
        }

        public ConsList(T head, ConsList<T> tail)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(318, 2398, 2558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 652, 657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 698, 703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2464, 2491);

                f_318_2464_2490(tail != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2507, 2520);

                _head = head;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2534, 2547);

                _tail = tail;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(318, 2398, 2558);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 2398, 2558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 2398, 2558);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public T Head
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 2667, 2778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2703, 2731);

                    f_318_2703_2730(this != Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2749, 2763);

                    return _head!;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(318, 2667, 2778);

                    int
                    f_318_2703_2730(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 2703, 2730);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 2570, 2789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 2570, 2789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ConsList<T> Tail
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 2908, 3072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2944, 2972);

                    f_318_2944_2971(this != Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 2990, 3026);

                    f_318_2990_3025(_tail is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3044, 3057);

                    return _tail;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(318, 2908, 3072);

                    int
                    f_318_2944_2971(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 2944, 2971);
                        return 0;
                    }


                    int
                    f_318_2990_3025(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 2990, 3025);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 2801, 3083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 2801, 3083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 3095, 3169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3137, 3158);

                return this != Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(318, 3095, 3169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 3095, 3169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 3095, 3169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ConsList<T> Push(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 3181, 3285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3238, 3274);

                return f_318_3245_3273(value, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(318, 3181, 3285);

                Roslyn.Utilities.ConsList<T>
                f_318_3245_3273(T?
                head, Roslyn.Utilities.ConsList<T>
                tail)
                {
                    var return_v = new Roslyn.Utilities.ConsList<T>(head, tail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 3245, 3273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 3181, 3285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 3181, 3285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 3297, 3395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3361, 3384);

                return f_318_3368_3383(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(318, 3297, 3395);

                Roslyn.Utilities.ConsList<T>.Enumerator
                f_318_3368_3383(Roslyn.Utilities.ConsList<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 3368, 3383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 3297, 3395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 3297, 3395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 3407, 3511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3477, 3500);

                return f_318_3484_3499(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(318, 3407, 3511);

                Roslyn.Utilities.ConsList<T>.Enumerator
                f_318_3484_3499(Roslyn.Utilities.ConsList<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 3484, 3499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 3407, 3511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 3407, 3511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 3523, 3620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3581, 3609);

                return f_318_3588_3608(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(318, 3523, 3620);

                Roslyn.Utilities.ConsList<T>.Enumerator
                f_318_3588_3608(Roslyn.Utilities.ConsList<T>
                list)
                {
                    var return_v = new Roslyn.Utilities.ConsList<T>.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 3588, 3608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 3523, 3620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 3523, 3620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(318, 3632, 4152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3690, 3744);

                StringBuilder
                result = f_318_3713_3743("ConsList[")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3758, 3775);

                bool
                any = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3806, 3817);
                    for (ConsList<T>
        list = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3789, 4067) || true) && (list._tail != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3839, 3856)
        , list = list._tail, DynAbs.Tracing.TraceSender.TraceExitCondition(318, 3789, 4067))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(318, 3789, 4067);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3890, 3978) || true) && (any)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(318, 3890, 3978);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3939, 3959);

                            f_318_3939_3958(result, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(318, 3890, 3978);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 3998, 4023);

                        f_318_3998_4022(
                                        result, f_318_4012_4021(list));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 4041, 4052);

                        any = true;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(318, 1, 279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(318, 1, 279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 4083, 4102);

                f_318_4083_4101(
                            result, "]");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 4116, 4141);

                return f_318_4123_4140(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(318, 3632, 4152);

                System.Text.StringBuilder
                f_318_3713_3743(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 3713, 3743);
                    return return_v;
                }


                System.Text.StringBuilder
                f_318_3939_3958(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 3939, 3958);
                    return return_v;
                }


                T?
                f_318_4012_4021(Roslyn.Utilities.ConsList<T>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(318, 4012, 4021);
                    return return_v;
                }


                System.Text.StringBuilder
                f_318_3998_4022(System.Text.StringBuilder
                this_param, T?
                value)
                {
                    var return_v = this_param.Append((object?)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 3998, 4022);
                    return return_v;
                }


                System.Text.StringBuilder
                f_318_4083_4101(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 4083, 4101);
                    return return_v;
                }


                string
                f_318_4123_4140(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 4123, 4140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(318, 3632, 4152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 3632, 4152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConsList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(318, 511, 4159);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(318, 606, 619);
            Empty = f_318_614_619<T>();

            static Roslyn.Utilities.ConsList<T>
f_318_614_619<T>()
            {
                var return_v = new Roslyn.Utilities.ConsList<T>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 614, 619);
                return return_v;
            }
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(318, 511, 4159);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(318, 511, 4159);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(318, 511, 4159);

        static int
        f_318_2464_2490(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(318, 2464, 2490);
            return 0;
        }

    }
}
