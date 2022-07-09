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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(116, 1288, 1823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1392, 1443);

                f_116_1392_1442(f_116_1405_1421(coll1) && (DynAbs.Tracing.TraceSender.Expression_True(116, 1405, 1441) && f_116_1425_1441(coll2)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1549, 1631) || true) && (f_116_1553_1564(coll1) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 1549, 1631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1603, 1616);

                    return coll2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(116, 1549, 1631);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1647, 1729) || true) && (f_116_1651_1662(coll2) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 1647, 1729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1701, 1714);

                    return coll1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(116, 1647, 1729);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 1745, 1812);

                return f_116_1752_1811(f_116_1775_1810(coll1, coll2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(116, 1288, 1823);

                bool
                f_116_1405_1421(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 1405, 1421);
                    return return_v;
                }


                bool
                f_116_1425_1441(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 1425, 1441);
                    return return_v;
                }


                int
                f_116_1392_1442(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 1392, 1442);
                    return 0;
                }


                int
                f_116_1553_1564(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 1553, 1564);
                    return return_v;
                }


                int
                f_116_1651_1662(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 1651, 1662);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                f_116_1775_1810(System.Collections.Generic.ICollection<T>
                item1, System.Collections.Generic.ICollection<T>
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 1775, 1810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnionCollection<T>
                f_116_1752_1811(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                collections)
                {
                    var return_v = new Microsoft.CodeAnalysis.UnionCollection<T>(collections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 1752, 1811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 1288, 1823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 1288, 1823);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 2839, 3234);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3022, 3194);
                    foreach (var c in f_116_3040_3052_I(_collections))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 3022, 3194);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3086, 3179) || true) && (f_116_3090_3106(c, item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 3086, 3179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3148, 3160);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(116, 3086, 3179);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(116, 3022, 3194);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(116, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(116, 1, 173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3210, 3223);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(116, 2839, 3234);

                bool
                f_116_3090_3106(System.Collections.Generic.ICollection<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3090, 3106);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                f_116_3040_3052_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3040, 3052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 2839, 3234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 2839, 3234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 3246, 3528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3316, 3339);

                var
                index = arrayIndex
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3353, 3517);
                    foreach (var collection in f_116_3380_3392_I(_collections))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(116, 3353, 3517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3426, 3458);

                        f_116_3426_3457(collection, array, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 3476, 3502);

                        index += f_116_3485_3501(collection);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(116, 3353, 3517);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(116, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(116, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(116, 3246, 3528);

                int
                f_116_3426_3457(System.Collections.Generic.ICollection<T>
                this_param, T[]
                array, int
                arrayIndex)
                {
                    this_param.CopyTo(array, arrayIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3426, 3457);
                    return 0;
                }


                int
                f_116_3485_3501(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 3485, 3501);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                f_116_3380_3392_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3380, 3392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 3246, 3528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 3246, 3528);
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 4047, 4175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 4109, 4164);

                // LAFHIS
                var temp = _collections.SelectMany<System.Collections.Generic.ICollection<T>, T>(c => c);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4116, 4147);

                return f_116_4116_4163(temp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(116, 4047, 4175);

                System.Collections.Generic.IEnumerable<T>
                f_116_4116_4147(ref System.Collections.Immutable.ImmutableArray<System.Collections.Generic.ICollection<T>>
                source, System.Func<System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>>
                selector)
                {
                    var return_v = source.SelectMany<System.Collections.Generic.ICollection<T>, T>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4116, 4147);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_116_4116_4163(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4116, 4163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 4047, 4175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 4047, 4175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(116, 4187, 4323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(116, 4289, 4312);

                return f_116_4296_4311(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(116, 4187, 4323);

                System.Collections.Generic.IEnumerator<T>
                f_116_4296_4311(Microsoft.CodeAnalysis.UnionCollection<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4296, 4311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116, 4187, 4323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116, 4187, 4323);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
