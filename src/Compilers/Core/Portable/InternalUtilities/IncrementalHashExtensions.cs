// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Roslyn.Utilities
{
    internal static class IncrementalHashExtensions
    {
        internal static void AppendData(this IncrementalHash hash, IEnumerable<Blob> blobs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(336, 431, 658);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(336, 539, 647);
                    foreach (var blob in f_336_560_565_I(blobs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(336, 539, 647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(336, 599, 632);

                        f_336_599_631(hash, blob.GetBytes());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(336, 539, 647);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(336, 1, 109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(336, 1, 109);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(336, 431, 658);

                int
                f_336_599_631(System.Security.Cryptography.IncrementalHash
                this_param, System.ArraySegment<byte>
                data)
                {
                    this_param.AppendData((System.ReadOnlySpan<byte>)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(336, 599, 631);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>
                f_336_560_565_I(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(336, 560, 565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(336, 431, 658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(336, 431, 658);
            }
        }

        internal static void AppendData(this IncrementalHash hash, IEnumerable<ArraySegment<byte>> blobs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(336, 670, 900);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(336, 792, 889);
                    foreach (var blob in f_336_813_818_I(blobs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(336, 792, 889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(336, 852, 874);

                        f_336_852_873(hash, blob);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(336, 792, 889);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(336, 1, 98);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(336, 1, 98);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(336, 670, 900);

                int
                f_336_852_873(System.Security.Cryptography.IncrementalHash
                this_param, System.ArraySegment<byte>
                data)
                {
                    this_param.AppendData((System.ReadOnlySpan<byte>)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(336, 852, 873);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.ArraySegment<byte>>
                f_336_813_818_I(System.Collections.Generic.IEnumerable<System.ArraySegment<byte>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(336, 813, 818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(336, 670, 900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(336, 670, 900);
            }
        }

        internal static void AppendData(this IncrementalHash hash, ArraySegment<byte> segment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(336, 912, 1096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(336, 1023, 1085);

                f_336_1023_1084(hash, segment.Array, segment.Offset, segment.Count);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(336, 912, 1096);

                int
                f_336_1023_1084(System.Security.Cryptography.IncrementalHash
                this_param, byte[]?
                data, int
                offset, int
                count)
                {
                    this_param.AppendData(data, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(336, 1023, 1084);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(336, 912, 1096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(336, 912, 1096);
            }
        }

        static IncrementalHashExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(336, 367, 1103);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(336, 367, 1103);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(336, 367, 1103);
        }

    }
}
