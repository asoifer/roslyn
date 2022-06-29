// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    internal static class EncodedStringText
    {
        private const int
        LargeObjectHeapLimitInChars = 40 * 1024
        ;

        private static readonly Encoding s_utf8Encoding;

        private static readonly Lazy<Encoding> s_fallbackEncoding;

        internal static Encoding CreateFallbackEncoding()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(15, 1222, 2064);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 1332, 1633) || true) && (f_15_1336_1370() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 1332, 1633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 1552, 1614);

                        f_15_1552_1613(f_15_1578_1612());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(15, 1332, 1633);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 1821, 1903);

                    return f_15_1828_1851(0) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding>(15, 1828, 1902) ?? f_15_1876_1902(1252));
                }
                catch (NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(15, 1932, 2053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 1994, 2038);

                    return f_15_2001_2037(name: "Latin1");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(15, 1932, 2053);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(15, 1222, 2064);

                System.Text.EncodingProvider
                f_15_1336_1370()
                {
                    var return_v = CodePagesEncodingProvider.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 1336, 1370);
                    return return_v;
                }


                System.Text.EncodingProvider
                f_15_1578_1612()
                {
                    var return_v = CodePagesEncodingProvider.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 1578, 1612);
                    return return_v;
                }


                int
                f_15_1552_1613(System.Text.EncodingProvider
                provider)
                {
                    Encoding.RegisterProvider(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 1552, 1613);
                    return 0;
                }


                System.Text.Encoding
                f_15_1828_1851(int
                codepage)
                {
                    var return_v = Encoding.GetEncoding(codepage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 1828, 1851);
                    return return_v;
                }


                System.Text.Encoding
                f_15_1876_1902(int
                codepage)
                {
                    var return_v = Encoding.GetEncoding(codepage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 1876, 1902);
                    return return_v;
                }


                System.Text.Encoding
                f_15_2001_2037(string
                name)
                {
                    var return_v = Encoding.GetEncoding(name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 2001, 2037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 1222, 2064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 1222, 2064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SourceText Create(Stream stream,
                    Encoding? defaultEncoding = null,
                    SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1,
                    bool canBeEmbedded = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(15, 3855, 4318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 4095, 4307);

                return f_15_4102_4306(stream, s_fallbackEncoding, defaultEncoding: defaultEncoding, checksumAlgorithm: checksumAlgorithm, canBeEmbedded: canBeEmbedded);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(15, 3855, 4318);

                Microsoft.CodeAnalysis.Text.SourceText
                f_15_4102_4306(System.IO.Stream
                stream, System.Lazy<System.Text.Encoding>
                getEncoding, System.Text.Encoding?
                defaultEncoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                canBeEmbedded)
                {
                    var return_v = Create(stream, getEncoding, defaultEncoding: defaultEncoding, checksumAlgorithm: checksumAlgorithm, canBeEmbedded: canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 4102, 4306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 3855, 4318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 3855, 4318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SourceText Create(Stream stream,
                    Lazy<Encoding> getEncoding,
                    Encoding? defaultEncoding = null,
                    SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1,
                    bool canBeEmbedded = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(15, 4330, 5522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 4611, 4646);

                f_15_4611_4645(stream != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 4660, 4695);

                f_15_4660_4694(f_15_4679_4693(stream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 4711, 4757);

                bool
                detectEncoding = defaultEncoding == null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 4771, 5158) || true) && (detectEncoding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 4771, 5158);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 4867, 4984);

                        return f_15_4874_4983(stream, s_utf8Encoding, checksumAlgorithm, throwIfBinaryDetected: false, canBeEmbedded: canBeEmbedded);
                    }
                    catch (DecoderFallbackException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(15, 5021, 5143);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(15, 5021, 5143);
                        // Fall back to Encoding.ASCII
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(15, 4771, 5158);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 5210, 5358);

                    return f_15_5217_5357(stream, defaultEncoding ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding?>(15, 5232, 5268) ?? f_15_5251_5268(getEncoding)), checksumAlgorithm, throwIfBinaryDetected: detectEncoding, canBeEmbedded: canBeEmbedded);
                }
                catch (DecoderFallbackException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(15, 5387, 5511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 5454, 5496);

                    throw f_15_5460_5495(f_15_5485_5494(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(15, 5387, 5511);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(15, 4330, 5522);

                int
                f_15_4611_4645(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 4611, 4645);
                    return 0;
                }


                bool
                f_15_4679_4693(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanRead;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 4679, 4693);
                    return return_v;
                }


                int
                f_15_4660_4694(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 4660, 4694);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_15_4874_4983(System.IO.Stream
                data, System.Text.Encoding
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                throwIfBinaryDetected, bool
                canBeEmbedded)
                {
                    var return_v = Decode(data, encoding, checksumAlgorithm, throwIfBinaryDetected: throwIfBinaryDetected, canBeEmbedded: canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 4874, 4983);
                    return return_v;
                }


                System.Text.Encoding
                f_15_5251_5268(System.Lazy<System.Text.Encoding>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 5251, 5268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_15_5217_5357(System.IO.Stream
                data, System.Text.Encoding
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                throwIfBinaryDetected, bool
                canBeEmbedded)
                {
                    var return_v = Decode(data, encoding, checksumAlgorithm, throwIfBinaryDetected: throwIfBinaryDetected, canBeEmbedded: canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 5217, 5357);
                    return return_v;
                }


                string
                f_15_5485_5494(System.Text.DecoderFallbackException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 5485, 5494);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_15_5460_5495(string
                message)
                {
                    var return_v = new System.IO.InvalidDataException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 5460, 5495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 4330, 5522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 4330, 5522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SourceText Decode(
                    Stream data,
                    Encoding encoding,
                    SourceHashAlgorithm checksumAlgorithm,
                    bool throwIfBinaryDetected = false,
                    bool canBeEmbedded = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(15, 6583, 7943);
                System.ArraySegment<byte> bytes = default(System.ArraySegment<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 6841, 6874);

                f_15_6841_6873(data != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 6888, 6925);

                f_15_6888_6924(encoding != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 6941, 7820) || true) && (f_15_6945_6957(data))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 6941, 7820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 6991, 7022);

                    f_15_6991_7021(data, 0, SeekOrigin.Begin);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 7126, 7805) || true) && (f_15_7130_7173(encoding, data) < LargeObjectHeapLimitInChars)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 7126, 7805);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 7245, 7786) || true) && (f_15_7249_7306(data, out bytes) && (DynAbs.Tracing.TraceSender.Expression_True(15, 7249, 7327) && bytes.Offset == 0) && (DynAbs.Tracing.TraceSender.Expression_True(15, 7249, 7352) && bytes.Array is object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 7245, 7786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 7402, 7763);

                            return f_15_7409_7762(bytes.Array, f_15_7491_7502(data), encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(15, 7245, 7786);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(15, 7126, 7805);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(15, 6941, 7820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 7836, 7932);

                return f_15_7843_7931(data, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(15, 6583, 7943);

                int
                f_15_6841_6873(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 6841, 6873);
                    return 0;
                }


                int
                f_15_6888_6924(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 6888, 6924);
                    return 0;
                }


                bool
                f_15_6945_6957(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 6945, 6957);
                    return return_v;
                }


                long
                f_15_6991_7021(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 6991, 7021);
                    return return_v;
                }


                int
                f_15_7130_7173(System.Text.Encoding
                encoding, System.IO.Stream
                stream)
                {
                    var return_v = encoding.GetMaxCharCountOrThrowIfHuge(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 7130, 7173);
                    return return_v;
                }


                bool
                f_15_7249_7306(System.IO.Stream
                data, out System.ArraySegment<byte>
                bytes)
                {
                    var return_v = TryGetBytesFromStream(data, out bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 7249, 7306);
                    return return_v;
                }


                long
                f_15_7491_7502(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 7491, 7502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_15_7409_7762(byte[]
                buffer, long
                length, System.Text.Encoding
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                throwIfBinaryDetected, bool
                canBeEmbedded)
                {
                    var return_v = SourceText.From(buffer, (int)length, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 7409, 7762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_15_7843_7931(System.IO.Stream
                stream, System.Text.Encoding
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                throwIfBinaryDetected, bool
                canBeEmbedded)
                {
                    var return_v = SourceText.From(stream, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 7843, 7931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 6583, 7943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 6583, 7943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetBytesFromStream(Stream data, out ArraySegment<byte> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(15, 8304, 9074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 8513, 8553);

                var
                memoryStream = data as MemoryStream
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 8567, 8684) || true) && (memoryStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 8567, 8684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 8625, 8669);

                    return f_15_8632_8668(memoryStream, out bytes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(15, 8567, 8684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 8791, 8827);

                var
                fileStream = data as FileStream
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 8841, 8968) || true) && (fileStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 8841, 8968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 8897, 8953);

                    return f_15_8904_8952(fileStream, out bytes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(15, 8841, 8968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 8984, 9036);

                bytes = f_15_8992_9035(f_15_9015_9034());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 9050, 9063);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(15, 8304, 9074);

                bool
                f_15_8632_8668(System.IO.MemoryStream
                this_param, out System.ArraySegment<byte>
                buffer)
                {
                    var return_v = this_param.TryGetBuffer(out buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 8632, 8668);
                    return return_v;
                }


                bool
                f_15_8904_8952(System.IO.FileStream
                stream, out System.ArraySegment<byte>
                bytes)
                {
                    var return_v = TryGetBytesFromFileStream(stream, out bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 8904, 8952);
                    return return_v;
                }


                byte[]
                f_15_9015_9034()
                {
                    var return_v = Array.Empty<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 9015, 9034);
                    return return_v;
                }


                System.ArraySegment<byte>
                f_15_8992_9035(byte[]
                array)
                {
                    var return_v = new System.ArraySegment<byte>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 8992, 9035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 8304, 9074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 8304, 9074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetBytesFromFileStream(FileStream stream,
                                                              out ArraySegment<byte> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(15, 9438, 11062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 9612, 9647);

                f_15_9612_9646(stream != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 9661, 9702);

                f_15_9661_9701(f_15_9680_9695(stream) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 9718, 9750);

                int
                length = (int)f_15_9736_9749(stream)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 9764, 9910) || true) && (length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(15, 9764, 9910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 9813, 9865);

                    bytes = f_15_9821_9864(f_15_9844_9863());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 9883, 9895);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(15, 9764, 9910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 10410, 10440);

                var
                buffer = new byte[length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 10814, 10875);

                var
                success = f_15_10828_10864(stream, buffer, 0, length) == length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 10891, 11020);

                bytes = (DynAbs.Tracing.TraceSender.Conditional_F1(15, 10899, 10906) || ((success
                && DynAbs.Tracing.TraceSender.Conditional_F2(15, 10926, 10956)) || DynAbs.Tracing.TraceSender.Conditional_F3(15, 10976, 11019))) ? f_15_10926_10956(buffer) : f_15_10976_11019(f_15_10999_11018());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 11036, 11051);

                return success;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(15, 9438, 11062);

                int
                f_15_9612_9646(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 9612, 9646);
                    return 0;
                }


                long
                f_15_9680_9695(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 9680, 9695);
                    return return_v;
                }


                int
                f_15_9661_9701(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 9661, 9701);
                    return 0;
                }


                long
                f_15_9736_9749(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(15, 9736, 9749);
                    return return_v;
                }


                byte[]
                f_15_9844_9863()
                {
                    var return_v = Array.Empty<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 9844, 9863);
                    return return_v;
                }


                System.ArraySegment<byte>
                f_15_9821_9864(byte[]
                array)
                {
                    var return_v = new System.ArraySegment<byte>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 9821, 9864);
                    return return_v;
                }


                int
                f_15_10828_10864(System.IO.FileStream
                stream, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = stream.TryReadAll(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 10828, 10864);
                    return return_v;
                }


                System.ArraySegment<byte>
                f_15_10926_10956(byte[]
                array)
                {
                    var return_v = new System.ArraySegment<byte>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 10926, 10956);
                    return return_v;
                }


                byte[]
                f_15_10999_11018()
                {
                    var return_v = Array.Empty<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 10999, 11018);
                    return return_v;
                }


                System.ArraySegment<byte>
                f_15_10976_11019(byte[]
                array)
                {
                    var return_v = new System.ArraySegment<byte>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 10976, 11019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 9438, 11062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 9438, 11062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal static class TestAccessor
        {
            internal static SourceText Create(Stream stream, Lazy<Encoding> getEncoding, Encoding defaultEncoding, SourceHashAlgorithm checksumAlgorithm, bool canBeEmbedded)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(15, 11312, 11411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 11315, 11411);
                    return f_15_11315_11411(stream, getEncoding, defaultEncoding, checksumAlgorithm, canBeEmbedded); DynAbs.Tracing.TraceSender.TraceExitMethod(15, 11312, 11411);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 11312, 11411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 11312, 11411);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.Text.SourceText
                f_15_11315_11411(System.IO.Stream
                stream, System.Lazy<System.Text.Encoding>
                getEncoding, System.Text.Encoding
                defaultEncoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                canBeEmbedded)
                {
                    var return_v = EncodedStringText.Create(stream, getEncoding, defaultEncoding, checksumAlgorithm, canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 11315, 11411);
                    return return_v;
                }

            }

            internal static SourceText Decode(Stream data, Encoding encoding, SourceHashAlgorithm checksumAlgorithm, bool throwIfBinaryDetected, bool canBeEmbedded)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(15, 11598, 11698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 11601, 11698);
                    return f_15_11601_11698(data, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded); DynAbs.Tracing.TraceSender.TraceExitMethod(15, 11598, 11698);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(15, 11598, 11698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 11598, 11698);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.Text.SourceText
                f_15_11601_11698(System.IO.Stream
                data, System.Text.Encoding
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                throwIfBinaryDetected, bool
                canBeEmbedded)
                {
                    var return_v = EncodedStringText.Decode(data, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 11601, 11698);
                    return return_v;
                }

            }

            static TestAccessor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(15, 11074, 11710);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(15, 11074, 11710);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 11074, 11710);
            }

        }

        static EncodedStringText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(15, 334, 11717);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 408, 447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 752, 852);
            s_utf8Encoding = f_15_769_852(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(15, 904, 952);
            s_fallbackEncoding = new(CreateFallbackEncoding); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(15, 334, 11717);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(15, 334, 11717);
        }


        static System.Text.UTF8Encoding
        f_15_769_852(bool
        encoderShouldEmitUTF8Identifier, bool
        throwOnInvalidBytes)
        {
            var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier, throwOnInvalidBytes: throwOnInvalidBytes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(15, 769, 852);
            return return_v;
        }

    }
}
