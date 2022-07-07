// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    using System.Collections.Immutable;
    using System.Threading.Tasks;
#if COMPILERCORE
    using Resources = CodeAnalysisResources;
#elif CODE_STYLE
    using Resources = CodeStyleResources;
#else
    using Resources = WorkspacesResources;
#endif

    internal sealed partial class ObjectWriter : IDisposable
    {
        private readonly BinaryWriter _writer;

        private readonly CancellationToken _cancellationToken;

        private WriterReferenceMap _objectReferenceMap;

        private WriterReferenceMap _stringReferenceMap;

        private readonly ObjectBinderSnapshot _binderSnapshot;

        private int _recursionDepth;

        internal const int
        MaxRecursionDepth = 50
        ;

        public ObjectWriter(
                    Stream stream,
                    bool leaveOpen = false,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(544, 3732, 4658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 1011, 1018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 3253, 3268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4060, 4102);

                f_544_4060_4101(BitConverter.IsLittleEndian);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4118, 4179);

                _writer = f_544_4128_4178(stream, f_544_4153_4166(), leaveOpen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4193, 4260);

                _objectReferenceMap = f_544_4215_4259(valueEquality: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4274, 4340);

                _stringReferenceMap = f_544_4296_4339(valueEquality: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4354, 4393);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4571, 4616);

                _binderSnapshot = f_544_4589_4615();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4632, 4647);

                f_544_4632_4646(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(544, 3732, 4658);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 3732, 4658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 3732, 4658);
            }
        }

        private void WriteVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 4670, 4829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4722, 4763);

                f_544_4722_4762(_writer, ObjectReader.VersionByte1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4777, 4818);

                f_544_4777_4817(_writer, ObjectReader.VersionByte2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 4670, 4829);

                int
                f_544_4722_4762(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4722, 4762);
                    return 0;
                }


                int
                f_544_4777_4817(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4777, 4817);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 4670, 4829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 4670, 4829);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 4841, 5038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4887, 4905);

                f_544_4887_4904(_writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4919, 4949);

                _objectReferenceMap.Dispose();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 4963, 4993);

                _stringReferenceMap.Dispose();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5007, 5027);

                _recursionDepth = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 4841, 5038);

                int
                f_544_4887_4904(System.IO.BinaryWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4887, 4904);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 4841, 5038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 4841, 5038);
            }
        }

        public void WriteBoolean(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5087, 5110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5090, 5110);
                f_544_5090_5110(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5087, 5110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5087, 5110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5087, 5110);
            }

            int
            f_544_5090_5110(System.IO.BinaryWriter
            this_param, bool
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5090, 5110);
                return 0;
            }

        }

        public void WriteByte(byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5155, 5178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5158, 5178);
                f_544_5158_5178(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5155, 5178);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5155, 5178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5155, 5178);
            }

            int
            f_544_5158_5178(System.IO.BinaryWriter
            this_param, byte
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5158, 5178);
                return 0;
            }

        }

        public void WriteChar(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5314, 5342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5317, 5342);
                f_544_5317_5342(_writer, ch); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5314, 5342);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5314, 5342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5314, 5342);
            }

            int
            f_544_5317_5342(System.IO.BinaryWriter
            this_param, char
            value)
            {
                this_param.Write((ushort)value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5317, 5342);
                return 0;
            }

        }

        public void WriteDecimal(decimal value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5393, 5416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5396, 5416);
                f_544_5396_5416(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5393, 5416);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5393, 5416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5393, 5416);
            }

            int
            f_544_5396_5416(System.IO.BinaryWriter
            this_param, decimal
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5396, 5416);
                return 0;
            }

        }

        public void WriteDouble(double value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5465, 5488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5468, 5488);
                f_544_5468_5488(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5465, 5488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5465, 5488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5465, 5488);
            }

            int
            f_544_5468_5488(System.IO.BinaryWriter
            this_param, double
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5468, 5488);
                return 0;
            }

        }

        public void WriteSingle(float value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5536, 5559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5539, 5559);
                f_544_5539_5559(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5536, 5559);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5536, 5559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5536, 5559);
            }

            int
            f_544_5539_5559(System.IO.BinaryWriter
            this_param, float
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5539, 5559);
                return 0;
            }

        }

        public void WriteInt32(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5604, 5627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5607, 5627);
                f_544_5607_5627(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5604, 5627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5604, 5627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5604, 5627);
            }

            int
            f_544_5607_5627(System.IO.BinaryWriter
            this_param, int
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5607, 5627);
                return 0;
            }

        }

        public void WriteInt64(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5673, 5696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5676, 5696);
                f_544_5676_5696(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5673, 5696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5673, 5696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5673, 5696);
            }

            int
            f_544_5676_5696(System.IO.BinaryWriter
            this_param, long
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5676, 5696);
                return 0;
            }

        }

        public void WriteSByte(sbyte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5743, 5766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5746, 5766);
                f_544_5746_5766(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5743, 5766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5743, 5766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5743, 5766);
            }

            int
            f_544_5746_5766(System.IO.BinaryWriter
            this_param, sbyte
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5746, 5766);
                return 0;
            }

        }

        public void WriteInt16(short value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5813, 5836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5816, 5836);
                f_544_5816_5836(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5813, 5836);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5813, 5836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5813, 5836);
            }

            int
            f_544_5816_5836(System.IO.BinaryWriter
            this_param, short
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5816, 5836);
                return 0;
            }

        }

        public void WriteUInt32(uint value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5883, 5906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5886, 5906);
                f_544_5886_5906(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5883, 5906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5883, 5906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5883, 5906);
            }

            int
            f_544_5886_5906(System.IO.BinaryWriter
            this_param, uint
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5886, 5906);
                return 0;
            }

        }

        public void WriteUInt64(ulong value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 5954, 5977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 5957, 5977);
                f_544_5957_5977(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 5954, 5977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 5954, 5977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 5954, 5977);
            }

            int
            f_544_5957_5977(System.IO.BinaryWriter
            this_param, ulong
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 5957, 5977);
                return 0;
            }

        }

        public void WriteUInt16(ushort value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 6026, 6049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 6029, 6049);
                f_544_6029_6049(_writer, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 6026, 6049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 6026, 6049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 6026, 6049);
            }

            int
            f_544_6029_6049(System.IO.BinaryWriter
            this_param, ushort
            value)
            {
                this_param.Write(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 6029, 6049);
                return 0;
            }

        }

        public void WriteString(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 6099, 6125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 6102, 6125);
                f_544_6102_6125(this, value); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 6099, 6125);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 6099, 6125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 6099, 6125);
            }

            int
            f_544_6102_6125(Roslyn.Utilities.ObjectWriter
            this_param, string?
            value)
            {
                this_param.WriteStringValue(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 6102, 6125);
                return 0;
            }

        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct GuidAccessor
        {

            [FieldOffset(0)]
            public Guid Guid;

            [FieldOffset(0)]
            public long Low64;

            [FieldOffset(8)]
            public long High64;
            static GuidAccessor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(544, 6274, 6557);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(544, 6274, 6557);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 6274, 6557);
            }
        }

        public void WriteGuid(Guid guid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 6569, 6768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 6626, 6674);

                var
                accessor = new GuidAccessor { Guid = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => guid, 544, 6641, 6673) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 6688, 6715);

                f_544_6688_6714(this, accessor.Low64);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 6729, 6757);

                f_544_6729_6756(this, accessor.High64);
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 6569, 6768);

                int
                f_544_6688_6714(Roslyn.Utilities.ObjectWriter
                this_param, long
                value)
                {
                    this_param.WriteInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 6688, 6714);
                    return 0;
                }


                int
                f_544_6729_6756(Roslyn.Utilities.ObjectWriter
                this_param, long
                value)
                {
                    this_param.WriteInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 6729, 6756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 6569, 6768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 6569, 6768);
            }
        }

        public void WriteValue(object? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 6780, 11859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 6842, 6987);

                f_544_6842_6986(value == null || (DynAbs.Tracing.TraceSender.Expression_False(544, 6855, 6909) || f_544_6872_6909_M(!f_544_6873_6902(f_544_6873_6888(value)).IsEnum)), "Enum should not be written with WriteValue.  Write them as ints instead.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 7003, 7133) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 7003, 7133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 7054, 7093);

                    f_544_7054_7092(_writer, EncodingKind.Null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 7111, 7118);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 7003, 7133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 7149, 7176);

                var
                type = f_544_7160_7175(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 7190, 7224);

                var
                typeInfo = f_544_7205_7223(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 7238, 7355);

                f_544_7238_7354(f_544_7251_7267_M(!typeInfo.IsEnum), "Enums should not be written with WriteObject.  Write them out as integers instead.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 7760, 11848) || true) && (f_544_7764_7784(typeInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 7760, 11848);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8075, 10686) || true) && (f_544_8079_8094(value) == typeof(int))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8075, 10686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8151, 8181);

                        f_544_8151_8180(this, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8075, 10686);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8075, 10686);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8223, 10686) || true) && (f_544_8227_8242(value) == typeof(double))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8223, 10686);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8302, 8343);

                            f_544_8302_8342(_writer, EncodingKind.Float8);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8365, 8394);

                            f_544_8365_8393(_writer, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8223, 10686);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8223, 10686);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8436, 10686) || true) && (f_544_8440_8455(value) == typeof(bool))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8436, 10686);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8513, 8605);

                                f_544_8513_8604(_writer, ((DynAbs.Tracing.TraceSender.Conditional_F1(544, 8534, 8545) || (((bool)value && DynAbs.Tracing.TraceSender.Conditional_F2(544, 8548, 8573)) || DynAbs.Tracing.TraceSender.Conditional_F3(544, 8576, 8602))) ? EncodingKind.Boolean_True : EncodingKind.Boolean_False));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8436, 10686);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8436, 10686);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8647, 10686) || true) && (f_544_8651_8666(value) == typeof(char))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8647, 10686);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8724, 8763);

                                    f_544_8724_8762(_writer, EncodingKind.Char);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8785, 8820);

                                    f_544_8785_8819(_writer, (char)value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8647, 10686);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8647, 10686);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 8948, 10686) || true) && (f_544_8952_8967(value) == typeof(byte))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8948, 10686);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9025, 9065);

                                        f_544_9025_9064(_writer, EncodingKind.UInt8);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9087, 9114);

                                        f_544_9087_9113(_writer, value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8948, 10686);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 8948, 10686);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9156, 10686) || true) && (f_544_9160_9175(value) == typeof(short))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9156, 10686);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9234, 9274);

                                            f_544_9234_9273(_writer, EncodingKind.Int16);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9296, 9324);

                                            f_544_9296_9323(_writer, value);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9156, 10686);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9156, 10686);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9366, 10686) || true) && (f_544_9370_9385(value) == typeof(long))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9366, 10686);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9443, 9483);

                                                f_544_9443_9482(_writer, EncodingKind.Int64);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9505, 9532);

                                                f_544_9505_9531(_writer, value);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9366, 10686);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9366, 10686);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9574, 10686) || true) && (f_544_9578_9593(value) == typeof(sbyte))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9574, 10686);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9652, 9691);

                                                    f_544_9652_9690(_writer, EncodingKind.Int8);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9713, 9741);

                                                    f_544_9713_9740(_writer, value);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9574, 10686);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9574, 10686);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9783, 10686) || true) && (f_544_9787_9802(value) == typeof(float))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9783, 10686);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9861, 9902);

                                                        f_544_9861_9901(_writer, EncodingKind.Float4);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9924, 9952);

                                                        f_544_9924_9951(_writer, value);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9783, 10686);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9783, 10686);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 9994, 10686) || true) && (f_544_9998_10013(value) == typeof(ushort))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9994, 10686);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10073, 10114);

                                                            f_544_10073_10113(_writer, EncodingKind.UInt16);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10136, 10165);

                                                            f_544_10136_10164(_writer, value);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9994, 10686);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 9994, 10686);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10207, 10686) || true) && (f_544_10211_10226(value) == typeof(uint))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10207, 10686);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10284, 10316);

                                                                f_544_10284_10315(this, value);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10207, 10686);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10207, 10686);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10358, 10686) || true) && (f_544_10362_10377(value) == typeof(ulong))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10358, 10686);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10436, 10477);

                                                                    f_544_10436_10476(_writer, EncodingKind.UInt64);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10499, 10527);

                                                                    f_544_10499_10526(_writer, value);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10358, 10686);
                                                                }

                                                                else

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10358, 10686);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10609, 10667);

                                                                    throw f_544_10615_10666(f_544_10650_10665(value));
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10358, 10686);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10207, 10686);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9994, 10686);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9783, 10686);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9574, 10686);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9366, 10686);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 9156, 10686);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8948, 10686);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8647, 10686);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8436, 10686);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8223, 10686);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 8075, 10686);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 7760, 11848);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 7760, 11848);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10720, 11848) || true) && (f_544_10724_10739(value) == typeof(decimal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10720, 11848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10792, 10834);

                        f_544_10792_10833(_writer, EncodingKind.Decimal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10852, 10882);

                        f_544_10852_10881(_writer, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10720, 11848);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10720, 11848);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10916, 11848) || true) && (f_544_10920_10935(value) == typeof(DateTime))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10916, 11848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 10989, 11032);

                            f_544_10989_11031(_writer, EncodingKind.DateTime);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11050, 11094);

                            f_544_11050_11093(_writer, ((DateTime)value).ToBinary());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10916, 11848);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 10916, 11848);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11128, 11848) || true) && (f_544_11132_11147(value) == typeof(string))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 11128, 11848);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11199, 11231);

                                f_544_11199_11230(this, value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 11128, 11848);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 11128, 11848);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11265, 11848) || true) && (f_544_11269_11281(type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 11265, 11848);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11315, 11343);

                                    var
                                    instance = (Array)value
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11363, 11549) || true) && (f_544_11367_11380(instance) > 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 11363, 11549);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11426, 11530);

                                        throw f_544_11432_11529(f_544_11462_11528());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 11363, 11549);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11569, 11590);

                                    f_544_11569_11589(this, instance);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 11265, 11848);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 11265, 11848);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11624, 11848) || true) && (value is Encoding encoding)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 11624, 11848);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11688, 11712);

                                        f_544_11688_11711(this, encoding);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 11624, 11848);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 11624, 11848);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 11778, 11833);

                                        f_544_11778_11832(this, instance: value, instanceAsWritable: null);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 11624, 11848);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 11265, 11848);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 11128, 11848);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10916, 11848);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 10720, 11848);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 7760, 11848);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 6780, 11859);

                System.Type
                f_544_6873_6888(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 6873, 6888);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_544_6873_6902(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 6873, 6902);
                    return return_v;
                }


                bool
                f_544_6872_6909_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 6872, 6909);
                    return return_v;
                }


                int
                f_544_6842_6986(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 6842, 6986);
                    return 0;
                }


                int
                f_544_7054_7092(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 7054, 7092);
                    return 0;
                }


                System.Type
                f_544_7160_7175(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 7160, 7175);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_544_7205_7223(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 7205, 7223);
                    return return_v;
                }


                bool
                f_544_7251_7267_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 7251, 7267);
                    return return_v;
                }


                int
                f_544_7238_7354(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 7238, 7354);
                    return 0;
                }


                bool
                f_544_7764_7784(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 7764, 7784);
                    return return_v;
                }


                System.Type
                f_544_8079_8094(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8079, 8094);
                    return return_v;
                }


                int
                f_544_8151_8180(Roslyn.Utilities.ObjectWriter
                this_param, object
                v)
                {
                    this_param.WriteEncodedInt32((int)v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8151, 8180);
                    return 0;
                }


                System.Type
                f_544_8227_8242(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8227, 8242);
                    return return_v;
                }


                int
                f_544_8302_8342(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8302, 8342);
                    return 0;
                }


                int
                f_544_8365_8393(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((double)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8365, 8393);
                    return 0;
                }


                System.Type
                f_544_8440_8455(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8440, 8455);
                    return return_v;
                }


                int
                f_544_8513_8604(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8513, 8604);
                    return 0;
                }


                System.Type
                f_544_8651_8666(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8651, 8666);
                    return return_v;
                }


                int
                f_544_8724_8762(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8724, 8762);
                    return 0;
                }


                int
                f_544_8785_8819(System.IO.BinaryWriter
                this_param, char
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8785, 8819);
                    return 0;
                }


                System.Type
                f_544_8952_8967(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 8952, 8967);
                    return return_v;
                }


                int
                f_544_9025_9064(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9025, 9064);
                    return 0;
                }


                int
                f_544_9087_9113(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9087, 9113);
                    return 0;
                }


                System.Type
                f_544_9160_9175(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9160, 9175);
                    return return_v;
                }


                int
                f_544_9234_9273(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9234, 9273);
                    return 0;
                }


                int
                f_544_9296_9323(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((short)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9296, 9323);
                    return 0;
                }


                System.Type
                f_544_9370_9385(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9370, 9385);
                    return return_v;
                }


                int
                f_544_9443_9482(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9443, 9482);
                    return 0;
                }


                int
                f_544_9505_9531(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9505, 9531);
                    return 0;
                }


                System.Type
                f_544_9578_9593(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9578, 9593);
                    return return_v;
                }


                int
                f_544_9652_9690(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9652, 9690);
                    return 0;
                }


                int
                f_544_9713_9740(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((sbyte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9713, 9740);
                    return 0;
                }


                System.Type
                f_544_9787_9802(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9787, 9802);
                    return return_v;
                }


                int
                f_544_9861_9901(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9861, 9901);
                    return 0;
                }


                int
                f_544_9924_9951(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((float)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9924, 9951);
                    return 0;
                }


                System.Type
                f_544_9998_10013(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 9998, 10013);
                    return return_v;
                }


                int
                f_544_10073_10113(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10073, 10113);
                    return 0;
                }


                int
                f_544_10136_10164(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10136, 10164);
                    return 0;
                }


                System.Type
                f_544_10211_10226(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10211, 10226);
                    return return_v;
                }


                int
                f_544_10284_10315(Roslyn.Utilities.ObjectWriter
                this_param, object
                v)
                {
                    this_param.WriteEncodedUInt32((uint)v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10284, 10315);
                    return 0;
                }


                System.Type
                f_544_10362_10377(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10362, 10377);
                    return return_v;
                }


                int
                f_544_10436_10476(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10436, 10476);
                    return 0;
                }


                int
                f_544_10499_10526(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((ulong)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10499, 10526);
                    return 0;
                }


                System.Type
                f_544_10650_10665(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10650, 10665);
                    return return_v;
                }


                System.Exception
                f_544_10615_10666(System.Type
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10615, 10666);
                    return return_v;
                }


                System.Type
                f_544_10724_10739(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10724, 10739);
                    return return_v;
                }


                int
                f_544_10792_10833(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10792, 10833);
                    return 0;
                }


                int
                f_544_10852_10881(System.IO.BinaryWriter
                this_param, object
                value)
                {
                    this_param.Write((decimal)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10852, 10881);
                    return 0;
                }


                System.Type
                f_544_10920_10935(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10920, 10935);
                    return return_v;
                }


                int
                f_544_10989_11031(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 10989, 11031);
                    return 0;
                }


                int
                f_544_11050_11093(System.IO.BinaryWriter
                this_param, long
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 11050, 11093);
                    return 0;
                }


                System.Type
                f_544_11132_11147(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 11132, 11147);
                    return return_v;
                }


                int
                f_544_11199_11230(Roslyn.Utilities.ObjectWriter
                this_param, object
                value)
                {
                    this_param.WriteStringValue((string)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 11199, 11230);
                    return 0;
                }


                bool
                f_544_11269_11281(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 11269, 11281);
                    return return_v;
                }


                int
                f_544_11367_11380(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 11367, 11380);
                    return return_v;
                }


                string
                f_544_11462_11528()
                {
                    var return_v = Resources.Arrays_with_more_than_one_dimension_cannot_be_serialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 11462, 11528);
                    return return_v;
                }


                System.InvalidOperationException
                f_544_11432_11529(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 11432, 11529);
                    return return_v;
                }


                int
                f_544_11569_11589(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteArray(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 11569, 11589);
                    return 0;
                }


                int
                f_544_11688_11711(Roslyn.Utilities.ObjectWriter
                this_param, System.Text.Encoding
                encoding)
                {
                    this_param.WriteEncoding(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 11688, 11711);
                    return 0;
                }


                int
                f_544_11778_11832(Roslyn.Utilities.ObjectWriter
                this_param, object
                instance, Roslyn.Utilities.IObjectWritable?
                instanceAsWritable)
                {
                    this_param.WriteObject(instance: instance, instanceAsWritable: instanceAsWritable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 11778, 11832);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 6780, 11859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 6780, 11859);
            }
        }

        public void WriteValue(ReadOnlySpan<byte> span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 12165, 13873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12237, 12262);

                int
                length = span.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12276, 12961);

                switch (length)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 12276, 12961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12353, 12395);

                        f_544_12353_12394(_writer, EncodingKind.Array_0);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 12417, 12423);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 12276, 12961);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 12276, 12961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12470, 12512);

                        f_544_12470_12511(_writer, EncodingKind.Array_1);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 12534, 12540);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 12276, 12961);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 12276, 12961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12587, 12629);

                        f_544_12587_12628(_writer, EncodingKind.Array_2);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 12651, 12657);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 12276, 12961);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 12276, 12961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12704, 12746);

                        f_544_12704_12745(_writer, EncodingKind.Array_3);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 12768, 12774);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 12276, 12961);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 12276, 12961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12822, 12862);

                        f_544_12822_12861(_writer, EncodingKind.Array);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12884, 12918);

                        f_544_12884_12917(this, length);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 12940, 12946);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 12276, 12961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 12977, 13008);

                var
                elementType = typeof(byte)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 13022, 13081);

                f_544_13022_13080(f_544_13035_13057(s_typeMap, elementType) == EncodingKind.UInt8);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 13097, 13149);

                f_544_13097_13148(this, elementType, EncodingKind.UInt8);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 13181, 13201);

                f_544_13181_13200(
                            _writer, span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 12165, 13873);

                int
                f_544_12353_12394(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 12353, 12394);
                    return 0;
                }


                int
                f_544_12470_12511(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 12470, 12511);
                    return 0;
                }


                int
                f_544_12587_12628(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 12587, 12628);
                    return 0;
                }


                int
                f_544_12704_12745(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 12704, 12745);
                    return 0;
                }


                int
                f_544_12822_12861(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 12822, 12861);
                    return 0;
                }


                int
                f_544_12884_12917(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteCompressedUInt((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 12884, 12917);
                    return 0;
                }


                Roslyn.Utilities.ObjectWriter.EncodingKind
                f_544_13035_13057(System.Collections.Generic.Dictionary<System.Type, Roslyn.Utilities.ObjectWriter.EncodingKind>
                this_param, System.Type
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 13035, 13057);
                    return return_v;
                }


                int
                f_544_13022_13080(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 13022, 13080);
                    return 0;
                }


                int
                f_544_13097_13148(Roslyn.Utilities.ObjectWriter
                this_param, System.Type
                type, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind)
                {
                    this_param.WritePrimitiveType(type, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 13097, 13148);
                    return 0;
                }


                int
                f_544_13181_13200(System.IO.BinaryWriter
                this_param, System.ReadOnlySpan<byte>
                buffer)
                {
                    #if NETCOREAPP
                        this_param.Write(buffer);
                    #endif
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 13181, 13200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 12165, 13873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 12165, 13873);
            }
        }

        public void WriteValue(IObjectWritable? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 13885, 14169);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 13956, 14086) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 13956, 14086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14007, 14046);

                    f_544_14007_14045(_writer, EncodingKind.Null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14064, 14071);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 13956, 14086);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14102, 14158);

                f_544_14102_14157(this, instance: value, instanceAsWritable: value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 13885, 14169);

                int
                f_544_14007_14045(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14007, 14045);
                    return 0;
                }


                int
                f_544_14102_14157(Roslyn.Utilities.ObjectWriter
                this_param, Roslyn.Utilities.IObjectWritable
                instance, Roslyn.Utilities.IObjectWritable
                instanceAsWritable)
                {
                    this_param.WriteObject(instance: (object)instance, instanceAsWritable: instanceAsWritable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14102, 14157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 13885, 14169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 13885, 14169);
            }
        }

        private void WriteEncodedInt32(int v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 14181, 14895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14243, 14884) || true) && (v >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(544, 14247, 14264) && v <= 10))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14243, 14884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14298, 14351);

                    f_544_14298_14350(_writer, ((int)EncodingKind.Int32_0 + v));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14243, 14884);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14243, 14884);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14385, 14884) || true) && (v >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(544, 14389, 14416) && v < byte.MaxValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14385, 14884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14450, 14496);

                        f_544_14450_14495(_writer, EncodingKind.Int32_1Byte);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14514, 14537);

                        f_544_14514_14536(_writer, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14385, 14884);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14385, 14884);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14571, 14884) || true) && (v >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(544, 14575, 14604) && v < ushort.MaxValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14571, 14884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14638, 14685);

                            f_544_14638_14684(_writer, EncodingKind.Int32_2Bytes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14703, 14728);

                            f_544_14703_14727(_writer, v);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14571, 14884);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14571, 14884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14794, 14834);

                            f_544_14794_14833(_writer, EncodingKind.Int32);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14852, 14869);

                            f_544_14852_14868(_writer, v);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14571, 14884);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14385, 14884);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14243, 14884);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 14181, 14895);

                int
                f_544_14298_14350(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14298, 14350);
                    return 0;
                }


                int
                f_544_14450_14495(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14450, 14495);
                    return 0;
                }


                int
                f_544_14514_14536(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14514, 14536);
                    return 0;
                }


                int
                f_544_14638_14684(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14638, 14684);
                    return 0;
                }


                int
                f_544_14703_14727(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14703, 14727);
                    return 0;
                }


                int
                f_544_14794_14833(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14794, 14833);
                    return 0;
                }


                int
                f_544_14852_14868(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 14852, 14868);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 14181, 14895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 14181, 14895);
            }
        }

        private void WriteEncodedUInt32(uint v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 14907, 15627);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 14971, 15616) || true) && (v >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(544, 14975, 14992) && v <= 10))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14971, 15616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15026, 15080);

                    f_544_15026_15079(_writer, ((int)EncodingKind.UInt32_0 + v));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14971, 15616);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 14971, 15616);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15114, 15616) || true) && (v >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(544, 15118, 15145) && v < byte.MaxValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 15114, 15616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15179, 15226);

                        f_544_15179_15225(_writer, EncodingKind.UInt32_1Byte);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15244, 15267);

                        f_544_15244_15266(_writer, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 15114, 15616);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 15114, 15616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15301, 15616) || true) && (v >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(544, 15305, 15334) && v < ushort.MaxValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 15301, 15616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15368, 15416);

                            f_544_15368_15415(_writer, EncodingKind.UInt32_2Bytes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15434, 15459);

                            f_544_15434_15458(_writer, v);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 15301, 15616);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 15301, 15616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15525, 15566);

                            f_544_15525_15565(_writer, EncodingKind.UInt32);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 15584, 15601);

                            f_544_15584_15600(_writer, v);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 15301, 15616);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 15114, 15616);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 14971, 15616);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 14907, 15627);

                int
                f_544_15026_15079(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 15026, 15079);
                    return 0;
                }


                int
                f_544_15179_15225(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 15179, 15225);
                    return 0;
                }


                int
                f_544_15244_15266(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 15244, 15266);
                    return 0;
                }


                int
                f_544_15368_15415(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 15368, 15415);
                    return 0;
                }


                int
                f_544_15434_15458(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 15434, 15458);
                    return 0;
                }


                int
                f_544_15525_15565(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 15525, 15565);
                    return 0;
                }


                int
                f_544_15584_15600(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 15584, 15600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 14907, 15627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 14907, 15627);
            }
        }

        private struct WriterReferenceMap
        {

            private readonly Dictionary<object, int> _valueToIdMap;

            private readonly bool _valueEquality;

            private int _nextId;

            private static readonly ObjectPool<Dictionary<object, int>> s_referenceDictionaryPool;

            private static readonly ObjectPool<Dictionary<object, int>> s_valueDictionaryPool;

            public WriterReferenceMap(bool valueEquality)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(544, 16354, 16586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 16432, 16463);

                    _valueEquality = valueEquality;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 16481, 16541);

                    _valueToIdMap = f_544_16497_16540(GetDictionaryPool(valueEquality));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 16559, 16571);

                    _nextId = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(544, 16354, 16586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 16354, 16586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 16354, 16586);
                }
            }

            private static ObjectPool<Dictionary<object, int>> GetDictionaryPool(bool valueEquality)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 16708, 16776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 16711, 16776);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(544, 16711, 16724) || ((valueEquality && DynAbs.Tracing.TraceSender.Conditional_F2(544, 16727, 16748)) || DynAbs.Tracing.TraceSender.Conditional_F3(544, 16751, 16776))) ? s_valueDictionaryPool : s_referenceDictionaryPool; DynAbs.Tracing.TraceSender.TraceExitMethod(544, 16708, 16776);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 16708, 16776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 16708, 16776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 16793, 17378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 16847, 16892);

                    var
                    pool = GetDictionaryPool(_valueEquality)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17081, 17363) || true) && (f_544_17085_17104(_valueToIdMap) > 1024)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 17081, 17363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17153, 17193);

                        f_544_17153_17192(pool, _valueToIdMap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 17081, 17363);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 17081, 17363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17275, 17297);

                        f_544_17275_17296(_valueToIdMap);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17319, 17344);

                        f_544_17319_17343(pool, _valueToIdMap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 17081, 17363);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(544, 16793, 17378);

                    int
                    f_544_17085_17104(System.Collections.Generic.Dictionary<object, int>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 17085, 17104);
                        return return_v;
                    }


                    int
                    f_544_17153_17192(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>
                    this_param, System.Collections.Generic.Dictionary<object, int>
                    old)
                    {
                        this_param.ForgetTrackedObject(old);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 17153, 17192);
                        return 0;
                    }


                    int
                    f_544_17275_17296(System.Collections.Generic.Dictionary<object, int>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 17275, 17296);
                        return 0;
                    }


                    int
                    f_544_17319_17343(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>
                    this_param, System.Collections.Generic.Dictionary<object, int>
                    obj)
                    {
                        this_param.Free(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 17319, 17343);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 16793, 17378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 16793, 17378);
                }
            }

            public bool TryGetReferenceId(object value, out int referenceId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 17476, 17528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17479, 17528);
                    return f_544_17479_17528(_valueToIdMap, value, out referenceId); DynAbs.Tracing.TraceSender.TraceExitMethod(544, 17476, 17528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 17476, 17528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 17476, 17528);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_544_17479_17528(System.Collections.Generic.Dictionary<object, int>
                this_param, object
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 17479, 17528);
                    return return_v;
                }

            }

            public void Add(object value, bool isReusable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 17545, 17782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17624, 17643);

                    var
                    id = _nextId++
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17663, 17767) || true) && (isReusable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 17663, 17767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17719, 17748);

                        f_544_17719_17747(_valueToIdMap, value, id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 17663, 17767);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(544, 17545, 17782);

                    int
                    f_544_17719_17747(System.Collections.Generic.Dictionary<object, int>
                    this_param, object
                    key, int
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 17719, 17747);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 17545, 17782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 17545, 17782);
                }
            }
            static WriterReferenceMap()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(544, 15778, 17793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 16052, 16176);
                s_referenceDictionaryPool = f_544_16097_16176(() => new Dictionary<object, int>(128, ReferenceEqualityComparer.Instance));
                static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>
