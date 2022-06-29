// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using System.Diagnostics;
using Roslyn.Utilities;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal class UnionCollection<T> : ICollection<T>
    {
        // LAFHIS: before was readonly but we wanted to send by reference
        private ImmutableArray<ICollection<T>> _collections;

        private int _count;

        public static ICollection<T> Create(ICollection<T> coll1, ICollection<T> coll2)
        {
            Debug.Assert(coll1.IsReadOnly && coll2.IsReadOnly);

            // Often, one of the collections is empty. Avoid allocations in those cases.
            if (coll1.Count == 0)
            {
                return coll2;
            }

            if (coll2.Count == 0)
            {
                return coll1;
            }

            return new UnionCollection<T>(ImmutableArray.Create(coll1, coll2));
        }

        public static ICollection<T> Create<TOrig>(ImmutableArray<TOrig> collections, Func<TOrig, ICollection<T>> selector)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(116, 1835, 2428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1975, 2034);

                f_116_1975_2033(collections.All(c => selector(c).IsReadOnly));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2050, 2417);

                switch (collections.Length)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 2050, 2417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2139, 2190);

                        return f_116_2146_2189();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(116, 2050, 2417);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 2050, 2417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2239, 2271);

                        return f_116_2246_2270(selector, collections[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(116, 2050, 2417);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 2050, 2417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2321, 2402);

                        return f_116_2328_2401(f_116_2351_2400(collections, selector));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(116, 2050, 2417);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(116, 1835, 2428);

                int
                f_116_1975_2033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 1975, 2033);
                    return 0;
                }


                System.Collections.Generic.ICollection<T>
                f_116_2146_2189()
                {
                    var return_v = SpecializedCollections.EmptyCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 2146, 2189);
                    return return_v;
                }


                System.Collections.Generic.ICollection<T>
                f_116_2246_2270(System.Func<TOrig, System.Collections.Generic.ICollection<T>>
                this_param, TOrig?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 2246, 2270);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                f_116_2351_2400(System.Collections.Immutable.ImmutableArray<TOrig>
                items, System.Func<TOrig, System.Collections.Generic.ICollection<T>>
                selector)
                {
                    var return_v = ImmutableArray.CreateRange(items, selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 2351, 2400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnionCollection<T>
                f_116_2328_2401(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                collections)
                {
                    var return_v = new Microsoft.CodeAnalysis.UnionCollection<T>(collections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 2328, 2401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 1835, 2428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 1835, 2428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UnionCollection(ImmutableArray<ICollection<T>> collections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(116, 2440, 2621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1264, 1275);
                this._count = -1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2532, 2569);

                f_116_2532_2568(f_116_2545_2567_M(!collections.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2583, 2610);

                _collections = collections;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(116, 2440, 2621);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 2440, 2621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 2440, 2621);
            }
        }

        public void Add(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 2633, 2726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2681, 2715);

                throw f_116_2687_2714();
                DynAbs.Tracing.TraceSender.TraceExitMethod(116, 2633, 2726);

                System.NotSupportedException
                f_116_2687_2714()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 2687, 2714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 2633, 2726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 2633, 2726);
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 2738, 2827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 2782, 2816);

                throw f_116_2788_2815();
                DynAbs.Tracing.TraceSender.TraceExitMethod(116, 2738, 2827);

                System.NotSupportedException
                f_116_2788_2815()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 2788, 2815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 2738, 2827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 2738, 2827);
            }
        }

        public bool Contains(T item)
        {
            // PERF: Expansion of "return collections.Any(c => c.Contains(item));"
            // to avoid allocating a lambda.
            foreach (var c in _collections)
            {
                if (c.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var index = arrayIndex;
            foreach (var collection in _collections)
            {
                collection.CopyTo(array, index);
                index += collection.Count;
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 3581, 3783);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3617, 3734) || true) && (_count == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 3617, 3734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3675, 3715);

                        _count = f_116_3684_3714(ref _collections, c => c.Count);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(116, 3617, 3734);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3754, 3768);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(116, 3581, 3783);

                    int
                    f_116_3684_3714(ref System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                    source, System.Func<System.Collections.Generic.ICollection<T>, int>
                    selector)
                    {
                        var return_v = source.Sum<System.Collections.Generic.ICollection<T>>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3684, 3714);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 3540, 3794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 3540, 3794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 3853, 3916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3889, 3901);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(116, 3853, 3916);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 3806, 3927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 3806, 3927);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Remove(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 3939, 4035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3990, 4024);

                throw f_116_3996_4023();
                DynAbs.Tracing.TraceSender.TraceExitMethod(116, 3939, 4035);

                System.NotSupportedException
                f_116_3996_4023()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3996, 4023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 3939, 4035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 3939, 4035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _collections.SelectMany(c => c).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        static UnionCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(116, 1114, 4330);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(116, 1114, 4330);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 1114, 4330);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(116, 1114, 4330);

        bool
        f_116_2545_2567_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 2545, 2567);
            return return_v;
        }


        static int
        f_116_2532_2568(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 2532, 2568);
            return 0;
        }

    }
}
