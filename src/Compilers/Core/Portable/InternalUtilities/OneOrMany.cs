// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Roslyn.Utilities
{

    internal struct OneOrMany<T>
            where T : notnull
    {

        private readonly T? _one;

        private readonly ImmutableArray<T> _many;

        public OneOrMany(T one)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(351, 730, 830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 778, 789);

                _one = one;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 803, 819);

                _many = default;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(351, 730, 830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 730, 830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 730, 830);
            }
        }

        public OneOrMany(ImmutableArray<T> many)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(351, 842, 1089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 907, 1020) || true) && (many.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 907, 1020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 959, 1005);

                    throw f_351_965_1004(nameof(many));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(351, 907, 1020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1036, 1051);

                _one = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1065, 1078);

                _many = many;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(351, 842, 1089);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 842, 1089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 842, 1089);
            }
        }

        public T this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 1150, 1544);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1186, 1529) || true) && (_many.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 1186, 1529);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1247, 1371) || true) && (index != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 1247, 1371);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1311, 1348);

                            throw f_351_1317_1347();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(351, 1247, 1371);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1395, 1408);

                        return _one!;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(351, 1186, 1529);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 1186, 1529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1490, 1510);

                        return _many[index];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(351, 1186, 1529);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(351, 1150, 1544);

                    System.IndexOutOfRangeException
                    f_351_1317_1347()
                    {
                        var return_v = new System.IndexOutOfRangeException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 1317, 1347);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 1150, 1544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 1150, 1544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 1608, 1701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1644, 1686);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(351, 1651, 1666) || ((_many.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(351, 1669, 1670)) || DynAbs.Tracing.TraceSender.Conditional_F3(351, 1673, 1685))) ? 1 : _many.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(351, 1608, 1701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 1567, 1712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 1567, 1712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public OneOrMany<T> Add(T one)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 1724, 2124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1779, 1823);

                var
                builder = f_351_1793_1822()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1837, 2014) || true) && (_many.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 1837, 2014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1890, 1909);

                    f_351_1890_1908(builder, _one!);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(351, 1837, 2014);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 1837, 2014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 1975, 1999);

                    f_351_1975_1998(builder, _many);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(351, 1837, 2014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2028, 2045);

                f_351_2028_2044(builder, one);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2059, 2113);

                return f_351_2066_2112(f_351_2083_2111(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(351, 1724, 2124);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_351_1793_1822()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 1793, 1822);
                    return return_v;
                }


                int
                f_351_1890_1908(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 1890, 1908);
                    return 0;
                }


                int
                f_351_1975_1998(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 1975, 1998);
                    return 0;
                }


                int
                f_351_2028_2044(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2028, 2044);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_351_2083_2111(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2083, 2111);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<T>
                f_351_2066_2112(System.Collections.Immutable.ImmutableArray<T>
                many)
                {
                    var return_v = new Roslyn.Utilities.OneOrMany<T>(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2066, 2112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 1724, 2124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 1724, 2124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Contains(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 2136, 2594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2189, 2222);

                f_351_2189_2221(item != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2236, 2324) || true) && (Count == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 2236, 2324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2284, 2309);

                    return f_351_2291_2308(item, _one);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(351, 2236, 2324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2340, 2367);

                var
                iter = GetEnumerator()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2381, 2554) || true) && (iter.MoveNext())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 2381, 2554);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2437, 2539) || true) && (f_351_2441_2466(item, iter.Current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 2437, 2539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2508, 2520);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(351, 2437, 2539);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(351, 2381, 2554);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(351, 2381, 2554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(351, 2381, 2554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2570, 2583);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(351, 2136, 2594);

                int
                f_351_2189_2221(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2189, 2221);
                    return 0;
                }


                bool
                f_351_2291_2308(T
                this_param, T?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2291, 2308);
                    return return_v;
                }


                bool
                f_351_2441_2466(T
                this_param, T
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2441, 2466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 2136, 2594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 2136, 2594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public OneOrMany<T> RemoveAll(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 2606, 3296);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2668, 2778) || true) && (_many.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 2668, 2778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2721, 2763);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(351, 2728, 2745) || ((f_351_2728_2745(item, _one) && DynAbs.Tracing.TraceSender.Conditional_F2(351, 2748, 2755)) || DynAbs.Tracing.TraceSender.Conditional_F3(351, 2758, 2762))) ? default : this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(351, 2668, 2778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2794, 2838);

                var
                builder = f_351_2808_2837()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2852, 2879);

                var
                iter = GetEnumerator()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2893, 3081) || true) && (iter.MoveNext())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 2893, 3081);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 2949, 3066) || true) && (!f_351_2954_2979(item, iter.Current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 2949, 3066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3021, 3047);

                            f_351_3021_3046(builder, iter.Current);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(351, 2949, 3066);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(351, 2893, 3081);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(351, 2893, 3081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(351, 2893, 3081);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3097, 3183) || true) && (f_351_3101_3114(builder) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(351, 3097, 3183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3153, 3168);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(351, 3097, 3183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3199, 3285);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(351, 3206, 3228) || ((f_351_3206_3219(builder) == Count && DynAbs.Tracing.TraceSender.Conditional_F2(351, 3231, 3235)) || DynAbs.Tracing.TraceSender.Conditional_F3(351, 3238, 3284))) ? this : f_351_3238_3284(f_351_3255_3283(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(351, 2606, 3296);

                bool
                f_351_2728_2745(T
                this_param, T?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2728, 2745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_351_2808_2837()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2808, 2837);
                    return return_v;
                }


                bool
                f_351_2954_2979(T
                this_param, T
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 2954, 2979);
                    return return_v;
                }


                int
                f_351_3021_3046(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 3021, 3046);
                    return 0;
                }


                int
                f_351_3101_3114(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(351, 3101, 3114);
                    return return_v;
                }


                int
                f_351_3206_3219(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(351, 3206, 3219);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_351_3255_3283(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 3255, 3283);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<T>
                f_351_3238_3284(System.Collections.Immutable.ImmutableArray<T>
                many)
                {
                    var return_v = new Roslyn.Utilities.OneOrMany<T>(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 3238, 3284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 2606, 3296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 2606, 3296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 3308, 3405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3366, 3394);

                return f_351_3373_3393(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(351, 3308, 3405);

                Roslyn.Utilities.OneOrMany<T>.Enumerator
                f_351_3373_3393(Roslyn.Utilities.OneOrMany<T>
                collection)
                {
                    var return_v = new Roslyn.Utilities.OneOrMany<T>.Enumerator(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 3373, 3393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 3308, 3405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 3308, 3405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal struct Enumerator
        {

            private readonly OneOrMany<T> _collection;

            private int _index;

            internal Enumerator(OneOrMany<T> collection)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(351, 3559, 3706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3636, 3661);

                    _collection = collection;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3679, 3691);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(351, 3559, 3706);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 3559, 3706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 3559, 3706);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 3722, 3853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3777, 3786);

                    _index++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3804, 3838);

                    return _index < _collection.Count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(351, 3722, 3853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 3722, 3853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 3722, 3853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public T Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(351, 3918, 3953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 3924, 3951);

                        return _collection[_index];
                        DynAbs.Tracing.TraceSender.TraceExitMethod(351, 3918, 3953);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 3869, 3968);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 3869, 3968);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(351, 3417, 3979);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(351, 3417, 3979);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 3417, 3979);
            }
        }
        static OneOrMany()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(351, 570, 3986);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(351, 570, 3986);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 570, 3986);
        }

        static System.ArgumentNullException
        f_351_965_1004(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 965, 1004);
            return return_v;
        }

    }
    internal static class OneOrMany
    {
        public static OneOrMany<T> Create<T>(T one)
                    where T : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(351, 4042, 4181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 4141, 4170);

                return f_351_4148_4169(one);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(351, 4042, 4181);

                Roslyn.Utilities.OneOrMany<T>
                f_351_4148_4169(T
                one)
                {
                    var return_v = new Roslyn.Utilities.OneOrMany<T>(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 4148, 4169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 4042, 4181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 4042, 4181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static OneOrMany<T> Create<T>(ImmutableArray<T> many)
                    where T : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(351, 4193, 4350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(351, 4309, 4339);

                return f_351_4316_4338(many);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(351, 4193, 4350);

                Roslyn.Utilities.OneOrMany<T>
                f_351_4316_4338(System.Collections.Immutable.ImmutableArray<T>
                many)
                {
                    var return_v = new Roslyn.Utilities.OneOrMany<T>(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(351, 4316, 4338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(351, 4193, 4350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(351, 4193, 4350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
