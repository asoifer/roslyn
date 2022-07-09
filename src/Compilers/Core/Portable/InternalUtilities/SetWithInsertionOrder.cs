// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Roslyn.Utilities
{
    internal sealed class SetWithInsertionOrder<T> : IEnumerable<T>, IReadOnlySet<T>
    {
        private HashSet<T>? _set;

        private ArrayBuilder<T>? _elements;

        public bool Add(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 758, 1121);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 807, 948) || true) && (_set == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 807, 948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 857, 881);

                    _set = f_365_864_880();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 899, 933);

                    _elements = f_365_911_932();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(365, 807, 948);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 964, 1046) || true) && (!f_365_969_984(_set, value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 964, 1046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1018, 1031);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(365, 964, 1046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1062, 1084);

                f_365_1062_1083(
                            _elements!, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1098, 1110);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(365, 758, 1121);

                System.Collections.Generic.HashSet<T>
                f_365_864_880()
                {
                    var return_v = new System.Collections.Generic.HashSet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 864, 880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_365_911_932()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 911, 932);
                    return return_v;
                }


                bool
                f_365_969_984(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 969, 984);
                    return return_v;
                }


                int
                f_365_1062_1083(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 1062, 1083);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 758, 1121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 758, 1121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Insert(int index, T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 1133, 1843);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1196, 1806) || true) && (_set == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 1196, 1806);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1246, 1357) || true) && (index > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 1246, 1357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1301, 1338);

                        throw f_365_1307_1337();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(365, 1246, 1357);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1375, 1386);

                    f_365_1375_1385(this, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(365, 1196, 1806);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 1196, 1806);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1452, 1546) || true) && (!f_365_1457_1472(_set, value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 1452, 1546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1514, 1527);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(365, 1452, 1546);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1610, 1642);

                        f_365_1610_1641(_elements!, index, value);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(365, 1679, 1791);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1725, 1744);

                        f_365_1725_1743(_set, value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1766, 1772);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(365, 1679, 1791);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(365, 1196, 1806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1820, 1832);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(365, 1133, 1843);

                System.IndexOutOfRangeException
                f_365_1307_1337()
                {
                    var return_v = new System.IndexOutOfRangeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 1307, 1337);
                    return return_v;
                }


                bool
                f_365_1375_1385(Roslyn.Utilities.SetWithInsertionOrder<T>
                this_param, T?
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 1375, 1385);
                    return return_v;
                }


                bool
                f_365_1457_1472(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 1457, 1472);
                    return return_v;
                }


                int
                f_365_1610_1641(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, int
                index, T?
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 1610, 1641);
                    return 0;
                }


                bool
                f_365_1725_1743(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 1725, 1743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 1133, 1843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 1133, 1843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Remove(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 1855, 2183);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1907, 1985) || true) && (_set is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 1907, 1985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 1957, 1970);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(365, 1907, 1985);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2001, 2086) || true) && (!f_365_2006_2024(_set, value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(365, 2001, 2086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2058, 2071);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(365, 2001, 2086);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2100, 2146);

                f_365_2100_2145(_elements!, f_365_2120_2144(_elements, value));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2160, 2172);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(365, 1855, 2183);

                bool
                f_365_2006_2024(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2006, 2024);
                    return return_v;
                }


                int
                f_365_2120_2144(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2120, 2144);
                    return return_v;
                }


                int
                f_365_2100_2145(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2100, 2145);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 1855, 2183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 1855, 2183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 2212, 2236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2215, 2236);
                    return f_365_2215_2231_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_elements, 365, 2215, 2231)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(365, 2215, 2236) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(365, 2212, 2236);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 2212, 2236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 2212, 2236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 2279, 2312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2282, 2312);
                return f_365_2282_2303_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_set, 365, 2282, 2303)?.Contains(value)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(365, 2282, 2312) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(365, 2279, 2312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 2279, 2312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 2279, 2312);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool?
            f_365_2282_2303_I(bool?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2282, 2303);
                return return_v;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 2376, 2488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2379, 2488);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(365, 2379, 2396) || ((_elements is null && DynAbs.Tracing.TraceSender.Conditional_F2(365, 2399, 2442)) || DynAbs.Tracing.TraceSender.Conditional_F3(365, 2445, 2488))) ? f_365_2399_2442() : f_365_2445_2488(((IEnumerable<T>)_elements)); DynAbs.Tracing.TraceSender.TraceExitMethod(365, 2376, 2488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 2376, 2488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 2376, 2488);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerator<T>
            f_365_2399_2442()
            {
                var return_v = SpecializedCollections.EmptyEnumerator<T>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2399, 2442);
                return return_v;
            }


            System.Collections.Generic.IEnumerator<T>
            f_365_2445_2488(System.Collections.Generic.IEnumerable<T>
            this_param)
            {
                var return_v = this_param.GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2445, 2488);
                return return_v;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 2541, 2559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2544, 2559);
                return f_365_2544_2559(this); DynAbs.Tracing.TraceSender.TraceExitMethod(365, 2541, 2559);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 2541, 2559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 2541, 2559);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerator<T>
            f_365_2544_2559(Roslyn.Utilities.SetWithInsertionOrder<T>
            this_param)
            {
                var return_v = this_param.GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2544, 2559);
                return return_v;
            }

        }

        public ImmutableArray<T> AsImmutable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 2611, 2649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2614, 2649);
                return f_365_2614_2649(_elements); DynAbs.Tracing.TraceSender.TraceExitMethod(365, 2611, 2649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 2611, 2649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 2611, 2649);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<T>
            f_365_2614_2649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>?
            items)
            {
                var return_v = items.ToImmutableArrayOrEmpty<T>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2614, 2649);
                return return_v;
            }

        }

        public T this[int i] => f_365_2686_2699(_elements!, i);

        public SetWithInsertionOrder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(365, 565, 2707);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 682, 693);
            this._set = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 729, 745);
            this._elements = null; DynAbs.Tracing.TraceSender.TraceExitConstructor(365, 565, 2707);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 565, 2707);
        }


        static SetWithInsertionOrder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(365, 565, 2707);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(365, 565, 2707);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 565, 2707);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(365, 565, 2707);

        int?
        f_365_2215_2231_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(365, 2215, 2231);
            return return_v;
        }


        T?
        f_365_2686_2699(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(365, 2686, 2699);
            return return_v;
        }

    }
}
