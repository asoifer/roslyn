// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private static partial class ReadOnly
        {
            internal class Collection<TUnderlying, T> : Enumerable<TUnderlying, T>, ICollection<T>
                           where TUnderlying : ICollection<T>
            {
                public Collection(TUnderlying underlying)
                : base(f_377_660_670_C<TUnderlying>(underlying))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(377, 590, 709);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(377, 590, 709);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(377, 590, 709);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 590, 709);
                    }
                }

                public void Add(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(377, 729, 846);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(377, 793, 827);

                        throw f_377_799_826();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(377, 729, 846);

                        System.NotSupportedException
                        f_377_799_826()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(377, 799, 826);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(377, 729, 846);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 729, 846);
                    }
                }

                public void Clear()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(377, 866, 979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(377, 926, 960);

                        throw f_377_932_959();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(377, 866, 979);

                        System.NotSupportedException
                        f_377_932_959()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(377, 932, 959);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(377, 866, 979);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 866, 979);
                    }
                }

                public bool Contains(T item)
                {
                    return this.Underlying.Contains(item);
                }

                public void CopyTo(T[] array, int arrayIndex)
                {
                    this.Underlying.CopyTo(array, arrayIndex);
                }

                public int Count
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(377, 1369, 1473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(377, 1421, 1450);

                            return f_377_1428_1449(this.Underlying);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(377, 1369, 1473);

                            int
                            f_377_1428_1449(TUnderlying
                            this_param)
                            {
                                var return_v = this_param.Count;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(377, 1428, 1449);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(377, 1312, 1492);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 1312, 1492);
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
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(377, 1535, 1542);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(377, 1538, 1542);
                            return true; DynAbs.Tracing.TraceSender.TraceExitMethod(377, 1535, 1542);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(377, 1535, 1542);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 1535, 1542);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool Remove(T item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(377, 1563, 1683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(377, 1630, 1664);

                        throw f_377_1636_1663();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(377, 1563, 1683);

                        System.NotSupportedException
                        f_377_1636_1663()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(377, 1636, 1663);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(377, 1563, 1683);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 1563, 1683);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static Collection()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(377, 419, 1698);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(377, 419, 1698);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 419, 1698);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(377, 419, 1698);

                static TUnderlying
                f_377_660_670_C<TUnderlying>(TUnderlying
                i) where TUnderlying : ICollection<T>

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(377, 590, 709);
                    return return_v;
                }

            }

            static ReadOnly()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(377, 357, 1709);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(377, 357, 1709);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(377, 357, 1709);
            }

        }
    }
}
