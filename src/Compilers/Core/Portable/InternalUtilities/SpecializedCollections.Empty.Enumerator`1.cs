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
            internal class Enumerator<T> : Enumerator, IEnumerator<T>
            {
                public static new readonly IEnumerator<T> Instance;

                protected Enumerator()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(374, 592, 652);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(374, 592, 652);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(374, 592, 652);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(374, 592, 652);
                    }
                }

                public new T Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(374, 693, 733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(374, 696, 733);
                            throw f_374_702_733(); DynAbs.Tracing.TraceSender.TraceExitMethod(374, 693, 733);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(374, 693, 733);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(374, 693, 733);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public void Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(374, 754, 813);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(374, 754, 813);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(374, 754, 813);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(374, 754, 813);
                    }
                }

                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(374, 409, 828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(374, 541, 571);
                    Instance = f_374_552_571<T>(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(374, 409, 828);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(374, 409, 828);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(374, 409, 828);

                static Roslyn.Utilities.SpecializedCollections.Empty.Enumerator<T>
                f_374_552_571<T>()
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Empty.Enumerator<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(374, 552, 571);
                    return return_v;
                }


                System.InvalidOperationException
                f_374_702_733()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(374, 702, 733);
                    return return_v;
                }

            }
        }
    }
}
