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
            var builder = ArrayBuilder<T>.GetInstance();
            if (_many.IsDefault)
            {
                builder.Add(_one!);
            }
            else
            {
                builder.AddRange(_many);
            }
            builder.Add(one);
            return new OneOrMany<T>(builder.ToImmutableAndFree());
        }

        public bool Contains(T item)
        {
            RoslynDebug.Assert(item != null);
            if (Count == 1)
            {
                return item.Equals(_one);
            }

            var iter = GetEnumerator();
            while (iter.MoveNext())
            {
                if (item.Equals(iter.Current))
                {
                    return true;
                }
            }

            return false;
        }

        public OneOrMany<T> RemoveAll(T item)
        {
            if (_many.IsDefault)
            {
                return item.Equals(_one) ? default : this;
            }

            var builder = ArrayBuilder<T>.GetInstance();
            var iter = GetEnumerator();
            while (iter.MoveNext())
            {
                if (!item.Equals(iter.Current))
                {
                    builder.Add(iter.Current);
                }
            }

            if (builder.Count == 0)
            {
                return default;
            }

            return builder.Count == Count ? this : new OneOrMany<T>(builder.ToImmutableAndFree());
        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
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
