// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;
using static System.Buffers.Binary.BinaryPrimitives;

namespace Microsoft.CodeAnalysis
{

    internal ref struct LittleEndianReader
    {

        private ReadOnlySpan<byte> _span;

        public LittleEndianReader(ReadOnlySpan<byte> span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(345, 560, 659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 635, 648);

                _span = span;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(345, 560, 659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(345, 560, 659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 560, 659);
            }
        }

        internal uint ReadUInt32()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(345, 671, 852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 722, 765);

                var
                result = f_345_735_764(_span)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 779, 813);

                _span = _span.Slice(sizeof(uint));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 827, 841);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(345, 671, 852);

                uint
                f_345_735_764(System.ReadOnlySpan<byte>
                source)
                {
                    var return_v = ReadUInt32LittleEndian(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(345, 735, 764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(345, 671, 852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 671, 852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal byte ReadByte()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(345, 864, 1022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 913, 935);

                var
                result = _span[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 949, 983);

                _span = _span.Slice(sizeof(byte));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 997, 1011);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(345, 864, 1022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(345, 864, 1022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 864, 1022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ushort ReadUInt16()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(345, 1034, 1219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1087, 1130);

                var
                result = f_345_1100_1129(_span)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1144, 1180);

                _span = _span.Slice(sizeof(ushort));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1194, 1208);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(345, 1034, 1219);

                ushort
                f_345_1100_1129(System.ReadOnlySpan<byte>
                source)
                {
                    var return_v = ReadUInt16LittleEndian(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(345, 1100, 1129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(345, 1034, 1219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 1034, 1219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ReadOnlySpan<byte> ReadBytes(int byteCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(345, 1231, 1431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1308, 1347);

                var
                result = _span.Slice(0, byteCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1361, 1392);

                _span = _span.Slice(byteCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1406, 1420);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(345, 1231, 1431);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(345, 1231, 1431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 1231, 1431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int ReadInt32()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(345, 1443, 1620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1492, 1534);

                var
                result = f_345_1505_1533(_span)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1548, 1581);

                _span = _span.Slice(sizeof(int));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1595, 1609);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(345, 1443, 1620);

                int
                f_345_1505_1533(System.ReadOnlySpan<byte>
                source)
                {
                    var return_v = ReadInt32LittleEndian(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(345, 1505, 1533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(345, 1443, 1620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 1443, 1620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal byte[] ReadReversed(int byteCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(345, 1632, 1822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1700, 1744);

                var
                result = ReadBytes(byteCount).ToArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1758, 1783);

                f_345_1758_1782(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(345, 1797, 1811);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(345, 1632, 1822);

                int
                f_345_1758_1782(byte[]
                array)
                {
                    array.ReverseContents<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(345, 1758, 1782);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(345, 1632, 1822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 1632, 1822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LittleEndianReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(345, 460, 1829);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(345, 460, 1829);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(345, 460, 1829);
        }
    }
}
