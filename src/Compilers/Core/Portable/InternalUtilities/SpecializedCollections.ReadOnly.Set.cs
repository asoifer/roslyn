// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class ReadOnly
        {
            internal class Set<TUnderlying, T> : Collection<TUnderlying, T>, ISet<T>, IReadOnlySet<T>
                           where TUnderlying : ISet<T>
            {
                public Set(TUnderlying underlying)
                : base(f_380_642_652_C<TUnderlying>(underlying))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(380, 579, 691);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(380, 579, 691);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 579, 691);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 579, 691);
                    }
                }

                public new bool Add(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 711, 832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 779, 813);

                        throw f_380_785_812();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 711, 832);

                        System.NotSupportedException
                        f_380_785_812()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 785, 812);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 711, 832);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 711, 832);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void ExceptWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 852, 990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 937, 971);

                        throw f_380_943_970();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 852, 990);

                        System.NotSupportedException
                        f_380_943_970()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 943, 970);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 852, 990);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 852, 990);
                    }
                }

                public void IntersectWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 1010, 1151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 1098, 1132);

                        throw f_380_1104_1131();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 1010, 1151);

                        System.NotSupportedException
                        f_380_1104_1131()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 1104, 1131);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 1010, 1151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 1010, 1151);
                    }
                }

                public bool IsProperSubsetOf(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 1171, 1323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 1262, 1304);

                        return f_380_1269_1303(Underlying, other);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 1171, 1323);

                        bool
                        f_380_1269_1303(TUnderlying
                        this_param, System.Collections.Generic.IEnumerable<T>
                        other)
                        {
                            var return_v = this_param.IsProperSubsetOf(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 1269, 1303);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 1171, 1323);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 1171, 1323);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool IsProperSupersetOf(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 1343, 1499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 1436, 1480);

                        return f_380_1443_1479(Underlying, other);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 1343, 1499);

                        bool
                        f_380_1443_1479(TUnderlying
                        this_param, System.Collections.Generic.IEnumerable<T>
                        other)
                        {
                            var return_v = this_param.IsProperSupersetOf(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 1443, 1479);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 1343, 1499);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 1343, 1499);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool IsSubsetOf(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 1519, 1659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 1604, 1640);

                        return f_380_1611_1639(Underlying, other);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 1519, 1659);

                        bool
                        f_380_1611_1639(TUnderlying
                        this_param, System.Collections.Generic.IEnumerable<T>
                        other)
                        {
                            var return_v = this_param.IsSubsetOf(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 1611, 1639);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 1519, 1659);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 1519, 1659);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool IsSupersetOf(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 1679, 1823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 1766, 1804);

                        return f_380_1773_1803(Underlying, other);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 1679, 1823);

                        bool
                        f_380_1773_1803(TUnderlying
                        this_param, System.Collections.Generic.IEnumerable<T>
                        other)
                        {
                            var return_v = this_param.IsSupersetOf(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 1773, 1803);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 1679, 1823);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 1679, 1823);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool Overlaps(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 1843, 1979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 1926, 1960);

                        return f_380_1933_1959(Underlying, other);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 1843, 1979);

                        bool
                        f_380_1933_1959(TUnderlying
                        this_param, System.Collections.Generic.IEnumerable<T>
                        other)
                        {
                            var return_v = this_param.Overlaps(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 1933, 1959);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 1843, 1979);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 1843, 1979);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool SetEquals(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 1999, 2137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 2083, 2118);

                        return f_380_2090_2117(Underlying, other);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 1999, 2137);

                        bool
                        f_380_2090_2117(TUnderlying
                        this_param, System.Collections.Generic.IEnumerable<T>
                        other)
                        {
                            var return_v = this_param.SetEquals(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 2090, 2117);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 1999, 2137);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 1999, 2137);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void SymmetricExceptWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 2157, 2304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 2251, 2285);

                        throw f_380_2257_2284();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 2157, 2304);

                        System.NotSupportedException
                        f_380_2257_2284()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 2257, 2284);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 2157, 2304);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 2157, 2304);
                    }
                }

                public void UnionWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(380, 2324, 2461);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(380, 2408, 2442);

                        throw f_380_2414_2441();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(380, 2324, 2461);

                        System.NotSupportedException
                        f_380_2414_2441()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(380, 2414, 2441);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(380, 2324, 2461);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 2324, 2461);
                    }
                }

                static Set()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(380, 412, 2476);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(380, 412, 2476);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(380, 412, 2476);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(380, 412, 2476);

                static TUnderlying
                f_380_642_652_C<TUnderlying>(TUnderlying
                i) where TUnderlying : ISet<T>

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(380, 579, 691);
                    return return_v;
                }

            }
        }
    }
}
