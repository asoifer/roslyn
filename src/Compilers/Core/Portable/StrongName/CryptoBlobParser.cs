// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Collections;
using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Microsoft.CodeAnalysis
{
    internal static class CryptoBlobParser
    {
        private enum AlgorithmClass
        {
            Signature = 1,
            Hash = 4,
        }

        private enum AlgorithmSubId
        {
            Sha1Hash = 4,
            MacHash = 5,
            RipeMdHash = 6,
            RipeMd160Hash = 7,
            Ssl3ShaMD5Hash = 8,
            HmacHash = 9,
            Tls1PrfHash = 10,
            HashReplacOwfHash = 11,
            Sha256Hash = 12,
            Sha384Hash = 13,
            Sha512Hash = 14,
        }

        private struct AlgorithmId
        {

            private const int
            AlgorithmClassOffset = 13
            ;

            private const int
            AlgorithmClassMask = 0x7
            ;

            private const int
            AlgorithmSubIdOffset = 0
            ;

            private const int
            AlgorithmSubIdMask = 0x1ff
            ;

            private readonly uint _flags;

            public const int
            RsaSign = 0x00002400
            ;

            public const int
            Sha = 0x00008004
            ;

            public bool IsSet
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(560, 1575, 1602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1581, 1600);

                        return _flags != 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(560, 1575, 1602);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 1525, 1617);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 1525, 1617);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public AlgorithmClass Class
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(560, 1693, 1780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1699, 1778);

                        return (AlgorithmClass)((_flags >> AlgorithmClassOffset) & AlgorithmClassMask);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(560, 1693, 1780);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 1633, 1795);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 1633, 1795);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public AlgorithmSubId SubId
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(560, 1871, 1958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1877, 1956);

                        return (AlgorithmSubId)((_flags >> AlgorithmSubIdOffset) & AlgorithmSubIdMask);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(560, 1871, 1958);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 1811, 1973);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 1811, 1973);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public AlgorithmId(uint flags)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(560, 1989, 2082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 2052, 2067);

                    _flags = flags;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(560, 1989, 2082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 1989, 2082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 1989, 2082);
                }
            }
            static AlgorithmId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(560, 1062, 2093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1163, 1188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1221, 1245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1278, 1302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1335, 1361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1440, 1460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 1492, 1508);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(560, 1062, 2093);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 1062, 2093);
            }
        }

        private static readonly ImmutableArray<byte> s_ecmaKey;

        private const int
        SnPublicKeyBlobSize = 13
        ;

        private const byte
        PublicKeyBlobId = 0x06
        ;

        private const byte
        PrivateKeyBlobId = 0x07
        ;

        internal const int
        s_publicKeyHeaderSize = SnPublicKeyBlobSize - 1
        ;

        internal static bool IsValidPublicKey(ImmutableArray<byte> blob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(560, 2747, 4769);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 2950, 3073) || true) && (blob.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(560, 2954, 3011) || blob.Length < s_publicKeyHeaderSize + 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 2950, 3073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3045, 3058);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 2950, 3073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3089, 3144);

                var
                blobReader = f_560_3106_3143(blob.AsSpan())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3199, 3238);

                var
                sigAlgId = blobReader.ReadUInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3286, 3326);

                var
                hashAlgId = blobReader.ReadUInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3415, 3459);

                var
                publicKeySize = blobReader.ReadUInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3528, 3566);

                var
                publicKey = blobReader.ReadByte()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3710, 3828) || true) && (blob.Length != s_publicKeyHeaderSize + publicKeySize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 3710, 3828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3800, 3813);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 3710, 3828);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 3934, 4043) || true) && (f_560_3938_3982(blob, s_ecmaKey))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 3934, 4043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4016, 4028);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 3934, 4043);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4136, 4230) || true) && (publicKey != PublicKeyBlobId)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 4136, 4230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4202, 4215);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 4136, 4230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4246, 4299);

                var
                signatureAlgorithmId = f_560_4273_4298(sigAlgId)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4313, 4463) || true) && (signatureAlgorithmId.IsSet && (DynAbs.Tracing.TraceSender.Expression_True(560, 4317, 4401) && signatureAlgorithmId.Class != AlgorithmClass.Signature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 4313, 4463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4435, 4448);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 4313, 4463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4479, 4528);

                var
                hashAlgorithmId = f_560_4501_4527(hashAlgId)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4542, 4730) || true) && (hashAlgorithmId.IsSet && (DynAbs.Tracing.TraceSender.Expression_True(560, 4546, 4668) && (hashAlgorithmId.Class != AlgorithmClass.Hash || (DynAbs.Tracing.TraceSender.Expression_False(560, 4572, 4667) || hashAlgorithmId.SubId < AlgorithmSubId.Sha1Hash))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 4542, 4730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4702, 4715);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 4542, 4730);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4746, 4758);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(560, 2747, 4769);

                Microsoft.CodeAnalysis.LittleEndianReader
                f_560_3106_3143(System.ReadOnlySpan<byte>
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.LittleEndianReader(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 3106, 3143);
                    return return_v;
                }


                bool
                f_560_3938_3982(System.Collections.Immutable.ImmutableArray<byte>
                x, System.Collections.Immutable.ImmutableArray<byte>
                y)
                {
                    var return_v = ByteSequenceComparer.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 3938, 3982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CryptoBlobParser.AlgorithmId
                f_560_4273_4298(uint
                flags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CryptoBlobParser.AlgorithmId(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 4273, 4298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CryptoBlobParser.AlgorithmId
                f_560_4501_4527(uint
                flags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CryptoBlobParser.AlgorithmId(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 4501, 4527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 2747, 4769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 2747, 4769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        BlobHeaderSize = sizeof(byte) + sizeof(byte) + sizeof(ushort) + sizeof(uint)
        ;

        private const int
        RsaPubKeySize = sizeof(uint) + sizeof(uint) + sizeof(uint)
        ;

        private const UInt32
        RSA1 = 0x31415352
        ;

        private const UInt32
        RSA2 = 0x32415352
        ;

        private const int
        s_offsetToKeyData = BlobHeaderSize + RsaPubKeySize
        ;

        private static ImmutableArray<byte> CreateSnPublicKeyBlob(
                    byte type,
                    byte version,
                    uint algId,
                    uint magic,
                    uint bitLen,
                    uint pubExp,
                    ReadOnlySpan<byte> pubKeyData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(560, 5300, 6420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5580, 5661);

                var
                w = f_560_5588_5660(3 * sizeof(uint) + s_offsetToKeyData + pubKeyData.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5675, 5710);

                w.WriteUInt32(AlgorithmId.RsaSign);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5724, 5755);

                w.WriteUInt32(AlgorithmId.Sha);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5769, 5830);

                w.WriteUInt32((uint)(s_offsetToKeyData + pubKeyData.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5846, 5864);

                w.WriteByte(type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5878, 5899);

                w.WriteByte(version);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5913, 5974);

                w.WriteUInt16(0 /* 16 bits of reserved space in the spec */);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5988, 6009);

                w.WriteUInt32(algId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6025, 6046);

                w.WriteUInt32(magic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6060, 6082);

                w.WriteUInt32(bitLen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6142, 6164);

                w.WriteUInt32(pubExp);

                unsafe
                {
                    fixed (byte*
    bytes = pubKeyData
    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6292, 6331);

                        w.WriteBytes(bytes, pubKeyData.Length);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6381, 6409);

                return w.ToImmutableArray();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(560, 5300, 6420);

                System.Reflection.Metadata.BlobWriter
                f_560_5588_5660(int
                size)
                {
                    var return_v = new System.Reflection.Metadata.BlobWriter(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 5588, 5660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 5300, 6420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 5300, 6420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryParseKey(ImmutableArray<byte> blob, out ImmutableArray<byte> snKey, out RSAParameters? privateKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(560, 6682, 9019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6827, 6845);

                privateKey = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6859, 6897);

                snKey = default(ImmutableArray<byte>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6913, 7031) || true) && (f_560_6917_6939(blob))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 6913, 7031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 6973, 6986);

                    snKey = blob;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7004, 7016);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 6913, 7031);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7047, 7157) || true) && (blob.Length < BlobHeaderSize + RsaPubKeySize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 7047, 7157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7129, 7142);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 7047, 7157);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7209, 7256);

                    var
                    br = f_560_7218_7255(blob.AsSpan())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7276, 7303);

                    byte
                    bType = br.ReadByte()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7459, 7489);

                    byte
                    bVersion = br.ReadByte()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7604, 7620);

                    br.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7676, 7705);

                    uint
                    algId = br.ReadUInt32()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7747, 7776);

                    uint
                    magic = br.ReadUInt32()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7874, 7903);

                    var
                    bitLen = br.ReadUInt32()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 7948, 7977);

                    var
                    pubExp = br.ReadUInt32()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8009, 8047);

                    var
                    modulusLength = (int)(bitLen / 8)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8067, 8192) || true) && (blob.Length - s_offsetToKeyData < modulusLength)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 8067, 8192);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8160, 8173);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(560, 8067, 8192);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8212, 8254);

                    var
                    modulus = br.ReadBytes(modulusLength)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8274, 8445) || true) && (!(bType == PrivateKeyBlobId && (DynAbs.Tracing.TraceSender.Expression_True(560, 8280, 8322) && magic == RSA2)) && (DynAbs.Tracing.TraceSender.Expression_True(560, 8278, 8371) && !(bType == PublicKeyBlobId && (DynAbs.Tracing.TraceSender.Expression_True(560, 8329, 8370) && magic == RSA1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 8274, 8445);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8413, 8426);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(560, 8274, 8445);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8465, 8756) || true) && (bType == PrivateKeyBlobId)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 8465, 8756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8536, 8586);

                        privateKey = ToRSAParameters(blob.AsSpan(), true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8674, 8702);

                        algId = AlgorithmId.RsaSign;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8724, 8737);

                        magic = RSA1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(560, 8465, 8756);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8776, 8871);

                    snKey = f_560_8784_8870(PublicKeyBlobId, bVersion, algId, RSA1, bitLen, pubExp, modulus);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8889, 8901);

                    return true;
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(560, 8930, 9008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 8980, 8993);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(560, 8930, 9008);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(560, 6682, 9019);

                bool
                f_560_6917_6939(System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = IsValidPublicKey(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 6917, 6939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LittleEndianReader
                f_560_7218_7255(System.ReadOnlySpan<byte>
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.LittleEndianReader(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 7218, 7255);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_560_8784_8870(byte
                type, byte
                version, uint
                algId, uint
                magic, uint
                bitLen, uint
                pubExp, System.ReadOnlySpan<byte>
                pubKeyData)
                {
                    var return_v = CreateSnPublicKeyBlob(type, version, algId, magic, bitLen, pubExp, pubKeyData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 8784, 8870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 6682, 9019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 6682, 9019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RSAParameters ToRSAParameters(this ReadOnlySpan<byte> cspBlob, bool includePrivateParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(560, 9341, 11075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 9475, 9516);

                var
                br = f_560_9484_9515(cspBlob)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 9532, 9559);

                byte
                bType = br.ReadByte()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 9711, 9741);

                byte
                bVersion = br.ReadByte()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 9852, 9868);

                br.ReadUInt16();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 9920, 9947);

                int
                algId = br.ReadInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 9989, 10016);

                int
                magic = br.ReadInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10112, 10140);

                int
                bitLen = br.ReadInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10178, 10209);

                int
                modulusLength = bitLen / 8
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10223, 10271);

                int
                halfModulusLength = (modulusLength + 1) / 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10287, 10321);

                uint
                expAsDword = br.ReadUInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10337, 10387);

                RSAParameters
                rsaParameters = f_560_10367_10386()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10401, 10454);

                rsaParameters.Exponent = f_560_10426_10453(expAsDword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10468, 10523);

                rsaParameters.Modulus = br.ReadReversed(modulusLength);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10537, 11027) || true) && (includePrivateParameters)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 10537, 11027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10599, 10652);

                    rsaParameters.P = br.ReadReversed(halfModulusLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10670, 10723);

                    rsaParameters.Q = br.ReadReversed(halfModulusLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10741, 10795);

                    rsaParameters.DP = br.ReadReversed(halfModulusLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10813, 10867);

                    rsaParameters.DQ = br.ReadReversed(halfModulusLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10885, 10945);

                    rsaParameters.InverseQ = br.ReadReversed(halfModulusLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 10963, 11012);

                    rsaParameters.D = br.ReadReversed(modulusLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 10537, 11027);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 11043, 11064);

                return rsaParameters;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(560, 9341, 11075);

                Microsoft.CodeAnalysis.LittleEndianReader
                f_560_9484_9515(System.ReadOnlySpan<byte>
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.LittleEndianReader(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 9484, 9515);
                    return return_v;
                }


                System.Security.Cryptography.RSAParameters
                f_560_10367_10386()
                {
                    var return_v = new System.Security.Cryptography.RSAParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 10367, 10386);
                    return return_v;
                }


                byte[]
                f_560_10426_10453(uint
                exponent)
                {
                    var return_v = ExponentAsBytes(exponent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 10426, 10453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 9341, 11075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 9341, 11075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static byte[] ExponentAsBytes(uint exponent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(560, 11392, 12537);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 11469, 12526) || true) && (exponent <= 0xFF)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 11469, 12526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 11523, 11555);

                    return new[] { (byte)exponent };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 11469, 12526);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 11469, 12526);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 11589, 12526) || true) && (exponent <= 0xFFFF)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 11589, 12526);
                        unchecked
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 11695, 11844);

                            return new[]
                                                {
                        (byte)(exponent >> 8),
                        (byte)(exponent)
                    };
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(560, 11589, 12526);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 11589, 12526);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 11897, 12526) || true) && (exponent <= 0xFFFFFF)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 11897, 12526);
                            unchecked
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 12005, 12203);

                                return new[]
                                                    {
                        (byte)(exponent >> 16),
                        (byte)(exponent >> 8),
                        (byte)(exponent)
                    };
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(560, 11897, 12526);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(560, 11897, 12526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 12288, 12511);

                            return new[]
                                            {
                    (byte)(exponent >> 24),
                    (byte)(exponent >> 16),
                    (byte)(exponent >> 8),
                    (byte)(exponent)
                };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(560, 11897, 12526);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(560, 11589, 12526);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(560, 11469, 12526);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(560, 11392, 12537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 11392, 12537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 11392, 12537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static byte[] ReadReversed(this BinaryReader br, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(560, 12845, 13042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 12937, 12971);

                byte[]
                data = f_560_12951_12970(br, count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 12985, 13005);

                f_560_12985_13004(data);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 13019, 13031);

                return data;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(560, 12845, 13042);

                byte[]
                f_560_12951_12970(System.IO.BinaryReader
                this_param, int
                count)
                {
                    var return_v = this_param.ReadBytes(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 12951, 12970);
                    return return_v;
                }


                int
                f_560_12985_13004(byte[]
                array)
                {
                    Array.Reverse(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 12985, 13004);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(560, 12845, 13042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 12845, 13042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CryptoBlobParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(560, 502, 13049);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 2177, 2273);
            s_ecmaKey = f_560_2189_2273(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0 }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 2304, 2328);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 2388, 2410);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 2440, 2463);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 2528, 2575);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4799, 4875);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4906, 4964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 4998, 5015);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5047, 5064);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(560, 5237, 5287);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(560, 502, 13049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(560, 502, 13049);
        }


        static System.Collections.Immutable.ImmutableArray<byte>
        f_560_2189_2273(params byte[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(560, 2189, 2273);
            return return_v;
        }

    }
}
