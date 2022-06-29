// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.IO;

namespace Roslyn.Utilities
{
    internal static class StreamExtensions
    {
        public static int TryReadAll(
                    this Stream stream,
                    byte[] buffer,
                    int offset,
                    int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(384, 966, 2191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 1487, 1511);

                f_384_1487_1510(count > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 1527, 1546);

                int
                totalBytesRead
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 1560, 1574);

                int
                bytesRead
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 1593, 1611)
   , totalBytesRead = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 1588, 2144) || true) && (totalBytesRead < count)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 1637, 1664)
   , totalBytesRead += bytesRead, DynAbs.Tracing.TraceSender.TraceExitCondition(384, 1588, 2144))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(384, 1588, 2144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 1863, 2026);

                        bytesRead = f_384_1875_2025(stream, buffer, offset + totalBytesRead, count - totalBytesRead);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2044, 2129) || true) && (bytesRead == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(384, 2044, 2129);
                            DynAbs.Tracing.TraceSender.TraceBreak(384, 2104, 2110);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(384, 2044, 2129);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(384, 1, 557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(384, 1, 557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2158, 2180);

                return totalBytesRead;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(384, 966, 2191);

                int
                f_384_1487_1510(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 1487, 1510);
                    return 0;
                }


                int
                f_384_1875_2025(System.IO.Stream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 1875, 2025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(384, 966, 2191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(384, 966, 2191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static byte[] ReadAllBytes(this Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(384, 2337, 3021);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2415, 2870) || true) && (f_384_2419_2433(stream))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(384, 2415, 2870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2467, 2513);

                    long
                    length = f_384_2481_2494(stream) - f_384_2497_2512(stream)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2531, 2634) || true) && (length == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(384, 2531, 2634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2588, 2615);

                        return f_384_2595_2614();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(384, 2531, 2634);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2654, 2684);

                    var
                    buffer = new byte[length]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2702, 2766);

                    int
                    actualLength = f_384_2721_2765(stream, buffer, 0, f_384_2751_2764(buffer))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2784, 2823);

                    f_384_2784_2822(ref buffer, actualLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2841, 2855);

                    return buffer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(384, 2415, 2870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2886, 2924);

                var
                memoryStream = f_384_2905_2923()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2938, 2966);

                f_384_2938_2965(stream, memoryStream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(384, 2980, 3010);

                return f_384_2987_3009(memoryStream);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(384, 2337, 3021);

                bool
                f_384_2419_2433(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(384, 2419, 2433);
                    return return_v;
                }


                long
                f_384_2481_2494(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(384, 2481, 2494);
                    return return_v;
                }


                long
                f_384_2497_2512(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(384, 2497, 2512);
                    return return_v;
                }


                byte[]
                f_384_2595_2614()
                {
                    var return_v = Array.Empty<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 2595, 2614);
                    return return_v;
                }


                int
                f_384_2751_2764(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(384, 2751, 2764);
                    return return_v;
                }


                int
                f_384_2721_2765(System.IO.Stream
                stream, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = stream.TryReadAll(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 2721, 2765);
                    return return_v;
                }


                int
                f_384_2784_2822(ref byte[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 2784, 2822);
                    return 0;
                }


                System.IO.MemoryStream
                f_384_2905_2923()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 2905, 2923);
                    return return_v;
                }


                int
                f_384_2938_2965(System.IO.Stream
                this_param, System.IO.MemoryStream
                destination)
                {
                    this_param.CopyTo((System.IO.Stream)destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 2938, 2965);
                    return 0;
                }


                byte[]
                f_384_2987_3009(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(384, 2987, 3009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(384, 2337, 3021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(384, 2337, 3021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StreamExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(384, 305, 3028);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(384, 305, 3028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(384, 305, 3028);
        }

    }
}
