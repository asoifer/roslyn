// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class Empty
        {
            internal class Set<T> : Collection<T>, ISet<T>, IReadOnlySet<T>
            {
                public static new readonly Set<T> Instance;

                protected Set()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(376, 576, 629);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(376, 576, 629);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 576, 629);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 576, 629);
                    }
                }

                public new bool Add(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 649, 770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 717, 751);

                        throw f_376_723_750();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 649, 770);

                        System.NotSupportedException
                        f_376_723_750()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(376, 723, 750);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 649, 770);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 649, 770);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void ExceptWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 790, 928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 875, 909);

                        throw f_376_881_908();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 790, 928);

                        System.NotSupportedException
                        f_376_881_908()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(376, 881, 908);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 790, 928);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 790, 928);
                    }
                }

                public void IntersectWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 948, 1089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 1036, 1070);

                        throw f_376_1042_1069();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 948, 1089);

                        System.NotSupportedException
                        f_376_1042_1069()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(376, 1042, 1069);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 948, 1089);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 948, 1089);
                    }
                }

                public bool IsProperSubsetOf(IEnumerable<T> other)
                {
                    return !other.IsEmpty();
                }

                public bool IsProperSupersetOf(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 1263, 1388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 1356, 1369);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 1263, 1388);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 1263, 1388);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 1263, 1388);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool IsSubsetOf(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 1408, 1524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 1493, 1505);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 1408, 1524);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 1408, 1524);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 1408, 1524);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool IsSupersetOf(IEnumerable<T> other)
                {
                    return other.IsEmpty();
                }

                public bool Overlaps(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 1693, 1808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 1776, 1789);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 1693, 1808);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 1693, 1808);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 1693, 1808);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool SetEquals(IEnumerable<T> other)
                {
                    return other.IsEmpty();
                }

                public void SymmetricExceptWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 1974, 2121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 2068, 2102);

                        throw f_376_2074_2101();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 1974, 2121);

                        System.NotSupportedException
                        f_376_2074_2101()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(376, 2074, 2101);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 1974, 2121);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 1974, 2121);
                    }
                }

                public void UnionWith(IEnumerable<T> other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(376, 2141, 2278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 2225, 2259);

                        throw f_376_2231_2258();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(376, 2141, 2278);

                        System.NotSupportedException
                        f_376_2231_2258()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(376, 2231, 2258);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(376, 2141, 2278);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 2141, 2278);
                    }
                }

                static Set()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(376, 409, 2293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(376, 539, 555);
                    Instance = f_376_550_555<T>();

                    static Roslyn.Utilities.SpecializedCollections.Empty.Set<T>
f_376_550_555<T>()
                    {
                        var return_v = new Roslyn.Utilities.SpecializedCollections.Empty.Set<T>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(376, 550, 555);
                        return return_v;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(376, 409, 2293);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(376, 409, 2293);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(376, 409, 2293);
            }
        }
    }
}
