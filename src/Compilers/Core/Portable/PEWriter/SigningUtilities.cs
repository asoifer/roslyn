// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class SigningUtilities
    {
        internal static byte[] CalculateRsaSignature(IEnumerable<Blob> content, RSAParameters privateKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(514, 597, 1073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 719, 753);

                var
                hash = f_514_730_752(content)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 769, 1062);
                using (var
                rsa = f_514_786_798()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 832, 865);

                    f_514_832_864(rsa, privateKey);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 883, 969);

                    var
                    signature = f_514_899_968(rsa, hash, HashAlgorithmName.SHA1, f_514_942_967())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 987, 1012);

                    f_514_987_1011(signature);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1030, 1047);

                    return signature;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(514, 769, 1062);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(514, 597, 1073);

                byte[]
                f_514_730_752(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>
                content)
                {
                    var return_v = CalculateSha1(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 730, 752);
                    return return_v;
                }


                System.Security.Cryptography.RSA
                f_514_786_798()
                {
                    var return_v = RSA.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 786, 798);
                    return return_v;
                }


                int
                f_514_832_864(System.Security.Cryptography.RSA
                this_param, System.Security.Cryptography.RSAParameters
                parameters)
                {
                    this_param.ImportParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 832, 864);
                    return 0;
                }


                System.Security.Cryptography.RSASignaturePadding
                f_514_942_967()
                {
                    var return_v = RSASignaturePadding.Pkcs1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 942, 967);
                    return return_v;
                }


                byte[]
                f_514_899_968(System.Security.Cryptography.RSA
                this_param, byte[]
                hash, System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm, System.Security.Cryptography.RSASignaturePadding
                padding)
                {
                    var return_v = this_param.SignHash(hash, hashAlgorithm, padding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 899, 968);
                    return return_v;
                }


                int
                f_514_987_1011(byte[]
                array)
                {
                    Array.Reverse(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 987, 1011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(514, 597, 1073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(514, 597, 1073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static byte[] CalculateSha1(IEnumerable<Blob> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(514, 1085, 1374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1173, 1363);
                using (var
                hash = f_514_1191_1241(HashAlgorithmName.SHA1)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1275, 1300);

                    f_514_1275_1299(hash, content);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1318, 1348);

                    return f_514_1325_1347(hash);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(514, 1173, 1363);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(514, 1085, 1374);

                System.Security.Cryptography.IncrementalHash
                f_514_1191_1241(System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm)
                {
                    var return_v = IncrementalHash.CreateHash(hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 1191, 1241);
                    return return_v;
                }


                int
                f_514_1275_1299(System.Security.Cryptography.IncrementalHash
                hash, System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>
                blobs)
                {
                    hash.AppendData(blobs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 1275, 1299);
                    return 0;
                }


                byte[]
                f_514_1325_1347(System.Security.Cryptography.IncrementalHash
                this_param)
                {
                    var return_v = this_param.GetHashAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(514, 1325, 1347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(514, 1085, 1374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(514, 1085, 1374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CalculateStrongNameSignatureSize(CommonPEModuleBuilder module, RSAParameters? privateKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(514, 1386, 2501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1520, 1587);

                ISourceAssemblySymbolInternal?
                assembly = f_514_1562_1586(module)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1601, 1703) || true) && (assembly == null && (DynAbs.Tracing.TraceSender.Expression_True(514, 1605, 1645) && f_514_1625_1645_M(!privateKey.HasValue)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(514, 1601, 1703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1679, 1688);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(514, 1601, 1703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1719, 1735);

                int
                keySize = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1877, 2043) || true) && (keySize == 0 && (DynAbs.Tracing.TraceSender.Expression_True(514, 1881, 1913) && assembly != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(514, 1877, 2043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 1947, 2028);

                    keySize = (DynAbs.Tracing.TraceSender.Conditional_F1(514, 1957, 1988) || (((f_514_1958_1979(assembly) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(514, 1991, 1992)) || DynAbs.Tracing.TraceSender.Conditional_F3(514, 1995, 2027))) ? 0 : f_514_1995_2023(f_514_1995_2016(assembly)) / 2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(514, 1877, 2043);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 2059, 2189) || true) && (keySize == 0 && (DynAbs.Tracing.TraceSender.Expression_True(514, 2063, 2095) && assembly != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(514, 2059, 2189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 2129, 2174);

                    keySize = f_514_2139_2156(assembly).PublicKey.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(514, 2059, 2189);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 2205, 2335) || true) && (keySize == 0 && (DynAbs.Tracing.TraceSender.Expression_True(514, 2209, 2244) && privateKey.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(514, 2205, 2335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 2278, 2320);

                    keySize = f_514_2288_2319(privateKey.Value.Modulus);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(514, 2205, 2335);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 2351, 2425) || true) && (keySize == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(514, 2351, 2425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 2401, 2410);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(514, 2351, 2425);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(514, 2441, 2490);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(514, 2448, 2468) || (((keySize < 128 + 32) && DynAbs.Tracing.TraceSender.Conditional_F2(514, 2471, 2474)) || DynAbs.Tracing.TraceSender.Conditional_F3(514, 2477, 2489))) ? 128 : keySize - 32;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(514, 1386, 2501);

                Microsoft.CodeAnalysis.Symbols.ISourceAssemblySymbolInternal
                f_514_1562_1586(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.SourceAssemblyOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 1562, 1586);
                    return return_v;
                }


                bool
                f_514_1625_1645_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 1625, 1645);
                    return return_v;
                }


                string?
                f_514_1958_1979(Microsoft.CodeAnalysis.Symbols.ISourceAssemblySymbolInternal
                this_param)
                {
                    var return_v = this_param.SignatureKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 1958, 1979);
                    return return_v;
                }


                string
                f_514_1995_2016(Microsoft.CodeAnalysis.Symbols.ISourceAssemblySymbolInternal
                this_param)
                {
                    var return_v = this_param.SignatureKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 1995, 2016);
                    return return_v;
                }


                int
                f_514_1995_2023(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 1995, 2023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_514_2139_2156(Microsoft.CodeAnalysis.Symbols.ISourceAssemblySymbolInternal
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 2139, 2156);
                    return return_v;
                }


                int
                f_514_2288_2319(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(514, 2288, 2319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(514, 1386, 2501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(514, 1386, 2501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SigningUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(514, 542, 2508);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(514, 542, 2508);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(514, 542, 2508);
        }

    }
}
