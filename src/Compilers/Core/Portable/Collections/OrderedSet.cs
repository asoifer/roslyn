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
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public bool Add(T item)
        {
            if (_set.Add(item))
            {
                _list.Add(item);
                return true;
            }

            return false;
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
            return _set.Contains(item);
        }

        public ArrayBuilder<T>.Enumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)_list).GetEnumerator();
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
            _set.Clear();
            _list.Clear();
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
