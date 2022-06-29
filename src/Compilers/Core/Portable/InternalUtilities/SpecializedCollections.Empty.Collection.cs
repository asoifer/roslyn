// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static partial class SpecializedCollections
    {
        private static partial class Empty
        {
            internal class Collection<T> : Enumerable<T>, ICollection<T>
            {
                public static readonly ICollection<T> Instance;

                protected Collection()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(369, 605, 665);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(369, 605, 665);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 605, 665);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 605, 665);
                    }
                }

                public void Add(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(369, 685, 802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(369, 749, 783);

                        throw f_369_755_782();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(369, 685, 802);

                        System.NotSupportedException
                        f_369_755_782()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(369, 755, 782);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 685, 802);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 685, 802);
                    }
                }

                public void Clear()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(369, 822, 935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(369, 882, 916);

                        throw f_369_888_915();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(369, 822, 935);

                        System.NotSupportedException
                        f_369_888_915()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(369, 888, 915);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 822, 935);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 822, 935);
                    }
                }

                public bool Contains(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(369, 955, 1056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(369, 1024, 1037);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(369, 955, 1056);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 955, 1056);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 955, 1056);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void CopyTo(T[] array, int arrayIndex)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(369, 1076, 1159);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(369, 1076, 1159);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 1076, 1159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 1076, 1159);
                    }
                }

                public int Count
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(369, 1196, 1200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(369, 1199, 1200);
                            return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(369, 1196, 1200);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 1196, 1200);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 1196, 1200);
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
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(369, 1244, 1251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(369, 1247, 1251);
                            return true; DynAbs.Tracing.TraceSender.TraceExitMethod(369, 1244, 1251);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 1244, 1251);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 1244, 1251);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool Remove(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(369, 1272, 1392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(369, 1339, 1373);

                        throw f_369_1345_1372();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(369, 1272, 1392);

                        System.NotSupportedException
                        f_369_1345_1372()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(369, 1345, 1372);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(369, 1272, 1392);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 1272, 1392);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static Collection()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(369, 423, 1407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(369, 554, 584);
                    Instance = f_369_565_584<T>(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(369, 423, 1407);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 423, 1407);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(369, 423, 1407);

                static Roslyn.Utilities.SpecializedCollections.Empty.Collection<T>
                f_369_565_584<T>()
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Empty.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(369, 565, 584);
                    return return_v;
                }

            }

            static Empty()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(369, 364, 1418);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(369, 364, 1418);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(369, 364, 1418);
            }

        }
    }
}
