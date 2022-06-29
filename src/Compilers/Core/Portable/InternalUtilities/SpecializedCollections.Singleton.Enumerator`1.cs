// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static partial class SpecializedCollections
    {
        private static partial class Singleton
        {
            internal class Enumerator<T> : IEnumerator<T>
            {
                private readonly T _loneValue;

                private bool _moveNextCalled;

                public Enumerator(T value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(382, 614, 765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 536, 546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 578, 593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 681, 700);

                        _loneValue = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 722, 746);

                        _moveNextCalled = false;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(382, 614, 765);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(382, 614, 765);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(382, 614, 765);
                    }
                }

                public T Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(382, 802, 815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 805, 815);
                            return _loneValue; DynAbs.Tracing.TraceSender.TraceExitMethod(382, 802, 815);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(382, 802, 815);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(382, 802, 815);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                object? IEnumerator.Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(382, 864, 877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 867, 877);
                            return _loneValue; DynAbs.Tracing.TraceSender.TraceExitMethod(382, 864, 877);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(382, 864, 877);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(382, 864, 877);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public void Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(382, 898, 957);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(382, 898, 957);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(382, 898, 957);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(382, 898, 957);
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(382, 977, 1250);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 1040, 1194) || true) && (!_moveNextCalled)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(382, 1040, 1194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 1110, 1133);

                            _moveNextCalled = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 1159, 1171);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(382, 1040, 1194);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 1218, 1231);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(382, 977, 1250);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(382, 977, 1250);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(382, 977, 1250);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(382, 1270, 1373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(382, 1330, 1354);

                        _moveNextCalled = false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(382, 1270, 1373);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(382, 1270, 1373);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(382, 1270, 1373);
                    }
                }

                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(382, 439, 1388);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(382, 439, 1388);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(382, 439, 1388);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(382, 439, 1388);
            }
        }
    }
}
