// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class Empty
        {
            internal class Dictionary<TKey, TValue>
#nullable disable
                           // Note: if the interfaces we implement weren't oblivious, then we'd warn about the `[MaybeNullWhen(false)] out TValue value` parameter below
                           // We can remove this once `IDictionary` is annotated with `[MaybeNullWhen(false)]`
                           : Collection<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>
#nullable enable
                where TKey : notnull
            {
                public static new readonly Dictionary<TKey, TValue> Instance;

                private Dictionary()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(371, 1065, 1123);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(371, 1065, 1123);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1065, 1123);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1065, 1123);
                    }
                }

                public void Add(TKey key, TValue value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 1143, 1276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 1223, 1257);

                        throw f_371_1229_1256();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(371, 1143, 1276);

                        System.NotSupportedException
                        f_371_1229_1256()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(371, 1229, 1256);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1143, 1276);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1143, 1276);
                    }
                }

                public bool ContainsKey(TKey key)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 1296, 1402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 1370, 1383);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(371, 1296, 1402);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1296, 1402);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1296, 1402);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public ICollection<TKey> Keys
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 1492, 1600);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 1544, 1577);

                            return Collection<TKey>.Instance;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(371, 1492, 1600);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1422, 1619);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1422, 1619);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 1696, 1703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 1699, 1703);
                            return f_371_1699_1703(); DynAbs.Tracing.TraceSender.TraceExitMethod(371, 1696, 1703);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1696, 1703);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1696, 1703);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 1783, 1792);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 1786, 1792);
                            return f_371_1786_1792(); DynAbs.Tracing.TraceSender.TraceExitMethod(371, 1783, 1792);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1783, 1792);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1783, 1792);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool Remove(TKey key)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 1813, 1935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 1882, 1916);

                        throw f_371_1888_1915();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(371, 1813, 1935);

                        System.NotSupportedException
                        f_371_1888_1915()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(371, 1888, 1915);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1813, 1935);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1813, 1935);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool TryGetValue(TKey key, [MaybeNullWhen(returnValue: false)] out TValue value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 1955, 2154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 2083, 2100);

                        value = default!;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 2122, 2135);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(371, 1955, 2154);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 1955, 2154);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 1955, 2154);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public ICollection<TValue> Values
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 2248, 2358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 2300, 2335);

                            return Collection<TValue>.Instance;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(371, 2248, 2358);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 2174, 2377);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 2174, 2377);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public TValue this[TKey key]
                {

                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 2466, 2575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 2518, 2552);

                            throw f_371_2524_2551();
                            DynAbs.Tracing.TraceSender.TraceExitMethod(371, 2466, 2575);

                            System.NotSupportedException
                            f_371_2524_2551()
                            {
                                var return_v = new System.NotSupportedException();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(371, 2524, 2551);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 2466, 2575);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 2466, 2575);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    set
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(371, 2599, 2708);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 2651, 2685);

                            throw f_371_2657_2684();
                            DynAbs.Tracing.TraceSender.TraceExitMethod(371, 2599, 2708);

                            System.NotSupportedException
                            f_371_2657_2684()
                            {
                                var return_v = new System.NotSupportedException();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(371, 2657, 2684);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(371, 2599, 2708);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 2599, 2708);
                        }
                    }
                }

                static Dictionary()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(371, 449, 2742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(371, 1028, 1044);
                    Instance = new(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(371, 449, 2742);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(371, 449, 2742);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(371, 449, 2742);

                System.Collections.Generic.ICollection<TKey>
                f_371_1699_1703()
                {
                    var return_v = Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(371, 1699, 1703);
                    return return_v;
                }


                System.Collections.Generic.ICollection<TValue>
                f_371_1786_1792()
                {
                    var return_v = Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(371, 1786, 1792);
                    return return_v;
                }

            }
        }
    }
}
