// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
#if COMPILERCORE
    using Resources = CodeAnalysisResources;
#elif CODE_STYLE
    using Resources = CodeStyleResources;
#else
    using Resources = WorkspacesResources;
#endif

    using EncodingKind = ObjectWriter.EncodingKind;
    internal sealed partial class ObjectReader : IDisposable
    {
        internal const byte
        VersionByte1 = 0b10101010
        ;

        internal const byte
        VersionByte2 = 0b00001011
        ;

        private readonly BinaryReader _reader;

        private readonly CancellationToken _cancellationToken;

        private readonly ReaderReferenceMap<object> _objectReferenceMap;

        private readonly ReaderReferenceMap<string> _stringReferenceMap;

        private readonly ObjectBinderSnapshot _binderSnapshot;

        private int _recursionDepth;

        private ObjectReader(
                    Stream stream,
                    bool leaveOpen,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(543, 2670, 3533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 1392, 1399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 2253, 2268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 2981, 3023);

                f_543_2981_3022(BitConverter.IsLittleEndian);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 3039, 3100);

                _reader = f_543_3049_3099(stream, f_543_3074_3087(), leaveOpen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 3114, 3172);

                _objectReferenceMap = ReaderReferenceMap<object>.Create();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 3186, 3244);

                _stringReferenceMap = ReaderReferenceMap<string>.Create();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 3422, 3467);

                _binderSnapshot = f_543_3440_3466();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 3483, 3522);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(543, 2670, 3533);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 2670, 3533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 2670, 3533);
            }
        }

        public static ObjectReader TryGetReader(
                    Stream stream,
                    bool leaveOpen = false,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(543, 3839, 4365);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 4029, 4108) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 4029, 4108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 4081, 4093);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 4029, 4108);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 4124, 4276) || true) && (f_543_4128_4145(stream) != VersionByte1 || (DynAbs.Tracing.TraceSender.Expression_False(543, 4128, 4215) || f_543_4182_4199(stream) != VersionByte2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 4124, 4276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 4249, 4261);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 4124, 4276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 4292, 4354);

                return f_543_4299_4353(stream, leaveOpen, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(543, 3839, 4365);

                int
                f_543_4128_4145(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 4128, 4145);
                    return return_v;
                }


                int
                f_543_4182_4199(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 4182, 4199);
                    return return_v;
                }


                Roslyn.Utilities.ObjectReader
                f_543_4299_4353(System.IO.Stream
                stream, bool
                leaveOpen, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Roslyn.Utilities.ObjectReader(stream, leaveOpen, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 4299, 4353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 3839, 4365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 3839, 4365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ObjectReader GetReader(
                    Stream stream,
                    bool leaveOpen,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(543, 4794, 5590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 4963, 4989);

                var
                b = f_543_4971_4988(stream)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5003, 5096) || true) && (b == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 5003, 5096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5048, 5081);

                    throw f_543_5054_5080();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 5003, 5096);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5112, 5226) || true) && (b != VersionByte1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 5112, 5226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5167, 5211);

                    throw f_543_5173_5210(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 5112, 5226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5242, 5264);

                b = f_543_5246_5263(stream);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5278, 5371) || true) && (b == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 5278, 5371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5323, 5356);

                    throw f_543_5329_5355();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 5278, 5371);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5387, 5501) || true) && (b != VersionByte2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 5387, 5501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5442, 5486);

                    throw f_543_5448_5485(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 5387, 5501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5517, 5579);

                return f_543_5524_5578(stream, leaveOpen, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(543, 4794, 5590);

                int
                f_543_4971_4988(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 4971, 4988);
                    return return_v;
                }


                System.IO.EndOfStreamException
                f_543_5054_5080()
                {
                    var return_v = new System.IO.EndOfStreamException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5054, 5080);
                    return return_v;
                }


                System.Exception
                f_543_5173_5210(int
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5173, 5210);
                    return return_v;
                }


                int
                f_543_5246_5263(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5246, 5263);
                    return return_v;
                }


                System.IO.EndOfStreamException
                f_543_5329_5355()
                {
                    var return_v = new System.IO.EndOfStreamException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5329, 5355);
                    return return_v;
                }


                System.Exception
                f_543_5448_5485(int
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5448, 5485);
                    return return_v;
                }


                Roslyn.Utilities.ObjectReader
                f_543_5524_5578(System.IO.Stream
                stream, bool
                leaveOpen, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Roslyn.Utilities.ObjectReader(stream, leaveOpen, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5524, 5578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 4794, 5590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 4794, 5590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 5602, 5767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5648, 5678);

                _objectReferenceMap.Dispose();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5692, 5722);

                _stringReferenceMap.Dispose();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5736, 5756);

                _recursionDepth = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 5602, 5767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 5602, 5767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 5602, 5767);
            }
        }

        public bool ReadBoolean()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 5805, 5829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5808, 5829);
                return f_543_5808_5829(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 5805, 5829);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 5805, 5829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 5805, 5829);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_543_5808_5829(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadBoolean();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5808, 5829);
                return return_v;
            }

        }

        public byte ReadByte()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 5863, 5884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 5866, 5884);
                return f_543_5866_5884(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 5863, 5884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 5863, 5884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 5863, 5884);
            }
            throw new System.Exception("Slicer error: unreachable code");

            byte
            f_543_5866_5884(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadByte();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 5866, 5884);
                return return_v;
            }

        }

        public char ReadChar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6009, 6038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6012, 6038);
                return (char)f_543_6018_6038(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6009, 6038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6009, 6038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6009, 6038);
            }
            throw new System.Exception("Slicer error: unreachable code");

            ushort
            f_543_6018_6038(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadUInt16();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6018, 6038);
                return return_v;
            }

        }

        public decimal ReadDecimal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6078, 6102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6081, 6102);
                return f_543_6081_6102(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6078, 6102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6078, 6102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6078, 6102);
            }
            throw new System.Exception("Slicer error: unreachable code");

            decimal
            f_543_6081_6102(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadDecimal();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6081, 6102);
                return return_v;
            }

        }

        public double ReadDouble()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6140, 6163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6143, 6163);
                return f_543_6143_6163(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6140, 6163);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6140, 6163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6140, 6163);
            }
            throw new System.Exception("Slicer error: unreachable code");

            double
            f_543_6143_6163(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadDouble();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6143, 6163);
                return return_v;
            }

        }

        public float ReadSingle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6200, 6223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6203, 6223);
                return f_543_6203_6223(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6200, 6223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6200, 6223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6200, 6223);
            }
            throw new System.Exception("Slicer error: unreachable code");

            float
            f_543_6203_6223(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadSingle();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6203, 6223);
                return return_v;
            }

        }

        public int ReadInt32()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6257, 6279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6260, 6279);
                return f_543_6260_6279(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6257, 6279);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6257, 6279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6257, 6279);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_543_6260_6279(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadInt32();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6260, 6279);
                return return_v;
            }

        }

        public long ReadInt64()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6314, 6336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6317, 6336);
                return f_543_6317_6336(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6314, 6336);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6314, 6336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6314, 6336);
            }
            throw new System.Exception("Slicer error: unreachable code");

            long
            f_543_6317_6336(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadInt64();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6317, 6336);
                return return_v;
            }

        }

        public sbyte ReadSByte()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6372, 6394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6375, 6394);
                return f_543_6375_6394(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6372, 6394);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6372, 6394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6372, 6394);
            }
            throw new System.Exception("Slicer error: unreachable code");

            sbyte
            f_543_6375_6394(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadSByte();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6375, 6394);
                return return_v;
            }

        }

        public short ReadInt16()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6430, 6452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6433, 6452);
                return f_543_6433_6452(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6430, 6452);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6430, 6452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6430, 6452);
            }
            throw new System.Exception("Slicer error: unreachable code");

            short
            f_543_6433_6452(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadInt16();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6433, 6452);
                return return_v;
            }

        }

        public uint ReadUInt32()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6488, 6511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6491, 6511);
                return f_543_6491_6511(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6488, 6511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6488, 6511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6488, 6511);
            }
            throw new System.Exception("Slicer error: unreachable code");

            uint
            f_543_6491_6511(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadUInt32();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6491, 6511);
                return return_v;
            }

        }

        public ulong ReadUInt64()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6548, 6571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6551, 6571);
                return f_543_6551_6571(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6548, 6571);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6548, 6571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6548, 6571);
            }
            throw new System.Exception("Slicer error: unreachable code");

            ulong
            f_543_6551_6571(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadUInt64();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6551, 6571);
                return return_v;
            }

        }

        public ushort ReadUInt16()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6609, 6632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6612, 6632);
                return f_543_6612_6632(_reader); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6609, 6632);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6609, 6632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6609, 6632);
            }
            throw new System.Exception("Slicer error: unreachable code");

            ushort
            f_543_6612_6632(System.IO.BinaryReader
            this_param)
            {
                var return_v = this_param.ReadUInt16();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6612, 6632);
                return return_v;
            }

        }

        public string ReadString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6670, 6690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6673, 6690);
                return f_543_6673_6690(this); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6670, 6690);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6670, 6690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6670, 6690);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_543_6673_6690(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadStringValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6673, 6690);
                return return_v;
            }

        }

        public Guid ReadGuid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6703, 6949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6750, 6901);

                var
                accessor = new ObjectWriter.GuidAccessor
                {
                    Low64 = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_543_6835_6846(this), 543, 6765, 6900),
                    High64 = f_543_6874_6885(this)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 6917, 6938);

                return accessor.Guid;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6703, 6949);

                long
                f_543_6835_6846(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6835, 6846);
                    return return_v;
                }


                long
                f_543_6874_6885(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 6874, 6885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6703, 6949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6703, 6949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object ReadValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 6961, 8516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 7011, 7042);

                var
                oldDepth = _recursionDepth
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 7056, 7074);

                _recursionDepth++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 7090, 7103);

                object
                value
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 7117, 8386) || true) && (_recursionDepth % ObjectWriter.MaxRecursionDepth == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 7117, 8386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 7343, 7562);

                    var
                    task = f_543_7354_7561(f_543_7354_7366(), () => ReadValueWorker(), _cancellationToken, TaskCreationOptions.LongRunning, f_543_7539_7560())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8241, 8279);

                    value = f_543_8249_8266(task).GetResult();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 7117, 8386);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 7117, 8386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8345, 8371);

                    value = f_543_8353_8370(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 7117, 8386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8402, 8420);

                _recursionDepth--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8434, 8476);

                f_543_8434_8475(oldDepth == _recursionDepth);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8492, 8505);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 6961, 8516);

                System.Threading.Tasks.TaskFactory
                f_543_7354_7366()
                {
                    var return_v = Task.Factory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 7354, 7366);
                    return return_v;
                }


                System.Threading.Tasks.TaskScheduler
                f_543_7539_7560()
                {
                    var return_v = TaskScheduler.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 7539, 7560);
                    return return_v;
                }


                System.Threading.Tasks.Task<object>
                f_543_7354_7561(System.Threading.Tasks.TaskFactory
                this_param, System.Func<object>
                function, System.Threading.CancellationToken
                cancellationToken, System.Threading.Tasks.TaskCreationOptions
                creationOptions, System.Threading.Tasks.TaskScheduler
                scheduler)
                {
                    var return_v = this_param.StartNew<object>(function, cancellationToken, creationOptions, scheduler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 7354, 7561);
                    return return_v;
                }


                System.Runtime.CompilerServices.TaskAwaiter<object>
                f_543_8249_8266(System.Threading.Tasks.Task<object>
                this_param)
                {
                    var return_v = this_param.GetAwaiter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 8249, 8266);
                    return return_v;
                }


                object
                f_543_8353_8370(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadValueWorker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 8353, 8370);
                    return return_v;
                }


                int
                f_543_8434_8475(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 8434, 8475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 6961, 8516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 6961, 8516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object ReadValueWorker()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 8528, 13381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8585, 8629);

                var
                kind = (EncodingKind)f_543_8610_8628(_reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8643, 13370);

                switch (kind)
                {

                    case EncodingKind.Null:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8713, 8725);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Boolean_True:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8775, 8787);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Boolean_False:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8838, 8851);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Int8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8893, 8920);

                        return f_543_8900_8919(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.UInt8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 8963, 8989);

                        return f_543_8970_8988(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 9032, 9059);

                        return f_543_9039_9058(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 9103, 9131);

                        return f_543_9110_9130(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 9174, 9201);

                        return f_543_9181_9200(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Int32_1Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 9250, 9281);

                        return (int)f_543_9262_9280(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Int32_2Bytes:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 9331, 9364);

                        return (int)f_543_9343_9363(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Int32_0:
                    case EncodingKind.Int32_1:
                    case EncodingKind.Int32_2:
                    case EncodingKind.Int32_3:
                    case EncodingKind.Int32_4:
                    case EncodingKind.Int32_5:
                    case EncodingKind.Int32_6:
                    case EncodingKind.Int32_7:
                    case EncodingKind.Int32_8:
                    case EncodingKind.Int32_9:
                    case EncodingKind.Int32_10:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 9871, 9916);

                        return (int)kind - (int)EncodingKind.Int32_0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 9960, 9988);

                        return f_543_9967_9987(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.UInt32_1Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 10038, 10070);

                        return (uint)f_543_10051_10069(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.UInt32_2Bytes:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 10121, 10155);

                        return (uint)f_543_10134_10154(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.UInt32_0:
                    case EncodingKind.UInt32_1:
                    case EncodingKind.UInt32_2:
                    case EncodingKind.UInt32_3:
                    case EncodingKind.UInt32_4:
                    case EncodingKind.UInt32_5:
                    case EncodingKind.UInt32_6:
                    case EncodingKind.UInt32_7:
                    case EncodingKind.UInt32_8:
                    case EncodingKind.UInt32_9:
                    case EncodingKind.UInt32_10:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 10673, 10727);

                        return (uint)((int)kind - (int)EncodingKind.UInt32_0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 10770, 10797);

                        return f_543_10777_10796(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 10841, 10869);

                        return f_543_10848_10868(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Float4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 10913, 10941);

                        return f_543_10920_10940(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Float8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 10985, 11013);

                        return f_543_10992_11012(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 11058, 11087);

                        return f_543_11065_11086(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 11253, 11287);

                        return (char)f_543_11266_11286(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.StringUtf8:
                    case EncodingKind.StringUtf16:
                    case EncodingKind.StringRef_4Bytes:
                    case EncodingKind.StringRef_1Byte:
                    case EncodingKind.StringRef_2Bytes:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 11562, 11591);

                        return f_543_11569_11590(this, kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.ObjectRef_4Bytes:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 11645, 11702);

                        return _objectReferenceMap.GetValue(f_543_11681_11700(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.ObjectRef_1Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 11755, 11811);

                        return _objectReferenceMap.GetValue(f_543_11791_11809(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.ObjectRef_2Bytes:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 11865, 11923);

                        return _objectReferenceMap.GetValue(f_543_11901_11921(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 11967, 11987);

                        return f_543_11974_11986(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12033, 12081);

                        return DateTime.FromBinary(f_543_12060_12079(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.Array:
                    case EncodingKind.Array_0:
                    case EncodingKind.Array_1:
                    case EncodingKind.Array_2:
                    case EncodingKind.Array_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12321, 12344);

                        return f_543_12328_12343(this, kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12396, 12438);

                        return f_543_12403_12437(f_543_12424_12436(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUTF8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12488, 12510);

                        return s_encodingUTF8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUTF8_BOM:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12564, 12585);

                        return f_543_12571_12584();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUTF32_BE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12639, 12665);

                        return s_encodingUTF32_BE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUTF32_BE_BOM:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12723, 12753);

                        return s_encodingUTF32_BE_BOM;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUTF32_LE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12807, 12833);

                        return s_encodingUTF32_LE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUTF32_LE_BOM:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12891, 12913);

                        return f_543_12898_12912();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUnicode_BE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 12969, 12997);

                        return s_encodingUnicode_BE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUnicode_BE_BOM:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13057, 13090);

                        return f_543_13064_13089();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUnicode_LE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13146, 13174);

                        return s_encodingUnicode_LE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    case EncodingKind.EncodingUnicode_LE_BOM:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13234, 13258);

                        return f_543_13241_13257();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 8643, 13370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13308, 13355);

                        throw f_543_13314_13354(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 8643, 13370);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 8528, 13381);

                byte
                f_543_8610_8628(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 8610, 8628);
                    return return_v;
                }


                sbyte
                f_543_8900_8919(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadSByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 8900, 8919);
                    return return_v;
                }


                byte
                f_543_8970_8988(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 8970, 8988);
                    return return_v;
                }


                short
                f_543_9039_9058(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 9039, 9058);
                    return return_v;
                }


                ushort
                f_543_9110_9130(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 9110, 9130);
                    return return_v;
                }


                int
                f_543_9181_9200(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 9181, 9200);
                    return return_v;
                }


                byte
                f_543_9262_9280(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 9262, 9280);
                    return return_v;
                }


                ushort
                f_543_9343_9363(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 9343, 9363);
                    return return_v;
                }


                uint
                f_543_9967_9987(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 9967, 9987);
                    return return_v;
                }


                byte
                f_543_10051_10069(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 10051, 10069);
                    return return_v;
                }


                ushort
                f_543_10134_10154(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 10134, 10154);
                    return return_v;
                }


                long
                f_543_10777_10796(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 10777, 10796);
                    return return_v;
                }


                ulong
                f_543_10848_10868(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 10848, 10868);
                    return return_v;
                }


                float
                f_543_10920_10940(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 10920, 10940);
                    return return_v;
                }


                double
                f_543_10992_11012(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 10992, 11012);
                    return return_v;
                }


                decimal
                f_543_11065_11086(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadDecimal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 11065, 11086);
                    return return_v;
                }


                ushort
                f_543_11266_11286(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 11266, 11286);
                    return return_v;
                }


                string
                f_543_11569_11590(Roslyn.Utilities.ObjectReader
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind)
                {
                    var return_v = this_param.ReadStringValue(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 11569, 11590);
                    return return_v;
                }


                int
                f_543_11681_11700(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 11681, 11700);
                    return return_v;
                }


                byte
                f_543_11791_11809(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 11791, 11809);
                    return return_v;
                }


                ushort
                f_543_11901_11921(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 11901, 11921);
                    return return_v;
                }


                object
                f_543_11974_11986(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 11974, 11986);
                    return return_v;
                }


                long
                f_543_12060_12079(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 12060, 12079);
                    return return_v;
                }


                System.Array
                f_543_12328_12343(Roslyn.Utilities.ObjectReader
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind)
                {
                    var return_v = this_param.ReadArray(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 12328, 12343);
                    return return_v;
                }


                string
                f_543_12424_12436(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 12424, 12436);
                    return return_v;
                }


                System.Text.Encoding
                f_543_12403_12437(string
                name)
                {
                    var return_v = Encoding.GetEncoding(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 12403, 12437);
                    return return_v;
                }


                System.Text.Encoding
                f_543_12571_12584()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 12571, 12584);
                    return return_v;
                }


                System.Text.Encoding
                f_543_12898_12912()
                {
                    var return_v = Encoding.UTF32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 12898, 12912);
                    return return_v;
                }


                System.Text.Encoding
                f_543_13064_13089()
                {
                    var return_v = Encoding.BigEndianUnicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 13064, 13089);
                    return return_v;
                }


                System.Text.Encoding
                f_543_13241_13257()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 13241, 13257);
                    return return_v;
                }


                System.Exception
                f_543_13314_13354(Roslyn.Utilities.ObjectWriter.EncodingKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 13314, 13354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 8528, 13381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 8528, 13381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Encoding s_encodingUTF8;

        private static readonly Encoding s_encodingUTF32_BE;

        private static readonly Encoding s_encodingUTF32_BE_BOM;

        private static readonly Encoding s_encodingUTF32_LE;

        private static readonly Encoding s_encodingUnicode_BE;

        private static readonly Encoding s_encodingUnicode_LE;

        private struct ReaderReferenceMap<T> : IDisposable
                    where T : class
        {

            private readonly List<T> _values;

            private static readonly ObjectPool<List<T>> s_objectListPool
            ;

            private ReaderReferenceMap(List<T> values)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(543, 14534, 14614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14597, 14613);
                    _values = values; DynAbs.Tracing.TraceSender.TraceExitConstructor(543, 14534, 14614);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 14534, 14614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 14534, 14614);
                }
            }

            public static ReaderReferenceMap<T> Create()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 14692, 14727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14695, 14727);
                    return f_543_14695_14727(f_543_14699_14726(s_objectListPool)); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 14692, 14727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 14692, 14727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 14692, 14727);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Generic.List<T>
                f_543_14699_14726(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<T>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 14699, 14726);
                    return return_v;
                }


                Roslyn.Utilities.ObjectReader.ReaderReferenceMap<T>
                f_543_14695_14727(System.Collections.Generic.List<T>
                values)
                {
                    var return_v = new Roslyn.Utilities.ObjectReader.ReaderReferenceMap<T>(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 14695, 14727);
                    return return_v;
                }

            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 14744, 14878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14798, 14814);

                    f_543_14798_14813(_values);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14832, 14863);

                    f_543_14832_14862(s_objectListPool, _values);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(543, 14744, 14878);

                    int
                    f_543_14798_14813(System.Collections.Generic.List<T>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 14798, 14813);
                        return 0;
                    }


                    int
                    f_543_14832_14862(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<T>>
                    this_param, System.Collections.Generic.List<T>
                    obj)
                    {
                        this_param.Free(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 14832, 14862);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 14744, 14878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 14744, 14878);
                }
            }

            public int GetNextObjectId()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 14894, 15057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14955, 14978);

                    var
                    id = f_543_14964_14977(_values)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14996, 15014);

                    f_543_14996_15013(_values, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15032, 15042);

                    return id;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(543, 14894, 15057);

                    int
                    f_543_14964_14977(System.Collections.Generic.List<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 14964, 14977);
                        return return_v;
                    }


                    int
                    f_543_14996_15013(System.Collections.Generic.List<T>
                    this_param, T
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 14996, 15013);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 14894, 15057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 14894, 15057);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void AddValue(T value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 15120, 15141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15123, 15141);
                    f_543_15123_15141(_values, value); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 15120, 15141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 15120, 15141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 15120, 15141);
                }

                int
                f_543_15123_15141(System.Collections.Generic.List<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 15123, 15141);
                    return 0;
                }

            }

            public void AddValue(int index, T value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 15216, 15241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15219, 15241);
                    _values[index] = value; DynAbs.Tracing.TraceSender.TraceExitMethod(543, 15216, 15241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 15216, 15241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 15216, 15241);
                }
            }

            public T GetValue(int referenceId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 15310, 15333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15313, 15333);
                    return f_543_15313_15333(_values, referenceId); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 15310, 15333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 15310, 15333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 15310, 15333);
                }
                throw new System.Exception("Slicer error: unreachable code");

                T
                f_543_15313_15333(System.Collections.Generic.List<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 15313, 15333);
                    return return_v;
                }

            }

            static ReaderReferenceMap()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(543, 14258, 15345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14455, 14517);
                s_objectListPool = f_543_14491_14517(() => new List<T>(20));

                static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<T>>
