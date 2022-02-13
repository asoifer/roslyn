// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Roslyn.Test.PdbUtilities
{
    public class Token2SourceLineExporter
    {
        private class PdbSource
        {
            internal readonly string name;

            internal Guid doctype;

            internal Guid language;

            internal Guid vendor;

            internal PdbSource(string name, Guid doctype, Guid language, Guid vendor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 801, 1062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 672, 676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 907, 924);

                    this.name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 942, 965);

                    this.doctype = doctype;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 983, 1008);

                    this.language = language;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1026, 1047);

                    this.vendor = vendor;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 801, 1062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 801, 1062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 801, 1062);
                }
            }

            static PdbSource()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 599, 1073);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 599, 1073);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 599, 1073);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 599, 1073);
        }
        private class PdbTokenLine
        {
            internal readonly uint token;

            internal readonly uint file_id;

            internal readonly uint line;

            internal readonly uint column;

            internal readonly uint endLine;

            internal readonly uint endColumn;

            internal PdbSource sourceFile;

            internal PdbTokenLine/*?*/ nextLine;

            internal PdbTokenLine(uint token, uint file_id, uint line, uint column, uint endLine, uint endColumn)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 1498, 1867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1159, 1164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1202, 1209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1247, 1251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1289, 1295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1333, 1340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1378, 1387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1421, 1431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1473, 1481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1632, 1651);

                    this.token = token;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1669, 1692);

                    this.file_id = file_id;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1710, 1727);

                    this.line = line;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1745, 1766);

                    this.column = column;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1784, 1807);

                    this.endLine = endLine;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 1825, 1852);

                    this.endColumn = endColumn;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 1498, 1867);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 1498, 1867);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 1498, 1867);
                }
            }

            static PdbTokenLine()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 1085, 1878);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 1085, 1878);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 1085, 1878);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 1085, 1878);
        }
        private class BitAccess
        {
            internal BitAccess(int capacity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 1938, 2047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2185, 2192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3087, 3094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2003, 2032);

                    _buffer = new byte[capacity];
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 1938, 2047);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 1938, 2047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 1938, 2047);
                }
            }

            internal byte[] Buffer
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 2118, 2141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2124, 2139);

                        return _buffer;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 2118, 2141);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 2063, 2156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 2063, 2156);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private byte[] _buffer;

            internal void FillBuffer(Stream stream, int capacity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 2209, 2414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2295, 2317);

                    f_24009_2295_2316(this, capacity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2335, 2369);

                    f_24009_2335_2368(stream, _buffer, 0, capacity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2387, 2399);

                    _offset = 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 2209, 2414);

                    int
                    f_24009_2295_2316(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, int
                    capacity)
                    {
                        this_param.MinCapacity(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 2295, 2316);
                        return 0;
                    }


                    int
                    f_24009_2335_2368(System.IO.Stream
                    this_param, byte[]
                    buffer, int
                    offset, int
                    count)
                    {
                        var return_v = this_param.Read(buffer, offset, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 2335, 2368);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 2209, 2414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 2209, 2414);
                }
            }

            internal void Append(Stream stream, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 2430, 2911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2509, 2543);

                    int
                    newCapacity = _offset + count
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2561, 2806) || true) && (f_24009_2565_2579(_buffer) < newCapacity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 2561, 2806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2635, 2676);

                        byte[]
                        newBuffer = new byte[newCapacity]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2698, 2745);

                        f_24009_2698_2744(_buffer, newBuffer, f_24009_2729_2743(_buffer));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2767, 2787);

                        _buffer = newBuffer;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 2561, 2806);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2824, 2861);

                    f_24009_2824_2860(stream, _buffer, _offset, count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2879, 2896);

                    _offset += count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 2430, 2911);

                    int
                    f_24009_2565_2579(byte[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 2565, 2579);
                        return return_v;
                    }


                    int
                    f_24009_2729_2743(byte[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 2729, 2743);
                        return return_v;
                    }


                    int
                    f_24009_2698_2744(byte[]
                    sourceArray, byte[]
                    destinationArray, int
                    length)
                    {
                        Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 2698, 2744);
                        return 0;
                    }


                    int
                    f_24009_2824_2860(System.IO.Stream
                    this_param, byte[]
                    buffer, int
                    offset, int
                    count)
                    {
                        var return_v = this_param.Read(buffer, offset, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 2824, 2860);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 2430, 2911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 2430, 2911);
                }
            }

            internal int Position
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 2981, 3004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 2987, 3002);

                        return _offset;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 2981, 3004);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 2927, 3061);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 2927, 3061);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 3022, 3046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3028, 3044);

                        _offset = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 3022, 3046);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 2927, 3061);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 2927, 3061);
                    }
                }
            }

            private int _offset;

            internal void MinCapacity(int capacity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 3111, 3347);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3183, 3302) || true) && (f_24009_3187_3201(_buffer) < capacity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 3183, 3302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3254, 3283);

                        _buffer = new byte[capacity];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 3183, 3302);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3320, 3332);

                    _offset = 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 3111, 3347);

                    int
                    f_24009_3187_3201(byte[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 3187, 3201);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 3111, 3347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 3111, 3347);
                }
            }

            internal void Align(int alignment)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 3363, 3549);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3430, 3534) || true) && ((_offset % alignment) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 3430, 3534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3505, 3515);

                            _offset++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 3430, 3534);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 3430, 3534);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 3430, 3534);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 3363, 3549);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 3363, 3549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 3363, 3549);
                }
            }

            internal void ReadInt16(out short value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 3565, 3873);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3688, 3808);

                        value = (short)((_buffer[_offset + 0] & 0xFF) |
                                                                  (_buffer[_offset + 1] << 8));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 3845, 3858);

                    _offset += 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 3565, 3873);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 3565, 3873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 3565, 3873);
                }
            }

            internal void ReadInt8(out sbyte value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 3889, 4108);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 4011, 4043);

                        value = (sbyte)_buffer[_offset];
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 4080, 4093);

                    _offset += 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 3889, 4108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 3889, 4108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 3889, 4108);
                }
            }

            internal void ReadInt32(out int value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 4124, 4570);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 4245, 4505);

                        value = (int)((_buffer[_offset + 0] & 0xFF) |
                                                                (_buffer[_offset + 1] << 8) |
                                                                (_buffer[_offset + 2] << 16) |
                                                                (_buffer[_offset + 3] << 24));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 4542, 4555);

                    _offset += 4;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 4124, 4570);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 4124, 4570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 4124, 4570);
                }
            }

            internal void ReadInt64(out long value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 4586, 5371);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 4708, 5306);

                        value = (long)(((ulong)_buffer[_offset + 0] & 0xFF) |
                                                               ((ulong)_buffer[_offset + 1] << 8) |
                                                               ((ulong)_buffer[_offset + 2] << 16) |
                                                               ((ulong)_buffer[_offset + 3] << 24) |
                                                               ((ulong)_buffer[_offset + 4] << 32) |
                                                               ((ulong)_buffer[_offset + 5] << 40) |
                                                               ((ulong)_buffer[_offset + 6] << 48) |
                                                               ((ulong)_buffer[_offset + 7] << 56));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 5343, 5356);

                    _offset += 8;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 4586, 5371);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 4586, 5371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 4586, 5371);
                }
            }

            internal void ReadUInt16(out ushort value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 5387, 5699);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 5512, 5634);

                        value = (ushort)((_buffer[_offset + 0] & 0xFF) |
                                                                   (_buffer[_offset + 1] << 8));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 5671, 5684);

                    _offset += 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 5387, 5699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 5387, 5699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 5387, 5699);
                }
            }

            internal void ReadUInt8(out byte value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 5715, 5948);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 5837, 5883);

                        value = (byte)((_buffer[_offset + 0] & 0xFF));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 5920, 5933);

                    _offset += 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 5715, 5948);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 5715, 5948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 5715, 5948);
                }
            }

            internal void ReadUInt32(out uint value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 5964, 6416);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 6087, 6351);

                        value = (uint)((_buffer[_offset + 0] & 0xFF) |
                                                                 (_buffer[_offset + 1] << 8) |
                                                                 (_buffer[_offset + 2] << 16) |
                                                                 (_buffer[_offset + 3] << 24));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 6388, 6401);

                    _offset += 4;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 5964, 6416);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 5964, 6416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 5964, 6416);
                }
            }

            internal void ReadUInt64(out ulong value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 6432, 7220);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 6556, 7155);

                        value = (ulong)(((ulong)_buffer[_offset + 0] & 0xFF) |
                                                               ((ulong)_buffer[_offset + 1] << 8) |
                                                               ((ulong)_buffer[_offset + 2] << 16) |
                                                               ((ulong)_buffer[_offset + 3] << 24) |
                                                               ((ulong)_buffer[_offset + 4] << 32) |
                                                               ((ulong)_buffer[_offset + 5] << 40) |
                                                               ((ulong)_buffer[_offset + 6] << 48) |
                                                               ((ulong)_buffer[_offset + 7] << 56));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7192, 7205);

                    _offset += 8;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 6432, 7220);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 6432, 7220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 6432, 7220);
                }
            }

            internal void ReadInt32(int[] values)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 7236, 7445);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7315, 7320);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7306, 7430) || true) && (i < f_24009_7326_7339(values))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7341, 7344)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 7306, 7430))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 7306, 7430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7386, 7411);

                            f_24009_7386_7410(this, out values[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 125);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 125);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 7236, 7445);

                    int
                    f_24009_7326_7339(int[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 7326, 7339);
                        return return_v;
                    }


                    int
                    f_24009_7386_7410(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out int
                    value)
                    {
                        this_param.ReadInt32(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 7386, 7410);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 7236, 7445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 7236, 7445);
                }
            }

            internal void ReadUInt32(uint[] values)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 7461, 7673);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7542, 7547);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7533, 7658) || true) && (i < f_24009_7553_7566(values))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7568, 7571)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 7533, 7658))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 7533, 7658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7613, 7639);

                            f_24009_7613_7638(this, out values[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 126);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 126);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 7461, 7673);

                    int
                    f_24009_7553_7566(uint[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 7553, 7566);
                        return return_v;
                    }


                    int
                    f_24009_7613_7638(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out uint
                    value)
                    {
                        this_param.ReadUInt32(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 7613, 7638);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 7461, 7673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 7461, 7673);
                }
            }

            internal void ReadBytes(byte[] bytes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 7689, 7902);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7768, 7773);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7759, 7887) || true) && (i < f_24009_7779_7791(bytes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7793, 7796)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 7759, 7887))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 7759, 7887);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7838, 7868);

                            bytes[i] = _buffer[_offset++];
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 129);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 129);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 7689, 7902);

                    int
                    f_24009_7779_7791(byte[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 7779, 7791);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 7689, 7902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 7689, 7902);
                }
            }

            internal float ReadFloat()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 7918, 8110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 7977, 8032);

                    float
                    result = f_24009_7992_8031(_buffer, _offset)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8050, 8063);

                    _offset += 4;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8081, 8095);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 7918, 8110);

                    float
                    f_24009_7992_8031(byte[]
                    value, int
                    startIndex)
                    {
                        var return_v = BitConverter.ToSingle(value, startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 7992, 8031);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 7918, 8110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 7918, 8110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal double ReadDouble()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 8126, 8321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8187, 8243);

                    double
                    result = f_24009_8203_8242(_buffer, _offset)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8261, 8274);

                    _offset += 8;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8292, 8306);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 8126, 8321);

                    double
                    f_24009_8203_8242(byte[]
                    value, int
                    startIndex)
                    {
                        var return_v = BitConverter.ToDouble(value, startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 8203, 8242);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 8126, 8321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 8126, 8321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal decimal ReadDecimal()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 8337, 8521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8400, 8424);

                    int[]
                    bits = new int[4]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8442, 8463);

                    f_24009_8442_8462(this, bits);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8481, 8506);

                    return f_24009_8488_8505(bits);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 8337, 8521);

                    int
                    f_24009_8442_8462(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, int[]
                    values)
                    {
                        this_param.ReadInt32(values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 8442, 8462);
                        return 0;
                    }


                    decimal
                    f_24009_8488_8505(int[]
                    bits)
                    {
                        var return_v = new decimal(bits);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 8488, 8505);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 8337, 8521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 8337, 8521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void ReadBString(out string value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 8537, 8763);
                    ushort len = default(ushort);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8613, 8642);

                    f_24009_8613_8641(this, out len);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8660, 8715);

                    value = f_24009_8668_8714(f_24009_8668_8681(), _buffer, _offset, len);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8733, 8748);

                    _offset += len;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 8537, 8763);

                    int
                    f_24009_8613_8641(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out ushort
                    value)
                    {
                        this_param.ReadUInt16(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 8613, 8641);
                        return 0;
                    }


                    System.Text.Encoding
                    f_24009_8668_8681()
                    {
                        var return_v = Encoding.UTF8;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 8668, 8681);
                        return return_v;
                    }


                    string
                    f_24009_8668_8714(System.Text.Encoding
                    this_param, byte[]
                    bytes, int
                    index, ushort
                    count)
                    {
                        var return_v = this_param.GetString(bytes, index, (int)count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 8668, 8714);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 8537, 8763);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 8537, 8763);
                }
            }

            internal void ReadCString(out string value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 8779, 9145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8855, 8867);

                    int
                    len = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8885, 9020) || true) && (_offset + len < f_24009_8908_8922(_buffer) && (DynAbs.Tracing.TraceSender.Expression_True(24009, 8892, 8953) && _buffer[_offset + len] != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 8885, 9020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 8995, 9001);

                            len++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 8885, 9020);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 8885, 9020);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 8885, 9020);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9038, 9093);

                    value = f_24009_9046_9092(f_24009_9046_9059(), _buffer, _offset, len);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9111, 9130);

                    _offset += len + 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 8779, 9145);

                    int
                    f_24009_8908_8922(byte[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 8908, 8922);
                        return return_v;
                    }


                    System.Text.Encoding
                    f_24009_9046_9059()
                    {
                        var return_v = Encoding.UTF8;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 9046, 9059);
                        return return_v;
                    }


                    string
                    f_24009_9046_9092(System.Text.Encoding
                    this_param, byte[]
                    bytes, int
                    index, int
                    count)
                    {
                        var return_v = this_param.GetString(bytes, index, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9046, 9092);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 8779, 9145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 8779, 9145);
                }
            }

            internal void SkipCString(out string value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 9161, 9485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9237, 9249);

                    int
                    len = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9267, 9402) || true) && (_offset + len < f_24009_9290_9304(_buffer) && (DynAbs.Tracing.TraceSender.Expression_True(24009, 9274, 9335) && _buffer[_offset + len] != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 9267, 9402);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9377, 9383);

                            len++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 9267, 9402);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 9267, 9402);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 9267, 9402);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9420, 9439);

                    _offset += len + 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9457, 9470);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 9161, 9485);

                    int
                    f_24009_9290_9304(byte[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 9290, 9304);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 9161, 9485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 9161, 9485);
                }
            }

            internal void ReadGuid(out Guid guid)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 9501, 10101);
                    uint a = default(uint);
                    ushort b = default(ushort);
                    ushort c = default(ushort);
                    byte d = default(byte);
                    byte e = default(byte);
                    byte f = default(byte);
                    byte g = default(byte);
                    byte h = default(byte);
                    byte i = default(byte);
                    byte j = default(byte);
                    byte k = default(byte);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9573, 9595);

                    f_24009_9573_9594(this, out a);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9613, 9635);

                    f_24009_9613_9634(this, out b);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9653, 9675);

                    f_24009_9653_9674(this, out c);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9693, 9714);

                    f_24009_9693_9713(this, out d);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9732, 9753);

                    f_24009_9732_9752(this, out e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9771, 9792);

                    f_24009_9771_9791(this, out f);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9810, 9831);

                    f_24009_9810_9830(this, out g);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9849, 9870);

                    f_24009_9849_9869(this, out h);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9888, 9909);

                    f_24009_9888_9908(this, out i);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9927, 9948);

                    f_24009_9927_9947(this, out j);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 9966, 9987);

                    f_24009_9966_9986(this, out k);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10007, 10086);

                    guid = unchecked(f_24009_10024_10084(a, b, c, d, e, f, g, h, i, j, k));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 9501, 10101);

                    int
                    f_24009_9573_9594(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out uint
                    value)
                    {
                        this_param.ReadUInt32(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9573, 9594);
                        return 0;
                    }


                    int
                    f_24009_9613_9634(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out ushort
                    value)
                    {
                        this_param.ReadUInt16(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9613, 9634);
                        return 0;
                    }


                    int
                    f_24009_9653_9674(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out ushort
                    value)
                    {
                        this_param.ReadUInt16(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9653, 9674);
                        return 0;
                    }


                    int
                    f_24009_9693_9713(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9693, 9713);
                        return 0;
                    }


                    int
                    f_24009_9732_9752(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9732, 9752);
                        return 0;
                    }


                    int
                    f_24009_9771_9791(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9771, 9791);
                        return 0;
                    }


                    int
                    f_24009_9810_9830(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9810, 9830);
                        return 0;
                    }


                    int
                    f_24009_9849_9869(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9849, 9869);
                        return 0;
                    }


                    int
                    f_24009_9888_9908(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9888, 9908);
                        return 0;
                    }


                    int
                    f_24009_9927_9947(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9927, 9947);
                        return 0;
                    }


                    int
                    f_24009_9966_9986(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, out byte
                    value)
                    {
                        this_param.ReadUInt8(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 9966, 9986);
                        return 0;
                    }


                    System.Guid
                    f_24009_10024_10084(uint
                    a, ushort
                    b, ushort
                    c, byte
                    d, byte
                    e, byte
                    f, byte
                    g, byte
                    h, byte
                    i, byte
                    j, byte
                    k)
                    {
                        var return_v = new System.Guid((int)a, (short)b, (short)c, d, e, f, g, h, i, j, k);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 10024, 10084);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 9501, 10101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 9501, 10101);
                }
            }

            internal string ReadString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 10117, 10514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10178, 10190);

                    int
                    len = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10208, 10346) || true) && (_offset + len < f_24009_10231_10245(_buffer) && (DynAbs.Tracing.TraceSender.Expression_True(24009, 10215, 10276) && _buffer[_offset + len] != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 10208, 10346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10318, 10327);

                            len += 2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 10208, 10346);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 10208, 10346);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 10208, 10346);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10364, 10430);

                    string
                    result = f_24009_10380_10429(f_24009_10380_10396(), _buffer, _offset, len)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10448, 10467);

                    _offset += len + 2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10485, 10499);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 10117, 10514);

                    int
                    f_24009_10231_10245(byte[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 10231, 10245);
                        return return_v;
                    }


                    System.Text.Encoding
                    f_24009_10380_10396()
                    {
                        var return_v = Encoding.Unicode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 10380, 10396);
                        return return_v;
                    }


                    string
                    f_24009_10380_10429(System.Text.Encoding
                    this_param, byte[]
                    bytes, int
                    index, int
                    count)
                    {
                        var return_v = this_param.GetString(bytes, index, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 10380, 10429);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 10117, 10514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 10117, 10514);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BitAccess()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 1890, 10525);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 1890, 10525);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 1890, 10525);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 1890, 10525);
        }

        private struct BitSet
        {

            internal BitSet(BitAccess bits)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 10583, 10802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10647, 10673);

                    f_24009_10647_10672(bits, out _size);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10720, 10745);

                    _words = new uint[_size];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10763, 10787);

                    f_24009_10763_10786(bits, _words);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 10583, 10802);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 10583, 10802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 10583, 10802);
                }
            }

            internal bool IsSet(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 10818, 11052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10881, 10903);

                    int
                    word = index / 32
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10921, 10974) || true) && (word >= _size)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 10921, 10974);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10961, 10974);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 10921, 10974);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 10992, 11037);

                    return ((_words[word] & GetBit(index)) != 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 10818, 11052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 10818, 11052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 10818, 11052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static uint GetBit(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 11068, 11186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 11138, 11171);

                    return ((uint)1 << (index % 32));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 11068, 11186);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 11068, 11186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 11068, 11186);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool IsEmpty
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 11256, 11282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 11262, 11280);

                        return _size == 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 11256, 11282);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 11202, 11297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 11202, 11297);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private readonly int _size;

            private readonly uint[] _words;
            static BitSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 10537, 11396);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 10537, 11396);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 10537, 11396);
            }

            static int
            f_24009_10647_10672(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 10647, 10672);
                return 0;
            }


            static int
            f_24009_10763_10786(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, uint[]
            values)
            {
                this_param.ReadUInt32(values);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 10763, 10786);
                return 0;
            }

        }
        private class IntHashTable
        {
            private static readonly int[] s_primes;

            private static int GetPrime(int minSize)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 12071, 12629);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12144, 12274) || true) && (minSize < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 12144, 12274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12201, 12255);

                        throw f_24009_12207_12254("Arg_HTCapacityOverflow");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 12144, 12274);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12301, 12306);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12292, 12542) || true) && (i < f_24009_12312_12327(s_primes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12329, 12332)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 12292, 12542))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 12292, 12542);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12374, 12397);

                            int
                            size = s_primes[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12419, 12523) || true) && (size >= minSize)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 12419, 12523);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12488, 12500);

                                return size;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 12419, 12523);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 251);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 251);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 12560, 12614);

                    throw f_24009_12566_12613("Arg_HTCapacityOverflow");
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 12071, 12629);

                    System.ArgumentException
                    f_24009_12207_12254(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 12207, 12254);
                        return return_v;
                    }


                    int
                    f_24009_12312_12327(int[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 12312, 12327);
                        return return_v;
                    }


                    System.ArgumentException
                    f_24009_12566_12613(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 12566, 12613);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 12071, 12629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 12071, 12629);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private struct bucket
            {

                internal int key;

                internal int hash_coll;

                internal Object val;
                static bucket()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 12788, 13013);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 12788, 13013);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 12788, 13013);
                }
            }

            private bucket[] _buckets;

            private int _count;

            private int _occupancy;

            private int _loadsize;

            private readonly int _loadFactorPerc;

            private int _version;

            internal IntHashTable()
            : this(f_24009_13695_13696_C(0), 100)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 13647, 13732);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 13647, 13732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 13647, 13732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 13647, 13732);
                }
            }

            internal IntHashTable(int capacity, int loadFactorPerc)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 13748, 14627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13046, 13054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13146, 13152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13253, 13263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13292, 13301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13337, 13352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13397, 13405);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13836, 13967) || true) && (capacity < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 13836, 13967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13875, 13967);

                        throw f_24009_13881_13966(nameof(capacity), "ArgumentOutOfRange_NeedNonNegNum");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 13836, 13967);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 13985, 14167) || true) && (!(loadFactorPerc >= 10 && (DynAbs.Tracing.TraceSender.Expression_True(24009, 13991, 14036) && loadFactorPerc <= 100)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 13985, 14167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14060, 14167);

                        throw f_24009_14066_14166(nameof(loadFactorPerc), "ArgumentOutOfRange_IntHashTableLoadFactor");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 13985, 14167);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14274, 14320);

                    _loadFactorPerc = (loadFactorPerc * 72) / 100;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14340, 14399);

                    int
                    hashsize = f_24009_14355_14398((capacity / _loadFactorPerc))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14417, 14449);

                    _buckets = new bucket[hashsize];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14469, 14521);

                    _loadsize = (int)(_loadFactorPerc * hashsize) / 100;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14539, 14612) || true) && (_loadsize >= hashsize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 14539, 14612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14587, 14612);

                        _loadsize = hashsize - 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 14539, 14612);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 13748, 14627);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 13748, 14627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 13748, 14627);
                }
            }

            private static uint InitHash(int key, int hashsize, out uint seed, out uint incr)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 14643, 15535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14903, 14942);

                    uint
                    hashcode = (uint)key & 0x7FFFFFFF
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 14960, 14982);

                    seed = (uint)hashcode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 15424, 15486);

                    incr = (uint)(1 + (((seed >> 5) + 1) % ((uint)hashsize - 1)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 15504, 15520);

                    return hashcode;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 14643, 15535);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 14643, 15535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 14643, 15535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void Add(int key, Object value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 15551, 15664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 15624, 15649);

                    f_24009_15624_15648(this, key, value, true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 15551, 15664);

                    int
                    f_24009_15624_15648(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                    this_param, int
                    key, object
                    nvalue, bool
                    add)
                    {
                        this_param.Insert(key, nvalue, add);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 15624, 15648);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 15551, 15664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 15551, 15664);
                }
            }

            internal Object this[int key]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 15742, 16904);
                        uint seed = default(uint);
                        uint incr = default(uint);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 15786, 15926) || true) && (key < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 15786, 15926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 15847, 15903);

                            throw f_24009_15853_15902("Argument_KeyLessThanZero");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 15786, 15926);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16037, 16066);

                        bucket[]
                        lbuckets = _buckets
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16088, 16163);

                        uint
                        hashcode = f_24009_16104_16162(key, f_24009_16118_16133(lbuckets), out seed, out incr)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16185, 16198);

                        int
                        ntry = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16222, 16231);

                        bucket
                        b
                        = default(bucket);
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 16253, 16851);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16304, 16359);

                                    int
                                    bucketNumber = (int)(seed % (uint)f_24009_16342_16357(lbuckets))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16385, 16412);

                                    b = lbuckets[bucketNumber];

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16438, 16552) || true) && (b.val == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 16438, 16552);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16513, 16525);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 16438, 16552);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16578, 16736) || true) && (((b.hash_coll & 0x7FFFFFFF) == hashcode) && (DynAbs.Tracing.TraceSender.Expression_True(24009, 16582, 16638) && key == b.key))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 16578, 16736);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16696, 16709);

                                        return b.val;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 16578, 16736);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16762, 16775);

                                    seed += incr;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 16253, 16851);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16253, 16851) || true) && (b.hash_coll < 0 && (DynAbs.Tracing.TraceSender.Expression_True(24009, 16806, 16849) && ++ntry < f_24009_16834_16849(lbuckets)))
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 16253, 16851);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 16253, 16851);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 16873, 16885);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 15742, 16904);

                        System.ArgumentException
                        f_24009_15853_15902(string
                        message)
                        {
                            var return_v = new System.ArgumentException(message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 15853, 15902);
                            return return_v;
                        }


                        int
                        f_24009_16118_16133(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 16118, 16133);
                            return return_v;
                        }


                        uint
                        f_24009_16104_16162(int
                        key, int
                        hashsize, out uint
                        seed, out uint
                        incr)
                        {
                            var return_v = InitHash(key, hashsize, out seed, out incr);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 16104, 16162);
                            return return_v;
                        }


                        int
                        f_24009_16342_16357(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 16342, 16357);
                            return return_v;
                        }


                        int
                        f_24009_16834_16849(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 16834, 16849);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 15742, 16904);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 15742, 16904);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                //set {
                //  Insert(key, value, false);
                //}
            }

            private void expand()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 17029, 17140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17083, 17125);

                    f_24009_17083_17124(this, f_24009_17090_17123(1 + f_24009_17103_17118(_buckets) * 2));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 17029, 17140);

                    int
                    f_24009_17103_17118(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 17103, 17118);
                        return return_v;
                    }


                    int
                    f_24009_17090_17123(int
                    minSize)
                    {
                        var return_v = GetPrime(minSize);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 17090, 17123);
                        return return_v;
                    }


                    int
                    f_24009_17083_17124(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                    this_param, int
                    newsize)
                    {
                        this_param.rehash(newsize);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 17083, 17124);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 17029, 17140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 17029, 17140);
                }
            }

            private void rehash()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 17156, 17249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17210, 17234);

                    f_24009_17210_17233(this, f_24009_17217_17232(_buckets));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 17156, 17249);

                    int
                    f_24009_17217_17232(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 17217, 17232);
                        return return_v;
                    }


                    int
                    f_24009_17210_17233(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                    this_param, int
                    newsize)
                    {
                        this_param.rehash(newsize);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 17210, 17233);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 17156, 17249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 17156, 17249);
                }
            }

            private void rehash(int newsize)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 17265, 18647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17366, 17381);

                    _occupancy = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17796, 17838);

                    bucket[]
                    newBuckets = new bucket[newsize]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17908, 17915);

                    int
                    nb
                    = default(int);
                    try
                    {
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17938, 17944)
   , nb = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17933, 18245) || true) && (nb < f_24009_17951_17966(_buckets))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 17968, 17972)
   , nb++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 17933, 18245))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 17933, 18245);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18014, 18041);

                            bucket
                            oldb = _buckets[nb]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18063, 18226) || true) && (oldb.val != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 18063, 18226);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18133, 18203);

                                f_24009_18133_18202(this, newBuckets, oldb.key, oldb.val, oldb.hash_coll & 0x7FFFFFFF);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 18063, 18226);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 313);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 313);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18356, 18367);

                    _version++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18385, 18407);

                    _buckets = newBuckets;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18425, 18476);

                    _loadsize = (int)(_loadFactorPerc * newsize) / 100;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18496, 18605) || true) && (_loadsize >= newsize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 18496, 18605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18562, 18586);

                        _loadsize = newsize - 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 18496, 18605);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18625, 18632);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 17265, 18647);

                    int
                    f_24009_17951_17966(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 17951, 17966);
                        return return_v;
                    }


                    int
                    f_24009_18133_18202(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                    this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    newBuckets, int
                    key, object
                    nvalue, int
                    hashcode)
                    {
                        this_param.putEntry(newBuckets, key, nvalue, hashcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 18133, 18202);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 17265, 18647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 17265, 18647);
                }
            }

            private void Insert(int key, Object nvalue, bool add)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 18663, 24072);
                    uint seed = default(uint);
                    uint incr = default(uint);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18749, 18877) || true) && (key < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 18749, 18877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18802, 18858);

                        throw f_24009_18808_18857("Argument_KeyLessThanZero");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 18749, 18877);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18895, 19044) || true) && (nvalue == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 18895, 19044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 18955, 19025);

                        throw f_24009_18961_19024(nameof(nvalue), "ArgumentNull_Value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 18895, 19044);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19062, 19290) || true) && (_count >= _loadsize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 19062, 19290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19127, 19136);

                        f_24009_19127_19135(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 19062, 19290);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 19062, 19290);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19178, 19290) || true) && (_occupancy > _loadsize && (DynAbs.Tracing.TraceSender.Expression_True(24009, 19182, 19220) && _count > 100))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 19178, 19290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19262, 19271);

                            f_24009_19262_19270(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 19178, 19290);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 19062, 19290);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19479, 19554);

                    uint
                    hashcode = f_24009_19495_19553(key, f_24009_19509_19524(_buckets), out seed, out incr)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19572, 19585);

                    int
                    ntry = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19603, 19628);

                    int
                    emptySlotNumber = -1
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 19829, 23034);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19872, 19927);

                                int
                                bucketNumber = (int)(seed % (uint)f_24009_19910_19925(_buckets))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 20571, 21544) || true) && (_buckets[bucketNumber].val == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 20571, 21544);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 20895, 21050) || true) && (emptySlotNumber != -1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 20895, 21050);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 20992, 21023);

                                        bucketNumber = emptySlotNumber;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 20895, 21050);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21245, 21281);

                                    _buckets[bucketNumber].val = nvalue;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21307, 21340);

                                    _buckets[bucketNumber].key = key;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21366, 21416);

                                    _buckets[bucketNumber].hash_coll |= (int)hashcode;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21442, 21451);

                                    _count++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21477, 21488);

                                    _version++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21514, 21521);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 20571, 21544);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21769, 22288) || true) && (((_buckets[bucketNumber].hash_coll & 0x7FFFFFFF) == hashcode) && (DynAbs.Tracing.TraceSender.Expression_True(24009, 21773, 21904) && key == _buckets[bucketNumber].key))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 21769, 22288);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 21954, 22133) || true) && (add)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 21954, 22133);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22019, 22106);

                                        throw f_24009_22025_22105("Argument_AddingDuplicate__" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_buckets[bucketNumber].key).ToString(), 24009, 22078, 22104));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 21954, 22133);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22159, 22195);

                                    _buckets[bucketNumber].val = nvalue;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22221, 22232);

                                    _version++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22258, 22265);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 21769, 22288);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22534, 22946) || true) && (emptySlotNumber == -1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 22534, 22946);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22691, 22923) || true) && (_buckets[bucketNumber].hash_coll >= 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 22691, 22923);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22790, 22853);

                                        _buckets[bucketNumber].hash_coll |= unchecked((int)0x80000000);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22883, 22896);

                                        _occupancy++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 22691, 22923);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 22534, 22946);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 22968, 22981);

                                seed += incr;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 19829, 23034);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 19829, 23034) || true) && (++ntry < f_24009_23017_23032(_buckets))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 19829, 23034);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 19829, 23034);
                        }
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23177, 23687) || true) && (emptySlotNumber != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 23177, 23687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23403, 23442);

                        _buckets[emptySlotNumber].val = nvalue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23464, 23500);

                        _buckets[emptySlotNumber].key = key;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23522, 23575);

                        _buckets[emptySlotNumber].hash_coll |= (int)hashcode;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23597, 23606);

                        _count++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23628, 23639);

                        _version++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23661, 23668);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 23177, 23687);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 23984, 24057);

                    throw f_24009_23990_24056("InvalidOperation_HashInsertFailed");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 18663, 24072);

                    System.ArgumentException
                    f_24009_18808_18857(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 18808, 18857);
                        return return_v;
                    }


                    System.ArgumentNullException
                    f_24009_18961_19024(string
                    paramName, string
                    message)
                    {
                        var return_v = new System.ArgumentNullException(paramName, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 18961, 19024);
                        return return_v;
                    }


                    int
                    f_24009_19127_19135(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                    this_param)
                    {
                        this_param.expand();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 19127, 19135);
                        return 0;
                    }


                    int
                    f_24009_19262_19270(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                    this_param)
                    {
                        this_param.rehash();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 19262, 19270);
                        return 0;
                    }


                    int
                    f_24009_19509_19524(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 19509, 19524);
                        return return_v;
                    }


                    uint
                    f_24009_19495_19553(int
                    key, int
                    hashsize, out uint
                    seed, out uint
                    incr)
                    {
                        var return_v = InitHash(key, hashsize, out seed, out incr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 19495, 19553);
                        return return_v;
                    }


                    int
                    f_24009_19910_19925(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 19910, 19925);
                        return return_v;
                    }


                    System.ArgumentException
                    f_24009_22025_22105(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 22025, 22105);
                        return return_v;
                    }


                    int
                    f_24009_23017_23032(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 23017, 23032);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_24009_23990_24056(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 23990, 24056);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 18663, 24072);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 18663, 24072);
                }
            }

            private void putEntry(bucket[] newBuckets, int key, Object nvalue, int hashcode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 24088, 25113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24201, 24228);

                    uint
                    seed = (uint)hashcode
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24246, 24322);

                    uint
                    incr = (uint)(1 + (((seed >> 5) + 1) % ((uint)f_24009_24297_24314(newBuckets) - 1)))
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 24342, 25098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24385, 24442);

                                int
                                bucketNumber = (int)(seed % (uint)f_24009_24423_24440(newBuckets))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24466, 24786) || true) && ((newBuckets[bucketNumber].val == null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 24466, 24786);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24558, 24596);

                                    newBuckets[bucketNumber].val = nvalue;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24622, 24657);

                                    newBuckets[bucketNumber].key = key;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24683, 24730);

                                    newBuckets[bucketNumber].hash_coll |= hashcode;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24756, 24763);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 24466, 24786);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24810, 25030) || true) && (newBuckets[bucketNumber].hash_coll >= 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 24810, 25030);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24903, 24968);

                                    newBuckets[bucketNumber].hash_coll |= unchecked((int)0x80000000);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24994, 25007);

                                    _occupancy++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 24810, 25030);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25052, 25065);

                                seed += incr;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 24342, 25098);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 24342, 25098) || true) && (true)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 24342, 25098);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 24342, 25098);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 24088, 25113);

                    int
                    f_24009_24297_24314(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 24297, 24314);
                        return return_v;
                    }


                    int
                    f_24009_24423_24440(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable.bucket[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 24423, 24440);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 24088, 25113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 24088, 25113);
                }
            }

            static IntHashTable()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 11408, 25124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 11489, 12054);
                s_primes = new int[]{
                3, 7, 11, 17, 23, 29, 37, 47, 59, 71, 89, 107, 131, 163, 197, 239, 293, 353, 431, 521, 631, 761, 919,
                1103, 1327, 1597, 1931, 2333, 2801, 3371, 4049, 4861, 5839, 7013, 8419, 10103, 12143, 14591,
                17519, 21023, 25229, 30293, 36353, 43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437,
                187751, 225307, 270371, 324449, 389357, 467237, 560689, 672827, 807403, 968897, 1162687, 1395263,
                1674319, 2009191, 2411033, 2893249, 3471899, 4166287, 4999559, 5999471, 7199369}; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 11408, 25124);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 11408, 25124);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 11408, 25124);

            static int
            f_24009_13695_13696_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(24009, 13647, 13732);
                return return_v;
            }


            System.ArgumentOutOfRangeException
            f_24009_13881_13966(string
            paramName, string
            message)
            {
                var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 13881, 13966);
                return return_v;
            }


            System.ArgumentOutOfRangeException
            f_24009_14066_14166(string
            paramName, string
            message)
            {
                var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 14066, 14166);
                return return_v;
            }


            int
            f_24009_14355_14398(int
            minSize)
            {
                var return_v = GetPrime(minSize);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 14355, 14398);
                return return_v;
            }

        }

        private struct DbiSecCon
        {

            internal DbiSecCon(BitAccess bits)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 25185, 25654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25252, 25280);

                    f_24009_25252_25279(bits, out section);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25298, 25323);

                    f_24009_25298_25322(bits, out pad1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25341, 25368);

                    f_24009_25341_25367(bits, out offset);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25386, 25411);

                    f_24009_25386_25410(bits, out size);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25429, 25456);

                    f_24009_25429_25455(bits, out flags);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25474, 25501);

                    f_24009_25474_25500(bits, out module);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25519, 25544);

                    f_24009_25519_25543(bits, out pad2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25562, 25591);

                    f_24009_25562_25590(bits, out dataCrc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 25609, 25639);

                    f_24009_25609_25638(bits, out relocCrc);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 25185, 25654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 25185, 25654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 25185, 25654);
                }
            }

            internal readonly short section;

            internal readonly short pad1;

            internal readonly int offset;

            internal readonly int size;

            internal readonly uint flags;

            internal readonly short module;

            internal readonly short pad2;

            internal readonly uint dataCrc;

            internal readonly uint relocCrc;
            static DbiSecCon()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 25136, 26328);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 25136, 26328);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 25136, 26328);
            }

            static int
            f_24009_25252_25279(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25252, 25279);
                return 0;
            }


            static int
            f_24009_25298_25322(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25298, 25322);
                return 0;
            }


            static int
            f_24009_25341_25367(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25341, 25367);
                return 0;
            }


            static int
            f_24009_25386_25410(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25386, 25410);
                return 0;
            }


            static int
            f_24009_25429_25455(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out uint
            value)
            {
                this_param.ReadUInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25429, 25455);
                return 0;
            }


            static int
            f_24009_25474_25500(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25474, 25500);
                return 0;
            }


            static int
            f_24009_25519_25543(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25519, 25543);
                return 0;
            }


            static int
            f_24009_25562_25590(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out uint
            value)
            {
                this_param.ReadUInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25562, 25590);
                return 0;
            }


            static int
            f_24009_25609_25638(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out uint
            value)
            {
                this_param.ReadUInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 25609, 25638);
                return 0;
            }

        }
        private class DbiModuleInfo
        {
            internal DbiModuleInfo(BitAccess bits, bool readStrings)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 26392, 27405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27443, 27449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27514, 27519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27585, 27591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27654, 27660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27723, 27733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27792, 27799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27863, 27868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27934, 27938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28004, 28011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28048, 28056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28093, 28103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28143, 28153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28193, 28203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26481, 26508);

                    f_24009_26481_26507(bits, out opened);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26526, 26546);

                    f_24009_26526_26545(bits);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26564, 26591);

                    f_24009_26564_26590(bits, out flags);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26609, 26636);

                    f_24009_26609_26635(bits, out stream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26654, 26681);

                    f_24009_26654_26680(bits, out cbSyms);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26699, 26730);

                    f_24009_26699_26729(bits, out cbOldLines);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26748, 26776);

                    f_24009_26748_26775(bits, out cbLines);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26794, 26820);

                    f_24009_26794_26819(bits, out files);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26838, 26863);

                    f_24009_26838_26862(bits, out pad1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26881, 26910);

                    f_24009_26881_26909(bits, out offsets);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26928, 26957);

                    f_24009_26928_26956(bits, out niSource);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 26975, 27006);

                    f_24009_26975_27005(bits, out niCompiler);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27024, 27358) || true) && (readStrings)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 27024, 27358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27081, 27114);

                        f_24009_27081_27113(bits, out moduleName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27136, 27169);

                        f_24009_27136_27168(bits, out objectName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 27024, 27358);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 27024, 27358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27251, 27284);

                        f_24009_27251_27283(bits, out moduleName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27306, 27339);

                        f_24009_27306_27338(bits, out objectName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 27024, 27358);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 27376, 27390);

                    f_24009_27376_27389(bits, 4);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 26392, 27405);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 26392, 27405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 26392, 27405);
                }
            }

            internal readonly int opened;

            internal readonly ushort flags;

            internal readonly short stream;

            internal readonly int cbSyms;

            internal readonly int cbOldLines;

            internal readonly int cbLines;

            internal readonly short files;

            internal readonly short pad1;

            internal readonly uint offsets;

            internal readonly int niSource;

            internal readonly int niCompiler;

            internal readonly string moduleName;

            internal readonly string objectName;

            static DbiModuleInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 26340, 28215);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 26340, 28215);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 26340, 28215);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 26340, 28215);

            int
            f_24009_26481_26507(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26481, 26507);
                return 0;
            }


            Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiSecCon
            f_24009_26526_26545(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            bits)
            {
                var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiSecCon(bits);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26526, 26545);
                return return_v;
            }


            int
            f_24009_26564_26590(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26564, 26590);
                return 0;
            }


            int
            f_24009_26609_26635(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26609, 26635);
                return 0;
            }


            int
            f_24009_26654_26680(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26654, 26680);
                return 0;
            }


            int
            f_24009_26699_26729(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26699, 26729);
                return 0;
            }


            int
            f_24009_26748_26775(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26748, 26775);
                return 0;
            }


            int
            f_24009_26794_26819(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26794, 26819);
                return 0;
            }


            int
            f_24009_26838_26862(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26838, 26862);
                return 0;
            }


            int
            f_24009_26881_26909(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out uint
            value)
            {
                this_param.ReadUInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26881, 26909);
                return 0;
            }


            int
            f_24009_26928_26956(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26928, 26956);
                return 0;
            }


            int
            f_24009_26975_27005(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 26975, 27005);
                return 0;
            }


            int
            f_24009_27081_27113(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out string
            value)
            {
                this_param.ReadCString(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 27081, 27113);
                return 0;
            }


            int
            f_24009_27136_27168(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out string
            value)
            {
                this_param.ReadCString(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 27136, 27168);
                return 0;
            }


            int
            f_24009_27251_27283(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out string
            value)
            {
                this_param.SkipCString(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 27251, 27283);
                return 0;
            }


            int
            f_24009_27306_27338(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out string
            value)
            {
                this_param.SkipCString(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 27306, 27338);
                return 0;
            }


            int
            f_24009_27376_27389(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, int
            alignment)
            {
                this_param.Align(alignment);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 27376, 27389);
                return 0;
            }

        }

        private struct DbiHeader
        {

            internal DbiHeader(BitAccess bits)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 28276, 29282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28343, 28367);

                    f_24009_28343_28366(bits, out sig);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28385, 28409);

                    f_24009_28385_28408(bits, out ver);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28427, 28451);

                    f_24009_28427_28450(bits, out age);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28469, 28501);

                    f_24009_28469_28500(bits, out gssymStream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28519, 28545);

                    f_24009_28519_28544(bits, out vers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28563, 28595);

                    f_24009_28563_28594(bits, out pssymStream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28613, 28641);

                    f_24009_28613_28640(bits, out pdbver);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28659, 28692);

                    f_24009_28659_28691(bits, out symrecStream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28710, 28739);

                    f_24009_28710_28738(bits, out pdbver2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28757, 28788);

                    f_24009_28757_28787(bits, out gpmodiSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28806, 28837);

                    f_24009_28806_28836(bits, out secconSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28855, 28886);

                    f_24009_28855_28885(bits, out secmapSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28904, 28935);

                    f_24009_28904_28934(bits, out filinfSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 28953, 28983);

                    f_24009_28953_28982(bits, out tsmapSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 29001, 29030);

                    f_24009_29001_29029(bits, out mfcIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 29048, 29079);

                    f_24009_29048_29078(bits, out dbghdrSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 29097, 29128);

                    f_24009_29097_29127(bits, out ecinfoSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 29146, 29173);

                    f_24009_29146_29172(bits, out flags);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 29191, 29220);

                    f_24009_29191_29219(bits, out machine);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 29238, 29267);

                    f_24009_29238_29266(bits, out reserved);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 28276, 29282);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 28276, 29282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 28276, 29282);
                }
            }

            internal readonly int sig;

            internal readonly int ver;

            internal readonly int age;

            internal readonly short gssymStream;

            internal readonly ushort vers;

            internal readonly short pssymStream;

            internal readonly ushort pdbver;

            internal readonly short symrecStream;

            internal readonly ushort pdbver2;

            internal readonly int gpmodiSize;

            internal readonly int secconSize;

            internal readonly int secmapSize;

            internal readonly int filinfSize;

            internal readonly int tsmapSize;

            internal readonly int mfcIndex;

            internal readonly int dbghdrSize;

            internal readonly int ecinfoSize;

            internal readonly ushort flags;

            internal readonly ushort machine;

            internal readonly int reserved;
            static DbiHeader()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 28227, 30771);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 28227, 30771);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 28227, 30771);
            }

            static int
            f_24009_28343_28366(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28343, 28366);
                return 0;
            }


            static int
            f_24009_28385_28408(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28385, 28408);
                return 0;
            }


            static int
            f_24009_28427_28450(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28427, 28450);
                return 0;
            }


            static int
            f_24009_28469_28500(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28469, 28500);
                return 0;
            }


            static int
            f_24009_28519_28544(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28519, 28544);
                return 0;
            }


            static int
            f_24009_28563_28594(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28563, 28594);
                return 0;
            }


            static int
            f_24009_28613_28640(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28613, 28640);
                return 0;
            }


            static int
            f_24009_28659_28691(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out short
            value)
            {
                this_param.ReadInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28659, 28691);
                return 0;
            }


            static int
            f_24009_28710_28738(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28710, 28738);
                return 0;
            }


            static int
            f_24009_28757_28787(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28757, 28787);
                return 0;
            }


            static int
            f_24009_28806_28836(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28806, 28836);
                return 0;
            }


            static int
            f_24009_28855_28885(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28855, 28885);
                return 0;
            }


            static int
            f_24009_28904_28934(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28904, 28934);
                return 0;
            }


            static int
            f_24009_28953_28982(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 28953, 28982);
                return 0;
            }


            static int
            f_24009_29001_29029(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 29001, 29029);
                return 0;
            }


            static int
            f_24009_29048_29078(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 29048, 29078);
                return 0;
            }


            static int
            f_24009_29097_29127(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 29097, 29127);
                return 0;
            }


            static int
            f_24009_29146_29172(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 29146, 29172);
                return 0;
            }


            static int
            f_24009_29191_29219(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 29191, 29219);
                return 0;
            }


            static int
            f_24009_29238_29266(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 29238, 29266);
                return 0;
            }

        }

        private struct DbiDbgHdr
        {

            internal DbiDbgHdr(BitAccess bits)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 30832, 31446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 30899, 30926);

                    f_24009_30899_30925(bits, out snFPO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 30944, 30977);

                    f_24009_30944_30976(bits, out snException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 30995, 31024);

                    f_24009_30995_31023(bits, out snFixup);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31042, 31075);

                    f_24009_31042_31074(bits, out snOmapToSrc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31093, 31128);

                    f_24009_31093_31127(bits, out snOmapFromSrc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31146, 31180);

                    f_24009_31146_31179(bits, out snSectionHdr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31198, 31233);

                    f_24009_31198_31232(bits, out snTokenRidMap);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31251, 31280);

                    f_24009_31251_31279(bits, out snXdata);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31298, 31327);

                    f_24009_31298_31326(bits, out snPdata);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31345, 31375);

                    f_24009_31345_31374(bits, out snNewFPO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 31393, 31431);

                    f_24009_31393_31430(bits, out snSectionHdrOrig);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 30832, 31446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 30832, 31446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 30832, 31446);
                }
            }

            internal readonly ushort snFPO;

            internal readonly ushort snException;

            internal readonly ushort snFixup;

            internal readonly ushort snOmapToSrc;

            internal readonly ushort snOmapFromSrc;

            internal readonly ushort snSectionHdr;

            internal readonly ushort snTokenRidMap;

            internal readonly ushort snXdata;

            internal readonly ushort snPdata;

            internal readonly ushort snNewFPO;

            internal readonly ushort snSectionHdrOrig;
            static DbiDbgHdr()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 30783, 32243);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 30783, 32243);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 30783, 32243);
            }

            static int
            f_24009_30899_30925(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 30899, 30925);
                return 0;
            }


            static int
            f_24009_30944_30976(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 30944, 30976);
                return 0;
            }


            static int
            f_24009_30995_31023(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 30995, 31023);
                return 0;
            }


            static int
            f_24009_31042_31074(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31042, 31074);
                return 0;
            }


            static int
            f_24009_31093_31127(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31093, 31127);
                return 0;
            }


            static int
            f_24009_31146_31179(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31146, 31179);
                return 0;
            }


            static int
            f_24009_31198_31232(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31198, 31232);
                return 0;
            }


            static int
            f_24009_31251_31279(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31251, 31279);
                return 0;
            }


            static int
            f_24009_31298_31326(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31298, 31326);
                return 0;
            }


            static int
            f_24009_31345_31374(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31345, 31374);
                return 0;
            }


            static int
            f_24009_31393_31430(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out ushort
            value)
            {
                this_param.ReadUInt16(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 31393, 31430);
                return 0;
            }

        }
        private class PdbFileHeader
        {
            internal PdbFileHeader(Stream reader, BitAccess bits)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 32307, 33301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33342, 33347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33384, 33392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33429, 33440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33477, 33486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33523, 33536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33573, 33577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33616, 33629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32393, 32414);

                    f_24009_32393_32413(bits, 56);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32432, 32465);

                    f_24009_32432_32464(reader, 0, SeekOrigin.Begin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32483, 32511);

                    f_24009_32483_32510(bits, reader, 52);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32531, 32557);

                    this.magic = new byte[32];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32575, 32602);

                    f_24009_32575_32601(bits, this.magic);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32647, 32681);

                    f_24009_32647_32680(bits, out this.pageSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32719, 32756);

                    f_24009_32719_32755(bits, out this.freePageMap);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32791, 32826);

                    f_24009_32791_32825(bits, out this.pagesUsed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32863, 32902);

                    f_24009_32863_32901(bits, out this.directorySize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 32935, 32965);

                    f_24009_32935_32964(bits, out this.zero);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33009, 33108);

                    int
                    directoryPages = ((((directorySize + pageSize - 1) / pageSize) * 4) + pageSize - 1) / pageSize
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33126, 33171);

                    this.directoryRoot = new int[directoryPages];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33189, 33233);

                    f_24009_33189_33232(bits, reader, directoryPages * 4);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33251, 33286);

                    f_24009_33251_33285(bits, this.directoryRoot);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 32307, 33301);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 32307, 33301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 32307, 33301);
                }
            }

            internal readonly byte[] magic;

            internal readonly int pageSize;

            internal readonly int freePageMap;

            internal readonly int pagesUsed;

            internal readonly int directorySize;

            internal readonly int zero;

            internal readonly int[] directoryRoot;

            static PdbFileHeader()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 32255, 33641);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 32255, 33641);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 32255, 33641);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 32255, 33641);

            int
            f_24009_32393_32413(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, int
            capacity)
            {
                this_param.MinCapacity(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32393, 32413);
                return 0;
            }


            long
            f_24009_32432_32464(System.IO.Stream
            this_param, int
            offset, System.IO.SeekOrigin
            origin)
            {
                var return_v = this_param.Seek((long)offset, origin);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32432, 32464);
                return return_v;
            }


            int
            f_24009_32483_32510(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, System.IO.Stream
            stream, int
            capacity)
            {
                this_param.FillBuffer(stream, capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32483, 32510);
                return 0;
            }


            int
            f_24009_32575_32601(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, byte[]
            bytes)
            {
                this_param.ReadBytes(bytes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32575, 32601);
                return 0;
            }


            int
            f_24009_32647_32680(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32647, 32680);
                return 0;
            }


            int
            f_24009_32719_32755(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32719, 32755);
                return 0;
            }


            int
            f_24009_32791_32825(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32791, 32825);
                return 0;
            }


            int
            f_24009_32863_32901(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32863, 32901);
                return 0;
            }


            int
            f_24009_32935_32964(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 32935, 32964);
                return 0;
            }


            int
            f_24009_33189_33232(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, System.IO.Stream
            stream, int
            capacity)
            {
                this_param.FillBuffer(stream, capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 33189, 33232);
                return 0;
            }


            int
            f_24009_33251_33285(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, int[]
            values)
            {
                this_param.ReadInt32(values);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 33251, 33285);
                return 0;
            }

        }
        private class PdbReader
        {
            internal PdbReader(Stream reader, int pageSize)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 33701, 33860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34353, 34361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34401, 34407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33781, 33806);

                    this.pageSize = pageSize;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33824, 33845);

                    this.reader = reader;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 33701, 33860);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 33701, 33860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 33701, 33860);
                }
            }

            internal void Seek(int page, int offset)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 33876, 34020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 33949, 34005);

                    f_24009_33949_34004(reader, page * pageSize + offset, SeekOrigin.Begin);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 33876, 34020);

                    long
                    f_24009_33949_34004(System.IO.Stream
                    this_param, int
                    offset, System.IO.SeekOrigin
                    origin)
                    {
                        var return_v = this_param.Seek((long)offset, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 33949, 34004);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 33876, 34020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 33876, 34020);
                }
            }

            internal void Read(byte[] bytes, int offset, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 34036, 34173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34124, 34158);

                    f_24009_34124_34157(reader, bytes, offset, count);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 34036, 34173);

                    int
                    f_24009_34124_34157(System.IO.Stream
                    this_param, byte[]
                    buffer, int
                    offset, int
                    count)
                    {
                        var return_v = this_param.Read(buffer, offset, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 34124, 34157);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 34036, 34173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 34036, 34173);
                }
            }

            internal int PagesFromSize(int size)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 34189, 34315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34258, 34300);

                    return (size + pageSize - 1) / (pageSize);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 34189, 34315);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 34189, 34315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 34189, 34315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal readonly int pageSize;

            internal readonly Stream reader;

            static PdbReader()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 33653, 34419);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 33653, 34419);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 33653, 34419);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 33653, 34419);
        }
        private class DataStream
        {
            internal DataStream()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 34480, 34531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36969, 36980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37019, 37024);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 34480, 34531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 34480, 34531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 34480, 34531);
                }
            }

            internal DataStream(int contentSize, BitAccess bits, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 34547, 34858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36969, 36980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37019, 37024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34643, 34674);

                    this.contentSize = contentSize;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34692, 34843) || true) && (count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 34692, 34843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34747, 34775);

                        this.pages = new int[count];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34797, 34824);

                        f_24009_34797_34823(bits, this.pages);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 34692, 34843);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 34547, 34858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 34547, 34858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 34547, 34858);
                }
            }

            internal void Read(PdbReader reader, BitAccess bits)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 34874, 35067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 34959, 34989);

                    f_24009_34959_34988(bits, contentSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35007, 35052);

                    f_24009_35007_35051(this, reader, 0, f_24009_35023_35034(bits), 0, contentSize);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 34874, 35067);

                    int
                    f_24009_34959_34988(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param, int
                    capacity)
                    {
                        this_param.MinCapacity(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 34959, 34988);
                        return 0;
                    }


                    byte[]
                    f_24009_35023_35034(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                    this_param)
                    {
                        var return_v = this_param.Buffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 35023, 35034);
                        return return_v;
                    }


                    int
                    f_24009_35007_35051(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
                    this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                    reader, int
                    position, byte[]
                    bytes, int
                    offset, int
                    data)
                    {
                        this_param.Read(reader, position, bytes, offset, data);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 35007, 35051);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 34874, 35067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 34874, 35067);
                }
            }

            internal void Read(PdbReader reader, int position,
                                         byte[] bytes, int offset, int data)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 35083, 36821);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35232, 35524) || true) && (position + data > contentSize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 35232, 35524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35307, 35505);

                        throw f_24009_35313_35504(f_24009_35353_35503("DataStream can't read off end of stream. (pos={0},siz={1})", position, data));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 35232, 35524);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35542, 35637) || true) && (position == contentSize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 35542, 35637);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35611, 35618);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 35542, 35637);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35657, 35673);

                    int
                    left = data
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35691, 35729);

                    int
                    page = position / reader.pageSize
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35747, 35785);

                    int
                    rema = position % reader.pageSize
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35859, 36302) || true) && (rema != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 35859, 36302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35914, 35948);

                        int
                        todo = reader.pageSize - rema
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 35970, 36070) || true) && (todo > left)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 35970, 36070);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36035, 36047);

                            todo = left;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 35970, 36070);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36094, 36125);

                        f_24009_36094_36124(
                                            reader, pages[page], rema);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36147, 36180);

                        f_24009_36147_36179(reader, bytes, offset, todo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36204, 36219);

                        offset += todo;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36241, 36254);

                        left -= todo;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36276, 36283);

                        page++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 35859, 36302);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36371, 36806) || true) && (left > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 36371, 36806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36428, 36455);

                            int
                            todo = reader.pageSize
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36477, 36577) || true) && (todo > left)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 36477, 36577);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36542, 36554);

                                todo = left;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 36477, 36577);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36601, 36629);

                            f_24009_36601_36628(
                                                reader, pages[page], 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36651, 36684);

                            f_24009_36651_36683(reader, bytes, offset, todo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36708, 36723);

                            offset += todo;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36745, 36758);

                            left -= todo;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36780, 36787);

                            page++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 36371, 36806);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 36371, 36806);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 36371, 36806);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 35083, 36821);

                    string
                    f_24009_35353_35503(string
                    format, int
                    arg0, int
                    arg1)
                    {
                        var return_v = string.Format(format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 35353, 35503);
                        return return_v;
                    }


                    System.Exception
                    f_24009_35313_35504(string
                    message)
                    {
                        var return_v = new System.Exception(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 35313, 35504);
                        return return_v;
                    }


                    int
                    f_24009_36094_36124(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                    this_param, int
                    page, int
                    offset)
                    {
                        this_param.Seek(page, offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 36094, 36124);
                        return 0;
                    }


                    int
                    f_24009_36147_36179(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                    this_param, byte[]
                    bytes, int
                    offset, int
                    count)
                    {
                        this_param.Read(bytes, offset, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 36147, 36179);
                        return 0;
                    }


                    int
                    f_24009_36601_36628(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                    this_param, int
                    page, int
                    offset)
                    {
                        this_param.Seek(page, offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 36601, 36628);
                        return 0;
                    }


                    int
                    f_24009_36651_36683(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                    this_param, byte[]
                    bytes, int
                    offset, int
                    count)
                    {
                        this_param.Read(bytes, offset, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 36651, 36683);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 35083, 36821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 35083, 36821);
                }
            }

            internal int Length
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(24009, 36889, 36916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 36895, 36914);

                        return contentSize;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(24009, 36889, 36916);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 36837, 36931);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 36837, 36931);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal readonly int contentSize;

            internal readonly int[] pages;

            static DataStream()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 34431, 37036);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 34431, 37036);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 34431, 37036);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 34431, 37036);

            int
            f_24009_34797_34823(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, int[]
            values)
            {
                this_param.ReadInt32(values);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 34797, 34823);
                return 0;
            }

        }
        private class MsfDirectory
        {
            internal MsfDirectory(PdbReader reader, PdbFileHeader head, BitAccess bits)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 37099, 38891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38938, 38945);
                    int count = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37207, 37260);

                    int
                    pages = f_24009_37219_37259(reader, head.directorySize)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37333, 37370);

                    f_24009_37333_37369(
                                    // 0..n in page of directory pages.
                                    bits, head.directorySize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37388, 37439);

                    int
                    directoryRootPages = f_24009_37413_37438(head.directoryRoot)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37457, 37494);

                    int
                    pagesPerPage = head.pageSize / 4
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37512, 37534);

                    int
                    pagesToGo = pages
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37561, 37566);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37552, 37912) || true) && (i < directoryRootPages)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37592, 37595)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 37552, 37912))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 37552, 37912);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37637, 37712);

                            int
                            pagesInThisPage = (DynAbs.Tracing.TraceSender.Conditional_F1(24009, 37659, 37684) || ((pagesToGo <= pagesPerPage && DynAbs.Tracing.TraceSender.Conditional_F2(24009, 37687, 37696)) || DynAbs.Tracing.TraceSender.Conditional_F3(24009, 37699, 37711))) ? pagesToGo : pagesPerPage
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37734, 37772);

                            f_24009_37734_37771(reader, head.directoryRoot[i], 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37794, 37842);

                            f_24009_37794_37841(bits, reader.reader, pagesInThisPage * 4);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37864, 37893);

                            pagesToGo -= pagesInThisPage;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 361);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 361);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37930, 37948);

                    bits.Position = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 37968, 38036);

                    DataStream
                    stream = f_24009_37988_38035(head.directorySize, bits, pages)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38054, 38091);

                    f_24009_38054_38090(bits, head.directorySize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38109, 38135);

                    f_24009_38109_38134(stream, reader, bits);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38199, 38229);

                    f_24009_38199_38228(
                                    // 0..3 in directory pages
                                    bits, out count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38274, 38303);

                    int[]
                    sizes = new int[count]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38321, 38343);

                    f_24009_38321_38342(bits, sizes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38388, 38420);

                    streams = new DataStream[count];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38447, 38452);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38438, 38876) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38465, 38468)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 38438, 38876))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 38438, 38876);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38510, 38857) || true) && (sizes[i] <= 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 38510, 38857);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38577, 38607);

                                streams[i] = f_24009_38590_38606();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 38510, 38857);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 38510, 38857);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 38705, 38834);

                                streams[i] = f_24009_38718_38833(sizes[i], bits, f_24009_38802_38832(reader, sizes[i]));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 38510, 38857);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 439);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 439);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 37099, 38891);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 37099, 38891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 37099, 38891);
                }
            }

            internal readonly DataStream[] streams;

            static MsfDirectory()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 37048, 38957);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 37048, 38957);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 37048, 38957);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 37048, 38957);

            int
            f_24009_37219_37259(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
            this_param, int
            size)
            {
                var return_v = this_param.PagesFromSize(size);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 37219, 37259);
                return return_v;
            }


            int
            f_24009_37333_37369(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, int
            capacity)
            {
                this_param.MinCapacity(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 37333, 37369);
                return 0;
            }


            int
            f_24009_37413_37438(int[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 37413, 37438);
                return return_v;
            }


            int
            f_24009_37734_37771(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
            this_param, int
            page, int
            offset)
            {
                this_param.Seek(page, offset);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 37734, 37771);
                return 0;
            }


            int
            f_24009_37794_37841(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, System.IO.Stream
            stream, int
            count)
            {
                this_param.Append(stream, count);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 37794, 37841);
                return 0;
            }


            Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
            f_24009_37988_38035(int
            contentSize, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            bits, int
            count)
            {
                var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream(contentSize, bits, count);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 37988, 38035);
                return return_v;
            }


            int
            f_24009_38054_38090(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, int
            capacity)
            {
                this_param.MinCapacity(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 38054, 38090);
                return 0;
            }


            int
            f_24009_38109_38134(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
            this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
            reader, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            bits)
            {
                this_param.Read(reader, bits);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 38109, 38134);
                return 0;
            }


            int
            f_24009_38199_38228(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, out int
            value)
            {
                this_param.ReadInt32(out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 38199, 38228);
                return 0;
            }


            int
            f_24009_38321_38342(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            this_param, int[]
            values)
            {
                this_param.ReadInt32(values);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 38321, 38342);
                return 0;
            }


            Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
            f_24009_38590_38606()
            {
                var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 38590, 38606);
                return return_v;
            }


            int
            f_24009_38802_38832(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
            this_param, int
            size)
            {
                var return_v = this_param.PagesFromSize(size);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 38802, 38832);
                return return_v;
            }


            Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
            f_24009_38718_38833(int
            contentSize, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
            bits, int
            count)
            {
                var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream(contentSize, bits, count);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 38718, 38833);
                return return_v;
            }

        }

        private struct CV_FileCheckSum
        {

            internal uint name;

            internal byte len;

            internal byte type;
            static CV_FileCheckSum()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 38969, 39210);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 38969, 39210);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 38969, 39210);
            }
        }

        private enum SYM
        {
            S_END = 0x0006,  // Block, procedure, "with" or thunk end
            S_OEM = 0x0404,  // OEM defined symbol
            S_REGISTER_ST = 0x1001,  // Register variable
            S_CONSTANT_ST = 0x1002,  // constant symbol
            S_UDT_ST = 0x1003,  // User defined type
            S_COBOLUDT_ST = 0x1004,  // special UDT for cobol that does not symbol pack
            S_MANYREG_ST = 0x1005,  // multiple register variable
            S_BPREL32_ST = 0x1006,  // BP-relative
            S_LDATA32_ST = 0x1007,  // Module-local symbol
            S_GDATA32_ST = 0x1008,  // Global data symbol
            S_PUB32_ST = 0x1009,  // a internal symbol (CV internal reserved)
            S_LPROC32_ST = 0x100a,  // Local procedure start
            S_GPROC32_ST = 0x100b,  // Global procedure start
            S_VFTABLE32 = 0x100c,  // address of virtual function table
            S_REGREL32_ST = 0x100d,  // register relative address
            S_LTHREAD32_ST = 0x100e,  // local thread storage
            S_GTHREAD32_ST = 0x100f,  // global thread storage
            S_LPROCMIPS_ST = 0x1010,  // Local procedure start
            S_GPROCMIPS_ST = 0x1011,  // Global procedure start
            S_FRAMEPROC = 0x1012,  // extra frame and proc information
            S_COMPILE2_ST = 0x1013,  // extended compile flags and info
            S_MANYREG2_ST = 0x1014,  // multiple register variable
            S_LPROCIA64_ST = 0x1015,  // Local procedure start (IA64)
            S_GPROCIA64_ST = 0x1016,  // Global procedure start (IA64)
            S_LOCALSLOT_ST = 0x1017,  // local IL sym with field for local slot index
            S_PARAMSLOT_ST = 0x1018,  // local IL sym with field for parameter slot index
            S_ANNOTATION = 0x1019,  // Annotation string literals
            S_GMANPROC_ST = 0x101a,  // Global proc
            S_LMANPROC_ST = 0x101b,  // Local proc
            S_RESERVED1 = 0x101c,  // reserved
            S_RESERVED2 = 0x101d,  // reserved
            S_RESERVED3 = 0x101e,  // reserved
            S_RESERVED4 = 0x101f,  // reserved
            S_LMANDATA_ST = 0x1020,
            S_GMANDATA_ST = 0x1021,
            S_MANFRAMEREL_ST = 0x1022,
            S_MANREGISTER_ST = 0x1023,
            S_MANSLOT_ST = 0x1024,
            S_MANMANYREG_ST = 0x1025,
            S_MANREGREL_ST = 0x1026,
            S_MANMANYREG2_ST = 0x1027,
            S_MANTYPREF = 0x1028,  // Index for type referenced by name from metadata
            S_UNAMESPACE_ST = 0x1029,  // Using namespace
            S_ST_MAX = 0x1100,  // starting point for SZ name symbols
            S_OBJNAME = 0x1101,  // path to object file name
            S_THUNK32 = 0x1102,  // Thunk Start
            S_BLOCK32 = 0x1103,  // block start
            S_WITH32 = 0x1104,  // with start
            S_LABEL32 = 0x1105,  // code label
            S_REGISTER = 0x1106,  // Register variable
            S_CONSTANT = 0x1107,  // constant symbol
            S_UDT = 0x1108,  // User defined type
            S_COBOLUDT = 0x1109,  // special UDT for cobol that does not symbol pack
            S_MANYREG = 0x110a,  // multiple register variable
            S_BPREL32 = 0x110b,  // BP-relative
            S_LDATA32 = 0x110c,  // Module-local symbol
            S_GDATA32 = 0x110d,  // Global data symbol
            S_PUB32 = 0x110e,  // a internal symbol (CV internal reserved)
            S_LPROC32 = 0x110f,  // Local procedure start
            S_GPROC32 = 0x1110,  // Global procedure start
            S_REGREL32 = 0x1111,  // register relative address
            S_LTHREAD32 = 0x1112,  // local thread storage
            S_GTHREAD32 = 0x1113,  // global thread storage
            S_LPROCMIPS = 0x1114,  // Local procedure start
            S_GPROCMIPS = 0x1115,  // Global procedure start
            S_COMPILE2 = 0x1116,  // extended compile flags and info
            S_MANYREG2 = 0x1117,  // multiple register variable
            S_LPROCIA64 = 0x1118,  // Local procedure start (IA64)
            S_GPROCIA64 = 0x1119,  // Global procedure start (IA64)
            S_LOCALSLOT = 0x111a,  // local IL sym with field for local slot index
            S_SLOT = S_LOCALSLOT,  // alias for LOCALSLOT
            S_PARAMSLOT = 0x111b,  // local IL sym with field for parameter slot index
            S_LMANDATA = 0x111c,
            S_GMANDATA = 0x111d,
            S_MANFRAMEREL = 0x111e,
            S_MANREGISTER = 0x111f,
            S_MANSLOT = 0x1120,
            S_MANMANYREG = 0x1121,
            S_MANREGREL = 0x1122,
            S_MANMANYREG2 = 0x1123,
            S_UNAMESPACE = 0x1124,  // Using namespace
            S_PROCREF = 0x1125,  // Reference to a procedure
            S_DATAREF = 0x1126,  // Reference to data
            S_LPROCREF = 0x1127,  // Local Reference to a procedure
            S_ANNOTATIONREF = 0x1128,  // Reference to an S_ANNOTATION symbol
            S_TOKENREF = 0x1129,  // Reference to one of the many MANPROCSYM's
            S_GMANPROC = 0x112a,  // Global proc
            S_LMANPROC = 0x112b,  // Local proc
            S_TRAMPOLINE = 0x112c,  // trampoline thunks
            S_MANCONSTANT = 0x112d,  // constants with metadata type info
            S_ATTR_FRAMEREL = 0x112e,  // relative to virtual frame ptr
            S_ATTR_REGISTER = 0x112f,  // stored in a register
            S_ATTR_REGREL = 0x1130,  // relative to register (alternate frame ptr)
            S_ATTR_MANYREG = 0x1131,  // stored in >1 register
            S_SEPCODE = 0x1132,
            S_LOCAL = 0x1133,  // defines a local symbol in optimized code
            S_DEFRANGE = 0x1134,  // defines a single range of addresses in which symbol can be evaluated
            S_DEFRANGE2 = 0x1135,  // defines ranges of addresses in which symbol can be evaluated
            S_SECTION = 0x1136,  // A COFF section in a PE executable
            S_COFFGROUP = 0x1137,  // A COFF group
            S_EXPORT = 0x1138,  // A export
            S_CALLSITEINFO = 0x1139,  // Indirect call site information
            S_FRAMECOOKIE = 0x113a,  // Security cookie information
            S_DISCARDED = 0x113b,  // Discarded by LINK /OPT:REF (experimental, see richards)
            S_RECTYPE_MAX,              // one greater than last
            S_RECTYPE_LAST = S_RECTYPE_MAX - 1,
        };

        private enum DEBUG_S_SUBSECTION
        {
            SYMBOLS = 0xF1,
            LINES = 0xF2,
            STRINGTABLE = 0xF3,
            FILECHKSMS = 0xF4,
            FRAMEDATA = 0xF5,
        }

        private struct OemSymbol
        {

            internal Guid idOem;

            internal uint typind;
            static OemSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 45903, 46155);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 45903, 46155);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 45903, 46155);
            }
            //internal byte[] rgl;        // user data, force 4-byte alignment
        };

        private Token2SourceLineExporter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24009, 46167, 46223);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24009, 46167, 46223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 46167, 46223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 46167, 46223);
            }
        }

        private static readonly XmlWriterSettings s_xmlWriterSettings;

        public static string TokenToSourceMap2Xml(Stream read, bool maskToken = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 46491, 48538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 46594, 46628);

                var
                builder = f_24009_46608_46627()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 46644, 48485);
                using (var
                writer = f_24009_46664_46710(builder, s_xmlWriterSettings)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 46744, 46782);

                    f_24009_46744_46781(writer, "token-map");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 46802, 46890);

                    List<PdbTokenLine>
                    list = f_24009_46828_46889(f_24009_46851_46888(f_24009_46851_46881(read)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 46908, 47665);

                    f_24009_46908_47664(list, (x, y) =>
                        {
                            int result = x.line.CompareTo(y.line);
                            if (result != 0)
                                return result;
                            result = x.column.CompareTo(y.column);
                            if (result != 0)
                                return result;
                            result = x.endLine.CompareTo(y.endLine);
                            if (result != 0)
                                return result;
                            result = x.endColumn.CompareTo(y.endColumn);
                            if (result != 0)
                                return result;
                            return x.token.CompareTo(y.token);
                        });
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 47685, 48409);
                        foreach (var rec in f_24009_47705_47709_I(list))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 47685, 48409);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 47751, 47794);

                            f_24009_47751_47793(writer, "token-location");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 47818, 47891);

                            f_24009_47818_47890(
                                                writer, "token", f_24009_47855_47889(rec.token, maskToken));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 47913, 47970);

                            f_24009_47913_47969(writer, "file", rec.sourceFile.name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 47992, 48055);

                            f_24009_47992_48054(writer, "start-line", f_24009_48034_48053(rec.line));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48077, 48144);

                            f_24009_48077_48143(writer, "start-column", f_24009_48121_48142(rec.column));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48166, 48230);

                            f_24009_48166_48229(writer, "end-line", f_24009_48206_48228(rec.endLine));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48252, 48320);

                            f_24009_48252_48319(writer, "end-column", f_24009_48294_48318(rec.endColumn));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48344, 48369);

                            f_24009_48344_48368(
                                                writer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 47685, 48409);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 725);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 725);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48429, 48454);

                    f_24009_48429_48453(
                                    writer);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(24009, 46644, 48485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48501, 48527);

                return f_24009_48508_48526(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 46491, 48538);

                System.Text.StringBuilder
                f_24009_46608_46627()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 46608, 46627);
                    return return_v;
                }


                System.Xml.XmlWriter
                f_24009_46664_46710(System.Text.StringBuilder
                output, System.Xml.XmlWriterSettings
                settings)
                {
                    var return_v = XmlWriter.Create(output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 46664, 46710);
                    return return_v;
                }


                int
                f_24009_46744_46781(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 46744, 46781);
                    return 0;
                }


                System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                f_24009_46851_46881(System.IO.Stream
                read)
                {
                    var return_v = LoadTokenToSourceMapping(read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 46851, 46881);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>.ValueCollection
                f_24009_46851_46888(System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 46851, 46888);
                    return return_v;
                }


                System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                f_24009_46828_46889(System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>.ValueCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>((System.Collections.Generic.IEnumerable<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 46828, 46889);
                    return return_v;
                }


                int
                f_24009_46908_47664(System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                this_param, System.Comparison<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                comparison)
                {
                    this_param.Sort(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 46908, 47664);
                    return 0;
                }


                int
                f_24009_47751_47793(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 47751, 47793);
                    return 0;
                }


                string
                f_24009_47855_47889(uint
                token, bool
                maskToken)
                {
                    var return_v = Token2String(token, maskToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 47855, 47889);
                    return return_v;
                }


                int
                f_24009_47818_47890(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteAttributeString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 47818, 47890);
                    return 0;
                }


                int
                f_24009_47913_47969(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteAttributeString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 47913, 47969);
                    return 0;
                }


                string
                f_24009_48034_48053(uint
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48034, 48053);
                    return return_v;
                }


                int
                f_24009_47992_48054(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteAttributeString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 47992, 48054);
                    return 0;
                }


                string
                f_24009_48121_48142(uint
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48121, 48142);
                    return return_v;
                }


                int
                f_24009_48077_48143(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteAttributeString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48077, 48143);
                    return 0;
                }


                string
                f_24009_48206_48228(uint
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48206, 48228);
                    return return_v;
                }


                int
                f_24009_48166_48229(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteAttributeString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48166, 48229);
                    return 0;
                }


                string
                f_24009_48294_48318(uint
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48294, 48318);
                    return return_v;
                }


                int
                f_24009_48252_48319(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteAttributeString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48252, 48319);
                    return 0;
                }


                int
                f_24009_48344_48368(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48344, 48368);
                    return 0;
                }


                System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                f_24009_47705_47709_I(System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 47705, 47709);
                    return return_v;
                }


                int
                f_24009_48429_48453(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48429, 48453);
                    return 0;
                }


                string
                f_24009_48508_48526(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48508, 48526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 46491, 48538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 46491, 48538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string Token2String(uint token, bool maskToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 48550, 48809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48637, 48674);

                string
                result = f_24009_48653_48673(token, "X8")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48688, 48763) || true) && (maskToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 48688, 48763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48720, 48763);

                    result = f_24009_48729_48751(result, 0, 2) + "xxxxxx";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 48688, 48763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48777, 48798);

                return "0x" + result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 48550, 48809);

                string
                f_24009_48653_48673(uint
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48653, 48673);
                    return return_v;
                }


                string
                f_24009_48729_48751(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48729, 48751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 48550, 48809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 48550, 48809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<uint, PdbTokenLine> LoadTokenToSourceMapping(Stream read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 48821, 50441);
                int nameStream = default(int);
                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo[] modules = default(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo[]);
                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiDbgHdr header = default(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiDbgHdr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 48929, 48993);

                var
                tokenToSourceMapping = f_24009_48956_48992()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49007, 49050);

                BitAccess
                bits = f_24009_49024_49049(512 * 1024)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49064, 49115);

                PdbFileHeader
                head = f_24009_49085_49114(read, bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49129, 49183);

                PdbReader
                reader = f_24009_49148_49182(read, head.pageSize)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49197, 49253);

                MsfDirectory
                dir = f_24009_49216_49252(reader, head, bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49269, 49303);

                f_24009_49269_49302(
                            dir.streams[1], reader, bits);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49317, 49373);

                Dictionary<string, int>
                nameIndex = f_24009_49353_49372(bits)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49387, 49532) || true) && (!f_24009_49392_49443(nameIndex, "/NAMES", out nameStream))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 49387, 49532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49477, 49517);

                    throw f_24009_49483_49516("No `name' stream");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 49387, 49532);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49548, 49591);

                f_24009_49548_49590(
                            dir.streams[nameStream], reader, bits);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49605, 49647);

                IntHashTable
                names = f_24009_49626_49646(bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49663, 49697);

                f_24009_49663_49696(
                            dir.streams[3], reader, bits);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49711, 49770);

                f_24009_49711_49769(bits, out modules, out header, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49786, 50386) || true) && (modules != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 49786, 50386);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49848, 49853);
                        for (int
        m = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49839, 50371) || true) && (m < f_24009_49859_49873(modules))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49875, 49878)
        , m++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 49839, 50371))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 49839, 50371);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49920, 49944);

                            var
                            module = modules[m]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 49966, 50352) || true) && (module.stream > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 49966, 50352);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50037, 50083);

                                f_24009_50037_50082(dir.streams[module.stream], reader, bits);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50109, 50329) || true) && (module.moduleName == "TokenSourceLineInfo")
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 50109, 50329);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50213, 50302);

                                    f_24009_50213_50301(bits, module, names, dir, nameIndex, reader, tokenToSourceMapping);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 50109, 50329);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 49966, 50352);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 533);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 533);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 49786, 50386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50402, 50430);

                return tokenToSourceMapping;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 48821, 50441);

                System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                f_24009_48956_48992()
                {
                    var return_v = new System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 48956, 48992);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                f_24009_49024_49049(int
                capacity)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49024, 49049);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbFileHeader
                f_24009_49085_49114(System.IO.Stream
                reader, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbFileHeader(reader, bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49085, 49114);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                f_24009_49148_49182(System.IO.Stream
                reader, int
                pageSize)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader(reader, pageSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49148, 49182);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.MsfDirectory
                f_24009_49216_49252(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                reader, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbFileHeader
                head, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.MsfDirectory(reader, head, bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49216, 49252);
                    return return_v;
                }


                int
                f_24009_49269_49302(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
                this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                reader, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    this_param.Read(reader, bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49269, 49302);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, int>
                f_24009_49353_49372(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = LoadNameIndex(bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49353, 49372);
                    return return_v;
                }


                bool
                f_24009_49392_49443(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49392, 49443);
                    return return_v;
                }


                System.Exception
                f_24009_49483_49516(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49483, 49516);
                    return return_v;
                }


                int
                f_24009_49548_49590(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
                this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                reader, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    this_param.Read(reader, bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49548, 49590);
                    return 0;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                f_24009_49626_49646(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = LoadNameStream(bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49626, 49646);
                    return return_v;
                }


                int
                f_24009_49663_49696(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
                this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                reader, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    this_param.Read(reader, bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49663, 49696);
                    return 0;
                }


                int
                f_24009_49711_49769(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits, out Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo[]
                modules, out Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiDbgHdr
                header, bool
                readStrings)
                {
                    LoadDbiStream(bits, out modules, out header, readStrings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 49711, 49769);
                    return 0;
                }


                int
                f_24009_49859_49873(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 49859, 49873);
                    return return_v;
                }


                int
                f_24009_50037_50082(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DataStream
                this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                reader, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    this_param.Read(reader, bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50037, 50082);
                    return 0;
                }


                int
                f_24009_50213_50301(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo
                module, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                names, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.MsfDirectory
                dir, System.Collections.Generic.Dictionary<string, int>
                nameIndex, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                reader, System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                tokenToSourceMapping)
                {
                    LoadTokenToSourceInfo(bits, module, names, dir, nameIndex, reader, tokenToSourceMapping);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50213, 50301);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 48821, 50441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 48821, 50441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<string, int> LoadNameIndex(BitAccess bits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 50453, 52206);
                int ver = default(int);
                int sig = default(int);
                int age = default(int);
                System.Guid guid = default(System.Guid);
                int buf = default(int);
                int cnt = default(int);
                int max = default(int);
                int ns = default(int);
                int ni = default(int);
                string name = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50546, 50609);

                Dictionary<string, int>
                result = f_24009_50579_50608()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50623, 50651);

                f_24009_50623_50650(bits, out ver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50686, 50714);

                f_24009_50686_50713(bits, out sig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50751, 50779);

                f_24009_50751_50778(bits, out age);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50810, 50838);

                f_24009_50810_50837(bits, out guid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50911, 50939);

                f_24009_50911_50938(
                            // Read string buffer.
                            bits, out buf);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 50985, 51009);

                int
                beg = f_24009_50995_51008(bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51023, 51053);

                int
                nxt = f_24009_51033_51046(bits) + buf
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51069, 51089);

                bits.Position = nxt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51140, 51168);

                f_24009_51140_51167(            // n+4..7 maximum ni.

                            bits, out cnt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51182, 51210);

                f_24009_51182_51209(bits, out max);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51226, 51260);

                BitSet
                present = f_24009_51243_51259(bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51274, 51308);

                BitSet
                deleted = f_24009_51291_51307(bits)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51322, 51459) || true) && (f_24009_51326_51342_M(!deleted.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 51322, 51459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51376, 51444);

                    throw f_24009_51382_51443("Unsupported PDB deleted bitset is not empty.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 51322, 51459);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51475, 51485);

                int
                j = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51508, 51513);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51499, 52017) || true) && (i < max)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51524, 51527)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 51499, 52017))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 51499, 52017);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51561, 52002) || true) && (present.IsSet(i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 51561, 52002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51623, 51650);

                            f_24009_51623_51649(bits, out ns);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51672, 51699);

                            f_24009_51672_51698(bits, out ni);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51723, 51749);

                            int
                            saved = f_24009_51735_51748(bits)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51771, 51796);

                            bits.Position = beg + ns;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51818, 51849);

                            f_24009_51818_51848(bits, out name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51871, 51893);

                            bits.Position = saved;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51917, 51957);

                            f_24009_51917_51956(
                                                result, f_24009_51928_51951(name), ni);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 51979, 51983);

                            j++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 51561, 52002);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 519);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52031, 52167) || true) && (j != cnt)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 52031, 52167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52077, 52152);

                    throw f_24009_52083_52151(f_24009_52097_52150("Count mismatch. ({0} != {1})", j, cnt));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 52031, 52167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52181, 52195);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 50453, 52206);

                System.Collections.Generic.Dictionary<string, int>
                f_24009_50579_50608()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50579, 50608);
                    return return_v;
                }


                int
                f_24009_50623_50650(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50623, 50650);
                    return 0;
                }


                int
                f_24009_50686_50713(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50686, 50713);
                    return 0;
                }


                int
                f_24009_50751_50778(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50751, 50778);
                    return 0;
                }


                int
                f_24009_50810_50837(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out System.Guid
                guid)
                {
                    this_param.ReadGuid(out guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50810, 50837);
                    return 0;
                }


                int
                f_24009_50911_50938(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 50911, 50938);
                    return 0;
                }


                int
                f_24009_50995_51008(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 50995, 51008);
                    return return_v;
                }


                int
                f_24009_51033_51046(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 51033, 51046);
                    return return_v;
                }


                int
                f_24009_51140_51167(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51140, 51167);
                    return 0;
                }


                int
                f_24009_51182_51209(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51182, 51209);
                    return 0;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitSet
                f_24009_51243_51259(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitSet(bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51243, 51259);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitSet
                f_24009_51291_51307(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitSet(bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51291, 51307);
                    return return_v;
                }


                bool
                f_24009_51326_51342_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 51326, 51342);
                    return return_v;
                }


                System.Exception
                f_24009_51382_51443(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51382, 51443);
                    return return_v;
                }


                int
                f_24009_51623_51649(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51623, 51649);
                    return 0;
                }


                int
                f_24009_51672_51698(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51672, 51698);
                    return 0;
                }


                int
                f_24009_51735_51748(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 51735, 51748);
                    return return_v;
                }


                int
                f_24009_51818_51848(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out string
                value)
                {
                    this_param.ReadCString(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51818, 51848);
                    return 0;
                }


                string
                f_24009_51928_51951(string
                this_param)
                {
                    var return_v = this_param.ToUpperInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51928, 51951);
                    return return_v;
                }


                int
                f_24009_51917_51956(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 51917, 51956);
                    return 0;
                }


                string
                f_24009_52097_52150(string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 52097, 52150);
                    return return_v;
                }


                System.Exception
                f_24009_52083_52151(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 52083, 52151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 50453, 52206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 50453, 52206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Guid s_msilMetaData;

        private static void LoadTokenToSourceInfo(
                    BitAccess bits, DbiModuleInfo module, IntHashTable names, MsfDirectory dir,
                    Dictionary<string, int> nameIndex, PdbReader reader, Dictionary<uint, PdbTokenLine> tokenToSourceMapping)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 52390, 55848);
                int sig = default(int);
                ushort siz = default(ushort);
                ushort rec = default(ushort);
                uint token = default(uint);
                uint file_id = default(uint);
                uint line = default(uint);
                uint column = default(uint);
                uint endLine = default(uint);
                uint endColumn = default(uint);
                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine tokenLine = default(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52665, 52683);

                bits.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52697, 52725);

                f_24009_52697_52724(bits, out sig);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52739, 52872) || true) && (sig != 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 52739, 52872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52785, 52857);

                    throw f_24009_52791_52856(f_24009_52805_52855("Invalid signature. (sig={0})", sig));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 52739, 52872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52888, 52906);

                bits.Position = 4;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52922, 55398) || true) && (f_24009_52929_52942(bits) < module.cbSyms)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 52922, 55398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52994, 53023);

                        f_24009_52994_53022(
                                        bits, out siz);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53041, 53066);

                        int
                        star = f_24009_53052_53065(bits)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53084, 53115);

                        int
                        stop = f_24009_53095_53108(bits) + siz
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53133, 53154);

                        bits.Position = star;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53172, 53201);

                        f_24009_53172_53200(bits, out rec);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53221, 55383);

                        switch ((SYM)rec)
                        {

                            case SYM.S_OEM:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 53221, 55383);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53320, 53334);

                                OemSymbol
                                oem
                                = default(OemSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53362, 53391);

                                f_24009_53362_53390(
                                                        bits, out oem.idOem);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53417, 53449);

                                f_24009_53417_53448(bits, out oem.typind);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53572, 55135) || true) && (oem.idOem == s_msilMetaData)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 53572, 55135);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53661, 53693);

                                    string
                                    name = f_24009_53675_53692(bits)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53723, 54817) || true) && (name == "TSLI")
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 53723, 54817);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53807, 53838);

                                        f_24009_53807_53837(bits, out token);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53872, 53905);

                                        f_24009_53872_53904(bits, out file_id);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 53939, 53969);

                                        f_24009_53939_53968(bits, out line);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54003, 54035);

                                        f_24009_54003_54034(bits, out column);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54069, 54102);

                                        f_24009_54069_54101(bits, out endLine);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54136, 54171);

                                        f_24009_54136_54170(bits, out endColumn);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54205, 54786) || true) && (!f_24009_54210_54268(tokenToSourceMapping, token, out tokenLine))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 54205, 54786);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54307, 54407);

                                            f_24009_54307_54406(tokenToSourceMapping, token, f_24009_54339_54405(token, file_id, line, column, endLine, endColumn));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 54205, 54786);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 54205, 54786);
                                            try
                                            {
                                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54518, 54625) || true) && (tokenLine.nextLine != null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 54518, 54625);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54594, 54625);

                                                    tokenLine = tokenLine.nextLine;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 54518, 54625);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 54518, 54625);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 54518, 54625);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54663, 54751);

                                            tokenLine.nextLine = f_24009_54684_54750(token, file_id, line, column, endLine, endColumn);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 54205, 54786);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 53723, 54817);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 54847, 54868);

                                    bits.Position = stop;
                                    DynAbs.Tracing.TraceSender.TraceBreak(24009, 54898, 54904);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 53572, 55135);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 53572, 55135);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55018, 55108);

                                    throw f_24009_55024_55107(f_24009_55038_55106("OEM section: guid={0} ti={1}", oem.idOem, oem.typind));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 53572, 55135);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 53221, 55383);

                            case SYM.S_END:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 53221, 55383);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55200, 55221);

                                bits.Position = stop;
                                DynAbs.Tracing.TraceSender.TraceBreak(24009, 55247, 55253);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 53221, 55383);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 53221, 55383);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55311, 55332);

                                bits.Position = stop;
                                DynAbs.Tracing.TraceSender.TraceBreak(24009, 55358, 55364);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 53221, 55383);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 52922, 55398);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 52922, 55398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 52922, 55398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55414, 55464);

                bits.Position = module.cbSyms + module.cbOldLines;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55478, 55541);

                int
                limit = module.cbSyms + module.cbOldLines + module.cbLines
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55555, 55651);

                IntHashTable
                sourceFiles = f_24009_55582_55650(bits, limit, names, dir, nameIndex, reader)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55665, 55837);
                    foreach (var tokenLineB in f_24009_55691_55718_I(f_24009_55691_55718(tokenToSourceMapping)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 55665, 55837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55752, 55822);

                        tokenLineB.sourceFile = (PdbSource)f_24009_55786_55821(sourceFiles, (int)tokenLineB.file_id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 55665, 55837);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 173);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 52390, 55848);

                int
                f_24009_52697_52724(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 52697, 52724);
                    return 0;
                }


                string
                f_24009_52805_52855(string
                format, int
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 52805, 52855);
                    return return_v;
                }


                System.Exception
                f_24009_52791_52856(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 52791, 52856);
                    return return_v;
                }


                int
                f_24009_52929_52942(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 52929, 52942);
                    return return_v;
                }


                int
                f_24009_52994_53022(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out ushort
                value)
                {
                    this_param.ReadUInt16(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 52994, 53022);
                    return 0;
                }


                int
                f_24009_53052_53065(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 53052, 53065);
                    return return_v;
                }


                int
                f_24009_53095_53108(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 53095, 53108);
                    return return_v;
                }


                int
                f_24009_53172_53200(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out ushort
                value)
                {
                    this_param.ReadUInt16(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 53172, 53200);
                    return 0;
                }


                int
                f_24009_53362_53390(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out System.Guid
                guid)
                {
                    this_param.ReadGuid(out guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 53362, 53390);
                    return 0;
                }


                int
                f_24009_53417_53448(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 53417, 53448);
                    return 0;
                }


                string
                f_24009_53675_53692(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.ReadString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 53675, 53692);
                    return return_v;
                }


                int
                f_24009_53807_53837(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 53807, 53837);
                    return 0;
                }


                int
                f_24009_53872_53904(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 53872, 53904);
                    return 0;
                }


                int
                f_24009_53939_53968(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 53939, 53968);
                    return 0;
                }


                int
                f_24009_54003_54034(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 54003, 54034);
                    return 0;
                }


                int
                f_24009_54069_54101(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 54069, 54101);
                    return 0;
                }


                int
                f_24009_54136_54170(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 54136, 54170);
                    return 0;
                }


                bool
                f_24009_54210_54268(System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                this_param, uint
                key, out Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 54210, 54268);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine
                f_24009_54339_54405(uint
                token, uint
                file_id, uint
                line, uint
                column, uint
                endLine, uint
                endColumn)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine(token, file_id, line, column, endLine, endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 54339, 54405);
                    return return_v;
                }


                int
                f_24009_54307_54406(System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                this_param, uint
                key, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 54307, 54406);
                    return 0;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine
                f_24009_54684_54750(uint
                token, uint
                file_id, uint
                line, uint
                column, uint
                endLine, uint
                endColumn)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine(token, file_id, line, column, endLine, endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 54684, 54750);
                    return return_v;
                }


                string
                f_24009_55038_55106(string
                format, System.Guid
                arg0, uint
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 55038, 55106);
                    return return_v;
                }


                System.Exception
                f_24009_55024_55107(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 55024, 55107);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                f_24009_55582_55650(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits, int
                limit, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                names, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.MsfDirectory
                dir, System.Collections.Generic.Dictionary<string, int>
                nameIndex, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbReader
                reader)
                {
                    var return_v = ReadSourceFileInfo(bits, (uint)limit, names, dir, nameIndex, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 55582, 55650);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>.ValueCollection
                f_24009_55691_55718(System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 55691, 55718);
                    return return_v;
                }


                object
                f_24009_55786_55821(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 55786, 55821);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>.ValueCollection
                f_24009_55691_55718_I(System.Collections.Generic.Dictionary<uint, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbTokenLine>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 55691, 55718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 52390, 55848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 52390, 55848);
            }
        }

        private static readonly Guid s_symDocumentTypeGuid;

        private static IntHashTable ReadSourceFileInfo(
                    BitAccess bits, uint limit, IntHashTable names, MsfDirectory dir,
                    Dictionary<string, int> nameIndex, PdbReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 55976, 57616);
                int sig = default(int);
                int siz = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56193, 56234);

                IntHashTable
                checks = f_24009_56215_56233()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56250, 56276);

                int
                begin = f_24009_56262_56275(bits)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56290, 57577) || true) && (f_24009_56297_56310(bits) < limit)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 56290, 57577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56352, 56380);

                        f_24009_56352_56379(bits, out sig);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56398, 56426);

                        f_24009_56398_56425(bits, out siz);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56444, 56470);

                        int
                        place = f_24009_56456_56469(bits)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56488, 56521);

                        int
                        endSym = f_24009_56501_56514(bits) + siz
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56541, 57562);

                        switch ((DEBUG_S_SUBSECTION)sig)
                        {

                            case DEBUG_S_SUBSECTION.FILECHKSMS:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 56541, 57562);
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56675, 57349) || true) && (f_24009_56682_56695(bits) < endSym)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 56675, 57349);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56762, 56782);

                                        CV_FileCheckSum
                                        chk
                                        = default(CV_FileCheckSum);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56814, 56845);

                                        int
                                        ni = f_24009_56823_56836(bits) - place
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56875, 56905);

                                        f_24009_56875_56904(bits, out chk.name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56935, 56963);

                                        f_24009_56935_56962(bits, out chk.len);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 56993, 57022);

                                        f_24009_56993_57021(bits, out chk.type);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57052, 57173);

                                        PdbSource
                                        src = f_24009_57068_57172((string)f_24009_57104_57124(names, (int)chk.name), s_symDocumentTypeGuid, Guid.Empty, Guid.Empty)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57203, 57223);

                                        f_24009_57203_57222(checks, ni, src);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57253, 57278);

                                        bits.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => chk.len, 24009, 57253, 57266);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57308, 57322);

                                        f_24009_57308_57321(bits, 4);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 56675, 57349);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 56675, 57349);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 56675, 57349);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57375, 57398);

                                bits.Position = endSym;
                                DynAbs.Tracing.TraceSender.TraceBreak(24009, 57424, 57430);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 56541, 57562);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 56541, 57562);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57488, 57511);

                                bits.Position = endSym;
                                DynAbs.Tracing.TraceSender.TraceBreak(24009, 57537, 57543);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 56541, 57562);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 56290, 57577);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 56290, 57577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 56290, 57577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57591, 57605);

                return checks;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 55976, 57616);

                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                f_24009_56215_56233()
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 56215, 56233);
                    return return_v;
                }


                int
                f_24009_56262_56275(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 56262, 56275);
                    return return_v;
                }


                int
                f_24009_56297_56310(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 56297, 56310);
                    return return_v;
                }


                int
                f_24009_56352_56379(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 56352, 56379);
                    return 0;
                }


                int
                f_24009_56398_56425(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 56398, 56425);
                    return 0;
                }


                int
                f_24009_56456_56469(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 56456, 56469);
                    return return_v;
                }


                int
                f_24009_56501_56514(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 56501, 56514);
                    return return_v;
                }


                int
                f_24009_56682_56695(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 56682, 56695);
                    return return_v;
                }


                int
                f_24009_56823_56836(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 56823, 56836);
                    return return_v;
                }


                int
                f_24009_56875_56904(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 56875, 56904);
                    return 0;
                }


                int
                f_24009_56935_56962(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out byte
                value)
                {
                    this_param.ReadUInt8(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 56935, 56962);
                    return 0;
                }


                int
                f_24009_56993_57021(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out byte
                value)
                {
                    this_param.ReadUInt8(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 56993, 57021);
                    return 0;
                }


                object
                f_24009_57104_57124(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 57104, 57124);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbSource
                f_24009_57068_57172(object
                name, System.Guid
                doctype, System.Guid
                language, System.Guid
                vendor)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbSource((string)name, doctype, language, vendor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 57068, 57172);
                    return return_v;
                }


                int
                f_24009_57203_57222(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                this_param, int
                key, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.PdbSource
                value)
                {
                    this_param.Add(key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 57203, 57222);
                    return 0;
                }


                int
                f_24009_57308_57321(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, int
                alignment)
                {
                    this_param.Align(alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 57308, 57321);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 55976, 57616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 55976, 57616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IntHashTable LoadNameStream(BitAccess bits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 57628, 58957);
                uint sig = default(uint);
                int ver = default(int);
                int buf = default(int);
                int siz = default(int);
                int ni = default(int);
                string name = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57711, 57748);

                IntHashTable
                ht = f_24009_57729_57747()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57762, 57791);

                f_24009_57762_57790(bits, out sig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57827, 57855);

                f_24009_57827_57854(bits, out ver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 57938, 57966);

                f_24009_57938_57965(
                            // Read (or skip) string buffer.
                            bits, out buf);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58012, 58197) || true) && (sig != 0xeffeeffe || (DynAbs.Tracing.TraceSender.Expression_False(24009, 58016, 58045) || ver != 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 58012, 58197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58079, 58182);

                    throw f_24009_58085_58181(f_24009_58099_58180("Unsupported Name Stream version. (sig={0:x8}, ver={1})", sig, ver));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 58012, 58197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58211, 58235);

                int
                beg = f_24009_58221_58234(bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58249, 58279);

                int
                nxt = f_24009_58259_58272(bits) + buf
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58293, 58313);

                bits.Position = nxt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58362, 58390);

                f_24009_58362_58389(
                            // Read hash table.
                            bits, out siz);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58441, 58461);

                nxt = f_24009_58447_58460(bits);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58486, 58491);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58477, 58886) || true) && (i < siz)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58502, 58505)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 58477, 58886))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 58477, 58886);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58541, 58568);

                        f_24009_58541_58567(
                                        bits, out ni);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58588, 58871) || true) && (ni != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 58588, 58871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58641, 58667);

                            int
                            saved = f_24009_58653_58666(bits)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58689, 58714);

                            bits.Position = beg + ni;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58736, 58767);

                            f_24009_58736_58766(bits, out name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58789, 58811);

                            bits.Position = saved;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58835, 58852);

                            f_24009_58835_58851(
                                                ht, ni, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 58588, 58871);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 1, 410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 1, 410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58900, 58920);

                bits.Position = nxt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 58936, 58946);

                return ht;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 57628, 58957);

                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                f_24009_57729_57747()
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 57729, 57747);
                    return return_v;
                }


                int
                f_24009_57762_57790(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out uint
                value)
                {
                    this_param.ReadUInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 57762, 57790);
                    return 0;
                }


                int
                f_24009_57827_57854(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 57827, 57854);
                    return 0;
                }


                int
                f_24009_57938_57965(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 57938, 57965);
                    return 0;
                }


                string
                f_24009_58099_58180(string
                format, uint
                arg0, int
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 58099, 58180);
                    return return_v;
                }


                System.Exception
                f_24009_58085_58181(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 58085, 58181);
                    return return_v;
                }


                int
                f_24009_58221_58234(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 58221, 58234);
                    return return_v;
                }


                int
                f_24009_58259_58272(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 58259, 58272);
                    return return_v;
                }


                int
                f_24009_58362_58389(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 58362, 58389);
                    return 0;
                }


                int
                f_24009_58447_58460(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 58447, 58460);
                    return return_v;
                }


                int
                f_24009_58541_58567(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out int
                value)
                {
                    this_param.ReadInt32(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 58541, 58567);
                    return 0;
                }


                int
                f_24009_58653_58666(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 58653, 58666);
                    return return_v;
                }


                int
                f_24009_58736_58766(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param, out string
                value)
                {
                    this_param.ReadCString(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 58736, 58766);
                    return 0;
                }


                int
                f_24009_58835_58851(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.IntHashTable
                this_param, int
                key, string
                value)
                {
                    this_param.Add(key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 58835, 58851);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 57628, 58957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 57628, 58957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void LoadDbiStream(BitAccess bits, out DbiModuleInfo[] modules, out DbiDbgHdr header, bool readStrings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24009, 58969, 60610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59112, 59147);

                DbiHeader
                dh = f_24009_59127_59146(bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59161, 59186);

                header = f_24009_59170_59185();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59238, 59278);

                var
                modList = f_24009_59252_59277()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59292, 59332);

                int
                end = f_24009_59302_59315(bits) + dh.gpmodiSize
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59346, 59513) || true) && (f_24009_59353_59366(bits) < end)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 59346, 59513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59406, 59463);

                        DbiModuleInfo
                        mod = f_24009_59426_59462(bits, readStrings)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59481, 59498);

                        f_24009_59481_59497(modList, mod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 59346, 59513);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24009, 59346, 59513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24009, 59346, 59513);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59527, 59699) || true) && (f_24009_59531_59544(bits) != end)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 59527, 59699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59585, 59684);

                    throw f_24009_59591_59683(f_24009_59605_59682("Error reading DBI stream, pos={0} != {1}", f_24009_59663_59676(bits), end));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 59527, 59699);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59715, 59894) || true) && (f_24009_59719_59732(modList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 59715, 59894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59770, 59798);

                    modules = f_24009_59780_59797(modList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 59715, 59894);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 59715, 59894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59864, 59879);

                    modules = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 59715, 59894);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 59967, 59998);

                bits.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => dh.secconSize, 24009, 59967, 59980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60062, 60093);

                bits.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => dh.secmapSize, 24009, 60062, 60075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60155, 60186);

                bits.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => dh.filinfSize, 24009, 60155, 60168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60242, 60272);

                bits.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => dh.tsmapSize, 24009, 60242, 60255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60327, 60358);

                bits.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => dh.ecinfoSize, 24009, 60327, 60340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60416, 60452);

                end = f_24009_60422_60435(bits) + dh.dbghdrSize;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60466, 60565) || true) && (dh.dbghdrSize > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24009, 60466, 60565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60521, 60550);

                    header = f_24009_60530_60549(bits);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24009, 60466, 60565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 60579, 60599);

                bits.Position = end;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24009, 58969, 60610);

                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiHeader
                f_24009_59127_59146(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiHeader(bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59127, 59146);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiDbgHdr
                f_24009_59170_59185()
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiDbgHdr();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59170, 59185);
                    return return_v;
                }


                System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo>
                f_24009_59252_59277()
                {
                    var return_v = new System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59252, 59277);
                    return return_v;
                }


                int
                f_24009_59302_59315(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 59302, 59315);
                    return return_v;
                }


                int
                f_24009_59353_59366(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 59353, 59366);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo
                f_24009_59426_59462(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits, bool
                readStrings)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo(bits, readStrings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59426, 59462);
                    return return_v;
                }


                int
                f_24009_59481_59497(System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo>
                this_param, Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59481, 59497);
                    return 0;
                }


                int
                f_24009_59531_59544(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 59531, 59544);
                    return return_v;
                }


                int
                f_24009_59663_59676(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 59663, 59676);
                    return return_v;
                }


                string
                f_24009_59605_59682(string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59605, 59682);
                    return return_v;
                }


                System.Exception
                f_24009_59591_59683(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59591, 59683);
                    return return_v;
                }


                int
                f_24009_59719_59732(System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 59719, 59732);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo[]
                f_24009_59780_59797(System.Collections.Generic.List<Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiModuleInfo>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 59780, 59797);
                    return return_v;
                }


                int
                f_24009_60422_60435(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 60422, 60435);
                    return return_v;
                }


                Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiDbgHdr
                f_24009_60530_60549(Roslyn.Test.PdbUtilities.Token2SourceLineExporter.BitAccess
                bits)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.Token2SourceLineExporter.DbiDbgHdr(bits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 60530, 60549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24009, 58969, 60610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 58969, 60610);
            }
        }

        static Token2SourceLineExporter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24009, 381, 60617);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 46277, 46478);
            s_xmlWriterSettings = new XmlWriterSettings
            {
                Encoding = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_24009_46356_46369(), 24009, 46299, 46478),
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n"
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 52247, 52377);
            s_msilMetaData = f_24009_52277_52377(unchecked(0xc6ea3fc9), 0x59b3, 0x49d6, 0xbc, 0x25, 0x09, 0x02, 0xbb, 0xab, 0xb4, 0x60); DynAbs.Tracing.TraceSender.TraceSimpleStatement(24009, 55889, 55963);
            s_symDocumentTypeGuid = f_24009_55913_55963("{5a869d0b-6611-11d3-bd2a-0000f80849bd}"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24009, 381, 60617);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24009, 381, 60617);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24009, 381, 60617);

        static System.Text.Encoding
        f_24009_46356_46369()
        {
            var return_v = Encoding.UTF8;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24009, 46356, 46369);
            return return_v;
        }


        static System.Guid
        f_24009_52277_52377(uint
        a, int
        b, int
        c, int
        d, int
        e, int
        f, int
        g, int
        h, int
        i, int
        j, int
        k)
        {
            var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 52277, 52377);
            return return_v;
        }


        static System.Guid
        f_24009_55913_55963(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24009, 55913, 55963);
            return return_v;
        }

    }
}
