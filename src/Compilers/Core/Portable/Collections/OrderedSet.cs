// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Collections
{
    internal sealed class OrderedSet<T> : IEnumerable<T>, IReadOnlySet<T>, IReadOnlyList<T>, IOrderedReadOnlySet<T>
    {
        private readonly HashSet<T> _set;

        private readonly ArrayBuilder<T> _list;

        public OrderedSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(109, 632, 755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 566, 570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 614, 619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 676, 700);

                _set = f_109_683_699<T>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 714, 744);

                _list = f_109_722_743<T>();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(109, 632, 755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 632, 755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 632, 755);
            }
        }

        public OrderedSet(IEnumerable<T> items)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(109, 767, 880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 853, 869);

                f_109_853_868(this, items);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(109, 767, 880);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 767, 880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 767, 880);
            }
        }

        public void AddRange(IEnumerable<T> items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 892, 1055);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 959, 1044);
                    foreach (var item in f_109_980_985_I(items))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(109, 959, 1044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1019, 1029);

                        f_109_1019_1028(this, item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(109, 959, 1044);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(109, 1, 86);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(109, 1, 86);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(109, 892, 1055);

                bool
                f_109_1019_1028(Microsoft.CodeAnalysis.Collections.OrderedSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1019, 1028);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_109_980_985_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 980, 985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 892, 1055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 892, 1055);
            }
        }

        public bool Add(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 1067, 1268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1115, 1228) || true) && (f_109_1119_1133(_set, item))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(109, 1115, 1228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1167, 1183);

                    f_109_1167_1182(_list, item);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1201, 1213);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(109, 1115, 1228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1244, 1257);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(109, 1067, 1268);

                bool
                f_109_1119_1133(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1119, 1133);
                    return return_v;
                }


                int
                f_109_1167_1182(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1167, 1182);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 1067, 1268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 1067, 1268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 1321, 1391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1357, 1376);

                    return f_109_1364_1375(_list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(109, 1321, 1391);

                    int
                    f_109_1364_1375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 1364, 1375);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 1280, 1402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 1280, 1402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public T this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 1463, 1534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1499, 1519);

                    return f_109_1506_1518(_list, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(109, 1463, 1534);

                    T?
                    f_109_1506_1518(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 1506, 1518);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 1463, 1534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 1463, 1534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 1557, 1648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1610, 1637);

                return f_109_1617_1636(_set, item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(109, 1557, 1648);

                bool
                f_109_1617_1636(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1617, 1636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 1557, 1648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 1557, 1648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ArrayBuilder<T>.Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 1660, 1774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1734, 1763);

                return f_109_1741_1762(_list);
                DynAbs.Tracing.TraceSender.TraceExitMethod(109, 1660, 1774);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>.Enumerator
                f_109_1741_1762(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1741, 1762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 1660, 1774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 1660, 1774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 1786, 1914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1856, 1903);

                return f_109_1863_1902(((IEnumerable<T>)_list));
                DynAbs.Tracing.TraceSender.TraceExitMethod(109, 1786, 1914);

                System.Collections.Generic.IEnumerator<T>
                f_109_1863_1902(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1863, 1902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 1786, 1914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 1786, 1914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 1926, 2045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 1990, 2034);

                return f_109_1997_2033(((IEnumerable)_list));
                DynAbs.Tracing.TraceSender.TraceExitMethod(109, 1926, 2045);

                System.Collections.IEnumerator
                f_109_1997_2033(System.Collections.IEnumerable
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1997, 2033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 1926, 2045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 1926, 2045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(109, 2057, 2153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 2101, 2114);

                f_109_2101_2113(_set);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(109, 2128, 2142);

                f_109_2128_2141(_list);
                DynAbs.Tracing.TraceSender.TraceExitMethod(109, 2057, 2153);

                int
                f_109_2101_2113(System.Collections.Generic.HashSet<T>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 2101, 2113);
                    return 0;
                }


                int
                f_109_2128_2141(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 2128, 2141);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109, 2057, 2153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 2057, 2153);
            }
        }

        static OrderedSet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(109, 410, 2160);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(109, 410, 2160);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109, 410, 2160);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(109, 410, 2160);

        static System.Collections.Generic.HashSet<T>
        f_109_683_699<T>()
        {
            var return_v = new System.Collections.Generic.HashSet<T>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 683, 699);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
        f_109_722_743<T>()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 722, 743);
            return return_v;
        }


        static int
        f_109_853_868<T>(Microsoft.CodeAnalysis.Collections.OrderedSet<T>
        this_param, System.Collections.Generic.IEnumerable<T>
        items)
        {
            this_param.AddRange(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 853, 868);
            return 0;
        }

    }
}