f_543_14491_14517(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<T>>.Factory
factory)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<T>>(factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 14491, 14517);
                    return return_v;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(543, 14258, 15345);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 14258, 15345);
            }
        }

        internal uint ReadCompressedUInt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 15357, 16304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15416, 15446);

                var
                info = f_543_15427_15445(_reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15460, 15517);

                byte
                marker = (byte)(info & ObjectWriter.ByteMarkerMask)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15531, 15588);

                byte
                byte0 = (byte)(info & ~ObjectWriter.ByteMarkerMask)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15604, 15704) || true) && (marker == ObjectWriter.Byte1Marker)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 15604, 15704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15676, 15689);

                    return byte0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 15604, 15704);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15720, 15892) || true) && (marker == ObjectWriter.Byte2Marker)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 15720, 15892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15792, 15823);

                    var
                    byte1 = f_543_15804_15822(_reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15841, 15877);

                    return (((uint)byte0) << 8) | byte1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 15720, 15892);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15908, 16228) || true) && (marker == ObjectWriter.Byte4Marker)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 15908, 16228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 15980, 16011);

                    var
                    byte1 = f_543_15992_16010(_reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16029, 16060);

                    var
                    byte2 = f_543_16041_16059(_reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16078, 16109);

                    var
                    byte3 = f_543_16090_16108(_reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16129, 16213);

                    return (((uint)byte0) << 24) | (((uint)byte1) << 16) | (((uint)byte2) << 8) | byte3;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 15908, 16228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16244, 16293);

                throw f_543_16250_16292(marker);
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 15357, 16304);

                byte
                f_543_15427_15445(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 15427, 15445);
                    return return_v;
                }


                byte
                f_543_15804_15822(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 15804, 15822);
                    return return_v;
                }


                byte
                f_543_15992_16010(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 15992, 16010);
                    return return_v;
                }


                byte
                f_543_16041_16059(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16041, 16059);
                    return return_v;
                }


                byte
                f_543_16090_16108(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16090, 16108);
                    return return_v;
                }


                System.Exception
                f_543_16250_16292(byte
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16250, 16292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 15357, 16304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 15357, 16304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ReadStringValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 16316, 16506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16373, 16417);

                var
                kind = (EncodingKind)f_543_16398_16416(_reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16431, 16495);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(543, 16438, 16463) || ((kind == EncodingKind.Null && DynAbs.Tracing.TraceSender.Conditional_F2(543, 16466, 16470)) || DynAbs.Tracing.TraceSender.Conditional_F3(543, 16473, 16494))) ? null : f_543_16473_16494(this, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 16316, 16506);

                byte
                f_543_16398_16416(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16398, 16416);
                    return return_v;
                }


                string
                f_543_16473_16494(Roslyn.Utilities.ObjectReader
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind)
                {
                    var return_v = this_param.ReadStringValue(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16473, 16494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 16316, 16506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 16316, 16506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ReadStringValue(EncodingKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 16518, 17292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16592, 17281);

                switch (kind)
                {

                    case EncodingKind.StringRef_1Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 16592, 17281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16694, 16750);

                        return _stringReferenceMap.GetValue(f_543_16730_16748(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 16592, 17281);

                    case EncodingKind.StringRef_2Bytes:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 16592, 17281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16827, 16885);

                        return _stringReferenceMap.GetValue(f_543_16863_16883(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 16592, 17281);

                    case EncodingKind.StringRef_4Bytes:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 16592, 17281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 16962, 17019);

                        return _stringReferenceMap.GetValue(f_543_16998_17017(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 16592, 17281);

                    case EncodingKind.StringUtf16:
                    case EncodingKind.StringUtf8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 16592, 17281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17138, 17169);

                        return f_543_17145_17168(this, kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 16592, 17281);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 16592, 17281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17219, 17266);

                        throw f_543_17225_17265(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 16592, 17281);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 16518, 17292);

                byte
                f_543_16730_16748(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16730, 16748);
                    return return_v;
                }


                ushort
                f_543_16863_16883(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16863, 16883);
                    return return_v;
                }


                int
                f_543_16998_17017(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 16998, 17017);
                    return return_v;
                }


                string
                f_543_17145_17168(Roslyn.Utilities.ObjectReader
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind)
                {
                    var return_v = this_param.ReadStringLiteral(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 17145, 17168);
                    return return_v;
                }


                System.Exception
                f_543_17225_17265(Roslyn.Utilities.ObjectWriter.EncodingKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 17225, 17265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 16518, 17292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 16518, 17292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private unsafe string ReadStringLiteral(EncodingKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 17304, 18051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17387, 17400);

                string
                value
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17414, 17961) || true) && (kind == EncodingKind.StringUtf8)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 17414, 17961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17483, 17512);

                    value = f_543_17491_17511(_reader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 17414, 17961);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 17414, 17961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17654, 17701);

                    int
                    characterCount = (int)f_543_17680_17700(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17719, 17783);

                    byte[]
                    bytes = f_543_17734_17782(_reader, characterCount * sizeof(char))
                    ;
                    fixed (byte*
    bytesPtr = bytes
    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17872, 17927);

                        value = f_543_17880_17926(bytesPtr, 0, characterCount);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 17414, 17961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 17977, 18013);

                _stringReferenceMap.AddValue(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18027, 18040);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 17304, 18051);

                string
                f_543_17491_17511(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 17491, 17511);
                    return return_v;
                }


                uint
                f_543_17680_17700(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadCompressedUInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 17680, 17700);
                    return return_v;
                }


                byte[]
                f_543_17734_17782(System.IO.BinaryReader
                this_param, int
                count)
                {
                    var return_v = this_param.ReadBytes(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 17734, 17782);
                    return return_v;
                }


                unsafe string
                f_543_17880_17926(byte*
                value, int
                startIndex, int
                length)
                {
                    var return_v = new string((char*)value, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 17880, 17926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 17304, 18051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 17304, 18051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Array ReadArray(EncodingKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 18063, 19719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18130, 18141);

                int
                length
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18155, 18734);

                switch (kind)
                {

                    case EncodingKind.Array_0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 18155, 18734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18249, 18260);

                        length = 0;
                        DynAbs.Tracing.TraceSender.TraceBreak(543, 18282, 18288);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 18155, 18734);

                    case EncodingKind.Array_1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 18155, 18734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18354, 18365);

                        length = 1;
                        DynAbs.Tracing.TraceSender.TraceBreak(543, 18387, 18393);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 18155, 18734);

                    case EncodingKind.Array_2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 18155, 18734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18459, 18470);

                        length = 2;
                        DynAbs.Tracing.TraceSender.TraceBreak(543, 18492, 18498);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 18155, 18734);

                    case EncodingKind.Array_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 18155, 18734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18564, 18575);

                        length = 3;
                        DynAbs.Tracing.TraceSender.TraceBreak(543, 18597, 18603);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 18155, 18734);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 18155, 18734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18651, 18691);

                        length = (int)f_543_18665_18690(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(543, 18713, 18719);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 18155, 18734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18894, 18945);

                var
                elementKind = (EncodingKind)f_543_18926_18944(_reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 18961, 19027);

                var
                elementType = ObjectWriter.s_reverseTypeMap[(int)elementKind]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19041, 19708) || true) && (elementType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 19041, 19708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19098, 19175);

                    return f_543_19105_19174(this, elementType, elementKind, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 19041, 19708);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 19041, 19708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19278, 19316);

                    elementType = f_543_19292_19315(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19416, 19472);

                    Array
                    array = f_543_19430_19471(elementType, length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19501, 19506);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19492, 19660) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19520, 19523)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 19492, 19660))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 19492, 19660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19565, 19594);

                            var
                            value = f_543_19577_19593(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19616, 19641);

                            f_543_19616_19640(array, value, i);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 169);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 169);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19680, 19693);

                    return array;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 19041, 19708);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 18063, 19719);

                uint
                f_543_18665_18690(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadCompressedUInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 18665, 18690);
                    return return_v;
                }


                byte
                f_543_18926_18944(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 18926, 18944);
                    return return_v;
                }


                System.Array
                f_543_19105_19174(Roslyn.Utilities.ObjectReader
                this_param, System.Type
                type, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind, int
                length)
                {
                    var return_v = this_param.ReadPrimitiveTypeArrayElements(type, kind, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 19105, 19174);
                    return return_v;
                }


                System.Type
                f_543_19292_19315(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadTypeAfterTag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 19292, 19315);
                    return return_v;
                }


                System.Array
                f_543_19430_19471(System.Type
                elementType, int
                length)
                {
                    var return_v = Array.CreateInstance(elementType, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 19430, 19471);
                    return return_v;
                }


                object
                f_543_19577_19593(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 19577, 19593);
                    return return_v;
                }


                int
                f_543_19616_19640(System.Array
                this_param, object
                value, int
                index)
                {
                    this_param.SetValue(value, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 19616, 19640);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 18063, 19719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 18063, 19719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Array ReadPrimitiveTypeArrayElements(Type type, EncodingKind kind, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 19731, 21746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19842, 19905);

                f_543_19842_19904(ObjectWriter.s_reverseTypeMap[(int)kind] == type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 19993, 20056) || true) && (type == typeof(byte))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 19993, 20056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20021, 20054);

                    return f_543_20028_20053(_reader, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 19993, 20056);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20070, 20133) || true) && (type == typeof(char))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20070, 20133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20098, 20131);

                    return f_543_20105_20130(_reader, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20070, 20133);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20284, 20376) || true) && (type == typeof(string))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20284, 20376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20314, 20374);

                    return f_543_20321_20373(this, f_543_20345_20372(length));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20284, 20376);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20390, 20479) || true) && (type == typeof(bool))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20390, 20479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20418, 20477);

                    return f_543_20425_20476(this, f_543_20450_20475(length));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20390, 20479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20575, 21735);

                switch (kind)
                {

                    case EncodingKind.Int8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20645, 20702);

                        return f_543_20652_20701(this, f_543_20674_20700(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20745, 20803);

                        return f_543_20752_20802(this, f_543_20775_20801(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20846, 20902);

                        return f_543_20853_20901(this, f_543_20876_20900(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 20945, 21002);

                        return f_543_20952_21001(this, f_543_20975_21000(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21046, 21106);

                        return f_543_21053_21105(this, f_543_21077_21104(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21150, 21208);

                        return f_543_21157_21207(this, f_543_21181_21206(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21252, 21311);

                        return f_543_21259_21310(this, f_543_21283_21309(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.Float4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21355, 21414);

                        return f_543_21362_21413(this, f_543_21386_21412(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.Float8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21458, 21518);

                        return f_543_21465_21517(this, f_543_21489_21516(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    case EncodingKind.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21563, 21625);

                        return f_543_21570_21624(this, f_543_21595_21623(length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 20575, 21735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21673, 21720);

                        throw f_543_21679_21719(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(543, 20575, 21735);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 19731, 21746);

                int
                f_543_19842_19904(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 19842, 19904);
                    return 0;
                }


                byte[]
                f_543_20028_20053(System.IO.BinaryReader
                this_param, int
                count)
                {
                    var return_v = this_param.ReadBytes(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20028, 20053);
                    return return_v;
                }


                char[]
                f_543_20105_20130(System.IO.BinaryReader
                this_param, int
                count)
                {
                    var return_v = this_param.ReadChars(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20105, 20130);
                    return return_v;
                }


                string[]
                f_543_20345_20372(int
                length)
                {
                    var return_v = CreateArray<string>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20345, 20372);
                    return return_v;
                }


                string[]
                f_543_20321_20373(Roslyn.Utilities.ObjectReader
                this_param, string[]
                array)
                {
                    var return_v = this_param.ReadStringArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20321, 20373);
                    return return_v;
                }


                bool[]
                f_543_20450_20475(int
                length)
                {
                    var return_v = CreateArray<bool>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20450, 20475);
                    return return_v;
                }


                bool[]
                f_543_20425_20476(Roslyn.Utilities.ObjectReader
                this_param, bool[]
                array)
                {
                    var return_v = this_param.ReadBooleanArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20425, 20476);
                    return return_v;
                }


                sbyte[]
                f_543_20674_20700(int
                length)
                {
                    var return_v = CreateArray<sbyte>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20674, 20700);
                    return return_v;
                }


                sbyte[]
                f_543_20652_20701(Roslyn.Utilities.ObjectReader
                this_param, sbyte[]
                array)
                {
                    var return_v = this_param.ReadInt8ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20652, 20701);
                    return return_v;
                }


                short[]
                f_543_20775_20801(int
                length)
                {
                    var return_v = CreateArray<short>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20775, 20801);
                    return return_v;
                }


                short[]
                f_543_20752_20802(Roslyn.Utilities.ObjectReader
                this_param, short[]
                array)
                {
                    var return_v = this_param.ReadInt16ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20752, 20802);
                    return return_v;
                }


                int[]
                f_543_20876_20900(int
                length)
                {
                    var return_v = CreateArray<int>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20876, 20900);
                    return return_v;
                }


                int[]
                f_543_20853_20901(Roslyn.Utilities.ObjectReader
                this_param, int[]
                array)
                {
                    var return_v = this_param.ReadInt32ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20853, 20901);
                    return return_v;
                }


                long[]
                f_543_20975_21000(int
                length)
                {
                    var return_v = CreateArray<long>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20975, 21000);
                    return return_v;
                }


                long[]
                f_543_20952_21001(Roslyn.Utilities.ObjectReader
                this_param, long[]
                array)
                {
                    var return_v = this_param.ReadInt64ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 20952, 21001);
                    return return_v;
                }


                ushort[]
                f_543_21077_21104(int
                length)
                {
                    var return_v = CreateArray<ushort>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21077, 21104);
                    return return_v;
                }


                ushort[]
                f_543_21053_21105(Roslyn.Utilities.ObjectReader
                this_param, ushort[]
                array)
                {
                    var return_v = this_param.ReadUInt16ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21053, 21105);
                    return return_v;
                }


                uint[]
                f_543_21181_21206(int
                length)
                {
                    var return_v = CreateArray<uint>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21181, 21206);
                    return return_v;
                }


                uint[]
                f_543_21157_21207(Roslyn.Utilities.ObjectReader
                this_param, uint[]
                array)
                {
                    var return_v = this_param.ReadUInt32ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21157, 21207);
                    return return_v;
                }


                ulong[]
                f_543_21283_21309(int
                length)
                {
                    var return_v = CreateArray<ulong>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21283, 21309);
                    return return_v;
                }


                ulong[]
                f_543_21259_21310(Roslyn.Utilities.ObjectReader
                this_param, ulong[]
                array)
                {
                    var return_v = this_param.ReadUInt64ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21259, 21310);
                    return return_v;
                }


                float[]
                f_543_21386_21412(int
                length)
                {
                    var return_v = CreateArray<float>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21386, 21412);
                    return return_v;
                }


                float[]
                f_543_21362_21413(Roslyn.Utilities.ObjectReader
                this_param, float[]
                array)
                {
                    var return_v = this_param.ReadFloat4ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21362, 21413);
                    return return_v;
                }


                double[]
                f_543_21489_21516(int
                length)
                {
                    var return_v = CreateArray<double>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21489, 21516);
                    return return_v;
                }


                double[]
                f_543_21465_21517(Roslyn.Utilities.ObjectReader
                this_param, double[]
                array)
                {
                    var return_v = this_param.ReadFloat8ArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21465, 21517);
                    return return_v;
                }


                decimal[]
                f_543_21595_21623(int
                length)
                {
                    var return_v = CreateArray<decimal>(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21595, 21623);
                    return return_v;
                }


                decimal[]
                f_543_21570_21624(Roslyn.Utilities.ObjectReader
                this_param, decimal[]
                array)
                {
                    var return_v = this_param.ReadDecimalArrayElements(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21570, 21624);
                    return return_v;
                }


                System.Exception
                f_543_21679_21719(Roslyn.Utilities.ObjectWriter.EncodingKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21679, 21719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 19731, 21746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 19731, 21746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool[] ReadBooleanArrayElements(bool[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 21758, 22513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21895, 21937);

                f_543_21895_21936(BitVector.BitsPerWord == 64);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 21953, 22008);

                var
                wordLength = BitVector.WordsRequired(f_543_21994_22006(array))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22024, 22038);

                var
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22061, 22066);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22052, 22473) || true) && (i < wordLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22084, 22087)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 22052, 22473))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 22052, 22473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22121, 22153);

                        var
                        word = f_543_22132_22152(_reader)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22182, 22187);

                            for (var
            p = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22173, 22458) || true) && (p < BitVector.BitsPerWord)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22216, 22219)
            , p++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 22173, 22458))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 22173, 22458);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22261, 22372) || true) && (count >= f_543_22274_22286(array))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 22261, 22372);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22336, 22349);

                                    return array;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 22261, 22372);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22396, 22439);

                                array[count++] = BitVector.IsTrue(word, p);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 286);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 286);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 422);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22489, 22502);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 21758, 22513);

                int
                f_543_21895_21936(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 21895, 21936);
                    return 0;
                }


                int
                f_543_21994_22006(bool[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 21994, 22006);
                    return return_v;
                }


                ulong
                f_543_22132_22152(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 22132, 22152);
                    return return_v;
                }


                int
                f_543_22274_22286(bool[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 22274, 22286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 21758, 22513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 21758, 22513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T[] CreateArray<T>(int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(543, 22525, 22813);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22595, 22802) || true) && (length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 22595, 22802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22676, 22700);

                    return f_543_22683_22699();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 22595, 22802);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 22595, 22802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22766, 22787);

                    return new T[length];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 22595, 22802);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(543, 22525, 22813);

                T[]
                f_543_22683_22699()
                {
                    var return_v = Array.Empty<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 22683, 22699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 22525, 22813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 22525, 22813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string[] ReadStringArrayElements(string[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 22825, 23066);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22915, 22920);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22906, 23026) || true) && (i < f_543_22926_22938(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22940, 22943)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 22906, 23026))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 22906, 23026);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 22977, 23011);

                        array[i] = f_543_22988_23010(this);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23042, 23055);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 22825, 23066);

                int
                f_543_22926_22938(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 22926, 22938);
                    return return_v;
                }


                string
                f_543_22988_23010(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadStringValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 22988, 23010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 22825, 23066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 22825, 23066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private sbyte[] ReadInt8ArrayElements(sbyte[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 23078, 23312);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23164, 23169);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23155, 23272) || true) && (i < f_543_23175_23187(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23189, 23192)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 23155, 23272))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 23155, 23272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23226, 23257);

                        array[i] = f_543_23237_23256(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23288, 23301);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 23078, 23312);

                int
                f_543_23175_23187(sbyte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 23175, 23187);
                    return return_v;
                }


                sbyte
                f_543_23237_23256(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadSByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 23237, 23256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 23078, 23312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 23078, 23312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private short[] ReadInt16ArrayElements(short[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 23324, 23559);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23411, 23416);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23402, 23519) || true) && (i < f_543_23422_23434(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23436, 23439)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 23402, 23519))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 23402, 23519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23473, 23504);

                        array[i] = f_543_23484_23503(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23535, 23548);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 23324, 23559);

                int
                f_543_23422_23434(short[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 23422, 23434);
                    return return_v;
                }


                short
                f_543_23484_23503(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 23484, 23503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 23324, 23559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 23324, 23559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int[] ReadInt32ArrayElements(int[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 23571, 23802);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23654, 23659);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23645, 23762) || true) && (i < f_543_23665_23677(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23679, 23682)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 23645, 23762))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 23645, 23762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23716, 23747);

                        array[i] = f_543_23727_23746(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23778, 23791);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 23571, 23802);

                int
                f_543_23665_23677(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 23665, 23677);
                    return return_v;
                }


                int
                f_543_23727_23746(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 23727, 23746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 23571, 23802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 23571, 23802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private long[] ReadInt64ArrayElements(long[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 23814, 24047);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23899, 23904);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23890, 24007) || true) && (i < f_543_23910_23922(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23924, 23927)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 23890, 24007))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 23890, 24007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 23961, 23992);

                        array[i] = f_543_23972_23991(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24023, 24036);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 23814, 24047);

                int
                f_543_23910_23922(long[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 23910, 23922);
                    return return_v;
                }


                long
                f_543_23972_23991(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 23972, 23991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 23814, 24047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 23814, 24047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ushort[] ReadUInt16ArrayElements(ushort[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 24059, 24298);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24149, 24154);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24140, 24258) || true) && (i < f_543_24160_24172(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24174, 24177)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 24140, 24258))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 24140, 24258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24211, 24243);

                        array[i] = f_543_24222_24242(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24274, 24287);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 24059, 24298);

                int
                f_543_24160_24172(ushort[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 24160, 24172);
                    return return_v;
                }


                ushort
                f_543_24222_24242(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 24222, 24242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 24059, 24298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 24059, 24298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private uint[] ReadUInt32ArrayElements(uint[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 24310, 24545);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24396, 24401);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24387, 24505) || true) && (i < f_543_24407_24419(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24421, 24424)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 24387, 24505))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 24387, 24505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24458, 24490);

                        array[i] = f_543_24469_24489(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24521, 24534);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 24310, 24545);

                int
                f_543_24407_24419(uint[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 24407, 24419);
                    return return_v;
                }


                uint
                f_543_24469_24489(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 24469, 24489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 24310, 24545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 24310, 24545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ulong[] ReadUInt64ArrayElements(ulong[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 24557, 24794);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24645, 24650);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24636, 24754) || true) && (i < f_543_24656_24668(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24670, 24673)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 24636, 24754))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 24636, 24754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24707, 24739);

                        array[i] = f_543_24718_24738(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24770, 24783);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 24557, 24794);

                int
                f_543_24656_24668(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 24656, 24668);
                    return return_v;
                }


                ulong
                f_543_24718_24738(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 24718, 24738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 24557, 24794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 24557, 24794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private decimal[] ReadDecimalArrayElements(decimal[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 24806, 25049);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24899, 24904);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24890, 25009) || true) && (i < f_543_24910_24922(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24924, 24927)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 24890, 25009))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 24890, 25009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 24961, 24994);

                        array[i] = f_543_24972_24993(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25025, 25038);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 24806, 25049);

                int
                f_543_24910_24922(decimal[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 24910, 24922);
                    return return_v;
                }


                decimal
                f_543_24972_24993(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadDecimal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 24972, 24993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 24806, 25049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 24806, 25049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private float[] ReadFloat4ArrayElements(float[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 25061, 25298);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25149, 25154);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25140, 25258) || true) && (i < f_543_25160_25172(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25174, 25177)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 25140, 25258))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 25140, 25258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25211, 25243);

                        array[i] = f_543_25222_25242(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25274, 25287);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 25061, 25298);

                int
                f_543_25160_25172(float[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 25160, 25172);
                    return return_v;
                }


                float
                f_543_25222_25242(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 25222, 25242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 25061, 25298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 25061, 25298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private double[] ReadFloat8ArrayElements(double[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 25310, 25549);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25400, 25405);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25391, 25509) || true) && (i < f_543_25411_25423(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25425, 25428)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(543, 25391, 25509))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 25391, 25509);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25462, 25494);

                        array[i] = f_543_25473_25493(_reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(543, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(543, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25525, 25538);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 25310, 25549);

                int
                f_543_25411_25423(double[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 25411, 25423);
                    return return_v;
                }


                double
                f_543_25473_25493(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 25473, 25493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 25310, 25549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 25310, 25549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Type ReadType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 25561, 25686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25608, 25627);

                f_543_25608_25626(_reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25641, 25675);

                return f_543_25648_25674(f_543_25661_25673(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 25561, 25686);

                byte
                f_543_25608_25626(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 25608, 25626);
                    return return_v;
                }


                string
                f_543_25661_25673(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 25661, 25673);
                    return return_v;
                }


                System.Type?
                f_543_25648_25674(string
                typeName)
                {
                    var return_v = Type.GetType(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 25648, 25674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 25561, 25686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 25561, 25686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Type ReadTypeAfterTag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 25743, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25746, 25793);
                return _binderSnapshot.GetTypeFromId(f_543_25776_25792(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(543, 25743, 25793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 25743, 25793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 25743, 25793);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_543_25776_25792(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadInt32();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 25776, 25792);
                return return_v;
            }

        }

        private object ReadObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(543, 25806, 26526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 25858, 25911);

                var
                objectId = _objectReferenceMap.GetNextObjectId()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 26095, 26166);

                var
                typeReader = _binderSnapshot.GetTypeReaderFromId(f_543_26148_26164(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 26298, 26330);

                var
                instance = f_543_26313_26329(typeReader, this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 26346, 26483) || true) && (f_543_26350_26385(instance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(543, 26346, 26483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 26419, 26468);

                    _objectReferenceMap.AddValue(objectId, instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(543, 26346, 26483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 26499, 26515);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitMethod(543, 25806, 26526);

                int
                f_543_26148_26164(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 26148, 26164);
                    return return_v;
                }


                Roslyn.Utilities.IObjectWritable
                f_543_26313_26329(System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
                this_param, Roslyn.Utilities.ObjectReader
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 26313, 26329);
                    return return_v;
                }


                bool
                f_543_26350_26385(Roslyn.Utilities.IObjectWritable
                this_param)
                {
                    var return_v = this_param.ShouldReuseInSerialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 26350, 26385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 25806, 26526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 25806, 26526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Exception DeserializationReadIncorrectNumberOfValuesException(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(543, 26538, 26800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 26656, 26789);

                throw f_543_26662_26788(f_543_26692_26787(f_543_26706_26776(), typeName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(543, 26538, 26800);

                string
                f_543_26706_26776()
                {
                    var return_v = Resources.Deserialization_reader_for_0_read_incorrect_number_of_values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 26706, 26776);
                    return return_v;
                }


                string
                f_543_26692_26787(string
                format, string
                arg0)
                {
                    var return_v = String.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 26692, 26787);
                    return return_v;
                }


                System.InvalidOperationException
                f_543_26662_26788(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 26662, 26788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 26538, 26800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 26538, 26800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Exception NoSerializationTypeException(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(543, 26812, 27048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 26907, 27037);

                return f_543_26914_27036(f_543_26944_27035(f_543_26958_27024(), typeName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(543, 26812, 27048);

                string
                f_543_26958_27024()
                {
                    var return_v = Resources.The_type_0_is_not_understood_by_the_serialization_binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 26958, 27024);
                    return return_v;
                }


                string
                f_543_26944_27035(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 26944, 27035);
                    return return_v;
                }


                System.InvalidOperationException
                f_543_26914_27036(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 26914, 27036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 26812, 27048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 26812, 27048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Exception NoSerializationReaderException(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(543, 27060, 27265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 27157, 27254);

                return f_543_27164_27253(f_543_27194_27252(f_543_27208_27241(), typeName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(543, 27060, 27265);

                string
                f_543_27208_27241()
                {
                    var return_v = Resources.Cannot_serialize_type_0;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 27208, 27241);
                    return return_v;
                }


                string
                f_543_27194_27252(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 27194, 27252);
                    return return_v;
                }


                System.InvalidOperationException
                f_543_27164_27253(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 27164, 27253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(543, 27060, 27265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 27060, 27265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ObjectReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(543, 878, 27272);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 1268, 1293);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 1324, 1349);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13426, 13499);
            s_encodingUTF8 = f_543_13443_13499(encoderShouldEmitUTF8Identifier: false); DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13543, 13620);
            s_encodingUTF32_BE = f_543_13564_13620(bigEndian: true, byteOrderMark: false); DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13664, 13744);
            s_encodingUTF32_BE_BOM = f_543_13689_13744(bigEndian: true, byteOrderMark: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13788, 13866);
            s_encodingUTF32_LE = f_543_13809_13866(bigEndian: false, byteOrderMark: false); DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 13910, 13991);
            s_encodingUnicode_BE = f_543_13933_13991(bigEndian: true, byteOrderMark: false); DynAbs.Tracing.TraceSender.TraceSimpleStatement(543, 14035, 14117);
            s_encodingUnicode_LE = f_543_14058_14117(bigEndian: false, byteOrderMark: false); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(543, 878, 27272);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(543, 878, 27272);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(543, 878, 27272);

        static int
        f_543_2981_3022(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 2981, 3022);
            return 0;
        }


        static System.Text.Encoding
        f_543_3074_3087()
        {
            var return_v = Encoding.UTF8;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(543, 3074, 3087);
            return return_v;
        }


        static System.IO.BinaryReader
        f_543_3049_3099(System.IO.Stream
        input, System.Text.Encoding
        encoding, bool
        leaveOpen)
        {
            var return_v = new System.IO.BinaryReader(input, encoding, leaveOpen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 3049, 3099);
            return return_v;
        }


        static Roslyn.Utilities.ObjectBinderSnapshot
        f_543_3440_3466()
        {
            var return_v = ObjectBinder.GetSnapshot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 3440, 3466);
            return return_v;
        }


        static System.Text.UTF8Encoding
        f_543_13443_13499(bool
        encoderShouldEmitUTF8Identifier)
        {
            var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 13443, 13499);
            return return_v;
        }


        static System.Text.UTF32Encoding
        f_543_13564_13620(bool
        bigEndian, bool
        byteOrderMark)
        {
            var return_v = new System.Text.UTF32Encoding(bigEndian: bigEndian, byteOrderMark: byteOrderMark);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 13564, 13620);
            return return_v;
        }


        static System.Text.UTF32Encoding
        f_543_13689_13744(bool
        bigEndian, bool
        byteOrderMark)
        {
            var return_v = new System.Text.UTF32Encoding(bigEndian: bigEndian, byteOrderMark: byteOrderMark);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 13689, 13744);
            return return_v;
        }


        static System.Text.UTF32Encoding
        f_543_13809_13866(bool
        bigEndian, bool
        byteOrderMark)
        {
            var return_v = new System.Text.UTF32Encoding(bigEndian: bigEndian, byteOrderMark: byteOrderMark);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 13809, 13866);
            return return_v;
        }


        static System.Text.UnicodeEncoding
        f_543_13933_13991(bool
        bigEndian, bool
        byteOrderMark)
        {
            var return_v = new System.Text.UnicodeEncoding(bigEndian: bigEndian, byteOrderMark: byteOrderMark);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 13933, 13991);
            return return_v;
        }


        static System.Text.UnicodeEncoding
        f_543_14058_14117(bool
        bigEndian, bool
        byteOrderMark)
        {
            var return_v = new System.Text.UnicodeEncoding(bigEndian: bigEndian, byteOrderMark: byteOrderMark);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(543, 14058, 14117);
            return return_v;
        }

    }
}
