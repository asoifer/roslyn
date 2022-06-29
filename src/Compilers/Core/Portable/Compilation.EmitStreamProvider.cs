// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.IO;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class Compilation
    {
        internal abstract class EmitStreamProvider
        {
            public abstract Stream? Stream { get; }

            protected abstract Stream? CreateStream(DiagnosticBag diagnostics);

            public Stream? GetOrCreateStream(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(7, 2046, 2196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(7, 2138, 2181);

                    return f_7_2145_2151() ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.IO.Stream?>(7, 2145, 2180) ?? f_7_2155_2180(this, diagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(7, 2046, 2196);

                    System.IO.Stream?
                    f_7_2145_2151()
                    {
                        var return_v = Stream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(7, 2145, 2151);
                        return return_v;
                    }


                    System.IO.Stream?
                    f_7_2155_2180(Microsoft.CodeAnalysis.Compilation.EmitStreamProvider
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateStream(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(7, 2155, 2180);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(7, 2046, 2196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(7, 2046, 2196);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EmitStreamProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(7, 1139, 2207);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(7, 1139, 2207);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(7, 1139, 2207);
            }


            static EmitStreamProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(7, 1139, 2207);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(7, 1139, 2207);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(7, 1139, 2207);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(7, 1139, 2207);
        }
        internal sealed class SimpleEmitStreamProvider : EmitStreamProvider
        {
            private readonly Stream _stream;

            internal SimpleEmitStreamProvider(Stream stream)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(7, 2359, 2525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(7, 2335, 2342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(7, 2440, 2475);

                    f_7_2440_2474(stream != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(7, 2493, 2510);

                    _stream = stream;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(7, 2359, 2525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(7, 2359, 2525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(7, 2359, 2525);
                }
            }

            public override Stream Stream
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(7, 2571, 2581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(7, 2574, 2581);
                        return _stream; DynAbs.Tracing.TraceSender.TraceExitMethod(7, 2571, 2581);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(7, 2571, 2581);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(7, 2571, 2581);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override Stream CreateStream(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(7, 2598, 2748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(7, 2696, 2733);

                    throw f_7_2702_2732();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(7, 2598, 2748);

                    System.Exception
                    f_7_2702_2732()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(7, 2702, 2732);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(7, 2598, 2748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(7, 2598, 2748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SimpleEmitStreamProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(7, 2219, 2759);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(7, 2219, 2759);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(7, 2219, 2759);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(7, 2219, 2759);

            static int
            f_7_2440_2474(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(7, 2440, 2474);
                return 0;
            }

        }
    }
}
