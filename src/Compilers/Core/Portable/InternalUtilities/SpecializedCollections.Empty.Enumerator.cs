// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class Empty
        {
            internal class Enumerator : IEnumerator
            {
                public static readonly IEnumerator Instance;

                protected Enumerator()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(373, 556, 616);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(373, 556, 616);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(373, 556, 616);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(373, 556, 616);
                    }
                }

                public object? Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(373, 659, 699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(373, 662, 699);
                            throw f_373_668_699(); DynAbs.Tracing.TraceSender.TraceExitMethod(373, 659, 699);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(373, 659, 699);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(373, 659, 699);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(373, 720, 815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(373, 783, 796);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(373, 720, 815);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(373, 720, 815);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(373, 720, 815);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(373, 835, 952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(373, 895, 933);

                        throw f_373_901_932();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(373, 835, 952);

                        System.InvalidOperationException
                        f_373_901_932()
                        {
                            var return_v = new System.InvalidOperationException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(373, 901, 932);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(373, 835, 952);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(373, 835, 952);
                    }
                }

                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(373, 401, 967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(373, 508, 535);
                    Instance = f_373_519_535(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(373, 401, 967);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(373, 401, 967);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(373, 401, 967);

                static Roslyn.Utilities.SpecializedCollections.Empty.Enumerator
                f_373_519_535()
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Empty.Enumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(373, 519, 535);
                    return return_v;
                }


                System.InvalidOperationException
                f_373_668_699()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(373, 668, 699);
                    return return_v;
                }

            }
        }
    }
}
