// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class Empty
        {
            internal static class BoxedImmutableArray<T>
            {
                public static readonly IReadOnlyList<T> Instance;

                static BoxedImmutableArray()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(375, 446, 661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(375, 611, 645);
                    Instance = ImmutableArray<T>.Empty; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(375, 446, 661);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 446, 661);
                }

            }
            internal class List<T> : Collection<T>, IList<T>, IReadOnlyList<T>
            {
                public static new readonly List<T> Instance;

                protected List()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(375, 848, 902);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(375, 848, 902);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(375, 848, 902);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 848, 902);
                    }
                }

                public int IndexOf(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(375, 922, 1018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(375, 989, 999);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(375, 922, 1018);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(375, 922, 1018);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 922, 1018);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void Insert(int index, T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(375, 1038, 1169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(375, 1116, 1150);

                        throw f_375_1122_1149();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(375, 1038, 1169);

                        System.NotSupportedException
                        f_375_1122_1149()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(375, 1122, 1149);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(375, 1038, 1169);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 1038, 1169);
                    }
                }

                public void RemoveAt(int index)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(375, 1189, 1314);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(375, 1261, 1295);

                        throw f_375_1267_1294();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(375, 1189, 1314);

                        System.NotSupportedException
                        f_375_1267_1294()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(375, 1267, 1294);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(375, 1189, 1314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 1189, 1314);
                    }
                }

                public T this[int index]
                {

                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(375, 1399, 1527);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(375, 1451, 1504);

                            throw f_375_1457_1503(nameof(index));
                            DynAbs.Tracing.TraceSender.TraceExitMethod(375, 1399, 1527);

                            System.ArgumentOutOfRangeException
                            f_375_1457_1503(string
                            paramName)
                            {
                                var return_v = new System.ArgumentOutOfRangeException(paramName);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(375, 1457, 1503);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(375, 1399, 1527);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 1399, 1527);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    set
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(375, 1551, 1660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(375, 1603, 1637);

                            throw f_375_1609_1636();
                            DynAbs.Tracing.TraceSender.TraceExitMethod(375, 1551, 1660);

                            System.NotSupportedException
                            f_375_1609_1636()
                            {
                                var return_v = new System.NotSupportedException();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(375, 1609, 1636);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(375, 1551, 1660);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 1551, 1660);
                        }
                    }
                }

                static List()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(375, 677, 1694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(375, 811, 827);
                    Instance = f_375_822_827<T>();

                    static Roslyn.Utilities.SpecializedCollections.Empty.List<T>
f_375_822_827<T>()
                    {
                        var return_v = new Roslyn.Utilities.SpecializedCollections.Empty.List<T>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(375, 822, 827);
                        return return_v;
                    }

                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(375, 677, 1694);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(375, 677, 1694);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(375, 677, 1694);
            }
        }
    }
}
