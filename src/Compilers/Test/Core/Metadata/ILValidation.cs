// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.Cci;
using Microsoft.CodeAnalysis;
using Microsoft.Metadata.Tools;

namespace Roslyn.Test.Utilities
{
    public static class ILValidation
    {
        private const int
        ChecksumOffset = 0x40
        ;

        public static bool IsStreamFullSigned(Stream moduleContents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 1017, 4817);
                int snOffset = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1102, 1146);

                var
                savedPosition = f_25106_1122_1145(moduleContents)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1198, 1226);

                    moduleContents.Position = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1246, 1292);

                    var
                    peHeaders = f_25106_1262_1291(moduleContents)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1312, 1340);

                    moduleContents.Position = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1360, 4682);
                    using (var
                    metadata = f_25106_1382_1446(moduleContents, leaveOpen: true)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1488, 1533);

                        var
                        metadataReader = f_25106_1509_1532(metadata)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1555, 1598);

                        var
                        peReader = f_25106_1570_1597(f_25106_1570_1585(metadata))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1620, 1658);

                        var
                        flags = f_25106_1632_1657(f_25106_1632_1651(peHeaders))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1682, 1836) || true) && (CorFlags.StrongNameSigned != (flags & CorFlags.StrongNameSigned))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 1682, 1836);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1800, 1813);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 1682, 1836);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1860, 1936);

                        var
                        snDirectory = f_25106_1878_1935(f_25106_1878_1906(f_25106_1878_1896(peReader)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 1958, 2111) || true) && (!f_25106_1963_2025(peHeaders, snDirectory, out snOffset))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 1958, 2111);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2075, 2088);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 1958, 2111);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2135, 2163);

                        moduleContents.Position = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2185, 2196);

                        int
                        peSize
                        = default(int);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2270, 2315);

                            peSize = checked((int)f_25106_2292_2313(moduleContents));
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(25106, 2360, 2450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2414, 2427);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(25106, 2360, 2450);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2474, 2512);

                        var
                        peImage = f_25106_2488_2511(peSize)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2534, 2679) || true) && (peSize != f_25106_2548_2593(peImage, moduleContents, peSize))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 2534, 2679);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2643, 2656);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 2534, 2679);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2703, 2762);

                        // LAFHIS
                        var temp = f_25106_2733_2751(peImage);
                        byte[]
                        buffer = f_25106_2719_2761(f_25106_2733_2760(ref temp))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2786, 2838);

                        uint
                        expectedChecksum = f_25106_2810_2837(f_25106_2810_2828(peHeaders))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2860, 2959);

                        Blob
                        checksumBlob = f_25106_2880_2958(buffer, f_25106_2897_2926(peHeaders) + ChecksumOffset, sizeof(uint))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 2983, 3142) || true) && (expectedChecksum != f_25106_3007_3056(peImage, checksumBlob))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 2983, 3142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3106, 3119);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 2983, 3142);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3166, 3196);

                        int
                        snSize = snDirectory.Size
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3218, 3303);

                        byte[]
                        hash = f_25106_3232_3302(peImage, peHeaders, checksumBlob, snOffset, snSize)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3327, 3444);

                        ImmutableArray<byte>
                        publicKeyBlob = f_25106_3364_3443(metadataReader, f_25106_3394_3432(metadataReader).PublicKey)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3539, 3636);

                        byte[]
                        publicKeyParams = new byte[publicKeyBlob.Length - CryptoBlobParser.s_publicKeyHeaderSize]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3658, 3763);

                        publicKeyBlob.CopyTo(CryptoBlobParser.s_publicKeyHeaderSize, publicKeyParams, 0, f_25106_3739_3761(publicKeyParams));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3785, 3889);

                        var
                        snKey = CryptoBlobParser.ToRSAParameters(f_25106_3830_3854(publicKeyParams), includePrivateParameters: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3913, 4627);
                        using (var
                        rsa = f_25106_3930_3942()
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 3992, 4020);

                            f_25106_3992_4019(rsa, snKey);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 4046, 4162);

                            var
                            reversedSignature = f_25106_4070_4129(peReader, snDirectory.RelativeVirtualAddress).GetContent(0, snSize).ToArray()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 4350, 4383);

                            f_25106_4350_4382(reversedSignature);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 4411, 4604) || true) && (!f_25106_4416_4506(rsa, hash, reversedSignature, HashAlgorithmName.SHA1, f_25106_4480_4505()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 4411, 4604);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 4564, 4577);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 4411, 4604);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(25106, 3913, 4627);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 4651, 4663);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitUsing(25106, 1360, 4682);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(25106, 4711, 4806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 4751, 4791);

                    moduleContents.Position = savedPosition;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(25106, 4711, 4806);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 1017, 4817);

                long
                f_25106_1122_1145(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1122, 1145);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_25106_1262_1291(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEHeaders(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 1262, 1291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_25106_1382_1446(System.IO.Stream
                peStream, bool
                leaveOpen)
                {
                    var return_v = ModuleMetadata.CreateFromStream(peStream, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 1382, 1446);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_25106_1509_1532(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1509, 1532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_25106_1570_1585(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1570, 1585);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_25106_1570_1597(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.PEReaderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1570, 1597);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorHeader?
                f_25106_1632_1651(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CorHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1632, 1651);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorFlags
                f_25106_1632_1657(System.Reflection.PortableExecutable.CorHeader?
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1632, 1657);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_25106_1878_1896(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.PEHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1878, 1896);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorHeader?
                f_25106_1878_1906(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CorHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1878, 1906);
                    return return_v;
                }


                System.Reflection.PortableExecutable.DirectoryEntry
                f_25106_1878_1935(System.Reflection.PortableExecutable.CorHeader?
                this_param)
                {
                    var return_v = this_param.StrongNameSignatureDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 1878, 1935);
                    return return_v;
                }


                bool
                f_25106_1963_2025(System.Reflection.PortableExecutable.PEHeaders
                this_param, System.Reflection.PortableExecutable.DirectoryEntry
                directory, out int
                offset)
                {
                    var return_v = this_param.TryGetDirectoryOffset(directory, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 1963, 2025);
                    return return_v;
                }


                long
                f_25106_2292_2313(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 2292, 2313);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_25106_2488_2511(int
                capacity)
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 2488, 2511);
                    return return_v;
                }


                int
                f_25106_2548_2593(System.Reflection.Metadata.BlobBuilder
                this_param, System.IO.Stream
                source, int
                byteCount)
                {
                    var return_v = this_param.TryWriteBytes(source, byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 2548, 2593);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder.Blobs
                f_25106_2733_2751(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.GetBlobs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 2733, 2751);
                    return return_v;
                }


                System.Reflection.Metadata.Blob
                f_25106_2733_2760(ref System.Reflection.Metadata.BlobBuilder.Blobs
                source)
                {
                    var return_v = source.Single<System.Reflection.Metadata.Blob>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 2733, 2760);
                    return return_v;
                }


                byte[]
                f_25106_2719_2761(System.Reflection.Metadata.Blob
                blob)
                {
                    var return_v = GetBlobBuffer(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 2719, 2761);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeader?
                f_25106_2810_2828(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 2810, 2828);
                    return return_v;
                }


                uint
                f_25106_2810_2837(System.Reflection.PortableExecutable.PEHeader?
                this_param)
                {
                    var return_v = this_param.CheckSum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 2810, 2837);
                    return return_v;
                }


                int
                f_25106_2897_2926(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeaderStartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 2897, 2926);
                    return return_v;
                }


                System.Reflection.Metadata.Blob
                f_25106_2880_2958(byte[]
                buffer, int
                offset, int
                size)
                {
                    var return_v = MakeBlob(buffer, offset, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 2880, 2958);
                    return return_v;
                }


                uint
                f_25106_3007_3056(System.Reflection.Metadata.BlobBuilder
                peBlob, System.Reflection.Metadata.Blob
                checksumBlob)
                {
                    var return_v = PeWriter.CalculateChecksum(peBlob, checksumBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 3007, 3056);
                    return return_v;
                }


                byte[]
                f_25106_3232_3302(System.Reflection.Metadata.BlobBuilder
                peImage, System.Reflection.PortableExecutable.PEHeaders
                peHeaders, System.Reflection.Metadata.Blob
                checksumBlob, int
                strongNameOffset, int
                strongNameSize)
                {
                    var return_v = ComputeSigningHash(peImage, peHeaders, checksumBlob, strongNameOffset, strongNameSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 3232, 3302);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyDefinition
                f_25106_3394_3432(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.GetAssemblyDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 3394, 3432);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25106_3364_3443(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobContent(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 3364, 3443);
                    return return_v;
                }


                int
                f_25106_3739_3761(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 3739, 3761);
                    return return_v;
                }


                System.Span<byte>
                f_25106_3830_3854(byte[]
                array)
                {
                    var return_v = array.AsSpan<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 3830, 3854);
                    return return_v;
                }


                System.Security.Cryptography.RSA
                f_25106_3930_3942()
                {
                    var return_v = RSA.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 3930, 3942);
                    return return_v;
                }


                int
                f_25106_3992_4019(System.Security.Cryptography.RSA
                this_param, System.Security.Cryptography.RSAParameters
                parameters)
                {
                    this_param.ImportParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 3992, 4019);
                    return 0;
                }


                System.Reflection.PortableExecutable.PEMemoryBlock
                f_25106_4070_4129(System.Reflection.PortableExecutable.PEReader
                this_param, int
                relativeVirtualAddress)
                {
                    var return_v = this_param.GetSectionData(relativeVirtualAddress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 4070, 4129);
                    return return_v;
                }


                int
                f_25106_4350_4382(byte[]
                array)
                {
                    Array.Reverse(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 4350, 4382);
                    return 0;
                }


                System.Security.Cryptography.RSASignaturePadding
                f_25106_4480_4505()
                {
                    var return_v = RSASignaturePadding.Pkcs1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 4480, 4505);
                    return return_v;
                }


                bool
                f_25106_4416_4506(System.Security.Cryptography.RSA
                this_param, byte[]
                hash, byte[]
                signature, System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm, System.Security.Cryptography.RSASignaturePadding
                padding)
                {
                    var return_v = this_param.VerifyHash(hash, signature, hashAlgorithm, padding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 4416, 4506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 1017, 4817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 1017, 4817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static byte[] ComputeSigningHash(
                    BlobBuilder peImage,
                    PEHeaders peHeaders,
                    Blob checksumBlob,
                    int strongNameOffset,
                    int strongNameSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 4829, 7314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5063, 5096);

                const int
                SectionHeaderSize = 40
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5112, 5168);

                bool
                is32bit = f_25106_5127_5151(f_25106_5127_5145(peHeaders)) == PEMagic.PE32
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5182, 5344);

                int
                peHeadersSize = f_25106_5202_5231(peHeaders) + f_25106_5251_5272(is32bit) + SectionHeaderSize * peHeaders.SectionHeaders.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5452, 5496);

                f_25106_5452_5480(checksumBlob).WriteUInt32(0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5510, 5568);

                // LAFHIS
                var temp = f_25106_5523_5541(peImage);
                var
                buffer = f_25106_5523_5550(ref temp).GetBytes().Array
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5582, 5649);

                int
                authenticodeOffset = f_25106_5607_5648(peHeaders, is32bit)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5663, 5730);

                var
                authenticodeDir = f_25106_5685_5729(f_25106_5685_5703(peHeaders))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5753, 5758);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5744, 5868) || true) && (i < 2 * sizeof(int))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5781, 5784)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 5744, 5868))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 5744, 5868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5818, 5853);

                        buffer[authenticodeOffset + i] = 0;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 5884, 7303);
                using (var
                hash = f_25106_5902_5952(HashAlgorithmName.SHA1)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 6047, 6089);

                    f_25106_6047_6088(                // First hash the DOS header and PE headers
                                    hash, buffer, 0, peHeadersSize);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 6193, 7238);
                        foreach (var sectionHeader in f_25106_6223_6247_I(f_25106_6223_6247(peHeaders)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 6193, 7238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 6289, 6340);

                            int
                            sectionOffset = sectionHeader.PointerToRawData
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 6362, 6408);

                            int
                            sectionSize = sectionHeader.SizeOfRawData
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 6432, 7219) || true) && ((strongNameOffset + strongNameSize) < sectionOffset || (DynAbs.Tracing.TraceSender.Expression_False(25106, 6436, 6565) || strongNameOffset >= (sectionOffset + sectionSize)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 6432, 7219);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 6688, 6740);

                                f_25106_6688_6739(                        // No signature overlap, hash the whole section
                                                        hash, buffer, sectionOffset, sectionSize);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 6432, 7219);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 6432, 7219);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 6913, 6986);

                                f_25106_6913_6985(                        // There is overlap. Hash both sides of signature
                                                        hash, buffer, sectionOffset, strongNameOffset - sectionOffset);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 7012, 7072);

                                var
                                strongNameEndOffset = strongNameOffset + strongNameSize
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 7098, 7196);

                                f_25106_7098_7195(hash, buffer, strongNameEndOffset, sectionSize - (strongNameEndOffset - sectionOffset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 6432, 7219);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 6193, 7238);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 1046);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 1046);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 7258, 7288);

                    return f_25106_7265_7287(hash);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25106, 5884, 7303);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 4829, 7314);

                System.Reflection.PortableExecutable.PEHeader?
                f_25106_5127_5145(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 5127, 5145);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEMagic
                f_25106_5127_5151(System.Reflection.PortableExecutable.PEHeader?
                this_param)
                {
                    var return_v = this_param.Magic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 5127, 5151);
                    return return_v;
                }


                int
                f_25106_5202_5231(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeaderStartOffset
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 5202, 5231);
                    return return_v;
                }


                int
                f_25106_5251_5272(bool
                is32Bit)
                {
                    var return_v = PEHeaderSize(is32Bit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 5251, 5272);
                    return return_v;
                }


                System.Reflection.Metadata.BlobWriter
                f_25106_5452_5480(System.Reflection.Metadata.Blob
                blob)
                {
                    var return_v = new System.Reflection.Metadata.BlobWriter(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 5452, 5480);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder.Blobs
                f_25106_5523_5541(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.GetBlobs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 5523, 5541);
                    return return_v;
                }


                System.Reflection.Metadata.Blob
                f_25106_5523_5550(ref System.Reflection.Metadata.BlobBuilder.Blobs
                source)
                {
                    var return_v = source.Single<System.Reflection.Metadata.Blob>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 5523, 5550);
                    return return_v;
                }


                int
                f_25106_5607_5648(System.Reflection.PortableExecutable.PEHeaders
                peHeaders, bool
                is32bit)
                {
                    var return_v = GetAuthenticodeOffset(peHeaders, is32bit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 5607, 5648);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeader
                f_25106_5685_5703(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 5685, 5703);
                    return return_v;
                }


                System.Reflection.PortableExecutable.DirectoryEntry
                f_25106_5685_5729(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.CertificateTableDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 5685, 5729);
                    return return_v;
                }


                System.Security.Cryptography.IncrementalHash
                f_25106_5902_5952(System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm)
                {
                    var return_v = IncrementalHash.CreateHash(hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 5902, 5952);
                    return return_v;
                }


                int
                f_25106_6047_6088(System.Security.Cryptography.IncrementalHash
                this_param, byte[]?
                data, int
                offset, int
                count)
                {
                    this_param.AppendData(data, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 6047, 6088);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_25106_6223_6247(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.SectionHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 6223, 6247);
                    return return_v;
                }


                int
                f_25106_6688_6739(System.Security.Cryptography.IncrementalHash
                this_param, byte[]?
                data, int
                offset, int
                count)
                {
                    this_param.AppendData(data, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 6688, 6739);
                    return 0;
                }


                int
                f_25106_6913_6985(System.Security.Cryptography.IncrementalHash
                this_param, byte[]?
                data, int
                offset, int
                count)
                {
                    this_param.AppendData(data, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 6913, 6985);
                    return 0;
                }


                int
                f_25106_7098_7195(System.Security.Cryptography.IncrementalHash
                this_param, byte[]?
                data, int
                offset, int
                count)
                {
                    this_param.AppendData(data, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 7098, 7195);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_25106_6223_6247_I(System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 6223, 6247);
                    return return_v;
                }


                byte[]
                f_25106_7265_7287(System.Security.Cryptography.IncrementalHash
                this_param)
                {
                    var return_v = this_param.GetHashAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 7265, 7287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 4829, 7314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 4829, 7314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetAuthenticodeOffset(PEHeaders peHeaders, bool is32bit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 7326, 8156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 7426, 8077);

                return f_25106_7433_7462(peHeaders) + ChecksumOffset
                                + sizeof(int)                                  // Checksum
                                + sizeof(short)                                // Subsystem
                                + sizeof(short)                                // DllCharacteristics
                                + 4 * ((DynAbs.Tracing.TraceSender.Conditional_F1(25106, 7760, 7767) || ((is32bit && DynAbs.Tracing.TraceSender.Conditional_F2(25106, 7770, 7781)) || DynAbs.Tracing.TraceSender.Conditional_F3(25106, 7784, 7796))) ? sizeof(int) : sizeof(long)) + // SizeOfStackReserve, SizeOfStackCommit, SizeOfHeapReserve, SizeOfHeapCommit
                                +sizeof(int) +                                // LoaderFlags
                                +sizeof(int) +                                // NumberOfRvaAndSizes
                                +4 * sizeof(long);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 7326, 8156);

                int
                f_25106_7433_7462(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeaderStartOffset
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 7433, 7462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 7326, 8156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 7326, 8156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodInfo s_peheaderSizeMethod;

        private static int PEHeaderSize(bool is32Bit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 8225, 8732);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 8295, 8633) || true) && (s_peheaderSizeMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 8295, 8633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 8361, 8618);

                    f_25106_8361_8617(ref s_peheaderSizeMethod, f_25106_8458_8589(typeof(PEHeader), "Size", BindingFlags.Static | BindingFlags.NonPublic), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 8295, 8633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 8649, 8721);

                return (int)f_25106_8661_8720(s_peheaderSizeMethod, null, new object[] { is32Bit });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 8225, 8732);

                System.Reflection.MethodInfo?
                f_25106_8458_8589(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 8458, 8589);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_25106_8361_8617(ref System.Reflection.MethodInfo?
                location1, System.Reflection.MethodInfo?
                value, System.Reflection.MethodInfo?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 8361, 8617);
                    return return_v;
                }


                object?
                f_25106_8661_8720(System.Reflection.MethodInfo?
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 8661, 8720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 8225, 8732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 8225, 8732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ConstructorInfo s_blobCtor;

        private static Blob MakeBlob(byte[] buffer, int offset, int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 8796, 9281);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 8886, 9184) || true) && (s_blobCtor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 8886, 9184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 8942, 9169);

                    f_25106_8942_9168(ref s_blobCtor, f_25106_9029_9140(f_25106_9029_9131(typeof(Blob), BindingFlags.NonPublic | BindingFlags.Instance)), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 8886, 9184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 9200, 9270);

                return (Blob)f_25106_9213_9269(s_blobCtor, new object[] { buffer, offset, size });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 8796, 9281);

                System.Reflection.ConstructorInfo[]
                f_25106_9029_9131(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetConstructors(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 9029, 9131);
                    return return_v;
                }


                System.Reflection.ConstructorInfo
                f_25106_9029_9140(System.Reflection.ConstructorInfo[]
                source)
                {
                    var return_v = source.Single<System.Reflection.ConstructorInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 9029, 9140);
                    return return_v;
                }


                System.Reflection.ConstructorInfo?
                f_25106_8942_9168(ref System.Reflection.ConstructorInfo?
                location1, System.Reflection.ConstructorInfo
                value, System.Reflection.ConstructorInfo?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 8942, 9168);
                    return return_v;
                }


                object
                f_25106_9213_9269(System.Reflection.ConstructorInfo
                this_param, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 9213, 9269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 8796, 9281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 8796, 9281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FieldInfo s_bufferField;

        private static byte[] GetBlobBuffer(Blob blob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 9342, 9807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 9413, 9736) || true) && (s_bufferField == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 9413, 9736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 9472, 9721);

                    f_25106_9472_9720(ref s_bufferField, f_25106_9562_9692(typeof(Blob), "Buffer", BindingFlags.NonPublic | BindingFlags.Instance), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 9413, 9736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 9752, 9796);

                return (byte[])f_25106_9767_9795(s_bufferField, blob);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 9342, 9807);

                System.Reflection.FieldInfo?
                f_25106_9562_9692(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 9562, 9692);
                    return return_v;
                }


                System.Reflection.FieldInfo?
                f_25106_9472_9720(ref System.Reflection.FieldInfo?
                location1, System.Reflection.FieldInfo?
                value, System.Reflection.FieldInfo?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 9472, 9720);
                    return return_v;
                }


                object?
                f_25106_9767_9795(System.Reflection.FieldInfo?
                this_param, System.Reflection.Metadata.Blob
                obj)
                {
                    var return_v = this_param.GetValue((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 9767, 9795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 9342, 9807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 9342, 9807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodInfo s_getContentToSignMethod;

        private static IEnumerable<Blob> GetContentToSign(
                    BlobBuilder peImage,
                    int peHeadersSize,
                    int peHeaderAlignment,
                    Blob strongNameSignatureFixup)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 9880, 10731);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 10101, 10460) || true) && (s_getContentToSignMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 10101, 10460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 10171, 10445);

                    f_25106_10171_10444(ref s_getContentToSignMethod, f_25106_10272_10416(typeof(PEBuilder), "GetContentToSign", BindingFlags.Static | BindingFlags.NonPublic), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 10101, 10460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 10476, 10720);

                return (IEnumerable<Blob>)f_25106_10502_10719(s_getContentToSignMethod, null, new object[]
                            {
                peImage,
                peHeadersSize,
                peHeaderAlignment,
                strongNameSignatureFixup
                            });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 9880, 10731);

                System.Reflection.MethodInfo?
                f_25106_10272_10416(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 10272, 10416);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_25106_10171_10444(ref System.Reflection.MethodInfo?
                location1, System.Reflection.MethodInfo?
                value, System.Reflection.MethodInfo?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 10171, 10444);
                    return return_v;
                }


                object?
                f_25106_10502_10719(System.Reflection.MethodInfo?
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 10502, 10719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 9880, 10731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 9880, 10731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static unsafe string GetMethodIL(this ImmutableArray<byte> ilArray)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 10743, 12317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 10842, 10875);

                var
                result = f_25106_10855_10874()
                ;
                fixed (byte*
    ilPtr = ilArray.ToArray()
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 10961, 10976);

                    int
                    offset = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 10994, 12250) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 10994, 12250);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11085, 11221) || true) && (offset < ilArray.Length && (DynAbs.Tracing.TraceSender.Expression_True(25106, 11092, 11139) && ilArray[offset] == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 11085, 11221);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11189, 11198);

                                    offset++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 11085, 11221);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 11085, 11221);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 11085, 11221);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11245, 11352) || true) && (offset == ilArray.Length)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 11245, 11352);
                                DynAbs.Tracing.TraceSender.TraceBreak(25106, 11323, 11329);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 11245, 11352);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11376, 11445);

                            var
                            reader = f_25106_11389_11444(ilPtr + offset, ilArray.Length - offset)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11467, 11513);

                            var
                            methodIL = f_25106_11482_11512(reader)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11537, 12231) || true) && (methodIL == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 11537, 12231);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11607, 11693);

                                f_25106_11607_11692(result, "<invalid byte 0x{0:X2} at offset {1}>", ilArray[offset], offset);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11719, 11728);

                                offset++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 11537, 12231);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 11537, 12231);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 11826, 12156);

                                f_25106_11826_12155(ILVisualizer.Default, result, f_25106_11925_11942(methodIL), f_25106_11973_11996(methodIL), f_25106_12027_12074(), f_25106_12105_12154());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 12184, 12208);

                                offset += f_25106_12194_12207(methodIL);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 11537, 12231);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 10994, 12250);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 10994, 12250);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 10994, 12250);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 12281, 12306);

                return f_25106_12288_12305(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 10743, 12317);

                System.Text.StringBuilder
                f_25106_10855_10874()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 10855, 10874);
                    return return_v;
                }


                unsafe System.Reflection.Metadata.BlobReader
                f_25106_11389_11444(byte*
                buffer, int
                length)
                {
                    var return_v = new System.Reflection.Metadata.BlobReader(buffer, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 11389, 11444);
                    return return_v;
                }


                System.Reflection.Metadata.MethodBodyBlock
                f_25106_11482_11512(System.Reflection.Metadata.BlobReader
                reader)
                {
                    var return_v = MethodBodyBlock.Create(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 11482, 11512);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25106_11607_11692(System.Text.StringBuilder
                this_param, string
                format, byte
                arg0, int
                arg1)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 11607, 11692);
                    return return_v;
                }


                int
                f_25106_11925_11942(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 11925, 11942);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25106_11973_11996(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.GetILContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 11973, 11996);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                f_25106_12027_12074()
                {
                    var return_v = ImmutableArray.Create<ILVisualizer.LocalInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 12027, 12074);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                f_25106_12105_12154()
                {
                    var return_v = ImmutableArray.Create<ILVisualizer.HandlerSpan>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 12105, 12154);
                    return return_v;
                }


                int
                f_25106_11826_12155(Microsoft.Metadata.Tools.ILVisualizer
                this_param, System.Text.StringBuilder
                sb, int
                maxStack, System.Collections.Immutable.ImmutableArray<byte>
                ilBytes, System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                exceptionHandlers)
                {
                    this_param.DumpMethod(sb, maxStack, ilBytes, locals, (System.Collections.Generic.IReadOnlyList<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>)exceptionHandlers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 11826, 12155);
                    return 0;
                }


                int
                f_25106_12194_12207(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.Size;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 12194, 12207);
                    return return_v;
                }


                string
                f_25106_12288_12305(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 12288, 12305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 10743, 12317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 10743, 12317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static unsafe MethodBodyBlock GetMethodBodyBlock(this ImmutableArray<byte> ilArray)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 12329, 12877);
                fixed (byte*
    ilPtr = ilArray.AsSpan()
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 12515, 12530);

                    int
                    offset = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 12582, 12706) || true) && (offset < ilArray.Length && (DynAbs.Tracing.TraceSender.Expression_True(25106, 12589, 12636) && ilArray[offset] == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 12582, 12706);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 12678, 12687);

                            offset++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 12582, 12706);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 12582, 12706);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 12582, 12706);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 12726, 12795);

                    var
                    reader = f_25106_12739_12794(ilPtr + offset, ilArray.Length - offset)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 12813, 12851);

                    return f_25106_12820_12850(reader);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 12329, 12877);

                unsafe System.Reflection.Metadata.BlobReader
                f_25106_12739_12794(byte*
                buffer, int
                length)
                {
                    var return_v = new System.Reflection.Metadata.BlobReader(buffer, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 12739, 12794);
                    return return_v;
                }


                System.Reflection.Metadata.MethodBodyBlock
                f_25106_12820_12850(System.Reflection.Metadata.BlobReader
                reader)
                {
                    var return_v = MethodBodyBlock.Create(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 12820, 12850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 12329, 12877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 12329, 12877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Dictionary<int, string> GetSequencePointMarkers(string pdbXml, string source = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 12889, 16346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13012, 13063);

                var doc = new XmlDocument() { XmlResolver = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (XmlResolver)null, 25106, 13022, 13062) };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13077, 13249);
                using (var
                reader = new XmlTextReader(f_25106_13115_13139(pdbXml)) { DtdProcessing = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DtdProcessing.Prohibit, 25106, 13097, 13183) }
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13217, 13234);

                    f_25106_13217_13233(doc, reader);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25106, 13077, 13249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13265, 13308);

                var
                result = f_25106_13278_13307()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13324, 16305) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 13324, 16305);

                    static void Add(Dictionary<int, string> dict, int key, string value)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25106, 13466, 13541);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13469, 13541);

                            // LAFHIS
                            DynAbs.Tracing.TraceSender.Conditional_F1(25106, 13481, 13517);
                            dict[key] = ((f_25106_13481_13517(dict, key, out var found) && DynAbs.Tracing.TraceSender.Conditional_F2(25106, 13520, 13533)) || 
                                DynAbs.Tracing.TraceSender.Conditional_F3(25106, 13536, 13541)) ? found + value : value; 
                            
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25106, 13466, 13541);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 13466, 13541);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 13466, 13541);
                        }
                    }


                    int
                    f_25106_14592_14658(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        Add(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14592, 14658);
                        return 0;
                    }


                    int
                    f_25106_14378_14444(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        Add(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14378, 14444);
                        return 0;
                    }


                    int
                    f_25106_14282_14347(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        Add(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14282, 14347);
                        return 0;
                    }


                    int
                    f_25106_13766_13938(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        Add(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13766, 13938);
                        return 0;
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13562, 13981);
                        foreach (XmlNode entry in f_25106_13588_13630_I(f_25106_13588_13630(doc, "sequencePoints")))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 13562, 13981);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13672, 13962);
                                foreach (XmlElement item in f_25106_13700_13716_I(f_25106_13700_13716(entry)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 13672, 13962);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 13766, 13939);

                                    f_25106_13766_13938(result, f_25106_13807_13855(f_25106_13823_13850(item, "offset"), 16), (DynAbs.Tracing.TraceSender.Conditional_F1(25106, 13886, 13925) || (((f_25106_13887_13914(item, "hidden") == "true") && DynAbs.Tracing.TraceSender.Conditional_F2(25106, 13928, 13931)) || DynAbs.Tracing.TraceSender.Conditional_F3(25106, 13934, 13937))) ? "~" : "-");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 13672, 13962);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 291);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 291);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 13562, 13981);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 420);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 420);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14001, 14728);
                        foreach (XmlNode entry in f_25106_14027_14064_I(f_25106_14027_14064(doc, "asyncInfo")))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 14001, 14728);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14106, 14709);
                                foreach (XmlElement item in f_25106_14134_14150_I(f_25106_14134_14150(entry)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 14106, 14709);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14200, 14686) || true) && (f_25106_14204_14213(item) == "await")
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 14200, 14686);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14282, 14348);

                                        f_25106_14282_14347(result, f_25106_14294_14341(f_25106_14310_14336(item, "yield"), 16), "<");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14378, 14445);

                                        f_25106_14378_14444(result, f_25106_14390_14438(f_25106_14406_14433(item, "resume"), 16), ">");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 14200, 14686);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 14200, 14686);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14503, 14686) || true) && (f_25106_14507_14516(item) == "catchHandler")
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 14503, 14686);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14592, 14659);

                                            f_25106_14592_14658(result, f_25106_14604_14652(f_25106_14620_14647(item, "offset"), 16), "$");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 14503, 14686);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 14200, 14686);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 14106, 14709);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 604);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 604);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 14001, 14728);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 728);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 728);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 13324, 16305);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 13324, 16305);

                    static void AddTextual(Dictionary<int, string> dict, int key, string value)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(25106, 14891, 14981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 14894, 14981);
                            DynAbs.Tracing.TraceSender.Conditional_F1(25106, 14906, 14942);
                            dict[key] = ((f_25106_14906_14942(dict, key, out var found) && DynAbs.Tracing.TraceSender.Conditional_F2(25106, 14945, 14965)) || 
                                DynAbs.Tracing.TraceSender.Conditional_F3(25106, 14968, 14981)) ? found + ", " + value : "// " + value; 
                            DynAbs.Tracing.TraceSender.TraceExitMethod(25106, 14891, 14981);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 14891, 14981);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 14891, 14981);
                        }
                    }




                    int
                    f_25106_16122_16247(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        AddTextual(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16122, 16247);
                        return 0;
                    }


                    int
                    f_25106_15630_15722(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        AddTextual(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15630, 15722);
                        return 0;
                    }


                    int
                    f_25106_15397_15482(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        AddTextual(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15397, 15482);
                        return 0;
                    }


                    int
                    f_25106_15283_15366(System.Collections.Generic.Dictionary<int, string>
                    dict, int
                    key, string
                    value)
                    {
                        AddTextual(dict, key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15283, 15366);
                        return 0;
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15002, 15792);
                        foreach (XmlNode entry in f_25106_15028_15065_I(f_25106_15028_15065(doc, "asyncInfo")))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 15002, 15792);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15107, 15773);
                                foreach (XmlElement item in f_25106_15135_15151_I(f_25106_15135_15151(entry)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 15107, 15773);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15201, 15750) || true) && (f_25106_15205_15214(item) == "await")
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 15201, 15750);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15283, 15367);

                                        f_25106_15283_15366(result, f_25106_15302_15349(f_25106_15318_15344(item, "yield"), 16), "async: yield");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15397, 15483);

                                        f_25106_15397_15482(result, f_25106_15416_15464(f_25106_15432_15459(item, "resume"), 16), "async: resume");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 15201, 15750);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 15201, 15750);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15541, 15750) || true) && (f_25106_15545_15554(item) == "catchHandler")
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 15541, 15750);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15630, 15723);

                                            f_25106_15630_15722(result, f_25106_15649_15697(f_25106_15665_15692(item, "offset"), 16), "async: catch handler");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 15541, 15750);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 15201, 15750);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 15107, 15773);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 667);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 667);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 15002, 15792);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 791);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 791);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15812, 15898);

                    var
                    sourceLines = f_25106_15830_15897(source, new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 15918, 16290);
                        foreach (XmlNode entry in f_25106_15944_15986_I(f_25106_15944_15986(doc, "sequencePoints")))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 15918, 16290);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16028, 16271);
                                foreach (XmlElement item in f_25106_16056_16072_I(f_25106_16056_16072(entry)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 16028, 16271);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16122, 16248);

                                    f_25106_16122_16247(result, f_25106_16141_16189(f_25106_16157_16184(item, "offset"), 16), "sequence point: " + f_25106_16212_16246(sourceLines, item));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 16028, 16271);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 244);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 244);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 15918, 16290);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25106, 1, 373);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25106, 1, 373);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 13324, 16305);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16321, 16335);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 12889, 16346);

                System.IO.StringReader
                f_25106_13115_13139(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13115, 13139);
                    return return_v;
                }


                int
                f_25106_13217_13233(System.Xml.XmlDocument
                this_param, System.Xml.XmlTextReader
                reader)
                {
                    this_param.Load((System.Xml.XmlReader)reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13217, 13233);
                    return 0;
                }


                System.Collections.Generic.Dictionary<int, string>
                f_25106_13278_13307()
                {
                    var return_v = new System.Collections.Generic.Dictionary<int, string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13278, 13307);
                    return return_v;
                }


                static bool
                f_25106_13481_13517(System.Collections.Generic.Dictionary<int, string>
                this_param, int
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13481, 13517);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_13588_13630(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.GetElementsByTagName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13588, 13630);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_13700_13716(System.Xml.XmlNode?
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 13700, 13716);
                    return return_v;
                }


                string
                f_25106_13823_13850(System.Xml.XmlElement?
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13823, 13850);
                    return return_v;
                }


                int
                f_25106_13807_13855(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13807, 13855);
                    return return_v;
                }


                string
                f_25106_13887_13914(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13887, 13914);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_13700_13716_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13700, 13716);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_13588_13630_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 13588, 13630);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_14027_14064(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.GetElementsByTagName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14027, 14064);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_14134_14150(System.Xml.XmlNode?
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 14134, 14150);
                    return return_v;
                }


                string
                f_25106_14204_14213(System.Xml.XmlElement?
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 14204, 14213);
                    return return_v;
                }


                string
                f_25106_14310_14336(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14310, 14336);
                    return return_v;
                }


                int
                f_25106_14294_14341(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14294, 14341);
                    return return_v;
                }


                string
                f_25106_14406_14433(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14406, 14433);
                    return return_v;
                }


                int
                f_25106_14390_14438(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14390, 14438);
                    return return_v;
                }


                string
                f_25106_14507_14516(System.Xml.XmlElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 14507, 14516);
                    return return_v;
                }


                string
                f_25106_14620_14647(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14620, 14647);
                    return return_v;
                }


                int
                f_25106_14604_14652(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14604, 14652);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_14134_14150_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14134, 14150);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_14027_14064_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14027, 14064);
                    return return_v;
                }


                static bool
                f_25106_14906_14942(System.Collections.Generic.Dictionary<int, string>
                this_param, int
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 14906, 14942);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_15028_15065(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.GetElementsByTagName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15028, 15065);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_15135_15151(System.Xml.XmlNode?
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 15135, 15151);
                    return return_v;
                }


                string
                f_25106_15205_15214(System.Xml.XmlElement?
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 15205, 15214);
                    return return_v;
                }


                string
                f_25106_15318_15344(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15318, 15344);
                    return return_v;
                }


                int
                f_25106_15302_15349(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15302, 15349);
                    return return_v;
                }


                string
                f_25106_15432_15459(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15432, 15459);
                    return return_v;
                }


                int
                f_25106_15416_15464(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15416, 15464);
                    return return_v;
                }


                string
                f_25106_15545_15554(System.Xml.XmlElement
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 15545, 15554);
                    return return_v;
                }


                string
                f_25106_15665_15692(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15665, 15692);
                    return return_v;
                }


                int
                f_25106_15649_15697(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15649, 15697);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_15135_15151_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15135, 15151);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_15028_15065_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15028, 15065);
                    return return_v;
                }


                string[]
                f_25106_15830_15897(string
                this_param, string[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15830, 15897);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_15944_15986(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.GetElementsByTagName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15944, 15986);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_16056_16072(System.Xml.XmlNode?
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 16056, 16072);
                    return return_v;
                }


                string
                f_25106_16157_16184(System.Xml.XmlElement?
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16157, 16184);
                    return return_v;
                }


                int
                f_25106_16141_16189(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16141, 16189);
                    return return_v;
                }


                string
                f_25106_16212_16246(string[]
                lines, System.Xml.XmlElement
                span)
                {
                    var return_v = SnippetFromSpan(lines, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16212, 16246);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_16056_16072_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16056, 16072);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_25106_15944_15986_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 15944, 15986);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 12889, 16346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 12889, 16346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string SnippetFromSpan(string[] lines, XmlElement span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25106, 16358, 17615);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16453, 16561) || true) && (f_25106_16457_16484(span, "hidden") == "true")
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 16453, 16561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16528, 16546);

                    return "<hidden>";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 16453, 16561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16577, 16641);

                var
                startLine = f_25106_16593_16640(f_25106_16609_16639(span, "startLine"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16655, 16723);

                var
                startColumn = f_25106_16673_16722(f_25106_16689_16721(span, "startColumn"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16737, 16797);

                var
                endLine = f_25106_16751_16796(f_25106_16767_16795(span, "endLine"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16811, 16875);

                var
                endColumn = f_25106_16827_16874(f_25106_16843_16873(span, "endColumn"))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16889, 17042) || true) && (startLine == endLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25106, 16889, 17042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 16947, 17027);

                    return f_25106_16954_17026(lines[startLine - 1], startColumn - 1, endColumn - startColumn);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25106, 16889, 17042);
                }

                static string TruncateStart(string text, int maxLength)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25106, 17131, 17197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 17134, 17197);
                        return (DynAbs.Tracing.TraceSender.Conditional_F1(25106, 17134, 17159) || (((f_25106_17135_17146(text) < maxLength) && 
                            DynAbs.Tracing.TraceSender.Conditional_F2(25106, 17162, 17166)) || DynAbs.Tracing.TraceSender.Conditional_F3(25106, 17169, 17197))) ? 
                            text : f_25106_17169_17197(text, 0, maxLength); 
                        
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25106, 17131, 17197);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 17131, 17197);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 17131, 17197);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static string TruncateEnd(string text, int maxLength)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25106, 17285, 17377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 17288, 17377);
                        return (DynAbs.Tracing.TraceSender.Conditional_F1(25106, 17288, 17313) || (((f_25106_17289_17300(text) < maxLength) && 
                            DynAbs.Tracing.TraceSender.Conditional_F2(25106, 17316, 17320)) || 
                            DynAbs.Tracing.TraceSender.Conditional_F3(25106, 17323, 17377))) ? text : 
                            f_25106_17323_17377(text, f_25106_17338_17349(text) - maxLength - 1, maxLength); 
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25106, 17285, 17377);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 17285, 17377);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 17285, 17377);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 17394, 17454);

                var
                start = f_25106_17406_17453(lines[startLine - 1], startColumn - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 17468, 17525);

                var
                end = f_25106_17478_17524(lines[endLine - 1], 0, endColumn - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 17539, 17604);

                return f_25106_17546_17570(start, 12) + " ... " + f_25106_17583_17603(end, 12);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25106, 16358, 17615);

                string
                f_25106_16457_16484(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16457, 16484);
                    return return_v;
                }


                string
                f_25106_16609_16639(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16609, 16639);
                    return return_v;
                }


                int
                f_25106_16593_16640(string
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16593, 16640);
                    return return_v;
                }


                string
                f_25106_16689_16721(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16689, 16721);
                    return return_v;
                }


                int
                f_25106_16673_16722(string
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16673, 16722);
                    return return_v;
                }


                string
                f_25106_16767_16795(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16767, 16795);
                    return return_v;
                }


                int
                f_25106_16751_16796(string
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16751, 16796);
                    return return_v;
                }


                string
                f_25106_16843_16873(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16843, 16873);
                    return return_v;
                }


                int
                f_25106_16827_16874(string
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16827, 16874);
                    return return_v;
                }


                string
                f_25106_16954_17026(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 16954, 17026);
                    return return_v;
                }


                static int
                f_25106_17135_17146(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 17135, 17146);
                    return return_v;
                }


                static string
                f_25106_17169_17197(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 17169, 17197);
                    return return_v;
                }


                static int
                f_25106_17289_17300(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 17289, 17300);
                    return return_v;
                }


                static int
                f_25106_17338_17349(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25106, 17338, 17349);
                    return return_v;
                }


                static string
                f_25106_17323_17377(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 17323, 17377);
                    return return_v;
                }


                string
                f_25106_17406_17453(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 17406, 17453);
                    return return_v;
                }


                string
                f_25106_17478_17524(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 17478, 17524);
                    return return_v;
                }


                string
                f_25106_17546_17570(string
                text, int
                maxLength)
                {
                    var return_v = TruncateStart(text, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 17546, 17570);
                    return return_v;
                }


                string
                f_25106_17583_17603(string
                text, int
                maxLength)
                {
                    var return_v = TruncateEnd(text, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25106, 17583, 17603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25106, 16358, 17615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 16358, 17615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ILValidation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25106, 716, 17622);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 783, 804);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 8194, 8214);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 8775, 8785);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 9318, 9331);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25106, 9845, 9869);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25106, 716, 17622);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25106, 716, 17622);
        }

    }
}
