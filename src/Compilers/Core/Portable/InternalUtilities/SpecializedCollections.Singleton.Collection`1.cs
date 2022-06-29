// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static partial class SpecializedCollections
    {
        private static partial class Singleton
        {
            internal sealed class List<T> : IReadOnlyList<T>, IList<T>, IReadOnlyCollection<T>
            {
                private readonly T _loneValue;

                public List(T value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(381, 619, 718);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 588, 598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 680, 699);

                        _loneValue = value;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(381, 619, 718);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 619, 718);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 619, 718);
                    }
                }

                public void Add(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 738, 855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 802, 836);

                        throw f_381_808_835();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(381, 738, 855);

                        System.NotSupportedException
                        f_381_808_835()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(381, 808, 835);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 738, 855);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 738, 855);
                    }
                }

                public void Clear()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 875, 988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 935, 969);

                        throw f_381_941_968();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(381, 875, 988);

                        System.NotSupportedException
                        f_381_941_968()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(381, 941, 968);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 875, 988);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 875, 988);
                    }
                }

                public bool Contains(T item)
                {
                    return EqualityComparer<T>.Default.Equals(_loneValue, item);
                }

                public void CopyTo(T[] array, int arrayIndex)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 1176, 1312);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 1262, 1293);

                        array[arrayIndex] = _loneValue;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(381, 1176, 1312);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 1176, 1312);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 1176, 1312);
                    }
                }

                public int Count
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 1349, 1353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 1352, 1353);
                            return 1; DynAbs.Tracing.TraceSender.TraceExitMethod(381, 1349, 1353);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 1349, 1353);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 1349, 1353);
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
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 1397, 1404);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 1400, 1404);
                            return true; DynAbs.Tracing.TraceSender.TraceExitMethod(381, 1397, 1404);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 1397, 1404);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 1397, 1404);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool Remove(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 1425, 1545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 1492, 1526);

                        throw f_381_1498_1525();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(381, 1425, 1545);

                        System.NotSupportedException
                        f_381_1498_1525()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(381, 1498, 1525);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 1425, 1545);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 1425, 1545);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public IEnumerator<T> GetEnumerator()
                {
                    return new Enumerator<T>(_loneValue);
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return GetEnumerator();
                }

                public T this[int index]
                {

                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 1926, 2183);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 1978, 2114) || true) && (index != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(381, 1978, 2114);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 2050, 2087);

                                throw f_381_2056_2086();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(381, 1978, 2114);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 2142, 2160);

                            return _loneValue;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(381, 1926, 2183);

                            System.IndexOutOfRangeException
                            f_381_2056_2086()
                            {
                                var return_v = new System.IndexOutOfRangeException();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(381, 2056, 2086);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 1926, 2183);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 1926, 2183);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    set
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 2207, 2316);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 2259, 2293);

                            throw f_381_2265_2292();
                            DynAbs.Tracing.TraceSender.TraceExitMethod(381, 2207, 2316);

                            System.NotSupportedException
                            f_381_2265_2292()
                            {
                                var return_v = new System.NotSupportedException();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(381, 2265, 2292);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 2207, 2316);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 2207, 2316);
                        }
                    }
                }

                public int IndexOf(T item)
                {
                    if (Equals(_loneValue, item))
                    {
                        return 0;
                    }

                    return -1;
                }

                public void Insert(int index, T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 2605, 2736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 2683, 2717);

                        throw f_381_2689_2716();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(381, 2605, 2736);

                        System.NotSupportedException
                        f_381_2689_2716()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(381, 2689, 2716);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 2605, 2736);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 2605, 2736);
                    }
                }

                public void RemoveAt(int index)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(381, 2756, 2881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(381, 2828, 2862);

                        throw f_381_2834_2861();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(381, 2756, 2881);

                        System.NotSupportedException
                        f_381_2834_2861()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(381, 2834, 2861);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(381, 2756, 2881);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 2756, 2881);
                    }
                }

                static List()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(381, 454, 2896);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(381, 454, 2896);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 454, 2896);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(381, 454, 2896);
            }

            static Singleton()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(381, 391, 2907);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(381, 391, 2907);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(381, 391, 2907);
            }

        }
    }
}
