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
                    return Underlying.IsProperSubsetOf(other);
                }

                public bool IsProperSupersetOf(IEnumerable<T> other)
                {
                    return Underlying.IsProperSupersetOf(other);
                }

                public bool IsSubsetOf(IEnumerable<T> other)
                {
                    return Underlying.IsSubsetOf(other);
                }

                public bool IsSupersetOf(IEnumerable<T> other)
                {
                    return Underlying.IsSupersetOf(other);
                }

                public bool Overlaps(IEnumerable<T> other)
                {
                    return Underlying.Overlaps(other);
                }

                public bool SetEquals(IEnumerable<T> other)
                {
                    return Underlying.SetEquals(other);
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