f_544_16097_16176(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>.Factory
factory)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>(factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 16097, 16176);
                    return return_v;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 16253, 16337);
                s_valueDictionaryPool = f_544_16294_16337(() => new Dictionary<object, int>(128));
                static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>
f_544_16294_16337(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>.Factory
factory)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>(factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 16294, 16337);
                    return return_v;
                }

                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(544, 15778, 17793);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 15778, 17793);
            }

            static System.Collections.Generic.Dictionary<object, int>
            f_544_16497_16540(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<object, int>>
            this_param)
            {
                var return_v = this_param.Allocate();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 16497, 16540);
                return return_v;
            }

        }

        internal void WriteCompressedUInt(uint value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 17805, 19037);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17875, 19026) || true) && (value <= (byte.MaxValue >> 2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 17875, 19026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 17942, 17969);

                    f_544_17942_17968(_writer, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 17875, 19026);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 17875, 19026);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18003, 19026) || true) && (value <= (ushort.MaxValue >> 2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 18003, 19026);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18072, 18130);

                        byte
                        byte0 = (byte)(((value >> 8) & 0xFFu) | Byte2Marker)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18148, 18183);

                        byte
                        byte1 = (byte)(value & 0xFFu)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18247, 18268);

                        f_544_18247_18267(
                                        // high-bytes to low-bytes
                                        _writer, byte0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18286, 18307);

                        f_544_18286_18306(_writer, byte1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 18003, 19026);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 18003, 19026);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18341, 19026) || true) && (value <= (uint.MaxValue >> 2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 18341, 19026);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18408, 18467);

                            byte
                            byte0 = (byte)(((value >> 24) & 0xFFu) | Byte4Marker)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18485, 18528);

                            byte
                            byte1 = (byte)((value >> 16) & 0xFFu)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18546, 18588);

                            byte
                            byte2 = (byte)((value >> 8) & 0xFFu)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18606, 18641);

                            byte
                            byte3 = (byte)(value & 0xFFu)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18705, 18726);

                            f_544_18705_18725(
                                            // high-bytes to low-bytes
                                            _writer, byte0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18744, 18765);

                            f_544_18744_18764(_writer, byte1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18783, 18804);

                            f_544_18783_18803(_writer, byte2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18822, 18843);

                            f_544_18822_18842(_writer, byte3);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 18341, 19026);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 18341, 19026);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 18909, 19011);

                            throw f_544_18915_19010(f_544_18937_19009());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 18341, 19026);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 18003, 19026);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 17875, 19026);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 17805, 19037);

                int
                f_544_17942_17968(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 17942, 17968);
                    return 0;
                }


                int
                f_544_18247_18267(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 18247, 18267);
                    return 0;
                }


                int
                f_544_18286_18306(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 18286, 18306);
                    return 0;
                }


                int
                f_544_18705_18725(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 18705, 18725);
                    return 0;
                }


                int
                f_544_18744_18764(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 18744, 18764);
                    return 0;
                }


                int
                f_544_18783_18803(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 18783, 18803);
                    return 0;
                }


                int
                f_544_18822_18842(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 18822, 18842);
                    return 0;
                }


                string
                f_544_18937_19009()
                {
                    var return_v = Resources.Value_too_large_to_be_represented_as_a_30_bit_unsigned_integer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 18937, 19009);
                    return return_v;
                }


                System.ArgumentException
                f_544_18915_19010(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 18915, 19010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 17805, 19037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 17805, 19037);
            }
        }

        private unsafe void WriteStringValue(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 19049, 21223);
                int id = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19125, 21212) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19125, 21212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19176, 19215);

                    f_544_19176_19214(_writer, EncodingKind.Null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19125, 21212);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19125, 21212);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19281, 21197) || true) && (_stringReferenceMap.TryGetReferenceId(value, out id
                    ))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19281, 21197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19383, 19405);

                        f_544_19383_19404(id >= 0);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19427, 20044) || true) && (id <= byte.MaxValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19427, 20044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19500, 19550);

                            f_544_19500_19549(_writer, EncodingKind.StringRef_1Byte);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19576, 19600);

                            f_544_19576_19599(_writer, id);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19427, 20044);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19427, 20044);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19650, 20044) || true) && (id <= ushort.MaxValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19650, 20044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19725, 19776);

                                f_544_19725_19775(_writer, EncodingKind.StringRef_2Bytes);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19802, 19828);

                                f_544_19802_19827(_writer, id);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19650, 20044);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19650, 20044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 19926, 19977);

                                f_544_19926_19976(_writer, EncodingKind.StringRef_4Bytes);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20003, 20021);

                                f_544_20003_20020(_writer, id);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19650, 20044);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19427, 20044);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19281, 21197);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 19281, 21197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20126, 20175);

                        _stringReferenceMap.Add(value, isReusable: true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20199, 21178) || true) && (f_544_20203_20231(value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 20199, 21178);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20438, 20483);

                            f_544_20438_20482(                        // Usual case - the string can be encoded as UTF8:
                                                                      // We can use the UTF8 encoding of the binary writer.

                                                    _writer, EncodingKind.StringUtf8);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20509, 20530);

                            f_544_20509_20529(_writer, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 20199, 21178);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 20199, 21178);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20628, 20674);

                            f_544_20628_20673(_writer, EncodingKind.StringUtf16);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20786, 20845);

                            byte[]
                            bytes = new byte[(uint)f_544_20816_20828(value) * sizeof(char)]
                            ;
                            fixed (char*
    valuePtr = value
    )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 20958, 21013);

                                f_544_20958_21012(valuePtr, bytes, 0, f_544_20999_21011(bytes));
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21068, 21108);

                            f_544_21068_21107(this, f_544_21094_21106(value));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21134, 21155);

                            f_544_21134_21154(_writer, bytes);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 20199, 21178);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19281, 21197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 19125, 21212);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 19049, 21223);

                int
                f_544_19176_19214(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 19176, 19214);
                    return 0;
                }


                int
                f_544_19383_19404(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 19383, 19404);
                    return 0;
                }


                int
                f_544_19500_19549(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 19500, 19549);
                    return 0;
                }


                int
                f_544_19576_19599(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 19576, 19599);
                    return 0;
                }


                int
                f_544_19725_19775(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 19725, 19775);
                    return 0;
                }


                int
                f_544_19802_19827(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 19802, 19827);
                    return 0;
                }


                int
                f_544_19926_19976(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 19926, 19976);
                    return 0;
                }


                int
                f_544_20003_20020(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 20003, 20020);
                    return 0;
                }


                bool
                f_544_20203_20231(string
                str)
                {
                    var return_v = str.IsValidUnicodeString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 20203, 20231);
                    return return_v;
                }


                int
                f_544_20438_20482(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 20438, 20482);
                    return 0;
                }


                int
                f_544_20509_20529(System.IO.BinaryWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 20509, 20529);
                    return 0;
                }


                int
                f_544_20628_20673(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 20628, 20673);
                    return 0;
                }


                int
                f_544_20816_20828(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 20816, 20828);
                    return return_v;
                }


                int
                f_544_20999_21011(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 20999, 21011);
                    return return_v;
                }


                unsafe int
                f_544_20958_21012(char*
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy((System.IntPtr)source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 20958, 21012);
                    return 0;
                }


                int
                f_544_21094_21106(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 21094, 21106);
                    return return_v;
                }


                int
                f_544_21068_21107(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteCompressedUInt((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21068, 21107);
                    return 0;
                }


                int
                f_544_21134_21154(System.IO.BinaryWriter
                this_param, byte[]
                buffer)
                {
                    this_param.Write(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21134, 21154);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 19049, 21223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 19049, 21223);
            }
        }

        private void WriteArray(Array array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 21235, 24288);
                Roslyn.Utilities.ObjectWriter.EncodingKind elementKind = default(Roslyn.Utilities.ObjectWriter.EncodingKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21296, 21328);

                int
                length = f_544_21309_21327(array, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21344, 22034);

                switch (length)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 21344, 22034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21421, 21463);

                        f_544_21421_21462(_writer, EncodingKind.Array_0);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 21485, 21491);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 21344, 22034);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 21344, 22034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21538, 21580);

                        f_544_21538_21579(_writer, EncodingKind.Array_1);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 21602, 21608);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 21344, 22034);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 21344, 22034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21655, 21697);

                        f_544_21655_21696(_writer, EncodingKind.Array_2);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 21719, 21725);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 21344, 22034);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 21344, 22034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21772, 21814);

                        f_544_21772_21813(_writer, EncodingKind.Array_3);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 21836, 21842);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 21344, 22034);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 21344, 22034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21890, 21930);

                        f_544_21890_21929(_writer, EncodingKind.Array);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 21952, 21991);

                        f_544_21952_21990(this, length);
                        DynAbs.Tracing.TraceSender.TraceBreak(544, 22013, 22019);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 21344, 22034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22050, 22102);

                var
                elementType = f_544_22068_22100(f_544_22068_22083(array))!
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22118, 24277) || true) && (f_544_22122_22177(s_typeMap, elementType, out elementKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 22118, 24277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22211, 22261);

                    f_544_22211_22260(this, elementType, elementKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22279, 22349);

                    f_544_22279_22348(this, elementType, elementKind, array);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 22118, 24277);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 22118, 24277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22456, 22489);

                    f_544_22456_22488(                // emit header up front
                                    this, elementType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22559, 22590);

                    var
                    oldDepth = _recursionDepth
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22608, 22626);

                    _recursionDepth++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 22646, 24164) || true) && (_recursionDepth % MaxRecursionDepth == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 22646, 24164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 23021, 23297);

                        var
                        task = f_544_23032_23296(f_544_23032_23044(), a => WriteArrayValues((Array)a!), array, _cancellationToken, TaskCreationOptions.LongRunning, f_544_23274_23295())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24009, 24039);

                        f_544_24009_24026(
                                            // We must not proceed until the additional task completes. After returning from a write, the underlying
                                            // stream providing access to raw memory will be closed; if this occurs before the separate thread
                                            // completes its write then an access violation can occur attempting to write to unmapped memory.
                                            //
                                            // CANCELLATION: If cancellation is required, DO NOT attempt to cancel the operation by cancelling this
                                            // wait. Cancellation must only be implemented by modifying 'task' to cancel itself in a timely manner
                                            // so the wait can complete.
                                            task).GetResult();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 22646, 24164);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 22646, 24164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24121, 24145);

                        f_544_24121_24144(this, array);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 22646, 24164);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24184, 24202);

                    _recursionDepth--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24220, 24262);

                    f_544_24220_24261(_recursionDepth == oldDepth);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 22118, 24277);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 21235, 24288);

                int
                f_544_21309_21327(System.Array
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21309, 21327);
                    return return_v;
                }


                int
                f_544_21421_21462(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21421, 21462);
                    return 0;
                }


                int
                f_544_21538_21579(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21538, 21579);
                    return 0;
                }


                int
                f_544_21655_21696(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21655, 21696);
                    return 0;
                }


                int
                f_544_21772_21813(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21772, 21813);
                    return 0;
                }


                int
                f_544_21890_21929(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21890, 21929);
                    return 0;
                }


                int
                f_544_21952_21990(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteCompressedUInt((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 21952, 21990);
                    return 0;
                }


                System.Type
                f_544_22068_22083(System.Array
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 22068, 22083);
                    return return_v;
                }


                System.Type?
                f_544_22068_22100(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 22068, 22100);
                    return return_v;
                }


                bool
                f_544_22122_22177(System.Collections.Generic.Dictionary<System.Type, Roslyn.Utilities.ObjectWriter.EncodingKind>
                this_param, System.Type
                key, out Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 22122, 22177);
                    return return_v;
                }


                int
                f_544_22211_22260(Roslyn.Utilities.ObjectWriter
                this_param, System.Type
                type, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind)
                {
                    this_param.WritePrimitiveType(type, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 22211, 22260);
                    return 0;
                }


                int
                f_544_22279_22348(Roslyn.Utilities.ObjectWriter
                this_param, System.Type
                type, Roslyn.Utilities.ObjectWriter.EncodingKind
                kind, System.Array
                instance)
                {
                    this_param.WritePrimitiveTypeArrayElements(type, kind, instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 22279, 22348);
                    return 0;
                }


                int
                f_544_22456_22488(Roslyn.Utilities.ObjectWriter
                this_param, System.Type
                type)
                {
                    this_param.WriteKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 22456, 22488);
                    return 0;
                }


                System.Threading.Tasks.TaskFactory
                f_544_23032_23044()
                {
                    var return_v = Task.Factory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 23032, 23044);
                    return return_v;
                }


                System.Threading.Tasks.TaskScheduler
                f_544_23274_23295()
                {
                    var return_v = TaskScheduler.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 23274, 23295);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_544_23032_23296(System.Threading.Tasks.TaskFactory
                this_param, System.Action<object?>
                action, System.Array
                state, System.Threading.CancellationToken
                cancellationToken, System.Threading.Tasks.TaskCreationOptions
                creationOptions, System.Threading.Tasks.TaskScheduler
                scheduler)
                {
                    var return_v = this_param.StartNew(action, (object)state, cancellationToken, creationOptions, scheduler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 23032, 23296);
                    return return_v;
                }


                System.Runtime.CompilerServices.TaskAwaiter
                f_544_24009_24026(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.GetAwaiter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24009, 24026);
                    return return_v;
                }


                int
                f_544_24121_24144(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteArrayValues(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24121, 24144);
                    return 0;
                }


                int
                f_544_24220_24261(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24220, 24261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 21235, 24288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 21235, 24288);
            }
        }

        private void WriteArrayValues(Array array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 24300, 24499);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24376, 24381);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24367, 24488) || true) && (i < f_544_24387_24399(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24401, 24404)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 24367, 24488))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 24367, 24488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24438, 24473);

                        f_544_24438_24472(this, f_544_24454_24471(array, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 122);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 24300, 24499);

                int
                f_544_24387_24399(System.Array
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 24387, 24399);
                    return return_v;
                }


                object?
                f_544_24454_24471(System.Array
                this_param, int
                index)
                {
                    var return_v = this_param.GetValue(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24454, 24471);
                    return return_v;
                }


                int
                f_544_24438_24472(Roslyn.Utilities.ObjectWriter
                this_param, object?
                value)
                {
                    this_param.WriteValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24438, 24472);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 24300, 24499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 24300, 24499);
            }
        }

        private void WritePrimitiveTypeArrayElements(Type type, EncodingKind kind, Array instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 24511, 27248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24626, 24664);

                f_544_24626_24663(f_544_24639_24654(s_typeMap, type) == kind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24755, 27237) || true) && (type == typeof(byte))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 24755, 27237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24813, 24845);

                    f_544_24813_24844(_writer, instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 24755, 27237);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 24755, 27237);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24879, 27237) || true) && (type == typeof(char))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 24879, 27237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 24937, 24969);

                        f_544_24937_24968(_writer, instance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 24879, 27237);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 24879, 27237);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25003, 27237) || true) && (type == typeof(string))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25003, 27237);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25198, 25243);

                            f_544_25198_25242(this, instance);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25003, 27237);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25003, 27237);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25277, 27237) || true) && (type == typeof(bool))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25277, 27237);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25383, 25427);

                                f_544_25383_25426(this, instance);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25277, 27237);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25277, 27237);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25576, 27222);

                                switch (kind)
                                {

                                    case EncodingKind.Int8:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25679, 25721);

                                        f_544_25679_25720(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25747, 25754);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.Int16:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25826, 25869);

                                        f_544_25826_25868(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25895, 25902);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.Int32:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 25974, 26015);

                                        f_544_25974_26014(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26041, 26048);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.Int64:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26120, 26162);

                                        f_544_26120_26161(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26188, 26195);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.UInt16:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26268, 26313);

                                        f_544_26268_26312(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26339, 26346);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.UInt32:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26419, 26462);

                                        f_544_26419_26461(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26488, 26495);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.UInt64:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26568, 26612);

                                        f_544_26568_26611(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26638, 26645);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.Float4:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26718, 26762);

                                        f_544_26718_26761(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26788, 26795);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.Float8:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26868, 26913);

                                        f_544_26868_26912(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 26939, 26946);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    case EncodingKind.Decimal:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27020, 27067);

                                        f_544_27020_27066(this, instance);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27093, 27100);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 25576, 27222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27156, 27203);

                                        throw f_544_27162_27202(kind);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25576, 27222);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25277, 27237);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 25003, 27237);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 24879, 27237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 24755, 27237);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 24511, 27248);

                Roslyn.Utilities.ObjectWriter.EncodingKind
                f_544_24639_24654(System.Collections.Generic.Dictionary<System.Type, Roslyn.Utilities.ObjectWriter.EncodingKind>
                this_param, System.Type
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 24639, 24654);
                    return return_v;
                }


                int
                f_544_24626_24663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24626, 24663);
                    return 0;
                }


                int
                f_544_24813_24844(System.IO.BinaryWriter
                this_param, System.Array
                buffer)
                {
                    this_param.Write((byte[])buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24813, 24844);
                    return 0;
                }


                int
                f_544_24937_24968(System.IO.BinaryWriter
                this_param, System.Array
                chars)
                {
                    this_param.Write((char[])chars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 24937, 24968);
                    return 0;
                }


                int
                f_544_25198_25242(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteStringArrayElements((string[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 25198, 25242);
                    return 0;
                }


                int
                f_544_25383_25426(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteBooleanArrayElements((bool[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 25383, 25426);
                    return 0;
                }


                int
                f_544_25679_25720(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteInt8ArrayElements((sbyte[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 25679, 25720);
                    return 0;
                }


                int
                f_544_25826_25868(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteInt16ArrayElements((short[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 25826, 25868);
                    return 0;
                }


                int
                f_544_25974_26014(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteInt32ArrayElements((int[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 25974, 26014);
                    return 0;
                }


                int
                f_544_26120_26161(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteInt64ArrayElements((long[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 26120, 26161);
                    return 0;
                }


                int
                f_544_26268_26312(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteUInt16ArrayElements((ushort[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 26268, 26312);
                    return 0;
                }


                int
                f_544_26419_26461(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteUInt32ArrayElements((uint[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 26419, 26461);
                    return 0;
                }


                int
                f_544_26568_26611(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteUInt64ArrayElements((ulong[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 26568, 26611);
                    return 0;
                }


                int
                f_544_26718_26761(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteFloat4ArrayElements((float[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 26718, 26761);
                    return 0;
                }


                int
                f_544_26868_26912(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteFloat8ArrayElements((double[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 26868, 26912);
                    return 0;
                }


                int
                f_544_27020_27066(Roslyn.Utilities.ObjectWriter
                this_param, System.Array
                array)
                {
                    this_param.WriteDecimalArrayElements((decimal[])array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 27020, 27066);
                    return 0;
                }


                System.Exception
                f_544_27162_27202(Roslyn.Utilities.ObjectWriter.EncodingKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 27162, 27202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 24511, 27248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 24511, 27248);
            }
        }

        private void WriteBooleanArrayElements(bool[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 27260, 27711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27385, 27427);

                var
                bits = BitVector.Create(f_544_27413_27425(array))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27450, 27455);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27441, 27546) || true) && (i < f_544_27461_27473(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27475, 27478)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 27441, 27546))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 27441, 27546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27512, 27531);

                        bits[i] = array[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 106);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27598, 27700);
                    foreach (var word in f_544_27619_27631_I(bits.Words()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 27598, 27700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27665, 27685);

                        f_544_27665_27684(_writer, word);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 27598, 27700);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 103);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 27260, 27711);

                int
                f_544_27413_27425(bool[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 27413, 27425);
                    return return_v;
                }


                int
                f_544_27461_27473(bool[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 27461, 27473);
                    return return_v;
                }


                int
                f_544_27665_27684(System.IO.BinaryWriter
                this_param, ulong
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 27665, 27684);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<ulong>
                f_544_27619_27631_I(System.Collections.Generic.IEnumerable<ulong>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 27619, 27631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 27260, 27711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 27260, 27711);
            }
        }

        private void WriteStringArrayElements(string[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 27723, 27925);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27810, 27815);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27801, 27914) || true) && (i < f_544_27821_27833(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27835, 27838)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 27801, 27914))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 27801, 27914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 27872, 27899);

                        f_544_27872_27898(this, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 27723, 27925);

                int
                f_544_27821_27833(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 27821, 27833);
                    return return_v;
                }


                int
                f_544_27872_27898(Roslyn.Utilities.ObjectWriter
                this_param, string
                value)
                {
                    this_param.WriteStringValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 27872, 27898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 27723, 27925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 27723, 27925);
            }
        }

        private void WriteInt8ArrayElements(sbyte[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 27937, 28133);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28021, 28026);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28012, 28122) || true) && (i < f_544_28032_28044(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28046, 28049)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 28012, 28122))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 28012, 28122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28083, 28107);

                        f_544_28083_28106(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 27937, 28133);

                int
                f_544_28032_28044(sbyte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 28032, 28044);
                    return return_v;
                }


                int
                f_544_28083_28106(System.IO.BinaryWriter
                this_param, sbyte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 28083, 28106);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 27937, 28133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 27937, 28133);
            }
        }

        private void WriteInt16ArrayElements(short[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 28145, 28342);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28230, 28235);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28221, 28331) || true) && (i < f_544_28241_28253(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28255, 28258)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 28221, 28331))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 28221, 28331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28292, 28316);

                        f_544_28292_28315(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 28145, 28342);

                int
                f_544_28241_28253(short[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 28241, 28253);
                    return return_v;
                }


                int
                f_544_28292_28315(System.IO.BinaryWriter
                this_param, short
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 28292, 28315);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 28145, 28342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 28145, 28342);
            }
        }

        private void WriteInt32ArrayElements(int[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 28354, 28549);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28437, 28442);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28428, 28538) || true) && (i < f_544_28448_28460(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28462, 28465)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 28428, 28538))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 28428, 28538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28499, 28523);

                        f_544_28499_28522(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 28354, 28549);

                int
                f_544_28448_28460(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 28448, 28460);
                    return return_v;
                }


                int
                f_544_28499_28522(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 28499, 28522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 28354, 28549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 28354, 28549);
            }
        }

        private void WriteInt64ArrayElements(long[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 28561, 28757);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28645, 28650);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28636, 28746) || true) && (i < f_544_28656_28668(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28670, 28673)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 28636, 28746))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 28636, 28746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28707, 28731);

                        f_544_28707_28730(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 28561, 28757);

                int
                f_544_28656_28668(long[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 28656, 28668);
                    return return_v;
                }


                int
                f_544_28707_28730(System.IO.BinaryWriter
                this_param, long
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 28707, 28730);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 28561, 28757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 28561, 28757);
            }
        }

        private void WriteUInt16ArrayElements(ushort[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 28769, 28968);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28856, 28861);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28847, 28957) || true) && (i < f_544_28867_28879(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28881, 28884)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 28847, 28957))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 28847, 28957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 28918, 28942);

                        f_544_28918_28941(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 28769, 28968);

                int
                f_544_28867_28879(ushort[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 28867, 28879);
                    return return_v;
                }


                int
                f_544_28918_28941(System.IO.BinaryWriter
                this_param, ushort
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 28918, 28941);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 28769, 28968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 28769, 28968);
            }
        }

        private void WriteUInt32ArrayElements(uint[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 28980, 29177);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29065, 29070);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29056, 29166) || true) && (i < f_544_29076_29088(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29090, 29093)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 29056, 29166))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 29056, 29166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29127, 29151);

                        f_544_29127_29150(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 28980, 29177);

                int
                f_544_29076_29088(uint[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 29076, 29088);
                    return return_v;
                }


                int
                f_544_29127_29150(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 29127, 29150);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 28980, 29177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 28980, 29177);
            }
        }

        private void WriteUInt64ArrayElements(ulong[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 29189, 29387);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29275, 29280);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29266, 29376) || true) && (i < f_544_29286_29298(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29300, 29303)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 29266, 29376))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 29266, 29376);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29337, 29361);

                        f_544_29337_29360(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 29189, 29387);

                int
                f_544_29286_29298(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 29286, 29298);
                    return return_v;
                }


                int
                f_544_29337_29360(System.IO.BinaryWriter
                this_param, ulong
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 29337, 29360);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 29189, 29387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 29189, 29387);
            }
        }

        private void WriteDecimalArrayElements(decimal[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 29399, 29600);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29488, 29493);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29479, 29589) || true) && (i < f_544_29499_29511(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29513, 29516)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 29479, 29589))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 29479, 29589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29550, 29574);

                        f_544_29550_29573(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 29399, 29600);

                int
                f_544_29499_29511(decimal[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 29499, 29511);
                    return return_v;
                }


                int
                f_544_29550_29573(System.IO.BinaryWriter
                this_param, decimal
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 29550, 29573);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 29399, 29600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 29399, 29600);
            }
        }

        private void WriteFloat4ArrayElements(float[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 29612, 29810);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29698, 29703);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29689, 29799) || true) && (i < f_544_29709_29721(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29723, 29726)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 29689, 29799))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 29689, 29799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29760, 29784);

                        f_544_29760_29783(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 29612, 29810);

                int
                f_544_29709_29721(float[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 29709, 29721);
                    return return_v;
                }


                int
                f_544_29760_29783(System.IO.BinaryWriter
                this_param, float
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 29760, 29783);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 29612, 29810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 29612, 29810);
            }
        }

        private void WriteFloat8ArrayElements(double[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 29822, 30021);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29909, 29914);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29900, 30010) || true) && (i < f_544_29920_29932(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29934, 29937)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(544, 29900, 30010))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 29900, 30010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 29971, 29995);

                        f_544_29971_29994(_writer, array[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 29822, 30021);

                int
                f_544_29920_29932(double[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 29920, 29932);
                    return return_v;
                }


                int
                f_544_29971_29994(System.IO.BinaryWriter
                this_param, double
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 29971, 29994);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 29822, 30021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 29822, 30021);
            }
        }

        private void WritePrimitiveType(Type type, EncodingKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 30033, 30208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30119, 30157);

                f_544_30119_30156(f_544_30132_30147(s_typeMap, type) == kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30171, 30197);

                f_544_30171_30196(_writer, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 30033, 30208);

                Roslyn.Utilities.ObjectWriter.EncodingKind
                f_544_30132_30147(System.Collections.Generic.Dictionary<System.Type, Roslyn.Utilities.ObjectWriter.EncodingKind>
                this_param, System.Type
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 30132, 30147);
                    return return_v;
                }


                int
                f_544_30119_30156(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30119, 30156);
                    return 0;
                }


                int
                f_544_30171_30196(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30171, 30196);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 30033, 30208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 30033, 30208);
            }
        }

        public void WriteType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 30220, 30386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30277, 30316);

                f_544_30277_30315(_writer, EncodingKind.Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30330, 30375);

                f_544_30330_30374(this, f_544_30347_30373(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 30220, 30386);

                int
                f_544_30277_30315(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30277, 30315);
                    return 0;
                }


                string?
                f_544_30347_30373(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 30347, 30373);
                    return return_v;
                }


                int
                f_544_30330_30374(Roslyn.Utilities.ObjectWriter
                this_param, string?
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30330, 30374);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 30220, 30386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 30220, 30386);
            }
        }

        private void WriteKnownType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 30398, 30574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30461, 30500);

                f_544_30461_30499(_writer, EncodingKind.Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30514, 30563);

                f_544_30514_30562(this, _binderSnapshot.GetTypeId(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 30398, 30574);

                int
                f_544_30461_30499(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30461, 30499);
                    return 0;
                }


                int
                f_544_30514_30562(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30514, 30562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 30398, 30574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 30398, 30574);
            }
        }

        public void WriteEncoding(Encoding? encoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 30586, 30873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30656, 30693);

                var
                kind = f_544_30667_30692(encoding)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30707, 30729);

                f_544_30707_30728(this, kind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30745, 30862) || true) && (kind == EncodingKind.EncodingName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 30745, 30862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30816, 30847);

                    f_544_30816_30846(this, f_544_30828_30845(encoding!));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 30745, 30862);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 30586, 30873);

                Roslyn.Utilities.ObjectWriter.EncodingKind
                f_544_30667_30692(System.Text.Encoding?
                encoding)
                {
                    var return_v = GetEncodingKind(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30667, 30692);
                    return return_v;
                }


                int
                f_544_30707_30728(Roslyn.Utilities.ObjectWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30707, 30728);
                    return 0;
                }


                string
                f_544_30828_30845(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.WebName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 30828, 30845);
                    return return_v;
                }


                int
                f_544_30816_30846(Roslyn.Utilities.ObjectWriter
                this_param, string
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 30816, 30846);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 30586, 30873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 30586, 30873);
            }
        }

        private static EncodingKind GetEncodingKind(Encoding? encoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(544, 30885, 32700);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 30973, 31067) || true) && (encoding is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 30973, 31067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31027, 31052);

                    return EncodingKind.Null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 30973, 31067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31083, 32497);

                switch (f_544_31091_31108(encoding))
                {

                    case 1200:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 31083, 32497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31174, 31218);

                        f_544_31174_31217(f_544_31187_31216(f_544_31199_31215()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31240, 31380);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(544, 31247, 31307) || (((f_544_31248_31281(encoding, f_544_31264_31280()) || (DynAbs.Tracing.TraceSender.Expression_False(544, 31248, 31306) || f_544_31285_31306(encoding))) && DynAbs.Tracing.TraceSender.Conditional_F2(544, 31310, 31345)) || DynAbs.Tracing.TraceSender.Conditional_F3(544, 31348, 31379))) ? EncodingKind.EncodingUnicode_LE_BOM : EncodingKind.EncodingUnicode_LE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 31083, 32497);

                    case 1201:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 31083, 32497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31432, 31485);

                        f_544_31432_31484(f_544_31445_31483(f_544_31457_31482()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31507, 31656);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(544, 31514, 31583) || (((f_544_31515_31557(encoding, f_544_31531_31556()) || (DynAbs.Tracing.TraceSender.Expression_False(544, 31515, 31582) || f_544_31561_31582(encoding))) && DynAbs.Tracing.TraceSender.Conditional_F2(544, 31586, 31621)) || DynAbs.Tracing.TraceSender.Conditional_F3(544, 31624, 31655))) ? EncodingKind.EncodingUnicode_BE_BOM : EncodingKind.EncodingUnicode_BE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 31083, 32497);

                    case 12000:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 31083, 32497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31709, 31751);

                        f_544_31709_31750(f_544_31722_31749(f_544_31734_31748()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31773, 31907);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(544, 31780, 31838) || (((f_544_31781_31812(encoding, f_544_31797_31811()) || (DynAbs.Tracing.TraceSender.Expression_False(544, 31781, 31837) || f_544_31816_31837(encoding))) && DynAbs.Tracing.TraceSender.Conditional_F2(544, 31841, 31874)) || DynAbs.Tracing.TraceSender.Conditional_F3(544, 31877, 31906))) ? EncodingKind.EncodingUTF32_LE_BOM : EncodingKind.EncodingUTF32_LE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 31083, 32497);

                    case 12001:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 31083, 32497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 31960, 32002);

                        f_544_31960_32001(f_544_31973_32000(f_544_31985_31999()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32024, 32158);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(544, 32031, 32089) || (((f_544_32032_32063(encoding, f_544_32048_32062()) || (DynAbs.Tracing.TraceSender.Expression_False(544, 32032, 32088) || f_544_32067_32088(encoding))) && DynAbs.Tracing.TraceSender.Conditional_F2(544, 32092, 32125)) || DynAbs.Tracing.TraceSender.Conditional_F3(544, 32128, 32157))) ? EncodingKind.EncodingUTF32_BE_BOM : EncodingKind.EncodingUTF32_BE;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 31083, 32497);

                    case 65001:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 31083, 32497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32211, 32252);

                        f_544_32211_32251(f_544_32224_32250(f_544_32236_32249()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32274, 32399);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(544, 32281, 32338) || (((f_544_32282_32312(encoding, f_544_32298_32311()) || (DynAbs.Tracing.TraceSender.Expression_False(544, 32282, 32337) || f_544_32316_32337(encoding))) && DynAbs.Tracing.TraceSender.Conditional_F2(544, 32341, 32370)) || DynAbs.Tracing.TraceSender.Conditional_F3(544, 32373, 32398))) ? EncodingKind.EncodingUTF8_BOM : EncodingKind.EncodingUTF8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 31083, 32497);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 31083, 32497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32449, 32482);

                        return EncodingKind.EncodingName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 31083, 32497);
                }

                static bool HasPreamble(Encoding encoding)
                {
                    try
                    {
#if NETCOREAPP
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 32589, 32618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32592, 32618);
                        return f_544_32592_32618_M(!encoding.Preamble.IsEmpty); 
                        DynAbs.Tracing.TraceSender.TraceExitMethod(544, 32589, 32618);
#else
                        return !encoding.GetPreamble().IsEmpty();
#endif
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 32589, 32618);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 32589, 32618);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(544, 30885, 32700);

                int
                f_544_31091_31108(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.CodePage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31091, 31108);
                    return return_v;
                }


                System.Text.Encoding
                f_544_31199_31215()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31199, 31215);
                    return return_v;
                }


                bool
                f_544_31187_31216(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31187, 31216);
                    return return_v;
                }


                int
                f_544_31174_31217(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31174, 31217);
                    return 0;
                }


                System.Text.Encoding
                f_544_31264_31280()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31264, 31280);
                    return return_v;
                }


                bool
                f_544_31248_31281(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31248, 31281);
                    return return_v;
                }


                bool
                f_544_31285_31306(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31285, 31306);
                    return return_v;
                }


                System.Text.Encoding
                f_544_31457_31482()
                {
                    var return_v = Encoding.BigEndianUnicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31457, 31482);
                    return return_v;
                }


                bool
                f_544_31445_31483(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31445, 31483);
                    return return_v;
                }


                int
                f_544_31432_31484(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31432, 31484);
                    return 0;
                }


                System.Text.Encoding
                f_544_31531_31556()
                {
                    var return_v = Encoding.BigEndianUnicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31531, 31556);
                    return return_v;
                }


                bool
                f_544_31515_31557(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31515, 31557);
                    return return_v;
                }


                bool
                f_544_31561_31582(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31561, 31582);
                    return return_v;
                }


                System.Text.Encoding
                f_544_31734_31748()
                {
                    var return_v = Encoding.UTF32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31734, 31748);
                    return return_v;
                }


                bool
                f_544_31722_31749(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31722, 31749);
                    return return_v;
                }


                int
                f_544_31709_31750(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31709, 31750);
                    return 0;
                }


                System.Text.Encoding
                f_544_31797_31811()
                {
                    var return_v = Encoding.UTF32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31797, 31811);
                    return return_v;
                }


                bool
                f_544_31781_31812(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31781, 31812);
                    return return_v;
                }


                bool
                f_544_31816_31837(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31816, 31837);
                    return return_v;
                }


                System.Text.Encoding
                f_544_31985_31999()
                {
                    var return_v = Encoding.UTF32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 31985, 31999);
                    return return_v;
                }


                bool
                f_544_31973_32000(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31973, 32000);
                    return return_v;
                }


                int
                f_544_31960_32001(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 31960, 32001);
                    return 0;
                }


                System.Text.Encoding
                f_544_32048_32062()
                {
                    var return_v = Encoding.UTF32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 32048, 32062);
                    return return_v;
                }


                bool
                f_544_32032_32063(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32032, 32063);
                    return return_v;
                }


                bool
                f_544_32067_32088(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32067, 32088);
                    return return_v;
                }


                System.Text.Encoding
                f_544_32236_32249()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 32236, 32249);
                    return return_v;
                }


                bool
                f_544_32224_32250(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32224, 32250);
                    return return_v;
                }


                int
                f_544_32211_32251(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32211, 32251);
                    return 0;
                }


                System.Text.Encoding
                f_544_32298_32311()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 32298, 32311);
                    return return_v;
                }


                bool
                f_544_32282_32312(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32282, 32312);
                    return return_v;
                }


                bool
                f_544_32316_32337(System.Text.Encoding
                encoding)
                {
                    var return_v = HasPreamble(encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32316, 32337);
                    return return_v;
                }


                static bool
                f_544_32592_32618_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 32592, 32618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 30885, 32700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 30885, 32700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteObject(object instance, IObjectWritable? instanceAsWritable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 32712, 36020);
                int id = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32815, 32852);

                f_544_32815_32851(instance != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32866, 32947);

                f_544_32866_32946(instanceAsWritable == null || (DynAbs.Tracing.TraceSender.Expression_False(544, 32885, 32945) || instance == instanceAsWritable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 32963, 33013);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33095, 36009) || true) && (_objectReferenceMap.TryGetReferenceId(instance, out id
                ))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 33095, 36009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33192, 33214);

                    f_544_33192_33213(id >= 0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33232, 33793) || true) && (id <= byte.MaxValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 33232, 33793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33297, 33347);

                        f_544_33297_33346(_writer, EncodingKind.ObjectRef_1Byte);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33369, 33393);

                        f_544_33369_33392(_writer, id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 33232, 33793);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 33232, 33793);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33435, 33793) || true) && (id <= ushort.MaxValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 33435, 33793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33502, 33553);

                            f_544_33502_33552(_writer, EncodingKind.ObjectRef_2Bytes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33575, 33601);

                            f_544_33575_33600(_writer, id);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 33435, 33793);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 33435, 33793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33683, 33734);

                            f_544_33683_33733(_writer, EncodingKind.ObjectRef_4Bytes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33756, 33774);

                            f_544_33756_33773(_writer, id);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 33435, 33793);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 33232, 33793);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 33095, 36009);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 33095, 36009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33859, 33893);

                    var
                    writable = instanceAsWritable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33911, 34249) || true) && (writable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 33911, 34249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 33973, 34012);

                        writable = instance as IObjectWritable;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 34034, 34230) || true) && (writable == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 34034, 34230);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 34104, 34207);

                            throw f_544_34110_34206($"{f_544_34144_34162(instance)} must implement {nameof(IObjectWritable)}");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(544, 34034, 34230);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 33911, 34249);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 34269, 34300);

                    var
                    oldDepth = _recursionDepth
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 34318, 34336);

                    _recursionDepth++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 34356, 35896) || true) && (_recursionDepth % MaxRecursionDepth == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 34356, 35896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 34731, 35025);

                        var
                        task = f_544_34742_35024(f_544_34742_34754(), obj => WriteObjectWorker((IObjectWritable)obj!), writable, _cancellationToken, TaskCreationOptions.LongRunning, f_544_35002_35023())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 35737, 35767);

                        f_544_35737_35754(
                                            // We must not proceed until the additional task completes. After returning from a write, the underlying
                                            // stream providing access to raw memory will be closed; if this occurs before the separate thread
                                            // completes its write then an access violation can occur attempting to write to unmapped memory.
                                            //
                                            // CANCELLATION: If cancellation is required, DO NOT attempt to cancel the operation by cancelling this
                                            // wait. Cancellation must only be implemented by modifying 'task' to cancel itself in a timely manner
                                            // so the wait can complete.
                                            task).GetResult();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 34356, 35896);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 34356, 35896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 35849, 35877);

                        f_544_35849_35876(this, writable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 34356, 35896);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 35916, 35934);

                    _recursionDepth--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 35952, 35994);

                    f_544_35952_35993(_recursionDepth == oldDepth);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(544, 33095, 36009);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 32712, 36020);

                int
                f_544_32815_32851(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32815, 32851);
                    return 0;
                }


                int
                f_544_32866_32946(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 32866, 32946);
                    return 0;
                }


                int
                f_544_33192_33213(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 33192, 33213);
                    return 0;
                }


                int
                f_544_33297_33346(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 33297, 33346);
                    return 0;
                }


                int
                f_544_33369_33392(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 33369, 33392);
                    return 0;
                }


                int
                f_544_33502_33552(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 33502, 33552);
                    return 0;
                }


                int
                f_544_33575_33600(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 33575, 33600);
                    return 0;
                }


                int
                f_544_33683_33733(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 33683, 33733);
                    return 0;
                }


                int
                f_544_33756_33773(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 33756, 33773);
                    return 0;
                }


                System.Type
                f_544_34144_34162(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 34144, 34162);
                    return return_v;
                }


                System.Exception
                f_544_34110_34206(string
                typeName)
                {
                    var return_v = NoSerializationWriterException(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 34110, 34206);
                    return return_v;
                }


                System.Threading.Tasks.TaskFactory
                f_544_34742_34754()
                {
                    var return_v = Task.Factory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 34742, 34754);
                    return return_v;
                }


                System.Threading.Tasks.TaskScheduler
                f_544_35002_35023()
                {
                    var return_v = TaskScheduler.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 35002, 35023);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_544_34742_35024(System.Threading.Tasks.TaskFactory
                this_param, System.Action<object?>
                action, Roslyn.Utilities.IObjectWritable
                state, System.Threading.CancellationToken
                cancellationToken, System.Threading.Tasks.TaskCreationOptions
                creationOptions, System.Threading.Tasks.TaskScheduler
                scheduler)
                {
                    var return_v = this_param.StartNew(action, (object)state, cancellationToken, creationOptions, scheduler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 34742, 35024);
                    return return_v;
                }


                System.Runtime.CompilerServices.TaskAwaiter
                f_544_35737_35754(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.GetAwaiter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 35737, 35754);
                    return return_v;
                }


                int
                f_544_35849_35876(Roslyn.Utilities.ObjectWriter
                this_param, Roslyn.Utilities.IObjectWritable
                writable)
                {
                    this_param.WriteObjectWorker(writable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 35849, 35876);
                    return 0;
                }


                int
                f_544_35952_35993(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 35952, 35993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 32712, 36020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 32712, 36020);
            }
        }

        private void WriteObjectWorker(IObjectWritable writable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(544, 36032, 36575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 36113, 36184);

                _objectReferenceMap.Add(writable, f_544_36147_36182(writable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 36244, 36285);

                f_544_36244_36284(
                            // emit object header up front
                            _writer, EncodingKind.Object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 36464, 36527);

                f_544_36464_36526(
                            // Directly write out the type-id for this object.  i.e. no need to write out the 'Type'
                            // tag since we just wrote out the 'Object' tag
                            this, _binderSnapshot.GetTypeId(f_544_36506_36524(writable)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 36541, 36564);

                f_544_36541_36563(writable, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(544, 36032, 36575);

                bool
                f_544_36147_36182(Roslyn.Utilities.IObjectWritable
                this_param)
                {
                    var return_v = this_param.ShouldReuseInSerialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 36147, 36182);
                    return return_v;
                }


                int
                f_544_36244_36284(System.IO.BinaryWriter
                this_param, Roslyn.Utilities.ObjectWriter.EncodingKind
                value)
                {
                    this_param.Write((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36244, 36284);
                    return 0;
                }


                System.Type
                f_544_36506_36524(Roslyn.Utilities.IObjectWritable
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36506, 36524);
                    return return_v;
                }


                int
                f_544_36464_36526(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36464, 36526);
                    return 0;
                }


                int
                f_544_36541_36563(Roslyn.Utilities.IObjectWritable
                this_param, Roslyn.Utilities.ObjectWriter
                writer)
                {
                    this_param.WriteTo(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36541, 36563);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 36032, 36575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 36032, 36575);
            }
        }

        private static Exception NoSerializationTypeException(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(544, 36587, 36823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 36682, 36812);

                return f_544_36689_36811(f_544_36719_36810(f_544_36733_36799(), typeName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(544, 36587, 36823);

                string
                f_544_36733_36799()
                {
                    var return_v = Resources.The_type_0_is_not_understood_by_the_serialization_binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 36733, 36799);
                    return return_v;
                }


                string
                f_544_36719_36810(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36719, 36810);
                    return return_v;
                }


                System.InvalidOperationException
                f_544_36689_36811(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36689, 36811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 36587, 36823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 36587, 36823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Exception NoSerializationWriterException(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(544, 36835, 37040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 36932, 37029);

                return f_544_36939_37028(f_544_36969_37027(f_544_36983_37016(), typeName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(544, 36835, 37040);

                string
                f_544_36983_37016()
                {
                    var return_v = Resources.Cannot_serialize_type_0;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 36983, 37016);
                    return return_v;
                }


                string
                f_544_36969_37027(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36969, 37027);
                    return return_v;
                }


                System.InvalidOperationException
                f_544_36939_37028(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 36939, 37028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 36835, 37040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 36835, 37040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static readonly Dictionary<Type, EncodingKind> s_typeMap;

        internal static readonly ImmutableArray<Type> s_reverseTypeMap;

        static ObjectWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(544, 37539, 38719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 3298, 3320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 37357, 37366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 38858, 38881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 39019, 39034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 39173, 39193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 39332, 39352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 37585, 38460);

                s_typeMap = new Dictionary<Type, EncodingKind>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => typeof(bool),544,37597,38459),EncodingKind.BooleanType },                { typeof(char), EncodingKind.Char },                { typeof(string), EncodingKind.StringType },                { typeof(sbyte), EncodingKind.Int8 },                { typeof(short), EncodingKind.Int16 },                { typeof(int), EncodingKind.Int32 },                { typeof(long), EncodingKind.Int64 },                { typeof(byte), EncodingKind.UInt8 },                { typeof(ushort), EncodingKind.UInt16 },                { typeof(uint), EncodingKind.UInt32 },                { typeof(ulong), EncodingKind.UInt64 },                { typeof(float), EncodingKind.Float4 },                { typeof(double), EncodingKind.Float8 },                { typeof(decimal), EncodingKind.Decimal }            };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 38476, 38520);

                var
                temp = new Type[(int)EncodingKind.Last]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 38536, 38645);
                    foreach (var kvp in f_544_38556_38565_I(s_typeMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(544, 38536, 38645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 38599, 38630);

                        temp[(int)kvp.Value] = kvp.Key;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(544, 38536, 38645);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(544, 1, 110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(544, 1, 110);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(544, 38661, 38708);

                s_reverseTypeMap = f_544_38680_38707(temp);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(544, 37539, 38719);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(544, 37539, 38719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(544, 37539, 38719);
            }
        }

        internal const byte
        ByteMarkerMask = 3 << 6
        ;

        internal const byte
        Byte1Marker = 0
        ;

        internal const byte
        Byte2Marker = 1 << 6
        ;

        internal const byte
        Byte4Marker = 2 << 6
        ;

        internal enum EncodingKind : byte
        {
            /// <summary>
            /// The null value
            /// </summary>
            Null,

            /// <summary>
            /// A type
            /// </summary>
            Type,

            /// <summary>
            /// An object with member values encoded as variants
            /// </summary>
            Object,

            /// <summary>
            /// An object reference with the id encoded as 1 byte.
            /// </summary>
            ObjectRef_1Byte,

            /// <summary>
            /// An object reference with the id encode as 2 bytes.
            /// </summary>
            ObjectRef_2Bytes,

            /// <summary>
            /// An object reference with the id encoded as 4 bytes.
            /// </summary>
            ObjectRef_4Bytes,

            /// <summary>
            /// A string encoded as UTF8 (using BinaryWriter.Write(string))
            /// </summary>
            StringUtf8,

            /// <summary>
            /// A string encoded as UTF16 (as array of UInt16 values)
            /// </summary>
            StringUtf16,

            /// <summary>
            /// A reference to a string with the id encoded as 1 byte.
            /// </summary>
            StringRef_1Byte,

            /// <summary>
            /// A reference to a string with the id encoded as 2 bytes.
            /// </summary>
            StringRef_2Bytes,

            /// <summary>
            /// A reference to a string with the id encoded as 4 bytes.
            /// </summary>
            StringRef_4Bytes,

            /// <summary>
            /// The boolean value true.
            /// </summary>
            Boolean_True,

            /// <summary>
            /// The boolean value char.
            /// </summary>
            Boolean_False,

            /// <summary>
            /// A character value encoded as 2 bytes.
            /// </summary>
            Char,

            /// <summary>
            /// An Int8 value encoded as 1 byte.
            /// </summary>
            Int8,

            /// <summary>
            /// An Int16 value encoded as 2 bytes.
            /// </summary>
            Int16,

            /// <summary>
            /// An Int32 value encoded as 4 bytes.
            /// </summary>
            Int32,

            /// <summary>
            /// An Int32 value encoded as 1 byte.
            /// </summary>
            Int32_1Byte,

            /// <summary>
            /// An Int32 value encoded as 2 bytes.
            /// </summary>
            Int32_2Bytes,

            /// <summary>
            /// The Int32 value 0
            /// </summary>
            Int32_0,

            /// <summary>
            /// The Int32 value 1
            /// </summary>
            Int32_1,

            /// <summary>
            /// The Int32 value 2
            /// </summary>
            Int32_2,

            /// <summary>
            /// The Int32 value 3
            /// </summary>
            Int32_3,

            /// <summary>
            /// The Int32 value 4
            /// </summary>
            Int32_4,

            /// <summary>
            /// The Int32 value 5
            /// </summary>
            Int32_5,

            /// <summary>
            /// The Int32 value 6
            /// </summary>
            Int32_6,

            /// <summary>
            /// The Int32 value 7
            /// </summary>
            Int32_7,

            /// <summary>
            /// The Int32 value 8
            /// </summary>
            Int32_8,

            /// <summary>
            /// The Int32 value 9
            /// </summary>
            Int32_9,

            /// <summary>
            /// The Int32 value 10
            /// </summary>
            Int32_10,

            /// <summary>
            /// An Int64 value encoded as 8 bytes
            /// </summary>
            Int64,

            /// <summary>
            /// A UInt8 value encoded as 1 byte.
            /// </summary>
            UInt8,

            /// <summary>
            /// A UIn16 value encoded as 2 bytes.
            /// </summary>
            UInt16,

            /// <summary>
            /// A UInt32 value encoded as 4 bytes.
            /// </summary>
            UInt32,

            /// <summary>
            /// A UInt32 value encoded as 1 byte.
            /// </summary>
            UInt32_1Byte,

            /// <summary>
            /// A UInt32 value encoded as 2 bytes.
            /// </summary>
            UInt32_2Bytes,

            /// <summary>
            /// The UInt32 value 0
            /// </summary>
            UInt32_0,

            /// <summary>
            /// The UInt32 value 1
            /// </summary>
            UInt32_1,

            /// <summary>
            /// The UInt32 value 2
            /// </summary>
            UInt32_2,

            /// <summary>
            /// The UInt32 value 3
            /// </summary>
            UInt32_3,

            /// <summary>
            /// The UInt32 value 4
            /// </summary>
            UInt32_4,

            /// <summary>
            /// The UInt32 value 5
            /// </summary>
            UInt32_5,

            /// <summary>
            /// The UInt32 value 6
            /// </summary>
            UInt32_6,

            /// <summary>
            /// The UInt32 value 7
            /// </summary>
            UInt32_7,

            /// <summary>
            /// The UInt32 value 8
            /// </summary>
            UInt32_8,

            /// <summary>
            /// The UInt32 value 9
            /// </summary>
            UInt32_9,

            /// <summary>
            /// The UInt32 value 10
            /// </summary>
            UInt32_10,

            /// <summary>
            /// A UInt64 value encoded as 8 bytes.
            /// </summary>
            UInt64,

            /// <summary>
            /// A float value encoded as 4 bytes.
            /// </summary>
            Float4,

            /// <summary>
            /// A double value encoded as 8 bytes.
            /// </summary>
            Float8,

            /// <summary>
            /// A decimal value encoded as 12 bytes.
            /// </summary>
            Decimal,

            /// <summary>
            /// A DateTime value
            /// </summary>
            DateTime,

            /// <summary>
            /// An array with length encoded as compressed uint
            /// </summary>
            Array,

            /// <summary>
            /// An array with zero elements
            /// </summary>
            Array_0,

            /// <summary>
            /// An array with one element
            /// </summary>
            Array_1,

            /// <summary>
            /// An array with 2 elements
            /// </summary>
            Array_2,

            /// <summary>
            /// An array with 3 elements
            /// </summary>
            Array_3,

            /// <summary>
            /// The boolean type
            /// </summary>
            BooleanType,

            /// <summary>
            /// The string type
            /// </summary>
            StringType,

            /// <summary>
            /// Encoding serialized as <see cref="Encoding.WebName"/>.
            /// </summary>
            EncodingName,

            // well-known encodings (parameterized by BOM)
            EncodingUTF8,
            EncodingUTF8_BOM,
            EncodingUTF32_BE,
            EncodingUTF32_BE_BOM,
            EncodingUTF32_LE,
            EncodingUTF32_LE_BOM,
            EncodingUnicode_BE,
            EncodingUnicode_BE_BOM,
            EncodingUnicode_LE,
            EncodingUnicode_LE_BOM,

            Last,
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(544, 908, 47462);

        static int
        f_544_4060_4101(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4060, 4101);
            return 0;
        }


        static System.Text.Encoding
        f_544_4153_4166()
        {
            var return_v = Encoding.UTF8;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(544, 4153, 4166);
            return return_v;
        }


        static System.IO.BinaryWriter
        f_544_4128_4178(System.IO.Stream
        output, System.Text.Encoding
        encoding, bool
        leaveOpen)
        {
            var return_v = new System.IO.BinaryWriter(output, encoding, leaveOpen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4128, 4178);
            return return_v;
        }


        static Roslyn.Utilities.ObjectWriter.WriterReferenceMap
        f_544_4215_4259(bool
        valueEquality)
        {
            var return_v = new Roslyn.Utilities.ObjectWriter.WriterReferenceMap(valueEquality: valueEquality);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4215, 4259);
            return return_v;
        }


        static Roslyn.Utilities.ObjectWriter.WriterReferenceMap
        f_544_4296_4339(bool
        valueEquality)
        {
            var return_v = new Roslyn.Utilities.ObjectWriter.WriterReferenceMap(valueEquality: valueEquality);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4296, 4339);
            return return_v;
        }


        static Roslyn.Utilities.ObjectBinderSnapshot
        f_544_4589_4615()
        {
            var return_v = ObjectBinder.GetSnapshot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4589, 4615);
            return return_v;
        }


        static int
        f_544_4632_4646(Roslyn.Utilities.ObjectWriter
        this_param)
        {
            this_param.WriteVersion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 4632, 4646);
            return 0;
        }


        static System.Collections.Generic.Dictionary<System.Type, Roslyn.Utilities.ObjectWriter.EncodingKind>
        f_544_38556_38565_I(System.Collections.Generic.Dictionary<System.Type, Roslyn.Utilities.ObjectWriter.EncodingKind>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 38556, 38565);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<System.Type>
        f_544_38680_38707(params System.Type[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(544, 38680, 38707);
            return return_v;
        }

    }
}
