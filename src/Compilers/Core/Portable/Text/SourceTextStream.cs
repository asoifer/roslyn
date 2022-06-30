// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed class SourceTextStream : Stream
    {
        private readonly SourceText _source;

        private readonly Encoding _encoding;

        private readonly Encoder _encoder;

        private readonly int _minimumTargetBufferCount;

        private int _position;

        private int _sourceOffset;

        private readonly char[] _charBuffer;

        private int _bufferOffset;

        private int _bufferUnreadChars;

        private bool _preambleWritten;

        private static readonly Encoding s_utf8EncodingWithNoBOM;

        public SourceTextStream(SourceText source, int bufferSize = 2048, bool useDefaultEncodingIfNull = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(723, 1112, 1793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 556, 563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 600, 609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 645, 653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 687, 712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 735, 744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 767, 780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 815, 826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 849, 862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 885, 903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 927, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1241, 1307);

                f_723_1241_1306(f_723_1254_1269(source) != null || (DynAbs.Tracing.TraceSender.Expression_False(723, 1254, 1305) || useDefaultEncodingIfNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1323, 1340);

                _source = source;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1354, 1409);

                _encoding = f_723_1366_1381(source) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding?>(723, 1366, 1408) ?? s_utf8EncodingWithNoBOM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1423, 1457);

                _encoder = f_723_1434_1456(_encoding);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1471, 1539);

                _minimumTargetBufferCount = f_723_1499_1538(_encoding, charCount: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1553, 1571);

                _sourceOffset = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1585, 1599);

                _position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1613, 1674);

                _charBuffer = new char[f_723_1636_1672(bufferSize, f_723_1657_1671(_source))];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1688, 1706);

                _bufferOffset = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1720, 1743);

                _bufferUnreadChars = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1757, 1782);

                _preambleWritten = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(723, 1112, 1793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 1112, 1793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 1112, 1793);
            }
        }

        public override bool CanRead
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 1858, 1878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1864, 1876);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(723, 1858, 1878);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 1805, 1889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 1805, 1889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool CanSeek
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 1954, 1975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 1960, 1973);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(723, 1954, 1975);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 1901, 1986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 1901, 1986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool CanWrite
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 2052, 2073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 2058, 2071);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(723, 2052, 2073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 1998, 2084);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 1998, 2084);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 2096, 2194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 2149, 2183);

                throw f_723_2155_2182();
                DynAbs.Tracing.TraceSender.TraceExitMethod(723, 2096, 2194);

                System.NotSupportedException
                f_723_2155_2182()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 2155, 2182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 2096, 2194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 2096, 2194);
            }
        }

        public override long Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 2258, 2300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 2264, 2298);

                    throw f_723_2270_2297();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(723, 2258, 2300);

                    System.NotSupportedException
                    f_723_2270_2297()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 2270, 2297);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 2206, 2311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 2206, 2311);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override long Position
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 2377, 2402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 2383, 2400);

                    return _position;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(723, 2377, 2402);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 2323, 2469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 2323, 2469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 2416, 2458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 2422, 2456);

                    throw f_723_2428_2455();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(723, 2416, 2458);

                    System.NotSupportedException
                    f_723_2428_2455()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 2428, 2455);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 2323, 2469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 2323, 2469);
                }
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 2481, 4124);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 2568, 3026) || true) && (count < _minimumTargetBufferCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(723, 2568, 3026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 2887, 3011);

                    throw f_723_2893_3010($"{nameof(count)} must be greater than or equal to {_minimumTargetBufferCount}", nameof(count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(723, 2568, 3026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3042, 3068);

                int
                originalCount = count
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3084, 3291) || true) && (!_preambleWritten)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(723, 3084, 3291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3139, 3195);

                    int
                    bytesWritten = f_723_3158_3194(this, buffer, offset, count)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3213, 3236);

                    offset += bytesWritten;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3254, 3276);

                    count -= bytesWritten;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(723, 3084, 3291);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3307, 4011) || true) && (count >= _minimumTargetBufferCount && (DynAbs.Tracing.TraceSender.Expression_True(723, 3314, 3378) && _position < f_723_3364_3378(_source)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(723, 3307, 4011);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3412, 3513) || true) && (_bufferUnreadChars == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(723, 3412, 3513);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3481, 3494);

                            f_723_3481_3493(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(723, 3412, 3513);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3533, 3558);

                        int
                        charsUsed
                        = default(int),
                        bytesUsed
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3576, 3589);

                        bool
                        ignored
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3607, 3785);

                        f_723_3607_3784(_encoder, _charBuffer, _bufferOffset, _bufferUnreadChars, buffer, offset, count, flush: false, charsUsed: out charsUsed, bytesUsed: out bytesUsed, completed: out ignored);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3803, 3826);

                        _position += charsUsed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3844, 3871);

                        _bufferOffset += charsUsed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3889, 3921);

                        _bufferUnreadChars -= charsUsed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3939, 3959);

                        offset += bytesUsed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 3977, 3996);

                        count -= bytesUsed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(723, 3307, 4011);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(723, 3307, 4011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(723, 3307, 4011);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4084, 4113);

                return originalCount - count;
                DynAbs.Tracing.TraceSender.TraceExitMethod(723, 2481, 4124);

                System.ArgumentException
                f_723_2893_3010(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 2893, 3010);
                    return return_v;
                }


                int
                f_723_3158_3194(Microsoft.CodeAnalysis.Text.SourceTextStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.WritePreamble(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 3158, 3194);
                    return return_v;
                }


                int
                f_723_3364_3378(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(723, 3364, 3378);
                    return return_v;
                }


                int
                f_723_3481_3493(Microsoft.CodeAnalysis.Text.SourceTextStream
                this_param)
                {
                    this_param.FillBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 3481, 3493);
                    return 0;
                }


                int
                f_723_3607_3784(System.Text.Encoder
                this_param, char[]
                chars, int
                charIndex, int
                charCount, byte[]
                bytes, int
                byteIndex, int
                byteCount, bool
                flush, out int
                charsUsed, out int
                bytesUsed, out bool
                completed)
                {
                    this_param.Convert(chars, charIndex, charCount, bytes, byteIndex, byteCount, flush: flush, out charsUsed, out bytesUsed, out completed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 3607, 3784);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 2481, 4124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 2481, 4124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int WritePreamble(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 4136, 4579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4224, 4248);

                _preambleWritten = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4262, 4309);

                byte[]
                preambleBytes = f_723_4285_4308(_encoding)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4323, 4406) || true) && (preambleBytes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(723, 4323, 4406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4382, 4391);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(723, 4323, 4406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4422, 4473);

                int
                length = f_723_4435_4472(count, f_723_4451_4471(preambleBytes))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4487, 4540);

                f_723_4487_4539(preambleBytes, 0, buffer, offset, length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4554, 4568);

                return length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(723, 4136, 4579);

                byte[]
                f_723_4285_4308(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.GetPreamble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 4285, 4308);
                    return return_v;
                }


                int
                f_723_4451_4471(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(723, 4451, 4471);
                    return return_v;
                }


                int
                f_723_4435_4472(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 4435, 4472);
                    return return_v;
                }


                int
                f_723_4487_4539(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 4487, 4539);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 4136, 4579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 4136, 4579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FillBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 4591, 4926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4641, 4720);

                int
                charsToRead = f_723_4659_4719(f_723_4668_4686(_charBuffer), f_723_4688_4702(_source) - _sourceOffset)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4734, 4793);

                f_723_4734_4792(_source, _sourceOffset, _charBuffer, 0, charsToRead);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4807, 4836);

                _sourceOffset += charsToRead;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4850, 4868);

                _bufferOffset = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 4882, 4915);

                _bufferUnreadChars = charsToRead;
                DynAbs.Tracing.TraceSender.TraceExitMethod(723, 4591, 4926);

                int
                f_723_4668_4686(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(723, 4668, 4686);
                    return return_v;
                }


                int
                f_723_4688_4702(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(723, 4688, 4702);
                    return return_v;
                }


                int
                f_723_4659_4719(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 4659, 4719);
                    return return_v;
                }


                int
                f_723_4734_4792(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 4734, 4792);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 4591, 4926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 4591, 4926);
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 4938, 5065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 5020, 5054);

                throw f_723_5026_5053();
                DynAbs.Tracing.TraceSender.TraceExitMethod(723, 4938, 5065);

                System.NotSupportedException
                f_723_5026_5053()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 5026, 5053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 4938, 5065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 4938, 5065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetLength(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 5077, 5189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 5144, 5178);

                throw f_723_5150_5177();
                DynAbs.Tracing.TraceSender.TraceExitMethod(723, 5077, 5189);

                System.NotSupportedException
                f_723_5150_5177()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 5150, 5177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 5077, 5189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 5077, 5189);
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(723, 5201, 5335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 5290, 5324);

                throw f_723_5296_5323();
                DynAbs.Tracing.TraceSender.TraceExitMethod(723, 5201, 5335);

                System.NotSupportedException
                f_723_5296_5323()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 5296, 5323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(723, 5201, 5335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 5201, 5335);
            }
        }

        static SourceTextStream()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(723, 464, 5342);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(723, 989, 1099);
            s_utf8EncodingWithNoBOM = f_723_1015_1099(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: false); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(723, 464, 5342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(723, 464, 5342);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(723, 464, 5342);

        static System.Text.UTF8Encoding
        f_723_1015_1099(bool
        encoderShouldEmitUTF8Identifier, bool
        throwOnInvalidBytes)
        {
            var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier, throwOnInvalidBytes: throwOnInvalidBytes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 1015, 1099);
            return return_v;
        }


        static System.Text.Encoding?
        f_723_1254_1269(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.Encoding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(723, 1254, 1269);
            return return_v;
        }


        static int
        f_723_1241_1306(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 1241, 1306);
            return 0;
        }


        static System.Text.Encoding?
        f_723_1366_1381(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.Encoding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(723, 1366, 1381);
            return return_v;
        }


        static System.Text.Encoder
        f_723_1434_1456(System.Text.Encoding
        this_param)
        {
            var return_v = this_param.GetEncoder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 1434, 1456);
            return return_v;
        }


        static int
        f_723_1499_1538(System.Text.Encoding
        this_param, int
        charCount)
        {
            var return_v = this_param.GetMaxByteCount(charCount: charCount);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 1499, 1538);
            return return_v;
        }


        static int
        f_723_1657_1671(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(723, 1657, 1671);
            return return_v;
        }


        static int
        f_723_1636_1672(int
        val1, int
        val2)
        {
            var return_v = Math.Min(val1, val2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(723, 1636, 1672);
            return return_v;
        }

    }
}
