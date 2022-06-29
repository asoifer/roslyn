// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.Collections
{
    internal class SmallConcurrentSetOfInts
    {
        private int _v1;

        private int _v2;

        private int _v3;

        private int _v4;

        private SmallConcurrentSetOfInts? _next;

        private const int
        unoccupied = int.MinValue
        ;

        public SmallConcurrentSetOfInts()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(112, 1299, 1403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1099, 1102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1125, 1128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1151, 1154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1177, 1180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1225, 1230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1357, 1392);

                _v1 = _v2 = _v3 = _v4 = unoccupied;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(112, 1299, 1403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 1299, 1403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 1299, 1403);
            }
        }

        private SmallConcurrentSetOfInts(int initialValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(112, 1415, 1563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1099, 1102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1125, 1128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1151, 1154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1177, 1180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1225, 1230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1490, 1509);

                _v1 = initialValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1523, 1552);

                _v2 = _v3 = _v4 = unoccupied;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(112, 1415, 1563);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 1415, 1563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 1415, 1563);
            }
        }

        public bool Contains(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 1843, 2000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1895, 1925);

                f_112_1895_1924(i != unoccupied);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1939, 1989);

                return f_112_1946_1988(this, i);
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 1843, 2000);

                int
                f_112_1895_1924(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 1895, 1924);
                    return 0;
                }


                bool
                f_112_1946_1988(Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts
                set, int
                i)
                {
                    var return_v = SmallConcurrentSetOfInts.Contains(set, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 1946, 1988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 1843, 2000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 1843, 2000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Contains(SmallConcurrentSetOfInts set, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(112, 2012, 2695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2102, 2142);

                SmallConcurrentSetOfInts?
                current = set
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 2156, 2655);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2405, 2558) || true) && (current._v1 == i || (DynAbs.Tracing.TraceSender.Expression_False(112, 2409, 2445) || current._v2 == i) || (DynAbs.Tracing.TraceSender.Expression_False(112, 2409, 2465) || current._v3 == i) || (DynAbs.Tracing.TraceSender.Expression_False(112, 2409, 2485) || current._v4 == i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 2405, 2558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2527, 2539);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(112, 2405, 2558);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2578, 2602);

                            current = current._next;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 2156, 2655);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2156, 2655) || true) && (current != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 2156, 2655);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(112, 2156, 2655);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2671, 2684);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(112, 2012, 2695);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 2012, 2695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 2012, 2695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Add(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 2966, 3113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3013, 3043);

                f_112_3013_3042(i != unoccupied);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3057, 3102);

                return f_112_3064_3101(this, i);
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 2966, 3113);

                int
                f_112_3013_3042(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3013, 3042);
                    return 0;
                }


                bool
                f_112_3064_3101(Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts
                set, int
                i)
                {
                    var return_v = SmallConcurrentSetOfInts.Add(set, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3064, 3101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 2966, 3113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 2966, 3113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Add(SmallConcurrentSetOfInts set, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(112, 3125, 4294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3210, 3229);

                bool
                added = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3245, 4283) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 3245, 4283);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3290, 3587) || true) && (f_112_3294_3330(ref set._v1, i, ref added) || (DynAbs.Tracing.TraceSender.Expression_False(112, 3294, 3391) || f_112_3355_3391(ref set._v2, i, ref added)) || (DynAbs.Tracing.TraceSender.Expression_False(112, 3294, 3452) || f_112_3416_3452(ref set._v3, i, ref added)) || (DynAbs.Tracing.TraceSender.Expression_False(112, 3294, 3513) || f_112_3477_3513(ref set._v4, i, ref added)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 3290, 3587);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3555, 3568);

                            return added;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 3290, 3587);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3607, 3631);

                        var
                        nextSet = set._next
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3649, 4234) || true) && (nextSet == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 3649, 4234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3761, 3839);

                            SmallConcurrentSetOfInts
                            tail = f_112_3793_3838(initialValue: i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3863, 3928);

                            nextSet = f_112_3873_3927(ref set._next, tail, null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3950, 4112) || true) && (nextSet == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 3950, 4112);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4077, 4089);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(112, 3950, 4112);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 3649, 4234);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4254, 4268);

                        set = nextSet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 3245, 4283);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 3245, 4283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(112, 3245, 4283);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(112, 3125, 4294);

                bool
                f_112_3294_3330(ref int
                slot, int
                i, ref bool
                added)
                {
                    var return_v = AddHelper(ref slot, i, ref added);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3294, 3330);
                    return return_v;
                }


                bool
                f_112_3355_3391(ref int
                slot, int
                i, ref bool
                added)
                {
                    var return_v = AddHelper(ref slot, i, ref added);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3355, 3391);
                    return return_v;
                }


                bool
                f_112_3416_3452(ref int
                slot, int
                i, ref bool
                added)
                {
                    var return_v = AddHelper(ref slot, i, ref added);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3416, 3452);
                    return return_v;
                }


                bool
                f_112_3477_3513(ref int
                slot, int
                i, ref bool
                added)
                {
                    var return_v = AddHelper(ref slot, i, ref added);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3477, 3513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts
                f_112_3793_3838(int
                initialValue)
                {
                    var return_v = new Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts(initialValue: initialValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3793, 3838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts?
                f_112_3873_3927(ref Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts?
                location1, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts
                value, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3873, 3927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 3125, 4294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 3125, 4294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AddHelper(ref int slot, int i, ref bool added)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(112, 4840, 5432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4931, 4952);

                f_112_4931_4951(!added);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4968, 4983);

                int
                val = slot
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4999, 5387) || true) && (val == unoccupied)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 4999, 5387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5054, 5113);

                    val = f_112_5060_5112(ref slot, i, unoccupied);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5133, 5318) || true) && (val == unoccupied)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 5133, 5318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5252, 5265);

                        added = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5287, 5299);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 5133, 5318);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 4999, 5387);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5403, 5421);

                return (val == i);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(112, 4840, 5432);

                int
                f_112_4931_4951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 4931, 4951);
                    return 0;
                }


                int
                f_112_5060_5112(ref int
                location1, int
                value, int
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 5060, 5112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 4840, 5432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 4840, 5432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SmallConcurrentSetOfInts()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(112, 881, 5439);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1261, 1286);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(112, 881, 5439);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 881, 5439);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(112, 881, 5439);
    }
}
