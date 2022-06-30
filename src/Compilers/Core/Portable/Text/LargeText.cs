// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed class LargeText : SourceText
    {
        internal const int
        ChunkSize = SourceText.LargeObjectHeapLimitInChars
        ;

        private readonly ImmutableArray<char[]> _chunks;

        private readonly int[] _chunkStartOffsets;

        private readonly int _length;

        private readonly Encoding? _encodingOpt;

        internal LargeText(ImmutableArray<char[]> chunks, Encoding? encodingOpt, ImmutableArray<byte> checksum, SourceHashAlgorithm checksumAlgorithm, ImmutableArray<byte> embeddedTextBlob)
        : base(f_715_1349_1357_C(checksum), checksumAlgorithm, embeddedTextBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(715, 1147, 1788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1027, 1045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1077, 1084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1122, 1134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1420, 1437);

                _chunks = chunks;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1451, 1478);

                _encodingOpt = encodingOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1492, 1536);

                _chunkStartOffsets = new int[chunks.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1552, 1567);

                int
                offset = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1590, 1595);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1581, 1744) || true) && (i < chunks.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1616, 1619)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(715, 1581, 1744))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 1581, 1744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1653, 1684);

                        _chunkStartOffsets[i] = offset;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1702, 1729);

                        offset += f_715_1712_1728(chunks[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(715, 1, 164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(715, 1, 164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 1760, 1777);

                _length = offset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(715, 1147, 1788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 1147, 1788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 1147, 1788);
            }
        }

        internal LargeText(ImmutableArray<char[]> chunks, Encoding? encodingOpt, SourceHashAlgorithm checksumAlgorithm)
        : this(f_715_1932_1938_C(chunks), encodingOpt, default(ImmutableArray<byte>), checksumAlgorithm, default(ImmutableArray<byte>))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(715, 1800, 2055);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(715, 1800, 2055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 1800, 2055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 1800, 2055);
            }
        }

        internal static SourceText Decode(Stream stream, Encoding encoding, SourceHashAlgorithm checksumAlgorithm, bool throwIfBinaryDetected, bool canBeEmbedded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(715, 2067, 3608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2246, 2279);

                f_715_2246_2278(stream, 0, SeekOrigin.Begin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2295, 2327);

                long
                longLength = f_715_2313_2326(stream)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2341, 2475) || true) && (longLength == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 2341, 2475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2394, 2460);

                    return f_715_2401_2459(string.Empty, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(715, 2341, 2475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2491, 2565);

                var
                maxCharRemainingGuess = f_715_2519_2564(encoding, stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2579, 2638);

                f_715_2579_2637(longLength > 0 && (DynAbs.Tracing.TraceSender.Expression_True(715, 2592, 2636) && longLength <= int.MaxValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2704, 2733);

                int
                length = (int)longLength
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2749, 3597);
                using (var
                reader = f_715_2769_2896(stream, encoding, detectEncodingFromByteOrderMarks: true, bufferSize: f_715_2856_2878(length, 4096), leaveOpen: true)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 2930, 3022);

                    var
                    chunks = f_715_2943_3021(reader, maxCharRemainingGuess, throwIfBinaryDetected)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 3283, 3343);

                    var
                    checksum = f_715_3298_3342(stream, checksumAlgorithm)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 3361, 3464);

                    var
                    embeddedTextBlob = (DynAbs.Tracing.TraceSender.Conditional_F1(715, 3384, 3397) || ((canBeEmbedded && DynAbs.Tracing.TraceSender.Conditional_F2(715, 3400, 3431)) || DynAbs.Tracing.TraceSender.Conditional_F3(715, 3434, 3463))) ? f_715_3400_3431(stream) : default(ImmutableArray<byte>)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 3482, 3582);

                    return f_715_3489_3581(chunks, f_715_3511_3533(reader), checksum, checksumAlgorithm, embeddedTextBlob);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(715, 2749, 3597);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(715, 2067, 3608);

                long
                f_715_2246_2278(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 2246, 2278);
                    return return_v;
                }


                long
                f_715_2313_2326(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 2313, 2326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_715_2401_2459(string
                text, System.Text.Encoding
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = SourceText.From(text, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 2401, 2459);
                    return return_v;
                }


                int
                f_715_2519_2564(System.Text.Encoding
                encoding, System.IO.Stream
                stream)
                {
                    var return_v = encoding.GetMaxCharCountOrThrowIfHuge(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 2519, 2564);
                    return return_v;
                }


                int
                f_715_2579_2637(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 2579, 2637);
                    return 0;
                }


                int
                f_715_2856_2878(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 2856, 2878);
                    return return_v;
                }


                System.IO.StreamReader
                f_715_2769_2896(System.IO.Stream
                stream, System.Text.Encoding
                encoding, bool
                detectEncodingFromByteOrderMarks, int
                bufferSize, bool
                leaveOpen)
                {
                    var return_v = new System.IO.StreamReader(stream, encoding, detectEncodingFromByteOrderMarks: detectEncodingFromByteOrderMarks, bufferSize: bufferSize, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 2769, 2896);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<char[]>
                f_715_2943_3021(System.IO.StreamReader
                reader, int
                maxCharRemainingGuess, bool
                throwIfBinaryDetected)
                {
                    var return_v = ReadChunksFromTextReader((System.IO.TextReader)reader, maxCharRemainingGuess, throwIfBinaryDetected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 2943, 3021);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_715_3298_3342(System.IO.Stream
                stream, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = CalculateChecksum(stream, algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 3298, 3342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_715_3400_3431(System.IO.Stream
                stream)
                {
                    var return_v = EmbeddedText.CreateBlob(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 3400, 3431);
                    return return_v;
                }


                System.Text.Encoding
                f_715_3511_3533(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.CurrentEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 3511, 3533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LargeText
                f_715_3489_3581(System.Collections.Immutable.ImmutableArray<char[]>
                chunks, System.Text.Encoding
                encodingOpt, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                embeddedTextBlob)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LargeText(chunks, encodingOpt, checksum, checksumAlgorithm, embeddedTextBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 3489, 3581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 2067, 3608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 2067, 3608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SourceText Decode(TextReader reader, int length, Encoding? encodingOpt, SourceHashAlgorithm checksumAlgorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(715, 3620, 4189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 3771, 3904) || true) && (length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 3771, 3904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 3820, 3889);

                    return f_715_3827_3888(string.Empty, encodingOpt, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(715, 3771, 3904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 4017, 4101);

                var
                chunks = f_715_4030_4100(reader, length, throwIfBinaryDetected: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 4117, 4178);

                return f_715_4124_4177(chunks, encodingOpt, checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(715, 3620, 4189);

                Microsoft.CodeAnalysis.Text.SourceText
                f_715_3827_3888(string
                text, System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = SourceText.From(text, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 3827, 3888);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<char[]>
                f_715_4030_4100(System.IO.TextReader
                reader, int
                maxCharRemainingGuess, bool
                throwIfBinaryDetected)
                {
                    var return_v = ReadChunksFromTextReader(reader, maxCharRemainingGuess, throwIfBinaryDetected: throwIfBinaryDetected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 4030, 4100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LargeText
                f_715_4124_4177(System.Collections.Immutable.ImmutableArray<char[]>
                chunks, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LargeText(chunks, encodingOpt, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 4124, 4177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 3620, 4189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 3620, 4189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<char[]> ReadChunksFromTextReader(TextReader reader, int maxCharRemainingGuess, bool throwIfBinaryDetected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(715, 4201, 5741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 4362, 4447);

                var
                chunks = f_715_4375_4446(1 + maxCharRemainingGuess / ChunkSize)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 4463, 5679) || true) && (f_715_4470_4483(reader) != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 4463, 5679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 4523, 4553);

                        var
                        nextChunkSize = ChunkSize
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 4571, 4987) || true) && (maxCharRemainingGuess < ChunkSize)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 4571, 4987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 4911, 4968);

                            nextChunkSize = f_715_4927_4967(maxCharRemainingGuess - 64, 64);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 4571, 4987);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5007, 5046);

                        char[]
                        chunk = new char[nextChunkSize]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5066, 5123);

                        int
                        charsRead = f_715_5082_5122(reader, chunk, 0, f_715_5109_5121(chunk))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5141, 5226) || true) && (charsRead == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 5141, 5226);
                            DynAbs.Tracing.TraceSender.TraceBreak(715, 5201, 5207);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 5141, 5226);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5246, 5281);

                        maxCharRemainingGuess -= charsRead;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5301, 5425) || true) && (charsRead < f_715_5317_5329(chunk))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 5301, 5425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5371, 5406);

                            f_715_5371_5405(ref chunk, charsRead);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 5301, 5425);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5488, 5626) || true) && (throwIfBinaryDetected && (DynAbs.Tracing.TraceSender.Expression_True(715, 5492, 5532) && f_715_5517_5532(chunk)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 5488, 5626);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5574, 5607);

                            throw f_715_5580_5606();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 5488, 5626);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5646, 5664);

                        f_715_5646_5663(
                                        chunks, chunk);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(715, 4463, 5679);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(715, 4463, 5679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(715, 4463, 5679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 5695, 5730);

                return f_715_5702_5729(chunks);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(715, 4201, 5741);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char[]>
                f_715_4375_4446(int
                capacity)
                {
                    var return_v = ArrayBuilder<char[]>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 4375, 4446);
                    return return_v;
                }


                int
                f_715_4470_4483(System.IO.TextReader
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 4470, 4483);
                    return return_v;
                }


                int
                f_715_4927_4967(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 4927, 4967);
                    return return_v;
                }


                int
                f_715_5109_5121(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 5109, 5121);
                    return return_v;
                }


                int
                f_715_5082_5122(System.IO.TextReader
                this_param, char[]
                buffer, int
                index, int
                count)
                {
                    var return_v = this_param.ReadBlock(buffer, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 5082, 5122);
                    return return_v;
                }


                int
                f_715_5317_5329(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 5317, 5329);
                    return return_v;
                }


                int
                f_715_5371_5405(ref char[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 5371, 5405);
                    return 0;
                }


                bool
                f_715_5517_5532(char[]
                chunk)
                {
                    var return_v = IsBinary(chunk);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 5517, 5532);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_715_5580_5606()
                {
                    var return_v = new System.IO.InvalidDataException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 5580, 5606);
                    return return_v;
                }


                int
                f_715_5646_5663(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char[]>
                this_param, char[]
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 5646, 5663);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<char[]>
                f_715_5702_5729(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char[]>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 5702, 5729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 4201, 5741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 4201, 5741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsBinary(char[] chunk)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(715, 5997, 6575);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6152, 6157);
                    // PERF: We can advance two chars at a time unless we find a NUL.
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6143, 6535) || true) && (i < f_715_6163_6175(chunk))
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(715, 6143, 6535))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 6143, 6535);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6210, 6520) || true) && (chunk[i] == '\0')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 6210, 6520);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6272, 6381) || true) && (chunk[i - 1] == '\0')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 6272, 6381);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6346, 6358);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(715, 6272, 6381);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6405, 6412);

                            i += 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 6210, 6520);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 6210, 6520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6494, 6501);

                            i += 2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 6210, 6520);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(715, 1, 393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(715, 1, 393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6551, 6564);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(715, 5997, 6575);

                int
                f_715_6163_6175(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 6163, 6175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 5997, 6575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 5997, 6575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int GetIndexFromPosition(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(715, 6587, 6852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6740, 6792);

                int
                idx = f_715_6750_6791(_chunkStartOffsets, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6806, 6841);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(715, 6813, 6821) || ((idx >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(715, 6824, 6827)) || DynAbs.Tracing.TraceSender.Conditional_F3(715, 6830, 6840))) ? idx : (~idx - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(715, 6587, 6852);

                int
                f_715_6750_6791(int[]
                array, int
                value)
                {
                    var return_v = array.BinarySearch(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 6750, 6791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 6587, 6852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 6587, 6852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override char this[int position]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(715, 6928, 7088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 6964, 7003);

                    int
                    i = f_715_6972_7002(this, position)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7021, 7073);

                    return _chunks[i][position - _chunkStartOffsets[i]];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(715, 6928, 7088);

                    int
                    f_715_6972_7002(Microsoft.CodeAnalysis.Text.LargeText
                    this_param, int
                    position)
                    {
                        var return_v = this_param.GetIndexFromPosition(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 6972, 7002);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 6928, 7088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 6928, 7088);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Encoding? Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(715, 7146, 7161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7149, 7161);
                    return _encodingOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(715, 7146, 7161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 7146, 7161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 7146, 7161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(715, 7201, 7211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7204, 7211);
                    return _length; DynAbs.Tracing.TraceSender.TraceExitMethod(715, 7201, 7211);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 7201, 7211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 7201, 7211);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(715, 7224, 8125);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7346, 7416) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 7346, 7416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7394, 7401);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(715, 7346, 7416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7432, 7483);

                int
                chunkIndex = f_715_7449_7482(this, sourceIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7497, 7565);

                int
                chunkStartOffset = sourceIndex - _chunkStartOffsets[chunkIndex]
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7579, 8114) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 7579, 8114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7624, 7656);

                        var
                        chunk = _chunks[chunkIndex]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7674, 7741);

                        int
                        charsToCopy = f_715_7692_7740(f_715_7701_7713(chunk) - chunkStartOffset, count)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7759, 7839);

                        f_715_7759_7838(chunk, chunkStartOffset, destination, destinationIndex, charsToCopy);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7857, 7878);

                        count -= charsToCopy;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7896, 7977) || true) && (count <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 7896, 7977);
                            DynAbs.Tracing.TraceSender.TraceBreak(715, 7952, 7958);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 7896, 7977);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 7997, 8029);

                        destinationIndex += charsToCopy;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8047, 8068);

                        chunkStartOffset = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8086, 8099);

                        chunkIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(715, 7579, 8114);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(715, 7579, 8114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(715, 7579, 8114);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(715, 7224, 8125);

                int
                f_715_7449_7482(Microsoft.CodeAnalysis.Text.LargeText
                this_param, int
                position)
                {
                    var return_v = this_param.GetIndexFromPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 7449, 7482);
                    return return_v;
                }


                int
                f_715_7701_7713(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 7701, 7713);
                    return return_v;
                }


                int
                f_715_7692_7740(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 7692, 7740);
                    return return_v;
                }


                int
                f_715_7759_7838(char[]
                sourceArray, int
                sourceIndex, char[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 7759, 7838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 7224, 8125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 7224, 8125);
            }
        }

        public override void Write(TextWriter writer, TextSpan span, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(715, 8137, 9636);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8288, 8453) || true) && (span.Start < 0 || (DynAbs.Tracing.TraceSender.Expression_False(715, 8292, 8330) || span.Start > _length) || (DynAbs.Tracing.TraceSender.Expression_False(715, 8292, 8352) || span.End > _length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 8288, 8453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8386, 8438);

                    throw f_715_8392_8437(nameof(span));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(715, 8288, 8453);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8469, 8493);

                int
                count = span.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8507, 8577) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 8507, 8577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8555, 8562);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(715, 8507, 8577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8593, 8637);

                var
                chunkWriter = writer as LargeTextWriter
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8653, 8703);

                int
                chunkIndex = f_715_8670_8702(this, span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8717, 8784);

                int
                chunkStartOffset = span.Start - _chunkStartOffsets[chunkIndex]
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8798, 9625) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 8798, 9625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8843, 8892);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8910, 8942);

                        var
                        chunk = _chunks[chunkIndex]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 8960, 9028);

                        int
                        charsToWrite = f_715_8979_9027(f_715_8988_9000(chunk) - chunkStartOffset, count)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 9048, 9397) || true) && (chunkWriter != null && (DynAbs.Tracing.TraceSender.Expression_True(715, 9052, 9096) && chunkStartOffset == 0) && (DynAbs.Tracing.TraceSender.Expression_True(715, 9052, 9128) && charsToWrite == f_715_9116_9128(chunk)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 9048, 9397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 9213, 9244);

                            f_715_9213_9243(                    // reuse entire chunk
                                                chunkWriter, chunk);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 9048, 9397);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 9048, 9397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 9326, 9378);

                            f_715_9326_9377(writer, chunk, chunkStartOffset, charsToWrite);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 9048, 9397);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 9417, 9439);

                        count -= charsToWrite;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 9457, 9538) || true) && (count <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(715, 9457, 9538);
                            DynAbs.Tracing.TraceSender.TraceBreak(715, 9513, 9519);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(715, 9457, 9538);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 9558, 9579);

                        chunkStartOffset = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 9597, 9610);

                        chunkIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(715, 8798, 9625);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(715, 8798, 9625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(715, 8798, 9625);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(715, 8137, 9636);

                System.ArgumentOutOfRangeException
                f_715_8392_8437(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 8392, 8437);
                    return return_v;
                }


                int
                f_715_8670_8702(Microsoft.CodeAnalysis.Text.LargeText
                this_param, int
                position)
                {
                    var return_v = this_param.GetIndexFromPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 8670, 8702);
                    return return_v;
                }


                int
                f_715_8988_9000(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 8988, 9000);
                    return return_v;
                }


                int
                f_715_8979_9027(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 8979, 9027);
                    return return_v;
                }


                int
                f_715_9116_9128(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 9116, 9128);
                    return return_v;
                }


                int
                f_715_9213_9243(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param, char[]
                chunk)
                {
                    this_param.AppendChunk(chunk);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 9213, 9243);
                    return 0;
                }


                int
                f_715_9326_9377(System.IO.TextWriter
                this_param, char[]
                buffer, int
                index, int
                count)
                {
                    this_param.Write(buffer, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 9326, 9377);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 8137, 9636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 8137, 9636);
            }
        }

        protected override TextLineCollection GetLinesCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(715, 9965, 10098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 10042, 10087);

                return f_715_10049_10086(this, f_715_10068_10085(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(715, 9965, 10098);

                int[]
                f_715_10068_10085(Microsoft.CodeAnalysis.Text.LargeText
                this_param)
                {
                    var return_v = this_param.ParseLineStarts();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 10068, 10085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText.LineInfo
                f_715_10049_10086(Microsoft.CodeAnalysis.Text.LargeText
                text, int[]
                lineStarts)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.SourceText.LineInfo((Microsoft.CodeAnalysis.Text.SourceText)text, lineStarts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(715, 10049, 10086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(715, 9965, 10098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 9965, 10098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int[] ParseLineStarts()
        {
            var position = 0;
            var index = 0;
            var lastCr = -1;
            var arrayBuilder = ArrayBuilder<int>.GetInstance();

            // The following loop goes through every character in the text. It is highly
            // performance critical, and thus inlines knowledge about common line breaks
            // and non-line breaks.
            foreach (var chunk in _chunks)
            {
                foreach (var c in chunk)
                {
                    index++;

                    // Common case - ASCII & not a line break
                    const uint bias = '\r' + 1;
                    if (unchecked(c - bias) <= (127 - bias))
                    {
                        continue;
                    }

                    switch (c)
                    {
                        case '\r':
                            lastCr = index;
                            goto line_break;

                        case '\n':
                            // Assumes that the only 2-char line break sequence is CR+LF
                            if (lastCr == (index - 1))
                            {
                                position = index;
                                break;
                            }

                            goto line_break;

                        case '\u0085':
                        case '\u2028':
                        case '\u2029':
line_break:
                            arrayBuilder.Add(position);
                            position = index;
                            break;
                    }
                }
            }

            // Create a start for the final line.  
            arrayBuilder.Add(position);
            return arrayBuilder.ToArrayAndFree();
        }

        static LargeText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(715, 640, 11998);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(715, 806, 856);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(715, 640, 11998);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(715, 640, 11998);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(715, 640, 11998);

        static int
        f_715_1712_1728(char[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(715, 1712, 1728);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<byte>
        f_715_1349_1357_C(System.Collections.Immutable.ImmutableArray<byte>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(715, 1147, 1788);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<char[]>
        f_715_1932_1938_C(System.Collections.Immutable.ImmutableArray<char[]>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(715, 1800, 2055);
            return return_v;
        }

    }
}
